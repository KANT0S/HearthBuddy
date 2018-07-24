namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("Reward")]
    public class Reward : MonoBehaviour
    {
        public Reward(IntPtr address) : this(address, "Reward")
        {
        }

        public Reward(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void EnableClickCatcher(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("EnableClickCatcher", objArray1);
        }

        public void Hide(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            base.method_8("Hide", objArray1);
        }

        public void HideReward()
        {
            base.method_8("HideReward", Array.Empty<object>());
        }

        public void InitData()
        {
            base.method_8("InitData", Array.Empty<object>());
        }

        public void NotifyLoadedWhenReady(LoadRewardCallbackData loadRewardCallbackData)
        {
            object[] objArray1 = new object[] { loadRewardCallbackData };
            base.method_8("NotifyLoadedWhenReady", objArray1);
        }

        public void OnClickReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnClickReleased", objArray1);
        }

        public void OnDataSet(bool updateVisuals)
        {
            object[] objArray1 = new object[] { updateVisuals };
            base.method_8("OnDataSet", objArray1);
        }

        public void OnHide()
        {
            base.method_8("OnHide", Array.Empty<object>());
        }

        public void OnHideAnimateComplete()
        {
            base.method_8("OnHideAnimateComplete", Array.Empty<object>());
        }

        public void SetData(RewardData data, bool updateVisuals)
        {
            object[] objArray1 = new object[] { data, updateVisuals };
            base.method_8("SetData", objArray1);
        }

        public void SetReady(bool ready)
        {
            object[] objArray1 = new object[] { ready };
            base.method_8("SetReady", objArray1);
        }

        public void SetRewardText(string headline, string details, string source)
        {
            object[] objArray1 = new object[] { headline, details, source };
            base.method_8("SetRewardText", objArray1);
        }

        public void Show(bool updateCacheValues)
        {
            object[] objArray1 = new object[] { updateCacheValues };
            base.method_8("Show", objArray1);
        }

        public void ShowReward(bool updateCacheValues)
        {
            object[] objArray1 = new object[] { updateCacheValues };
            base.method_8("ShowReward", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public RewardData Data
        {
            get
            {
                return base.method_14<RewardData>("get_Data", Array.Empty<object>());
            }
        }

        public bool IsShown
        {
            get
            {
                return base.method_11<bool>("get_IsShown", Array.Empty<object>());
            }
        }

        public PegUIElement m_clickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_clickCatcher");
            }
        }

        public RewardData m_data
        {
            get
            {
                return base.method_3<RewardData>("m_data");
            }
        }

        public bool m_ready
        {
            get
            {
                return base.method_2<bool>("m_ready");
            }
        }

        public RewardBanner m_rewardBanner
        {
            get
            {
                return base.method_3<RewardBanner>("m_rewardBanner");
            }
        }

        public GameObject m_rewardBannerBone
        {
            get
            {
                return base.method_3<GameObject>("m_rewardBannerBone");
            }
        }

        public RewardBanner m_rewardBannerPrefab
        {
            get
            {
                return base.method_3<RewardBanner>("m_rewardBannerPrefab");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public Type m_type
        {
            get
            {
                return base.method_2<Type>("m_type");
            }
        }

        public Type RewardType
        {
            get
            {
                return base.method_11<Type>("get_RewardType", Array.Empty<object>());
            }
        }

        [Attribute38("Reward.LoadRewardCallbackData")]
        public class LoadRewardCallbackData : MonoClass
        {
            public LoadRewardCallbackData(IntPtr address) : this(address, "LoadRewardCallbackData")
            {
            }

            public LoadRewardCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public object m_callbackData
            {
                get
                {
                    return base.method_3<object>("m_callbackData");
                }
            }
        }

        public enum Type
        {
            ARCANE_DUST,
            BOOSTER_PACK,
            CARD,
            CARD_BACK,
            CRAFTABLE_CARD,
            FORGE_TICKET,
            GOLD,
            MOUNT,
            CLASS_CHALLENGE
        }
    }
}

