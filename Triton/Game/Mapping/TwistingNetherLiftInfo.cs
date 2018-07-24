namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("TwistingNetherLiftInfo")]
    public class TwistingNetherLiftInfo : MonoClass
    {
        public TwistingNetherLiftInfo(IntPtr address) : this(address, "TwistingNetherLiftInfo")
        {
        }

        public TwistingNetherLiftInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_DelayMax
        {
            get
            {
                return base.method_2<float>("m_DelayMax");
            }
        }

        public float m_DelayMin
        {
            get
            {
                return base.method_2<float>("m_DelayMin");
            }
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

        public iTween.EaseType m_EaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_EaseType");
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

        public float m_RotationMax
        {
            get
            {
                return base.method_2<float>("m_RotationMax");
            }
        }

        public float m_RotationMin
        {
            get
            {
                return base.method_2<float>("m_RotationMin");
            }
        }

        public float m_RotDelayMax
        {
            get
            {
                return base.method_2<float>("m_RotDelayMax");
            }
        }

        public float m_RotDelayMin
        {
            get
            {
                return base.method_2<float>("m_RotDelayMin");
            }
        }

        public float m_RotDurationMax
        {
            get
            {
                return base.method_2<float>("m_RotDurationMax");
            }
        }

        public float m_RotDurationMin
        {
            get
            {
                return base.method_2<float>("m_RotDurationMin");
            }
        }
    }
}

