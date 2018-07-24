namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TutorialProgressScreen")]
    public class TutorialProgressScreen : MonoBehaviour
    {
        public TutorialProgressScreen(IntPtr address) : this(address, "TutorialProgressScreen")
        {
        }

        public TutorialProgressScreen(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ExitButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ExitButtonPress", objArray1);
        }

        public static TutorialProgressScreen Get()
        {
            return MonoClass.smethod_15<TutorialProgressScreen>(TritonHs.MainAssemblyPath, "", "TutorialProgressScreen", "Get", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void InitMissionRecords()
        {
            base.method_8("InitMissionRecords", Array.Empty<object>());
        }

        public void LoadAllTutorialHeroEntities()
        {
            base.method_8("LoadAllTutorialHeroEntities", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnHideAnimComplete()
        {
            base.method_8("OnHideAnimComplete", Array.Empty<object>());
        }

        public void OnScaleAnimComplete()
        {
            base.method_8("OnScaleAnimComplete", Array.Empty<object>());
        }

        public void OnTutorialImageLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnTutorialImageLoaded", objArray1);
        }

        public void SetupCoins()
        {
            base.method_8("SetupCoins", Array.Empty<object>());
        }

        public void SetupTutorialImage(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            base.method_8("SetupTutorialImage", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void StartTutorialProgress()
        {
            base.method_8("StartTutorialProgress", Array.Empty<object>());
        }

        public void UpdateProgress()
        {
            base.method_8("UpdateProgress", Array.Empty<object>());
        }

        public Vector3 FINAL_SCALE
        {
            get
            {
                return base.method_2<Vector3>("FINAL_SCALE");
            }
        }

        public Vector3 FINAL_SCALE_OVER_BOX
        {
            get
            {
                return base.method_2<Vector3>("FINAL_SCALE_OVER_BOX");
            }
        }

        public Vector3 HERO_COIN_START
        {
            get
            {
                return base.method_2<Vector3>("HERO_COIN_START");
            }
        }

        public static float HERO_SPACING
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TutorialProgressScreen", "HERO_SPACING");
            }
        }

        public bool IS_TESTING
        {
            get
            {
                return base.method_2<bool>("IS_TESTING");
            }
        }

        public HeroCoin m_coinPrefab
        {
            get
            {
                return base.method_3<HeroCoin>("m_coinPrefab");
            }
        }

        public GameObject m_currentLessonBone
        {
            get
            {
                return base.method_3<GameObject>("m_currentLessonBone");
            }
        }

        public PegUIElement m_exitButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_exitButton");
            }
        }

        public UberText m_exitButtonLabel
        {
            get
            {
                return base.method_3<UberText>("m_exitButtonLabel");
            }
        }

        public List<HeroCoin> m_heroCoins
        {
            get
            {
                Class267<HeroCoin> class2 = base.method_3<Class267<HeroCoin>>("m_heroCoins");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_lessonTitle
        {
            get
            {
                return base.method_3<UberText>("m_lessonTitle");
            }
        }

        public UberText m_missionProgressTitle
        {
            get
            {
                return base.method_3<UberText>("m_missionProgressTitle");
            }
        }

        public bool m_showProgressSavedMessage
        {
            get
            {
                return base.method_2<bool>("m_showProgressSavedMessage");
            }
        }

        public List<ScenarioDbfRecord> m_sortedMissionRecords
        {
            get
            {
                Class267<ScenarioDbfRecord> class2 = base.method_3<Class267<ScenarioDbfRecord>>("m_sortedMissionRecords");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 START_SCALE
        {
            get
            {
                return base.method_2<Vector3>("START_SCALE");
            }
        }

        public static float START_SCALE_VAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TutorialProgressScreen", "START_SCALE_VAL");
            }
        }

        [Attribute38("TutorialProgressScreen.LessonAsset")]
        public class LessonAsset : MonoClass
        {
            public LessonAsset(IntPtr address) : this(address, "LessonAsset")
            {
            }

            public LessonAsset(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_asset
            {
                get
                {
                    return base.method_4("m_asset");
                }
            }

            public string m_phoneAsset
            {
                get
                {
                    return base.method_4("m_phoneAsset");
                }
            }
        }
    }
}

