namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SecretBannerDef")]
    public class SecretBannerDef : MonoClass
    {
        public SecretBannerDef(IntPtr address) : this(address, "SecretBannerDef")
        {
        }

        public SecretBannerDef(IntPtr address, string className) : base(address, className)
        {
        }

        public SpellClassTag m_HeroClass
        {
            get
            {
                return base.method_2<SpellClassTag>("m_HeroClass");
            }
        }

        public Spell m_SpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_SpellPrefab");
            }
        }
    }
}

