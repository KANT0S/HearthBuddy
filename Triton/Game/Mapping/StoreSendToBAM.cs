namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StoreSendToBAM")]
    public class StoreSendToBAM : UIBPopup
    {
        public StoreSendToBAM(IntPtr address) : this(address, "StoreSendToBAM")
        {
        }

        public StoreSendToBAM(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void LayoutMessageText()
        {
            base.method_8("LayoutMessageText", Array.Empty<object>());
        }

        public bool OnCancel()
        {
            return base.method_11<bool>("OnCancel", Array.Empty<object>());
        }

        public void OnCancelPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelPressed", objArray1);
        }

        public void OnHidden()
        {
            base.method_8("OnHidden", Array.Empty<object>());
        }

        public void OnOkayPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnOkayPressed", objArray1);
        }

        public void Show(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction, BAMReason reason, string errorCode, bool fromPreviousPurchase)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction, reason, errorCode, fromPreviousPurchase };
            base.method_8("Show", objArray1);
        }

        public void UpdateText()
        {
            base.method_8("UpdateText", Array.Empty<object>());
        }

        public static string FMT_URL_EULA_AND_TOS
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreSendToBAM", "FMT_URL_EULA_AND_TOS");
            }
        }

        public static string FMT_URL_GENERIC_PAYMENT_FAIL
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreSendToBAM", "FMT_URL_GENERIC_PAYMENT_FAIL");
            }
        }

        public static string FMT_URL_NO_PAYMENT_METHOD
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreSendToBAM", "FMT_URL_NO_PAYMENT_METHOD");
            }
        }

        public static string FMT_URL_PAYMENT_EXPIRED
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreSendToBAM", "FMT_URL_PAYMENT_EXPIRED");
            }
        }

        public static string FMT_URL_PURCHASE_UNIQUENESS_VIOLATED
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreSendToBAM", "FMT_URL_PURCHASE_UNIQUENESS_VIOLATED");
            }
        }

        public static string FMT_URL_RESET_PASSWORD
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreSendToBAM", "FMT_URL_RESET_PASSWORD");
            }
        }

        public MultiSliceElement m_allSections
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_allSections");
            }
        }

        public UIBButton m_cancelButton
        {
            get
            {
                return base.method_3<UIBButton>("m_cancelButton");
            }
        }

        public string m_errorCode
        {
            get
            {
                return base.method_4("m_errorCode");
            }
        }

        public UberText m_headlineText
        {
            get
            {
                return base.method_3<UberText>("m_headlineText");
            }
        }

        public UberText m_messageText
        {
            get
            {
                return base.method_3<UberText>("m_messageText");
            }
        }

        public GameObject m_midSection
        {
            get
            {
                return base.method_3<GameObject>("m_midSection");
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

        public UIBButton m_okayButton
        {
            get
            {
                return base.method_3<UIBButton>("m_okayButton");
            }
        }

        public Vector3 m_originalShowScale
        {
            get
            {
                return base.method_2<Vector3>("m_originalShowScale");
            }
        }

        public BAMReason m_sendToBAMReason
        {
            get
            {
                return base.method_2<BAMReason>("m_sendToBAMReason");
            }
        }

        public GameObject m_sendToBAMRoot
        {
            get
            {
                return base.method_3<GameObject>("m_sendToBAMRoot");
            }
        }

        public Transform m_sendToBAMRootWithSummaryBone
        {
            get
            {
                return base.method_3<Transform>("m_sendToBAMRootWithSummaryBone");
            }
        }

        public static string SEND_TO_BAM_THEN_HIDE_COROUTINE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreSendToBAM", "SEND_TO_BAM_THEN_HIDE_COROUTINE");
            }
        }

        public static Vector3 SHOW_MINI_SUMMARY_SCALE_PHONE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "StoreSendToBAM", "SHOW_MINI_SUMMARY_SCALE_PHONE");
            }
        }

        public enum BAMReason
        {
            PAYMENT_INFO,
            NEED_PASSWORD_RESET,
            NO_VALID_PAYMENT_METHOD,
            CREDIT_CARD_EXPIRED,
            GENERIC_PAYMENT_FAIL,
            EULA_AND_TOS,
            PRODUCT_UNIQUENESS_VIOLATED,
            GENERIC_PURCHASE_FAIL_RETRY_CONTACT_CS_IF_PERSISTS
        }

        [Attribute38("StoreSendToBAM.SendToBAMText")]
        public class SendToBAMText : MonoClass
        {
            public SendToBAMText(IntPtr address) : this(address, "SendToBAMText")
            {
            }

            public SendToBAMText(IntPtr address, string className) : base(address, className)
            {
            }

            public string GetDetails()
            {
                return base.method_13("GetDetails", Array.Empty<object>());
            }

            public string GetGoToURLDetails(string buttonName)
            {
                object[] objArray1 = new object[] { buttonName };
                return base.method_13("GetGoToURLDetails", objArray1);
            }

            public string GetHeadline()
            {
                return base.method_13("GetHeadline", Array.Empty<object>());
            }

            public string GetURL()
            {
                return base.method_13("GetURL", Array.Empty<object>());
            }

            public string m_detailsKey
            {
                get
                {
                    return base.method_4("m_detailsKey");
                }
            }

            public string m_goToURLKey
            {
                get
                {
                    return base.method_4("m_goToURLKey");
                }
            }

            public string m_headlineKey
            {
                get
                {
                    return base.method_4("m_headlineKey");
                }
            }

            public StoreURL m_url
            {
                get
                {
                    return base.method_3<StoreURL>("m_url");
                }
            }
        }
    }
}

