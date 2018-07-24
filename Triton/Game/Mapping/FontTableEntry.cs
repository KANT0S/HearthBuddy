namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FontTableEntry")]
    public class FontTableEntry : MonoClass
    {
        public FontTableEntry(IntPtr address) : this(address, "FontTableEntry")
        {
        }

        public FontTableEntry(IntPtr address, string className) : base(address, className)
        {
        }

        public string m_FontDefName
        {
            get
            {
                return base.method_4("m_FontDefName");
            }
        }

        public string m_FontName
        {
            get
            {
                return base.method_4("m_FontName");
            }
        }
    }
}

