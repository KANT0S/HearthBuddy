namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Vars")]
    public class Vars : MonoClass
    {
        public Vars(IntPtr address) : this(address, "Vars")
        {
        }

        public Vars(IntPtr address, string className) : base(address, className)
        {
        }

        public static string GetClientConfigPath()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Vars", "GetClientConfigPath", Array.Empty<object>());
        }

        public static VarKey Key(string key)
        {
            object[] objArray1 = new object[] { key };
            return MonoClass.smethod_15<VarKey>(TritonHs.MainAssemblyPath, "", "Vars", "Key", objArray1);
        }

        public static void RefreshVars()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Vars", "RefreshVars");
        }

        public static string CONFIG_FILE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Vars", "CONFIG_FILE_NAME");
            }
        }
    }
}

