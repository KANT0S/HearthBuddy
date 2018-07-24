namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using System.Xml;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DbfXml")]
    public class DbfXml : MonoClass
    {
        public DbfXml(IntPtr address) : this(address, "DbfXml")
        {
        }

        public DbfXml(IntPtr address, string className) : base(address, className)
        {
        }

        public static DbfLocValue LoadLocalizedString(string locIdStr, XmlReader reader, bool hideDebugInfo)
        {
            object[] objArray1 = new object[] { locIdStr, reader, hideDebugInfo };
            return MonoClass.smethod_15<DbfLocValue>(TritonHs.MainAssemblyPath, "", "DbfXml", "LoadLocalizedString", objArray1);
        }
    }
}

