namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GeneralStorePackSelectorButton")]
    public class GeneralStorePackSelectorButton : PegUIElement
    {
        public GeneralStorePackSelectorButton(IntPtr address) : this(address, "GeneralStorePackSelectorButton")
        {
        }

        public GeneralStorePackSelectorButton(IntPtr address, string className) : base(address, className)
        {
        }

        public BoosterDbId GetBoosterId()
        {
            return base.method_11<BoosterDbId>("GetBoosterId", Array.Empty<object>());
        }

        public bool IsLatestExpansion()
        {
            return base.method_11<bool>("IsLatestExpansion", Array.Empty<object>());
        }

        public bool IsPreorder()
        {
            return base.method_11<bool>("IsPreorder", Array.Empty<object>());
        }

        public bool IsPurchasable()
        {
            return base.method_11<bool>("IsPurchasable", Array.Empty<object>());
        }

        public bool IsRecommendedForNewPlayer()
        {
            return base.method_11<bool>("IsRecommendedForNewPlayer", Array.Empty<object>());
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void Select()
        {
            base.method_8("Select", Array.Empty<object>());
        }

        public void SetBoosterId(BoosterDbId boosterId)
        {
            object[] objArray1 = new object[] { boosterId };
            base.method_8("SetBoosterId", objArray1);
        }

        public void Unselect()
        {
            base.method_8("Unselect", Array.Empty<object>());
        }

        public void UpdateRibbonIndicator()
        {
            base.method_8("UpdateRibbonIndicator", Array.Empty<object>());
        }

        public BoosterDbId m_boosterId
        {
            get
            {
                return base.method_2<BoosterDbId>("m_boosterId");
            }
        }

        public bool m_checkNewPlayer
        {
            get
            {
                return base.method_2<bool>("m_checkNewPlayer");
            }
        }

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }

        public string m_mouseOverSound
        {
            get
            {
                return base.method_4("m_mouseOverSound");
            }
        }

        public UberText m_packText
        {
            get
            {
                return base.method_3<UberText>("m_packText");
            }
        }

        public int m_recommendedExpertSetOwnedCardCount
        {
            get
            {
                return base.method_2<int>("m_recommendedExpertSetOwnedCardCount");
            }
        }

        public GameObject m_ribbonIndicator
        {
            get
            {
                return base.method_3<GameObject>("m_ribbonIndicator");
            }
        }

        public UberText m_ribbonIndicatorText
        {
            get
            {
                return base.method_3<UberText>("m_ribbonIndicatorText");
            }
        }

        public bool m_selected
        {
            get
            {
                return base.method_2<bool>("m_selected");
            }
        }

        public string m_selectSound
        {
            get
            {
                return base.method_4("m_selectSound");
            }
        }

        public string m_unselectSound
        {
            get
            {
                return base.method_4("m_unselectSound");
            }
        }
    }
}

