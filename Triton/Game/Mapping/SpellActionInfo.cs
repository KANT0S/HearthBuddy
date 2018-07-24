namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellActionInfo")]
    public class SpellActionInfo : MonoClass
    {
        public SpellActionInfo(IntPtr address) : this(address, "SpellActionInfo")
        {
        }

        public SpellActionInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public SpellVisualShowTime m_ShowSpellVisuals
        {
            get
            {
                return base.method_2<SpellVisualShowTime>("m_ShowSpellVisuals");
            }
        }

        public float m_StartDelayMax
        {
            get
            {
                return base.method_2<float>("m_StartDelayMax");
            }
        }

        public float m_StartDelayMin
        {
            get
            {
                return base.method_2<float>("m_StartDelayMin");
            }
        }
    }
}

