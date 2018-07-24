namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Collider")]
    public class Collider : Component
    {
        public Collider(IntPtr address) : base(address, "Collider")
        {
        }

        public Collider(IntPtr address, string className) : base(address, className)
        {
        }

        public Triton.Game.Mapping.Bounds Bounds
        {
            get
            {
                return base.method_11<Triton.Game.Mapping.Bounds>("get_bounds", Array.Empty<object>());
            }
        }
    }
}

