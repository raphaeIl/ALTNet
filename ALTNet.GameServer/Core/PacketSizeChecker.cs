namespace ALTNet.GameServer.Core
{
    public class PacketSizeChecker
    {
        private int size;

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public void PutOrGet(ZeroCopyBuffer data)
        {
            int num = data.CalcTotalSize();
            this.CheckInt32(num);
            this.size += num;
        }

        public void PutOrGet(byte[] data)
        {
            int num = data.Length;
            this.CheckInt32(num);
            this.size += num;
        }

        private void CheckInt32(int data)
        {
            this.size += PacketSizeChecker.ComputeRawVarint32Size(Decoder.Encode32(data));
        }

        public void PutOrGet(ref long data)
        {
            this.CheckInt64(data);
        }

        public void PutOrGet(ref ushort data)
        {
            this.CheckUint32((uint)data);
        }

        public void PutOrGet(ref bool data)
        {
            this.size++;
        }

        private void CheckUint32(uint data)
        {
            this.size += PacketSizeChecker.ComputeRawVarint32Size(data);
        }

        public void CheckRawUint32(uint data)
        {
            this.size += 4;
        }

        public void CheckRawInt32(int data)
        {
            this.size += 4;
        }

        private void CheckInt64(long data)
        {
            this.size += PacketSizeChecker.ComputeRawVarint64Size(Decoder.Encode64(data));
        }

        private static int ComputeRawVarint32Size(uint value)
        {
            if ((value & 4294967168U) == 0U)
            {
                return 1;
            }
            if ((value & 4294950912U) == 0U)
            {
                return 2;
            }
            if ((value & 4292870144U) == 0U)
            {
                return 3;
            }
            if ((value & 4026531840U) == 0U)
            {
                return 4;
            }
            return 5;
        }

        private static int ComputeRawVarint64Size(ulong value)
        {
            if ((value & 18446744073709551488UL) == 0UL)
            {
                return 1;
            }
            if ((value & 18446744073709535232UL) == 0UL)
            {
                return 2;
            }
            if ((value & 18446744073707454464UL) == 0UL)
            {
                return 3;
            }
            if ((value & 18446744073441116160UL) == 0UL)
            {
                return 4;
            }
            if ((value & 18446744039349813248UL) == 0UL)
            {
                return 5;
            }
            if ((value & 18446739675663040512UL) == 0UL)
            {
                return 6;
            }
            if ((value & 18446181123756130304UL) == 0UL)
            {
                return 7;
            }
            if ((value & 18374686479671623680UL) == 0UL)
            {
                return 8;
            }
            if ((value & 9223372036854775808UL) == 0UL)
            {
                return 9;
            }
            return 10;
        }


    }
}
