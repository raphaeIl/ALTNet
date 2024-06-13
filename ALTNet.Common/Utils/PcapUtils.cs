using Cs.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Serilog;
using System.Reflection;
using System.Text.Json.Nodes;

namespace ALTNet.Common.Utils
{
    public static class PcapUtils
    {
        static PcapUtils()
        {
            PcapUtils.Load();
        }

        public static string PcapFilePath = "E:\\documents\\Decompiling\\Extracted\\CounterSide\\ps\\ALTNet\\ALTNet\\pcap.json";

        public static List<PacketJson> packetJsons = new List<PacketJson>();

        private static void Load()
        {
            var json = File.ReadAllText(PcapFilePath);

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultValuesContractResolver()
            };
            
            packetJsons = JsonConvert.DeserializeObject<List<PacketJson>>(json, settings);
            
            foreach (var pj in packetJsons)
                Console.WriteLine($"Loaded Pcap {pj.PacketId}");
        }

        public static T FromJson<T>() where T : ISerializable
        {
            Console.WriteLine($"k{typeof(T)}");
            JObject jObjejct = (JObject)packetJsons.FirstOrDefault(x => x.PacketId.Equals($"k{typeof(T).Name}")).Payload;

            return jObjejct.ToObject<T>();
        }

        public class PacketJson
        {
            public string Type { get; set; }

            public string PacketId { get; set; }

            public object Payload { get; set; }
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
