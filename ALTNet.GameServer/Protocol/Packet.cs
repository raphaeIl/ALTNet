using ALTNet.GameServer.Core;
using Cs.Protocol;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ALTNet.GameServer.Protocol
{
    public struct Packet
    {
        // Token: 0x17001BE7 RID: 7143
        // (get) Token: 0x0600CB83 RID: 52099 RVA: 0x00089ADD File Offset: 0x00087CDD
        public ushort PacketId
        {
            get
            {
                return this.packetId;
            }
        }

        // Token: 0x0600CB84 RID: 52100 RVA: 0x003B1D54 File Offset: 0x003AFF54
        public static Packet? Pack(ISerializable data, long sequence)
        {
            Packet packet = new Packet
            {
                sequence = sequence,
                packetId = PacketStream.GetPacketId(data)
            };
            if (packet.packetId == 65535)
            {
                Log.Error(MethodBase.GetCurrentMethod().Name + " invalid data", "/Users/buildman/buildAgent_ca18-1/work/e0bfb30763b53cef/CounterSide/CODE/CSClient/Assets/ASSET_STATIC/AS_SCRIPT/COMMON/Cs.Protocol/Packet.cs", 36);
                return null;
            }
            packet.buffer = PacketWriter.ToBufferWithoutNullBit(data);
            if (packet.buffer.CalcTotalSize() > 1024)
            {
                packet.buffer.Lz4Compress();
                packet.compressed = true;
            } else
            {
                packet.buffer.Encrypt();
            }
            packet.totalLength = packet.CalcTotalLength();
            return new Packet?(packet);
        }

        // Token: 0x0600CB87 RID: 52103 RVA: 0x003B21E0 File Offset: 0x003B03E0
        public void WriteTo(SendBuffer sendBuffer)
        {
            using (BinaryWriter writer = sendBuffer.GetWriter())
            {
                PacketWriter packetWriter = new PacketWriter(writer);
                packetWriter.PutRawUint(2864434397U);
                packetWriter.PutRawInt(this.totalLength);
                packetWriter.PutOrGet(ref this.sequence);
                packetWriter.PutOrGet(ref this.packetId);
                packetWriter.PutOrGet(ref this.compressed);
                packetWriter.PutInt(this.buffer.CalcTotalSize());
                sendBuffer.Absorb(this.buffer);
                packetWriter.PutRawUint(287454020U);
            }
        }

        // Token: 0x0600CB88 RID: 52104 RVA: 0x003B2394 File Offset: 0x003B0594
        private int CalcTotalLength()
        {
            PacketSizeChecker packetSizeChecker = new PacketSizeChecker();
            packetSizeChecker.CheckRawUint32(2864434397U);
            packetSizeChecker.CheckRawInt32(this.totalLength);
            packetSizeChecker.PutOrGet(ref this.sequence);
            packetSizeChecker.PutOrGet(ref this.packetId);
            packetSizeChecker.PutOrGet(ref this.compressed);
            packetSizeChecker.PutOrGet(this.buffer);
            packetSizeChecker.CheckRawUint32(287454020U);
            return packetSizeChecker.Size;
        }

        // Token: 0x0400BE40 RID: 48704
        private const uint HeadFence = 2864434397U;

        // Token: 0x0400BE41 RID: 48705
        private const uint TailFence = 287454020U;

        // Token: 0x0400BE42 RID: 48706
        private const int CompressThreshold = 1024;

        // Token: 0x0400BE43 RID: 48707
        private const ushort MinHeaderSize = 12;

        // Token: 0x0400BE44 RID: 48708
        private long sequence;

        // Token: 0x0400BE45 RID: 48709
        private ushort packetId;

        // Token: 0x0400BE46 RID: 48710
        private bool compressed;

        // Token: 0x0400BE47 RID: 48711
        private ZeroCopyBuffer buffer;

        // Token: 0x0400BE48 RID: 48712
        private int totalLength;
    }
}
