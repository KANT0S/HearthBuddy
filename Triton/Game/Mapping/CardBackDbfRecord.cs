namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBackDbfRecord")]
    public class CardBackDbfRecord : DbfRecord
    {
        public CardBackDbfRecord(IntPtr address) : this(address, "CardBackDbfRecord")
        {
        }

        public CardBackDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetData1(long v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetData1", objArray1);
        }

        public void SetDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDescription", objArray1);
        }

        public void SetEnabled(bool v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetEnabled", objArray1);
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

        public void SetPrefabName(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetPrefabName", objArray1);
        }

        public void SetSortCategory(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSortCategory", objArray1);
        }

        public void SetSortOrder(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSortOrder", objArray1);
        }

        public void SetSource(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSource", objArray1);
        }

        public void SetSourceDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSourceDescription", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public long Data1
        {
            get
            {
                return base.method_11<long>("get_Data1", Array.Empty<object>());
            }
        }

        public DbfLocValue Description
        {
            get
            {
                return base.method_14<DbfLocValue>("get_Description", Array.Empty<object>());
            }
        }

        public bool Enabled
        {
            get
            {
                return base.method_11<bool>("get_Enabled", Array.Empty<object>());
            }
        }

        public long m_Data1
        {
            get
            {
                return base.method_2<long>("m_Data1");
            }
        }

        public DbfLocValue m_Description
        {
            get
            {
                return base.method_3<DbfLocValue>("m_Description");
            }
        }

        public bool m_Enabled
        {
            get
            {
                return base.method_2<bool>("m_Enabled");
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

        public string m_PrefabName
        {
            get
            {
                return base.method_4("m_PrefabName");
            }
        }

        public int m_SortCategory
        {
            get
            {
                return base.method_2<int>("m_SortCategory");
            }
        }

        public int m_SortOrder
        {
            get
            {
                return base.method_2<int>("m_SortOrder");
            }
        }

        public string m_Source
        {
            get
            {
                return base.method_4("m_Source");
            }
        }

        public DbfLocValue m_SourceDescription
        {
            get
            {
                return base.method_3<DbfLocValue>("m_SourceDescription");
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

        public string PrefabName
        {
            get
            {
                return base.method_13("get_PrefabName", Array.Empty<object>());
            }
        }

        public int SortCategory
        {
            get
            {
                return base.method_11<int>("get_SortCategory", Array.Empty<object>());
            }
        }

        public int SortOrder
        {
            get
            {
                return base.method_11<int>("get_SortOrder", Array.Empty<object>());
            }
        }

        public string Source
        {
            get
            {
                return base.method_13("get_Source", Array.Empty<object>());
            }
        }

        public DbfLocValue SourceDescription
        {
            get
            {
                return base.method_14<DbfLocValue>("get_SourceDescription", Array.Empty<object>());
            }
        }
    }
}

