namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ActorPool")]
    public class ActorPool : MonoClass
    {
        public ActorPool(IntPtr address) : this(address, "ActorPool")
        {
        }

        public ActorPool(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

