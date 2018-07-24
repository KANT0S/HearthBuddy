namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("EndTurnButton")]
    public class EndTurnButton : MonoBehaviour
    {
        public EndTurnButton(IntPtr address) : this(address, "EndTurnButton")
        {
        }

        public EndTurnButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static EndTurnButton Get()
        {
            return MonoClass.smethod_15<EndTurnButton>(TritonHs.MainAssemblyPath, "", "EndTurnButton", "Get", Array.Empty<object>());
        }

        public GameObject GetButtonContainer()
        {
            return base.method_14<GameObject>("GetButtonContainer", Array.Empty<object>());
        }

        public void HandleGameStart()
        {
            base.method_8("HandleGameStart", Array.Empty<object>());
        }

        public void HandleMouseOut()
        {
            base.method_8("HandleMouseOut", Array.Empty<object>());
        }

        public void HandleMouseOver()
        {
            base.method_8("HandleMouseOver", Array.Empty<object>());
        }

        public bool HasNoMorePlays()
        {
            return base.method_11<bool>("HasNoMorePlays", Array.Empty<object>());
        }

        public bool IsInNMPState()
        {
            return base.method_11<bool>("IsInNMPState", Array.Empty<object>());
        }

        public bool IsInputBlocked()
        {
            return base.method_11<bool>("IsInputBlocked", Array.Empty<object>());
        }

        public bool IsInWaitingState()
        {
            return base.method_11<bool>("IsInWaitingState", Array.Empty<object>());
        }

        public bool IsInYouHavePlaysState()
        {
            return base.method_11<bool>("IsInYouHavePlaysState", Array.Empty<object>());
        }

        public void OnCreateGame(GameState.CreateGamePhase phase, object userData)
        {
            object[] objArray1 = new object[] { phase, userData };
            base.method_8("OnCreateGame", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnEndTurnRequested()
        {
            base.method_8("OnEndTurnRequested", Array.Empty<object>());
        }

        public void OnMulliganEnded()
        {
            base.method_8("OnMulliganEnded", Array.Empty<object>());
        }

        public void OnOptionsReceived(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnOptionsReceived", objArray1);
        }

        public void OnTurnStartManagerFinished()
        {
            base.method_8("OnTurnStartManagerFinished", Array.Empty<object>());
        }

        public void OnTurnTimerEnded(bool isFriendlyPlayerTurnTimer)
        {
            object[] objArray1 = new object[] { isFriendlyPlayerTurnTimer };
            base.method_8("OnTurnTimerEnded", objArray1);
        }

        public void OnTurnTimerStart()
        {
            base.method_8("OnTurnTimerStart", Array.Empty<object>());
        }

        public void OnUpdateIntensityValue(float newValue)
        {
            object[] objArray1 = new object[] { newValue };
            base.method_8("OnUpdateIntensityValue", objArray1);
        }

        public void PlayButtonUpAnimation()
        {
            base.method_8("PlayButtonUpAnimation", Array.Empty<object>());
        }

        public void PlayPushDownAnimation()
        {
            base.method_8("PlayPushDownAnimation", Array.Empty<object>());
        }

        public void PutInMouseOffState()
        {
            base.method_8("PutInMouseOffState", Array.Empty<object>());
        }

        public void PutInMouseOverState()
        {
            base.method_8("PutInMouseOverState", Array.Empty<object>());
        }

        public void SetButtonState(ActorStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("SetButtonState", objArray1);
        }

        public void SetStateToNoMorePlays()
        {
            base.method_8("SetStateToNoMorePlays", Array.Empty<object>());
        }

        public void SetStateToWaiting()
        {
            base.method_8("SetStateToWaiting", Array.Empty<object>());
        }

        public void SetStateToYourTurn()
        {
            base.method_8("SetStateToYourTurn", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateState()
        {
            base.method_8("UpdateState", Array.Empty<object>());
        }

        public ActorStateMgr m_ActorStateMgr
        {
            get
            {
                return base.method_3<ActorStateMgr>("m_ActorStateMgr");
            }
        }

        public GameObject m_EndTurnButtonMesh
        {
            get
            {
                return base.method_3<GameObject>("m_EndTurnButtonMesh");
            }
        }

        public GameObject m_GreenHighlight
        {
            get
            {
                return base.method_3<GameObject>("m_GreenHighlight");
            }
        }

        public bool m_inputBlocked
        {
            get
            {
                return base.method_2<bool>("m_inputBlocked");
            }
        }

        public bool m_mousedOver
        {
            get
            {
                return base.method_2<bool>("m_mousedOver");
            }
        }

        public UberText m_MyTurnText
        {
            get
            {
                return base.method_3<UberText>("m_MyTurnText");
            }
        }

        public bool m_playedNmpSoundThisTurn
        {
            get
            {
                return base.method_2<bool>("m_playedNmpSoundThisTurn");
            }
        }

        public bool m_pressed
        {
            get
            {
                return base.method_2<bool>("m_pressed");
            }
        }

        public UberText m_WaitingText
        {
            get
            {
                return base.method_3<UberText>("m_WaitingText");
            }
        }

        public GameObject m_WhiteHighlight
        {
            get
            {
                return base.method_3<GameObject>("m_WhiteHighlight");
            }
        }
    }
}

