using Cs.Protocol;
using Protocol;

namespace ClientPacket.Game
{
	[PacketId(ClientPacketId.kNKMPacket_FIERCE_SEASON_NOT)]
	public sealed class NKMPacket_FIERCE_SEASON_NOT : ISerializable
	{
		void ISerializable.Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.fierceId);
		}

		public int fierceId;
	}
}
