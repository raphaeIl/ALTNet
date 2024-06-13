namespace ALTNet.GameServer.Packets
{
    public static class NumericExt
    {
        // Token: 0x0600CCD1 RID: 52433 RVA: 0x0008A54C File Offset: 0x0008874C
        public static int Clamp(this int val, int min, int max)
        {
            return Math.Min(Math.Max(val, min), max);
        }

        // Token: 0x0600CCD2 RID: 52434 RVA: 0x0008A55B File Offset: 0x0008875B
        public static long Clamp(this long val, long min, long max)
        {
            return Math.Min(Math.Max(val, min), max);
        }

        // Token: 0x0600CCD3 RID: 52435 RVA: 0x0008A56A File Offset: 0x0008876A
        public static T Clamp<T>(this T val, T min, T max) where T : class, IComparable<T>
        {
            if (val.CompareTo(min) < 0)
            {
                return min;
            }
            if (val.CompareTo(max) <= 0)
            {
                return val;
            }
            return max;
        }

        // Token: 0x0600CCD4 RID: 52436 RVA: 0x0008A58F File Offset: 0x0008878F
        public static ushort DirectToUint16(this byte[] buffer, int startIndex)
        {
            return (ushort)((int)buffer[startIndex + 1] << 8 | (int)buffer[startIndex]);
        }

        // Token: 0x0600CCD5 RID: 52437 RVA: 0x0008A59D File Offset: 0x0008879D
        public static uint DirectToUint32(this byte[] buffer, int startIndex)
        {
            return (uint)((((int)buffer[startIndex + 3] << 8 | (int)buffer[startIndex + 2]) << 8 | (int)buffer[startIndex + 1]) << 8 | (int)buffer[startIndex]);
        }

        // Token: 0x0600CCD6 RID: 52438 RVA: 0x003B4E38 File Offset: 0x003B3038
        public static ulong DirectToUint64(this byte[] buffer, int startIndex)
        {
            return (((((((ulong)buffer[startIndex + 7] << 8 | (ulong)buffer[startIndex + 6]) << 8 | (ulong)buffer[startIndex + 5]) << 8 | (ulong)buffer[startIndex + 4]) << 8 | (ulong)buffer[startIndex + 3]) << 8 | (ulong)buffer[startIndex + 2]) << 8 | (ulong)buffer[startIndex + 1]) << 8 | (ulong)buffer[startIndex];
        }

        // Token: 0x0600CCD7 RID: 52439 RVA: 0x0008A5BA File Offset: 0x000887BA
        public static void DirectWriteTo(this int data, byte[] buffer, int position)
        {
            buffer[position] = (byte)data;
            buffer[position + 1] = (byte)(data >> 8);
            buffer[position + 2] = (byte)(data >> 16);
            buffer[position + 3] = (byte)(data >> 24);
        }

        // Token: 0x0600CCD8 RID: 52440 RVA: 0x003B4E88 File Offset: 0x003B3088
        public static void DirectWriteTo(this long data, byte[] buffer, int position)
        {
            buffer[position] = (byte)data;
            buffer[position + 1] = (byte)(data >> 8);
            buffer[position + 2] = (byte)(data >> 16);
            buffer[position + 3] = (byte)(data >> 24);
            buffer[position + 4] = (byte)(data >> 32);
            buffer[position + 5] = (byte)(data >> 40);
            buffer[position + 6] = (byte)(data >> 48);
            buffer[position + 7] = (byte)(data >> 56);
        }

        // Token: 0x0600CCD9 RID: 52441 RVA: 0x003B4EE0 File Offset: 0x003B30E0
        public static void DirectWriteTo(this ulong data, byte[] buffer, int position)
        {
            buffer[position] = (byte)data;
            buffer[position + 1] = (byte)(data >> 8);
            buffer[position + 2] = (byte)(data >> 16);
            buffer[position + 3] = (byte)(data >> 24);
            buffer[position + 4] = (byte)(data >> 32);
            buffer[position + 5] = (byte)(data >> 40);
            buffer[position + 6] = (byte)(data >> 48);
            buffer[position + 7] = (byte)(data >> 56);
        }
    }
}
