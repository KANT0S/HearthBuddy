namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CollectionSetFilterDropdownItem")]
    public class CollectionSetFilterDropdownItem : PegUIElement
    {
        public CollectionSetFilterDropdownItem(IntPtr address) : this(address, "CollectionSetFilterDropdownItem")
        {
        }

        public CollectionSetFilterDropdownItem(IntPtr address, string className) : base(address, className)
        {
        }

        public void DisableIconMaterial()
        {
            base.method_8("DisableIconMaterial", Array.Empty<object>());
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

        public void Select(bool selection)
        {
            object[] objArray1 = new object[] { selection };
            base.method_8("Select", objArray1);
        }

        public void SetIconMaterialOffset(Vector2 offset)
        {
            object[] objArray1 = new object[] { offset };
            base.method_8("SetIconMaterialOffset", objArray1);
        }

        public void SetItemColors(Color color)
        {
            object[] objArray1 = new object[] { color };
            base.method_8("SetItemColors", objArray1);
        }

        public void SetName(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("SetName", objArray1);
        }

        public UberText m_dropdownText
        {
            get
            {
                return base.method_3<UberText>("m_dropdownText");
            }
        }

        public MeshRenderer m_iconRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_iconRenderer");
            }
        }

        public GameObject m_mouseOverBar
        {
            get
            {
                return base.method_3<GameObject>("m_mouseOverBar");
            }
        }

        public Color m_mouseOverColor
        {
            get
            {
                return base.method_2<Color>("m_mouseOverColor");
            }
        }

        public bool m_selected
        {
            get
            {
                return base.method_2<bool>("m_selected");
            }
        }

        public GameObject m_selectedBar
        {
            get
            {
                return base.method_3<GameObject>("m_selectedBar");
            }
        }

        public Color m_selectedColor
        {
            get
            {
                return base.method_2<Color>("m_selectedColor");
            }
        }

        public Color m_unselectedColor
        {
            get
            {
                return base.method_2<Color>("m_unselectedColor");
            }
        }
    }
}

