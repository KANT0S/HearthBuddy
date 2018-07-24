namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DLLUtils")]
    public class DLLUtils : MonoClass
    {
        public DLLUtils(IntPtr address) : this(address, "DLLUtils")
        {
        }

        public DLLUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool FreeLibrary(IntPtr module)
        {
            object[] objArray1 = new object[] { module };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "DLLUtils", "FreeLibrary", objArray1);
        }

        public static IntPtr GetProcAddress(IntPtr module, string funcName)
        {
            object[] objArray1 = new object[] { module, funcName };
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "DLLUtils", "GetProcAddress", objArray1);
        }

        public static IntPtr LoadLibrary(string filename)
        {
            object[] objArray1 = new object[] { filename };
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "DLLUtils", "LoadLibrary", objArray1);
        }
    }
}

