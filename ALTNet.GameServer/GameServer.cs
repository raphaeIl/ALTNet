using System.Net.Sockets;
using System.Net;
using Serilog;
using ALTNet.GameServer.Packets;
using Cs.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using Protocol;

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

        public static T FromJson<T>(string json)
        {
            string jsonData = File.ReadAllText(json);

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultValuesContractResolver()
            };


            return JsonConvert.DeserializeObject<T>(jsonData, settings);
        }

        public class DefaultValuesContractResolver : DefaultContractResolver
        {
            protected override JsonObjectContract CreateObjectContract(Type objectType)
            {
                JsonObjectContract contract = base.CreateObjectContract(objectType);
                contract.DefaultCreator = () => CreateWithDefaults(objectType);
                return contract;
            }

            private object CreateWithDefaults(Type objectType)
            {
                var instance = Activator.CreateInstance(objectType);

                foreach (PropertyInfo property in objectType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if (property.CanWrite && property.PropertyType.IsValueType && !property.PropertyType.IsEnum)
                    {
                        property.SetValue(instance, Activator.CreateInstance(property.PropertyType));
                    } else if (property.CanWrite && property.PropertyType == typeof(string))
                    {
                        property.SetValue(instance, string.Empty);
                    } else if (property.CanWrite && property.PropertyType.IsClass)
                    {
                        property.SetValue(instance, null);
                    }
                }

                return instance;
            }
        }
    }
}