namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TransitionPopup")]
    public class TransitionPopup : MonoBehaviour
    {
        public TransitionPopup(IntPtr address) : this(address, "TransitionPopup")
        {
        }

        public TransitionPopup(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateBlurBlendOff()
        {
            base.method_8("AnimateBlurBlendOff", Array.Empty<object>());
        }

        public void AnimateBlurBlendOn()
        {
            base.method_8("AnimateBlurBlendOn", Array.Empty<object>());
        }

        public void AnimateHide()
        {
            base.method_8("AnimateHide", Array.Empty<object>());
        }

        public void AnimateShow()
        {
            base.method_8("AnimateShow", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Cancel()
        {
            base.method_8("Cancel", Array.Empty<object>());
        }

        public void DeactivatePopup()
        {
            base.method_8("DeactivatePopup", Array.Empty<object>());
        }

        public void DisableCancelButton()
        {
            base.method_8("DisableCancelButton", Array.Empty<object>());
        }

        public void DisableFullScreenBlur()
        {
            base.method_8("DisableFullScreenBlur", Array.Empty<object>());
        }

        public void EnableCancelButton()
        {
            base.method_8("EnableCancelButton", Array.Empty<object>());
        }

        public bool EnableCancelButtonIfPossible()
        {
            return base.method_11<bool>("EnableCancelButtonIfPossible", Array.Empty<object>());
        }

        public void EnableFullScreenBlur()
        {
            base.method_8("EnableFullScreenBlur", Array.Empty<object>());
        }

        public void FireMatchCanceledEvent()
        {
            base.method_8("FireMatchCanceledEvent", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void OnAnimateShowFinished()
        {
            base.method_8("OnAnimateShowFinished", Array.Empty<object>());
        }

        public void OnCancelButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelButtonOver", objArray1);
        }

        public void OnCancelButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelButtonReleased", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
        }

        public void OnGameCanceled(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameCanceled", objArray1);
        }

        public void OnGameConnecting(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameConnecting", objArray1);
        }

        public void OnGameDelayed(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameDelayed", objArray1);
        }

        public void OnGameEntered(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameEntered", objArray1);
        }

        public void OnGameError(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameError", objArray1);
        }

        public void OnGameplaySceneLoaded()
        {
            base.method_8("OnGameplaySceneLoaded", Array.Empty<object>());
        }

        public void OnGameStarted(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameStarted", objArray1);
        }

        public void OnGameUpdated(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameUpdated", objArray1);
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void PunchPopup()
        {
            base.method_8("PunchPopup", Array.Empty<object>());
        }

        public void SetAdventureId(AdventureDbId adventureId)
        {
            object[] objArray1 = new object[] { adventureId };
            base.method_8("SetAdventureId", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowPopup()
        {
            base.method_8("ShowPopup", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartBlockingTransition()
        {
            base.method_8("StartBlockingTransition", Array.Empty<object>());
        }

        public void StopBlockingTransition()
        {
            base.method_8("StopBlockingTransition", Array.Empty<object>());
        }

        public Vector3 END_POSITION
        {
            get
            {
                return base.method_2<Vector3>("END_POSITION");
            }
        }

        public AdventureDbId m_adventureId
        {
            get
            {
                return base.method_2<AdventureDbId>("m_adventureId");
            }
        }

        public bool m_blockingLoadingScreen
        {
            get
            {
                return base.method_2<bool>("m_blockingLoadingScreen");
            }
        }

        public bool m_blurEnabled
        {
            get
            {
                return base.method_2<bool>("m_blurEnabled");
            }
        }

        public UIBButton m_cancelButton
        {
            get
            {
                return base.method_3<UIBButton>("m_cancelButton");
            }
        }

        public Camera m_fullScreenEffectsCamera
        {
            get
            {
                return base.method_3<Camera>("m_fullScreenEffectsCamera");
            }
        }

        public MatchingQueueTab m_queueTab
        {
            get
            {
                return base.method_3<MatchingQueueTab>("m_queueTab");
            }
        }

        public bool m_showAnimationFinished
        {
            get
            {
                return base.method_2<bool>("m_showAnimationFinished");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public UberText m_title
        {
            get
            {
                return base.method_3<UberText>("m_title");
            }
        }

        public float POPUP_TIME
        {
            get
            {
                return base.method_2<float>("POPUP_TIME");
            }
        }

        public float START_SCALE_VAL
        {
            get
            {
                return base.method_2<float>("START_SCALE_VAL");
            }
        }
    }
}

