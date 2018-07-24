namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("WingDbfRecord")]
    public class WingDbfRecord : DbfRecord
    {
        public WingDbfRecord(IntPtr address) : this(address, "WingDbfRecord")
        {
        }

        public WingDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetAdventureWingDefPrefab(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAdventureWingDefPrefab", objArray1);
        }

        public void SetClassChallengeRewardSource(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetClassChallengeRewardSource", objArray1);
        }

        public void SetComingSoonLabel(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetComingSoonLabel", objArray1);
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

        public void SetOwnershipPrereqWingId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetOwnershipPrereqWingId", objArray1);
        }

        public void SetRelease(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRelease", objArray1);
        }

        public void SetRequiredEvent(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRequiredEvent", objArray1);
        }

        public void SetRequiresLabel(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRequiresLabel", objArray1);
        }

        public void SetSortOrder(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSortOrder", objArray1);
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

        public string AdventureWingDefPrefab
        {
            get
            {
                return base.method_13("get_AdventureWingDefPrefab", Array.Empty<object>());
            }
        }

        public DbfLocValue ClassChallengeRewardSource
        {
            get
            {
                return base.method_14<DbfLocValue>("get_ClassChallengeRewardSource", Array.Empty<object>());
            }
        }

        public DbfLocValue ComingSoonLabel
        {
            get
            {
                return base.method_14<DbfLocValue>("get_ComingSoonLabel", Array.Empty<object>());
            }
        }

        public int m_AdventureId
        {
            get
            {
                return base.method_2<int>("m_AdventureId");
            }
        }

        public string m_AdventureWingDefPrefab
        {
            get
            {
                return base.method_4("m_AdventureWingDefPrefab");
            }
        }

        public DbfLocValue m_ClassChallengeRewardSource
        {
            get
            {
                return base.method_3<DbfLocValue>("m_ClassChallengeRewardSource");
            }
        }

        public DbfLocValue m_ComingSoonLabel
        {
            get
            {
                return base.method_3<DbfLocValue>("m_ComingSoonLabel");
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

        public int m_OwnershipPrereqWingId
        {
            get
            {
                return base.method_2<int>("m_OwnershipPrereqWingId");
            }
        }

        public string m_Release
        {
            get
            {
                return base.method_4("m_Release");
            }
        }

        public string m_RequiredEvent
        {
            get
            {
                return base.method_4("m_RequiredEvent");
            }
        }

        public DbfLocValue m_RequiresLabel
        {
            get
            {
                return base.method_3<DbfLocValue>("m_RequiresLabel");
            }
        }

        public int m_SortOrder
        {
            get
            {
                return base.method_2<int>("m_SortOrder");
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

        public int OwnershipPrereqWingId
        {
            get
            {
                return base.method_11<int>("get_OwnershipPrereqWingId", Array.Empty<object>());
            }
        }

        public string Release
        {
            get
            {
                return base.method_13("get_Release", Array.Empty<object>());
            }
        }

        public string RequiredEvent
        {
            get
            {
                return base.method_13("get_RequiredEvent", Array.Empty<object>());
            }
        }

        public DbfLocValue RequiresLabel
        {
            get
            {
                return base.method_14<DbfLocValue>("get_RequiresLabel", Array.Empty<object>());
            }
        }

        public int SortOrder
        {
            get
            {
                return base.method_11<int>("get_SortOrder", Array.Empty<object>());
            }
        }
    }
}

