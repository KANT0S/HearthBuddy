namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("VarsInternal")]
    public class VarsInternal : MonoClass
    {
        public VarsInternal(IntPtr address) : this(address, "VarsInternal")
        {
        }

        public VarsInternal(IntPtr address, string className) : base(address, className)
        {
        }

        public bool Contains(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<bool>("Contains", objArray1);
        }

        public static VarsInternal Get()
        {
            return MonoClass.smethod_15<VarsInternal>(TritonHs.MainAssemblyPath, "", "VarsInternal", "Get", Array.Empty<object>());
        }

        public bool LoadConfig(string path)
        {
            object[] objArray1 = new object[] { path };
            return base.method_11<bool>("LoadConfig", objArray1);
        }

        public static void RefreshVars()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "VarsInternal", "RefreshVars");
        }

        public void Set(string key, string value)
        {
            object[] objArray1 = new object[] { key, value };
            base.method_8("Set", objArray1);
        }

        public string Value(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_13("Value", objArray1);
        }
    }
}

