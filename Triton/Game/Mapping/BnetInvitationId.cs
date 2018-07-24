namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetInvitationId")]
    public class BnetInvitationId : MonoClass
    {
        public BnetInvitationId(IntPtr address) : this(address, "BnetInvitationId")
        {
        }

        public BnetInvitationId(IntPtr address, string className) : base(address, className)
        {
        }

        public bool Equals(object obj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { obj };
            return base.method_10<bool>("Equals", enumArray1, objArray1);
        }

        public bool Equals(BnetInvitationId other)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { other };
            return base.method_10<bool>("Equals", enumArray1, objArray1);
        }

        public int GetHashCode()
        {
            return base.method_11<int>("GetHashCode", Array.Empty<object>());
        }

        public ulong GetVal()
        {
            return base.method_11<ulong>("GetVal", Array.Empty<object>());
        }

        public static bool op_Equality(BnetInvitationId a, BnetInvitationId b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BnetInvitationId", "op_Equality", objArray1);
        }

        public static bool op_Inequality(BnetInvitationId a, BnetInvitationId b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BnetInvitationId", "op_Inequality", objArray1);
        }

        public void SetVal(ulong val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetVal", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public ulong m_val
        {
            get
            {
                return base.method_2<ulong>("m_val");
            }
        }
    }
}

