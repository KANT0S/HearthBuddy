namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UnearthedRaptorSpell")]
    public class UnearthedRaptorSpell : SuperSpell
    {
        public UnearthedRaptorSpell(IntPtr address) : this(address, "UnearthedRaptorSpell")
        {
        }

        public UnearthedRaptorSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }
    }
}

