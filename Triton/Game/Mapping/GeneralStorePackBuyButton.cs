namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("GeneralStorePackBuyButton")]
    public class GeneralStorePackBuyButton : PegUIElement
    {
        public GeneralStorePackBuyButton(IntPtr address) : this(address, "GeneralStorePackBuyButton")
        {
        }

        public GeneralStorePackBuyButton(IntPtr address, string className) : base(address, className)
        {
        }

        public bool IsSelected()
        {
            return base.method_11<bool>("IsSelected", Array.Empty<object>());
        }

        public void OnDoubleClick()
        {
            base.method_8("OnDoubleClick", Array.Empty<object>());
        }

        public void Select()
        {
            base.method_8("Select", Array.Empty<object>());
        }

        public void SetGoldValue(long goldCost, string quantityText)
        {
            object[] objArray1 = new object[] { goldCost, quantityText };
            base.method_8("SetGoldValue", objArray1);
        }

        public void SetMoneyValue(Network.Bundle bundle, string quantityText)
        {
            object[] objArray1 = new object[] { bundle, quantityText };
            base.method_8("SetMoneyValue", objArray1);
        }

        public void Unselect()
        {
            base.method_8("Unselect", Array.Empty<object>());
        }

        public void UpdateButtonState()
        {
            base.method_8("UpdateButtonState", Array.Empty<object>());
        }

        public void UpdateFromGTAPP(NoGTAPPTransactionData noGTAPPGoldPrice)
        {
            object[] objArray1 = new object[] { noGTAPPGoldPrice };
            base.method_8("UpdateFromGTAPP", objArray1);
        }

        public void UpdateFromMoneyBundle(Network.Bundle bundle)
        {
            object[] objArray1 = new object[] { bundle };
            base.method_8("UpdateFromMoneyBundle", objArray1);
        }

        public List<Renderer> m_buttonRenderers
        {
            get
            {
                Class267<Renderer> class2 = base.method_3<Class267<Renderer>>("m_buttonRenderers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_costText
        {
            get
            {
                return base.method_3<UberText>("m_costText");
            }
        }

        public UberText m_fullText
        {
            get
            {
                return base.method_3<UberText>("m_fullText");
            }
        }

        public Vector2 m_goldBtnDownMatOffset
        {
            get
            {
                return base.method_2<Vector2>("m_goldBtnDownMatOffset");
            }
        }

        public Vector2 m_goldBtnMatOffset
        {
            get
            {
                return base.method_2<Vector2>("m_goldBtnMatOffset");
            }
        }

        public Color m_goldCostTextColor
        {
            get
            {
                return base.method_2<Color>("m_goldCostTextColor");
            }
        }

        public GameObject m_goldIcon
        {
            get
            {
                return base.method_3<GameObject>("m_goldIcon");
            }
        }

        public Color m_goldQuantityTextColor
        {
            get
            {
                return base.method_2<Color>("m_goldQuantityTextColor");
            }
        }

        public bool m_isGold
        {
            get
            {
                return base.method_2<bool>("m_isGold");
            }
        }

        public int m_materialIndex
        {
            get
            {
                return base.method_2<int>("m_materialIndex");
            }
        }

        public string m_materialPropName
        {
            get
            {
                return base.method_4("m_materialPropName");
            }
        }

        public Vector2 m_moneyBtnDownMatOffset
        {
            get
            {
                return base.method_2<Vector2>("m_moneyBtnDownMatOffset");
            }
        }

        public Vector2 m_moneyBtnMatOffset
        {
            get
            {
                return base.method_2<Vector2>("m_moneyBtnMatOffset");
            }
        }

        public Color m_moneyCostTextColor
        {
            get
            {
                return base.method_2<Color>("m_moneyCostTextColor");
            }
        }

        public Color m_moneyQuantityTextColor
        {
            get
            {
                return base.method_2<Color>("m_moneyQuantityTextColor");
            }
        }

        public UberText m_quantityText
        {
            get
            {
                return base.method_3<UberText>("m_quantityText");
            }
        }

        public bool m_selected
        {
            get
            {
                return base.method_2<bool>("m_selected");
            }
        }

        public GameObject m_selectGlow
        {
            get
            {
                return base.method_3<GameObject>("m_selectGlow");
            }
        }
    }
}

