namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GoldRewardData")]
    public class GoldRewardData : RewardData
    {
        public GoldRewardData(IntPtr address) : this(address, "GoldRewardData")
        {
        }

        public GoldRewardData(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetGameObjectName()
        {
            return base.method_13("GetGameObjectName", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public long Amount
        {
            get
            {
                return base.method_11<long>("get_Amount", Array.Empty<object>());
            }
        }
    }
}

