namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SeasonEndDialog")]
    public class SeasonEndDialog : DialogBase
    {
        public SeasonEndDialog(IntPtr address) : this(address, "SeasonEndDialog")
        {
        }

        public SeasonEndDialog(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ChestButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ChestButtonReleased", objArray1);
        }

        public void FadeEffectsIn()
        {
            base.method_8("FadeEffectsIn", Array.Empty<object>());
        }

        public void FadeEffectsOut()
        {
            base.method_8("FadeEffectsOut", Array.Empty<object>());
        }

        public string GetInlineSeasonName(int seasonID)
        {
            object[] objArray1 = new object[] { seasonID };
            return base.method_13("GetInlineSeasonName", objArray1);
        }

        public static string GetRankPercentile(int rank)
        {
            object[] objArray1 = new object[] { rank };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "SeasonEndDialog", "GetRankPercentile", objArray1);
        }

        public string GetSeasonName(int seasonID)
        {
            object[] objArray1 = new object[] { seasonID };
            return base.method_13("GetSeasonName", objArray1);
        }

        public void GotoBonusStars()
        {
            base.method_8("GotoBonusStars", Array.Empty<object>());
        }

        public void GotoBonusStarsOrWelcome()
        {
            base.method_8("GotoBonusStarsOrWelcome", Array.Empty<object>());
        }

        public void GotoBoostedMedal()
        {
            base.method_8("GotoBoostedMedal", Array.Empty<object>());
        }

        public void GotoSeasonWelcome()
        {
            base.method_8("GotoSeasonWelcome", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideBonusStarText()
        {
            base.method_8("HideBonusStarText", Array.Empty<object>());
        }

        public void HideMedal()
        {
            base.method_8("HideMedal", Array.Empty<object>());
        }

        public void HideRewardChest()
        {
            base.method_8("HideRewardChest", Array.Empty<object>());
        }

        public void Init(SeasonEndInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("Init", objArray1);
        }

        public void MedalAnimationFinished()
        {
            base.method_8("MedalAnimationFinished", Array.Empty<object>());
        }

        public void MedalInFinished()
        {
            base.method_8("MedalInFinished", Array.Empty<object>());
        }

        public void OkayButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OkayButtonReleased", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnHideAnimFinished()
        {
            base.method_8("OnHideAnimFinished", Array.Empty<object>());
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void OpenRewards()
        {
            base.method_8("OpenRewards", Array.Empty<object>());
        }

        public void PageTearFinished()
        {
            base.method_8("PageTearFinished", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowMedal()
        {
            base.method_8("ShowMedal", Array.Empty<object>());
        }

        public void ShowRewardChest()
        {
            base.method_8("ShowRewardChest", Array.Empty<object>());
        }

        public void StarBurstFinished()
        {
            base.method_8("StarBurstFinished", Array.Empty<object>());
        }

        public GameObject m_bonusStar
        {
            get
            {
                return base.method_3<GameObject>("m_bonusStar");
            }
        }

        public GameObject m_bonusStarFlourish
        {
            get
            {
                return base.method_3<GameObject>("m_bonusStarFlourish");
            }
        }

        public GameObject m_bonusStarItems
        {
            get
            {
                return base.method_3<GameObject>("m_bonusStarItems");
            }
        }

        public UberText m_bonusStarLabel
        {
            get
            {
                return base.method_3<UberText>("m_bonusStarLabel");
            }
        }

        public int m_bonusStars
        {
            get
            {
                return base.method_2<int>("m_bonusStars");
            }
        }

        public UberText m_bonusStarText
        {
            get
            {
                return base.method_3<UberText>("m_bonusStarText");
            }
        }

        public UberText m_bonusStarTitle
        {
            get
            {
                return base.method_3<UberText>("m_bonusStarTitle");
            }
        }

        public GameObject m_boostedMedalBone
        {
            get
            {
                return base.method_3<GameObject>("m_boostedMedalBone");
            }
        }

        public GameObject m_boostedMedalLeftFiligreeBone
        {
            get
            {
                return base.method_3<GameObject>("m_boostedMedalLeftFiligreeBone");
            }
        }

        public GameObject m_boostedMedalRightFiligreeBone
        {
            get
            {
                return base.method_3<GameObject>("m_boostedMedalRightFiligreeBone");
            }
        }

        public bool m_chestOpened
        {
            get
            {
                return base.method_2<bool>("m_chestOpened");
            }
        }

        public MODE m_currentMode
        {
            get
            {
                return base.method_2<MODE>("m_currentMode");
            }
        }

        public bool m_earnedRewardChest
        {
            get
            {
                return base.method_2<bool>("m_earnedRewardChest");
            }
        }

        public UberText m_header
        {
            get
            {
                return base.method_3<UberText>("m_header");
            }
        }

        public GameObject m_leftFiligree
        {
            get
            {
                return base.method_3<GameObject>("m_leftFiligree");
            }
        }

        public GameObject m_legendaryGem
        {
            get
            {
                return base.method_3<GameObject>("m_legendaryGem");
            }
        }

        public Vector3 m_loadPosition
        {
            get
            {
                return base.method_2<Vector3>("m_loadPosition");
            }
        }

        public TournamentMedal m_medal
        {
            get
            {
                return base.method_3<TournamentMedal>("m_medal");
            }
        }

        public GameObject m_nameFlourish
        {
            get
            {
                return base.method_3<GameObject>("m_nameFlourish");
            }
        }

        public UIBButton m_okayButton
        {
            get
            {
                return base.method_3<UIBButton>("m_okayButton");
            }
        }

        public UberText m_rankAchieved
        {
            get
            {
                return base.method_3<UberText>("m_rankAchieved");
            }
        }

        public UberText m_rankName
        {
            get
            {
                return base.method_3<UberText>("m_rankName");
            }
        }

        public UberText m_rankPercentile
        {
            get
            {
                return base.method_3<UberText>("m_rankPercentile");
            }
        }

        public GameObject m_rewardBoxesBone
        {
            get
            {
                return base.method_3<GameObject>("m_rewardBoxesBone");
            }
        }

        public PegUIElement m_rewardChest
        {
            get
            {
                return base.method_3<PegUIElement>("m_rewardChest");
            }
        }

        public UberText m_rewardChestHeader
        {
            get
            {
                return base.method_3<UberText>("m_rewardChestHeader");
            }
        }

        public UberText m_rewardChestInstructions
        {
            get
            {
                return base.method_3<UberText>("m_rewardChestInstructions");
            }
        }

        public GameObject m_rewardChestLeftFiligreeBone
        {
            get
            {
                return base.method_3<GameObject>("m_rewardChestLeftFiligreeBone");
            }
        }

        public GameObject m_rewardChestPage
        {
            get
            {
                return base.method_3<GameObject>("m_rewardChestPage");
            }
        }

        public GameObject m_rewardChestRightFiligreeBone
        {
            get
            {
                return base.method_3<GameObject>("m_rewardChestRightFiligreeBone");
            }
        }

        public List<PegUIElement> m_rewardChests
        {
            get
            {
                Class267<PegUIElement> class2 = base.method_3<Class267<PegUIElement>>("m_rewardChests");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_ribbon
        {
            get
            {
                return base.method_3<GameObject>("m_ribbon");
            }
        }

        public GameObject m_rightFiligree
        {
            get
            {
                return base.method_3<GameObject>("m_rightFiligree");
            }
        }

        public SeasonEndInfo m_seasonEndInfo
        {
            get
            {
                return base.method_3<SeasonEndInfo>("m_seasonEndInfo");
            }
        }

        public GameObject m_shieldIcon
        {
            get
            {
                return base.method_3<GameObject>("m_shieldIcon");
            }
        }

        public Vector3 m_showPosition
        {
            get
            {
                return base.method_2<Vector3>("m_showPosition");
            }
        }

        public Material m_transparentMaterial
        {
            get
            {
                return base.method_3<Material>("m_transparentMaterial");
            }
        }

        public UberText m_welcomeDetails
        {
            get
            {
                return base.method_3<UberText>("m_welcomeDetails");
            }
        }

        public GameObject m_welcomeItems
        {
            get
            {
                return base.method_3<GameObject>("m_welcomeItems");
            }
        }

        public UberText m_welcomeTitle
        {
            get
            {
                return base.method_3<UberText>("m_welcomeTitle");
            }
        }

        public static List<string> s_percentiles
        {
            get
            {
                Class245 class2 = MonoClass.smethod_7<Class245>(TritonHs.MainAssemblyPath, "", "SeasonEndDialog", "s_percentiles");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool TESTING
        {
            get
            {
                return base.method_2<bool>("TESTING");
            }
        }

        public enum MODE
        {
            RANK_EARNED,
            CHEST_EARNED,
            SEASON_WELCOME,
            BONUS_STARS,
            BOOSTED_WELCOME
        }

        [Attribute38("SeasonEndDialog.SeasonEndInfo")]
        public class SeasonEndInfo : MonoClass
        {
            public SeasonEndInfo(IntPtr address) : this(address, "SeasonEndInfo")
            {
            }

            public SeasonEndInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_bonusStars
            {
                get
                {
                    return base.method_2<int>("m_bonusStars");
                }
            }

            public int m_boostedRank
            {
                get
                {
                    return base.method_2<int>("m_boostedRank");
                }
            }

            public int m_chestRank
            {
                get
                {
                    return base.method_2<int>("m_chestRank");
                }
            }

            public bool m_isFake
            {
                get
                {
                    return base.method_2<bool>("m_isFake");
                }
            }

            public int m_legendIndex
            {
                get
                {
                    return base.method_2<int>("m_legendIndex");
                }
            }

            public List<long> m_noticesToAck
            {
                get
                {
                    Class266<long> class2 = base.method_3<Class266<long>>("m_noticesToAck");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public int m_rank
            {
                get
                {
                    return base.method_2<int>("m_rank");
                }
            }

            public List<RewardData> m_rankedRewards
            {
                get
                {
                    Class267<RewardData> class2 = base.method_3<Class267<RewardData>>("m_rankedRewards");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public int m_seasonID
            {
                get
                {
                    return base.method_2<int>("m_seasonID");
                }
            }
        }
    }
}

