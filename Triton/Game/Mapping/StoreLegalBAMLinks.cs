namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StoreLegalBAMLinks")]
    public class StoreLegalBAMLinks : UIBPopup
    {
        public StoreLegalBAMLinks(IntPtr address) : this(address, "StoreLegalBAMLinks")
        {
        }

        public StoreLegalBAMLinks(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void EnableButtons(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("EnableButtons", objArray1);
        }

        public void OnClickCatcherPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnClickCatcherPressed", objArray1);
        }

        public void OnPaymentMethodPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnPaymentMethodPressed", objArray1);
        }

        public void OnTermsOfSalePressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTermsOfSalePressed", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public static StoreURL CHANGE_PAYMENT_URL
        {
            get
            {
                return MonoClass.smethod_7<StoreURL>(TritonHs.MainAssemblyPath, "", "StoreLegalBAMLinks", "CHANGE_PAYMENT_URL");
            }
        }

        public static string FMT_URL_CHANGE_PAYMENT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreLegalBAMLinks", "FMT_URL_CHANGE_PAYMENT");
            }
        }

        public static string FMT_URL_TERMS_OF_SALE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreLegalBAMLinks", "FMT_URL_TERMS_OF_SALE");
            }
        }

        public PegUIElement m_offClickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_offClickCatcher");
            }
        }

        public UIBButton m_paymentMethodButton
        {
            get
            {
                return base.method_3<UIBButton>("m_paymentMethodButton");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public UIBButton m_termsOfSaleButton
        {
            get
            {
                return base.method_3<UIBButton>("m_termsOfSaleButton");
            }
        }

        public static string SEND_TO_BAM_THEN_HIDE_COROUTINE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreLegalBAMLinks", "SEND_TO_BAM_THEN_HIDE_COROUTINE");
            }
        }

        public static StoreURL TERMS_OF_SALE_URL
        {
            get
            {
                return MonoClass.smethod_7<StoreURL>(TritonHs.MainAssemblyPath, "", "StoreLegalBAMLinks", "TERMS_OF_SALE_URL");
            }
        }

        public enum BAMReason
        {
            CHANGE_PAYMENT_METHOD,
            READ_TERMS_OF_SALE
        }
    }
}

