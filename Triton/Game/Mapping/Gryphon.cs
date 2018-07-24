namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Gryphon")]
    public class Gryphon : MonoBehaviour
    {
        public Gryphon(IntPtr address) : this(address, "Gryphon")
        {
        }

        public Gryphon(IntPtr address, string className) : base(address, className)
        {
        }

        public void AniamteHead()
        {
            base.method_8("AniamteHead", Array.Empty<object>());
        }

        public void FindEndTurnButton()
        {
            base.method_8("FindEndTurnButton", Array.Empty<object>());
        }

        public void FindSomethingToLookAt()
        {
            base.method_8("FindSomethingToLookAt", Array.Empty<object>());
        }

        public void LateUpdate()
        {
            base.method_8("LateUpdate", Array.Empty<object>());
        }

        public bool LookAtTurnButton()
        {
            return base.method_11<bool>("LookAtTurnButton", Array.Empty<object>());
        }

        public void PlayAniamtion()
        {
            base.method_8("PlayAniamtion", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public static int cleanState
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Gryphon", "cleanState");
            }
        }

        public static int lookState
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Gryphon", "lookState");
            }
        }

        public EndTurnButton m_EndTurnButton
        {
            get
            {
                return base.method_3<EndTurnButton>("m_EndTurnButton");
            }
        }

        public Transform m_EndTurnButtonTransform
        {
            get
            {
                return base.method_3<Transform>("m_EndTurnButtonTransform");
            }
        }

        public Transform m_HeadBone
        {
            get
            {
                return base.method_3<Transform>("m_HeadBone");
            }
        }

        public float m_HeadRotationSpeed
        {
            get
            {
                return base.method_2<float>("m_HeadRotationSpeed");
            }
        }

        public float m_idleEndTime
        {
            get
            {
                return base.method_2<float>("m_idleEndTime");
            }
        }

        public float m_lastScreech
        {
            get
            {
                return base.method_2<float>("m_lastScreech");
            }
        }

        public int m_LookAtHeroesPercent
        {
            get
            {
                return base.method_2<int>("m_LookAtHeroesPercent");
            }
        }

        public Vector3 m_LookAtPosition
        {
            get
            {
                return base.method_2<Vector3>("m_LookAtPosition");
            }
        }

        public int m_LookAtTurnButtonPercent
        {
            get
            {
                return base.method_2<int>("m_LookAtTurnButtonPercent");
            }
        }

        public float m_MaxFocusTime
        {
            get
            {
                return base.method_2<float>("m_MaxFocusTime");
            }
        }

        public float m_MinFocusTime
        {
            get
            {
                return base.method_2<float>("m_MinFocusTime");
            }
        }

        public int m_PlayAnimationPercent
        {
            get
            {
                return base.method_2<int>("m_PlayAnimationPercent");
            }
        }

        public float m_RandomWeightsTotal
        {
            get
            {
                return base.method_2<float>("m_RandomWeightsTotal");
            }
        }

        public GameObject m_SnapCollider
        {
            get
            {
                return base.method_3<GameObject>("m_SnapCollider");
            }
        }

        public float m_SnapWaitTime
        {
            get
            {
                return base.method_2<float>("m_SnapWaitTime");
            }
        }

        public float m_TurnButtonLookAwayTime
        {
            get
            {
                return base.method_2<float>("m_TurnButtonLookAwayTime");
            }
        }

        public UniversalInputManager m_UniversalInputManager
        {
            get
            {
                return base.method_3<UniversalInputManager>("m_UniversalInputManager");
            }
        }

        public float m_WaitStartTime
        {
            get
            {
                return base.method_2<float>("m_WaitStartTime");
            }
        }

        public static int screechState
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Gryphon", "screechState");
            }
        }
    }
}

