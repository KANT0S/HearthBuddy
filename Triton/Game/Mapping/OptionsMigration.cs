namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("OptionsMigration")]
    public class OptionsMigration : MonoClass
    {
        public OptionsMigration(IntPtr address) : this(address, "OptionsMigration")
        {
        }

        public OptionsMigration(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool UpgradeClientOptions()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "OptionsMigration", "UpgradeClientOptions", Array.Empty<object>());
        }

        public static bool UpgradeClientOptions_V2()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "OptionsMigration", "UpgradeClientOptions_V2", Array.Empty<object>());
        }

        public static bool UpgradeServerOptions()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "OptionsMigration", "UpgradeServerOptions", Array.Empty<object>());
        }

        public static bool UpgradeServerOptions_V2()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "OptionsMigration", "UpgradeServerOptions_V2", Array.Empty<object>());
        }

        public static bool UpgradeServerOptions_V3(int startingVersion)
        {
            object[] objArray1 = new object[] { startingVersion };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "OptionsMigration", "UpgradeServerOptions_V3", objArray1);
        }

        public static int LATEST_CLIENT_VERSION
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "OptionsMigration", "LATEST_CLIENT_VERSION");
            }
        }

        public static int LATEST_SERVER_VERSION
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "OptionsMigration", "LATEST_SERVER_VERSION");
            }
        }
    }
}

