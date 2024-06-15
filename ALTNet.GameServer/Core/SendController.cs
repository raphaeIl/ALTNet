using ALTNet.GameServer.Protocol;
using Serilog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ALTNet.GameServer.Core
{
    internal sealed class SendController : IDisposable
    {
        public SendController(Socket socket)
        {
            this.socket_ = socket;
            this.eventArgs_.SetBuffer(this.sendingBuffer_.Data, 0, this.sendingBuffer_.Data.Length);
            this.eventArgs_.Completed += this.OnSendCompleted;
        }

        public int MessageCount
        {
            get
            {
                return this.messageCount_;
            }
        }

        public void Dispose()
        {
            this.eventArgs_.Dispose();
        }

        public void Push(Packet data)
        {
            this.sendQueue_.Enqueue(data);
            if (Interlocked.Increment(ref this.messageCount_) != 1)
            {
                return;
            }
            if (!this.socket_.Connected)
            {
                return;
            }
            this.TryFillBuffer();
            if (!this.RequestSendAsync())
            {
                Log.Error("send data failed.");
                Log.Information("manually continuing");
                OnSendCompleted(this.socket_, this.eventArgs_);
            }
        }

        public void TryConsumeQueue()
        {
            if (this.sendQueue_.Count == 0)
            {
                return;
            }
            this.TryFillBuffer();
            if (!this.RequestSendAsync())
            {
                Log.Error("send data failed.");
                Log.Information("manually continuing");
                OnSendCompleted(this.socket_, this.eventArgs_);
            }

        }

        private void TryFillBuffer()
        {
            Packet packet;
            while (this.sendQueue_.TryDequeue(out packet))
            {
                Log.Information("TryFillBuffer PacketType: " + packet.GetType().ToString(), "main.cs", 79);
                this.sendingMessageCount_++;
                packet.WriteTo(this.sendingBuffer_);
            }
        }

        private bool RequestSendAsync()
        {
            this.eventArgs_.SetBuffer(0, this.sendingBuffer_.HeadOffset);
            return this.socket_.SendAsync(this.eventArgs_);
        }

        private void OnSendCompleted(object sender, SocketAsyncEventArgs arg)
        {
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
            this.TryFillBuffer();
            if (!this.RequestSendAsync())
            {
                Log.Error("send data failed.");

                Log.Information("manually continuing");
                OnSendCompleted(this.socket_, this.eventArgs_);
            }
        }

        private readonly Socket socket_;

        private SocketAsyncEventArgs eventArgs_ = new SocketAsyncEventArgs();

        private ConcurrentQueue<Packet> sendQueue_ = new ConcurrentQueue<Packet>();

        private SendBuffer sendingBuffer_ = new SendBuffer();

        private int messageCount_;

        private int sendingMessageCount_;
    }
}
