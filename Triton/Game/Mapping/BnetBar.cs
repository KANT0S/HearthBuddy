namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetBar")]
    public class BnetBar : MonoBehaviour
    {
        public BnetBar(IntPtr address) : this(address, "BnetBar")
        {
        }

        public BnetBar(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DestroyLoginTooltip()
        {
            base.method_8("DestroyLoginTooltip", Array.Empty<object>());
        }

        public void Disable()
        {
            base.method_8("Disable", Array.Empty<object>());
        }

        public void Enable()
        {
            base.method_8("Enable", Array.Empty<object>());
        }

        public static BnetBar Get()
        {
            return MonoClass.smethod_15<BnetBar>(TritonHs.MainAssemblyPath, "", "BnetBar", "Get", Array.Empty<object>());
        }

        public bool HandleEscapeKey()
        {
            return base.method_11<bool>("HandleEscapeKey", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void HideFriendList()
        {
            base.method_8("HideFriendList", Array.Empty<object>());
        }

        public bool IsEnabled()
        {
            return base.method_11<bool>("IsEnabled", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFatalError(FatalErrorMessage message, object userData)
        {
            object[] objArray1 = new object[] { message, userData };
            base.method_8("OnFatalError", objArray1);
        }

        public void OnFriendButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnFriendButtonReleased", objArray1);
        }

        public void OnLoggedIn()
        {
            base.method_8("OnLoggedIn", Array.Empty<object>());
        }

        public void OnMenuButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnMenuButtonReleased", objArray1);
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void PositionCurrencyFrame(GameObject parent, Vector3 offset)
        {
            object[] objArray1 = new object[] { parent, offset };
            base.method_8("PositionCurrencyFrame", objArray1);
        }

        public void ShowFriendList()
        {
            base.method_8("ShowFriendList", Array.Empty<object>());
        }

        public void ShowGameMenu(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("ShowGameMenu", objArray1);
        }

        public static void SpectatorCount_OnRollout(UIEvent evt)
        {
            object[] objArray1 = new object[] { evt };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "BnetBar", "SpectatorCount_OnRollout", objArray1);
        }

        public static void SpectatorCount_OnRollover(UIEvent evt)
        {
            object[] objArray1 = new object[] { evt };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "BnetBar", "SpectatorCount_OnRollover", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void SuppressLoginTooltip(bool val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SuppressLoginTooltip", objArray1);
        }

        public void ToggleActive(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("ToggleActive", objArray1);
        }

        public void ToggleEnableButtons(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("ToggleEnableButtons", objArray1);
        }

        public void ToggleFriendListShowing()
        {
            base.method_8("ToggleFriendListShowing", Array.Empty<object>());
        }

        public void ToggleFriendsButton(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("ToggleFriendsButton", objArray1);
        }

        public void ToggleGameMenu()
        {
            base.method_8("ToggleGameMenu", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateForDemoMode()
        {
            base.method_8("UpdateForDemoMode", Array.Empty<object>());
        }

        public void UpdateForPhone()
        {
            base.method_8("UpdateForPhone", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateLoginTooltip()
        {
            base.method_8("UpdateLoginTooltip", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public static int CameraDepth
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "BnetBar", "CameraDepth");
            }
        }

        public Flipbook m_batteryLevel
        {
            get
            {
                return base.method_3<Flipbook>("m_batteryLevel");
            }
        }

        public Flipbook m_batteryLevelPhone
        {
            get
            {
                return base.method_3<Flipbook>("m_batteryLevelPhone");
            }
        }

        public ConnectionIndicator m_connectionIndicator
        {
            get
            {
                return base.method_3<ConnectionIndicator>("m_connectionIndicator");
            }
        }

        public CurrencyFrame m_currencyFrame
        {
            get
            {
                return base.method_3<CurrencyFrame>("m_currencyFrame");
            }
        }

        public UberText m_currentTime
        {
            get
            {
                return base.method_3<UberText>("m_currentTime");
            }
        }

        public BnetBarFriendButton m_friendButton
        {
            get
            {
                return base.method_3<BnetBarFriendButton>("m_friendButton");
            }
        }

        public GameMenu m_gameMenu
        {
            get
            {
                return base.method_3<GameMenu>("m_gameMenu");
            }
        }

        public bool m_gameMenuLoading
        {
            get
            {
                return base.method_2<bool>("m_gameMenuLoading");
            }
        }

        public bool m_hasUnacknowledgedPendingInvites
        {
            get
            {
                return base.method_2<bool>("m_hasUnacknowledgedPendingInvites");
            }
        }

        public float m_initialConnectionIndicatorScaleX
        {
            get
            {
                return base.method_2<float>("m_initialConnectionIndicatorScaleX");
            }
        }

        public float m_initialFriendButtonScaleX
        {
            get
            {
                return base.method_2<float>("m_initialFriendButtonScaleX");
            }
        }

        public float m_initialMenuButtonScaleX
        {
            get
            {
                return base.method_2<float>("m_initialMenuButtonScaleX");
            }
        }

        public float m_initialWidth
        {
            get
            {
                return base.method_2<float>("m_initialWidth");
            }
        }

        public bool m_isEnabled
        {
            get
            {
                return base.method_2<bool>("m_isEnabled");
            }
        }

        public bool m_isInitting
        {
            get
            {
                return base.method_2<bool>("m_isInitting");
            }
        }

        public bool m_isLoggedIn
        {
            get
            {
                return base.method_2<bool>("m_isLoggedIn");
            }
        }

        public float m_lastClockUpdate
        {
            get
            {
                return base.method_2<float>("m_lastClockUpdate");
            }
        }

        public float m_lightingBlend
        {
            get
            {
                return base.method_2<float>("m_lightingBlend");
            }
        }

        public GameObject m_loginTooltip
        {
            get
            {
                return base.method_3<GameObject>("m_loginTooltip");
            }
        }

        public BnetBarMenuButton m_menuButton
        {
            get
            {
                return base.method_3<BnetBarMenuButton>("m_menuButton");
            }
        }

        public GameObject m_menuButtonMesh
        {
            get
            {
                return base.method_3<GameObject>("m_menuButtonMesh");
            }
        }

        public GameObject m_questProgressToastBone
        {
            get
            {
                return base.method_3<GameObject>("m_questProgressToastBone");
            }
        }

        public GameObject m_socialToastBone
        {
            get
            {
                return base.method_3<GameObject>("m_socialToastBone");
            }
        }

        public GameObject m_spectatorCountPanel
        {
            get
            {
                return base.method_3<GameObject>("m_spectatorCountPanel");
            }
        }

        public string m_spectatorCountPrefabPath
        {
            get
            {
                return base.method_4("m_spectatorCountPrefabPath");
            }
        }

        public TooltipZone m_spectatorCountTooltipZone
        {
            get
            {
                return base.method_3<TooltipZone>("m_spectatorCountTooltipZone");
            }
        }

        public GameObject m_spectatorModeIndicator
        {
            get
            {
                return base.method_3<GameObject>("m_spectatorModeIndicator");
            }
        }

        public string m_spectatorModeIndicatorPrefab
        {
            get
            {
                return base.method_4("m_spectatorModeIndicatorPrefab");
            }
        }

        public bool m_suppressLoginTooltip
        {
            get
            {
                return base.method_2<bool>("m_suppressLoginTooltip");
            }
        }
    }
}

