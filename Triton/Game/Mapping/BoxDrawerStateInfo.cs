namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BoxDrawerStateInfo")]
    public class BoxDrawerStateInfo : MonoClass
    {
        public BoxDrawerStateInfo(IntPtr address) : this(address, "BoxDrawerStateInfo")
        {
        }

        public BoxDrawerStateInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject m_ClosedBone
        {
            get
            {
                return base.method_3<GameObject>("m_ClosedBone");
            }
        }

        public GameObject m_ClosedBoxOpenedBone
        {
            get
            {
                return base.method_3<GameObject>("m_ClosedBoxOpenedBone");
            }
        }

        public float m_ClosedBoxOpenedDelaySec
        {
            get
            {
                return base.method_2<float>("m_ClosedBoxOpenedDelaySec");
            }
        }

        public iTween.EaseType m_ClosedBoxOpenedMoveEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_ClosedBoxOpenedMoveEaseType");
            }
        }

        public float m_ClosedBoxOpenedMoveSec
        {
            get
            {
                return base.method_2<float>("m_ClosedBoxOpenedMoveSec");
            }
        }

        public float m_ClosedDelaySec
        {
            get
            {
                return base.method_2<float>("m_ClosedDelaySec");
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

