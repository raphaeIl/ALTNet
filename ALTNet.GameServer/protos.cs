using ALTNet.GameServer.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTNet.GameServer
{
    [PacketId(ClientPacketId.kNKMPacket_CONTENTS_VERSION_REQ)]
    public sealed class NKMPacket_CONTENTS_VERSION_REQ : Packet
    {

    }

    [PacketId(ClientPacketId.kNKMPacket_CONTENTS_VERSION_ACK)]
    public sealed class NKMPacket_CONTENTS_VERSION_ACK : Packet
    {
        public NKM_ERROR_CODE errorCode;

        public string contentsVersion;

        public List<string> contentsTag = new List<string>();

        public DateTime utcTime;

        public TimeSpan utcOffset;

        public override void Serialize(IPacketStream serializer)
        {
            serializer.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
            serializer.PutOrGet(ref this.contentsVersion);
            serializer.PutOrGet(ref this.contentsTag);
            serializer.PutOrGet(ref this.utcTime);
            serializer.PutOrGet(ref this.utcOffset);
        }
    }

    [PacketId(ClientPacketId.kNKMPacket_STEAM_LOGIN_REQ)]
    public sealed class NKMPacket_STEAM_LOGIN_REQ : Packet
    {
        public override void Serialize(IPacketStream stream)
        {
            stream.PutOrGet(ref this.protocolVersion);
            stream.PutOrGet(ref this.deviceUid);
            stream.PutOrGet(ref this.accessToken);
            stream.PutOrGet(ref this.accountId);
            stream.PutOrGet<NKMUserMobileData>(ref this.userMobileData);
        }

        public int protocolVersion;

        public string deviceUid;

        public string accessToken;

        public string accountId;

        public NKMUserMobileData userMobileData;
    }

    [PacketId(ClientPacketId.kNKMPacket_LOGIN_ACK)]
    public sealed class NKMPacket_LOGIN_ACK : Packet
    {
        public override void Serialize(IPacketStream stream)
        {
            stream.PutOrGetEnum<NKM_ERROR_CODE>(ref this.errorCode);
            stream.PutOrGet(ref this.accessToken);
            stream.PutOrGet(ref this.gameServerIP);
            stream.PutOrGet(ref this.gameServerPort);
            stream.PutOrGet(ref this.contentsVersion);
            stream.PutOrGet(ref this.contentsTag);
            stream.PutOrGet(ref this.openTag);
        }

        public NKM_ERROR_CODE errorCode;

        public string accessToken;

        public string gameServerIP;

        public int gameServerPort;

        public string contentsVersion;

        public List<string> contentsTag = new List<string>();

        public List<string> openTag = new List<string>();
    }

    [PacketId(ClientPacketId.kNKMPacket_JOIN_LOBBY_REQ)]
    public sealed class NKMPacket_JOIN_LOBBY_REQ : Packet
    {
        public override void Serialize(IPacketStream stream)
        {
            stream.PutOrGet(ref this.protocolVersion);
            stream.PutOrGet(ref this.accessToken);
        }

        public int protocolVersion;

        public string accessToken;
    }

    [PacketId(ClientPacketId.kNKMPacket_RESET_GROUP_COUNT_NOT)]
    public sealed class NKMPacket_RESET_GROUP_COUNT_NOT : Packet
    {
        public override void Serialize(IPacketStream stream)
        {
            stream.PutOrGet<NKMResetCount>(ref this.resetCountList);
        }

        public List<NKMResetCount> resetCountList = new List<NKMResetCount>();
    }

	[PacketId(ClientPacketId.kNKMPacket_JOIN_LOBBY_ACK)]
	public sealed class NKMPacket_JOIN_LOBBY_ACK : Packet
	{
		public override void Serialize(IPacketStream stream)
		{
			
		}

		public NKM_ERROR_CODE errorCode;

		public long friendCode;

		public NKMUserData userData;
	}
}
