namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellStartInfo")]
    public class SpellStartInfo : MonoClass
    {
        public SpellStartInfo(IntPtr address) : this(address, "SpellStartInfo")
        {
        }

        public SpellStartInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public bool m_DeathAfterAllMissilesFire
        {
            get
            {
                return base.method_2<bool>("m_DeathAfterAllMissilesFire");
            }
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

        public bool m_UseSuperSpellLocation
        {
            get
            {
                return base.method_2<bool>("m_UseSuperSpellLocation");
            }
        }
    }
}

