namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("PoisonSeeds")]
    public class PoisonSeeds : SuperSpell
    {
        public PoisonSeeds(IntPtr address) : this(address, "PoisonSeeds")
        {
        }

        public PoisonSeeds(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DeathEffect()
        {
            base.method_8("DeathEffect", Array.Empty<object>());
        }

        public Card GetTargetCardFromPowerTask(int index, PowerTask task)
        {
            object[] objArray1 = new object[] { index, task };
            return base.method_14<Card>("GetTargetCardFromPowerTask", objArray1);
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

        public Spell m_CustomDeathSpell
        {
            get
            {
                return base.method_3<Spell>("m_CustomDeathSpell");
            }
        }

        public Spell m_CustomSpawnSpell
        {
            get
            {
                return base.method_3<Spell>("m_CustomSpawnSpell");
            }
        }

        public float m_HeightCurveLength
        {
            get
            {
                return base.method_2<float>("m_HeightCurveLength");
            }
        }

        public float m_RotationDriftAmount
        {
            get
            {
                return base.method_2<float>("m_RotationDriftAmount");
            }
        }

        public float m_StartDeathSpellAdjustment
        {
            get
            {
                return base.method_2<float>("m_StartDeathSpellAdjustment");
            }
        }

        public SpellTargetType m_TargetType
        {
            get
            {
                return base.method_2<SpellTargetType>("m_TargetType");
            }
        }

        [Attribute38("PoisonSeeds.MinionData")]
        public class MinionData : MonoClass
        {
            public MinionData(IntPtr address) : this(address, "MinionData")
            {
            }

            public MinionData(IntPtr address, string className) : base(address, className)
            {
            }

            public Card card
            {
                get
                {
                    return base.method_3<Card>("card");
                }
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

        public enum SpellTargetType
        {
            None,
            Death,
            Create
        }
    }
}

