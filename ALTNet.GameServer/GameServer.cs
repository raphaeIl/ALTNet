using System.Net.Sockets;
using System.Net;
using Serilog;
using ALTNet.GameServer.Packets;
using Cs.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using Protocol;
using ALTNet.Common.Utils;
using ALTNet.GameServer.Protocol;

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

        public GameServer()
        {
            listener = new(IPAddress.Parse("0.0.0.0"), Config.GameServerPort);
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    listener.Start();

                    Log.Information($"{nameof(GameServer)} started and listening on port {Config.GameServerPort}");

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
            Connection connection = Connection.CreateConnection(tcpClient);

            connection.HandleMessage(tcpClient);
        }


        public static ISerializable PacketHandler(ClientPacketId packetId, ISerializable req)
        {
            Log.Information($"Handling Packet: {packetId}...");

            var handler = GetHandler(packetId);

            if (handler != null)
            {
                Log.Information($"Found handler: {handler} for packetId: {packetId}");

                var rsp = handler.Invoke(null, [req]) as ISerializable;

                return rsp;
            }

            Log.Information($"No handler for packet {packetId}!");
            return null;
        }

        public static MethodInfo GetHandler(ClientPacketId packetId)
        {
            var type = typeof(Handlers.Handlers);
            var handlerName = $"{packetId}_Handler";

            MethodInfo methodInfo = type.GetMethod(handlerName, BindingFlags.Static | BindingFlags.Public);

            return methodInfo;
        }
    }
}