namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Version")]
    public class Version : MonoClass
    {
        public Version(IntPtr address) : this(address, "Version")
        {
        }

        public Version(IntPtr address, string className) : base(address, className)
        {
        }

        public static void createReport()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Version", "createReport");
        }

        public static void Reset()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Version", "Reset");
        }

        public static string androidTextureCompression
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Version", "androidTextureCompression");
            }
        }

        public static string bobNetAddress
        {
            get
            {
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Version", "get_bobNetAddress", Array.Empty<object>());
            }
        }

        public static string bobNetAddress_
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Version", "bobNetAddress_");
            }
        }

        public static int clientChangelist
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Version", "clientChangelist");
            }
        }

        public static int clientChangelist_
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Version", "clientChangelist_");
            }
        }

        public static string cosmeticVersion
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Version", "cosmeticVersion");
            }
        }

        public static string FullReport
        {
            get
            {
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Version", "get_FullReport", Array.Empty<object>());
            }
        }

        public static string report_
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Version", "report_");
            }
        }

        public static string serverChangelist
        {
            get
            {
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Version", "get_serverChangelist", Array.Empty<object>());
            }
        }

        public static string serverChangelist_
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Version", "serverChangelist_");
            }
        }

        public static int version
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Version", "version");
            }
        }
    }
}

