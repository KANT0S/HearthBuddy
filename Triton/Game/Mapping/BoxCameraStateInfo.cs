namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BoxCameraStateInfo")]
    public class BoxCameraStateInfo : MonoClass
    {
        public BoxCameraStateInfo(IntPtr address) : this(address, "BoxCameraStateInfo")
        {
        }

        public BoxCameraStateInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject m_ClosedBone
        {
            get
            {
                return base.method_3<GameObject>("m_ClosedBone");
            }
        }

        public float m_ClosedDelaySec
        {
            get
            {
                return base.method_2<float>("m_ClosedDelaySec");
            }
        }

        public GameObject m_ClosedMinAspectRatioBone
        {
            get
            {
                return base.method_3<GameObject>("m_ClosedMinAspectRatioBone");
            }
        }

        public iTween.EaseType m_ClosedMoveEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_ClosedMoveEaseType");
            }
        }

        public float m_ClosedMoveSec
        {
            get
            {
                return base.method_2<float>("m_ClosedMoveSec");
            }
        }

        public GameObject m_ClosedWithDrawerBone
        {
            get
            {
                return base.method_3<GameObject>("m_ClosedWithDrawerBone");
            }
        }

        public float m_ClosedWithDrawerDelaySec
        {
            get
            {
                return base.method_2<float>("m_ClosedWithDrawerDelaySec");
            }
        }

        public GameObject m_ClosedWithDrawerMinAspectRatioBone
        {
            get
            {
                return base.method_3<GameObject>("m_ClosedWithDrawerMinAspectRatioBone");
            }
        }

        public iTween.EaseType m_ClosedWithDrawerMoveEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_ClosedWithDrawerMoveEaseType");
            }
        }

        public float m_ClosedWithDrawerMoveSec
        {
            get
            {
                return base.method_2<float>("m_ClosedWithDrawerMoveSec");
            }
        }

        public GameObject m_OpenedBone
        {
            get
            {
                return base.method_3<GameObject>("m_OpenedBone");
            }
        }

        public float m_OpenedDelaySec
        {
            get
            {
                return base.method_2<float>("m_OpenedDelaySec");
            }
        }

        public GameObject m_OpenedMinAspectRatioBone
        {
            get
            {
                return base.method_3<GameObject>("m_OpenedMinAspectRatioBone");
            }
        }

        public iTween.EaseType m_OpenedMoveEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_OpenedMoveEaseType");
            }
        }

        public float m_OpenedMoveSec
        {
            get
            {
                return base.method_2<float>("m_OpenedMoveSec");
            }
        }
    }
}

