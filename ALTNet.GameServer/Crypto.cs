using ALTNet.GameServer.Packets;

namespace ALTNet.GameServer
{
    public static class Crypto
    {
        public static void Encrypt(byte[] buffer, int size)
        {
            if (buffer == null)
            {
                return;
            }
            int num = 0;
            Crypto.Encrypt(buffer, size, ref num, Crypto.MaskList);
        }

        public static void Encrypt(byte[] buffer, int size, ulong[] maskList)
        {
            if (buffer == null)
            {
                return;
            }
            int num = 0;
            Crypto.Encrypt(buffer, size, ref num, maskList);
        }

        public static void Encrypt(byte[] buffer, int size, ref int maskIndex)
        {
            if (buffer == null)
            {
                return;
            }
            Crypto.Encrypt(buffer, size, ref maskIndex, Crypto.MaskList);
        }

        public static void Encrypt(byte[] buffer, int size, ref int maskIndex, ulong[] maskList)
        {
            if (buffer == null)
            {
                return;
            }
            int i = 0;
            while (i < size)
            {
                ulong num = maskList[maskIndex];
                int num2 = size - i;
                if (num2 >= 8)
                {
                    (buffer.DirectToUint64(i) ^ num).DirectWriteTo(buffer, i);
                    i += 8;
                } else
                {
                    for (int j = i; j < size; j++)
                    {
                        int num3 = j - i;
                        int num4 = j;
                        buffer[num4] ^= (byte)(num & 255UL << num3 >> num3);
                    }
                    i += num2;
                }
                maskIndex = (maskIndex + 1) % maskList.Length;
            }
        }

        // Token: 0x0400BE1B RID: 48667
        private static readonly ulong[] MaskList = new ulong[]
        {
            14170986657190717782UL,
            15546886188969944187UL,
            15913139373130964729UL,
            3486779174683840252UL
        };
    }
}
