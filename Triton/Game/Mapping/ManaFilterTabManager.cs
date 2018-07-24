namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("ManaFilterTabManager")]
    public class ManaFilterTabManager : MonoBehaviour
    {
        public ManaFilterTabManager(IntPtr address) : this(address, "ManaFilterTabManager")
        {
        }

        public ManaFilterTabManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateTabs(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("ActivateTabs", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearFilter()
        {
            base.method_8("ClearFilter", Array.Empty<object>());
        }

        public void CreateNewTab(ManaFilterTab tabPrefab, int index)
        {
            object[] objArray1 = new object[] { tabPrefab, index };
            base.method_8("CreateNewTab", objArray1);
        }

        public void Enable(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("Enable", objArray1);
        }

        public void OnTabMousedOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTabMousedOut", objArray1);
        }

        public void OnTabMousedOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTabMousedOver", objArray1);
        }

        public void OnTabPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTabPressed", objArray1);
        }

        public void SetUpTabs()
        {
            base.method_8("SetUpTabs", Array.Empty<object>());
        }

        public void ShowManaTabHint(ManaFilterTab tabButton)
        {
            object[] objArray1 = new object[] { tabButton };
            base.method_8("ShowManaTabHint", objArray1);
        }

        public void UpdateCurrentFilterValue(int filterValue)
        {
            object[] objArray1 = new object[] { filterValue };
            base.method_8("UpdateCurrentFilterValue", objArray1);
        }

        public void UpdateFilterStates()
        {
            base.method_8("UpdateFilterStates", Array.Empty<object>());
        }

        public int m_currentFilterValue
        {
            get
            {
                return base.method_2<int>("m_currentFilterValue");
            }
        }

        public ManaFilterTab m_dynamicManaFilterPrefab
        {
            get
            {
                return base.method_3<ManaFilterTab>("m_dynamicManaFilterPrefab");
            }
        }

        public MultiSliceElement m_manaCrystalContainer
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_manaCrystalContainer");
            }
        }

        public ManaFilterTab m_singleManaFilterPrefab
        {
            get
            {
                return base.method_3<ManaFilterTab>("m_singleManaFilterPrefab");
            }
        }

        public List<ManaFilterTab> m_tabs
        {
            get
            {
                Class267<ManaFilterTab> class2 = base.method_3<Class267<ManaFilterTab>>("m_tabs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_tabsActive
        {
            get
            {
                return base.method_2<bool>("m_tabsActive");
            }
        }
    }
}

