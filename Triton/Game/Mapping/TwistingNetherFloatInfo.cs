namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("TwistingNetherFloatInfo")]
    public class TwistingNetherFloatInfo : MonoClass
    {
        public TwistingNetherFloatInfo(IntPtr address) : this(address, "TwistingNetherFloatInfo")
        {
        }

        public TwistingNetherFloatInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_DurationMax
        {
            get
            {
                return base.method_2<float>("m_DurationMax");
            }
        }

        public float m_DurationMin
        {
            get
            {
                return base.method_2<float>("m_DurationMin");
            }
        }

        public Vector3 m_OffsetMax
        {
            get
            {
                return base.method_2<Vector3>("m_OffsetMax");
            }
        }

        public Vector3 m_OffsetMin
        {
            get
            {
                return base.method_2<Vector3>("m_OffsetMin");
            }
        }

        public Vector2 m_RotationXZMax
        {
            get
            {
                return base.method_2<Vector2>("m_RotationXZMax");
            }
        }

        public Vector2 m_RotationXZMin
        {
            get
            {
                return base.method_2<Vector2>("m_RotationXZMin");
            }
        }
    }
}

