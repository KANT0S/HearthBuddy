namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ManaCrystalEventSpells")]
    public class ManaCrystalEventSpells : MonoClass
    {
        public ManaCrystalEventSpells(IntPtr address) : this(address, "ManaCrystalEventSpells")
        {
        }

        public ManaCrystalEventSpells(IntPtr address, string className) : base(address, className)
        {
        }

        public Spell m_proposeUsageSpell
        {
            get
            {
                return base.method_3<Spell>("m_proposeUsageSpell");
            }
        }
    }
}

