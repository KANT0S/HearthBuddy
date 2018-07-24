namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GVGLaserGun")]
    public class GVGLaserGun : MonoBehaviour
    {
        public GVGLaserGun(IntPtr address) : this(address, "GVGLaserGun")
        {
        }

        public GVGLaserGun(IntPtr address, string className) : base(address, className)
        {
        }

        public static int AngleDefSortComparison(AngleDef def1, AngleDef def2)
        {
            object[] objArray1 = new object[] { def1, def2 };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GVGLaserGun", "AngleDefSortComparison", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public AngleDef GetAngleDef()
        {
            return base.method_14<AngleDef>("GetAngleDef", Array.Empty<object>());
        }

        public void HandleLever()
        {
            base.method_8("HandleLever", Array.Empty<object>());
        }

        public void HandleRotation()
        {
            base.method_8("HandleRotation", Array.Empty<object>());
        }

        public bool IsOver(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("IsOver", objArray1);
        }

        public void OnImpactSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnImpactSpellFinished", objArray1);
        }

        public void OnPullLeverSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnPullLeverSpellFinished", objArray1);
        }

        public void PullLever()
        {
            base.method_8("PullLever", Array.Empty<object>());
        }

        public void RotateLeft()
        {
            base.method_8("RotateLeft", Array.Empty<object>());
        }

        public void RotateRight()
        {
            base.method_8("RotateRight", Array.Empty<object>());
        }

        public void SetAngle(float angle)
        {
            object[] objArray1 = new object[] { angle };
            base.method_8("SetAngle", objArray1);
        }

        public bool ShouldStartRotating()
        {
            return base.method_11<bool>("ShouldStartRotating", Array.Empty<object>());
        }

        public void StartRotating(int dir)
        {
            object[] objArray1 = new object[] { dir };
            base.method_8("StartRotating", objArray1);
        }

        public void StopRotating()
        {
            base.method_8("StopRotating", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float m_angle
        {
            get
            {
                return base.method_2<float>("m_angle");
            }
        }

        public List<AngleDef> m_AngleDefs
        {
            get
            {
                Class267<AngleDef> class2 = base.method_3<Class267<AngleDef>>("m_AngleDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_angleIndex
        {
            get
            {
                return base.method_2<int>("m_angleIndex");
            }
        }

        public bool m_DebugShowGunAngle
        {
            get
            {
                return base.method_2<bool>("m_DebugShowGunAngle");
            }
        }

        public GameObject m_GunLever
        {
            get
            {
                return base.method_3<GameObject>("m_GunLever");
            }
        }

        public GameObject m_GunRotator
        {
            get
            {
                return base.method_3<GameObject>("m_GunRotator");
            }
        }

        public bool m_leverEffectsActive
        {
            get
            {
                return base.method_2<bool>("m_leverEffectsActive");
            }
        }

        public int m_maxAngleIndex
        {
            get
            {
                return base.method_2<int>("m_maxAngleIndex");
            }
        }

        public int m_minAngleIndex
        {
            get
            {
                return base.method_2<int>("m_minAngleIndex");
            }
        }

        public Spell m_PullLeverSpell
        {
            get
            {
                return base.method_3<Spell>("m_PullLeverSpell");
            }
        }

        public int m_requestedRotationDir
        {
            get
            {
                return base.method_2<int>("m_requestedRotationDir");
            }
        }

        public GameObject m_RotateLeftButton
        {
            get
            {
                return base.method_3<GameObject>("m_RotateLeftButton");
            }
        }

        public GameObject m_RotateRightButton
        {
            get
            {
                return base.method_3<GameObject>("m_RotateRightButton");
            }
        }

        public int m_rotationDir
        {
            get
            {
                return base.method_2<int>("m_rotationDir");
            }
        }

        public float m_RotationSpeed
        {
            get
            {
                return base.method_2<float>("m_RotationSpeed");
            }
        }

        public List<int> m_sortedAngleDefIndexes
        {
            get
            {
                Class266<int> class2 = base.method_3<Class266<int>>("m_sortedAngleDefIndexes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Spell m_StartRotationSpell
        {
            get
            {
                return base.method_3<Spell>("m_StartRotationSpell");
            }
        }

        public Spell m_StopRotationSpell
        {
            get
            {
                return base.method_3<Spell>("m_StopRotationSpell");
            }
        }

        [Attribute38("GVGLaserGun.AngleDef")]
        public class AngleDef : MonoClass
        {
            public AngleDef(IntPtr address) : this(address, "AngleDef")
            {
            }

            public AngleDef(IntPtr address, string className) : base(address, className)
            {
            }

            public int CustomBehaviorListCompare(GVGLaserGun.AngleDef def1, GVGLaserGun.AngleDef def2)
            {
                object[] objArray1 = new object[] { def1, def2 };
                return base.method_11<int>("CustomBehaviorListCompare", objArray1);
            }

            public float m_Angle
            {
                get
                {
                    return base.method_2<float>("m_Angle");
                }
            }

            public bool m_Default
            {
                get
                {
                    return base.method_2<bool>("m_Default");
                }
            }

            public Spell m_ImpactSpell
            {
                get
                {
                    return base.method_3<Spell>("m_ImpactSpell");
                }
            }
        }
    }
}

