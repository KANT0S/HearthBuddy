namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BnetUtils")]
    public class BnetUtils : MonoClass
    {
        public BnetUtils(IntPtr address) : this(address, "BnetUtils")
        {
        }

        public BnetUtils(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

