using System;
using System.Collections.Generic;
using System.Linq;
using NKC;
using NKM.Templet.Base;

namespace NKM.Templet
{
	// Token: 0x020005DB RID: 1499
	public sealed class NKMDiveTemplet : INKMTemplet
	{
		// Token: 0x04002D36 RID: 11574
		public static int DiveStormCostMiscId = 3;

		// Token: 0x04002D37 RID: 11575
		public static int DiveStormCostMultiply = 2;

		// Token: 0x04002D38 RID: 11576
		public static int DiveStormRewardMiscId = 1;

		// Token: 0x04002D39 RID: 11577
		public static int DiveStormRewardMultiply = 2;

		// Token: 0x04002D3A RID: 11578
		public const int MaxFirstRewardCount = 3;

		// Token: 0x04002D3B RID: 11579
		public const int MaxSafeRewardCount = 3;

		// Token: 0x04002D3C RID: 11580
		private int INDEX_ID;

		// Token: 0x04002D3D RID: 11581
		private int STAGE_ID;

		// Token: 0x04002D3E RID: 11582
		private string STAGE_STR_ID = "";

		// Token: 0x04002D3F RID: 11583
		private string STAGE_NAME = "";

		// Token: 0x04002D40 RID: 11584
		private string STAGE_NAME_SUB = "";

		// Token: 0x04002D41 RID: 11585
		private string BACKGROUND_FILENAME;

		// Token: 0x04002D42 RID: 11586
		private string MUSIC_ASSET_BUNDLE_NAME;

		// Token: 0x04002D43 RID: 11587
		private string STAGE_MUSIC_NAME;

		// Token: 0x04002D44 RID: 11588
		private NKM_DIVE_STAGE_TYPE DIVE_STAGE_TYPE;

		// Token: 0x04002D45 RID: 11589
		private int STAGE_LEVEL;

		// Token: 0x04002D46 RID: 11590
		private int STAGE_LEVEL_SCALE;

		// Token: 0x04002D47 RID: 11591
		private int SET_LEVEL_SCALE;

		// Token: 0x04002D48 RID: 11592
		private int BIND_SET;

		// Token: 0x04002D49 RID: 11593
		private STAGE_UNLOCK_REQ_TYPE STAGE_UNLOCK_REQ_TYPE;

		// Token: 0x04002D4A RID: 11594
		private int STAGE_UNLOCK_REQ_VALUE;

		// Token: 0x04002D4B RID: 11595
		private string OPEN_TAG = "";

		// Token: 0x04002D4C RID: 11596
		private int STAGE_REQ_ITEM_ID;

		// Token: 0x04002D4D RID: 11597
		private int STAGE_REQ_ITEM_COUNT;

		// Token: 0x04002D4E RID: 11598
		private int SQUAD_COUNT;

		// Token: 0x04002D4F RID: 11599
		private int RANDOM_SET_COUNT;

		// Token: 0x04002D50 RID: 11600
		private int SLOT_COUNT;

		// Token: 0x04002D51 RID: 11601
		private int SLOT_EVENT_GROUP_ID;

		// Token: 0x04002D52 RID: 11602
		private int BOSS_EVENT_GROUP_ID;

		// Token: 0x04002D53 RID: 11603
		private bool IS_EVENT_DIVE;

		// Token: 0x04002D54 RID: 11604
		private string cutsceneDiveEnter = string.Empty;

		// Token: 0x04002D55 RID: 11605
		private string cutsceneDiveStart = string.Empty;

		// Token: 0x04002D56 RID: 11606
		private string cutsceneDiveBossBefore = string.Empty;

		// Token: 0x04002D57 RID: 11607
		private string cutsceneDiveBossAfter = string.Empty;

		// Token: 0x04002D58 RID: 11608
		private readonly List<NKMDiveFirstReward> FIRSTREWARD_LIST = new List<NKMDiveFirstReward>();

		// Token: 0x04002D59 RID: 11609
		private readonly List<NKMDiveSafeReward> safeRewards = new List<NKMDiveSafeReward>();

		// Token: 0x04002D5A RID: 11610
		private int startingArtifact;

		// Token: 0x04002D5B RID: 11611
		private string diveMonsterBattleCondition = string.Empty;

		// Token: 0x04002D5C RID: 11612
		private int depth = 1;

		// Token: 0x04002D5D RID: 11613
		private int BOSS_STAGE_REQ_ITEM_ID;

		// Token: 0x04002D5E RID: 11614
		private int BOSS_STAGE_REQ_ITEM_COUNT;

		// Token: 0x04002D5F RID: 11615
		private int SAFE_MINE_REQ_ITEM_ID;

		// Token: 0x04002D60 RID: 11616
		private int SAFE_MINE_REQ_ITEM_COUNT;

        public int Key => throw new NotImplementedException();

        public void Join()
        {
            throw new NotImplementedException();
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
