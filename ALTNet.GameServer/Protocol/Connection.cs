using ALTNet.GameServer.Core;
using Cs.Protocol;
using Protocol;
using Serilog;
using System.IO;
using System.Net.Sockets;

namespace ALTNet.GameServer.Protocol
{
    public class Connection
    {
        private TcpClient tcpClient;

        private SendController sendController;

        private BinaryReader reader;

        private SendBuffer sendingBuffer_;

        private long sendSequence;

        private int messageCount_;
        
        private int sendingMessageCount_;

        public static Connection CreateConnection(TcpClient tcpClient)
        {
            return new Connection(tcpClient);
        }

        public Connection(TcpClient tcpClient) {
            this.tcpClient = tcpClient;
            this.sendController = new SendController(tcpClient.Client);
            this.reader = new BinaryReader(new StreamReader(tcpClient.GetStream()).BaseStream);
        }

        public void HandleMessage(TcpClient tcpClient)
        {
            while (tcpClient.Connected)
            {
                Log.Information("Waiting for next packet...");
                uint headFence = 1;
                bool eos = false;
                while (true)
                {
                    try
                    {
                        headFence = reader.ReadUInt32();
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

                if (headFence != Packet.HeadFence)
                {
                    Log.Information("Invalid Head Fence or Client Disconnected!");
                    break;
                }
                // ---------------------------------------- \\


                // ----------- Packet Decoding ---------`--- \\

                ISerializable packet = Packet.DecodeFromStream(this.reader);
                ClientPacketId packetId = (ClientPacketId)Packet.GetPacketId(packet);
                // ---------------------------------------- \\


                // ----------- Tail Fence Check ----------- \\
                uint tailFence = this.reader.ReadUInt32();
                Log.Information($"Tail Fence: {tailFence}");

                if (tailFence != Packet.TailFence)
                {
                    Log.Information("Invalid Head Fence or Client Disconnected!");
                    break;
                }
                // ---------------------------------------- \\

                ISerializable response = GameServer.PacketHandler(packetId, packet);

                if (response == null)
                {
                    Log.Information("No response for that Request!");
                    break;
                }

                this.Send(response);

                Log.Information("Packet Responded!");
            }

            tcpClient.Close();
            Log.Information("Invalid Fence or Client Disconnected!");
        }

        public bool Send(ISerializable msg)
        {
            if (msg == null)
            {
                return false;
            }

            long sequence = Interlocked.Increment(ref this.sendSequence);
            Packet? packet = Packet.Pack(msg, sequence);
            if (packet == null)
            {
                Log.Error("data serializing failed");
                return false;
            }

            this.sendController.Push(packet.Value);
            return true;
        }
    }
}
