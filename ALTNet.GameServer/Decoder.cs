using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTNet.GameServer
{
    public static class Decoder
    {
        public static long Decode64(ulong n)
        {
            long result = (long)(n >> 1);
            if ((n & 1) != 0)
            {
                result = result ^ -1L;
            }
            return result;
        }

        public static int Decode32(uint n)
        {
            return (int)(n >> 1 ^ -(int)(n & 1U));
        }

        public static uint Encode32(int n)
        {
            return (uint)(n << 1 ^ n >> 31);
        }

        public static ulong Encode64(long n)
        {
            return (ulong)(n << 1 ^ n >> 63);
        }

        public static ulong ReadRawVarInt64(BinaryReader reader, out int bytesRead)
        {
            bytesRead = 0;

            int i = 0;
            ulong num = 0UL;
            while (i < 64)
            {
                byte b = reader.ReadByte();
                bytesRead++;
                num |= (ulong)((ulong)((long)(b & 127)) << i);
                if ((b & 128) == 0)
                {
                    return num;
                }
                i += 7;
            }
            throw new Exception("[PacketReader] Malformed Varint64");
        }

        public static uint ReadRawVarInt32(BinaryReader reader)
        {
            int i = 0;
            uint num = 0U;
            while (i < 32)
            {
                byte b = reader.ReadByte();
                num |= (uint)((uint)(b & 127) << i);
                if ((b & 128) == 0)
                {
                    return num;
                }
                i += 7;
            }
            throw new Exception("[PacketReader] Malformed Varint32");
        }

        public static uint ReadRawVarInt32(BinaryReader reader, out int bytesRead)
        {
            bytesRead = 0;

            int i = 0;
            uint num = 0U;
            while (i < 32)
            {
                byte b = reader.ReadByte();
                bytesRead++;
                num |= (uint)((uint)(b & 127) << i);
                if ((b & 128) == 0)
                {
                    return num;
                }
                i += 7;
            }
            throw new Exception("[PacketReader] Malformed Varint32");
        }

        public static void WriteRawVarint32(BinaryWriter writer, uint value)
        {
            while (value > 127U)
            {
                writer.Write((byte)((value & 127U) | 128U));
                value >>= 7;
            }
            writer.Write((byte)value);
        }
    }
}
