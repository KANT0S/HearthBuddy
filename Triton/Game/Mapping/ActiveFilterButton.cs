namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ActiveFilterButton")]
    public class ActiveFilterButton : MonoBehaviour
    {
        public ActiveFilterButton(IntPtr address) : this(address, "ActiveFilterButton")
        {
        }

        public ActiveFilterButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearFilters()
        {
            base.method_8("ClearFilters", Array.Empty<object>());
        }

        public void FiltersUpdated()
        {
            base.method_8("FiltersUpdated", Array.Empty<object>());
        }

        public bool HideFilters()
        {
            return base.method_11<bool>("HideFilters", Array.Empty<object>());
        }

        public void ManaFilterUpdate(bool state, object description)
        {
            object[] objArray1 = new object[] { state, description };
            base.method_8("ManaFilterUpdate", objArray1);
        }

        public void OffClickPressed()
        {
            base.method_8("OffClickPressed", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void SearchFilterUpdate(bool state, object description)
        {
            object[] objArray1 = new object[] { state, description };
            base.method_8("SearchFilterUpdate", objArray1);
        }

        public void SetEnabled(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("SetEnabled", objArray1);
        }

        public void ShowFilters()
        {
            base.method_8("ShowFilters", Array.Empty<object>());
        }

        public PegUIElement m_activeFilterButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_activeFilterButton");
            }
        }

        public SlidingTray m_activeFilterTray
        {
            get
            {
                return base.method_3<SlidingTray>("m_activeFilterTray");
            }
        }

        public Material m_disabledMaterial
        {
            get
            {
                return base.method_3<Material>("m_disabledMaterial");
            }
        }

        public Material m_enabledMaterial
        {
            get
            {
                return base.method_3<Material>("m_enabledMaterial");
            }
        }

        public bool m_filtersShown
        {
            get
            {
                return base.method_2<bool>("m_filtersShown");
            }
        }

        public PegUIElement m_inactiveFilterButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_inactiveFilterButton");
            }
        }

        public MeshRenderer m_inactiveFilterButtonRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_inactiveFilterButtonRenderer");
            }
        }

        public GameObject m_inactiveFilterButtonText
        {
            get
            {
                return base.method_3<GameObject>("m_inactiveFilterButtonText");
            }
        }

        public ManaFilterTabManager m_manaFilter
        {
            get
            {
                return base.method_3<ManaFilterTabManager>("m_manaFilter");
            }
        }

        public bool m_manaFilterActive
        {
            get
            {
                return base.method_2<bool>("m_manaFilterActive");
            }
        }

        public GameObject m_manaFilterIcon
        {
            get
            {
                return base.method_3<GameObject>("m_manaFilterIcon");
            }
        }

        public UberText m_manaFilterText
        {
            get
            {
                return base.method_3<UberText>("m_manaFilterText");
            }
        }

        public string m_manaFilterValue
        {
            get
            {
                return base.method_4("m_manaFilterValue");
            }
        }

        public PegUIElement m_offClickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_offClickCatcher");
            }
        }

        public CollectionSearch m_search
        {
            get
            {
                return base.method_3<CollectionSearch>("m_search");
            }
        }

        public bool m_searchFilterActive
        {
            get
            {
                return base.method_2<bool>("m_searchFilterActive");
            }
        }

        public string m_searchFilterValue
        {
            get
            {
                return base.method_4("m_searchFilterValue");
            }
        }

        public UberText m_searchText
        {
            get
            {
                return base.method_3<UberText>("m_searchText");
            }
        }
    }
}

