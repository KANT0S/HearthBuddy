namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoosterDbfRecord")]
    public class BoosterDbfRecord : DbfRecord
    {
        public BoosterDbfRecord(IntPtr address) : this(address, "BoosterDbfRecord")
        {
        }

        public BoosterDbfRecord(IntPtr address, string className) : base(address, className)
        {
        }

        public object GetVar(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<object>("GetVar", objArray1);
        }

        public System.Type GetVarType(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<System.Type>("GetVarType", objArray1);
        }

        public void SetArenaPrefab(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetArenaPrefab", objArray1);
        }

        public void SetBuyWithGoldEvent(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetBuyWithGoldEvent", objArray1);
        }

        public void SetLeavingSoon(bool v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetLeavingSoon", objArray1);
        }

        public void SetLeavingSoonText(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetLeavingSoonText", objArray1);
        }

        public void SetName(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetName", objArray1);
        }

        public void SetNoteDesc(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNoteDesc", objArray1);
        }

        public void SetOpenPackEvent(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetOpenPackEvent", objArray1);
        }

        public void SetPackOpeningFxPrefab(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetPackOpeningFxPrefab", objArray1);
        }

        public void SetPackOpeningPrefab(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetPackOpeningPrefab", objArray1);
        }

        public void SetSortOrder(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSortOrder", objArray1);
        }

        public void SetStorePrefab(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStorePrefab", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public string ArenaPrefab
        {
            get
            {
                return base.method_13("get_ArenaPrefab", Array.Empty<object>());
            }
        }

        public string BuyWithGoldEvent
        {
            get
            {
                return base.method_13("get_BuyWithGoldEvent", Array.Empty<object>());
            }
        }

        public bool LeavingSoon
        {
            get
            {
                return base.method_11<bool>("get_LeavingSoon", Array.Empty<object>());
            }
        }

        public DbfLocValue LeavingSoonText
        {
            get
            {
                return base.method_14<DbfLocValue>("get_LeavingSoonText", Array.Empty<object>());
            }
        }

        public string m_ArenaPrefab
        {
            get
            {
                return base.method_4("m_ArenaPrefab");
            }
        }

        public string m_BuyWithGoldEvent
        {
            get
            {
                return base.method_4("m_BuyWithGoldEvent");
            }
        }

        public bool m_LeavingSoon
        {
            get
            {
                return base.method_2<bool>("m_LeavingSoon");
            }
        }

        public DbfLocValue m_LeavingSoonText
        {
            get
            {
                return base.method_3<DbfLocValue>("m_LeavingSoonText");
            }
        }

        public DbfLocValue m_Name
        {
            get
            {
                return base.method_3<DbfLocValue>("m_Name");
            }
        }

        public string m_NoteDesc
        {
            get
            {
                return base.method_4("m_NoteDesc");
            }
        }

        public string m_OpenPackEvent
        {
            get
            {
                return base.method_4("m_OpenPackEvent");
            }
        }

        public string m_PackOpeningFxPrefab
        {
            get
            {
                return base.method_4("m_PackOpeningFxPrefab");
            }
        }

        public string m_PackOpeningPrefab
        {
            get
            {
                return base.method_4("m_PackOpeningPrefab");
            }
        }

        public int m_SortOrder
        {
            get
            {
                return base.method_2<int>("m_SortOrder");
            }
        }

        public string m_StorePrefab
        {
            get
            {
                return base.method_4("m_StorePrefab");
            }
        }

        public DbfLocValue Name
        {
            get
            {
                return base.method_14<DbfLocValue>("get_Name", Array.Empty<object>());
            }
        }

        public string NoteDesc
        {
            get
            {
                return base.method_13("get_NoteDesc", Array.Empty<object>());
            }
        }

        public string OpenPackEvent
        {
            get
            {
                return base.method_13("get_OpenPackEvent", Array.Empty<object>());
            }
        }

        public string PackOpeningFxPrefab
        {
            get
            {
                return base.method_13("get_PackOpeningFxPrefab", Array.Empty<object>());
            }
        }

        public string PackOpeningPrefab
        {
            get
            {
                return base.method_13("get_PackOpeningPrefab", Array.Empty<object>());
            }
        }

        public int SortOrder
        {
            get
            {
                return base.method_11<int>("get_SortOrder", Array.Empty<object>());
            }
        }

        public string StorePrefab
        {
            get
            {
                return base.method_13("get_StorePrefab", Array.Empty<object>());
            }
        }
    }
}

