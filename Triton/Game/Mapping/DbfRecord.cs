namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("DbfRecord")]
    public class DbfRecord : MonoClass
    {
        public DbfRecord(IntPtr address) : this(address, "DbfRecord")
        {
        }

        public DbfRecord(IntPtr address, string className) : base(address, className)
        {
        }

        public object GetVar(string varName)
        {
            object[] objArray1 = new object[] { varName };
            return base.method_14<object>("GetVar", objArray1);
        }

        public System.Type GetVarType(string varName)
        {
            object[] objArray1 = new object[] { varName };
            return base.method_14<System.Type>("GetVarType", objArray1);
        }

        public void SetID(int id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetID", objArray1);
        }

        public void SetVar(string varName, object value)
        {
            object[] objArray1 = new object[] { varName, value };
            base.method_8("SetVar", objArray1);
        }

        public int ID
        {
            get
            {
                return base.method_11<int>("get_ID", Array.Empty<object>());
            }
        }

        public int m_ID
        {
            get
            {
                return base.method_2<int>("m_ID");
            }
        }
    }
}

