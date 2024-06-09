using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTNet.GameServer.Packets
{
    public sealed class SimpleObjectPool<T>
    {
        // Token: 0x0600CB28 RID: 52008 RVA: 0x000899CA File Offset: 0x00087BCA
        public SimpleObjectPool(Func<T> factoryMethod)
        {
            this.factoryMethod = factoryMethod;
        }

        // Token: 0x0600CB29 RID: 52009 RVA: 0x003B1194 File Offset: 0x003AF394
        public T CreateInstance()
        {
            T result;
            if (this.objects.TryDequeue(out result))
            {
                return result;
            }
            return this.factoryMethod();
        }

        // Token: 0x0600CB2A RID: 52010 RVA: 0x000899E4 File Offset: 0x00087BE4
        public void ToRecycleBin(T item)
        {
            this.objects.Enqueue(item);
        }

        // Token: 0x0400BE29 RID: 48681
        private readonly ConcurrentQueue<T> objects = new ConcurrentQueue<T>();

        // Token: 0x0400BE2A RID: 48682
        private readonly Func<T> factoryMethod;
    }

    internal sealed class TailBuffer
    {
        // Token: 0x0600CAFF RID: 51967 RVA: 0x00089888 File Offset: 0x00087A88
        private TailBuffer()
        {
        }

        // Token: 0x17001BD8 RID: 7128
        // (get) Token: 0x0600CB00 RID: 51968 RVA: 0x000898A0 File Offset: 0x00087AA0
        public byte[] Data
        {
            get
            {
                return this.data;
            }
        }

        // Token: 0x17001BD9 RID: 7129
        // (get) Token: 0x0600CB01 RID: 51969 RVA: 0x000898A8 File Offset: 0x00087AA8
        public int Offset
        {
            get
            {
                return this.size;
            }
        }

        // Token: 0x17001BDA RID: 7130
        // (get) Token: 0x0600CB02 RID: 51970 RVA: 0x000898B0 File Offset: 0x00087AB0
        public bool IsFull
        {
            get
            {
                return this.data.Length == this.size;
            }
        }

        // Token: 0x0600CB03 RID: 51971 RVA: 0x000898C2 File Offset: 0x00087AC2
        public static TailBuffer Create()
        {
            return TailBuffer.pool.CreateInstance();
        }

        // Token: 0x0600CB04 RID: 51972 RVA: 0x000898CE File Offset: 0x00087ACE
        public static TailBuffer Create(byte[] data, int offset, int size)
        {
            TailBuffer tailBuffer = TailBuffer.pool.CreateInstance();
            tailBuffer.FillData(data, offset, size);
            return tailBuffer;
        }

        // Token: 0x0600CB05 RID: 51973 RVA: 0x003B0DE8 File Offset: 0x003AEFE8
        public int AddData(byte[] data, int offset, int size)
        {
            int num = Math.Min(this.data.Length - this.size, size);
            Buffer.BlockCopy(data, offset, this.data, this.size, num);
            this.size += num;
            return num;
        }

        // Token: 0x0600CB06 RID: 51974 RVA: 0x000898E3 File Offset: 0x00087AE3
        public void ToRecycleBin()
        {
            this.size = 0;
            TailBuffer.pool.ToRecycleBin(this);
        }

        // Token: 0x0600CB07 RID: 51975 RVA: 0x000898F7 File Offset: 0x00087AF7
        private void FillData(byte[] data, int offset, int size)
        {
            this.size = Math.Min(this.data.Length, size);
            Buffer.BlockCopy(data, offset, this.data, 0, this.size);
        }

        // Token: 0x0400BE1D RID: 48669
        private const int BufferSize = 4096;

        // Token: 0x0400BE1E RID: 48670
        private static SimpleObjectPool<TailBuffer> pool = new SimpleObjectPool<TailBuffer>(() => new TailBuffer());

        // Token: 0x0400BE1F RID: 48671
        private readonly byte[] data = new byte[4096];

        // Token: 0x0400BE20 RID: 48672
        private int size;
    }



    public sealed class ZeroCopyBuffer
    {
        private readonly Queue<TailBuffer> tailBuffers = new Queue<TailBuffer>();

        // Token: 0x0400BE10 RID: 48656
        private TailBuffer last;

        internal TailBuffer[] GetView()
        {
            return this.tailBuffers.ToArray();
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
        // Token: 0x02001C95 RID: 7317
        private sealed class Cleaner : IDisposable
        {
            // Token: 0x0600CAEA RID: 51946 RVA: 0x00089813 File Offset: 0x00087A13
            public Cleaner(ZeroCopyBuffer buffer)
            {
                this.buffer = buffer;
            }

            // Token: 0x0600CAEB RID: 51947 RVA: 0x003B09AC File Offset: 0x003AEBAC
            public void Dispose()
            {
                foreach (TailBuffer tailBuffer in this.buffer.tailBuffers)
                {
                    tailBuffer.ToRecycleBin();
                }
                this.buffer.tailBuffers.Clear();
                this.buffer.last = null;
            }

            // Token: 0x0400BE11 RID: 48657
            private readonly ZeroCopyBuffer buffer;
        }
        // Token: 0x17001BD2 RID: 7122
        // (get) Token: 0x0600CAD9 RID: 51929 RVA: 0x0008976A File Offset: 0x0008796A
        public int SegmentCount
        {
            get
            {
                return this.tailBuffers.Count;
            }
        }

        // Token: 0x0600CADA RID: 51930 RVA: 0x003B0614 File Offset: 0x003AE814
        public int CalcTotalSize()
        {
            int num = 0;
            foreach (TailBuffer tailBuffer in this.tailBuffers)
            {
                num += tailBuffer.Offset;
            }
            return num;
        }

        // Token: 0x0600CADB RID: 51931 RVA: 0x00089777 File Offset: 0x00087977
        public BinaryWriter GetWriter()
        {
            return new BinaryWriter(new ZeroCopyOutputStream(this));
        }

        // Token: 0x0600CADC RID: 51932 RVA: 0x00089784 File Offset: 0x00087984
        public BinaryReader GetReader()
        {
            return new BinaryReader(new ZeroCopyInputStream(this));
        }

        // Token: 0x0600CADD RID: 51933 RVA: 0x00089791 File Offset: 0x00087991
        public Stream GetOutputStream()
        {
            return new ZeroCopyOutputStream(this);
        }
    }

    internal sealed class ZeroCopyOutputStream : Stream
    {
        // Token: 0x0600CB1C RID: 51996 RVA: 0x0008999D File Offset: 0x00087B9D
        public ZeroCopyOutputStream(ZeroCopyBuffer buffer)
        {
            this.buffer = buffer;
        }

        // Token: 0x17001BE0 RID: 7136
        // (get) Token: 0x0600CB1D RID: 51997 RVA: 0x00002E09 File Offset: 0x00001009
        public override bool CanRead
        {
            get
            {
                return false;
            }
        }

        // Token: 0x17001BE1 RID: 7137
        // (get) Token: 0x0600CB1E RID: 51998 RVA: 0x00002E09 File Offset: 0x00001009
        public override bool CanSeek
        {
            get
            {
                return false;
            }
        }

        // Token: 0x17001BE2 RID: 7138
        // (get) Token: 0x0600CB1F RID: 51999 RVA: 0x00002ABB File Offset: 0x00000CBB
        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        // Token: 0x17001BE3 RID: 7139
        // (get) Token: 0x0600CB20 RID: 52000 RVA: 0x000899AC File Offset: 0x00087BAC
        public override long Length
        {
            get
            {
                return (long)this.buffer.CalcTotalSize();
            }
        }

        // Token: 0x17001BE4 RID: 7140
        // (get) Token: 0x0600CB21 RID: 52001 RVA: 0x00021616 File Offset: 0x0001F816
        // (set) Token: 0x0600CB22 RID: 52002 RVA: 0x00021616 File Offset: 0x0001F816
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

        // Token: 0x0600CB23 RID: 52003 RVA: 0x000028DF File Offset: 0x00000ADF
        public override void Flush()
        {
        }

        // Token: 0x0600CB24 RID: 52004 RVA: 0x00021616 File Offset: 0x0001F816
        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        // Token: 0x0600CB25 RID: 52005 RVA: 0x00021616 File Offset: 0x0001F816
        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        // Token: 0x0600CB26 RID: 52006 RVA: 0x00021616 File Offset: 0x0001F816
        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        // Token: 0x0600CB27 RID: 52007 RVA: 0x000899BA File Offset: 0x00087BBA
        public override void Write(byte[] buffer, int offset, int count)
        {
            this.buffer.Write(buffer, offset, count);
        }

        // Token: 0x0400BE28 RID: 48680
        private readonly ZeroCopyBuffer buffer;
    }

    internal sealed class ZeroCopyInputStream : Stream
    {
        // Token: 0x0600CB0C RID: 51980 RVA: 0x00089950 File Offset: 0x00087B50
        public ZeroCopyInputStream(ZeroCopyBuffer buffer)
        {
            this.tailBuffers = buffer.GetView();
            this.totalSize = buffer.CalcTotalSize();
            this.Length = (long)this.totalSize;
        }

        // Token: 0x0600CB0D RID: 51981 RVA: 0x003B0E30 File Offset: 0x003AF030
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

        // Token: 0x17001BDB RID: 7131
        // (get) Token: 0x0600CB0E RID: 51982 RVA: 0x0008997D File Offset: 0x00087B7D
        public override bool CanRead
        {
            get
            {
                return this.IsReadable();
            }
        }

        // Token: 0x17001BDC RID: 7132
        // (get) Token: 0x0600CB0F RID: 51983 RVA: 0x00002E09 File Offset: 0x00001009
        public override bool CanSeek
        {
            get
            {
                return false;
            }
        }

        // Token: 0x17001BDD RID: 7133
        // (get) Token: 0x0600CB10 RID: 51984 RVA: 0x00002E09 File Offset: 0x00001009
        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }

        // Token: 0x17001BDE RID: 7134
        // (get) Token: 0x0600CB11 RID: 51985 RVA: 0x00089985 File Offset: 0x00087B85
        public override long Length { get; }

        // Token: 0x17001BDF RID: 7135
        // (get) Token: 0x0600CB12 RID: 51986 RVA: 0x0008998D File Offset: 0x00087B8D
        // (set) Token: 0x0600CB13 RID: 51987 RVA: 0x00021616 File Offset: 0x0001F816
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

        // Token: 0x0600CB14 RID: 51988 RVA: 0x000028DF File Offset: 0x00000ADF
        public override void Flush()
        {
        }

        // Token: 0x0600CB15 RID: 51989 RVA: 0x003B0EB0 File Offset: 0x003AF0B0
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

        // Token: 0x0600CB16 RID: 51990 RVA: 0x003B0F9C File Offset: 0x003AF19C
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

        // Token: 0x0600CB17 RID: 51991 RVA: 0x00021616 File Offset: 0x0001F816
        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        // Token: 0x0600CB18 RID: 51992 RVA: 0x00021616 File Offset: 0x0001F816
        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        // Token: 0x0600CB19 RID: 51993 RVA: 0x003B0FEC File Offset: 0x003AF1EC
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

        // Token: 0x0600CB1A RID: 51994 RVA: 0x003B10C8 File Offset: 0x003AF2C8
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

        // Token: 0x0600CB1B RID: 51995 RVA: 0x003B115C File Offset: 0x003AF35C
        private int CalcCurrentFullOffset()
        {
            int num = this.offset;
            for (int i = 0; i < this.index; i++)
            {
                num += this.tailBuffers[i].Offset;
            }
            return num;
        }

        // Token: 0x0400BE22 RID: 48674
        private readonly TailBuffer[] tailBuffers;

        // Token: 0x0400BE23 RID: 48675
        private readonly int totalSize;

        // Token: 0x0400BE24 RID: 48676
        private readonly int fixedOffset;

        // Token: 0x0400BE25 RID: 48677
        private int index;

        // Token: 0x0400BE26 RID: 48678
        private int offset;
    }
}
