namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("SpellImpactInfo")]
    public class SpellImpactInfo : MonoClass
    {
        public SpellImpactInfo(IntPtr address) : this(address, "SpellImpactInfo")
        {
        }

        public SpellImpactInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public List<SpellImpactPrefabs> m_DamageAmountImpacts
        {
            get
            {
                Class247<SpellImpactPrefabs> class2 = base.method_3<Class247<SpellImpactPrefabs>>("m_DamageAmountImpacts");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_Enabled
        {
            get
            {
                return base.method_2<bool>("m_Enabled");
            }
        }

        public float m_GameDelaySecMax
        {
            get
            {
                return base.method_2<float>("m_GameDelaySecMax");
            }
        }

        public float m_GameDelaySecMin
        {
            get
            {
                return base.method_2<float>("m_GameDelaySecMin");
            }
        }

        public SpellLocation m_Location
        {
            get
            {
                return base.method_2<SpellLocation>("m_Location");
            }
        }

        public Spell m_Prefab
        {
            get
            {
                return base.method_3<Spell>("m_Prefab");
            }
        }

        public bool m_SetParentToLocation
        {
            get
            {
                return base.method_2<bool>("m_SetParentToLocation");
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

