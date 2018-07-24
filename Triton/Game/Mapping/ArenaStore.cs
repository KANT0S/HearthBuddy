namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ArenaStore")]
    public class ArenaStore : Store
    {
        public ArenaStore(IntPtr address) : this(address, "ArenaStore")
        {
        }

        public ArenaStore(IntPtr address, string className) : base(address, className)
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

        public void ExitForgeStore(bool authorizationBackButtonPressed)
        {
            object[] objArray1 = new object[] { authorizationBackButtonPressed };
            base.method_8("ExitForgeStore", objArray1);
        }

        public static ArenaStore Get()
        {
            return MonoClass.smethod_15<ArenaStore>(TritonHs.MainAssemblyPath, "", "ArenaStore", "Get", Array.Empty<object>());
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

        public void OnBackPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBackPressed", objArray1);
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

        public UIBButton m_backButton
        {
            get
            {
                return base.method_3<UIBButton>("m_backButton");
            }
        }

        public Network.Bundle m_bundle
        {
            get
            {
                return base.method_3<Network.Bundle>("m_bundle");
            }
        }

        public NoGTAPPTransactionData m_goldTransactionData
        {
            get
            {
                return base.method_3<NoGTAPPTransactionData>("m_goldTransactionData");
            }
        }

        public GameObject m_storeClosed
        {
            get
            {
                return base.method_3<GameObject>("m_storeClosed");
            }
        }

        public static int NUM_BUNDLE_ITEMS_REQUIRED
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ArenaStore", "NUM_BUNDLE_ITEMS_REQUIRED");
            }
        }
    }
}

