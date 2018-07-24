namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureDbfRecord")]
    public class AdventureDbfRecord : DbfRecord
    {
        public AdventureDbfRecord(IntPtr address) : this(address, "AdventureDbfRecord")
        {
        }

        public AdventureDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetAdventureDefPrefab(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAdventureDefPrefab", objArray1);
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

        public void SetSortOrder(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSortOrder", objArray1);
        }

        public void SetStoreBuyButtonLabel(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyButtonLabel", objArray1);
        }

        public void SetStoreBuyWings1Desc(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyWings1Desc", objArray1);
        }

        public void SetStoreBuyWings1Headline(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyWings1Headline", objArray1);
        }

        public void SetStoreBuyWings2Desc(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyWings2Desc", objArray1);
        }

        public void SetStoreBuyWings2Headline(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyWings2Headline", objArray1);
        }

        public void SetStoreBuyWings3Desc(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyWings3Desc", objArray1);
        }

        public void SetStoreBuyWings3Headline(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyWings3Headline", objArray1);
        }

        public void SetStoreBuyWings4Desc(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyWings4Desc", objArray1);
        }

        public void SetStoreBuyWings4Headline(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyWings4Headline", objArray1);
        }

        public void SetStoreBuyWings5Desc(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyWings5Desc", objArray1);
        }

        public void SetStoreBuyWings5Headline(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBuyWings5Headline", objArray1);
        }

        public void SetStoreOwnedDesc(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreOwnedDesc", objArray1);
        }

        public void SetStoreOwnedHeadline(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreOwnedHeadline", objArray1);
        }

        public void SetStorePrefab(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStorePrefab", objArray1);
        }

        public void SetStorePreorderDesc(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStorePreorderDesc", objArray1);
        }

        public void SetStorePreorderHeadline(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStorePreorderHeadline", objArray1);
        }

        public void SetStorePreviewRewardsText(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStorePreviewRewardsText", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public string AdventureDefPrefab
        {
            get
            {
                return base.method_13("get_AdventureDefPrefab", Array.Empty<object>());
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

        public string m_AdventureDefPrefab
        {
            get
            {
                return base.method_4("m_AdventureDefPrefab");
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

        public int m_SortOrder
        {
            get
            {
                return base.method_2<int>("m_SortOrder");
            }
        }

        public DbfLocValue m_StoreBuyButtonLabel
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyButtonLabel");
            }
        }

        public DbfLocValue m_StoreBuyWings1Desc
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyWings1Desc");
            }
        }

        public DbfLocValue m_StoreBuyWings1Headline
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyWings1Headline");
            }
        }

        public DbfLocValue m_StoreBuyWings2Desc
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyWings2Desc");
            }
        }

        public DbfLocValue m_StoreBuyWings2Headline
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyWings2Headline");
            }
        }

        public DbfLocValue m_StoreBuyWings3Desc
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyWings3Desc");
            }
        }

        public DbfLocValue m_StoreBuyWings3Headline
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyWings3Headline");
            }
        }

        public DbfLocValue m_StoreBuyWings4Desc
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyWings4Desc");
            }
        }

        public DbfLocValue m_StoreBuyWings4Headline
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyWings4Headline");
            }
        }

        public DbfLocValue m_StoreBuyWings5Desc
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyWings5Desc");
            }
        }

        public DbfLocValue m_StoreBuyWings5Headline
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreBuyWings5Headline");
            }
        }

        public DbfLocValue m_StoreOwnedDesc
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreOwnedDesc");
            }
        }

        public DbfLocValue m_StoreOwnedHeadline
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreOwnedHeadline");
            }
        }

        public string m_StorePrefab
        {
            get
            {
                return base.method_4("m_StorePrefab");
            }
        }

        public DbfLocValue m_StorePreorderDesc
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StorePreorderDesc");
            }
        }

        public DbfLocValue m_StorePreorderHeadline
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StorePreorderHeadline");
            }
        }

        public DbfLocValue m_StorePreviewRewardsText
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StorePreviewRewardsText");
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

        public int SortOrder
        {
            get
            {
                return base.method_11<int>("get_SortOrder", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyButtonLabel
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyButtonLabel", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyWings1Desc
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyWings1Desc", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyWings1Headline
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyWings1Headline", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyWings2Desc
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyWings2Desc", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyWings2Headline
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyWings2Headline", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyWings3Desc
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyWings3Desc", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyWings3Headline
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyWings3Headline", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyWings4Desc
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyWings4Desc", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyWings4Headline
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyWings4Headline", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyWings5Desc
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyWings5Desc", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreBuyWings5Headline
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreBuyWings5Headline", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreOwnedDesc
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreOwnedDesc", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreOwnedHeadline
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreOwnedHeadline", Array.Empty<object>());
            }
        }

        public string StorePrefab
        {
            get
            {
                return base.method_13("get_StorePrefab", Array.Empty<object>());
            }
        }

        public DbfLocValue StorePreorderDesc
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StorePreorderDesc", Array.Empty<object>());
            }
        }

        public DbfLocValue StorePreorderHeadline
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StorePreorderHeadline", Array.Empty<object>());
            }
        }

        public DbfLocValue StorePreviewRewardsText
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StorePreviewRewardsText", Array.Empty<object>());
            }
        }
    }
}

