namespace Cs.Protocol
{
    public interface ISerializable
    {
        void Serialize(IPacketStream serializer);
    }
}
