using System.Net.Sockets;
using System.Net;
using Serilog;
using ALTNet.GameServer.Packets;
using System.Text;
using ALTNet.Common.Utils;
using Cs.Protocol;
using NKM;

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

                        Task.Run(() => HandleMessage(tcpClient)); 
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
                bool eos = false;
                while (true) {
                    try
                    {
                        headFence = binaryReader.ReadUInt32();
                        Log.Information("Packet Received!");
                        break;
                    } catch (Exception ex)
                    {
                        Log.Information("End of Stream reached probably, exiting..." + ex.GetBaseException());
                        eos = true;
                        break;
                    }
                }

                if (eos) break;

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

                ISerializable packet = packetStream.Packet;
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
                ISerializable response = PacketHandler(packetId, packet);

                SendBuffer responseSendBuffer = PacketStream.EncodeToSendBuffer(response);

                var eventArgs = new SocketAsyncEventArgs();
                eventArgs.SetBuffer(0, responseSendBuffer.HeadOffset);
                eventArgs.SetBuffer(responseSendBuffer.Data, 0, responseSendBuffer.Data.Length);
                eventArgs.Completed += this.OnSendCompleted;

                tcpClient.Client.SendAsync(eventArgs);

                Log.Information("Packet Responded!");
                // ---------------------------------------- \\
            }

            tcpClient.Close();
            Log.Information("Invalid Fence or Client Disconnected!");
        }

        private void OnSendCompleted(object sender, SocketAsyncEventArgs arg)
        {
            Console.WriteLine("Data sent to client.");
        }

        public ISerializable PacketHandler(ClientPacketId packetId, ISerializable req)
        {
            Log.Information($"Handling Packet: {packetId}...");

            switch (packetId)
            {
                case ClientPacketId.kNKMPacket_CONTENTS_VERSION_REQ:
                    return CONTENTS_VERSION_Handler((NKMPacket_CONTENTS_VERSION_REQ)req);

                case ClientPacketId.kNKMPacket_STEAM_LOGIN_REQ:
                    return STEAM_LOGIN_Handler((NKMPacket_STEAM_LOGIN_REQ)req);
                case ClientPacketId.kNKMPacket_JOIN_LOBBY_REQ:
                    return JOIN_LOBBY_REQ((NKMPacket_JOIN_LOBBY_REQ)req);

                default:
                    Log.Information("No handler for this packet!");
                    break;
            }

            return null;
        }

        private ISerializable JOIN_LOBBY_REQ(NKMPacket_JOIN_LOBBY_REQ req)
        {

            return new NKMPacket_JOIN_LOBBY_ACK()
            {
                errorCode = NKM_ERROR_CODE.NEC_OK,
                friendCode = 13126485,
                utcTime = DateTime.UtcNow,
                utcOffset = TimeSpan.Parse("09:00:00"),
                userData = new NKMUserData()
                {
                    m_eAuthLevel = NKM_USER_AUTH_LEVEL.NORMAL_USER,
                    m_UserLevel = 1,
                    m_ShopData = new()
                    {
                        histories = new(),
                        randomShop = new()
                        {
                            datas = new(),
                            nextRefreshDate = 638531861193270000,
                            refreshCount = 5
                        },
                        subscriptions = new(),
                    }
                },
                gameData = null,
                intervalData = [
                    new() {
                        key = 10,
                        strKey = "DATE_LOGIN_DEFAULT",
                        startDate = DateTime.Parse("2020-01-01T04:00:00"),
                        endDate = DateTime.Parse("2999-01-01T04:00:00"),
                        repeatStartDate = 0,
                        repeatEndDate = 0
                    }

                ]

            };
        }

        public ISerializable CONTENTS_VERSION_Handler(NKMPacket_CONTENTS_VERSION_REQ req)
        {
            return new NKMPacket_CONTENTS_VERSION_ACK()
            {
                errorCode = NKM_ERROR_CODE.NEC_OK,
                contentsVersion = "7.2.e",
                utcTime = DateTime.UtcNow,
                utcOffset = TimeSpan.Parse("09:00:00"),
                contentsTag = ZeroCopyInputStream.ContentsTag,
            };
        }

        public ISerializable STEAM_LOGIN_Handler(NKMPacket_STEAM_LOGIN_REQ req)
        {
            return new NKMPacket_LOGIN_ACK()
            {
                errorCode = NKM_ERROR_CODE.NEC_OK,
                accessToken = "d87a5aa0421b4eddad1809de9cf4d69b",
                //gameServerIP = "ctsglobal-agame02.sbside.com",
                gameServerIP = Config.GameServerIP,
                gameServerPort = Config.GameServerPort,
                //gameServerPort = 20000,
                contentsVersion = "7.2.e",
                contentsTag = ZeroCopyInputStream.ContentsTag,
            };
        }



    }
}