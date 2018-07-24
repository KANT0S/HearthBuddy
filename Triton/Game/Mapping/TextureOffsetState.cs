namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("TextureOffsetState")]
    public class TextureOffsetState : MonoClass
    {
        public TextureOffsetState(IntPtr address) : this(address, "TextureOffsetState")
        {
        }

        public TextureOffsetState(IntPtr address, string className) : base(address, className)
        {
        }

        public Triton.Game.Mapping.Material Material
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Material>("Material");
            }
        }

        public string Name
        {
            get
            {
                return base.method_4("Name");
            }
        }

        public Vector2 Offset
        {
            get
            {
                return base.method_2<Vector2>("Offset");
            }
        }
    }
}

