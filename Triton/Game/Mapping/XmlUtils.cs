namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("XmlUtils")]
    public class XmlUtils : MonoClass
    {
        public XmlUtils(IntPtr address) : this(address, "XmlUtils")
        {
        }

        public XmlUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static string EscapeXPathSearchString(string search)
        {
            object[] objArray1 = new object[] { search };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "XmlUtils", "EscapeXPathSearchString", objArray1);
        }
    }
}

