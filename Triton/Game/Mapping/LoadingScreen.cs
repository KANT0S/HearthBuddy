namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("LoadingScreen")]
    public class LoadingScreen : MonoBehaviour
    {
        public LoadingScreen(IntPtr address) : this(address, "LoadingScreen")
        {
        }

        public LoadingScreen(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddTransitionBlocker()
        {
            base.method_9("AddTransitionBlocker", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void AddTransitionBlocker(int count)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { count };
            base.method_9("AddTransitionBlocker", enumArray1, objArray1);
        }

        public void AddTransitionObject(Component c)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { c };
            base.method_9("AddTransitionObject", enumArray1, objArray1);
        }

        public void AddTransitionObject(GameObject go)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { go };
            base.method_9("AddTransitionObject", enumArray1, objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearAssets(long startTimestamp, long endTimestamp)
        {
            object[] objArray1 = new object[] { startTimestamp, endTimestamp };
            base.method_8("ClearAssets", objArray1);
        }

        public void ClearPreviousSceneAssets()
        {
            base.method_8("ClearPreviousSceneAssets", Array.Empty<object>());
        }

        public void CutoffTransition()
        {
            base.method_8("CutoffTransition", Array.Empty<object>());
        }

        public void DisableTransitionUnfriendlyStuff(GameObject mainObject)
        {
            object[] objArray1 = new object[] { mainObject };
            base.method_8("DisableTransitionUnfriendlyStuff", objArray1);
        }

        public static bool DoesShowLoadingScreen(SceneMgr.Mode prevMode, SceneMgr.Mode nextMode)
        {
            object[] objArray1 = new object[] { prevMode, nextMode };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "LoadingScreen", "DoesShowLoadingScreen", objArray1);
        }

        public void DoInterruptionCleanUp()
        {
            base.method_8("DoInterruptionCleanUp", Array.Empty<object>());
        }

        public void EnableFadeIn(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableFadeIn", objArray1);
        }

        public void EnableFadeOut(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableFadeOut", objArray1);
        }

        public void EnableTransition(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableTransition", objArray1);
        }

        public void FadeIn()
        {
            base.method_8("FadeIn", Array.Empty<object>());
        }

        public void FadeOut()
        {
            base.method_8("FadeOut", Array.Empty<object>());
        }

        public void FinishFxCamera()
        {
            base.method_8("FinishFxCamera", Array.Empty<object>());
        }

        public void FinishPreviousScene()
        {
            base.method_8("FinishPreviousScene", Array.Empty<object>());
        }

        public void FireFinishedTransitionListeners(bool cutoff)
        {
            object[] objArray1 = new object[] { cutoff };
            base.method_8("FireFinishedTransitionListeners", objArray1);
        }

        public void FirePreviousSceneDestroyedListeners()
        {
            base.method_8("FirePreviousSceneDestroyedListeners", Array.Empty<object>());
        }

        public static LoadingScreen Get()
        {
            return MonoClass.smethod_15<LoadingScreen>(TritonHs.MainAssemblyPath, "", "LoadingScreen", "Get", Array.Empty<object>());
        }

        public long GetAssetLoadStartTimestamp()
        {
            return base.method_11<long>("GetAssetLoadStartTimestamp", Array.Empty<object>());
        }

        public CameraFade GetCameraFade()
        {
            return base.method_14<CameraFade>("GetCameraFade", Array.Empty<object>());
        }

        public Color GetFadeColor()
        {
            return base.method_11<Color>("GetFadeColor", Array.Empty<object>());
        }

        public Camera GetFreezeFrameCamera()
        {
            return base.method_14<Camera>("GetFreezeFrameCamera", Array.Empty<object>());
        }

        public FullScreenEffects GetFullScreenEffects(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            return base.method_14<FullScreenEffects>("GetFullScreenEffects", objArray1);
        }

        public Camera GetFxCamera()
        {
            return base.method_14<Camera>("GetFxCamera", Array.Empty<object>());
        }

        public Phase GetPhase()
        {
            return base.method_11<Phase>("GetPhase", Array.Empty<object>());
        }

        public void InitializeFxCamera()
        {
            base.method_8("InitializeFxCamera", Array.Empty<object>());
        }

        public bool IsFading()
        {
            return base.method_11<bool>("IsFading", Array.Empty<object>());
        }

        public bool IsFadingIn()
        {
            return base.method_11<bool>("IsFadingIn", Array.Empty<object>());
        }

        public bool IsFadingOut()
        {
            return base.method_11<bool>("IsFadingOut", Array.Empty<object>());
        }

        public bool IsPreviousSceneActive()
        {
            return base.method_11<bool>("IsPreviousSceneActive", Array.Empty<object>());
        }

        public bool IsTransitionEnabled()
        {
            return base.method_11<bool>("IsTransitionEnabled", Array.Empty<object>());
        }

        public bool IsTransitioning()
        {
            return base.method_11<bool>("IsTransitioning", Array.Empty<object>());
        }

        public bool IsWaiting()
        {
            return base.method_11<bool>("IsWaiting", Array.Empty<object>());
        }

        public void NotifyMainSceneObjectAwoke(GameObject mainObject)
        {
            object[] objArray1 = new object[] { mainObject };
            base.method_8("NotifyMainSceneObjectAwoke", objArray1);
        }

        public void NotifyTransitionBlockerComplete()
        {
            base.method_9("NotifyTransitionBlockerComplete", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void NotifyTransitionBlockerComplete(int count)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { count };
            base.method_9("NotifyTransitionBlockerComplete", enumArray1, objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFadeInComplete()
        {
            base.method_8("OnFadeInComplete", Array.Empty<object>());
        }

        public void OnFadeOutComplete()
        {
            base.method_8("OnFadeOutComplete", Array.Empty<object>());
        }

        public void OnFatalError(FatalErrorMessage message, object userData)
        {
            object[] objArray1 = new object[] { message, userData };
            base.method_8("OnFatalError", objArray1);
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void OnScenePreUnload(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("OnScenePreUnload", objArray1);
        }

        public void OnSceneUnloaded(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("OnSceneUnloaded", objArray1);
        }

        public void RegisterSceneListeners()
        {
            base.method_8("RegisterSceneListeners", Array.Empty<object>());
        }

        public void SetAssetLoadStartTimestamp(long timestamp)
        {
            object[] objArray1 = new object[] { timestamp };
            base.method_8("SetAssetLoadStartTimestamp", objArray1);
        }

        public void SetFadeColor(Color color)
        {
            object[] objArray1 = new object[] { color };
            base.method_8("SetFadeColor", objArray1);
        }

        public void SetFreezeFrameCamera(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            base.method_8("SetFreezeFrameCamera", objArray1);
        }

        public void ShowFreezeFrame(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            base.method_8("ShowFreezeFrame", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StopFading()
        {
            base.method_8("StopFading", Array.Empty<object>());
        }

        public bool TransitionIfPossible()
        {
            return base.method_11<bool>("TransitionIfPossible", Array.Empty<object>());
        }

        public void UnregisterSceneListeners()
        {
            base.method_8("UnregisterSceneListeners", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public long m_assetLoadEndTimestamp
        {
            get
            {
                return base.method_2<long>("m_assetLoadEndTimestamp");
            }
        }

        public long m_assetLoadNextStartTimestamp
        {
            get
            {
                return base.method_2<long>("m_assetLoadNextStartTimestamp");
            }
        }

        public long m_assetLoadStartTimestamp
        {
            get
            {
                return base.method_2<long>("m_assetLoadStartTimestamp");
            }
        }

        public iTween.EaseType m_FadeInEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_FadeInEaseType");
            }
        }

        public float m_FadeInSec
        {
            get
            {
                return base.method_2<float>("m_FadeInSec");
            }
        }

        public iTween.EaseType m_FadeOutEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_FadeOutEaseType");
            }
        }

        public float m_FadeOutSec
        {
            get
            {
                return base.method_2<float>("m_FadeOutSec");
            }
        }

        public Camera m_fxCamera
        {
            get
            {
                return base.method_3<Camera>("m_fxCamera");
            }
        }

        public float m_originalPosX
        {
            get
            {
                return base.method_2<float>("m_originalPosX");
            }
        }

        public Phase m_phase
        {
            get
            {
                return base.method_2<Phase>("m_phase");
            }
        }

        public bool m_previousSceneActive
        {
            get
            {
                return base.method_2<bool>("m_previousSceneActive");
            }
        }

        public TransitionParams m_prevTransitionParams
        {
            get
            {
                return base.method_3<TransitionParams>("m_prevTransitionParams");
            }
        }

        public TransitionParams m_transitionParams
        {
            get
            {
                return base.method_3<TransitionParams>("m_transitionParams");
            }
        }

        public TransitionUnfriendlyData m_transitionUnfriendlyData
        {
            get
            {
                return base.method_3<TransitionUnfriendlyData>("m_transitionUnfriendlyData");
            }
        }

        public static float MIDDLE_OF_NOWHERE_X
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "LoadingScreen", "MIDDLE_OF_NOWHERE_X");
            }
        }

        public enum Phase
        {
            INVALID,
            WAITING_FOR_SCENE_UNLOAD,
            WAITING_FOR_SCENE_LOAD,
            WAITING_FOR_BLOCKERS,
            FADING_OUT,
            FADING_IN
        }

        [Attribute38("LoadingScreen.TransitionParams")]
        public class TransitionParams : MonoClass
        {
            public TransitionParams(IntPtr address) : this(address, "TransitionParams")
            {
            }

            public TransitionParams(IntPtr address, string className) : base(address, className)
            {
            }

            public void AddBlocker()
            {
                base.method_9("AddBlocker", new Class272.Enum20[0], Array.Empty<object>());
            }

            public void AddBlocker(int count)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
                object[] objArray1 = new object[] { count };
                base.method_9("AddBlocker", enumArray1, objArray1);
            }

            public void AddObject(Component c)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { c };
                base.method_9("AddObject", enumArray1, objArray1);
            }

            public void AddObject(GameObject go)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { go };
                base.method_9("AddObject", enumArray1, objArray1);
            }

            public void AutoAddObjects()
            {
                base.method_8("AutoAddObjects", Array.Empty<object>());
            }

            public void DestroyObjects()
            {
                base.method_8("DestroyObjects", Array.Empty<object>());
            }

            public void Enable(bool enable)
            {
                object[] objArray1 = new object[] { enable };
                base.method_8("Enable", objArray1);
            }

            public void EnableFadeIn(bool enable)
            {
                object[] objArray1 = new object[] { enable };
                base.method_8("EnableFadeIn", objArray1);
            }

            public void EnableFadeOut(bool enable)
            {
                object[] objArray1 = new object[] { enable };
                base.method_8("EnableFadeOut", objArray1);
            }

            public void FixupCameras(Camera fxCamera)
            {
                object[] objArray1 = new object[] { fxCamera };
                base.method_8("FixupCameras", objArray1);
            }

            public int GetBlockerCount()
            {
                return base.method_11<int>("GetBlockerCount", Array.Empty<object>());
            }

            public List<Camera> GetCameras()
            {
                Class267<Camera> class2 = base.method_14<Class267<Camera>>("GetCameras", Array.Empty<object>());
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }

            public Color GetFadeColor()
            {
                return base.method_11<Color>("GetFadeColor", Array.Empty<object>());
            }

            public Camera GetFreezeFrameCamera()
            {
                return base.method_14<Camera>("GetFreezeFrameCamera", Array.Empty<object>());
            }

            public bool IsEnabled()
            {
                return base.method_11<bool>("IsEnabled", Array.Empty<object>());
            }

            public bool IsFadeInEnabled()
            {
                return base.method_11<bool>("IsFadeInEnabled", Array.Empty<object>());
            }

            public bool IsFadeOutEnabled()
            {
                return base.method_11<bool>("IsFadeOutEnabled", Array.Empty<object>());
            }

            public void PreserveObjects(Transform parent)
            {
                object[] objArray1 = new object[] { parent };
                base.method_8("PreserveObjects", objArray1);
            }

            public void RemoveBlocker()
            {
                base.method_9("RemoveBlocker", new Class272.Enum20[0], Array.Empty<object>());
            }

            public void RemoveBlocker(int count)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
                object[] objArray1 = new object[] { count };
                base.method_9("RemoveBlocker", enumArray1, objArray1);
            }

            public void SetFadeColor(Color color)
            {
                object[] objArray1 = new object[] { color };
                base.method_8("SetFadeColor", objArray1);
            }

            public void SetFreezeFrameCamera(Camera camera)
            {
                object[] objArray1 = new object[] { camera };
                base.method_8("SetFreezeFrameCamera", objArray1);
            }

            public bool ClearPreviousAssets
            {
                get
                {
                    return base.method_11<bool>("get_ClearPreviousAssets", Array.Empty<object>());
                }
            }

            public int m_blockerCount
            {
                get
                {
                    return base.method_2<int>("m_blockerCount");
                }
            }

            public List<Camera> m_cameras
            {
                get
                {
                    Class267<Camera> class2 = base.method_3<Class267<Camera>>("m_cameras");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public bool m_clearPreviousAssets
            {
                get
                {
                    return base.method_2<bool>("m_clearPreviousAssets");
                }
            }

            public bool m_enabled
            {
                get
                {
                    return base.method_2<bool>("m_enabled");
                }
            }

            public Color m_fadeColor
            {
                get
                {
                    return base.method_2<Color>("m_fadeColor");
                }
            }

            public bool m_fadeIn
            {
                get
                {
                    return base.method_2<bool>("m_fadeIn");
                }
            }

            public bool m_fadeOut
            {
                get
                {
                    return base.method_2<bool>("m_fadeOut");
                }
            }

            public Camera m_freezeFrameCamera
            {
                get
                {
                    return base.method_3<Camera>("m_freezeFrameCamera");
                }
            }

            public List<GameObject> m_objects
            {
                get
                {
                    Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_objects");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        [Attribute38("LoadingScreen.TransitionUnfriendlyData")]
        public class TransitionUnfriendlyData : MonoClass
        {
            public TransitionUnfriendlyData(IntPtr address) : this(address, "TransitionUnfriendlyData")
            {
            }

            public TransitionUnfriendlyData(IntPtr address, string className) : base(address, className)
            {
            }

            public void Clear()
            {
                base.method_8("Clear", Array.Empty<object>());
            }

            public void Restore()
            {
                base.method_8("Restore", Array.Empty<object>());
            }
        }
    }
}

