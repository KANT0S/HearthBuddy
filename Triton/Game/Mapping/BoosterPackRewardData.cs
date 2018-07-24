namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoosterPackRewardData")]
    public class BoosterPackRewardData : RewardData
    {
        public BoosterPackRewardData(IntPtr address) : this(address, "BoosterPackRewardData")
        {
        }

        public BoosterPackRewardData(IntPtr address, string className) : base(address, className)
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

        public int Count
        {
            get
            {
                return base.method_11<int>("get_Count", Array.Empty<object>());
            }
        }

        public int Id
        {
            get
            {
                return base.method_11<int>("get_Id", Array.Empty<object>());
            }
        }
    }
}

