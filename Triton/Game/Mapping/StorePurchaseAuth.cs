namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StorePurchaseAuth")]
    public class StorePurchaseAuth : UIBPopup
    {
        public StorePurchaseAuth(IntPtr address) : this(address, "StorePurchaseAuth")
        {
        }

        public StorePurchaseAuth(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CompletePurchaseFailure(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction, string failDetails)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction, failDetails };
            return base.method_11<bool>("CompletePurchaseFailure", objArray1);
        }

        public bool CompletePurchaseSuccess(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction };
            return base.method_11<bool>("CompletePurchaseSuccess", objArray1);
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void OnOkayButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnOkayButtonPressed", objArray1);
        }

        public void Show(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction, bool enableBackButton, bool isZeroCostLicense)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction, enableBackButton, isZeroCostLicense };
            base.method_8("Show", objArray1);
        }

        public void ShowMiniSummary()
        {
            base.method_8("ShowMiniSummary", Array.Empty<object>());
        }

        public void ShowPreviousPurchaseFailure(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction, string failDetails, bool enableBackButton)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction, failDetails, enableBackButton };
            base.method_8("ShowPreviousPurchaseFailure", objArray1);
        }

        public void ShowPreviousPurchaseSuccess(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction, bool enableBackButton)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction, enableBackButton };
            base.method_8("ShowPreviousPurchaseSuccess", objArray1);
        }

        public void ShowPurchaseFailure(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction, string failDetails, bool showMiniSummary)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction, failDetails, showMiniSummary };
            base.method_8("ShowPurchaseFailure", objArray1);
        }

        public void ShowPurchaseMethodFailure(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction, string failDetails, bool enableBackButton)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction, failDetails, enableBackButton };
            base.method_8("ShowPurchaseMethodFailure", objArray1);
        }

        public void ShowPurchaseSuccess(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction, bool showMiniSummary)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction, showMiniSummary };
            base.method_8("ShowPurchaseSuccess", objArray1);
        }

        public UberText m_failDetailsText
        {
            get
            {
                return base.method_3<UberText>("m_failDetailsText");
            }
        }

        public UberText m_failHeadlineText
        {
            get
            {
                return base.method_3<UberText>("m_failHeadlineText");
            }
        }

        public bool m_isBackButton
        {
            get
            {
                return base.method_2<bool>("m_isBackButton");
            }
        }

        public StoreMiniSummary m_miniSummary
        {
            get
            {
                return base.method_3<StoreMiniSummary>("m_miniSummary");
            }
        }

        public MoneyOrGTAPPTransaction m_moneyOrGTAPPTransaction
        {
            get
            {
                return base.method_3<MoneyOrGTAPPTransaction>("m_moneyOrGTAPPTransaction");
            }
        }

        public UIBButton m_okButton
        {
            get
            {
                return base.method_3<UIBButton>("m_okButton");
            }
        }

        public MultiSliceElement m_root
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_root");
            }
        }

        public bool m_showingSuccess
        {
            get
            {
                return base.method_2<bool>("m_showingSuccess");
            }
        }

        public Spell m_spell
        {
            get
            {
                return base.method_3<Spell>("m_spell");
            }
        }

        public UberText m_successHeadlineText
        {
            get
            {
                return base.method_3<UberText>("m_successHeadlineText");
            }
        }

        public UberText m_waitingForAuthText
        {
            get
            {
                return base.method_3<UberText>("m_waitingForAuthText");
            }
        }

        public static string s_BackButtonText
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StorePurchaseAuth", "s_BackButtonText");
            }
        }

        public static string s_OkButtonText
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StorePurchaseAuth", "s_OkButtonText");
            }
        }
    }
}

