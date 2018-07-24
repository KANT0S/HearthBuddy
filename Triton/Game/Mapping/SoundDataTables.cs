namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SoundDataTables")]
    public class SoundDataTables : MonoClass
    {
        public SoundDataTables(IntPtr address) : this(address, "SoundDataTables")
        {
        }

        public SoundDataTables(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

