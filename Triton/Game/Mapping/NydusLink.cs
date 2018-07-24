namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("NydusLink")]
    public class NydusLink : MonoClass
    {
        public NydusLink(IntPtr address) : this(address, "NydusLink")
        {
        }

        public NydusLink(IntPtr address, string className) : base(address, className)
        {
        }

        public static string GetAccountCreationLink()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "NydusLink", "GetAccountCreationLink", Array.Empty<object>());
        }

        public static string GetBreakingNewsLink()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "NydusLink", "GetBreakingNewsLink", Array.Empty<object>());
        }

        public static string GetLink(string linkType, bool isMobile)
        {
            object[] objArray1 = new object[] { linkType, isMobile };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "NydusLink", "GetLink", objArray1);
        }

        public static string GetSupportLink(string linkType, bool isMobile)
        {
            object[] objArray1 = new object[] { linkType, isMobile };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "NydusLink", "GetSupportLink", objArray1);
        }

        public static string DevHost
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "NydusLink", "DevHost");
            }
        }

        public static string ProdHost
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "NydusLink", "ProdHost");
            }
        }
    }
}

