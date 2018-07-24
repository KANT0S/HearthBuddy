namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("CustomDeckBones")]
    public class CustomDeckBones : MonoClass
    {
        public CustomDeckBones(IntPtr address) : this(address, "CustomDeckBones")
        {
        }

        public CustomDeckBones(IntPtr address, string className) : base(address, className)
        {
        }

        public Transform m_deckLabelOneLine
        {
            get
            {
                return base.method_3<Transform>("m_deckLabelOneLine");
            }
        }

        public Transform m_deckLabelTwoLine
        {
            get
            {
                return base.method_3<Transform>("m_deckLabelTwoLine");
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

