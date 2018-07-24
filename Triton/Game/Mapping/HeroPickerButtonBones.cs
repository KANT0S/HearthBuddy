namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("HeroPickerButtonBones")]
    public class HeroPickerButtonBones : MonoClass
    {
        public HeroPickerButtonBones(IntPtr address) : this(address, "HeroPickerButtonBones")
        {
        }

        public HeroPickerButtonBones(IntPtr address, string className) : base(address, className)
        {
        }

        public Transform m_classLabelOneLine
        {
            get
            {
                return base.method_3<Transform>("m_classLabelOneLine");
            }
        }

        public Transform m_classLabelTwoLine
        {
            get
            {
                return base.method_3<Transform>("m_classLabelTwoLine");
            }
        }

        public Transform m_gradientOneLine
        {
            get
            {
                return base.method_3<Transform>("m_gradientOneLine");
            }
        }

        public Transform m_gradientTwoLine
        {
            get
            {
                return base.method_3<Transform>("m_gradientTwoLine");
            }
        }
    }
}

