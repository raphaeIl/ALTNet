using Cs.Protocol;
using Protocol;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ALTNet.GameServer.Packets
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

                if (headFence != PacketStream.HeadFence)
                {
                    Log.Information("Invalid Head Fence or Client Disconnected!");
                    break;
                }
                // ---------------------------------------- \\


                // ----------- Packet Decoding ---------`--- \\


                var packetStream = PacketStream.DecodeFromStream(this.reader);

                ISerializable packet = packetStream.Packet;
                ClientPacketId packetId = (ClientPacketId)packetStream.PacketId;
                // ---------------------------------------- \\


                // ----------- Tail Fence Check ----------- \\
                uint tailFence = this.reader.ReadUInt32();
                Log.Information($"Tail Fence: {tailFence}");

                if (tailFence != PacketStream.TailFence)
                {
                    Log.Information("Invalid Head Fence or Client Disconnected!");
                    break;
                }
                // ---------------------------------------- \\


                // ------- Handle Packet & Response ------- \\
                //ISerializable response = GameServer.PacketHandler(packetId, packet);
                //long sequence = Interlocked.Increment(ref this.sendSequence);

                //this.sendingBuffer_ = PacketStream.EncodeToSendBuffer(response);
                //if (!this.Send())
                //{
                //    Log.Error("send data failed.", "/Users/buildman/buildAgent_ca18-1/work/e0bfb30763b53cef/CounterSide/CODE/CSClient/Assets/ASSET_STATIC/AS_SCRIPT/NKC/Cs.Engine/Network/SendController.cs", 106);
                //}

                //Log.Information("Packet Responded!");
                // ---------------------------------------- \\


                ISerializable response = GameServer.PacketHandler(packetId, packet);

                if (response == null)
                {
                    Log.Information("No response for that Request!");
                    break;
                }

                SendBuffer responseSendBuffer = PacketStream.EncodeToSendBuffer(response);

                //var eventArgs = new SocketAsyncEventArgs();
                //eventArgs.SetBuffer(responseSendBuffer.Data, 0, responseSendBuffer.Data.Length);
                //eventArgs.SetBuffer(0, responseSendBuffer.HeadOffset);
                //eventArgs.Completed += this.OnSendCompleted;

                //while (true)
                //{
                //    var bytesTransferred = tcpClient.Client.Send(responseSendBuffer.Data);
                //    Log.Information("send result: bytes transferred:" + bytesTransferred);
                //    Log.Information("responseSendBuffer.HeadOffset: " + responseSendBuffer.HeadOffset);
                //    if (responseSendBuffer.HeadOffset < bytesTransferred)
                //        break;

                //    responseSendBuffer.Consume(bytesTransferred);
                //    Log.Information("Consumed, moving to next section!");

                //}
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

        private bool Send()
        {
            var eventArgs = new SocketAsyncEventArgs();
            eventArgs.SetBuffer(0, sendingBuffer_.HeadOffset);
            eventArgs.SetBuffer(sendingBuffer_.Data, 0, sendingBuffer_.Data.Length);
            eventArgs.Completed += this.OnSendCompleted;
            return tcpClient.Client.SendAsync(eventArgs);
        }

        private void OnSendCompletedSync(int bytesSent)
        {
            Log.Information($"Send Completed! BytesTransferred: {bytesSent}");

            this.sendingBuffer_.Consume(bytesSent);
            if (!this.sendingBuffer_.HasData)
            {
                int num = this.sendingMessageCount_;
                this.sendingMessageCount_ = 0;
                if (Interlocked.Add(ref this.messageCount_, -num) == 0)
                {
                    return;
                }
            }
            if (!this.Send())
            {
                Log.Error("send data failed.", "/Users/buildman/buildAgent_ca18-1/work/e0bfb30763b53cef/CounterSide/CODE/CSClient/Assets/ASSET_STATIC/AS_SCRIPT/NKC/Cs.Engine/Network/SendController.cs", 106);
            }
        }

        private void OnSendCompleted(object sender, SocketAsyncEventArgs arg)
        {
            Log.Information($"Send Completed! sender: {sender}, BytesTransferred: {arg.BytesTransferred}");

            this.sendingBuffer_.Consume(arg.BytesTransferred);
            if (!this.sendingBuffer_.HasData)
            {
                int num = this.sendingMessageCount_;
                this.sendingMessageCount_ = 0;
                if (Interlocked.Add(ref this.messageCount_, -num) == 0)
                {
                    return;
                }
            }
            if (!this.Send())
            {
                Log.Error("send data failed.", "/Users/buildman/buildAgent_ca18-1/work/e0bfb30763b53cef/CounterSide/CODE/CSClient/Assets/ASSET_STATIC/AS_SCRIPT/NKC/Cs.Engine/Network/SendController.cs", 106);
            }
        }

    }
}
