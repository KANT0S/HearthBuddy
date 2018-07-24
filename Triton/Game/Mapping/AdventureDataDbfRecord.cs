namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureDataDbfRecord")]
    public class AdventureDataDbfRecord : DbfRecord
    {
        public AdventureDataDbfRecord(IntPtr address) : this(address, "AdventureDataDbfRecord")
        {
        }

        public AdventureDataDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetAdventureId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAdventureId", objArray1);
        }

        public void SetAdventureSubDefPrefab(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAdventureSubDefPrefab", objArray1);
        }

        public void SetCompleteBannerText(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetCompleteBannerText", objArray1);
        }

        public void SetDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDescription", objArray1);
        }

        public void SetModeId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetModeId", objArray1);
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

        public void SetRequirementsDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRequirementsDescription", objArray1);
        }

        public void SetShortDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetShortDescription", objArray1);
        }

        public void SetShortName(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetShortName", objArray1);
        }

        public void SetSortOrder(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSortOrder", objArray1);
        }

        public void SetSubscenePrefab(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSubscenePrefab", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public int AdventureId
        {
            get
            {
                return base.method_11<int>("get_AdventureId", Array.Empty<object>());
            }
        }

        public string AdventureSubDefPrefab
        {
            get
            {
                return base.method_13("get_AdventureSubDefPrefab", Array.Empty<object>());
            }
        }

        public DbfLocValue CompleteBannerText
        {
            get
            {
                return base.method_14<DbfLocValue>("get_CompleteBannerText", Array.Empty<object>());
            }
        }

        public DbfLocValue Description
        {
            get
            {
                return base.method_14<DbfLocValue>("get_Description", Array.Empty<object>());
            }
        }

        public int m_AdventureId
        {
            get
            {
                return base.method_2<int>("m_AdventureId");
            }
        }

        public string m_AdventureSubDefPrefab
        {
            get
            {
                return base.method_4("m_AdventureSubDefPrefab");
            }
        }

        public DbfLocValue m_CompleteBannerText
        {
            get
            {
                return base.method_3<DbfLocValue>("m_CompleteBannerText");
            }
        }

        public DbfLocValue m_Description
        {
            get
            {
                return base.method_3<DbfLocValue>("m_Description");
            }
        }

        public int m_ModeId
        {
            get
            {
                return base.method_2<int>("m_ModeId");
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

        public DbfLocValue m_RequirementsDescription
        {
            get
            {
                return base.method_3<DbfLocValue>("m_RequirementsDescription");
            }
        }

        public DbfLocValue m_ShortDescription
        {
            get
            {
                return base.method_3<DbfLocValue>("m_ShortDescription");
            }
        }

        public DbfLocValue m_ShortName
        {
            get
            {
                return base.method_3<DbfLocValue>("m_ShortName");
            }
        }

        public int m_SortOrder
        {
            get
            {
                return base.method_2<int>("m_SortOrder");
            }
        }

        public string m_SubscenePrefab
        {
            get
            {
                return base.method_4("m_SubscenePrefab");
            }
        }

        public int ModeId
        {
            get
            {
                return base.method_11<int>("get_ModeId", Array.Empty<object>());
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

        public DbfLocValue RequirementsDescription
        {
            get
            {
                return base.method_14<DbfLocValue>("get_RequirementsDescription", Array.Empty<object>());
            }
        }

        public DbfLocValue ShortDescription
        {
            get
            {
                return base.method_14<DbfLocValue>("get_ShortDescription", Array.Empty<object>());
            }
        }

        public DbfLocValue ShortName
        {
            get
            {
                return base.method_14<DbfLocValue>("get_ShortName", Array.Empty<object>());
            }
        }

        public int SortOrder
        {
            get
            {
                return base.method_11<int>("get_SortOrder", Array.Empty<object>());
            }
        }

        public string SubscenePrefab
        {
            get
            {
                return base.method_13("get_SubscenePrefab", Array.Empty<object>());
            }
        }
    }
}

