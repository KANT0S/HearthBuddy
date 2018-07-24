namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ApplicationMgr")]
    public class ApplicationMgr : MonoBehaviour
    {
        public ApplicationMgr(IntPtr address) : this(address, "ApplicationMgr")
        {
        }

        public ApplicationMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Exit()
        {
            base.method_8("Exit", Array.Empty<object>());
        }

        public static IntPtr FindWindow(string className, string windowName)
        {
            object[] objArray1 = new object[] { className, windowName };
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "FindWindow", objArray1);
        }

        public void FireFocusChangedEvent()
        {
            base.method_8("FireFocusChangedEvent", Array.Empty<object>());
        }

        public static ApplicationMgr Get()
        {
            return MonoClass.smethod_15<ApplicationMgr>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "Get", Array.Empty<object>());
        }

        public static AndroidStore GetAndroidStore()
        {
            return MonoClass.smethod_14<AndroidStore>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "GetAndroidStore", Array.Empty<object>());
        }

        public static ApplicationMode GetMode()
        {
            return MonoClass.smethod_14<ApplicationMode>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "GetMode", Array.Empty<object>());
        }

        public static string GetStandaloneLocalDataPath()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "GetStandaloneLocalDataPath", Array.Empty<object>());
        }

        public bool HasFocus()
        {
            return base.method_11<bool>("HasFocus", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public void InitializeGame()
        {
            base.method_8("InitializeGame", Array.Empty<object>());
        }

        public static void InitializeMode()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "InitializeMode");
        }

        public void InitializeOptionValues()
        {
            base.method_8("InitializeOptionValues", Array.Empty<object>());
        }

        public void InitializeUnity()
        {
            base.method_8("InitializeUnity", Array.Empty<object>());
        }

        public void InitializeWindowTitle()
        {
            base.method_8("InitializeWindowTitle", Array.Empty<object>());
        }

        public bool IsExiting()
        {
            return base.method_11<bool>("IsExiting", Array.Empty<object>());
        }

        public static bool IsInternal()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "IsInternal", Array.Empty<object>());
        }

        public static bool IsPublic()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "IsPublic", Array.Empty<object>());
        }

        public bool IsResetting()
        {
            return base.method_11<bool>("IsResetting", Array.Empty<object>());
        }

        public float LastResetTime()
        {
            return base.method_11<float>("LastResetTime", Array.Empty<object>());
        }

        public void OnApplicationFocus(bool focus)
        {
            object[] objArray1 = new object[] { focus };
            base.method_8("OnApplicationFocus", objArray1);
        }

        public void OnApplicationPause(bool pauseStatus)
        {
            object[] objArray1 = new object[] { pauseStatus };
            base.method_8("OnApplicationPause", objArray1);
        }

        public void OnApplicationQuit()
        {
            base.method_8("OnApplicationQuit", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public void ProcessScheduledCallbacks()
        {
            base.method_8("ProcessScheduledCallbacks", Array.Empty<object>());
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void ResetAndForceLogin()
        {
            base.method_8("ResetAndForceLogin", Array.Empty<object>());
        }

        public void ResetAndGoBackToNoAccountTutorial()
        {
            base.method_8("ResetAndGoBackToNoAccountTutorial", Array.Empty<object>());
        }

        public void ResetImmediately(bool forceLogin, bool forceNoAccountTutorial)
        {
            object[] objArray1 = new object[] { forceLogin, forceNoAccountTutorial };
            base.method_8("ResetImmediately", objArray1);
        }

        public bool ResetOnErrorIfNecessary()
        {
            return base.method_11<bool>("ResetOnErrorIfNecessary", Array.Empty<object>());
        }

        public static int SetWindowTextW(IntPtr hWnd, string text)
        {
            object[] objArray1 = new object[] { hWnd, text };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "SetWindowTextW", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UnloadUnusedAssets()
        {
            base.method_8("UnloadUnusedAssets", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static bool UsingStandaloneLocalData()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "UsingStandaloneLocalData", Array.Empty<object>());
        }

        public static float AUTO_RESET_ON_ERROR_TIMEOUT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "AUTO_RESET_ON_ERROR_TIMEOUT");
            }
        }

        public static ApplicationMode DEFAULT_MODE
        {
            get
            {
                return MonoClass.smethod_6<ApplicationMode>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "DEFAULT_MODE");
            }
        }

        public bool m_exiting
        {
            get
            {
                return base.method_2<bool>("m_exiting");
            }
        }

        public bool m_focused
        {
            get
            {
                return base.method_2<bool>("m_focused");
            }
        }

        public bool m_hasResetSinceLastResume
        {
            get
            {
                return base.method_2<bool>("m_hasResetSinceLastResume");
            }
        }

        public float m_lastPauseTime
        {
            get
            {
                return base.method_2<float>("m_lastPauseTime");
            }
        }

        public float m_lastResetTime
        {
            get
            {
                return base.method_2<float>("m_lastResetTime");
            }
        }

        public float m_lastResumeTime
        {
            get
            {
                return base.method_2<float>("m_lastResumeTime");
            }
        }

        public bool m_resetting
        {
            get
            {
                return base.method_2<bool>("m_resetting");
            }
        }

        public static ApplicationMode s_mode
        {
            get
            {
                return MonoClass.smethod_6<ApplicationMode>(TritonHs.MainAssemblyPath, "", "ApplicationMgr", "s_mode");
            }
        }

        [Attribute38("ApplicationMgr.SchedulerContext")]
        public class SchedulerContext : MonoClass
        {
            public SchedulerContext(IntPtr address) : this(address, "SchedulerContext")
            {
            }

            public SchedulerContext(IntPtr address, string className) : base(address, className)
            {
            }

            public float EstimateTargetTime()
            {
                return base.method_11<float>("EstimateTargetTime", Array.Empty<object>());
            }

            public bool m_realTime
            {
                get
                {
                    return base.method_2<bool>("m_realTime");
                }
            }

            public float m_secondsToWait
            {
                get
                {
                    return base.method_2<float>("m_secondsToWait");
                }
            }

            public float m_secondsWaited
            {
                get
                {
                    return base.method_2<float>("m_secondsWaited");
                }
            }

            public float m_startTime
            {
                get
                {
                    return base.method_2<float>("m_startTime");
                }
            }

            public object m_userData
            {
                get
                {
                    return base.method_3<object>("m_userData");
                }
            }
        }
    }
}

