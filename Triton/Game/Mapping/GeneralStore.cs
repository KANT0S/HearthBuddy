namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GeneralStore")]
    public class GeneralStore : Store
    {
        public GeneralStore(IntPtr address) : this(address, "GeneralStore")
        {
        }

        public GeneralStore(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BuyWithGold(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("BuyWithGold", objArray1);
        }

        public void BuyWithMoney(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("BuyWithMoney", objArray1);
        }

        public void Close()
        {
            base.method_9("Close", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Close(bool closeWithAnimation)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { closeWithAnimation };
            base.method_9("Close", enumArray1, objArray1);
        }

        public void CloseImpl(bool closeWithAnimation)
        {
            object[] objArray1 = new object[] { closeWithAnimation };
            base.method_8("CloseImpl", objArray1);
        }

        public void FireModeChangedEvent(GeneralStoreMode oldMode, GeneralStoreMode newMode)
        {
            object[] objArray1 = new object[] { oldMode, newMode };
            base.method_8("FireModeChangedEvent", objArray1);
        }

        public static GeneralStore Get()
        {
            return MonoClass.smethod_15<GeneralStore>(TritonHs.MainAssemblyPath, "", "GeneralStore", "Get", Array.Empty<object>());
        }

        public GameObject GetBuyPanelObject(BuyPanelState buyPanelState)
        {
            object[] objArray1 = new object[] { buyPanelState };
            return base.method_14<GameObject>("GetBuyPanelObject", objArray1);
        }

        public GeneralStoreContent GetContent(GeneralStoreMode mode)
        {
            object[] objArray1 = new object[] { mode };
            return base.method_14<GeneralStoreContent>("GetContent", objArray1);
        }

        public GeneralStoreContent GetCurrentContent()
        {
            return base.method_14<GeneralStoreContent>("GetCurrentContent", Array.Empty<object>());
        }

        public GeneralStorePane GetCurrentPane()
        {
            return base.method_14<GeneralStorePane>("GetCurrentPane", Array.Empty<object>());
        }

        public GeneralStoreMode GetMode()
        {
            return base.method_11<GeneralStoreMode>("GetMode", Array.Empty<object>());
        }

        public string GetOwnedTooltipString()
        {
            return base.method_13("GetOwnedTooltipString", Array.Empty<object>());
        }

        public GeneralStorePane GetPane(GeneralStoreMode mode)
        {
            object[] objArray1 = new object[] { mode };
            return base.method_14<GeneralStorePane>("GetPane", objArray1);
        }

        public void Hide(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            base.method_8("Hide", objArray1);
        }

        public void HideAccentTexture()
        {
            base.method_8("HideAccentTexture", Array.Empty<object>());
        }

        public void HideChooseDescription()
        {
            base.method_8("HideChooseDescription", Array.Empty<object>());
        }

        public void HideDescription()
        {
            base.method_8("HideDescription", Array.Empty<object>());
        }

        public bool IsContentFlipClockwise(GeneralStoreMode oldMode, GeneralStoreMode newMode)
        {
            object[] objArray1 = new object[] { oldMode, newMode };
            return base.method_11<bool>("IsContentFlipClockwise", objArray1);
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public void OnClosePressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnClosePressed", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnGoldBalanceChanged(NetCache.NetCacheGoldBalance balance)
        {
            object[] objArray1 = new object[] { balance };
            base.method_8("OnGoldBalanceChanged", objArray1);
        }

        public void OnGoldSpent()
        {
            base.method_8("OnGoldSpent", Array.Empty<object>());
        }

        public void OnHidden()
        {
            base.method_8("OnHidden", Array.Empty<object>());
        }

        public void OnMoneySpent()
        {
            base.method_8("OnMoneySpent", Array.Empty<object>());
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void OnStopShaking(object obj)
        {
            object[] objArray1 = new object[] { obj };
            base.method_8("OnStopShaking", objArray1);
        }

        public void PreRender()
        {
            base.method_8("PreRender", Array.Empty<object>());
        }

        public void RefreshContent()
        {
            base.method_8("RefreshContent", Array.Empty<object>());
        }

        public void ResumePreviousMusicPlaylist()
        {
            base.method_8("ResumePreviousMusicPlaylist", Array.Empty<object>());
        }

        public void SetAccentTexture(Texture texture)
        {
            object[] objArray1 = new object[] { texture };
            base.method_8("SetAccentTexture", objArray1);
        }

        public void SetChooseDescription(string chooseText)
        {
            object[] objArray1 = new object[] { chooseText };
            base.method_8("SetChooseDescription", objArray1);
        }

        public void SetDescription(string title, string desc, string warning)
        {
            object[] objArray1 = new object[] { title, desc, warning };
            base.method_8("SetDescription", objArray1);
        }

        public void SetMode(GeneralStoreMode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("SetMode", objArray1);
        }

        public void ShakeStore(float xRotationAmount, float shakeTime, float delay)
        {
            object[] objArray1 = new object[] { xRotationAmount, shakeTime, delay };
            base.method_8("ShakeStore", objArray1);
        }

        public void ShowBuyPanel(BuyPanelState setPanelState)
        {
            object[] objArray1 = new object[] { setPanelState };
            base.method_8("ShowBuyPanel", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void SuccessfulPurchaseAckEvent(Network.Bundle bundle, PaymentMethod paymentMethod, object userData)
        {
            object[] objArray1 = new object[] { bundle, paymentMethod, userData };
            base.method_8("SuccessfulPurchaseAckEvent", objArray1);
        }

        public void SuccessfulPurchaseEvent(Network.Bundle bundle, PaymentMethod paymentMethod, object userData)
        {
            object[] objArray1 = new object[] { bundle, paymentMethod, userData };
            base.method_8("SuccessfulPurchaseEvent", objArray1);
        }

        public void UpdateCostAndButtonState(NoGTAPPTransactionData goldBundle, Network.Bundle moneyBundle)
        {
            object[] objArray1 = new object[] { goldBundle, moneyBundle };
            base.method_8("UpdateCostAndButtonState", objArray1);
        }

        public void UpdateCostDisplay(Network.Bundle moneyBundle)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { moneyBundle };
            base.method_9("UpdateCostDisplay", enumArray1, objArray1);
        }

        public void UpdateCostDisplay(NoGTAPPTransactionData goldBundle)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { goldBundle };
            base.method_9("UpdateCostDisplay", enumArray1, objArray1);
        }

        public void UpdateCostDisplay(BuyPanelState newPanelState, string costText)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.String };
            object[] objArray1 = new object[] { newPanelState, costText };
            base.method_9("UpdateCostDisplay", enumArray1, objArray1);
        }

        public void UpdateGoldButtonState()
        {
            base.method_9("UpdateGoldButtonState", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void UpdateGoldButtonState(NetCache.NetCacheGoldBalance balance)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { balance };
            base.method_9("UpdateGoldButtonState", enumArray1, objArray1);
        }

        public void UpdateModeButtons(GeneralStoreMode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("UpdateModeButtons", objArray1);
        }

        public void UpdateMoneyButtonState()
        {
            base.method_8("UpdateMoneyButtonState", Array.Empty<object>());
        }

        public static float FLIP_BUY_PANEL_ANIM_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GeneralStore", "FLIP_BUY_PANEL_ANIM_TIME");
            }
        }

        public MeshRenderer m_accentIcon
        {
            get
            {
                return base.method_3<MeshRenderer>("m_accentIcon");
            }
        }

        public GameObject m_buyEmptyPanel
        {
            get
            {
                return base.method_3<GameObject>("m_buyEmptyPanel");
            }
        }

        public GameObject m_buyGoldPanel
        {
            get
            {
                return base.method_3<GameObject>("m_buyGoldPanel");
            }
        }

        public GameObject m_buyMoneyPanel
        {
            get
            {
                return base.method_3<GameObject>("m_buyMoneyPanel");
            }
        }

        public BuyPanelState m_buyPanelState
        {
            get
            {
                return base.method_2<BuyPanelState>("m_buyPanelState");
            }
        }

        public GameObject m_chooseArrowContainer
        {
            get
            {
                return base.method_3<GameObject>("m_chooseArrowContainer");
            }
        }

        public UberText m_chooseArrowText
        {
            get
            {
                return base.method_3<UberText>("m_chooseArrowText");
            }
        }

        public float m_contentFlipAnimationTime
        {
            get
            {
                return base.method_2<float>("m_contentFlipAnimationTime");
            }
        }

        public iTween.EaseType m_contentFlipEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_contentFlipEaseType");
            }
        }

        public string m_contentFlipSound
        {
            get
            {
                return base.method_4("m_contentFlipSound");
            }
        }

        public int m_currentContentPositionIdx
        {
            get
            {
                return base.method_2<int>("m_currentContentPositionIdx");
            }
        }

        public GeneralStoreMode m_currentMode
        {
            get
            {
                return base.method_2<GeneralStoreMode>("m_currentMode");
            }
        }

        public GeneralStorePane m_defaultPane
        {
            get
            {
                return base.method_3<GeneralStorePane>("m_defaultPane");
            }
        }

        public UberText m_goldCostText
        {
            get
            {
                return base.method_3<UberText>("m_goldCostText");
            }
        }

        public float m_koreanProductDetailsExtendedHeight
        {
            get
            {
                return base.method_2<float>("m_koreanProductDetailsExtendedHeight");
            }
        }

        public float m_koreanProductDetailsRegularHeight
        {
            get
            {
                return base.method_2<float>("m_koreanProductDetailsRegularHeight");
            }
        }

        public UberText m_koreanProductDetailsText
        {
            get
            {
                return base.method_3<UberText>("m_koreanProductDetailsText");
            }
        }

        public UberText m_koreanWarningText
        {
            get
            {
                return base.method_3<UberText>("m_koreanWarningText");
            }
        }

        public float m_lastShakeyAmount
        {
            get
            {
                return base.method_2<float>("m_lastShakeyAmount");
            }
        }

        public GameObject m_mainPanel
        {
            get
            {
                return base.method_3<GameObject>("m_mainPanel");
            }
        }

        public GameObject m_modeButtonBlocker
        {
            get
            {
                return base.method_3<GameObject>("m_modeButtonBlocker");
            }
        }

        public List<ModeObjects> m_modeObjects
        {
            get
            {
                Class267<ModeObjects> class2 = base.method_3<Class267<ModeObjects>>("m_modeObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_moneyCostText
        {
            get
            {
                return base.method_3<UberText>("m_moneyCostText");
            }
        }

        public float m_multipleShakeTolerance
        {
            get
            {
                return base.method_2<float>("m_multipleShakeTolerance");
            }
        }

        public UIBScrollable m_paneScrollbar
        {
            get
            {
                return base.method_3<UIBScrollable>("m_paneScrollbar");
            }
        }

        public float m_paneSwapAnimationTime
        {
            get
            {
                return base.method_2<float>("m_paneSwapAnimationTime");
            }
        }

        public Vector3 m_paneSwapInOffset
        {
            get
            {
                return base.method_2<Vector3>("m_paneSwapInOffset");
            }
        }

        public Vector3 m_paneSwapOutOffset
        {
            get
            {
                return base.method_2<Vector3>("m_paneSwapOutOffset");
            }
        }

        public MusicPlaylistType m_prevPlaylist
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_prevPlaylist");
            }
        }

        public MultiSliceElement m_productDetailsContainer
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_productDetailsContainer");
            }
        }

        public float m_productDetailsExtendedHeight
        {
            get
            {
                return base.method_2<float>("m_productDetailsExtendedHeight");
            }
        }

        public UberText m_productDetailsHeadlineText
        {
            get
            {
                return base.method_3<UberText>("m_productDetailsHeadlineText");
            }
        }

        public float m_productDetailsRegularHeight
        {
            get
            {
                return base.method_2<float>("m_productDetailsRegularHeight");
            }
        }

        public UberText m_productDetailsText
        {
            get
            {
                return base.method_3<UberText>("m_productDetailsText");
            }
        }

        public int m_settingNewModeCount
        {
            get
            {
                return base.method_2<int>("m_settingNewModeCount");
            }
        }

        public GameObject m_shakeyObject
        {
            get
            {
                return base.method_3<GameObject>("m_shakeyObject");
            }
        }

        public Vector3 m_shakeyObjectOriginalLocalRotation
        {
            get
            {
                return base.method_2<Vector3>("m_shakeyObjectOriginalLocalRotation");
            }
        }

        public bool m_staticTextResized
        {
            get
            {
                return base.method_2<bool>("m_staticTextResized");
            }
        }

        public bool m_stillShaking
        {
            get
            {
                return base.method_2<bool>("m_stillShaking");
            }
        }

        public static Vector3 MAIN_PANEL_ANGLE_TO_ROTATE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "GeneralStore", "MAIN_PANEL_ANGLE_TO_ROTATE");
            }
        }

        public static int MIN_GOLD_FOR_CHANGE_QTY_TOOLTIP
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "GeneralStore", "MIN_GOLD_FOR_CHANGE_QTY_TOOLTIP");
            }
        }

        public static List<GeneralStoreMode> s_ContentOrdering
        {
            get
            {
                Class246<GeneralStoreMode> class2 = MonoClass.smethod_7<Class246<GeneralStoreMode>>(TritonHs.MainAssemblyPath, "", "GeneralStore", "s_ContentOrdering");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static List<Vector3> s_ContentTriangularPositions
        {
            get
            {
                Class246<Vector3> class2 = MonoClass.smethod_7<Class246<Vector3>>(TritonHs.MainAssemblyPath, "", "GeneralStore", "s_ContentTriangularPositions");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static List<Vector3> s_ContentTriangularRotations
        {
            get
            {
                Class246<Vector3> class2 = MonoClass.smethod_7<Class246<Vector3>>(TritonHs.MainAssemblyPath, "", "GeneralStore", "s_ContentTriangularRotations");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static List<Vector3> s_MainPanelTriangularRotations
        {
            get
            {
                Class246<Vector3> class2 = MonoClass.smethod_7<Class246<Vector3>>(TritonHs.MainAssemblyPath, "", "GeneralStore", "s_MainPanelTriangularRotations");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public enum BuyPanelState
        {
            DISABLED,
            BUY_GOLD,
            BUY_MONEY
        }

        [Attribute38("GeneralStore.ModeObjects")]
        public class ModeObjects : MonoClass
        {
            public ModeObjects(IntPtr address) : this(address, "ModeObjects")
            {
            }

            public ModeObjects(IntPtr address, string className) : base(address, className)
            {
            }

            public UIBButton m_button
            {
                get
                {
                    return base.method_3<UIBButton>("m_button");
                }
            }

            public GeneralStoreContent m_content
            {
                get
                {
                    return base.method_3<GeneralStoreContent>("m_content");
                }
            }

            public GeneralStoreMode m_mode
            {
                get
                {
                    return base.method_2<GeneralStoreMode>("m_mode");
                }
            }

            public GeneralStorePane m_pane
            {
                get
                {
                    return base.method_3<GeneralStorePane>("m_pane");
                }
            }
        }
    }
}

