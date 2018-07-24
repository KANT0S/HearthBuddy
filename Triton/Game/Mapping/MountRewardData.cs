namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MountRewardData")]
    public class MountRewardData : RewardData
    {
        public MountRewardData(IntPtr address) : this(address, "MountRewardData")
        {
        }

        public MountRewardData(IntPtr address, string className) : base(address, className)
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

        public MountType Mount
        {
            get
            {
                return base.method_11<MountType>("get_Mount", Array.Empty<object>());
            }
        }

        public enum MountType
        {
            UNKNOWN,
            WOW_HEARTHSTEED,
            HEROES_MAGIC_CARPET_CARD
        }
    }
}

