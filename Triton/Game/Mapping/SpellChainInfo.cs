namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellChainInfo")]
    public class SpellChainInfo : MonoClass
    {
        public SpellChainInfo(IntPtr address) : this(address, "SpellChainInfo")
        {
        }

        public SpellChainInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public bool m_Enabled
        {
            get
            {
                return base.method_2<bool>("m_Enabled");
            }
        }

        public Spell m_Prefab
        {
            get
            {
                return base.method_3<Spell>("m_Prefab");
            }
        }

        public float m_SpawnDelayMax
        {
            get
            {
                return base.method_2<float>("m_SpawnDelayMax");
            }
        }

        public float m_SpawnDelayMin
        {
            get
            {
                return base.method_2<float>("m_SpawnDelayMin");
            }
        }
    }
}

