namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FixedRewardsMgr")]
    public class FixedRewardsMgr : MonoClass
    {
        public FixedRewardsMgr(IntPtr address) : this(address, "FixedRewardsMgr")
        {
        }

        public FixedRewardsMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanCraftCard(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_11<bool>("CanCraftCard", objArray1);
        }

        public void CheckForTutorialComplete()
        {
            base.method_9("CheckForTutorialComplete", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static FixedRewardsMgr Get()
        {
            return MonoClass.smethod_15<FixedRewardsMgr>(TritonHs.MainAssemblyPath, "", "FixedRewardsMgr", "Get", Array.Empty<object>());
        }

        public NetCache.CardDefinition GetCardDefinition(FixedRewardDbfRecord dbfRecReward)
        {
            object[] objArray1 = new object[] { dbfRecReward };
            return base.method_14<NetCache.CardDefinition>("GetCardDefinition", objArray1);
        }

        public FixedMetaActionReward GetEarnedMetaActionReward(int metaActionID)
        {
            object[] objArray1 = new object[] { metaActionID };
            return base.method_14<FixedMetaActionReward>("GetEarnedMetaActionReward", objArray1);
        }

        public FixedReward GetFixedReward(FixedRewardMapDbfRecord fixedRewardMapRecord)
        {
            object[] objArray1 = new object[] { fixedRewardMapRecord };
            return base.method_14<FixedReward>("GetFixedReward", objArray1);
        }

        public static void Initialize()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "FixedRewardsMgr", "Initialize");
        }

        public void InitStartupFixedRewards()
        {
            base.method_8("InitStartupFixedRewards", Array.Empty<object>());
        }

        public void OnAdventureProgressUpdate(bool isStartupAction, AdventureMission.WingProgress oldProgress, AdventureMission.WingProgress newProgress, object userData)
        {
            object[] objArray1 = new object[] { isStartupAction, oldProgress, newProgress, userData };
            base.method_8("OnAdventureProgressUpdate", objArray1);
        }

        public void OnNonToastRewardClicked(Reward reward, object userData)
        {
            object[] objArray1 = new object[] { reward, userData };
            base.method_8("OnNonToastRewardClicked", objArray1);
        }

        public bool QueueRewardVisual(FixedRewardMapDbfRecord fixedRewardMapRecord, int achieveID)
        {
            object[] objArray1 = new object[] { fixedRewardMapRecord, achieveID };
            return base.method_11<bool>("QueueRewardVisual", objArray1);
        }

        public void ShowFixedRewards_Internal(OnAllFixedRewardsShownCallbackInfo callbackInfo)
        {
            object[] objArray1 = new object[] { callbackInfo };
            base.method_8("ShowFixedRewards_Internal", objArray1);
        }

        public void UpdateEarnedMetaActionFlags(int metaActionID, ulong addFlags, ulong removeFlags)
        {
            object[] objArray1 = new object[] { metaActionID, addFlags, removeFlags };
            base.method_8("UpdateEarnedMetaActionFlags", objArray1);
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public bool m_isInitialization
        {
            get
            {
                return base.method_2<bool>("m_isInitialization");
            }
        }

        public bool m_registeredForAdventureProgressUpdates
        {
            get
            {
                return base.method_2<bool>("m_registeredForAdventureProgressUpdates");
            }
        }

        public bool m_registeredForCompletedAchieves
        {
            get
            {
                return base.method_2<bool>("m_registeredForCompletedAchieves");
            }
        }

        public bool m_registeredForProfileNotices
        {
            get
            {
                return base.method_2<bool>("m_registeredForProfileNotices");
            }
        }

        [Attribute38("FixedRewardsMgr.FixedMetaActionReward")]
        public class FixedMetaActionReward : MonoClass
        {
            public FixedMetaActionReward(IntPtr address) : this(address, "FixedMetaActionReward")
            {
            }

            public FixedMetaActionReward(IntPtr address, string className) : base(address, className)
            {
            }

            public bool HasAllRequiredFlags(ulong requiredFlags)
            {
                object[] objArray1 = new object[] { requiredFlags };
                return base.method_11<bool>("HasAllRequiredFlags", objArray1);
            }

            public void UpdateFlags(ulong addFlags, ulong removeFlags)
            {
                object[] objArray1 = new object[] { addFlags, removeFlags };
                base.method_8("UpdateFlags", objArray1);
            }

            public ulong MetaActionFlags
            {
                get
                {
                    return base.method_11<ulong>("get_MetaActionFlags", Array.Empty<object>());
                }
            }

            public int MetaActionID
            {
                get
                {
                    return base.method_11<int>("get_MetaActionID", Array.Empty<object>());
                }
            }
        }

        [Attribute38("FixedRewardsMgr.FixedReward")]
        public class FixedReward : MonoClass
        {
            public FixedReward(IntPtr address) : this(address, "FixedReward")
            {
            }

            public FixedReward(IntPtr address, string className) : base(address, className)
            {
            }

            public CardBackRewardData FixedCardBackRewardData
            {
                get
                {
                    return base.method_3<CardBackRewardData>("FixedCardBackRewardData");
                }
            }

            public CardRewardData FixedCardRewardData
            {
                get
                {
                    return base.method_3<CardRewardData>("FixedCardRewardData");
                }
            }

            public NetCache.CardDefinition FixedCraftableCardRewardData
            {
                get
                {
                    return base.method_3<NetCache.CardDefinition>("FixedCraftableCardRewardData");
                }
            }

            public FixedRewardsMgr.FixedMetaActionReward FixedMetaActionRewardData
            {
                get
                {
                    return base.method_3<FixedRewardsMgr.FixedMetaActionReward>("FixedMetaActionRewardData");
                }
            }
        }

        [Attribute38("FixedRewardsMgr.OnAllFixedRewardsShownCallbackInfo")]
        public class OnAllFixedRewardsShownCallbackInfo : MonoClass
        {
            public OnAllFixedRewardsShownCallbackInfo(IntPtr address) : this(address, "OnAllFixedRewardsShownCallbackInfo")
            {
            }

            public OnAllFixedRewardsShownCallbackInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public List<FixedRewardsMgr.RewardMapIDToShow> m_rewardMapIDsToShow
            {
                get
                {
                    Class267<FixedRewardsMgr.RewardMapIDToShow> class2 = base.method_3<Class267<FixedRewardsMgr.RewardMapIDToShow>>("m_rewardMapIDsToShow");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public Vector3 m_rewardPunchScale
            {
                get
                {
                    return base.method_2<Vector3>("m_rewardPunchScale");
                }
            }

            public Vector3 m_rewardScale
            {
                get
                {
                    return base.method_2<Vector3>("m_rewardScale");
                }
            }

            public bool m_showingCheatRewards
            {
                get
                {
                    return base.method_2<bool>("m_showingCheatRewards");
                }
            }

            public object m_userData
            {
                get
                {
                    return base.method_3<object>("m_userData");
                }
            }
        }

        [Attribute38("FixedRewardsMgr.RewardMapIDToShow")]
        public class RewardMapIDToShow : MonoClass
        {
            public RewardMapIDToShow(IntPtr address) : this(address, "RewardMapIDToShow")
            {
            }

            public RewardMapIDToShow(IntPtr address, string className) : base(address, className)
            {
            }

            public bool Equals(object obj)
            {
                object[] objArray1 = new object[] { obj };
                return base.method_11<bool>("Equals", objArray1);
            }

            public int GetHashCode()
            {
                return base.method_11<int>("GetHashCode", Array.Empty<object>());
            }

            public int AchieveID
            {
                get
                {
                    return base.method_2<int>("AchieveID");
                }
            }

            public static int NO_ACHIEVE_ID
            {
                get
                {
                    return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "FixedRewardsMgr/RewardMapIDToShow", "NO_ACHIEVE_ID");
                }
            }

            public int RewardMapID
            {
                get
                {
                    return base.method_2<int>("RewardMapID");
                }
            }

            public int SortOrder
            {
                get
                {
                    return base.method_2<int>("SortOrder");
                }
            }
        }

        public enum ShowVisualOption
        {
            DO_NOT_SHOW,
            SHOW,
            FORCE_SHOW
        }
    }
}

