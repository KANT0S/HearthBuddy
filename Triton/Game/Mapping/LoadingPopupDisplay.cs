namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("LoadingPopupDisplay")]
    public class LoadingPopupDisplay : TransitionPopup
    {
        public LoadingPopupDisplay(IntPtr address) : this(address, "LoadingPopupDisplay")
        {
        }

        public LoadingPopupDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateHide()
        {
            base.method_8("AnimateHide", Array.Empty<object>());
        }

        public void AnimateInLoadingTile()
        {
            base.method_8("AnimateInLoadingTile", Array.Empty<object>());
        }

        public void AnimateOutLoadingTile()
        {
            base.method_8("AnimateOutLoadingTile", Array.Empty<object>());
        }

        public void AnimateShow()
        {
            base.method_8("AnimateShow", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DisableCancelButton()
        {
            base.method_8("DisableCancelButton", Array.Empty<object>());
        }

        public void EnableCancelButton()
        {
            base.method_8("EnableCancelButton", Array.Empty<object>());
        }

        public bool EnableCancelButtonIfPossible()
        {
            return base.method_11<bool>("EnableCancelButtonIfPossible", Array.Empty<object>());
        }

        public void GenerateTaskNameMap()
        {
            base.method_8("GenerateTaskNameMap", Array.Empty<object>());
        }

        public void GenerateTaskNamesForAdventure(AdventureDbId adventureId, string prefix)
        {
            object[] objArray1 = new object[] { adventureId, prefix };
            base.method_8("GenerateTaskNamesForAdventure", objArray1);
        }

        public float GetRandomTaskDuration()
        {
            return base.method_11<float>("GetRandomTaskDuration", Array.Empty<object>());
        }

        public string GetRandomTaskName()
        {
            return base.method_13("GetRandomTaskName", Array.Empty<object>());
        }

        public void OnAnimateShowFinished()
        {
            base.method_8("OnAnimateShowFinished", Array.Empty<object>());
        }

        public void OnCancelButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelButtonReleased", objArray1);
        }

        public void OnCancelButtonShowTimerCompleted(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnCancelButtonShowTimerCompleted", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnGameCanceled(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameCanceled", objArray1);
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

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void SetLoadingBarTexture()
        {
            base.method_8("SetLoadingBarTexture", Array.Empty<object>());
        }

        public void SetTipOfTheDay()
        {
            base.method_8("SetTipOfTheDay", Array.Empty<object>());
        }

        public void StopLoopingSound()
        {
            base.method_8("StopLoopingSound", Array.Empty<object>());
        }

        public static Vector3 END_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "END_POS");
            }
        }

        public static float LOWER_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "LOWER_TIME");
            }
        }

        public bool m_animationStopped
        {
            get
            {
                return base.method_2<bool>("m_animationStopped");
            }
        }

        public bool m_barAnimating
        {
            get
            {
                return base.method_2<bool>("m_barAnimating");
            }
        }

        public List<LoadingbarTexture> m_barTextures
        {
            get
            {
                Class267<LoadingbarTexture> class2 = base.method_3<Class267<LoadingbarTexture>>("m_barTextures");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_cancelButtonParent
        {
            get
            {
                return base.method_3<GameObject>("m_cancelButtonParent");
            }
        }

        public GameObject m_loadingTile
        {
            get
            {
                return base.method_3<GameObject>("m_loadingTile");
            }
        }

        public ProgressBar m_progressBar
        {
            get
            {
                return base.method_3<ProgressBar>("m_progressBar");
            }
        }

        public List<string> m_spectatorTaskNameMap
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_spectatorTaskNameMap");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_stopAnimating
        {
            get
            {
                return base.method_2<bool>("m_stopAnimating");
            }
        }

        public UberText m_tipOfTheDay
        {
            get
            {
                return base.method_3<UberText>("m_tipOfTheDay");
            }
        }

        public static Vector3 MID_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "MID_POS");
            }
        }

        public static Vector3 OFFSCREEN_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "OFFSCREEN_POS");
            }
        }

        public static float RAISE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "RAISE_TIME");
            }
        }

        public static float ROTATION_DELAY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "ROTATION_DELAY");
            }
        }

        public static float ROTATION_DURATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "ROTATION_DURATION");
            }
        }

        public static float SHOW_CANCEL_BUTTON_THRESHOLD
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "SHOW_CANCEL_BUTTON_THRESHOLD");
            }
        }

        public static string SHOW_CANCEL_BUTTON_TWEEN_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "SHOW_CANCEL_BUTTON_TWEEN_NAME");
            }
        }

        public static float SLIDE_IN_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "SLIDE_IN_TIME");
            }
        }

        public static float SLIDE_OUT_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "SLIDE_OUT_TIME");
            }
        }

        public static Vector3 START_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "START_POS");
            }
        }

        public static int TASK_DURATION_VARIATION
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "LoadingPopupDisplay", "TASK_DURATION_VARIATION");
            }
        }

        [Attribute38("LoadingPopupDisplay.LoadingbarTexture")]
        public class LoadingbarTexture : MonoClass
        {
            public LoadingbarTexture(IntPtr address) : this(address, "LoadingbarTexture")
            {
            }

            public LoadingbarTexture(IntPtr address, string className) : base(address, className)
            {
            }

            public AdventureDbId adventureID
            {
                get
                {
                    return base.method_2<AdventureDbId>("adventureID");
                }
            }

            public float m_barIntensity
            {
                get
                {
                    return base.method_2<float>("m_barIntensity");
                }
            }

            public float m_barIntensityIncreaseMax
            {
                get
                {
                    return base.method_2<float>("m_barIntensityIncreaseMax");
                }
            }

            public Texture texture
            {
                get
                {
                    return base.method_3<Texture>("texture");
                }
            }
        }
    }
}

