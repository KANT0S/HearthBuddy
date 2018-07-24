namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FixedRewardActionDbfRecord")]
    public class FixedRewardActionDbfRecord : DbfRecord
    {
        public FixedRewardActionDbfRecord(IntPtr address) : this(address, "FixedRewardActionDbfRecord")
        {
        }

        public FixedRewardActionDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetAccountLicenseFlags(ulong v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAccountLicenseFlags", objArray1);
        }

        public void SetAccountLicenseId(long v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAccountLicenseId", objArray1);
        }

        public void SetAchieveId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAchieveId", objArray1);
        }

        public void SetClassId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetClassId", objArray1);
        }

        public void SetHeroLevel(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetHeroLevel", objArray1);
        }

        public void SetMetaActionFlags(ulong v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetMetaActionFlags", objArray1);
        }

        public void SetNoteDesc(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNoteDesc", objArray1);
        }

        public void SetTutorialProgress(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetTutorialProgress", objArray1);
        }

        public void SetType(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetType", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public void SetWingFlags(ulong v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetWingFlags", objArray1);
        }

        public void SetWingId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetWingId", objArray1);
        }

        public void SetWingProgress(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetWingProgress", objArray1);
        }

        public ulong AccountLicenseFlags
        {
            get
            {
                return base.method_11<ulong>("get_AccountLicenseFlags", Array.Empty<object>());
            }
        }

        public long AccountLicenseId
        {
            get
            {
                return base.method_11<long>("get_AccountLicenseId", Array.Empty<object>());
            }
        }

        public int AchieveId
        {
            get
            {
                return base.method_11<int>("get_AchieveId", Array.Empty<object>());
            }
        }

        public int ClassId
        {
            get
            {
                return base.method_11<int>("get_ClassId", Array.Empty<object>());
            }
        }

        public int HeroLevel
        {
            get
            {
                return base.method_11<int>("get_HeroLevel", Array.Empty<object>());
            }
        }

        public ulong m_AccountLicenseFlags
        {
            get
            {
                return base.method_2<ulong>("m_AccountLicenseFlags");
            }
        }

        public long m_AccountLicenseId
        {
            get
            {
                return base.method_2<long>("m_AccountLicenseId");
            }
        }

        public int m_AchieveId
        {
            get
            {
                return base.method_2<int>("m_AchieveId");
            }
        }

        public int m_ClassId
        {
            get
            {
                return base.method_2<int>("m_ClassId");
            }
        }

        public int m_HeroLevel
        {
            get
            {
                return base.method_2<int>("m_HeroLevel");
            }
        }

        public ulong m_MetaActionFlags
        {
            get
            {
                return base.method_2<ulong>("m_MetaActionFlags");
            }
        }

        public string m_NoteDesc
        {
            get
            {
                return base.method_4("m_NoteDesc");
            }
        }

        public int m_TutorialProgress
        {
            get
            {
                return base.method_2<int>("m_TutorialProgress");
            }
        }

        public string m_Type
        {
            get
            {
                return base.method_4("m_Type");
            }
        }

        public ulong m_WingFlags
        {
            get
            {
                return base.method_2<ulong>("m_WingFlags");
            }
        }

        public int m_WingId
        {
            get
            {
                return base.method_2<int>("m_WingId");
            }
        }

        public int m_WingProgress
        {
            get
            {
                return base.method_2<int>("m_WingProgress");
            }
        }

        public ulong MetaActionFlags
        {
            get
            {
                return base.method_11<ulong>("get_MetaActionFlags", Array.Empty<object>());
            }
        }

        public string NoteDesc
        {
            get
            {
                return base.method_13("get_NoteDesc", Array.Empty<object>());
            }
        }

        public int TutorialProgress
        {
            get
            {
                return base.method_11<int>("get_TutorialProgress", Array.Empty<object>());
            }
        }

        public string Type
        {
            get
            {
                return base.method_13("get_Type", Array.Empty<object>());
            }
        }

        public ulong WingFlags
        {
            get
            {
                return base.method_11<ulong>("get_WingFlags", Array.Empty<object>());
            }
        }

        public int WingId
        {
            get
            {
                return base.method_11<int>("get_WingId", Array.Empty<object>());
            }
        }

        public int WingProgress
        {
            get
            {
                return base.method_11<int>("get_WingProgress", Array.Empty<object>());
            }
        }
    }
}

