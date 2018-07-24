namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureScene")]
    public class AdventureScene : Scene
    {
        public AdventureScene(IntPtr address) : this(address, "AdventureScene")
        {
        }

        public AdventureScene(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CompleteTransition()
        {
            base.method_8("CompleteTransition", Array.Empty<object>());
        }

        public void DestroyTransitioningSubScene(GameObject destroysubscene)
        {
            object[] objArray1 = new object[] { destroysubscene };
            base.method_8("DestroyTransitioningSubScene", objArray1);
        }

        public void DoSubSceneTransition(AdventureSubScene subscene)
        {
            object[] objArray1 = new object[] { subscene };
            base.method_8("DoSubSceneTransition", objArray1);
        }

        public void EnableTransitionBlocker(bool block)
        {
            object[] objArray1 = new object[] { block };
            base.method_8("EnableTransitionBlocker", objArray1);
        }

        public static AdventureScene Get()
        {
            return MonoClass.smethod_15<AdventureScene>(TritonHs.MainAssemblyPath, "", "AdventureScene", "Get", Array.Empty<object>());
        }

        public AdventureDef GetAdventureDef(AdventureDbId advId)
        {
            object[] objArray1 = new object[] { advId };
            return base.method_14<AdventureDef>("GetAdventureDef", objArray1);
        }

        public Vector3 GetMoveDirection()
        {
            return base.method_11<Vector3>("GetMoveDirection", Array.Empty<object>());
        }

        public List<AdventureDef> GetSortedAdventureDefs()
        {
            Class267<AdventureDef> class2 = base.method_14<Class267<AdventureDef>>("GetSortedAdventureDefs", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public AdventureWingDef GetWingDef(WingDbId wingId)
        {
            object[] objArray1 = new object[] { wingId };
            return base.method_14<AdventureWingDef>("GetWingDef", objArray1);
        }

        public List<AdventureWingDef> GetWingDefsFromAdventure(AdventureDbId advId)
        {
            object[] objArray1 = new object[] { advId };
            Class267<AdventureWingDef> class2 = base.method_14<Class267<AdventureWingDef>>("GetWingDefsFromAdventure", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void InitializeAllDefs()
        {
            base.method_8("InitializeAllDefs", Array.Empty<object>());
        }

        public bool IsAdventureOpen(AdventureDbId advId)
        {
            object[] objArray1 = new object[] { advId };
            return base.method_11<bool>("IsAdventureOpen", objArray1);
        }

        public bool IsInitialScreen()
        {
            return base.method_11<bool>("IsInitialScreen", Array.Empty<object>());
        }

        public bool IsUnloading()
        {
            return base.method_11<bool>("IsUnloading", Array.Empty<object>());
        }

        public void LoadSubScene(AdventureSubScenes subscene)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { subscene };
            base.method_9("LoadSubScene", enumArray1, objArray1);
        }

        public void OnAdventureModeChanged(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            base.method_8("OnAdventureModeChanged", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFirstSubSceneLoaded(string name, GameObject screen, object callbackData)
        {
            object[] objArray1 = new object[] { name, screen, callbackData };
            base.method_8("OnFirstSubSceneLoaded", objArray1);
        }

        public void OnKTQuoteLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnKTQuoteLoaded", objArray1);
        }

        public void OnSelectedModeChanged(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            base.method_8("OnSelectedModeChanged", objArray1);
        }

        public void OnSelectedModeChanged_CreateKTIntroConversation()
        {
            base.method_8("OnSelectedModeChanged_CreateKTIntroConversation", Array.Empty<object>());
        }

        public void OnStartupAssetLoaded()
        {
            base.method_8("OnStartupAssetLoaded", Array.Empty<object>());
        }

        public void OnSubSceneChange(AdventureSubScenes newscene, bool forward)
        {
            object[] objArray1 = new object[] { newscene, forward };
            base.method_8("OnSubSceneChange", objArray1);
        }

        public void OnSubSceneLoaded(string name, GameObject screen, object callbackData)
        {
            object[] objArray1 = new object[] { name, screen, callbackData };
            base.method_8("OnSubSceneLoaded", objArray1);
        }

        public void ShowExpertAIUnlockTip()
        {
            base.method_8("ShowExpertAIUnlockTip", Array.Empty<object>());
        }

        public void ShowHeroicWarning()
        {
            base.method_8("ShowHeroicWarning", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateAdventureModeMusic()
        {
            base.method_8("UpdateAdventureModeMusic", Array.Empty<object>());
        }

        public int DevModeSetting
        {
            get
            {
                return base.method_11<int>("get_DevModeSetting", Array.Empty<object>());
            }
        }

        public bool IsDevMode
        {
            get
            {
                return base.method_11<bool>("get_IsDevMode", Array.Empty<object>());
            }
        }

        public List<AdventureModeMusic> m_AdventureModeMusic
        {
            get
            {
                Class267<AdventureModeMusic> class2 = base.method_3<Class267<AdventureModeMusic>>("m_AdventureModeMusic");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_CurrentSubScene
        {
            get
            {
                return base.method_3<GameObject>("m_CurrentSubScene");
            }
        }

        public float m_DefaultTransitionAnimationTime
        {
            get
            {
                return base.method_2<float>("m_DefaultTransitionAnimationTime");
            }
        }

        public bool m_MusicStopped
        {
            get
            {
                return base.method_2<bool>("m_MusicStopped");
            }
        }

        public bool m_ReverseTransition
        {
            get
            {
                return base.method_2<bool>("m_ReverseTransition");
            }
        }

        public string m_SlideInSound
        {
            get
            {
                return base.method_4("m_SlideInSound");
            }
        }

        public string m_SlideOutSound
        {
            get
            {
                return base.method_4("m_SlideOutSound");
            }
        }

        public int m_StartupAssetLoads
        {
            get
            {
                return base.method_2<int>("m_StartupAssetLoads");
            }
        }

        public List<AdventureSubSceneDef> m_SubSceneDefs
        {
            get
            {
                Class267<AdventureSubSceneDef> class2 = base.method_3<Class267<AdventureSubSceneDef>>("m_SubSceneDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 m_SubScenePosition
        {
            get
            {
                return base.method_2<Vector3>("m_SubScenePosition");
            }
        }

        public int m_SubScenesLoaded
        {
            get
            {
                return base.method_2<int>("m_SubScenesLoaded");
            }
        }

        public GameObject m_transitionClickBlocker
        {
            get
            {
                return base.method_3<GameObject>("m_transitionClickBlocker");
            }
        }

        public TransitionDirection m_TransitionDirection
        {
            get
            {
                return base.method_2<TransitionDirection>("m_TransitionDirection");
            }
        }

        public iTween.EaseType m_TransitionEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_TransitionEaseType");
            }
        }

        public GameObject m_TransitionOutSubScene
        {
            get
            {
                return base.method_3<GameObject>("m_TransitionOutSubScene");
            }
        }

        public bool m_Unloading
        {
            get
            {
                return base.method_2<bool>("m_Unloading");
            }
        }

        public static Vector3 REWARD_LOCAL_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "AdventureScene", "REWARD_LOCAL_POS");
            }
        }

        public static AdventureSubScenes s_StartMode
        {
            get
            {
                return MonoClass.smethod_6<AdventureSubScenes>(TritonHs.MainAssemblyPath, "", "AdventureScene", "s_StartMode");
            }
        }

        [Attribute38("AdventureScene.AdventureModeMusic")]
        public class AdventureModeMusic : MonoClass
        {
            public AdventureModeMusic(IntPtr address) : this(address, "AdventureModeMusic")
            {
            }

            public AdventureModeMusic(IntPtr address, string className) : base(address, className)
            {
            }

            public AdventureDbId m_adventureId
            {
                get
                {
                    return base.method_2<AdventureDbId>("m_adventureId");
                }
            }

            public MusicPlaylistType m_playlist
            {
                get
                {
                    return base.method_2<MusicPlaylistType>("m_playlist");
                }
            }

            public AdventureSubScenes m_subsceneId
            {
                get
                {
                    return base.method_2<AdventureSubScenes>("m_subsceneId");
                }
            }
        }

        [Attribute38("AdventureScene.AdventureSubSceneDef")]
        public class AdventureSubSceneDef : MonoClass
        {
            public AdventureSubSceneDef(IntPtr address) : this(address, "AdventureSubSceneDef")
            {
            }

            public AdventureSubSceneDef(IntPtr address, string className) : base(address, className)
            {
            }

            public AdventureSubScenes m_SubScene
            {
                get
                {
                    return base.method_2<AdventureSubScenes>("m_SubScene");
                }
            }
        }

        public enum TransitionDirection
        {
            X,
            Y,
            Z,
            NX,
            NY,
            NZ
        }
    }
}

