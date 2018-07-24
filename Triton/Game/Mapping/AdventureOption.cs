namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("AdventureOption")]
    public class AdventureOption : MonoClass
    {
        public AdventureOption(IntPtr address) : this(address, "AdventureOption")
        {
        }

        public AdventureOption(IntPtr address, string className) : base(address, className)
        {
        }

        public int AdventureID
        {
            get
            {
                return base.method_11<int>("get_AdventureID", Array.Empty<object>());
            }
        }

        public ulong Options
        {
            get
            {
                return base.method_11<ulong>("get_Options", Array.Empty<object>());
            }
        }
    }
}

