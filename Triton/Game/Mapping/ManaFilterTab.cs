namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ManaFilterTab")]
    public class ManaFilterTab : PegUIElement
    {
        public ManaFilterTab(IntPtr address) : this(address, "ManaFilterTab")
        {
        }

        public ManaFilterTab(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public int GetManaID()
        {
            return base.method_11<int>("GetManaID", Array.Empty<object>());
        }

        public void NotifyMousedOut()
        {
            base.method_8("NotifyMousedOut", Array.Empty<object>());
        }

        public void NotifyMousedOver()
        {
            base.method_8("NotifyMousedOver", Array.Empty<object>());
        }

        public void SetFilterState(FilterState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("SetFilterState", objArray1);
        }

        public void SetManaID(int manaID)
        {
            object[] objArray1 = new object[] { manaID };
            base.method_8("SetManaID", objArray1);
        }

        public void UpdateManaText()
        {
            base.method_8("UpdateManaText", Array.Empty<object>());
        }

        public static int ALL_TAB_IDX
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ManaFilterTab", "ALL_TAB_IDX");
            }
        }

        public UberText m_costText
        {
            get
            {
                return base.method_3<UberText>("m_costText");
            }
        }

        public ManaCrystal m_crystal
        {
            get
            {
                return base.method_3<ManaCrystal>("m_crystal");
            }
        }

        public FilterState m_filterState
        {
            get
            {
                return base.method_2<FilterState>("m_filterState");
            }
        }

        public int m_manaID
        {
            get
            {
                return base.method_2<int>("m_manaID");
            }
        }

        public UberText m_otherText
        {
            get
            {
                return base.method_3<UberText>("m_otherText");
            }
        }

        public static int SEVEN_PLUS_TAB_IDX
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ManaFilterTab", "SEVEN_PLUS_TAB_IDX");
            }
        }

        public enum FilterState
        {
            ON,
            OFF,
            DISABLED
        }
    }
}

