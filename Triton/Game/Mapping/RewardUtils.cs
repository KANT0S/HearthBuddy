namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("RewardUtils")]
    public class RewardUtils : MonoClass
    {
        public RewardUtils(IntPtr address) : this(address, "RewardUtils")
        {
        }

        public RewardUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static string GetRewardText(RewardData rewardData)
        {
            object[] objArray1 = new object[] { rewardData };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "RewardUtils", "GetRewardText", objArray1);
        }

        public static void ShowInnkeeperQuoteForReward(Reward reward)
        {
            object[] objArray1 = new object[] { reward };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "RewardUtils", "ShowInnkeeperQuoteForReward", objArray1);
        }

        public static void ShowReward(Reward reward, bool updateCacheValues, Vector3 rewardPunchScale, Vector3 rewardScale, string callbackName, object callbackData, GameObject callbackGO)
        {
            object[] objArray1 = new object[] { reward, updateCacheValues, rewardPunchScale, rewardScale, callbackName, callbackData, callbackGO };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RewardUtils", "ShowReward", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Vector3 REWARD_HIDDEN_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "RewardUtils", "REWARD_HIDDEN_SCALE");
            }
        }

        public static float REWARD_HIDE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "RewardUtils", "REWARD_HIDE_TIME");
            }
        }
    }
}

