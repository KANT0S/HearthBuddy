namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetBattleTag")]
    public class BnetBattleTag : MonoClass
    {
        public BnetBattleTag(IntPtr address) : this(address, "BnetBattleTag")
        {
        }

        public BnetBattleTag(IntPtr address, string className) : base(address, className)
        {
        }

        public BnetBattleTag Clone()
        {
            return base.method_14<BnetBattleTag>("Clone", Array.Empty<object>());
        }

        public static BnetBattleTag CreateFromString(string src)
        {
            object[] objArray1 = new object[] { src };
            return MonoClass.smethod_15<BnetBattleTag>(TritonHs.MainAssemblyPath, "", "BnetBattleTag", "CreateFromString", objArray1);
        }

        public bool Equals(object obj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { obj };
            return base.method_10<bool>("Equals", enumArray1, objArray1);
        }

        public bool Equals(BnetBattleTag other)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { other };
            return base.method_10<bool>("Equals", enumArray1, objArray1);
        }

        public int GetHashCode()
        {
            return base.method_11<int>("GetHashCode", Array.Empty<object>());
        }

        public string GetName()
        {
            return base.method_13("GetName", Array.Empty<object>());
        }

        public int GetNumber()
        {
            return base.method_11<int>("GetNumber", Array.Empty<object>());
        }

        public string GetString()
        {
            return base.method_13("GetString", Array.Empty<object>());
        }

        public static bool op_Equality(BnetBattleTag a, BnetBattleTag b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BnetBattleTag", "op_Equality", objArray1);
        }

        public static bool op_Inequality(BnetBattleTag a, BnetBattleTag b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BnetBattleTag", "op_Inequality", objArray1);
        }

        public void SetName(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("SetName", objArray1);
        }

        public void SetNumber(int number)
        {
            object[] objArray1 = new object[] { number };
            base.method_8("SetNumber", objArray1);
        }

        public bool SetString(string composite)
        {
            object[] objArray1 = new object[] { composite };
            return base.method_11<bool>("SetString", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public string m_name
        {
            get
            {
                return base.method_4("m_name");
            }
        }

        public int m_number
        {
            get
            {
                return base.method_2<int>("m_number");
            }
        }
    }
}

