namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MoveToTarget")]
    public class MoveToTarget : MonoBehaviour
    {
        public MoveToTarget(IntPtr address) : this(address, "MoveToTarget")
        {
        }

        public MoveToTarget(IntPtr address, string className) : base(address, className)
        {
        }

        public void MoveSpeed()
        {
            base.method_8("MoveSpeed", Array.Empty<object>());
        }

        public void MoveTime()
        {
            base.method_8("MoveTime", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartAnimation()
        {
            base.method_8("StartAnimation", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool m_Animate
        {
            get
            {
                return base.method_2<bool>("m_Animate");
            }
        }

        public bool m_AnimateOnStart
        {
            get
            {
                return base.method_2<bool>("m_AnimateOnStart");
            }
        }

        public bool m_isDone
        {
            get
            {
                return base.method_2<bool>("m_isDone");
            }
        }

        public Vector3 m_LastTargetPosition
        {
            get
            {
                return base.method_2<Vector3>("m_LastTargetPosition");
            }
        }

        public float m_LerpPosition
        {
            get
            {
                return base.method_2<float>("m_LerpPosition");
            }
        }

        public MoveType m_MoveType
        {
            get
            {
                return base.method_2<MoveType>("m_MoveType");
            }
        }

        public bool m_OrientToPath
        {
            get
            {
                return base.method_2<bool>("m_OrientToPath");
            }
        }

        public float m_SnapDistance
        {
            get
            {
                return base.method_2<float>("m_SnapDistance");
            }
        }

        public float m_Speed
        {
            get
            {
                return base.method_2<float>("m_Speed");
            }
        }

        public Transform m_StartPosition
        {
            get
            {
                return base.method_3<Transform>("m_StartPosition");
            }
        }

        public Transform m_TargetObject
        {
            get
            {
                return base.method_3<Transform>("m_TargetObject");
            }
        }

        public float m_Time
        {
            get
            {
                return base.method_2<float>("m_Time");
            }
        }

        public enum MoveType
        {
            MoveByTime,
            MoveBySpeed
        }
    }
}

