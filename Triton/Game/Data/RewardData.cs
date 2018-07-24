namespace Triton.Game.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class RewardData
    {
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private Triton.Game.Mapping.Reward.Type type_0;

        internal RewardData(Triton.Game.Mapping.RewardData reward)
        {
            this.Type = reward.m_type;
            this.Count = 1;
            if (reward.RewardType == Triton.Game.Mapping.Reward.Type.ARCANE_DUST)
            {
                ArcaneDustRewardData data = new ArcaneDustRewardData(reward.Address);
                this.Count = data.Amount;
            }
            else if (reward.RewardType == Triton.Game.Mapping.Reward.Type.GOLD)
            {
                GoldRewardData data2 = new GoldRewardData(reward.Address);
                this.Count = (int) data2.Amount;
            }
            else if (reward.RewardType == Triton.Game.Mapping.Reward.Type.CARD)
            {
                CardRewardData data3 = new CardRewardData(reward.Address);
                this.Count = data3.Count;
            }
            else if (reward.RewardType == Triton.Game.Mapping.Reward.Type.BOOSTER_PACK)
            {
                BoosterPackRewardData data4 = new BoosterPackRewardData(reward.Address);
                this.Count = data4.Count;
            }
        }

        public int Count
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            private set
            {
                this.int_0 = value;
            }
        }

        public Triton.Game.Mapping.Reward.Type Type
        {
            [CompilerGenerated]
            get
            {
                return this.type_0;
            }
            [CompilerGenerated]
            private set
            {
                this.type_0 = value;
            }
        }
    }
}

