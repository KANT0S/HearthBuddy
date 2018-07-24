namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GeneralStoreAdventureSelectorButton")]
    public class GeneralStoreAdventureSelectorButton : PegUIElement
    {
        public GeneralStoreAdventureSelectorButton(IntPtr address) : this(address, "GeneralStoreAdventureSelectorButton")
        {
        }

        public GeneralStoreAdventureSelectorButton(IntPtr address, string className) : base(address, className)
        {
        }

        public AdventureDbId GetAdventureType()
        {
            return base.method_11<AdventureDbId>("GetAdventureType", Array.Empty<object>());
        }

        public bool IsAvailable()
        {
            return base.method_11<bool>("IsAvailable", Array.Empty<object>());
        }

        public bool IsPreorder()
        {
            return base.method_11<bool>("IsPreorder", Array.Empty<object>());
        }

        public bool IsPurchasable()
        {
            return base.method_11<bool>("IsPurchasable", Array.Empty<object>());
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

        public void SetAdventureType(AdventureDbId adventure)
        {
            object[] objArray1 = new object[] { adventure };
            base.method_8("SetAdventureType", objArray1);
        }

        public void Unselect()
        {
            base.method_8("Unselect", Array.Empty<object>());
        }

        public void UpdateState()
        {
            base.method_8("UpdateState", Array.Empty<object>());
        }

        public UberText m_adventureTitle
        {
            get
            {
                return base.method_3<UberText>("m_adventureTitle");
            }
        }

        public AdventureDbId m_adventureType
        {
            get
            {
                return base.method_2<AdventureDbId>("m_adventureType");
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

        public GameObject m_preorderRibbon
        {
            get
            {
                return base.method_3<GameObject>("m_preorderRibbon");
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

        public TooltipZone m_unavailableTooltip
        {
            get
            {
                return base.method_3<TooltipZone>("m_unavailableTooltip");
            }
        }

        public GameLayer m_unavailableTooltipLayer
        {
            get
            {
                return base.method_2<GameLayer>("m_unavailableTooltipLayer");
            }
        }

        public float m_unavailableTooltipScale
        {
            get
            {
                return base.method_2<float>("m_unavailableTooltipScale");
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

