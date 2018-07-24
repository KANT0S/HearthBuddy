namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("ConsecrationEffect")]
    public class ConsecrationEffect : MonoBehaviour
    {
        public ConsecrationEffect(IntPtr address) : this(address, "ConsecrationEffect")
        {
        }

        public ConsecrationEffect(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Finished()
        {
            base.method_8("Finished", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartAnimation()
        {
            base.method_8("StartAnimation", Array.Empty<object>());
        }

        public float m_Bounceness
        {
            get
            {
                return base.method_2<float>("m_Bounceness");
            }
        }

        public GameObject m_EndImpact
        {
            get
            {
                return base.method_3<GameObject>("m_EndImpact");
            }
        }

        public float m_HoverTime
        {
            get
            {
                return base.method_2<float>("m_HoverTime");
            }
        }

        public List<GameObject> m_ImpactObjects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_ImpactObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_LiftHeightMax
        {
            get
            {
                return base.method_2<float>("m_LiftHeightMax");
            }
        }

        public float m_LiftHeightMin
        {
            get
            {
                return base.method_2<float>("m_LiftHeightMin");
            }
        }

        public float m_LiftRotMax
        {
            get
            {
                return base.method_2<float>("m_LiftRotMax");
            }
        }

        public float m_LiftRotMin
        {
            get
            {
                return base.method_2<float>("m_LiftRotMin");
            }
        }

        public float m_LiftTime
        {
            get
            {
                return base.method_2<float>("m_LiftTime");
            }
        }

        public float m_SlamTime
        {
            get
            {
                return base.method_2<float>("m_SlamTime");
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

        public GameObject m_StartImpact
        {
            get
            {
                return base.method_3<GameObject>("m_StartImpact");
            }
        }

        public SuperSpell m_SuperSpell
        {
            get
            {
                return base.method_3<SuperSpell>("m_SuperSpell");
            }
        }

        public float m_TotalTime
        {
            get
            {
                return base.method_2<float>("m_TotalTime");
            }
        }
    }
}

