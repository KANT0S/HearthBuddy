namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AmbushSpell")]
    public class AmbushSpell : OverrideCustomSpawnSpell
    {
        public AmbushSpell(IntPtr address) : this(address, "AmbushSpell")
        {
        }

        public AmbushSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }
    }
}

