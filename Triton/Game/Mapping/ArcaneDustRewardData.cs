namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ArcaneDustRewardData")]
    public class ArcaneDustRewardData : RewardData
    {
        public ArcaneDustRewardData(IntPtr address) : this(address, "ArcaneDustRewardData")
        {
        }

        public ArcaneDustRewardData(IntPtr address, string className) : base(address, className)
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

        public int Amount
        {
            get
            {
                return base.method_11<int>("get_Amount", Array.Empty<object>());
            }
        }
    }
}

