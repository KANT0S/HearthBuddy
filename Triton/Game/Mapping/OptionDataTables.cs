namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("OptionDataTables")]
    public class OptionDataTables : MonoClass
    {
        public OptionDataTables(IntPtr address) : this(address, "OptionDataTables")
        {
        }

        public OptionDataTables(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

