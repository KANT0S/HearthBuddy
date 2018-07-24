namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureMissionDbfRecord")]
    public class AdventureMissionDbfRecord : DbfRecord
    {
        public AdventureMissionDbfRecord(IntPtr address) : this(address, "AdventureMissionDbfRecord")
        {
        }

        public AdventureMissionDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetBossDefAssetPath(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetBossDefAssetPath", objArray1);
        }

        public void SetClassChallengePrefabPopup(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetClassChallengePrefabPopup", objArray1);
        }

        public void SetGrantsFlags(ulong v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetGrantsFlags", objArray1);
        }

        public void SetGrantsProgress(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetGrantsProgress", objArray1);
        }

        public void SetGrantsWingId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetGrantsWingId", objArray1);
        }

        public void SetNoteDesc(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNoteDesc", objArray1);
        }

        public void SetReqFlags(ulong v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetReqFlags", objArray1);
        }

        public void SetReqProgress(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetReqProgress", objArray1);
        }

        public void SetReqWingId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetReqWingId", objArray1);
        }

        public void SetScenarioId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetScenarioId", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public string BossDefAssetPath
        {
            get
            {
                return base.method_13("get_BossDefAssetPath", Array.Empty<object>());
            }
        }

        public string ClassChallengePrefabPopup
        {
            get
            {
                return base.method_13("get_ClassChallengePrefabPopup", Array.Empty<object>());
            }
        }

        public ulong GrantsFlags
        {
            get
            {
                return base.method_11<ulong>("get_GrantsFlags", Array.Empty<object>());
            }
        }

        public int GrantsProgress
        {
            get
            {
                return base.method_11<int>("get_GrantsProgress", Array.Empty<object>());
            }
        }

        public int GrantsWingId
        {
            get
            {
                return base.method_11<int>("get_GrantsWingId", Array.Empty<object>());
            }
        }

        public string m_BossDefAssetPath
        {
            get
            {
                return base.method_4("m_BossDefAssetPath");
            }
        }

        public string m_ClassChallengePrefabPopup
        {
            get
            {
                return base.method_4("m_ClassChallengePrefabPopup");
            }
        }

        public ulong m_GrantsFlags
        {
            get
            {
                return base.method_2<ulong>("m_GrantsFlags");
            }
        }

        public int m_GrantsProgress
        {
            get
            {
                return base.method_2<int>("m_GrantsProgress");
            }
        }

        public int m_GrantsWingId
        {
            get
            {
                return base.method_2<int>("m_GrantsWingId");
            }
        }

        public string m_NoteDesc
        {
            get
            {
                return base.method_4("m_NoteDesc");
            }
        }

        public ulong m_ReqFlags
        {
            get
            {
                return base.method_2<ulong>("m_ReqFlags");
            }
        }

        public int m_ReqProgress
        {
            get
            {
                return base.method_2<int>("m_ReqProgress");
            }
        }

        public int m_ReqWingId
        {
            get
            {
                return base.method_2<int>("m_ReqWingId");
            }
        }

        public int m_ScenarioId
        {
            get
            {
                return base.method_2<int>("m_ScenarioId");
            }
        }

        public string NoteDesc
        {
            get
            {
                return base.method_13("get_NoteDesc", Array.Empty<object>());
            }
        }

        public ulong ReqFlags
        {
            get
            {
                return base.method_11<ulong>("get_ReqFlags", Array.Empty<object>());
            }
        }

        public int ReqProgress
        {
            get
            {
                return base.method_11<int>("get_ReqProgress", Array.Empty<object>());
            }
        }

        public int ReqWingId
        {
            get
            {
                return base.method_11<int>("get_ReqWingId", Array.Empty<object>());
            }
        }

        public int ScenarioId
        {
            get
            {
                return base.method_11<int>("get_ScenarioId", Array.Empty<object>());
            }
        }
    }
}

