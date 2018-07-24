namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureMissionDisplay")]
    public class AdventureMissionDisplay : MonoBehaviour
    {
        public AdventureMissionDisplay(IntPtr address) : this(address, "AdventureMissionDisplay")
        {
        }

        public AdventureMissionDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddAssetToLoad(int assetCount)
        {
            object[] objArray1 = new object[] { assetCount };
            base.method_8("AddAssetToLoad", objArray1);
        }

        public void AssetLoadCompleted()
        {
            base.method_8("AssetLoadCompleted", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public int BossCreateParamsSortComparison(BossCreateParams params1, BossCreateParams params2)
        {
            object[] objArray1 = new object[] { params1, params2 };
            return base.method_11<int>("BossCreateParamsSortComparison", objArray1);
        }

        public void BringWingToFocus(float scrollPos)
        {
            object[] objArray1 = new object[] { scrollPos };
            base.method_8("BringWingToFocus", objArray1);
        }

        public List<WingCreateParams> BuildWingCreateParamsList()
        {
            Class267<WingCreateParams> class2 = base.method_14<Class267<WingCreateParams>>("BuildWingCreateParamsList", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void ChangeToDeckPicker()
        {
            base.method_8("ChangeToDeckPicker", Array.Empty<object>());
        }

        public Vector3 DetermineCharacterQuotePos(GameObject coin)
        {
            object[] objArray1 = new object[] { coin };
            return base.method_11<Vector3>("DetermineCharacterQuotePos", objArray1);
        }

        public void DisableSelection(bool yes)
        {
            object[] objArray1 = new object[] { yes };
            base.method_8("DisableSelection", objArray1);
        }

        public void DoAutoPurchaseWings(AdventureDbId selectedAdv, AdventureModeDbId selectedMode)
        {
            object[] objArray1 = new object[] { selectedAdv, selectedMode };
            base.method_8("DoAutoPurchaseWings", objArray1);
        }

        public static AdventureMissionDisplay Get()
        {
            return MonoClass.smethod_15<AdventureMissionDisplay>(TritonHs.MainAssemblyPath, "", "AdventureMissionDisplay", "Get", Array.Empty<object>());
        }

        public void HideHeroPowerBigCard()
        {
            base.method_8("HideHeroPowerBigCard", Array.Empty<object>());
        }

        public bool IsDisabledSelection()
        {
            return base.method_11<bool>("IsDisabledSelection", Array.Empty<object>());
        }

        public Actor OnActorLoaded(string actorName, GameObject actorObject, GameObject container)
        {
            object[] objArray1 = new object[] { actorName, actorObject, container };
            return base.method_14<Actor>("OnActorLoaded", objArray1);
        }

        public void OnAdventureProgressUpdate(bool isStartupAction, AdventureMission.WingProgress oldProgress, AdventureMission.WingProgress newProgress, object userData)
        {
            object[] objArray1 = new object[] { isStartupAction, oldProgress, newProgress, userData };
            base.method_8("OnAdventureProgressUpdate", objArray1);
        }

        public void OnBackButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBackButtonPress", objArray1);
        }

        public void OnBossSelected(AdventureBossCoin coin, ScenarioDbId mission, bool showDetails)
        {
            object[] objArray1 = new object[] { coin, mission, showDetails };
            base.method_8("OnBossSelected", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnEndUnlockPlate(AdventureWing wing)
        {
            object[] objArray1 = new object[] { wing };
            base.method_8("OnEndUnlockPlate", objArray1);
        }

        public void OnHeroActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnHeroActorLoaded", objArray1);
        }

        public void OnHeroFullDefLoaded(string cardId, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardId, def, userData };
            base.method_8("OnHeroFullDefLoaded", objArray1);
        }

        public void OnHeroPowerActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnHeroPowerActorLoaded", objArray1);
        }

        public void OnHeroPowerBigCardLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnHeroPowerBigCardLoaded", objArray1);
        }

        public void OnHeroPowerFullDefLoaded(string cardId, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardId, def, userData };
            base.method_8("OnHeroPowerFullDefLoaded", objArray1);
        }

        public void OnHideRewardsPreview()
        {
            base.method_8("OnHideRewardsPreview", Array.Empty<object>());
        }

        public static bool OnNavigateBack()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AdventureMissionDisplay", "OnNavigateBack", Array.Empty<object>());
        }

        public void OnRewardObjectLoaded(Reward reward, object callbackData)
        {
            object[] objArray1 = new object[] { reward, callbackData };
            base.method_8("OnRewardObjectLoaded", objArray1);
        }

        public void OnStartUnlockPlate(AdventureWing wing)
        {
            object[] objArray1 = new object[] { wing };
            base.method_8("OnStartUnlockPlate", objArray1);
        }

        public void OnStoreHidden(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnStoreHidden", objArray1);
        }

        public void OnStoreShown(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnStoreShown", objArray1);
        }

        public void OnSubSceneLoaded()
        {
            base.method_8("OnSubSceneLoaded", Array.Empty<object>());
        }

        public void OnSubSceneTransitionComplete()
        {
            base.method_8("OnSubSceneTransitionComplete", Array.Empty<object>());
        }

        public void OnZeroCostTransactionStoreExit(bool authorizationBackButtonPressed, object userData)
        {
            object[] objArray1 = new object[] { authorizationBackButtonPressed, userData };
            base.method_8("OnZeroCostTransactionStoreExit", objArray1);
        }

        public void PlayMissionQuote(AdventureBossDef bossDef, Vector3 position)
        {
            object[] objArray1 = new object[] { bossDef, position };
            base.method_8("PlayMissionQuote", objArray1);
        }

        public void PositionReward(Reward reward)
        {
            object[] objArray1 = new object[] { reward };
            base.method_8("PositionReward", objArray1);
        }

        public void ResumeMainMusic()
        {
            base.method_8("ResumeMainMusic", Array.Empty<object>());
        }

        public void ShowAdventureComplete()
        {
            base.method_8("ShowAdventureComplete", Array.Empty<object>());
        }

        public void ShowAdventureStore(AdventureWing selectedWing)
        {
            object[] objArray1 = new object[] { selectedWing };
            base.method_8("ShowAdventureStore", objArray1);
        }

        public void ShowBossFrame(ScenarioDbId mission)
        {
            object[] objArray1 = new object[] { mission };
            base.method_8("ShowBossFrame", objArray1);
        }

        public void ShowHeroPowerBigCard()
        {
            base.method_8("ShowHeroPowerBigCard", Array.Empty<object>());
        }

        public void UnselectBoss()
        {
            base.method_8("UnselectBoss", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateWingPositions()
        {
            base.method_8("UpdateWingPositions", Array.Empty<object>());
        }

        public int WingCreateParamsSortComparison(WingCreateParams params1, WingCreateParams params2)
        {
            object[] objArray1 = new object[] { params1, params2 };
            return base.method_11<int>("WingCreateParamsSortComparison", objArray1);
        }

        public float BossWingHeight
        {
            get
            {
                return base.method_11<float>("get_BossWingHeight", Array.Empty<object>());
            }
        }

        public Vector3 BossWingOffset
        {
            get
            {
                return base.method_11<Vector3>("get_BossWingOffset", Array.Empty<object>());
            }
        }

        public UberText m_AdventureTitle
        {
            get
            {
                return base.method_3<UberText>("m_AdventureTitle");
            }
        }

        public int m_AssetsLoading
        {
            get
            {
                return base.method_2<int>("m_AssetsLoading");
            }
        }

        public PegUIElement m_BackButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_BackButton");
            }
        }

        public Actor m_BossActor
        {
            get
            {
                return base.method_3<Actor>("m_BossActor");
            }
        }

        public UberText m_BossDescription
        {
            get
            {
                return base.method_3<UberText>("m_BossDescription");
            }
        }

        public bool m_BossJustDefeated
        {
            get
            {
                return base.method_2<bool>("m_BossJustDefeated");
            }
        }

        public GameObject m_BossPortraitContainer
        {
            get
            {
                return base.method_3<GameObject>("m_BossPortraitContainer");
            }
        }

        public Actor m_BossPowerActor
        {
            get
            {
                return base.method_3<Actor>("m_BossPowerActor");
            }
        }

        public Actor m_BossPowerBigCard
        {
            get
            {
                return base.method_3<Actor>("m_BossPowerBigCard");
            }
        }

        public float m_BossPowerCardScale
        {
            get
            {
                return base.method_2<float>("m_BossPowerCardScale");
            }
        }

        public GameObject m_BossPowerContainer
        {
            get
            {
                return base.method_3<GameObject>("m_BossPowerContainer");
            }
        }

        public PegUIElement m_BossPowerHoverArea
        {
            get
            {
                return base.method_3<PegUIElement>("m_BossPowerHoverArea");
            }
        }

        public UberText m_BossTitle
        {
            get
            {
                return base.method_3<UberText>("m_BossTitle");
            }
        }

        public GameObject m_BossWingBorder
        {
            get
            {
                return base.method_3<GameObject>("m_BossWingBorder");
            }
        }

        public GameObject m_BossWingContainer
        {
            get
            {
                return base.method_3<GameObject>("m_BossWingContainer");
            }
        }

        public float m_BossWingHeight
        {
            get
            {
                return base.method_2<float>("m_BossWingHeight");
            }
        }

        public Vector3 m_BossWingOffset
        {
            get
            {
                return base.method_2<Vector3>("m_BossWingOffset");
            }
        }

        public List<AdventureWing> m_BossWings
        {
            get
            {
                Class267<AdventureWing> class2 = base.method_3<Class267<AdventureWing>>("m_BossWings");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public PlayButton m_ChooseButton
        {
            get
            {
                return base.method_3<PlayButton>("m_ChooseButton");
            }
        }

        public int m_ClassChallengeUnlockShowing
        {
            get
            {
                return base.method_2<int>("m_ClassChallengeUnlockShowing");
            }
        }

        public GameObject m_ClickBlocker
        {
            get
            {
                return base.method_3<GameObject>("m_ClickBlocker");
            }
        }

        public float m_CoinFlipAnimationTime
        {
            get
            {
                return base.method_2<float>("m_CoinFlipAnimationTime");
            }
        }

        public float m_CoinFlipDelayTime
        {
            get
            {
                return base.method_2<float>("m_CoinFlipDelayTime");
            }
        }

        public int m_DisableSelectionCount
        {
            get
            {
                return base.method_2<int>("m_DisableSelectionCount");
            }
        }

        public MusicPlaylistType m_mainMusic
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_mainMusic");
            }
        }

        public AdventureRewardsPreview m_PreviewPane
        {
            get
            {
                return base.method_3<AdventureRewardsPreview>("m_PreviewPane");
            }
        }

        public AdventureWingProgressDisplay m_progressDisplay
        {
            get
            {
                return base.method_3<AdventureWingProgressDisplay>("m_progressDisplay");
            }
        }

        public AdventureRewardsDisplayArea m_RewardsDisplay
        {
            get
            {
                return base.method_3<AdventureRewardsDisplayArea>("m_RewardsDisplay");
            }
        }

        public UIBScrollable m_ScrollBar
        {
            get
            {
                return base.method_3<UIBScrollable>("m_ScrollBar");
            }
        }

        public AdventureBossCoin m_SelectedCoin
        {
            get
            {
                return base.method_3<AdventureBossCoin>("m_SelectedCoin");
            }
        }

        public FullDef m_SelectedHeroPowerFullDef
        {
            get
            {
                return base.method_3<FullDef>("m_SelectedHeroPowerFullDef");
            }
        }

        public bool m_ShowingRewardsPreview
        {
            get
            {
                return base.method_2<bool>("m_ShowingRewardsPreview");
            }
        }

        public int m_TotalBosses
        {
            get
            {
                return base.method_2<int>("m_TotalBosses");
            }
        }

        public int m_TotalBossesDefeated
        {
            get
            {
                return base.method_2<int>("m_TotalBossesDefeated");
            }
        }

        public bool m_WaitingForClassChallengeUnlocks
        {
            get
            {
                return base.method_2<bool>("m_WaitingForClassChallengeUnlocks");
            }
        }

        public MeshRenderer m_WatermarkIcon
        {
            get
            {
                return base.method_3<MeshRenderer>("m_WatermarkIcon");
            }
        }

        public List<AdventureWing> m_WingsToGiveBigChest
        {
            get
            {
                Class267<AdventureWing> class2 = base.method_3<Class267<AdventureWing>>("m_WingsToGiveBigChest");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static Vector3 REWARD_PUNCH_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "AdventureMissionDisplay", "REWARD_PUNCH_SCALE");
            }
        }

        public static Vector3 REWARD_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "AdventureMissionDisplay", "REWARD_SCALE");
            }
        }

        public static float s_ScreenBackTransitionDelay
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AdventureMissionDisplay", "s_ScreenBackTransitionDelay");
            }
        }

        [Attribute38("AdventureMissionDisplay.BossCreateParams")]
        public class BossCreateParams : MonoClass
        {
            public BossCreateParams(IntPtr address) : this(address, "BossCreateParams")
            {
            }

            public BossCreateParams(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_CardDefId
            {
                get
                {
                    return base.method_4("m_CardDefId");
                }
            }

            public ScenarioDbId m_MissionId
            {
                get
                {
                    return base.method_2<ScenarioDbId>("m_MissionId");
                }
            }

            public ScenarioDbfRecord m_ScenarioRecord
            {
                get
                {
                    return base.method_3<ScenarioDbfRecord>("m_ScenarioRecord");
                }
            }
        }

        [Attribute38("AdventureMissionDisplay.BossInfo")]
        public class BossInfo : MonoClass
        {
            public BossInfo(IntPtr address) : this(address, "BossInfo")
            {
            }

            public BossInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_Description
            {
                get
                {
                    return base.method_4("m_Description");
                }
            }

            public string m_Title
            {
                get
                {
                    return base.method_4("m_Title");
                }
            }
        }

        [Attribute38("AdventureMissionDisplay.WingCreateParams")]
        public class WingCreateParams : MonoClass
        {
            public WingCreateParams(IntPtr address) : this(address, "WingCreateParams")
            {
            }

            public WingCreateParams(IntPtr address, string className) : base(address, className)
            {
            }

            public List<AdventureMissionDisplay.BossCreateParams> m_BossCreateParams
            {
                get
                {
                    Class267<AdventureMissionDisplay.BossCreateParams> class2 = base.method_3<Class267<AdventureMissionDisplay.BossCreateParams>>("m_BossCreateParams");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public AdventureWingDef m_WingDef
            {
                get
                {
                    return base.method_3<AdventureWingDef>("m_WingDef");
                }
            }
        }
    }
}

