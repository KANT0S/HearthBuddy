namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureWing")]
    public class AdventureWing : MonoBehaviour
    {
        public AdventureWing(IntPtr address) : this(address, "AdventureWing")
        {
        }

        public AdventureWing(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BigChestStayOpen()
        {
            base.method_8("BigChestStayOpen", Array.Empty<object>());
        }

        public AdventureBossCoin CreateBoss(string coinPrefab, string rewardsPrefab, ScenarioDbId mission, bool enabled)
        {
            object[] objArray1 = new object[] { coinPrefab, rewardsPrefab, mission, enabled };
            return base.method_14<AdventureBossCoin>("CreateBoss", objArray1);
        }

        public void FireBossSelectedEvent(AdventureBossCoin coin, ScenarioDbId mission)
        {
            object[] objArray1 = new object[] { coin, mission };
            base.method_8("FireBossSelectedEvent", objArray1);
        }

        public void FireOpenPlateEndEvent(Spell s)
        {
            object[] objArray1 = new object[] { s };
            base.method_8("FireOpenPlateEndEvent", objArray1);
        }

        public void FireOpenPlateStartEvent()
        {
            base.method_8("FireOpenPlateStartEvent", Array.Empty<object>());
        }

        public void FireShowRewardsPreviewEvent()
        {
            base.method_8("FireShowRewardsPreviewEvent", Array.Empty<object>());
        }

        public void FireTryPurchaseWingEvent()
        {
            base.method_8("FireTryPurchaseWingEvent", Array.Empty<object>());
        }

        public AdventureDbId GetAdventureId()
        {
            return base.method_11<AdventureDbId>("GetAdventureId", Array.Empty<object>());
        }

        public List<CardRewardData> GetBigChestRewards()
        {
            Class267<CardRewardData> class2 = base.method_14<Class267<CardRewardData>>("GetBigChestRewards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<AdventureRewardsChest> GetChests()
        {
            Class267<AdventureRewardsChest> class2 = base.method_14<Class267<AdventureRewardsChest>>("GetChests", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetProductData()
        {
            return base.method_11<int>("GetProductData", Array.Empty<object>());
        }

        public AdventureWingDef GetWingDef()
        {
            return base.method_14<AdventureWingDef>("GetWingDef", Array.Empty<object>());
        }

        public WingDbId GetWingId()
        {
            return base.method_11<WingDbId>("GetWingId", Array.Empty<object>());
        }

        public string GetWingName()
        {
            return base.method_13("GetWingName", Array.Empty<object>());
        }

        public bool HasBigChestRewards()
        {
            return base.method_11<bool>("HasBigChestRewards", Array.Empty<object>());
        }

        public bool HasRewards()
        {
            return base.method_11<bool>("HasRewards", Array.Empty<object>());
        }

        public void HideBigChest()
        {
            base.method_8("HideBigChest", Array.Empty<object>());
        }

        public void HideBigChestRewards(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("HideBigChestRewards", objArray1);
        }

        public void HideBossRewards(ScenarioDbId mission)
        {
            object[] objArray1 = new object[] { mission };
            base.method_8("HideBossRewards", objArray1);
        }

        public void Initialize(AdventureWingDef wingDef, AdventureWingDef dependsOnWingDef)
        {
            object[] objArray1 = new object[] { wingDef, dependsOnWingDef };
            base.method_8("Initialize", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnUnlockButtonOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnUnlockButtonOut", objArray1);
        }

        public void OnUnlockButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnUnlockButtonOver", objArray1);
        }

        public void OnUnlockSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnUnlockSpellFinished", objArray1);
        }

        public void OpenBigChest()
        {
            base.method_8("OpenBigChest", Array.Empty<object>());
        }

        public void RandomizeBackground()
        {
            base.method_8("RandomizeBackground", Array.Empty<object>());
        }

        public void SetAccent(string accentPrefab)
        {
            object[] objArray1 = new object[] { accentPrefab };
            base.method_8("SetAccent", objArray1);
        }

        public void SetBigChestRewards(WingDbId wingId)
        {
            object[] objArray1 = new object[] { wingId };
            base.method_8("SetBigChestRewards", objArray1);
        }

        public void ShowBigChestRewards(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ShowBigChestRewards", objArray1);
        }

        public void ShowBossRewards(ScenarioDbId mission, Vector3 origin)
        {
            object[] objArray1 = new object[] { mission, origin };
            base.method_8("ShowBossRewards", objArray1);
        }

        public void UnlockPlate(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("UnlockPlate", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateBossChest(AdventureRewardsChest chest, ScenarioDbId mission)
        {
            object[] objArray1 = new object[] { chest, mission };
            base.method_8("UpdateBossChest", objArray1);
        }

        public void UpdateBuyButton(bool isOpen, object userData)
        {
            object[] objArray1 = new object[] { isOpen, userData };
            base.method_8("UpdateBuyButton", objArray1);
        }

        public void UpdateCoinPositions()
        {
            base.method_8("UpdateCoinPositions", Array.Empty<object>());
        }

        public void UpdatePlateState()
        {
            base.method_8("UpdatePlateState", Array.Empty<object>());
        }

        public void UpdatePurchasedBanner()
        {
            base.method_8("UpdatePurchasedBanner", Array.Empty<object>());
        }

        public void UpdateRewardsPreviewCover()
        {
            base.method_8("UpdateRewardsPreviewCover", Array.Empty<object>());
        }

        public Vector3 CoinsChestOffset
        {
            get
            {
                return base.method_11<Vector3>("get_CoinsChestOffset", Array.Empty<object>());
            }
        }

        public Vector3 CoinsOffset
        {
            get
            {
                return base.method_11<Vector3>("get_CoinsOffset", Array.Empty<object>());
            }
        }

        public float CoinSpacing
        {
            get
            {
                return base.method_11<float>("get_CoinSpacing", Array.Empty<object>());
            }
        }

        public List<float> m_BackgroundOffsets
        {
            get
            {
                Class266<float> class2 = base.method_3<Class266<float>>("m_BackgroundOffsets");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BackgroundRandomization> m_BackgroundRenderers
        {
            get
            {
                Class267<BackgroundRandomization> class2 = base.method_3<Class267<BackgroundRandomization>>("m_BackgroundRenderers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public PegUIElement m_BigChest
        {
            get
            {
                return base.method_3<PegUIElement>("m_BigChest");
            }
        }

        public List<Boss> m_BossCoins
        {
            get
            {
                Class267<Boss> class2 = base.method_3<Class267<Boss>>("m_BossCoins");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public PegUIElement m_BuyButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_BuyButton");
            }
        }

        public MeshRenderer m_BuyButtonMesh
        {
            get
            {
                return base.method_3<MeshRenderer>("m_BuyButtonMesh");
            }
        }

        public UberText m_BuyButtonText
        {
            get
            {
                return base.method_3<UberText>("m_BuyButtonText");
            }
        }

        public GameObject m_CoinContainer
        {
            get
            {
                return base.method_3<GameObject>("m_CoinContainer");
            }
        }

        public Vector3 m_CoinsChestOffset
        {
            get
            {
                return base.method_2<Vector3>("m_CoinsChestOffset");
            }
        }

        public Vector3 m_CoinsOffset
        {
            get
            {
                return base.method_2<Vector3>("m_CoinsOffset");
            }
        }

        public float m_CoinSpacing
        {
            get
            {
                return base.method_2<float>("m_CoinSpacing");
            }
        }

        public GameObject m_ContentsContainer
        {
            get
            {
                return base.method_3<GameObject>("m_ContentsContainer");
            }
        }

        public AdventureWingDef m_DependsOnWingDef
        {
            get
            {
                return base.method_3<AdventureWingDef>("m_DependsOnWingDef");
            }
        }

        public bool m_EventStartDetected
        {
            get
            {
                return base.method_2<bool>("m_EventStartDetected");
            }
        }

        public GameObject m_LockPlate
        {
            get
            {
                return base.method_3<GameObject>("m_LockPlate");
            }
        }

        public GameObject m_LockPlateFXContainer
        {
            get
            {
                return base.method_3<GameObject>("m_LockPlateFXContainer");
            }
        }

        public bool m_Owned
        {
            get
            {
                return base.method_2<bool>("m_Owned");
            }
        }

        public GameObject m_PlateAccentContainer
        {
            get
            {
                return base.method_3<GameObject>("m_PlateAccentContainer");
            }
        }

        public GameObject m_PlateAccentObject
        {
            get
            {
                return base.method_3<GameObject>("m_PlateAccentObject");
            }
        }

        public bool m_Playable
        {
            get
            {
                return base.method_2<bool>("m_Playable");
            }
        }

        public GameObject m_PurchasedBanner
        {
            get
            {
                return base.method_3<GameObject>("m_PurchasedBanner");
            }
        }

        public UberText m_ReleaseLabelText
        {
            get
            {
                return base.method_3<UberText>("m_ReleaseLabelText");
            }
        }

        public PegUIElement m_RewardsPreviewButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_RewardsPreviewButton");
            }
        }

        public PegUIElement m_UnlockButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_UnlockButton");
            }
        }

        public float m_UnlockButtonHighlightIntensityOut
        {
            get
            {
                return base.method_2<float>("m_UnlockButtonHighlightIntensityOut");
            }
        }

        public float m_UnlockButtonHighlightIntensityOver
        {
            get
            {
                return base.method_2<float>("m_UnlockButtonHighlightIntensityOver");
            }
        }

        public MeshRenderer m_UnlockButtonHighlightMesh_LOE
        {
            get
            {
                return base.method_3<MeshRenderer>("m_UnlockButtonHighlightMesh_LOE");
            }
        }

        public Spell m_UnlockSpell
        {
            get
            {
                return base.method_3<Spell>("m_UnlockSpell");
            }
        }

        public GameObject m_WallAccentContainer
        {
            get
            {
                return base.method_3<GameObject>("m_WallAccentContainer");
            }
        }

        public GameObject m_WallAccentObject
        {
            get
            {
                return base.method_3<GameObject>("m_WallAccentObject");
            }
        }

        public AdventureWingDef m_WingDef
        {
            get
            {
                return base.method_3<AdventureWingDef>("m_WingDef");
            }
        }

        public AdventureWingEventTable m_WingEventTable
        {
            get
            {
                return base.method_3<AdventureWingEventTable>("m_WingEventTable");
            }
        }

        public List<UberText> m_WingTitles
        {
            get
            {
                Class267<UberText> class2 = base.method_3<Class267<UberText>>("m_WingTitles");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static List<int> s_LastRandomNumbers
        {
            get
            {
                Class266<int> class2 = MonoClass.smethod_7<Class266<int>>(TritonHs.MainAssemblyPath, "", "AdventureWing", "s_LastRandomNumbers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        [Attribute38("AdventureWing.BackgroundRandomization")]
        public class BackgroundRandomization : MonoClass
        {
            public BackgroundRandomization(IntPtr address) : this(address, "BackgroundRandomization")
            {
            }

            public BackgroundRandomization(IntPtr address, string className) : base(address, className)
            {
            }

            public MeshRenderer m_backgroundRenderer
            {
                get
                {
                    return base.method_3<MeshRenderer>("m_backgroundRenderer");
                }
            }

            public string m_materialTextureName
            {
                get
                {
                    return base.method_4("m_materialTextureName");
                }
            }
        }

        [Attribute38("AdventureWing.Boss")]
        public class Boss : MonoClass
        {
            public Boss(IntPtr address) : this(address, "Boss")
            {
            }

            public Boss(IntPtr address, string className) : base(address, className)
            {
            }

            public AdventureRewardsChest m_Chest
            {
                get
                {
                    return base.method_3<AdventureRewardsChest>("m_Chest");
                }
            }

            public AdventureBossCoin m_Coin
            {
                get
                {
                    return base.method_3<AdventureBossCoin>("m_Coin");
                }
            }

            public ScenarioDbId m_Mission
            {
                get
                {
                    return base.method_2<ScenarioDbId>("m_Mission");
                }
            }
        }
    }
}

