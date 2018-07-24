namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SubsetCardDbfRecord")]
    public class SubsetCardDbfRecord : DbfRecord
    {
        public SubsetCardDbfRecord(IntPtr address) : this(address, "SubsetCardDbfRecord")
        {
        }

        public SubsetCardDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetSubsetId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSubsetId", objArray1);
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

        public int m_CardId
        {
            get
            {
                return base.method_2<int>("m_CardId");
            }
        }

        public int m_SubsetId
        {
            get
            {
                return base.method_2<int>("m_SubsetId");
            }
        }

        public int SubsetId
        {
            get
            {
                return base.method_11<int>("get_SubsetId", Array.Empty<object>());
            }
        }
    }
}

