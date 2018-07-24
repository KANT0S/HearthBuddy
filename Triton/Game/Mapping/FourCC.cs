namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FourCC")]
    public class FourCC : MonoClass
    {
        public FourCC(IntPtr address) : this(address, "FourCC")
        {
        }

        public FourCC(IntPtr address, string className) : base(address, className)
        {
        }

        public FourCC Clone()
        {
            return base.method_14<FourCC>("Clone", Array.Empty<object>());
        }

        public void CopyFrom(FourCC other)
        {
            object[] objArray1 = new object[] { other };
            base.method_8("CopyFrom", objArray1);
        }

        public bool Equals(object obj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { obj };
            return base.method_10<bool>("Equals", enumArray1, objArray1);
        }

        public bool Equals(FourCC other)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { other };
            return base.method_10<bool>("Equals", enumArray1, objArray1);
        }

        public int GetHashCode()
        {
            return base.method_11<int>("GetHashCode", Array.Empty<object>());
        }

        public string GetString()
        {
            return base.method_13("GetString", Array.Empty<object>());
        }

        public uint GetValue()
        {
            return base.method_11<uint>("GetValue", Array.Empty<object>());
        }

        public static bool op_Equality(uint val, FourCC fourCC)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.U4, Class272.Enum20.Class };
            object[] objArray1 = new object[] { val, fourCC };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "FourCC", "op_Equality", enumArray1, objArray1);
        }

        public static bool op_Equality(FourCC fourCC, uint val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.U4 };
            object[] objArray1 = new object[] { fourCC, val };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "FourCC", "op_Equality", enumArray1, objArray1);
        }

        public static bool op_Equality(FourCC a, FourCC b)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "FourCC", "op_Equality", enumArray1, objArray1);
        }

        public static FourCC op_Implicit(uint val)
        {
            object[] objArray1 = new object[] { val };
            return MonoClass.smethod_15<FourCC>(TritonHs.MainAssemblyPath, "", "FourCC", "op_Implicit", objArray1);
        }

        public static bool op_Inequality(uint val, FourCC fourCC)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.U4, Class272.Enum20.Class };
            object[] objArray1 = new object[] { val, fourCC };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "FourCC", "op_Inequality", enumArray1, objArray1);
        }

        public static bool op_Inequality(FourCC fourCC, uint val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.U4 };
            object[] objArray1 = new object[] { fourCC, val };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "FourCC", "op_Inequality", enumArray1, objArray1);
        }

        public static bool op_Inequality(FourCC a, FourCC b)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "FourCC", "op_Inequality", enumArray1, objArray1);
        }

        public void SetString(string str)
        {
            object[] objArray1 = new object[] { str };
            base.method_8("SetString", objArray1);
        }

        public void SetValue(uint val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetValue", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public uint m_value
        {
            get
            {
                return base.method_2<uint>("m_value");
            }
        }
    }
}

