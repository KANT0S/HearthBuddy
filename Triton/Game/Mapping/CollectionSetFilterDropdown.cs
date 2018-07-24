namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("CollectionSetFilterDropdown")]
    public class CollectionSetFilterDropdown : MonoBehaviour
    {
        public CollectionSetFilterDropdown(IntPtr address) : this(address, "CollectionSetFilterDropdown")
        {
        }

        public CollectionSetFilterDropdown(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearFilter()
        {
            base.method_8("ClearFilter", Array.Empty<object>());
        }

        public bool IsShowing()
        {
            return base.method_11<bool>("IsShowing", Array.Empty<object>());
        }

        public void Select(int index)
        {
            object[] objArray1 = new object[] { index };
            base.method_8("Select", objArray1);
        }

        public void Show(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("Show", objArray1);
        }

        public MultiSliceElement m_background
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_background");
            }
        }

        public GameObject m_backgroundMiddleSection
        {
            get
            {
                return base.method_3<GameObject>("m_backgroundMiddleSection");
            }
        }

        public float m_backgroundPadding
        {
            get
            {
                return base.method_2<float>("m_backgroundPadding");
            }
        }

        public PegUIElement m_hideDropDownButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_hideDropDownButton");
            }
        }

        public MultiSliceElement m_itemContainer
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_itemContainer");
            }
        }

        public List<CollectionSetFilterDropdownItem> m_items
        {
            get
            {
                Class267<CollectionSetFilterDropdownItem> class2 = base.method_3<Class267<CollectionSetFilterDropdownItem>>("m_items");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public CollectionSetFilterDropdownItem m_itemTemplate
        {
            get
            {
                return base.method_3<CollectionSetFilterDropdownItem>("m_itemTemplate");
            }
        }

        public CollectionSetFilterDropdownToggle m_showDropDownButton
        {
            get
            {
                return base.method_3<CollectionSetFilterDropdownToggle>("m_showDropDownButton");
            }
        }

        public bool m_showing
        {
            get
            {
                return base.method_2<bool>("m_showing");
            }
        }

        public UIBHighlight m_toggleButtonHighlight
        {
            get
            {
                return base.method_3<UIBHighlight>("m_toggleButtonHighlight");
            }
        }

        public string m_toggleSound
        {
            get
            {
                return base.method_4("m_toggleSound");
            }
        }
    }
}

