namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("RankChangeTwoScoop")]
    public class RankChangeTwoScoop : MonoBehaviour
    {
        public RankChangeTwoScoop(IntPtr address) : this(address, "RankChangeTwoScoop")
        {
        }

        public RankChangeTwoScoop(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateRankChange()
        {
            base.method_8("AnimateRankChange", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public float DecreaseStars(int lastWipeIndex, int firstWipeIndex)
        {
            object[] objArray1 = new object[] { lastWipeIndex, firstWipeIndex };
            return base.method_11<float>("DecreaseStars", objArray1);
        }

        public void DespawnOldStars()
        {
            base.method_8("DespawnOldStars", Array.Empty<object>());
        }

        public void DestroyRankChange()
        {
            base.method_8("DestroyRankChange", Array.Empty<object>());
        }

        public void Hide(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("Hide", objArray1);
        }

        public float IncreaseStars(int blinkToThisIndex, int burstToThisIndex)
        {
            object[] objArray1 = new object[] { blinkToThisIndex, burstToThisIndex };
            return base.method_11<float>("IncreaseStars", objArray1);
        }

        public void InitMedalsAndStars()
        {
            base.method_8("InitMedalsAndStars", Array.Empty<object>());
        }

        public void InitStars(int numEarned, int numTotal, bool fadeIn)
        {
            object[] objArray1 = new object[] { numEarned, numTotal, fadeIn };
            base.method_8("InitStars", objArray1);
        }

        public void LevelUpChanges()
        {
            base.method_8("LevelUpChanges", Array.Empty<object>());
        }

        public void OnBottomTextureLoaded(string assetName, object asset, object callbackData)
        {
            object[] objArray1 = new object[] { assetName, asset, callbackData };
            base.method_8("OnBottomTextureLoaded", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnTopTextureLoaded(string assetName, object asset, object callbackData)
        {
            object[] objArray1 = new object[] { assetName, asset, callbackData };
            base.method_8("OnTopTextureLoaded", objArray1);
        }

        public void PlayChestChange()
        {
            base.method_8("PlayChestChange", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void StartChestGlow()
        {
            base.method_8("StartChestGlow", Array.Empty<object>());
        }

        public void UpdateChestAfterLevelUp()
        {
            base.method_8("UpdateChestAfterLevelUp", Array.Empty<object>());
        }

        public void UpdateLegendText(int legendIndex)
        {
            object[] objArray1 = new object[] { legendIndex };
            base.method_8("UpdateLegendText", objArray1);
        }

        public void UpdateToCurrentChest()
        {
            base.method_8("UpdateToCurrentChest", Array.Empty<object>());
        }

        public void UpdateToFinalChest()
        {
            base.method_8("UpdateToFinalChest", Array.Empty<object>());
        }

        public Vector3 AFTER_PUNCH_SCALE
        {
            get
            {
                return base.method_2<Vector3>("AFTER_PUNCH_SCALE");
            }
        }

        public Vector3 END_SCALE
        {
            get
            {
                return base.method_2<Vector3>("END_SCALE");
            }
        }

        public GameObject m_bannerBottom
        {
            get
            {
                return base.method_3<GameObject>("m_bannerBottom");
            }
        }

        public GameObject m_bannerTop
        {
            get
            {
                return base.method_3<GameObject>("m_bannerTop");
            }
        }

        public int m_chestRank
        {
            get
            {
                return base.method_2<int>("m_chestRank");
            }
        }

        public List<RankChangeStar> m_chestStars
        {
            get
            {
                Class267<RankChangeStar> class2 = base.method_3<Class267<RankChangeStar>>("m_chestStars");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public TranslatedMedalInfo m_currMedalInfo
        {
            get
            {
                return base.method_3<TranslatedMedalInfo>("m_currMedalInfo");
            }
        }

        public PegUIElement m_debugClickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_debugClickCatcher");
            }
        }

        public List<Transform> m_evenStarBones
        {
            get
            {
                Class267<Transform> class2 = base.method_3<Class267<Transform>>("m_evenStarBones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Material m_legendaryMaterial
        {
            get
            {
                return base.method_3<Material>("m_legendaryMaterial");
            }
        }

        public UberText m_legendIndex
        {
            get
            {
                return base.method_3<UberText>("m_legendIndex");
            }
        }

        public GameObject m_medalContainer
        {
            get
            {
                return base.method_3<GameObject>("m_medalContainer");
            }
        }

        public MedalInfoTranslator m_medalInfoTranslator
        {
            get
            {
                return base.method_3<MedalInfoTranslator>("m_medalInfoTranslator");
            }
        }

        public UberText m_name
        {
            get
            {
                return base.method_3<UberText>("m_name");
            }
        }

        public int m_numTexturesLoading
        {
            get
            {
                return base.method_2<int>("m_numTexturesLoading");
            }
        }

        public List<Transform> m_oddStarBones
        {
            get
            {
                Class267<Transform> class2 = base.method_3<Class267<Transform>>("m_oddStarBones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public TranslatedMedalInfo m_prevMedalInfo
        {
            get
            {
                return base.method_3<TranslatedMedalInfo>("m_prevMedalInfo");
            }
        }

        public GameObject m_rankMedalBottom
        {
            get
            {
                return base.method_3<GameObject>("m_rankMedalBottom");
            }
        }

        public GameObject m_rankMedalTop
        {
            get
            {
                return base.method_3<GameObject>("m_rankMedalTop");
            }
        }

        public UberText m_rankNumberBottom
        {
            get
            {
                return base.method_3<UberText>("m_rankNumberBottom");
            }
        }

        public UberText m_rankNumberTop
        {
            get
            {
                return base.method_3<UberText>("m_rankNumberTop");
            }
        }

        public RankedRewardChest m_rewardChest
        {
            get
            {
                return base.method_3<RankedRewardChest>("m_rewardChest");
            }
        }

        public MeshRenderer m_rewardChestGlow
        {
            get
            {
                return base.method_3<MeshRenderer>("m_rewardChestGlow");
            }
        }

        public UberText m_rewardChestInstructions
        {
            get
            {
                return base.method_3<UberText>("m_rewardChestInstructions");
            }
        }

        public GameObject m_scrubRankDesc
        {
            get
            {
                return base.method_3<GameObject>("m_scrubRankDesc");
            }
        }

        public RankChangeStar m_starPrefab
        {
            get
            {
                return base.method_3<RankChangeStar>("m_starPrefab");
            }
        }

        public List<RankChangeStar> m_stars
        {
            get
            {
                Class267<RankChangeStar> class2 = base.method_3<Class267<RankChangeStar>>("m_stars");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_validPrevMedal
        {
            get
            {
                return base.method_2<bool>("m_validPrevMedal");
            }
        }

        public GameObject m_winStreakParent
        {
            get
            {
                return base.method_3<GameObject>("m_winStreakParent");
            }
        }

        public static float STAR_ACTION_DELAY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "RankChangeTwoScoop", "STAR_ACTION_DELAY");
            }
        }

        public Vector3 START_SCALE
        {
            get
            {
                return base.method_2<Vector3>("START_SCALE");
            }
        }
    }
}

