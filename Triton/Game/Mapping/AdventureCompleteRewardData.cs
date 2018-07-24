namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureCompleteRewardData")]
    public class AdventureCompleteRewardData : RewardData
    {
        public AdventureCompleteRewardData(IntPtr address) : this(address, "AdventureCompleteRewardData")
        {
        }

        public AdventureCompleteRewardData(IntPtr address, string className) : base(address, className)
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

        public string BannerText
        {
            get
            {
                return base.method_13("get_BannerText", Array.Empty<object>());
            }
        }

        public bool IsBadlyHurt
        {
            get
            {
                return base.method_11<bool>("get_IsBadlyHurt", Array.Empty<object>());
            }
        }

        public string RewardObjectName
        {
            get
            {
                return base.method_13("get_RewardObjectName", Array.Empty<object>());
            }
        }

        public static string s_DefaultRewardObject
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureCompleteRewardData", "s_DefaultRewardObject");
            }
        }
    }
}

