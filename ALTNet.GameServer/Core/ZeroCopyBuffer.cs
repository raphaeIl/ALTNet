using Serilog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LZ4;

namespace ALTNet.GameServer.Core
{
    public sealed class SimpleObjectPool<T>
    {
        
        public SimpleObjectPool(Func<T> factoryMethod)
        {
            this.factoryMethod = factoryMethod;
        }
        
        public T CreateInstance()
        {
            T result;
            if (this.objects.TryDequeue(out result))
            {
                return result;
            }
            return this.factoryMethod();
        }

        
        public void ToRecycleBin(T item)
        {
            this.objects.Enqueue(item);
        }

        
        private readonly ConcurrentQueue<T> objects = new ConcurrentQueue<T>();

        
        private readonly Func<T> factoryMethod;
    }

    internal sealed class TailBuffer
    {
        
        private TailBuffer()
        {
        }

        
        
        public byte[] Data
        {
            get
            {
                return this.data;
            }
        }

        
        
        public int Offset
        {
            get
            {
                return this.size;
            }
        }

        
        
        public bool IsFull
        {
            get
            {
                return this.data.Length == this.size;
            }
        }

        
        public static TailBuffer Create()
        {
            return TailBuffer.pool.CreateInstance();
        }

        
        public static TailBuffer Create(byte[] data, int offset, int size)
        {
            TailBuffer tailBuffer = TailBuffer.pool.CreateInstance();
            tailBuffer.FillData(data, offset, size);
            return tailBuffer;
        }

        
        public int AddData(byte[] data, int offset, int size)
        {
            int num = Math.Min(this.data.Length - this.size, size);
            Buffer.BlockCopy(data, offset, this.data, this.size, num);
            this.size += num;
            return num;
        }

        
        public void ToRecycleBin()
        {
            this.size = 0;
            TailBuffer.pool.ToRecycleBin(this);
        }

        
        private void FillData(byte[] data, int offset, int size)
        {
            this.size = Math.Min(this.data.Length, size);
            Buffer.BlockCopy(data, offset, this.data, 0, this.size);
        }

        
        private const int BufferSize = 4096;

        
        private static SimpleObjectPool<TailBuffer> pool = new SimpleObjectPool<TailBuffer>(() => new TailBuffer());

        
        private readonly byte[] data = new byte[4096];

        
        private int size;
    }

    public sealed class ZeroCopyBuffer
    {
        public int SegmentCount
        {
            get
            {
                return this.tailBuffers.Count;
            }
        }
        
        public int CalcTotalSize()
        {
            int num = 0;
            foreach (TailBuffer tailBuffer in this.tailBuffers)
            {
                num += tailBuffer.Offset;
            }
            return num;
        }
        
        public BinaryWriter GetWriter()
        {
            return new BinaryWriter(new ZeroCopyOutputStream(this));
        }
        
        public BinaryReader GetReader()
        {
            return new BinaryReader(new ZeroCopyInputStream(this));
        }

        
        public Stream GetOutputStream()
        {
            return new ZeroCopyOutputStream(this);
        }

        
        public IDisposable Hold()
        {
            return new ZeroCopyBuffer.Cleaner(this);
        }


        public void Lz4Compress()
        {
            TailBuffer[] array = this.Move();
            using (ZeroCopyOutputStream zeroCopyOutputStream = new ZeroCopyOutputStream(this))
            {
                using (LZ4Stream lz4Stream = new LZ4Stream(zeroCopyOutputStream, LZ4StreamMode.Compress, LZ4StreamFlags.None, 1048576))
                {
                    foreach (TailBuffer tailBuffer in array)
                    {
                        lz4Stream.Write(tailBuffer.Data, 0, tailBuffer.Offset);
                        tailBuffer.ToRecycleBin();
                    }
                }
            }
        }

        public void Encrypt()
        {
            if (this.tailBuffers.Count > 1)
            {
                throw new Exception(string.Format("[ZeroCopyBuffer] encryption only support single tail. #tail:{0}", this.tailBuffers.Count));
            }
            if (this.tailBuffers.Count == 0)
            {
                return;
            }
            int num = 0;
            Crypto.Encrypt(this.last.Data, this.last.Offset, ref num);
        }
        
        internal TailBuffer Peek()
        {
            return this.tailBuffers.Peek();
        }
        
        internal void PopHeadSegment()
        {
            this.tailBuffers.Dequeue().ToRecycleBin();
            if (this.tailBuffers.Count == 0)
            {
                this.last = null;
            }
        }

        
        internal void Write(byte[] buffer, int offset, int count)
        {
            while (count > 0)
            {
                if (this.last == null || this.last.IsFull)
                {
                    this.last = TailBuffer.Create();
                    this.tailBuffers.Enqueue(this.last);
                }
                int num = this.last.AddData(buffer, offset, count);
                offset += num;
                count -= num;
            }
        }

        
        internal TailBuffer[] Move()
        {
            TailBuffer[] result = this.tailBuffers.ToArray();
            this.tailBuffers.Clear();
            this.last = null;
            return result;
        }

        
        internal TailBuffer[] GetView()
        {
            return this.tailBuffers.ToArray();
        }

        
        public string ToBase64()
        {
            if (this.tailBuffers.Count > 1)
            {
                throw new Exception(string.Format("[ZeroCopyBuffer] ToBase64 only support single tail. #tail:{0}", this.tailBuffers.Count));
            }
            return Convert.ToBase64String(this.last.Data, 0, this.last.Offset);
        }

        
        private readonly Queue<TailBuffer> tailBuffers = new Queue<TailBuffer>();
        
        private TailBuffer last;
        
        private sealed class Cleaner : IDisposable
        {
            
            public Cleaner(ZeroCopyBuffer buffer)
            {
                this.buffer = buffer;
            }

            
            public void Dispose()
            {
                foreach (TailBuffer tailBuffer in this.buffer.tailBuffers)
                {
                    tailBuffer.ToRecycleBin();
                }
                this.buffer.tailBuffers.Clear();
                this.buffer.last = null;
            }

            
            private readonly ZeroCopyBuffer buffer;
        }
    }

    internal sealed class ZeroCopyOutputStream : Stream
    {
        
        public ZeroCopyOutputStream(ZeroCopyBuffer buffer)
        {
            this.buffer = buffer;
        }

        
        
        public override bool CanRead
        {
            get
            {
                return false;
            }
        }

        
        
        public override bool CanSeek
        {
            get
            {
                return false;
            }
        }

        
        
        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        
        
        public override long Length
        {
            get
            {
                return (long)this.buffer.CalcTotalSize();
            }
        }

        
        
        
        public override long Position
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        
        public override void Flush()
        {
        }

        
        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        
        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        
        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        
        public override void Write(byte[] buffer, int offset, int count)
        {
            this.buffer.Write(buffer, offset, count);
        }

        
        private readonly ZeroCopyBuffer buffer;
    }

    public sealed class ZeroCopyInputStream : Stream
    {
        
        public ZeroCopyInputStream(ZeroCopyBuffer buffer)
        {
            this.tailBuffers = buffer.GetView();
            this.totalSize = buffer.CalcTotalSize();
            this.Length = (long)this.totalSize;
        }

        
        public ZeroCopyInputStream(ZeroCopyBuffer buffer, int fixedOffset)
        {
            this.tailBuffers = buffer.GetView();
            this.totalSize = buffer.CalcTotalSize();
            if (fixedOffset < 0 || fixedOffset > this.totalSize)
            {
                throw new Exception(string.Format("[ZeroCopyInputStream] invalid offset. fixed:{0} length:{1}", fixedOffset, this.Length));
            }
            this.fixedOffset = fixedOffset;
            this.Length = (long)(this.totalSize - this.fixedOffset);
            this.ResetOffset(this.fixedOffset);
        }

        
        
        public override bool CanRead
        {
            get
            {
                return this.IsReadable();
            }
        }

        
        
        public override bool CanSeek
        {
            get
            {
                return false;
            }
        }

        
        
        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }

        
        
        public override long Length { get; }

        
        
        
        public override long Position
        {
            get
            {
                return (long)(this.CalcCurrentFullOffset() - this.fixedOffset);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        
        public override void Flush()
        {
        }

        
        public override int Read(byte[] buffer, int offset, int count)
        {
            int num = 0;
            while (this.CanRead)
            {
                TailBuffer tailBuffer = this.tailBuffers[this.index];
                if (this.offset > tailBuffer.Offset)
                {
                    throw new Exception(string.Format("memory offset error. this.offset:{0} buffer offset:{1}", this.offset, tailBuffer.Offset));
                }
                if (this.offset == tailBuffer.Offset)
                {
                    this.index++;
                    this.offset = 0;
                } else
                {
                    int num2 = Math.Min(count - num, tailBuffer.Offset - this.offset);
                    Buffer.BlockCopy(tailBuffer.Data, this.offset, buffer, offset + num, num2);
                    this.offset += num2;
                    num += num2;
                    if (num > count)
                    {
                        throw new Exception(string.Format("memory offset error. transferred:{0} count:{1}", num, count));
                    }
                    if (num == count)
                    {
                        break;
                    }
                }
            }
            return num;
        }

        
        public override long Seek(long offset, SeekOrigin origin)
        {
            int num = 0;
            switch (origin)
            {
                case SeekOrigin.Begin:
                    num = this.fixedOffset + (int)offset;
                    break;
                case SeekOrigin.Current:
                    num = this.CalcCurrentFullOffset() + (int)offset;
                    break;
                case SeekOrigin.End:
                    num = (int)(this.Length - offset);
                    break;
            }
            this.ResetOffset(num);
            return (long)num;
        }

        
        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        
        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        
        private void ResetOffset(int offset)
        {
            if (offset > this.totalSize)
            {
                throw new Exception(string.Format("[ZeroCopyInputStream] invalid offset:{0} length:{1}", offset, this.totalSize));
            }
            this.index = 0;
            this.offset = offset;
            for (int i = 0; i < this.tailBuffers.Length; i++)
            {
                TailBuffer tailBuffer = this.tailBuffers[i];
                if (this.offset < tailBuffer.Offset)
                {
                    break;
                }
                this.index++;
                this.offset -= tailBuffer.Offset;
            }
            if (this.index >= this.tailBuffers.Length && this.offset > 0)
            {
                throw new Exception(string.Format("index:{0} buffers:{1} offset:{2}", this.index, this.tailBuffers.Length, this.offset));
            }
        }

        
        private bool IsReadable()
        {
            if (this.tailBuffers.Length == 0)
            {
                return false;
            }
            if (this.index < this.tailBuffers.Length)
            {
                return this.index < this.tailBuffers.Length || this.offset < this.tailBuffers[this.index].Offset;
            }
            if (this.offset == 0)
            {
                return false;
            }
            throw new Exception(string.Format("invalid index:{0} #buffer:{1} offset:{2}", this.index, this.tailBuffers.Length, this.offset));
        }

        
        private int CalcCurrentFullOffset()
        {
            int num = this.offset;
            for (int i = 0; i < this.index; i++)
            {
                num += this.tailBuffers[i].Offset;
            }
            return num;
        }

        
        private readonly TailBuffer[] tailBuffers;

        
        private readonly int totalSize;

        
        private readonly int fixedOffset;

        
        private int index;

        
        private int offset;
    }
}
