namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("RewardBoxesDisplay")]
    public class RewardBoxesDisplay : MonoBehaviour
    {
        public RewardBoxesDisplay(IntPtr address) : this(address, "RewardBoxesDisplay")
        {
        }

        public RewardBoxesDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddRewardsToCacheValues()
        {
            base.method_8("AddRewardsToCacheValues", Array.Empty<object>());
        }

        public void AllDone()
        {
            base.method_8("AllDone", Array.Empty<object>());
        }

        public void AnimateRewards()
        {
            base.method_8("AnimateRewards", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CheckAllRewardsActive()
        {
            return base.method_11<bool>("CheckAllRewardsActive", Array.Empty<object>());
        }

        public void CleanUp()
        {
            base.method_8("CleanUp", Array.Empty<object>());
        }

        public GameObject CreateRewardInstance(int rewardIndex, Vector3 rewardPos, bool activeOnStart)
        {
            object[] objArray1 = new object[] { rewardIndex, rewardPos, activeOnStart };
            return base.method_14<GameObject>("CreateRewardInstance", objArray1);
        }

        public void DebugLogRewards()
        {
            base.method_8("DebugLogRewards", Array.Empty<object>());
        }

        public void FadeFullscreenEffectsIn()
        {
            base.method_8("FadeFullscreenEffectsIn", Array.Empty<object>());
        }

        public void FadeFullscreenEffectsOut()
        {
            base.method_8("FadeFullscreenEffectsOut", Array.Empty<object>());
        }

        public void FadeFullscreenEffectsOutFinished()
        {
            base.method_8("FadeFullscreenEffectsOutFinished", Array.Empty<object>());
        }

        public void FadeVignetteIn()
        {
            base.method_8("FadeVignetteIn", Array.Empty<object>());
        }

        public static RewardBoxesDisplay Get()
        {
            return MonoClass.smethod_15<RewardBoxesDisplay>(TritonHs.MainAssemblyPath, "", "RewardBoxesDisplay", "Get", Array.Empty<object>());
        }

        public List<RewardPackageData> GetPackageData(int rewardCount)
        {
            object[] objArray1 = new object[] { rewardCount };
            Class267<RewardPackageData> class2 = base.method_14<Class267<RewardPackageData>>("GetPackageData", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnDoneButtonHidden(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnDoneButtonHidden", objArray1);
        }

        public void OnDoneButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDoneButtonPressed", objArray1);
        }

        public void OnDoneButtonShown(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnDoneButtonShown", objArray1);
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void OpenReward(int rewardIndex, Vector3 rewardPos)
        {
            object[] objArray1 = new object[] { rewardIndex, rewardPos };
            base.method_8("OpenReward", objArray1);
        }

        public void RewardPackageAnimation()
        {
            base.method_8("RewardPackageAnimation", Array.Empty<object>());
        }

        public void RewardPackageOnComplete(RewardBoxData boxData)
        {
            object[] objArray1 = new object[] { boxData };
            base.method_8("RewardPackageOnComplete", objArray1);
        }

        public void RewardPackageOnStart(RewardBoxData boxData)
        {
            object[] objArray1 = new object[] { boxData };
            base.method_8("RewardPackageOnStart", objArray1);
        }

        public void RewardPackagePressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("RewardPackagePressed", objArray1);
        }

        public void SetLayer(GameLayer layer)
        {
            object[] objArray1 = new object[] { layer };
            base.method_8("SetLayer", objArray1);
        }

        public void ShowAlreadyOpenedRewards()
        {
            base.method_8("ShowAlreadyOpenedRewards", Array.Empty<object>());
        }

        public void ShowCompleteAchieve(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("ShowCompleteAchieve", objArray1);
        }

        public void ShowOpenedRewards()
        {
            base.method_8("ShowOpenedRewards", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UseDarkeningClickCatcher(bool value)
        {
            object[] objArray1 = new object[] { value };
            base.method_8("UseDarkeningClickCatcher", objArray1);
        }

        public static string DEFAULT_PREFAB
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RewardBoxesDisplay", "DEFAULT_PREFAB");
            }
        }

        public bool m_addRewardsToCacheValues
        {
            get
            {
                return base.method_2<bool>("m_addRewardsToCacheValues");
            }
        }

        public GameObject m_ClickCatcher
        {
            get
            {
                return base.method_3<GameObject>("m_ClickCatcher");
            }
        }

        public List<Achievement> m_completeAchievesToDisplay
        {
            get
            {
                Class267<Achievement> class2 = base.method_3<Class267<Achievement>>("m_completeAchievesToDisplay");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_destroyed
        {
            get
            {
                return base.method_2<bool>("m_destroyed");
            }
        }

        public NormalButton m_DoneButton
        {
            get
            {
                return base.method_3<NormalButton>("m_DoneButton");
            }
        }

        public List<GameObject> m_InstancedObjects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_InstancedObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameLayer m_layer
        {
            get
            {
                return base.method_2<GameLayer>("m_layer");
            }
        }

        public bool m_playBoxFlyoutSound
        {
            get
            {
                return base.method_2<bool>("m_playBoxFlyoutSound");
            }
        }

        public List<GameObject> m_RewardObjects
        {
            get
            {
                Class247<GameObject> class2 = base.method_3<Class247<GameObject>>("m_RewardObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<RewardPackageData> m_RewardPackages
        {
            get
            {
                Class267<RewardPackageData> class2 = base.method_3<Class267<RewardPackageData>>("m_RewardPackages");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<RewardData> m_Rewards
        {
            get
            {
                Class267<RewardData> class2 = base.method_3<Class267<RewardData>>("m_Rewards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public RewardSet m_RewardSets
        {
            get
            {
                return base.method_3<RewardSet>("m_RewardSets");
            }
        }

        public GameObject m_Root
        {
            get
            {
                return base.method_3<GameObject>("m_Root");
            }
        }

        public bool m_useDarkeningClickCatcher
        {
            get
            {
                return base.method_2<bool>("m_useDarkeningClickCatcher");
            }
        }

        public static RewardBoxesDisplay s_Instance
        {
            get
            {
                return MonoClass.smethod_7<RewardBoxesDisplay>(TritonHs.MainAssemblyPath, "", "RewardBoxesDisplay", "s_Instance");
            }
        }

        [Attribute38("RewardBoxesDisplay.BoxRewardData")]
        public class BoxRewardData : MonoClass
        {
            public BoxRewardData(IntPtr address) : this(address, "BoxRewardData")
            {
            }

            public BoxRewardData(IntPtr address, string className) : base(address, className)
            {
            }

            public List<RewardBoxesDisplay.RewardPackageData> m_PackageData
            {
                get
                {
                    Class267<RewardBoxesDisplay.RewardPackageData> class2 = base.method_3<Class267<RewardBoxesDisplay.RewardPackageData>>("m_PackageData");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        public enum Events
        {
            GVG_PROMOTION
        }

        [Attribute38("RewardBoxesDisplay.RewardBoxData")]
        public class RewardBoxData : MonoClass
        {
            public RewardBoxData(IntPtr address) : this(address, "RewardBoxData")
            {
            }

            public RewardBoxData(IntPtr address, string className) : base(address, className)
            {
            }

            public GameObject m_GameObject
            {
                get
                {
                    return base.method_3<GameObject>("m_GameObject");
                }
            }

            public int m_Index
            {
                get
                {
                    return base.method_2<int>("m_Index");
                }
            }

            public RewardPackage m_RewardPackage
            {
                get
                {
                    return base.method_3<RewardPackage>("m_RewardPackage");
                }
            }
        }

        [Attribute38("RewardBoxesDisplay.RewardCardLoadData")]
        public class RewardCardLoadData : MonoClass
        {
            public RewardCardLoadData(IntPtr address) : this(address, "RewardCardLoadData")
            {
            }

            public RewardCardLoadData(IntPtr address, string className) : base(address, className)
            {
            }

            public CardRewardData m_CardRewardData
            {
                get
                {
                    return base.method_3<CardRewardData>("m_CardRewardData");
                }
            }

            public EntityDef m_EntityDef
            {
                get
                {
                    return base.method_3<EntityDef>("m_EntityDef");
                }
            }

            public Transform m_ParentTransform
            {
                get
                {
                    return base.method_3<Transform>("m_ParentTransform");
                }
            }
        }

        [Attribute38("RewardBoxesDisplay.RewardPackageData")]
        public class RewardPackageData : MonoClass
        {
            public RewardPackageData(IntPtr address) : this(address, "RewardPackageData")
            {
            }

            public RewardPackageData(IntPtr address, string className) : base(address, className)
            {
            }

            public Transform m_StartBone
            {
                get
                {
                    return base.method_3<Transform>("m_StartBone");
                }
            }

            public float m_StartDelay
            {
                get
                {
                    return base.method_2<float>("m_StartDelay");
                }
            }

            public Transform m_TargetBone
            {
                get
                {
                    return base.method_3<Transform>("m_TargetBone");
                }
            }
        }

        [Attribute38("RewardBoxesDisplay.RewardSet")]
        public class RewardSet : MonoClass
        {
            public RewardSet(IntPtr address) : this(address, "RewardSet")
            {
            }

            public RewardSet(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_AnimationTime
            {
                get
                {
                    return base.method_2<float>("m_AnimationTime");
                }
            }

            public GameObject m_RewardCard
            {
                get
                {
                    return base.method_3<GameObject>("m_RewardCard");
                }
            }

            public GameObject m_RewardCardBack
            {
                get
                {
                    return base.method_3<GameObject>("m_RewardCardBack");
                }
            }

            public List<RewardBoxesDisplay.BoxRewardData> m_RewardData
            {
                get
                {
                    Class267<RewardBoxesDisplay.BoxRewardData> class2 = base.method_3<Class267<RewardBoxesDisplay.BoxRewardData>>("m_RewardData");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public GameObject m_RewardDust
            {
                get
                {
                    return base.method_3<GameObject>("m_RewardDust");
                }
            }

            public GameObject m_RewardGold
            {
                get
                {
                    return base.method_3<GameObject>("m_RewardGold");
                }
            }

            public GameObject m_RewardPackage
            {
                get
                {
                    return base.method_3<GameObject>("m_RewardPackage");
                }
            }
        }
    }
}

