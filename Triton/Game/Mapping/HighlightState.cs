namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("HighlightState")]
    public class HighlightState : MonoBehaviour
    {
        public HighlightState(IntPtr address) : this(address, "HighlightState")
        {
        }

        public HighlightState(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool ChangeState(ActorStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            return base.method_11<bool>("ChangeState", objArray1);
        }

        public void ContinuousUpdate(float updateTime)
        {
            object[] objArray1 = new object[] { updateTime };
            base.method_8("ContinuousUpdate", objArray1);
        }

        public void ForceUpdate()
        {
            base.method_8("ForceUpdate", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public void LateUpdate()
        {
            base.method_8("LateUpdate", Array.Empty<object>());
        }

        public void OnActionFinished()
        {
            base.method_8("OnActionFinished", Array.Empty<object>());
        }

        public void OnApplicationFocus(bool state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("OnApplicationFocus", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool RenderSilouette()
        {
            return base.method_11<bool>("RenderSilouette", Array.Empty<object>());
        }

        public void SendDataToPlaymaker()
        {
            base.method_8("SendDataToPlaymaker", Array.Empty<object>());
        }

        public void SendPlaymakerBirthEvent()
        {
            base.method_8("SendPlaymakerBirthEvent", Array.Empty<object>());
        }

        public void SendPlaymakerDeathEvent()
        {
            base.method_8("SendPlaymakerDeathEvent", Array.Empty<object>());
        }

        public void SetDirty()
        {
            base.method_8("SetDirty", Array.Empty<object>());
        }

        public void Setup()
        {
            base.method_8("Setup", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateSilouette()
        {
            base.method_8("UpdateSilouette", Array.Empty<object>());
        }

        public static string FSM_BIRTH_STATE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "HighlightState", "FSM_BIRTH_STATE");
            }
        }

        public static string FSM_BIRTHTRANSITION_STATE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "HighlightState", "FSM_BIRTHTRANSITION_STATE");
            }
        }

        public static string FSM_DEATH_STATE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "HighlightState", "FSM_DEATH_STATE");
            }
        }

        public static string FSM_DEATHTRANSITION_STATE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "HighlightState", "FSM_DEATHTRANSITION_STATE");
            }
        }

        public static string FSM_IDLE_STATE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "HighlightState", "FSM_IDLE_STATE");
            }
        }

        public static string FSM_IDLETRANSITION_STATE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "HighlightState", "FSM_IDLETRANSITION_STATE");
            }
        }

        public string HIGHLIGHT_SHADER_NAME
        {
            get
            {
                return base.method_4("HIGHLIGHT_SHADER_NAME");
            }
        }

        public string m_BirthTransition
        {
            get
            {
                return base.method_4("m_BirthTransition");
            }
        }

        public ActorStateType m_CurrentState
        {
            get
            {
                return base.method_2<ActorStateType>("m_CurrentState");
            }
        }

        public string m_DeathTransition
        {
            get
            {
                return base.method_4("m_DeathTransition");
            }
        }

        public bool m_forceRerender
        {
            get
            {
                return base.method_2<bool>("m_forceRerender");
            }
        }

        public bool m_Hide
        {
            get
            {
                return base.method_2<bool>("m_Hide");
            }
        }

        public List<HighlightRenderState> m_HighlightStates
        {
            get
            {
                Class267<HighlightRenderState> class2 = base.method_3<Class267<HighlightRenderState>>("m_HighlightStates");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public HighlightStateType m_highlightType
        {
            get
            {
                return base.method_2<HighlightStateType>("m_highlightType");
            }
        }

        public Vector3 m_HistoryTranslation
        {
            get
            {
                return base.method_2<Vector3>("m_HistoryTranslation");
            }
        }

        public string m_IdleTransition
        {
            get
            {
                return base.method_4("m_IdleTransition");
            }
        }

        public bool m_isDirty
        {
            get
            {
                return base.method_2<bool>("m_isDirty");
            }
        }

        public Material m_Material
        {
            get
            {
                return base.method_3<Material>("m_Material");
            }
        }

        public ActorStateType m_PreviousState
        {
            get
            {
                return base.method_2<ActorStateType>("m_PreviousState");
            }
        }

        public GameObject m_RenderPlane
        {
            get
            {
                return base.method_3<GameObject>("m_RenderPlane");
            }
        }

        public int m_RenderQueue
        {
            get
            {
                return base.method_2<int>("m_RenderQueue");
            }
        }

        public string m_SecondBirthTransition
        {
            get
            {
                return base.method_4("m_SecondBirthTransition");
            }
        }

        public float m_seed
        {
            get
            {
                return base.method_2<float>("m_seed");
            }
        }

        public string m_sendEvent
        {
            get
            {
                return base.method_4("m_sendEvent");
            }
        }

        public bool m_VisibilityState
        {
            get
            {
                return base.method_2<bool>("m_VisibilityState");
            }
        }
    }
}

