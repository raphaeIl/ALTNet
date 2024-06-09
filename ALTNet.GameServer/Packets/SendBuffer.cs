using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTNet.GameServer.Packets
{
    public sealed class SendBuffer
    {
        public byte[] Data
        {
            get
            {
                return this.headBuffer;
            }
        }

        public int HeadOffset
        {
            get
            {
                return this.headOffset;
            }
        }
        
        public bool HasData
        {
            get
            {
                return this.headOffset > 0 || this.tailBuffers.Count > 0;
            }
        }
        
        internal int TailCount
        {
            get
            {
                return this.tailBuffers.Count;
            }
        }

        
        
        private int HeadReservedSize
        {
            get
            {
                return this.headBuffer.Length - this.headOffset;
            }
        }

        
        public int CalcTotalSize()
        {
            int num = this.headOffset;
            foreach (TailBuffer tailBuffer in this.tailBuffers)
            {
                num += tailBuffer.Offset;
            }
            return num;
        }

        
        public BinaryWriter GetWriter()
        {
            return new BinaryWriter(new SendStream(this));
        }

        
        public void Consume(int size)
        {
            if (this.headOffset < size)
            {
                throw new ArgumentException(string.Format("this.offset:{0} size:{1}", this.headOffset, size));
            }
            this.headOffset -= size;
            if (this.headOffset > 0)
            {
                Buffer.BlockCopy(this.headBuffer, size, this.headBuffer, 0, this.headOffset);
            }
            this.TryConsumeTailBuffers();
        }

        
        public byte[] Flush()
        {
            byte[] array = new byte[this.CalcTotalSize()];
            int num = 0;
            Buffer.BlockCopy(this.headBuffer, 0, array, num, this.HeadOffset);
            num += this.HeadOffset;
            this.headOffset = 0;
            foreach (TailBuffer tailBuffer in this.tailBuffers)
            {
                Buffer.BlockCopy(tailBuffer.Data, 0, array, num, tailBuffer.Offset);
                num += tailBuffer.Offset;
                tailBuffer.ToRecycleBin();
            }
            this.tailBuffers.Clear();
            return array;
        }

        
        public void Absorb(ZeroCopyBuffer zeroCopyBuffer)
        {
            foreach (TailBuffer value in zeroCopyBuffer.Move())
            {
                this.tailBuffers.AddLast(value);
            }
            this.TryConsumeTailBuffers();
        }

        
        internal void Write(byte[] buffer, int offset, int count)
        {
            if (this.tailBuffers.Count == 0 && this.HeadReservedSize > 0)
            {
                int num = Math.Min(this.HeadReservedSize, count);
                Buffer.BlockCopy(buffer, offset, this.headBuffer, this.headOffset, num);
                this.headOffset += num;
                offset += num;
                count -= num;
            }
            if (count == 0)
            {
                return;
            }
            TailBuffer tailBuffer = null;
            if (this.tailBuffers.Count > 0)
            {
                tailBuffer = this.tailBuffers.Last.Value;
                if (!tailBuffer.IsFull)
                {
                    int num2 = tailBuffer.AddData(buffer, offset, count);
                    offset += num2;
                    count -= num2;
                }
            }
            while (count > 0)
            {
                if (tailBuffer != null && !tailBuffer.IsFull)
                {
                    throw new Exception(string.Format("memory offset error. lastBuffer.Offset:{0}", tailBuffer.Offset));
                }
                TailBuffer tailBuffer2 = TailBuffer.Create(buffer, offset, count);
                this.tailBuffers.AddLast(tailBuffer2);
                offset += tailBuffer2.Offset;
                count -= tailBuffer2.Offset;
            }
        }

        
        internal void Clear()
        {
            this.headOffset = 0;
            foreach (TailBuffer tailBuffer in this.tailBuffers)
            {
                tailBuffer.ToRecycleBin();
            }
            this.tailBuffers.Clear();
        }

        
        private void TryConsumeTailBuffers()
        {
            while (this.tailBuffers.Count > 0)
            {
                TailBuffer value = this.tailBuffers.First.Value;
                if (this.HeadReservedSize < value.Offset)
                {
                    break;
                }
                Buffer.BlockCopy(value.Data, 0, this.headBuffer, this.headOffset, value.Offset);
                this.headOffset += value.Offset;
                value.ToRecycleBin();
                this.tailBuffers.RemoveFirst();
            }
        }

        
        private readonly byte[] headBuffer = new byte[4096];

        
        private readonly LinkedList<TailBuffer> tailBuffers = new LinkedList<TailBuffer>();

        
        private int headOffset;
    }

    internal sealed class SendStream : Stream
    {
        
        public SendStream(SendBuffer sendBuffer)
        {
            this.buffer = sendBuffer;
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

        
        private readonly SendBuffer buffer;
    }
}
