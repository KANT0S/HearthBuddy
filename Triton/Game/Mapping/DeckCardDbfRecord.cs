namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckCardDbfRecord")]
    public class DeckCardDbfRecord : DbfRecord
    {
        public DeckCardDbfRecord(IntPtr address) : this(address, "DeckCardDbfRecord")
        {
        }

        public DeckCardDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetCardId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetCardId", objArray1);
        }

        public void SetDeckId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDeckId", objArray1);
        }

        public void SetDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDescription", objArray1);
        }

        public void SetNextCard(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNextCard", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public int CardId
        {
            get
            {
                return base.method_11<int>("get_CardId", Array.Empty<object>());
            }
        }

        public int DeckId
        {
            get
            {
                return base.method_11<int>("get_DeckId", Array.Empty<object>());
            }
        }

        public DbfLocValue Description
        {
            get
            {
                return base.method_14<DbfLocValue>("get_Description", Array.Empty<object>());
            }
        }

        public int m_CardId
        {
            get
            {
                return base.method_2<int>("m_CardId");
            }
        }

        public int m_DeckId
        {
            get
            {
                return base.method_2<int>("m_DeckId");
            }
        }

        public DbfLocValue m_Description
        {
            get
            {
                return base.method_3<DbfLocValue>("m_Description");
            }
        }

        public int m_NextCard
        {
            get
            {
                return base.method_2<int>("m_NextCard");
            }
        }

        public int NextCard
        {
            get
            {
                return base.method_11<int>("get_NextCard", Array.Empty<object>());
            }
        }
    }
}

