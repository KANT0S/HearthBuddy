namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AchieveDbfRecord")]
    public class AchieveDbfRecord : DbfRecord
    {
        public AchieveDbfRecord(IntPtr address) : this(address, "AchieveDbfRecord")
        {
        }

        public AchieveDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetAchQuota(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAchQuota", objArray1);
        }

        public void SetAchType(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAchType", objArray1);
        }

        public void SetBooster(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetBooster", objArray1);
        }

        public void SetCardSet(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetCardSet", objArray1);
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

        public void SetEvent(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetEvent", objArray1);
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

        public void SetParentAch(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetParentAch", objArray1);
        }

        public void SetRace(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRace", objArray1);
        }

        public void SetReward(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetReward", objArray1);
        }

        public void SetRewardData1(long v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRewardData1", objArray1);
        }

        public void SetRewardData2(long v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRewardData2", objArray1);
        }

        public void SetRewardTiming(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRewardTiming", objArray1);
        }

        public void SetTriggered(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetTriggered", objArray1);
        }

        public void SetUnlocks(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetUnlocks", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public int AchQuota
        {
            get
            {
                return base.method_11<int>("get_AchQuota", Array.Empty<object>());
            }
        }

        public string AchType
        {
            get
            {
                return base.method_13("get_AchType", Array.Empty<object>());
            }
        }

        public int Booster
        {
            get
            {
                return base.method_11<int>("get_Booster", Array.Empty<object>());
            }
        }

        public int CardSet
        {
            get
            {
                return base.method_11<int>("get_CardSet", Array.Empty<object>());
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

        public string Event
        {
            get
            {
                return base.method_13("get_Event", Array.Empty<object>());
            }
        }

        public int m_AchQuota
        {
            get
            {
                return base.method_2<int>("m_AchQuota");
            }
        }

        public string m_AchType
        {
            get
            {
                return base.method_4("m_AchType");
            }
        }

        public int m_Booster
        {
            get
            {
                return base.method_2<int>("m_Booster");
            }
        }

        public int m_CardSet
        {
            get
            {
                return base.method_2<int>("m_CardSet");
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

        public string m_Event
        {
            get
            {
                return base.method_4("m_Event");
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

        public string m_ParentAch
        {
            get
            {
                return base.method_4("m_ParentAch");
            }
        }

        public int m_Race
        {
            get
            {
                return base.method_2<int>("m_Race");
            }
        }

        public string m_Reward
        {
            get
            {
                return base.method_4("m_Reward");
            }
        }

        public long m_RewardData1
        {
            get
            {
                return base.method_2<long>("m_RewardData1");
            }
        }

        public long m_RewardData2
        {
            get
            {
                return base.method_2<long>("m_RewardData2");
            }
        }

        public string m_RewardTiming
        {
            get
            {
                return base.method_4("m_RewardTiming");
            }
        }

        public string m_Triggered
        {
            get
            {
                return base.method_4("m_Triggered");
            }
        }

        public string m_Unlocks
        {
            get
            {
                return base.method_4("m_Unlocks");
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

        public string ParentAch
        {
            get
            {
                return base.method_13("get_ParentAch", Array.Empty<object>());
            }
        }

        public int Race
        {
            get
            {
                return base.method_11<int>("get_Race", Array.Empty<object>());
            }
        }

        public string Reward
        {
            get
            {
                return base.method_13("get_Reward", Array.Empty<object>());
            }
        }

        public long RewardData1
        {
            get
            {
                return base.method_11<long>("get_RewardData1", Array.Empty<object>());
            }
        }

        public long RewardData2
        {
            get
            {
                return base.method_11<long>("get_RewardData2", Array.Empty<object>());
            }
        }

        public string RewardTiming
        {
            get
            {
                return base.method_13("get_RewardTiming", Array.Empty<object>());
            }
        }

        public string Triggered
        {
            get
            {
                return base.method_13("get_Triggered", Array.Empty<object>());
            }
        }

        public string Unlocks
        {
            get
            {
                return base.method_13("get_Unlocks", Array.Empty<object>());
            }
        }
    }
}

