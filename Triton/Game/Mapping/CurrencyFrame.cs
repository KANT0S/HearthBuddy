namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CurrencyFrame")]
    public class CurrencyFrame : MonoBehaviour
    {
        public CurrencyFrame(IntPtr address) : this(address, "CurrencyFrame")
        {
        }

        public CurrencyFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateCurrencyFrame()
        {
            base.method_8("ActivateCurrencyFrame", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DeactivateCurrencyFrame()
        {
            base.method_8("DeactivateCurrencyFrame", Array.Empty<object>());
        }

        public void FadeBackground(bool isFaded)
        {
            object[] objArray1 = new object[] { isFaded };
            base.method_8("FadeBackground", objArray1);
        }

        public CurrencyType GetCurrencyToShow()
        {
            return base.method_11<CurrencyType>("GetCurrencyToShow", Array.Empty<object>());
        }

        public GameObject GetTooltipObject()
        {
            return base.method_14<GameObject>("GetTooltipObject", Array.Empty<object>());
        }

        public void HideTemporarily()
        {
            base.method_8("HideTemporarily", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFrameMouseOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnFrameMouseOut", objArray1);
        }

        public void OnFrameMouseOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnFrameMouseOver", objArray1);
        }

        public void OnGoldBalanceChanged(NetCache.NetCacheGoldBalance balance)
        {
            object[] objArray1 = new object[] { balance };
            base.method_8("OnGoldBalanceChanged", objArray1);
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void RefreshContents()
        {
            base.method_8("RefreshContents", Array.Empty<object>());
        }

        public void SetAmount(long amount)
        {
            object[] objArray1 = new object[] { amount };
            base.method_8("SetAmount", objArray1);
        }

        public void Show(CurrencyType currencyType)
        {
            object[] objArray1 = new object[] { currencyType };
            base.method_8("Show", objArray1);
        }

        public void ShowCurrencyType(CurrencyType currencyType)
        {
            object[] objArray1 = new object[] { currencyType };
            base.method_8("ShowCurrencyType", objArray1);
        }

        public void ShowImmediate(CurrencyType currencyType)
        {
            object[] objArray1 = new object[] { currencyType };
            base.method_8("ShowImmediate", objArray1);
        }

        public void UpdateAmount(CurrencyType currencyType)
        {
            object[] objArray1 = new object[] { currencyType };
            base.method_8("UpdateAmount", objArray1);
        }

        public UberText m_amount
        {
            get
            {
                return base.method_3<UberText>("m_amount");
            }
        }

        public GameObject m_background
        {
            get
            {
                return base.method_3<GameObject>("m_background");
            }
        }

        public bool m_backgroundFaded
        {
            get
            {
                return base.method_2<bool>("m_backgroundFaded");
            }
        }

        public GameObject m_dustFX
        {
            get
            {
                return base.method_3<GameObject>("m_dustFX");
            }
        }

        public GameObject m_dustJar
        {
            get
            {
                return base.method_3<GameObject>("m_dustJar");
            }
        }

        public GameObject m_explodeFX_Common
        {
            get
            {
                return base.method_3<GameObject>("m_explodeFX_Common");
            }
        }

        public GameObject m_explodeFX_Epic
        {
            get
            {
                return base.method_3<GameObject>("m_explodeFX_Epic");
            }
        }

        public GameObject m_explodeFX_Legendary
        {
            get
            {
                return base.method_3<GameObject>("m_explodeFX_Legendary");
            }
        }

        public GameObject m_explodeFX_Rare
        {
            get
            {
                return base.method_3<GameObject>("m_explodeFX_Rare");
            }
        }

        public GameObject m_goldCoin
        {
            get
            {
                return base.method_3<GameObject>("m_goldCoin");
            }
        }

        public PegUIElement m_mouseOverZone
        {
            get
            {
                return base.method_3<PegUIElement>("m_mouseOverZone");
            }
        }

        public CurrencyType m_showingCurrency
        {
            get
            {
                return base.method_2<CurrencyType>("m_showingCurrency");
            }
        }

        public State m_state
        {
            get
            {
                return base.method_2<State>("m_state");
            }
        }

        public enum CurrencyType
        {
            NONE,
            GOLD,
            ARCANE_DUST
        }

        public enum State
        {
            ANIMATE_IN,
            ANIMATE_OUT,
            HIDDEN,
            SHOWN
        }
    }
}

