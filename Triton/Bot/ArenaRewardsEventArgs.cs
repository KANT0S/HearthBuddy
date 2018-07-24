namespace Triton.Bot
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class ArenaRewardsEventArgs : EventArgs
    {
        [CompilerGenerated]
        private List<RewardData> list_0;

        internal ArenaRewardsEventArgs(List<RewardData> rewards)
        {
            this.Rewards = new List<RewardData>(rewards);
        }

        public List<RewardData> Rewards
        {
            [CompilerGenerated]
            get
            {
                return this.list_0;
            }
            [CompilerGenerated]
            private set
            {
                this.list_0 = value;
            }
        }
    }
}

