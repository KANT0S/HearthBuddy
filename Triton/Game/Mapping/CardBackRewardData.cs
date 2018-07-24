namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBackRewardData")]
    public class CardBackRewardData : RewardData
    {
        public CardBackRewardData(IntPtr address) : this(address, "CardBackRewardData")
        {
        }

        public CardBackRewardData(IntPtr address, string className) : base(address, className)
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

        public int CardBackID
        {
            get
            {
                return base.method_11<int>("get_CardBackID", Array.Empty<object>());
            }
        }
    }
}

