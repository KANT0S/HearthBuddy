namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureStore")]
    public class AdventureStore : Store
    {
        public AdventureStore(IntPtr address) : this(address, "AdventureStore")
        {
        }

        public AdventureStore(IntPtr address, string className) : base(address, className)
        {
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

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void OnAuthExit(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnAuthExit", objArray1);
        }

        public void OnBuyDungeonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBuyDungeonPressed", objArray1);
        }

        public void OnGoldBalanceChanged(NetCache.NetCacheGoldBalance balance)
        {
            object[] objArray1 = new object[] { balance };
            base.method_8("OnGoldBalanceChanged", objArray1);
        }

        public void OnMoneySpent()
        {
            base.method_8("OnMoneySpent", Array.Empty<object>());
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void SetUpBuyButtons()
        {
            base.method_8("SetUpBuyButtons", Array.Empty<object>());
        }

        public void SetUpBuyDungeonButton()
        {
            base.method_8("SetUpBuyDungeonButton", Array.Empty<object>());
        }

        public void SetUpBuyWithGoldButton()
        {
            base.method_8("SetUpBuyWithGoldButton", Array.Empty<object>());
        }

        public void SetUpBuyWithMoneyButton()
        {
            base.method_8("SetUpBuyWithMoneyButton", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateGoldButtonState(NetCache.NetCacheGoldBalance balance)
        {
            object[] objArray1 = new object[] { balance };
            base.method_8("UpdateGoldButtonState", objArray1);
        }

        public void UpdateMoneyButtonState()
        {
            base.method_8("UpdateMoneyButtonState", Array.Empty<object>());
        }

        public bool m_animating
        {
            get
            {
                return base.method_2<bool>("m_animating");
            }
        }

        public Network.Bundle m_bundle
        {
            get
            {
                return base.method_3<Network.Bundle>("m_bundle");
            }
        }

        public UIBButton m_BuyDungeonButton
        {
            get
            {
                return base.method_3<UIBButton>("m_BuyDungeonButton");
            }
        }

        public UberText m_DetailsText1
        {
            get
            {
                return base.method_3<UberText>("m_DetailsText1");
            }
        }

        public UberText m_DetailsText2
        {
            get
            {
                return base.method_3<UberText>("m_DetailsText2");
            }
        }

        public Network.Bundle m_fullDungeonBundle
        {
            get
            {
                return base.method_3<Network.Bundle>("m_fullDungeonBundle");
            }
        }

        public UberText m_Headline
        {
            get
            {
                return base.method_3<UberText>("m_Headline");
            }
        }

        public static int NUM_BUNDLE_ITEMS_REQUIRED
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AdventureStore", "NUM_BUNDLE_ITEMS_REQUIRED");
            }
        }
    }
}

