using System.Net.Sockets;
using System.Net;
using Serilog;
using ALTNet.GameServer.Packets;

namespace ALTNet.GameServer
{
    public class GameServer 
    {
        private readonly TcpListener listener;

        private static GameServer _instance;
        public static GameServer Instance
        {
            get
            {
                return _instance ??= new GameServer();
            }
        }

        public const int port = 22000;

        public GameServer()
        {
            listener = new(IPAddress.Parse("0.0.0.0"), port);
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    listener.Start();

                    Log.Information($"{nameof(GameServer)} started and listening on port {port}");

                    while (true)
                    {
                        TcpClient tcpClient = listener.AcceptTcpClient();
                        string id = tcpClient.Client.RemoteEndPoint!.ToString()!;

                        Log.Information($"{id} connected");

                        HandleMessage(tcpClient);
                    }
                } catch (Exception ex)
                {
                    Log.Information("TCP listener error: " + ex.Message);
                }
            }
        }

        public void HandleMessage(TcpClient tcpClient)
        {
            using var reader = new StreamReader(tcpClient.GetStream());
            using var writer = new StreamWriter(tcpClient.GetStream()) { AutoFlush = true };

            using var binaryReader = new BinaryReader(reader.BaseStream);

            while (tcpClient.Connected)
            {
                Log.Information("Waiting for next packet...");
                uint headFence = 1;

                while (true) {
                    try
                    {
                        headFence = binaryReader.ReadUInt32();
                        Log.Information("Packet Received!");
                        break;
                    } catch (Exception ex)
                    {
                        continue;
                    }
                }

                // ----------- Head Fence Check ----------- \\
                Log.Information($"Head Fence: {headFence}");

                if (headFence != PacketStream.HeadFence)
                {
                    Log.Information("Invalid Head Fence or Client Disconnected!");
                    break;
                }
                // ---------------------------------------- \\


                // ----------- Packet Decoding ---------`--- \\
                var packetStream = PacketStream.DecodeFromStream(binaryReader);

                Packet packet = packetStream.Packet;
                ClientPacketId packetId = (ClientPacketId)packetStream.PacketId;
                // ---------------------------------------- \\


                // ----------- Tail Fence Check ----------- \\
                uint tailFence = binaryReader.ReadUInt32();
                Log.Information($"Tail Fence: {tailFence}");

                if (tailFence != PacketStream.TailFence)
                {
                    Log.Information("Invalid Head Fence or Client Disconnected!");
                    break;
                }
                // ---------------------------------------- \\


                // ------- Handle Packet & Response ------- \\
                Packet response = PacketHandler(packetId, packet);

                var responseBuffer = PacketStream.EncodeToBuffer(packetStream.PacketId, PacketStream.EncodePacket(response));
                writer.Write(responseBuffer);
                // ---------------------------------------- \\

            }

            tcpClient.Close();
            Log.Information("Invalid Fence or Client Disconnected!");
        }

        public Packet PacketHandler(ClientPacketId packetId, Packet packet)
        {
            Log.Information($"Handling Packet: {packetId}...");

            return new NKMPacket_CONTENTS_VERSION_ACK()
            {
                errorCode = NKM_ERROR_CODE.NEC_OK,
                contentsTag = [],
                contentsVersion = "1.0",
                utcTime = DateTime.UtcNow,
                utcOffset = ((DateTimeOffset)DateTime.UtcNow.ToLocalTime()).Offset,
            };
        }
    }
}