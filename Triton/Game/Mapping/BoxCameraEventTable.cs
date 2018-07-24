namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BoxCameraEventTable")]
    public class BoxCameraEventTable : MonoClass
    {
        public BoxCameraEventTable(IntPtr address) : this(address, "BoxCameraEventTable")
        {
        }

        public BoxCameraEventTable(IntPtr address, string className) : base(address, className)
        {
        }

        public Spell m_BlurSpell
        {
            get
            {
                return base.method_3<Spell>("m_BlurSpell");
            }
        }

        public Spell m_FadeFromBlackSpell
        {
            get
            {
                return base.method_3<Spell>("m_FadeFromBlackSpell");
            }
        }
    }
}

