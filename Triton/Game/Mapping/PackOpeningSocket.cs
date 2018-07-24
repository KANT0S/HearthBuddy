namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PackOpeningSocket")]
    public class PackOpeningSocket : PegUIElement
    {
        public PackOpeningSocket(IntPtr address) : this(address, "PackOpeningSocket")
        {
        }

        public PackOpeningSocket(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnPackHeld()
        {
            base.method_8("OnPackHeld", Array.Empty<object>());
        }

        public void OnPackReleased()
        {
            base.method_8("OnPackReleased", Array.Empty<object>());
        }

        public Spell m_alertSpell
        {
            get
            {
                return base.method_3<Spell>("m_alertSpell");
            }
        }
    }
}

