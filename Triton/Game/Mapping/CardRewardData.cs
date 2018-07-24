namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardRewardData")]
    public class CardRewardData : RewardData
    {
        public CardRewardData(IntPtr address) : this(address, "CardRewardData")
        {
        }

        public CardRewardData(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetGameObjectName()
        {
            return base.method_13("GetGameObjectName", Array.Empty<object>());
        }

        public bool Merge(CardRewardData other)
        {
            object[] objArray1 = new object[] { other };
            return base.method_11<bool>("Merge", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public string CardID
        {
            get
            {
                return base.method_13("get_CardID", Array.Empty<object>());
            }
        }

        public int Count
        {
            get
            {
                return base.method_11<int>("get_Count", Array.Empty<object>());
            }
        }

        public FixedRewardMapDbfRecord FixedReward
        {
            get
            {
                return base.method_14<FixedRewardMapDbfRecord>("get_FixedReward", Array.Empty<object>());
            }
        }

        public InnKeeperTrigger InnKeeperLine
        {
            get
            {
                return base.method_11<InnKeeperTrigger>("get_InnKeeperLine", Array.Empty<object>());
            }
        }

        public TAG_PREMIUM Premium
        {
            get
            {
                return base.method_11<TAG_PREMIUM>("get_Premium", Array.Empty<object>());
            }
        }

        public enum InnKeeperTrigger
        {
            NONE,
            CORE_CLASS_SET_COMPLETE,
            SECOND_REWARD_EVER
        }
    }
}

