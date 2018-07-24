namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellMissileInfo")]
    public class SpellMissileInfo : MonoClass
    {
        public SpellMissileInfo(IntPtr address) : this(address, "SpellMissileInfo")
        {
        }

        public SpellMissileInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_CenterOffsetPercent
        {
            get
            {
                return base.method_2<float>("m_CenterOffsetPercent");
            }
        }

        public float m_CenterPointHeightMax
        {
            get
            {
                return base.method_2<float>("m_CenterPointHeightMax");
            }
        }

        public float m_CenterPointHeightMin
        {
            get
            {
                return base.method_2<float>("m_CenterPointHeightMin");
            }
        }

        public bool m_DebugForceMax
        {
            get
            {
                return base.method_2<bool>("m_DebugForceMax");
            }
        }

        public float m_DistanceScaleFactor
        {
            get
            {
                return base.method_2<float>("m_DistanceScaleFactor");
            }
        }

        public bool m_Enabled
        {
            get
            {
                return base.method_2<bool>("m_Enabled");
            }
        }

        public Vector3 m_JointUpVector
        {
            get
            {
                return base.method_2<Vector3>("m_JointUpVector");
            }
        }

        public float m_LeftMax
        {
            get
            {
                return base.method_2<float>("m_LeftMax");
            }
        }

        public float m_LeftMin
        {
            get
            {
                return base.method_2<float>("m_LeftMin");
            }
        }

        public bool m_OrientToPath
        {
            get
            {
                return base.method_2<bool>("m_OrientToPath");
            }
        }

        public float m_PathDurationMax
        {
            get
            {
                return base.method_2<float>("m_PathDurationMax");
            }
        }

        public float m_PathDurationMin
        {
            get
            {
                return base.method_2<float>("m_PathDurationMin");
            }
        }

        public iTween.EaseType m_PathEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_PathEaseType");
            }
        }

        public Spell m_Prefab
        {
            get
            {
                return base.method_3<Spell>("m_Prefab");
            }
        }

        public float m_reverseDelay
        {
            get
            {
                return base.method_2<float>("m_reverseDelay");
            }
        }

        public Spell m_ReversePrefab
        {
            get
            {
                return base.method_3<Spell>("m_ReversePrefab");
            }
        }

        public float m_RightMax
        {
            get
            {
                return base.method_2<float>("m_RightMax");
            }
        }

        public float m_RightMin
        {
            get
            {
                return base.method_2<float>("m_RightMin");
            }
        }

        public bool m_SpawnInSequence
        {
            get
            {
                return base.method_2<bool>("m_SpawnInSequence");
            }
        }

        public float m_TargetHeightOffset
        {
            get
            {
                return base.method_2<float>("m_TargetHeightOffset");
            }
        }

        public string m_TargetJoint
        {
            get
            {
                return base.method_4("m_TargetJoint");
            }
        }

        public bool m_UseSuperSpellLocation
        {
            get
            {
                return base.method_2<bool>("m_UseSuperSpellLocation");
            }
        }
    }
}

