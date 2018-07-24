namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SceneMgr")]
    public class SceneMgr : MonoBehaviour
    {
        public SceneMgr(IntPtr address) : this(address, "SceneMgr")
        {
        }

        public SceneMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CacheModeForResume(Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("CacheModeForResume", objArray1);
        }

        public void ClearCachesAndFreeMemory(int severity)
        {
            object[] objArray1 = new object[] { severity };
            base.method_8("ClearCachesAndFreeMemory", objArray1);
        }

        public void DestroyAllObjectsOnModeSwitch()
        {
            base.method_8("DestroyAllObjectsOnModeSwitch", Array.Empty<object>());
        }

        public bool DoesModeShowBox(Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            return base.method_11<bool>("DoesModeShowBox", objArray1);
        }

        public void FatalMobileError(string msg)
        {
            object[] objArray1 = new object[] { msg };
            base.method_8("FatalMobileError", objArray1);
        }

        public void FireSceneLoadedEvent()
        {
            base.method_8("FireSceneLoadedEvent", Array.Empty<object>());
        }

        public void FireScenePreLoadEvent()
        {
            base.method_8("FireScenePreLoadEvent", Array.Empty<object>());
        }

        public void FireScenePreUnloadEvent(Scene prevScene)
        {
            object[] objArray1 = new object[] { prevScene };
            base.method_8("FireScenePreUnloadEvent", objArray1);
        }

        public void FireSceneUnloadedEvent(Scene prevScene)
        {
            object[] objArray1 = new object[] { prevScene };
            base.method_8("FireSceneUnloadedEvent", objArray1);
        }

        public static SceneMgr Get()
        {
            return MonoClass.smethod_15<SceneMgr>(TritonHs.MainAssemblyPath, "", "SceneMgr", "Get", Array.Empty<object>());
        }

        public Mode GetMode()
        {
            return base.method_11<Mode>("GetMode", Array.Empty<object>());
        }

        public Mode GetNextMode()
        {
            return base.method_11<Mode>("GetNextMode", Array.Empty<object>());
        }

        public Mode GetPrevMode()
        {
            return base.method_11<Mode>("GetPrevMode", Array.Empty<object>());
        }

        public Scene GetScene()
        {
            return base.method_14<Scene>("GetScene", Array.Empty<object>());
        }

        public bool IsInGame()
        {
            return base.method_11<bool>("IsInGame", Array.Empty<object>());
        }

        public bool IsModeRequested(Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            return base.method_11<bool>("IsModeRequested", objArray1);
        }

        public bool IsSceneLoaded()
        {
            return base.method_11<bool>("IsSceneLoaded", Array.Empty<object>());
        }

        public bool IsTransitioning()
        {
            return base.method_11<bool>("IsTransitioning", Array.Empty<object>());
        }

        public void LoadMode()
        {
            base.method_8("LoadMode", Array.Empty<object>());
        }

        public void LoadModeFromModeSwitch()
        {
            base.method_8("LoadModeFromModeSwitch", Array.Empty<object>());
        }

        public void LoadShaderPreCompiler()
        {
            base.method_8("LoadShaderPreCompiler", Array.Empty<object>());
        }

        public void LoadStartupAssets()
        {
            base.method_8("LoadStartupAssets", Array.Empty<object>());
        }

        public void LowMemoryWarning(string msg)
        {
            object[] objArray1 = new object[] { msg };
            base.method_8("LowMemoryWarning", objArray1);
        }

        public void NotifySceneLoaded()
        {
            base.method_8("NotifySceneLoaded", Array.Empty<object>());
        }

        public void OnBaseUILoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnBaseUILoaded", objArray1);
        }

        public void OnBoxLoaded(string name, GameObject screen, object callbackData)
        {
            object[] objArray1 = new object[] { name, screen, callbackData };
            base.method_8("OnBoxLoaded", objArray1);
        }

        public void OnBoxReloaded(string name, GameObject screen, object callbackData)
        {
            object[] objArray1 = new object[] { name, screen, callbackData };
            base.method_8("OnBoxReloaded", objArray1);
        }

        public void OnColorSwitcherLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnColorSwitcherLoaded", objArray1);
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

        public void OnFontTableInitialized(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnFontTableInitialized", objArray1);
        }

        public void OnOverlayUILoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnOverlayUILoaded", objArray1);
        }

        public void OnSoundConfigLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnSoundConfigLoaded", objArray1);
        }

        public void OnSpecialEventVisualMgrLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnSpecialEventVisualMgrLoaded", objArray1);
        }

        public void OnSplashScreenFinished()
        {
            base.method_8("OnSplashScreenFinished", Array.Empty<object>());
        }

        public void OnSplashScreenLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnSplashScreenLoaded", objArray1);
        }

        public void OnStartupAssetFinishedLoading()
        {
            base.method_8("OnStartupAssetFinishedLoading", Array.Empty<object>());
        }

        public void OnTextInputGUISkinLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnTextInputGUISkinLoaded", objArray1);
        }

        public void PostUnloadCleanup()
        {
            base.method_8("PostUnloadCleanup", Array.Empty<object>());
        }

        public void ReloadMode()
        {
            base.method_8("ReloadMode", Array.Empty<object>());
        }

        public void SetNextMode(Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("SetNextMode", objArray1);
        }

        public void SetScene(Scene scene)
        {
            object[] objArray1 = new object[] { scene };
            base.method_8("SetScene", objArray1);
        }

        public bool ShouldDestroyOnModeSwitch(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("ShouldDestroyOnModeSwitch", objArray1);
        }

        public bool ShouldUseSceneLoadDelays()
        {
            return base.method_11<bool>("ShouldUseSceneLoadDelays", Array.Empty<object>());
        }

        public bool ShouldUseSceneUnloadDelays()
        {
            return base.method_11<bool>("ShouldUseSceneUnloadDelays", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public bool WillTransition()
        {
            return base.method_11<bool>("WillTransition", Array.Empty<object>());
        }

        public long m_boxLoadTimestamp
        {
            get
            {
                return base.method_2<long>("m_boxLoadTimestamp");
            }
        }

        public float m_lastMemoryWarning
        {
            get
            {
                return base.method_2<float>("m_lastMemoryWarning");
            }
        }

        public Mode m_mode
        {
            get
            {
                return base.method_2<Mode>("m_mode");
            }
        }

        public Mode m_nextMode
        {
            get
            {
                return base.method_2<Mode>("m_nextMode");
            }
        }

        public bool m_performFullCleanup
        {
            get
            {
                return base.method_2<bool>("m_performFullCleanup");
            }
        }

        public Mode m_prevMode
        {
            get
            {
                return base.method_2<Mode>("m_prevMode");
            }
        }

        public bool m_reloadMode
        {
            get
            {
                return base.method_2<bool>("m_reloadMode");
            }
        }

        public Scene m_scene
        {
            get
            {
                return base.method_3<Scene>("m_scene");
            }
        }

        public bool m_sceneLoaded
        {
            get
            {
                return base.method_2<bool>("m_sceneLoaded");
            }
        }

        public int m_startupAssetLoads
        {
            get
            {
                return base.method_2<int>("m_startupAssetLoads");
            }
        }

        public GameObject m_StartupCamera
        {
            get
            {
                return base.method_3<GameObject>("m_StartupCamera");
            }
        }

        public bool m_textInputGUISkinLoaded
        {
            get
            {
                return base.method_2<bool>("m_textInputGUISkinLoaded");
            }
        }

        public bool m_transitioning
        {
            get
            {
                return base.method_2<bool>("m_transitioning");
            }
        }

        public static float SCENE_LOADED_DELAY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SceneMgr", "SCENE_LOADED_DELAY");
            }
        }

        public static float SCENE_UNLOAD_DELAY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SceneMgr", "SCENE_UNLOAD_DELAY");
            }
        }

        public static int TRIM_MEMORY_RUNNING_CRITICAL
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "SceneMgr", "TRIM_MEMORY_RUNNING_CRITICAL");
            }
        }

        public static int TRIM_MEMORY_RUNNING_LOW
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "SceneMgr", "TRIM_MEMORY_RUNNING_LOW");
            }
        }

        public static int TRIM_MEMORY_RUNNING_MODERATE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "SceneMgr", "TRIM_MEMORY_RUNNING_MODERATE");
            }
        }

        public enum Mode
        {
            INVALID,
            STARTUP,
            LOGIN,
            HUB,
            GAMEPLAY,
            COLLECTIONMANAGER,
            PACKOPENING,
            TOURNAMENT,
            FRIENDLY,
            FATAL_ERROR,
            DRAFT,
            CREDITS,
            RESET,
            ADVENTURE,
            TAVERN_BRAWL
        }
    }
}

