namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StoreSummary")]
    public class StoreSummary : UIBPopup
    {
        public StoreSummary(IntPtr address) : this(address, "StoreSummary")
        {
        }

        public StoreSummary(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void EnableConfirmButton(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("EnableConfirmButton", objArray1);
        }

        public string GetItemsText()
        {
            return base.method_13("GetItemsText", Array.Empty<object>());
        }

        public string GetPriceText()
        {
            return base.method_13("GetPriceText", Array.Empty<object>());
        }

        public void Hide(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            base.method_8("Hide", objArray1);
        }

        public void OnCancelPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelPressed", objArray1);
        }

        public void OnConfirmPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnConfirmPressed", objArray1);
        }

        public void OnInfoPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnInfoPressed", objArray1);
        }

        public void OnTermsOfSalePressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTermsOfSalePressed", objArray1);
        }

        public void PreRender()
        {
            base.method_8("PreRender", Array.Empty<object>());
        }

        public void SetDetails(string productID, int quantity, string paymentMethodName)
        {
            object[] objArray1 = new object[] { productID, quantity, paymentMethodName };
            base.method_8("SetDetails", objArray1);
        }

        public void Show()
        {
            base.method_9("Show", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Show(string productID, int quantity, string paymentMethodName)
        {
            object[] objArray1 = new object[] { productID, quantity, paymentMethodName };
            base.method_9("Show", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void ToggleKoreanAgreement(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ToggleKoreanAgreement", objArray1);
        }

        public static Color DISABLED_CONFIRM_BUTTON_TEXT_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "StoreSummary", "DISABLED_CONFIRM_BUTTON_TEXT_COLOR");
            }
        }

        public static Color ENABLED_CONFIRM_BUTTON_TEXT_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "StoreSummary", "ENABLED_CONFIRM_BUTTON_TEXT_COLOR");
            }
        }

        public GameObject m_bottomSectionRoot
        {
            get
            {
                return base.method_3<GameObject>("m_bottomSectionRoot");
            }
        }

        public Network.Bundle m_bundle
        {
            get
            {
                return base.method_3<Network.Bundle>("m_bundle");
            }
        }

        public UIBButton m_cancelButton
        {
            get
            {
                return base.method_3<UIBButton>("m_cancelButton");
            }
        }

        public UberText m_chargeDetailsText
        {
            get
            {
                return base.method_3<UberText>("m_chargeDetailsText");
            }
        }

        public UIBButton m_confirmButton
        {
            get
            {
                return base.method_3<UIBButton>("m_confirmButton");
            }
        }

        public GameObject m_confirmButtonCheckMark
        {
            get
            {
                return base.method_3<GameObject>("m_confirmButtonCheckMark");
            }
        }

        public bool m_confirmButtonEnabled
        {
            get
            {
                return base.method_2<bool>("m_confirmButtonEnabled");
            }
        }

        public Material m_disabledConfirmButtonMaterial
        {
            get
            {
                return base.method_3<Material>("m_disabledConfirmButtonMaterial");
            }
        }

        public Material m_disabledConfirmCheckMarkMaterial
        {
            get
            {
                return base.method_3<Material>("m_disabledConfirmCheckMarkMaterial");
            }
        }

        public Material m_enabledConfirmButtonMaterial
        {
            get
            {
                return base.method_3<Material>("m_enabledConfirmButtonMaterial");
            }
        }

        public Material m_enabledConfirmCheckMarkMaterial
        {
            get
            {
                return base.method_3<Material>("m_enabledConfirmCheckMarkMaterial");
            }
        }

        public UberText m_headlineText
        {
            get
            {
                return base.method_3<UberText>("m_headlineText");
            }
        }

        public UIBButton m_infoButton
        {
            get
            {
                return base.method_3<UIBButton>("m_infoButton");
            }
        }

        public UberText m_itemsHeadlineText
        {
            get
            {
                return base.method_3<UberText>("m_itemsHeadlineText");
            }
        }

        public UberText m_itemsText
        {
            get
            {
                return base.method_3<UberText>("m_itemsText");
            }
        }

        public CheckBox m_koreanAgreementCheckBox
        {
            get
            {
                return base.method_3<CheckBox>("m_koreanAgreementCheckBox");
            }
        }

        public UberText m_koreanAgreementTermsText
        {
            get
            {
                return base.method_3<UberText>("m_koreanAgreementTermsText");
            }
        }

        public Transform m_koreanBottomSectionBone
        {
            get
            {
                return base.method_3<Transform>("m_koreanBottomSectionBone");
            }
        }

        public GameObject m_koreanRequirementRoot
        {
            get
            {
                return base.method_3<GameObject>("m_koreanRequirementRoot");
            }
        }

        public Transform m_koreanSummaryBone
        {
            get
            {
                return base.method_3<Transform>("m_koreanSummaryBone");
            }
        }

        public UberText m_priceHeadlineText
        {
            get
            {
                return base.method_3<UberText>("m_priceHeadlineText");
            }
        }

        public UberText m_priceText
        {
            get
            {
                return base.method_3<UberText>("m_priceText");
            }
        }

        public int m_quantity
        {
            get
            {
                return base.method_2<int>("m_quantity");
            }
        }

        public bool m_staticTextResized
        {
            get
            {
                return base.method_2<bool>("m_staticTextResized");
            }
        }

        public UberText m_taxDisclaimerText
        {
            get
            {
                return base.method_3<UberText>("m_taxDisclaimerText");
            }
        }

        public UberText m_termsOfSaleAgreementText
        {
            get
            {
                return base.method_3<UberText>("m_termsOfSaleAgreementText");
            }
        }

        public Transform m_termsOfSaleBottomSectionBone
        {
            get
            {
                return base.method_3<Transform>("m_termsOfSaleBottomSectionBone");
            }
        }

        public UIBButton m_termsOfSaleButton
        {
            get
            {
                return base.method_3<UIBButton>("m_termsOfSaleButton");
            }
        }

        public GameObject m_termsOfSaleRoot
        {
            get
            {
                return base.method_3<GameObject>("m_termsOfSaleRoot");
            }
        }

        public bool m_textInitialized
        {
            get
            {
                return base.method_2<bool>("m_textInitialized");
            }
        }
    }
}

