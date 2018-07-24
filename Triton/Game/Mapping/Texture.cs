namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Texture")]
    public class Texture : Renderer
    {
        public Texture(IntPtr address) : base(address, "Texture")
        {
        }
    }
}

