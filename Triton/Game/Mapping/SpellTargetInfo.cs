namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellTargetInfo")]
    public class SpellTargetInfo : MonoClass
    {
        public SpellTargetInfo(IntPtr address) : this(address, "SpellTargetInfo")
        {
        }

        public SpellTargetInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public SpellTargetBehavior m_Behavior
        {
            get
            {
                return base.method_2<SpellTargetBehavior>("m_Behavior");
            }
        }

        public int m_RandomTargetCountMax
        {
            get
            {
                return base.method_2<int>("m_RandomTargetCountMax");
            }
        }

        public int m_RandomTargetCountMin
        {
            get
            {
                return base.method_2<int>("m_RandomTargetCountMin");
            }
        }
    }
}

