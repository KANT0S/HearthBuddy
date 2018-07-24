namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("TransformProps")]
    public class TransformProps : MonoClass
    {
        public TransformProps(IntPtr address) : this(address, "TransformProps")
        {
        }

        public TransformProps(IntPtr address, string className) : base(address, className)
        {
        }

        public Vector3 position
        {
            get
            {
                return base.method_2<Vector3>("position");
            }
        }

        public Quaternion rotation
        {
            get
            {
                return base.method_2<Quaternion>("rotation");
            }
        }

        public Vector3 scale
        {
            get
            {
                return base.method_2<Vector3>("scale");
            }
        }
    }
}

