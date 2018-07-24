namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AnimatedLeavingSoonSign")]
    public class AnimatedLeavingSoonSign : AnimatedLowPolyPack
    {
        public AnimatedLeavingSoonSign(IntPtr address) : this(address, "AnimatedLeavingSoonSign")
        {
        }

        public AnimatedLeavingSoonSign(IntPtr address, string className) : base(address, className)
        {
        }

        public UIBButton m_leavingSoonButton
        {
            get
            {
                return base.method_3<UIBButton>("m_leavingSoonButton");
            }
        }
    }
}

