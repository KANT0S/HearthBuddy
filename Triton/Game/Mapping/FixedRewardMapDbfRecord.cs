namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FixedRewardMapDbfRecord")]
    public class FixedRewardMapDbfRecord : DbfRecord
    {
        public FixedRewardMapDbfRecord(IntPtr address) : this(address, "FixedRewardMapDbfRecord")
        {
        }

        public FixedRewardMapDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetActionId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetActionId", objArray1);
        }

        public void SetNoteDesc(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNoteDesc", objArray1);
        }

        public void SetRewardCount(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRewardCount", objArray1);
        }

        public void SetRewardId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRewardId", objArray1);
        }

        public void SetRewardTiming(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRewardTiming", objArray1);
        }

        public void SetSortOrder(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSortOrder", objArray1);
        }

        public void SetToastDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetToastDescription", objArray1);
        }

        public void SetToastName(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetToastName", objArray1);
        }

        public void SetUseQuestToast(bool v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetUseQuestToast", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public int ActionId
        {
            get
            {
                return base.method_11<int>("get_ActionId", Array.Empty<object>());
            }
        }

        public int m_ActionId
        {
            get
            {
                return base.method_2<int>("m_ActionId");
            }
        }

        public string m_NoteDesc
        {
            get
            {
                return base.method_4("m_NoteDesc");
            }
        }

        public int m_RewardCount
        {
            get
            {
                return base.method_2<int>("m_RewardCount");
            }
        }

        public int m_RewardId
        {
            get
            {
                return base.method_2<int>("m_RewardId");
            }
        }

        public string m_RewardTiming
        {
            get
            {
                return base.method_4("m_RewardTiming");
            }
        }

        public int m_SortOrder
        {
            get
            {
                return base.method_2<int>("m_SortOrder");
            }
        }

        public DbfLocValue m_ToastDescription
        {
            get
            {
                return base.method_3<DbfLocValue>("m_ToastDescription");
            }
        }

        public DbfLocValue m_ToastName
        {
            get
            {
                return base.method_3<DbfLocValue>("m_ToastName");
            }
        }

        public bool m_UseQuestToast
        {
            get
            {
                return base.method_2<bool>("m_UseQuestToast");
            }
        }

        public string NoteDesc
        {
            get
            {
                return base.method_13("get_NoteDesc", Array.Empty<object>());
            }
        }

        public int RewardCount
        {
            get
            {
                return base.method_11<int>("get_RewardCount", Array.Empty<object>());
            }
        }

        public int RewardId
        {
            get
            {
                return base.method_11<int>("get_RewardId", Array.Empty<object>());
            }
        }

        public string RewardTiming
        {
            get
            {
                return base.method_13("get_RewardTiming", Array.Empty<object>());
            }
        }

        public int SortOrder
        {
            get
            {
                return base.method_11<int>("get_SortOrder", Array.Empty<object>());
            }
        }

        public DbfLocValue ToastDescription
        {
            get
            {
                return base.method_14<DbfLocValue>("get_ToastDescription", Array.Empty<object>());
            }
        }

        public DbfLocValue ToastName
        {
            get
            {
                return base.method_14<DbfLocValue>("get_ToastName", Array.Empty<object>());
            }
        }

        public bool UseQuestToast
        {
            get
            {
                return base.method_11<bool>("get_UseQuestToast", Array.Empty<object>());
            }
        }
    }
}

