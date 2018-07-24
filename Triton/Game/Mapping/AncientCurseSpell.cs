namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AncientCurseSpell")]
    public class AncientCurseSpell : SuperSpell
    {
        public AncientCurseSpell(IntPtr address) : this(address, "AncientCurseSpell")
        {
        }

        public AncientCurseSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void DoHeroDamage()
        {
            base.method_8("DoHeroDamage", Array.Empty<object>());
        }
    }
}

