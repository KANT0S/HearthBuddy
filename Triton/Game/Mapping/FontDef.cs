namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FontDef")]
    public class FontDef : MonoBehaviour
    {
        public FontDef(IntPtr address) : this(address, "FontDef")
        {
        }

        public FontDef(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_CharacterSizeModifier
        {
            get
            {
                return base.method_2<float>("m_CharacterSizeModifier");
            }
        }

        public float m_FontSizeModifier
        {
            get
            {
                return base.method_2<float>("m_FontSizeModifier");
            }
        }

        public float m_LineSpaceModifier
        {
            get
            {
                return base.method_2<float>("m_LineSpaceModifier");
            }
        }

        public float m_OutlineModifier
        {
            get
            {
                return base.method_2<float>("m_OutlineModifier");
            }
        }

        public float m_SingleLineAdjustment
        {
            get
            {
                return base.method_2<float>("m_SingleLineAdjustment");
            }
        }
    }
}

