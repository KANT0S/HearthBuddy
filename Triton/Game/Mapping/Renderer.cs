namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Renderer")]
    public class Renderer : Component
    {
        public Renderer(IntPtr address) : base(address, "Renderer")
        {
        }

        public Renderer(IntPtr address, string className) : base(address, className)
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

