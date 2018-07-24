namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellFacingOptions")]
    public class SpellFacingOptions : MonoClass
    {
        public SpellFacingOptions(IntPtr address) : this(address, "SpellFacingOptions")
        {
        }

        public SpellFacingOptions(IntPtr address, string className) : base(address, className)
        {
        }

        public bool m_RotateX
        {
            get
            {
                return base.method_2<bool>("m_RotateX");
            }
        }

        public bool m_RotateY
        {
            get
            {
                return base.method_2<bool>("m_RotateY");
            }
        }
    }
}

