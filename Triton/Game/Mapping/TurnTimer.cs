namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TurnTimer")]
    public class TurnTimer : MonoBehaviour
    {
        public TurnTimer(IntPtr address) : this(address, "TurnTimer")
        {
        }

        public TurnTimer(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ChangeSpellState(TurnTimerState timerState)
        {
            object[] objArray1 = new object[] { timerState };
            base.method_8("ChangeSpellState", objArray1);
        }

        public void ChangeState(TurnTimerState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("ChangeState", objArray1);
        }

        public void ChangeState_Countdown()
        {
            base.method_8("ChangeState_Countdown", Array.Empty<object>());
        }

        public void ChangeState_Kill()
        {
            base.method_8("ChangeState_Kill", Array.Empty<object>());
        }

        public void ChangeState_Start()
        {
            base.method_8("ChangeState_Start", Array.Empty<object>());
        }

        public void ChangeState_Timeout()
        {
            base.method_8("ChangeState_Timeout", Array.Empty<object>());
        }

        public void ChangeStateImpl(TurnTimerState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("ChangeStateImpl", objArray1);
        }

        public float ComputeCountdownProgress(float countdownRemainingSec)
        {
            object[] objArray1 = new object[] { countdownRemainingSec };
            return base.method_11<float>("ComputeCountdownProgress", objArray1);
        }

        public float ComputeCountdownRemainingSec()
        {
            return base.method_11<float>("ComputeCountdownRemainingSec", Array.Empty<object>());
        }

        public string GenerateMatValAnimName()
        {
            return base.method_13("GenerateMatValAnimName", Array.Empty<object>());
        }

        public string GenerateMoveAnimName()
        {
            return base.method_13("GenerateMoveAnimName", Array.Empty<object>());
        }

        public static TurnTimer Get()
        {
            return MonoClass.smethod_15<TurnTimer>(TritonHs.MainAssemblyPath, "", "TurnTimer", "Get", Array.Empty<object>());
        }

        public bool HasCountdownTimeout()
        {
            return base.method_11<bool>("HasCountdownTimeout", Array.Empty<object>());
        }

        public void OnCurrentPlayerChanged(Player player, object userData)
        {
            object[] objArray1 = new object[] { player, userData };
            base.method_8("OnCurrentPlayerChanged", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnEndTurnRequested()
        {
            base.method_8("OnEndTurnRequested", Array.Empty<object>());
        }

        public void OnGameOver(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnGameOver", objArray1);
        }

        public void OnSpellStateStarted(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnSpellStateStarted", objArray1);
        }

        public void OnTurnStartManagerFinished()
        {
            base.method_8("OnTurnStartManagerFinished", Array.Empty<object>());
        }

        public void OnTurnTimedOut()
        {
            base.method_8("OnTurnTimedOut", Array.Empty<object>());
        }

        public void OnTurnTimerUpdate(TurnTimerUpdate update, object userData)
        {
            object[] objArray1 = new object[] { update, userData };
            base.method_8("OnTurnTimerUpdate", objArray1);
        }

        public void OnUpdateFuseMatVal(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("OnUpdateFuseMatVal", objArray1);
        }

        public void RestartCountdownAnims(float countdownRemainingSec)
        {
            object[] objArray1 = new object[] { countdownRemainingSec };
            base.method_8("RestartCountdownAnims", objArray1);
        }

        public bool ShouldUpdateCountdownRemaining()
        {
            return base.method_11<bool>("ShouldUpdateCountdownRemaining", Array.Empty<object>());
        }

        public void StartCountdownAnims(float startingMatVal, float countdownRemainingSec)
        {
            object[] objArray1 = new object[] { startingMatVal, countdownRemainingSec };
            base.method_8("StartCountdownAnims", objArray1);
        }

        public void StopCountdownAnims()
        {
            base.method_8("StopCountdownAnims", Array.Empty<object>());
        }

        public TurnTimerState TranslateSpellStateToTimerState(SpellStateType spellState)
        {
            object[] objArray1 = new object[] { spellState };
            return base.method_11<TurnTimerState>("TranslateSpellStateToTimerState", objArray1);
        }

        public SpellStateType TranslateTimerStateToSpellState(TurnTimerState timerState)
        {
            object[] objArray1 = new object[] { timerState };
            return base.method_11<SpellStateType>("TranslateTimerStateToSpellState", objArray1);
        }

        public float UpdateCountdownAnims(float countdownRemainingSec)
        {
            object[] objArray1 = new object[] { countdownRemainingSec };
            return base.method_11<float>("UpdateCountdownAnims", objArray1);
        }

        public void UpdateCountdownTimeout()
        {
            base.method_8("UpdateCountdownTimeout", Array.Empty<object>());
        }

        public static float BIRTH_ANIMATION_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TurnTimer", "BIRTH_ANIMATION_TIME");
            }
        }

        public float m_countdownEndTimestamp
        {
            get
            {
                return base.method_2<float>("m_countdownEndTimestamp");
            }
        }

        public float m_countdownTimeoutSec
        {
            get
            {
                return base.method_2<float>("m_countdownTimeoutSec");
            }
        }

        public uint m_currentMatValAnimId
        {
            get
            {
                return base.method_2<uint>("m_currentMatValAnimId");
            }
        }

        public uint m_currentMoveAnimId
        {
            get
            {
                return base.method_2<uint>("m_currentMoveAnimId");
            }
        }

        public bool m_currentTimerBelongsToFriendlySidePlayer
        {
            get
            {
                return base.method_2<bool>("m_currentTimerBelongsToFriendlySidePlayer");
            }
        }

        public float m_DebugTimeout
        {
            get
            {
                return base.method_2<float>("m_DebugTimeout");
            }
        }

        public float m_DebugTimeoutStart
        {
            get
            {
                return base.method_2<float>("m_DebugTimeoutStart");
            }
        }

        public float m_FuseMatValFinish
        {
            get
            {
                return base.method_2<float>("m_FuseMatValFinish");
            }
        }

        public string m_FuseMatValName
        {
            get
            {
                return base.method_4("m_FuseMatValName");
            }
        }

        public float m_FuseMatValStart
        {
            get
            {
                return base.method_2<float>("m_FuseMatValStart");
            }
        }

        public GameObject m_FuseShadowObject
        {
            get
            {
                return base.method_3<GameObject>("m_FuseShadowObject");
            }
        }

        public GameObject m_FuseWickObject
        {
            get
            {
                return base.method_3<GameObject>("m_FuseWickObject");
            }
        }

        public float m_FuseXamountAnimation
        {
            get
            {
                return base.method_2<float>("m_FuseXamountAnimation");
            }
        }

        public Transform m_SparksFinishBone
        {
            get
            {
                return base.method_3<Transform>("m_SparksFinishBone");
            }
        }

        public GameObject m_SparksObject
        {
            get
            {
                return base.method_3<GameObject>("m_SparksObject");
            }
        }

        public Transform m_SparksStartBone
        {
            get
            {
                return base.method_3<Transform>("m_SparksStartBone");
            }
        }

        public Spell m_spell
        {
            get
            {
                return base.method_3<Spell>("m_spell");
            }
        }

        public TurnTimerState m_state
        {
            get
            {
                return base.method_2<TurnTimerState>("m_state");
            }
        }

        public bool m_waitingForTurnStartManagerFinish
        {
            get
            {
                return base.method_2<bool>("m_waitingForTurnStartManagerFinish");
            }
        }
    }
}

