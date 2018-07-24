namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellAreaEffectInfo")]
    public class SpellAreaEffectInfo : MonoClass
    {
        public SpellAreaEffectInfo(IntPtr address) : this(address, "SpellAreaEffectInfo")
        {
        }

        public SpellAreaEffectInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public bool m_Enabled
        {
            get
            {
                return base.method_2<bool>("m_Enabled");
            }
        }

        public SpellFacing m_Facing
        {
            get
            {
                return base.method_2<SpellFacing>("m_Facing");
            }
        }

        public SpellFacingOptions m_FacingOptions
        {
            get
            {
                return base.method_3<SpellFacingOptions>("m_FacingOptions");
            }
        }

        public Spell m_Prefab
        {
            get
            {
                return base.method_3<Spell>("m_Prefab");
            }
        }

        public float m_SpawnDelaySecMax
        {
            get
            {
                return base.method_2<float>("m_SpawnDelaySecMax");
            }
        }

        public float m_SpawnDelaySecMin
        {
            get
            {
                return base.method_2<float>("m_SpawnDelaySecMin");
            }
        }

        public bool m_UseSuperSpellLocation
        {
            get
            {
                return base.method_2<bool>("m_UseSuperSpellLocation");
            }
        }
    }
}

