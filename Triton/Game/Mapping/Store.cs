namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Store")]
    public class Store : UIBPopup
    {
        public Store(IntPtr address) : this(address, "Store")
        {
        }

        public Store(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateCover(bool coverActive)
        {
            object[] objArray1 = new object[] { coverActive };
            base.method_8("ActivateCover", objArray1);
        }

        public bool AllowBuyingWithGold()
        {
            return base.method_11<bool>("AllowBuyingWithGold", Array.Empty<object>());
        }

        public bool AllowBuyingWithMoney()
        {
            return base.method_11<bool>("AllowBuyingWithMoney", Array.Empty<object>());
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
            base.method_8("Close", Array.Empty<object>());
        }

        public void EnableBuyButtons(bool buyButtonsEnabled)
        {
            object[] objArray1 = new object[] { buyButtonsEnabled };
            base.method_8("EnableBuyButtons", objArray1);
        }

        public void EnableClickCatcher(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("EnableClickCatcher", objArray1);
        }

        public void EnableFullScreenEffects(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableFullScreenEffects", objArray1);
        }

        public void FireBuyWithGoldEventGTAPP(string productID, int quantity)
        {
            object[] objArray1 = new object[] { productID, quantity };
            base.method_8("FireBuyWithGoldEventGTAPP", objArray1);
        }

        public void FireBuyWithGoldEventNoGTAPP(NoGTAPPTransactionData noGTAPPTransactionData)
        {
            object[] objArray1 = new object[] { noGTAPPTransactionData };
            base.method_8("FireBuyWithGoldEventNoGTAPP", objArray1);
        }

        public void FireBuyWithMoneyEvent(string productID, int quantity)
        {
            object[] objArray1 = new object[] { productID, quantity };
            base.method_8("FireBuyWithMoneyEvent", objArray1);
        }

        public void FireExitEvent(bool authorizationBackButtonPressed)
        {
            object[] objArray1 = new object[] { authorizationBackButtonPressed };
            base.method_8("FireExitEvent", objArray1);
        }

        public string GetBuyButtonTooltipMessage(BuyButtonState state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_13("GetBuyButtonTooltipMessage", objArray1);
        }

        public string GetOwnedTooltipString()
        {
            return base.method_13("GetOwnedTooltipString", Array.Empty<object>());
        }

        public StoreType GetStoreType()
        {
            return base.method_11<StoreType>("GetStoreType", Array.Empty<object>());
        }

        public bool IsCovered()
        {
            return base.method_11<bool>("IsCovered", Array.Empty<object>());
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public void OnBuyWithGoldPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBuyWithGoldPressed", objArray1);
        }

        public void OnBuyWithMoneyPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBuyWithMoneyPressed", objArray1);
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

        public void OnHideBuyWithGoldTooltip(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnHideBuyWithGoldTooltip", objArray1);
        }

        public void OnHideBuyWithMoneyTooltip(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnHideBuyWithMoneyTooltip", objArray1);
        }

        public void OnInfoPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnInfoPressed", objArray1);
        }

        public void OnMoneySpent()
        {
            base.method_8("OnMoneySpent", Array.Empty<object>());
        }

        public void OnShowBuyWithGoldTooltip(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnShowBuyWithGoldTooltip", objArray1);
        }

        public void OnShowBuyWithMoneyTooltip(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnShowBuyWithMoneyTooltip", objArray1);
        }

        public void SetGoldButtonState(BuyButtonState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("SetGoldButtonState", objArray1);
        }

        public void SetMoneyButtonState(BuyButtonState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("SetMoneyButtonState", objArray1);
        }

        public void SetStoreType(StoreType storeType)
        {
            object[] objArray1 = new object[] { storeType };
            base.method_8("SetStoreType", objArray1);
        }

        public void ShowBuyTooltip(TooltipZone tooltipZone, string tooltipText, BuyButtonState buttonState)
        {
            object[] objArray1 = new object[] { tooltipZone, tooltipText, buttonState };
            base.method_8("ShowBuyTooltip", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateBuyButtonsState()
        {
            base.method_8("UpdateBuyButtonsState", Array.Empty<object>());
        }

        public bool m_buyButtonsEnabled
        {
            get
            {
                return base.method_2<bool>("m_buyButtonsEnabled");
            }
        }

        public UIBButton m_buyWithGoldButton
        {
            get
            {
                return base.method_3<UIBButton>("m_buyWithGoldButton");
            }
        }

        public TooltipZone m_buyWithGoldTooltip
        {
            get
            {
                return base.method_3<TooltipZone>("m_buyWithGoldTooltip");
            }
        }

        public PegUIElement m_buyWithGoldTooltipTrigger
        {
            get
            {
                return base.method_3<PegUIElement>("m_buyWithGoldTooltipTrigger");
            }
        }

        public UIBButton m_buyWithMoneyButton
        {
            get
            {
                return base.method_3<UIBButton>("m_buyWithMoneyButton");
            }
        }

        public TooltipZone m_buyWithMoneyTooltip
        {
            get
            {
                return base.method_3<TooltipZone>("m_buyWithMoneyTooltip");
            }
        }

        public PegUIElement m_buyWithMoneyTooltipTrigger
        {
            get
            {
                return base.method_3<PegUIElement>("m_buyWithMoneyTooltipTrigger");
            }
        }

        public GameObject m_cover
        {
            get
            {
                return base.method_3<GameObject>("m_cover");
            }
        }

        public Material m_disabledGoldButtonMaterial
        {
            get
            {
                return base.method_3<Material>("m_disabledGoldButtonMaterial");
            }
        }

        public Material m_disabledMoneyButtonMaterial
        {
            get
            {
                return base.method_3<Material>("m_disabledMoneyButtonMaterial");
            }
        }

        public Material m_enabledGoldButtonMaterial
        {
            get
            {
                return base.method_3<Material>("m_enabledGoldButtonMaterial");
            }
        }

        public Material m_enabledMoneyButtonMaterial
        {
            get
            {
                return base.method_3<Material>("m_enabledMoneyButtonMaterial");
            }
        }

        public List<MeshRenderer> m_goldButtonMeshes
        {
            get
            {
                Class267<MeshRenderer> class2 = base.method_3<Class267<MeshRenderer>>("m_goldButtonMeshes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public BuyButtonState m_goldButtonState
        {
            get
            {
                return base.method_2<BuyButtonState>("m_goldButtonState");
            }
        }

        public UIBButton m_infoButton
        {
            get
            {
                return base.method_3<UIBButton>("m_infoButton");
            }
        }

        public List<MeshRenderer> m_moneyButtonMeshes
        {
            get
            {
                Class267<MeshRenderer> class2 = base.method_3<Class267<MeshRenderer>>("m_moneyButtonMeshes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public BuyButtonState m_moneyButtonState
        {
            get
            {
                return base.method_2<BuyButtonState>("m_moneyButtonState");
            }
        }

        public PegUIElement m_offClicker
        {
            get
            {
                return base.method_3<PegUIElement>("m_offClicker");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public StoreType m_storeType
        {
            get
            {
                return base.method_2<StoreType>("m_storeType");
            }
        }

        public enum BuyButtonState
        {
            ENABLED,
            DISABLED_NOT_ENOUGH_GOLD,
            DISABLED_FEATURE,
            DISABLED,
            DISABLED_OWNED
        }
    }
}

