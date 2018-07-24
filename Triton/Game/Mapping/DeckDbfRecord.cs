namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckDbfRecord")]
    public class DeckDbfRecord : DbfRecord
    {
        public DeckDbfRecord(IntPtr address) : this(address, "DeckDbfRecord")
        {
        }

        public DeckDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDescription", objArray1);
        }

        public void SetName(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetName", objArray1);
        }

        public void SetNoteName(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNoteName", objArray1);
        }

        public void SetTopCardId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetTopCardId", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public DbfLocValue Description
        {
            get
            {
                return base.method_14<DbfLocValue>("get_Description", Array.Empty<object>());
            }
        }

        public DbfLocValue m_Description
        {
            get
            {
                return base.method_3<DbfLocValue>("m_Description");
            }
        }

        public DbfLocValue m_Name
        {
            get
            {
                return base.method_3<DbfLocValue>("m_Name");
            }
        }

        public string m_NoteName
        {
            get
            {
                return base.method_4("m_NoteName");
            }
        }

        public int m_TopCardId
        {
            get
            {
                return base.method_2<int>("m_TopCardId");
            }
        }

        public DbfLocValue Name
        {
            get
            {
                return base.method_14<DbfLocValue>("get_Name", Array.Empty<object>());
            }
        }

        public string NoteName
        {
            get
            {
                return base.method_13("get_NoteName", Array.Empty<object>());
            }
        }

        public int TopCardId
        {
            get
            {
                return base.method_11<int>("get_TopCardId", Array.Empty<object>());
            }
        }
    }
}

