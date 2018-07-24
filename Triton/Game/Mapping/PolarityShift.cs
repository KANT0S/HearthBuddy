namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("PolarityShift")]
    public class PolarityShift : SuperSpell
    {
        public PolarityShift(IntPtr address) : this(address, "PolarityShift")
        {
        }

        public PolarityShift(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void ShakeCamera()
        {
            base.method_8("ShakeCamera", Array.Empty<object>());
        }

        public float m_AnimTime
        {
            get
            {
                return base.method_2<float>("m_AnimTime");
            }
        }

        public float m_CleanupTime
        {
            get
            {
                return base.method_2<float>("m_CleanupTime");
            }
        }

        public float m_HeightCurveLength
        {
            get
            {
                return base.method_2<float>("m_HeightCurveLength");
            }
        }

        public ParticleEffects m_ParticleEffects
        {
            get
            {
                return base.method_3<ParticleEffects>("m_ParticleEffects");
            }
        }

        public float m_ParticleHeightOffset
        {
            get
            {
                return base.method_2<float>("m_ParticleHeightOffset");
            }
        }

        public float m_RotationDriftAmount
        {
            get
            {
                return base.method_2<float>("m_RotationDriftAmount");
            }
        }

        public float m_SpellFinishTime
        {
            get
            {
                return base.method_2<float>("m_SpellFinishTime");
            }
        }

        [Attribute38("PolarityShift.MinionData")]
        public class MinionData : MonoClass
        {
            public MinionData(IntPtr address) : this(address, "MinionData")
            {
            }

            public MinionData(IntPtr address, string className) : base(address, className)
            {
            }

            public GameObject gameObject
            {
                get
                {
                    return base.method_3<GameObject>("gameObject");
                }
            }

            public Vector3 orgLocPos
            {
                get
                {
                    return base.method_2<Vector3>("orgLocPos");
                }
            }

            public Quaternion orgLocRot
            {
                get
                {
                    return base.method_2<Quaternion>("orgLocRot");
                }
            }

            public Vector3 rotationDrift
            {
                get
                {
                    return base.method_2<Vector3>("rotationDrift");
                }
            }
        }
    }
}

