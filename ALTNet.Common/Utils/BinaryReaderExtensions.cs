using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTNet.GameServer.Packets
{
    public static class BinaryReaderExtensions
    {
        public static int PeekInt32(this BinaryReader reader)
        {
            long currentPosition = reader.BaseStream.Position;

            int value = reader.ReadInt32();

            reader.BaseStream.Position = currentPosition;

            return value;
        }
    }
}
