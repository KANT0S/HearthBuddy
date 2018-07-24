namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("TagDelta")]
    public class TagDelta : MonoClass
    {
        public TagDelta(IntPtr address) : this(address, "TagDelta")
        {
        }

        public TagDelta(IntPtr address, string className) : base(address, className)
        {
        }

        public int newValue
        {
            get
            {
                return base.method_2<int>("newValue");
            }
        }

        public int oldValue
        {
            get
            {
                return base.method_2<int>("oldValue");
            }
        }

        public int tag
        {
            get
            {
                return base.method_2<int>("tag");
            }
        }
    }
}

