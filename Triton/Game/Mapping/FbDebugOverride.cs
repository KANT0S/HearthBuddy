namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FbDebugOverride")]
    public class FbDebugOverride : MonoClass
    {
        public FbDebugOverride(IntPtr address) : this(address, "FbDebugOverride")
        {
        }

        public FbDebugOverride(IntPtr address, string className) : base(address, className)
        {
        }

        public static void Error(string msg)
        {
            object[] objArray1 = new object[] { msg };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "FbDebugOverride", "Error", objArray1);
        }

        public static void Info(string msg)
        {
            object[] objArray1 = new object[] { msg };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "FbDebugOverride", "Info", objArray1);
        }

        public static void Log(string msg)
        {
            object[] objArray1 = new object[] { msg };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "FbDebugOverride", "Log", objArray1);
        }

        public static void Warn(string msg)
        {
            object[] objArray1 = new object[] { msg };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "FbDebugOverride", "Warn", objArray1);
        }

        public static bool allowLogging
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "FbDebugOverride", "allowLogging");
            }
        }
    }
}

