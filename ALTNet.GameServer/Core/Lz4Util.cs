using LZ4;

namespace ALTNet.GameServer.Core
{
    public static class Lz4Util
    {
        public static byte[] Compress(byte[] source)
        {
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (LZ4Stream lz4Stream = new LZ4Stream(memoryStream, LZ4StreamMode.Compress, LZ4StreamFlags.None, 1048576))
                {
                    lz4Stream.Write(source, 0, source.Length);
                }
                result = memoryStream.ToArray();
            }
            return result;
        }

        public static ZeroCopyBuffer Decompress(byte[] source)
        {
            ZeroCopyBuffer zeroCopyBuffer = new ZeroCopyBuffer();
            using (ZeroCopyOutputStream zeroCopyOutputStream = new ZeroCopyOutputStream(zeroCopyBuffer))
            {
                using (LZ4Stream lz4Stream = new LZ4Stream(new MemoryStream(source), LZ4StreamMode.Decompress, LZ4StreamFlags.None, 1048576))
                {
                    byte[] array = new byte[4096];
                    int count;
                    while ((count = lz4Stream.Read(array, 0, array.Length)) != 0)
                    {
                        zeroCopyOutputStream.Write(array, 0, count);
                    }
                }
            }
            return zeroCopyBuffer;
        }

        public static ZeroCopyBuffer Decompress(Stream source)
        {
            ZeroCopyBuffer zeroCopyBuffer = new ZeroCopyBuffer();
            ZeroCopyBuffer result;
            using (Stream outputStream = zeroCopyBuffer.GetOutputStream())
            {
                using (LZ4Stream lz4Stream = new LZ4Stream(source, LZ4StreamMode.Decompress, LZ4StreamFlags.None, 1048576))
                {
                    byte[] array = new byte[4096];
                    int count;
                    while ((count = lz4Stream.Read(array, 0, array.Length)) != 0)
                    {
                        outputStream.Write(array, 0, count);
                    }
                    result = zeroCopyBuffer;
                }
            }
            return result;
        }
    }
}
