using Serilog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ALTNet.GameServer.Packets
{
    internal sealed class SendController : IDisposable
    {
        // Token: 0x0600CAC3 RID: 51907 RVA: 0x003B0318 File Offset: 0x003AE518
        public SendController(Socket socket)
        {
            this.socket_ = socket;
            this.eventArgs_.SetBuffer(this.sendingBuffer_.Data, 0, this.sendingBuffer_.Data.Length);
            this.eventArgs_.Completed += this.OnSendCompleted;
        }

        // Token: 0x17001BCD RID: 7117
        // (get) Token: 0x0600CAC4 RID: 51908 RVA: 0x00089625 File Offset: 0x00087825
        public int MessageCount
        {
            get
            {
                return this.messageCount_;
            }
        }

        // Token: 0x0600CAC5 RID: 51909 RVA: 0x0008962D File Offset: 0x0008782D
        public void Dispose()
        {
            this.eventArgs_.Dispose();
        }

        // Token: 0x0600CAC6 RID: 51910 RVA: 0x003B0390 File Offset: 0x003AE590
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

        // Token: 0x0600CAC7 RID: 51911 RVA: 0x0008963A File Offset: 0x0008783A
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

        // Token: 0x0600CAC8 RID: 51912 RVA: 0x003B03F8 File Offset: 0x003AE5F8
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

        // Token: 0x0600CAC9 RID: 51913 RVA: 0x00089669 File Offset: 0x00087869
        private bool RequestSendAsync()
        {
            this.eventArgs_.SetBuffer(0, this.sendingBuffer_.HeadOffset);
            return this.socket_.SendAsync(this.eventArgs_);
        }

        // Token: 0x0600CACA RID: 51914 RVA: 0x003B0458 File Offset: 0x003AE658
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

        // Token: 0x0400BE0A RID: 48650
        private readonly Socket socket_;

        // Token: 0x0400BE0B RID: 48651
        private SocketAsyncEventArgs eventArgs_ = new SocketAsyncEventArgs();

        // Token: 0x0400BE0C RID: 48652
        private ConcurrentQueue<Packet> sendQueue_ = new ConcurrentQueue<Packet>();

        // Token: 0x0400BE0D RID: 48653
        private SendBuffer sendingBuffer_ = new SendBuffer();

        // Token: 0x0400BE0E RID: 48654
        private int messageCount_;

        // Token: 0x0400BE0F RID: 48655
        private int sendingMessageCount_;
    }
}
