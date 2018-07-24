namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BoxDoorStateInfo")]
    public class BoxDoorStateInfo : MonoClass
    {
        public BoxDoorStateInfo(IntPtr address) : this(address, "BoxDoorStateInfo")
        {
        }

        public BoxDoorStateInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_ClosedDelaySec
        {
            get
            {
                return base.method_2<float>("m_ClosedDelaySec");
            }
        }

        public iTween.EaseType m_ClosedRotateEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_ClosedRotateEaseType");
            }
        }

        public float m_ClosedRotateSec
        {
            get
            {
                return base.method_2<float>("m_ClosedRotateSec");
            }
        }

        public Vector3 m_ClosedRotation
        {
            get
            {
                return base.method_2<Vector3>("m_ClosedRotation");
            }
        }

        public float m_OpenedDelaySec
        {
            get
            {
                return base.method_2<float>("m_OpenedDelaySec");
            }
        }

        public iTween.EaseType m_OpenedRotateEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_OpenedRotateEaseType");
            }
        }

        public float m_OpenedRotateSec
        {
            get
            {
                return base.method_2<float>("m_OpenedRotateSec");
            }
        }

        public Vector3 m_OpenedRotation
        {
            get
            {
                return base.method_2<Vector3>("m_OpenedRotation");
            }
        }
    }
}

