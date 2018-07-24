namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("InactivePlayerKicker")]
    public class InactivePlayerKicker : MonoBehaviour
    {
        public InactivePlayerKicker(IntPtr address) : this(address, "InactivePlayerKicker")
        {
        }

        public InactivePlayerKicker(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanCheckForInactivity()
        {
            return base.method_11<bool>("CanCheckForInactivity", Array.Empty<object>());
        }

        public void CheckActivity()
        {
            base.method_8("CheckActivity", Array.Empty<object>());
        }

        public void CheckInactivity()
        {
            base.method_8("CheckInactivity", Array.Empty<object>());
        }

        public static InactivePlayerKicker Get()
        {
            return MonoClass.smethod_15<InactivePlayerKicker>(TritonHs.MainAssemblyPath, "", "InactivePlayerKicker", "Get", Array.Empty<object>());
        }

        public float GetKickSec()
        {
            return base.method_11<float>("GetKickSec", Array.Empty<object>());
        }

        public bool IsCheckingForInactivity()
        {
            return base.method_11<bool>("IsCheckingForInactivity", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public void OnLoggedIn()
        {
            base.method_8("OnLoggedIn", Array.Empty<object>());
        }

        public void OnOptionChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnOptionChanged", objArray1);
        }

        public void OnScenePreUnload(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("OnScenePreUnload", objArray1);
        }

        public void SetKickSec(float sec)
        {
            object[] objArray1 = new object[] { sec };
            base.method_8("SetKickSec", objArray1);
        }

        public bool SetKickTimeStr(string timeStr)
        {
            object[] objArray1 = new object[] { timeStr };
            return base.method_11<bool>("SetKickTimeStr", objArray1);
        }

        public void SetShouldCheckForInactivity(bool check)
        {
            object[] objArray1 = new object[] { check };
            base.method_8("SetShouldCheckForInactivity", objArray1);
        }

        public bool ShouldCheckForInactivity()
        {
            return base.method_11<bool>("ShouldCheckForInactivity", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartCheckForInactivity()
        {
            base.method_8("StartCheckForInactivity", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateCheckForInactivity()
        {
            base.method_8("UpdateCheckForInactivity", Array.Empty<object>());
        }

        public void UpdateIdleKickTimeOption()
        {
            base.method_8("UpdateIdleKickTimeOption", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public static float DEFAULT_KICK_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "InactivePlayerKicker", "DEFAULT_KICK_SEC");
            }
        }

        public bool m_activityDetected
        {
            get
            {
                return base.method_2<bool>("m_activityDetected");
            }
        }

        public bool m_checkingForInactivity
        {
            get
            {
                return base.method_2<bool>("m_checkingForInactivity");
            }
        }

        public float m_inactivityStartTimestamp
        {
            get
            {
                return base.method_2<float>("m_inactivityStartTimestamp");
            }
        }

        public float m_kickSec
        {
            get
            {
                return base.method_2<float>("m_kickSec");
            }
        }

        public bool m_shouldCheckForInactivity
        {
            get
            {
                return base.method_2<bool>("m_shouldCheckForInactivity");
            }
        }
    }
}

