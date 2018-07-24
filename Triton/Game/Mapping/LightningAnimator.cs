namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("LightningAnimator")]
    public class LightningAnimator : MonoBehaviour
    {
        public LightningAnimator(IntPtr address) : this(address, "LightningAnimator")
        {
        }

        public LightningAnimator(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void RandomJointRotation()
        {
            base.method_8("RandomJointRotation", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartAnimation()
        {
            base.method_8("StartAnimation", Array.Empty<object>());
        }

        public List<int> m_FrameList
        {
            get
            {
                Class266<int> class2 = base.method_3<Class266<int>>("m_FrameList");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_FrameTime
        {
            get
            {
                return base.method_2<float>("m_FrameTime");
            }
        }

        public Material m_material
        {
            get
            {
                return base.method_3<Material>("m_material");
            }
        }

        public string m_MatFrameProperty
        {
            get
            {
                return base.method_4("m_MatFrameProperty");
            }
        }

        public float m_matGlowIntensity
        {
            get
            {
                return base.method_2<float>("m_matGlowIntensity");
            }
        }

        public bool m_SetAlphaToZeroOnStart
        {
            get
            {
                return base.method_2<bool>("m_SetAlphaToZeroOnStart");
            }
        }

        public Transform m_SourceJount
        {
            get
            {
                return base.method_3<Transform>("m_SourceJount");
            }
        }

        public Vector3 m_SourceMaxRotation
        {
            get
            {
                return base.method_2<Vector3>("m_SourceMaxRotation");
            }
        }

        public Vector3 m_SourceMinRotation
        {
            get
            {
                return base.method_2<Vector3>("m_SourceMinRotation");
            }
        }

        public float m_StartDelayMax
        {
            get
            {
                return base.method_2<float>("m_StartDelayMax");
            }
        }

        public float m_StartDelayMin
        {
            get
            {
                return base.method_2<float>("m_StartDelayMin");
            }
        }

        public bool m_StartOnEnable
        {
            get
            {
                return base.method_2<bool>("m_StartOnEnable");
            }
        }

        public Transform m_TargetJoint
        {
            get
            {
                return base.method_3<Transform>("m_TargetJoint");
            }
        }

        public Vector3 m_TargetMaxRotation
        {
            get
            {
                return base.method_2<Vector3>("m_TargetMaxRotation");
            }
        }

        public Vector3 m_TargetMinRotation
        {
            get
            {
                return base.method_2<Vector3>("m_TargetMinRotation");
            }
        }
    }
}

