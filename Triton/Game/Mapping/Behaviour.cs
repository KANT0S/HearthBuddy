namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Behaviour")]
    public class Behaviour : Component
    {
        public Behaviour(IntPtr address) : base(address, "Behaviour")
        {
        }

        public Behaviour(IntPtr address, string className) : base(address, className)
        {
        }

        public bool Enabled
        {
            get
            {
                return base.method_11<bool>("get_enabled", Array.Empty<object>());
            }
        }
    }
}

