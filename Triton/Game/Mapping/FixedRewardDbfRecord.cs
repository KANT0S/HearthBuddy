namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FixedRewardDbfRecord")]
    public class FixedRewardDbfRecord : DbfRecord
    {
        public FixedRewardDbfRecord(IntPtr address) : this(address, "FixedRewardDbfRecord")
        {
        }

        public FixedRewardDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetCardBackId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetCardBackId", objArray1);
        }

        public void SetCardId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetCardId", objArray1);
        }

        public void SetCardPremium(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetCardPremium", objArray1);
        }

        public void SetMetaActionFlags(ulong v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetMetaActionFlags", objArray1);
        }

        public void SetMetaActionId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetMetaActionId", objArray1);
        }

        public void SetNoteDesc(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNoteDesc", objArray1);
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

        public int CardBackId
        {
            get
            {
                return base.method_11<int>("get_CardBackId", Array.Empty<object>());
            }
        }

        public int CardId
        {
            get
            {
                return base.method_11<int>("get_CardId", Array.Empty<object>());
            }
        }

        public int CardPremium
        {
            get
            {
                return base.method_11<int>("get_CardPremium", Array.Empty<object>());
            }
        }

        public int m_CardBackId
        {
            get
            {
                return base.method_2<int>("m_CardBackId");
            }
        }

        public int m_CardId
        {
            get
            {
                return base.method_2<int>("m_CardId");
            }
        }

        public int m_CardPremium
        {
            get
            {
                return base.method_2<int>("m_CardPremium");
            }
        }

        public ulong m_MetaActionFlags
        {
            get
            {
                return base.method_2<ulong>("m_MetaActionFlags");
            }
        }

        public int m_MetaActionId
        {
            get
            {
                return base.method_2<int>("m_MetaActionId");
            }
        }

        public string m_NoteDesc
        {
            get
            {
                return base.method_4("m_NoteDesc");
            }
        }

        public string m_Type
        {
            get
            {
                return base.method_4("m_Type");
            }
        }

        public ulong MetaActionFlags
        {
            get
            {
                return base.method_11<ulong>("get_MetaActionFlags", Array.Empty<object>());
            }
        }

        public int MetaActionId
        {
            get
            {
                return base.method_11<int>("get_MetaActionId", Array.Empty<object>());
            }
        }

        public string NoteDesc
        {
            get
            {
                return base.method_13("get_NoteDesc", Array.Empty<object>());
            }
        }

        public string Type
        {
            get
            {
                return base.method_13("get_Type", Array.Empty<object>());
            }
        }
    }
}

