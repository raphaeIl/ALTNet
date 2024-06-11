using System;
using System.Collections.Generic;
using Cs.Protocol;
using NKM.Templet;

namespace NKM
{
	// Token: 0x02000462 RID: 1122
	public class NKMPostData : ISerializable
	{
		// Token: 0x06001E9B RID: 7835 RVA: 0x00093D4F File Offset: 0x00091F4F
		public NKMPostData()
		{
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00093D62 File Offset: 0x00091F62
		public NKMPostData(int postId)
		{
			this.postId = postId;
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00093D7C File Offset: 0x00091F7C
		public NKMPostData(int postId, string title, string contents, DateTime sendDate, DateTime expireDate, long postIndex)
		{
			this.postId = postId;
			this.title = title;
			this.contents = contents;
			this.expirationDate = expireDate;
			this.sendDate = sendDate;
			this.postIndex = postIndex;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00093DBC File Offset: 0x00091FBC
		public NKMPostData(int postId, string title, string contents, DateTime sendDate, TimeSpan lifeTime, long postIndex)
		{
			this.postId = postId;
			this.title = title;
			this.contents = contents;
			this.sendDate = sendDate;
			this.expirationDate = sendDate + lifeTime;
			this.postIndex = postIndex;
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00093E58 File Offset: 0x00092058
		public void Serialize(IPacketStream stream)
		{
			stream.PutOrGet(ref this.postId);
			stream.PutOrGet(ref this.postIndex);
			stream.PutOrGet(ref this.title);
			stream.PutOrGet(ref this.contents);
			stream.PutOrGet(ref this.sendDate);
			stream.PutOrGet<NKMRewardInfo>(ref this.items);
			stream.PutOrGet(ref this.expirationDate);
		}

		// Token: 0x04002052 RID: 8274
		public int postId;

		// Token: 0x04002053 RID: 8275
		public long postIndex;

		// Token: 0x04002054 RID: 8276
		public string title;

		// Token: 0x04002055 RID: 8277
		public string contents;

		// Token: 0x04002056 RID: 8278
		public DateTime sendDate;

		// Token: 0x04002057 RID: 8279
		public DateTime expirationDate;

		// Token: 0x04002058 RID: 8280
		public List<NKMRewardInfo> items = new List<NKMRewardInfo>();
	}
}
