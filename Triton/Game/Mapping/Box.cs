namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Box")]
    public class Box : MonoBehaviour
    {
        public Box(IntPtr address) : this(address, "Box")
        {
        }

        public Box(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanEnableUIEvents()
        {
            return base.method_11<bool>("CanEnableUIEvents", Array.Empty<object>());
        }

        public void ChangeLightState(BoxLightStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("ChangeLightState", objArray1);
        }

        public bool ChangeState(State state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("ChangeState", objArray1);
        }

        public void ChangeState_Closed()
        {
            base.method_8("ChangeState_Closed", Array.Empty<object>());
        }

        public void ChangeState_Error()
        {
            base.method_8("ChangeState_Error", Array.Empty<object>());
        }

        public void ChangeState_Hub()
        {
            base.method_8("ChangeState_Hub", Array.Empty<object>());
        }

        public void ChangeState_HubWithDrawer()
        {
            base.method_8("ChangeState_HubWithDrawer", Array.Empty<object>());
        }

        public void ChangeState_Loading()
        {
            base.method_8("ChangeState_Loading", Array.Empty<object>());
        }

        public void ChangeState_Open()
        {
            base.method_8("ChangeState_Open", Array.Empty<object>());
        }

        public void ChangeState_PressStart()
        {
            base.method_8("ChangeState_PressStart", Array.Empty<object>());
        }

        public void ChangeState_Startup()
        {
            base.method_8("ChangeState_Startup", Array.Empty<object>());
        }

        public void ChangeStateNow(State state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("ChangeStateNow", objArray1);
        }

        public void ChangeStateQueued()
        {
            base.method_8("ChangeStateQueued", Array.Empty<object>());
        }

        public void ChangeStateToReflectSceneMode(SceneMgr.Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("ChangeStateToReflectSceneMode", objArray1);
        }

        public void ChangeStateUsingConfig()
        {
            base.method_8("ChangeStateUsingConfig", Array.Empty<object>());
        }

        public void ClearQueuedButtonFireEvent()
        {
            base.method_8("ClearQueuedButtonFireEvent", Array.Empty<object>());
        }

        public int ComputeBoosterCount()
        {
            return base.method_11<int>("ComputeBoosterCount", Array.Empty<object>());
        }

        public void DestroyQuestLog()
        {
            base.method_8("DestroyQuestLog", Array.Empty<object>());
        }

        public void DisableButton(PegUIElement button)
        {
            object[] objArray1 = new object[] { button };
            base.method_8("DisableButton", objArray1);
        }

        public void DoTavernBrawlButtonInitialization()
        {
            base.method_8("DoTavernBrawlButtonInitialization", Array.Empty<object>());
        }

        public void EnableButton(PegUIElement button)
        {
            object[] objArray1 = new object[] { button };
            base.method_8("EnableButton", objArray1);
        }

        public void FireButtonPressEvent(ButtonType buttonType)
        {
            object[] objArray1 = new object[] { buttonType };
            base.method_8("FireButtonPressEvent", objArray1);
        }

        public void FireTransitionFinishedEvent()
        {
            base.method_8("FireTransitionFinishedEvent", Array.Empty<object>());
        }

        public void FullScreenBlack_ChangeState(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("FullScreenBlack_ChangeState", objArray1);
        }

        public void FullScreenBlack_UpdateState(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("FullScreenBlack_UpdateState", objArray1);
        }

        public static Box Get()
        {
            return MonoClass.smethod_15<Box>(TritonHs.MainAssemblyPath, "", "Box", "Get", Array.Empty<object>());
        }

        public BoxCamera GetBoxCamera()
        {
            return base.method_14<BoxCamera>("GetBoxCamera", Array.Empty<object>());
        }

        public Camera GetCamera()
        {
            return base.method_14<Camera>("GetCamera", Array.Empty<object>());
        }

        public BoxEventMgr GetEventMgr()
        {
            return base.method_14<BoxEventMgr>("GetEventMgr", Array.Empty<object>());
        }

        public Spell GetEventSpell(BoxEventType eventType)
        {
            object[] objArray1 = new object[] { eventType };
            return base.method_14<Spell>("GetEventSpell", objArray1);
        }

        public BoxLightMgr GetLightMgr()
        {
            return base.method_14<BoxLightMgr>("GetLightMgr", Array.Empty<object>());
        }

        public BoxLightStateType GetLightState()
        {
            return base.method_11<BoxLightStateType>("GetLightState", Array.Empty<object>());
        }

        public Camera GetNoFxCamera()
        {
            return base.method_14<Camera>("GetNoFxCamera", Array.Empty<object>());
        }

        public State GetState()
        {
            return base.method_11<State>("GetState", Array.Empty<object>());
        }

        public void HackRequestNetData()
        {
            base.method_8("HackRequestNetData", Array.Empty<object>());
        }

        public void HackRequestNetFeatures()
        {
            base.method_8("HackRequestNetFeatures", Array.Empty<object>());
        }

        public bool HasPendingEffects()
        {
            return base.method_11<bool>("HasPendingEffects", Array.Empty<object>());
        }

        public void HighlightButton(BoxMenuButton button, bool highlightOn)
        {
            object[] objArray1 = new object[] { button, highlightOn };
            base.method_8("HighlightButton", objArray1);
        }

        public void InitializeComponents()
        {
            base.method_8("InitializeComponents", Array.Empty<object>());
        }

        public void InitializeNet()
        {
            base.method_8("InitializeNet", Array.Empty<object>());
        }

        public void InitializeState()
        {
            base.method_8("InitializeState", Array.Empty<object>());
        }

        public void InitializeStateConfigs()
        {
            base.method_8("InitializeStateConfigs", Array.Empty<object>());
        }

        public void InitializeUI()
        {
            base.method_8("InitializeUI", Array.Empty<object>());
        }

        public bool IsBusy()
        {
            return base.method_11<bool>("IsBusy", Array.Empty<object>());
        }

        public bool IsTransitioningToSceneMode()
        {
            return base.method_11<bool>("IsTransitioningToSceneMode", Array.Empty<object>());
        }

        public void OnAnimFinished()
        {
            base.method_8("OnAnimFinished", Array.Empty<object>());
        }

        public void OnAnimStarted()
        {
            base.method_8("OnAnimStarted", Array.Empty<object>());
        }

        public void OnBoxTopPhoneTextureLoaded(string name, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { name, obj, callbackData };
            base.method_8("OnBoxTopPhoneTextureLoaded", objArray1);
        }

        public void OnButtonMouseOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnButtonMouseOut", objArray1);
        }

        public void OnButtonMouseOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnButtonMouseOver", objArray1);
        }

        public void OnButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnButtonPressed", objArray1);
        }

        public void OnCollectionButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCollectionButtonPressed", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnForgeButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnForgeButtonPressed", objArray1);
        }

        public void OnLoggedIn()
        {
            base.method_8("OnLoggedIn", Array.Empty<object>());
        }

        public void OnNetCacheReady()
        {
            base.method_8("OnNetCacheReady", Array.Empty<object>());
        }

        public void OnOpenPacksButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnOpenPacksButtonPressed", objArray1);
        }

        public void OnQuestButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnQuestButtonPressed", objArray1);
        }

        public void OnQuestLogLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnQuestLogLoaded", objArray1);
        }

        public void OnQuestLogNetCacheReady()
        {
            base.method_8("OnQuestLogNetCacheReady", Array.Empty<object>());
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

        public void OnSoloAdventuresButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnSoloAdventuresButtonPressed", objArray1);
        }

        public void OnStartButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnStartButtonPressed", objArray1);
        }

        public void OnStoreButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnStoreButtonReleased", objArray1);
        }

        public void OnStoreShown(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnStoreShown", objArray1);
        }

        public void OnTavernBrawlButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTavernBrawlButtonPressed", objArray1);
        }

        public void OnTournamentButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTournamentButtonPressed", objArray1);
        }

        public void OnTutorialPlaySpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnTutorialPlaySpellStateFinished", objArray1);
        }

        public void OnTutorialSceneDestroyed(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnTutorialSceneDestroyed", objArray1);
        }

        public void PlayTavernBrawlButtonActivation(bool activate, bool isInitialization)
        {
            object[] objArray1 = new object[] { activate, isInitialization };
            base.method_8("PlayTavernBrawlButtonActivation", objArray1);
        }

        public void QueueStateChange(State state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("QueueStateChange", objArray1);
        }

        public void RegisterButtonEvents(PegUIElement button)
        {
            object[] objArray1 = new object[] { button };
            base.method_8("RegisterButtonEvents", objArray1);
        }

        public void SetLightState(BoxLightStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("SetLightState", objArray1);
        }

        public void SetPackCount(int n)
        {
            object[] objArray1 = new object[] { n };
            base.method_8("SetPackCount", objArray1);
        }

        public void SetToIgnoreFullScreenEffects(bool ignoreEffects)
        {
            object[] objArray1 = new object[] { ignoreEffects };
            base.method_8("SetToIgnoreFullScreenEffects", objArray1);
        }

        public bool ShouldRequestData(DataState state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("ShouldRequestData", objArray1);
        }

        public void ShutdownNet()
        {
            base.method_8("ShutdownNet", Array.Empty<object>());
        }

        public void ShutdownState()
        {
            base.method_8("ShutdownState", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void ToggleButtonTextureState(bool enabled, BoxMenuButton button)
        {
            object[] objArray1 = new object[] { enabled, button };
            base.method_8("ToggleButtonTextureState", objArray1);
        }

        public void ToggleDrawerButtonState(bool enabled, BoxMenuButton button)
        {
            object[] objArray1 = new object[] { enabled, button };
            base.method_8("ToggleDrawerButtonState", objArray1);
        }

        public void ToggleRibbonUI(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ToggleRibbonUI", objArray1);
        }

        public State TranslateSceneModeToBoxState(SceneMgr.Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            return base.method_11<State>("TranslateSceneModeToBoxState", objArray1);
        }

        public BoxLightStateType TranslateSceneModeToLightState(SceneMgr.Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            return base.method_11<BoxLightStateType>("TranslateSceneModeToLightState", objArray1);
        }

        public void UnloadQuestLog()
        {
            base.method_8("UnloadQuestLog", Array.Empty<object>());
        }

        public void UpdateState()
        {
            base.method_8("UpdateState", Array.Empty<object>());
        }

        public void UpdateState_Closed()
        {
            base.method_8("UpdateState_Closed", Array.Empty<object>());
        }

        public void UpdateState_Error()
        {
            base.method_8("UpdateState_Error", Array.Empty<object>());
        }

        public void UpdateState_Hub()
        {
            base.method_8("UpdateState_Hub", Array.Empty<object>());
        }

        public void UpdateState_HubWithDrawer()
        {
            base.method_8("UpdateState_HubWithDrawer", Array.Empty<object>());
        }

        public void UpdateState_Loading()
        {
            base.method_8("UpdateState_Loading", Array.Empty<object>());
        }

        public void UpdateState_Open()
        {
            base.method_8("UpdateState_Open", Array.Empty<object>());
        }

        public void UpdateState_PressStart()
        {
            base.method_8("UpdateState_PressStart", Array.Empty<object>());
        }

        public void UpdateState_Startup()
        {
            base.method_8("UpdateState_Startup", Array.Empty<object>());
        }

        public void UpdateStateUsingConfig()
        {
            base.method_8("UpdateStateUsingConfig", Array.Empty<object>());
        }

        public bool UpdateTavernBrawlButtonState(bool highlightAllowed)
        {
            object[] objArray1 = new object[] { highlightAllowed };
            return base.method_11<bool>("UpdateTavernBrawlButtonState", objArray1);
        }

        public void UpdateUI(bool isInitialization)
        {
            object[] objArray1 = new object[] { isInitialization };
            base.method_8("UpdateUI", objArray1);
        }

        public void UpdateUIEvents()
        {
            base.method_8("UpdateUIEvents", Array.Empty<object>());
        }

        public void UpdateUIState(bool isInitialization)
        {
            object[] objArray1 = new object[] { isInitialization };
            base.method_8("UpdateUIState", objArray1);
        }

        public bool IsTavernBrawlButtonDeactivated
        {
            get
            {
                return base.method_11<bool>("get_IsTavernBrawlButtonDeactivated", Array.Empty<object>());
            }
        }

        public BoxSpinner m_BottomSpinner
        {
            get
            {
                return base.method_3<BoxSpinner>("m_BottomSpinner");
            }
        }

        public BoxCamera m_Camera
        {
            get
            {
                return base.method_3<BoxCamera>("m_Camera");
            }
        }

        public BoxMenuButton m_CollectionButton
        {
            get
            {
                return base.method_3<BoxMenuButton>("m_CollectionButton");
            }
        }

        public Color m_DisabledDrawerMaterial
        {
            get
            {
                return base.method_2<Color>("m_DisabledDrawerMaterial");
            }
        }

        public Color m_DisabledMaterial
        {
            get
            {
                return base.method_2<Color>("m_DisabledMaterial");
            }
        }

        public BoxDisk m_Disk
        {
            get
            {
                return base.method_3<BoxDisk>("m_Disk");
            }
        }

        public BoxDrawer m_Drawer
        {
            get
            {
                return base.method_3<BoxDrawer>("m_Drawer");
            }
        }

        public GameObject m_EmptyFourthButton
        {
            get
            {
                return base.method_3<GameObject>("m_EmptyFourthButton");
            }
        }

        public Color m_EnabledDrawerMaterial
        {
            get
            {
                return base.method_2<Color>("m_EnabledDrawerMaterial");
            }
        }

        public Color m_EnabledMaterial
        {
            get
            {
                return base.method_2<Color>("m_EnabledMaterial");
            }
        }

        public BoxEventMgr m_EventMgr
        {
            get
            {
                return base.method_3<BoxEventMgr>("m_EventMgr");
            }
        }

        public BoxMenuButton m_ForgeButton
        {
            get
            {
                return base.method_3<BoxMenuButton>("m_ForgeButton");
            }
        }

        public BoxDoor m_LeftDoor
        {
            get
            {
                return base.method_3<BoxDoor>("m_LeftDoor");
            }
        }

        public GameObject m_letterboxingContainer
        {
            get
            {
                return base.method_3<GameObject>("m_letterboxingContainer");
            }
        }

        public BoxLightMgr m_LightMgr
        {
            get
            {
                return base.method_3<BoxLightMgr>("m_LightMgr");
            }
        }

        public BoxLogo m_Logo
        {
            get
            {
                return base.method_3<BoxLogo>("m_Logo");
            }
        }

        public Camera m_NoFxCamera
        {
            get
            {
                return base.method_3<Camera>("m_NoFxCamera");
            }
        }

        public PackOpeningButton m_OpenPacksButton
        {
            get
            {
                return base.method_3<PackOpeningButton>("m_OpenPacksButton");
            }
        }

        public GameLayer m_originalDrawerLayer
        {
            get
            {
                return base.method_2<GameLayer>("m_originalDrawerLayer");
            }
        }

        public GameLayer m_originalLeftDoorLayer
        {
            get
            {
                return base.method_2<GameLayer>("m_originalLeftDoorLayer");
            }
        }

        public GameLayer m_originalRightDoorLayer
        {
            get
            {
                return base.method_2<GameLayer>("m_originalRightDoorLayer");
            }
        }

        public GameObject m_OuterFrame
        {
            get
            {
                return base.method_3<GameObject>("m_OuterFrame");
            }
        }

        public int m_pendingEffects
        {
            get
            {
                return base.method_2<int>("m_pendingEffects");
            }
        }

        public QuestLog m_questLog
        {
            get
            {
                return base.method_3<QuestLog>("m_questLog");
            }
        }

        public QuestLogButton m_QuestLogButton
        {
            get
            {
                return base.method_3<QuestLogButton>("m_QuestLogButton");
            }
        }

        public bool m_questLogLoading
        {
            get
            {
                return base.method_2<bool>("m_questLogLoading");
            }
        }

        public DataState m_questLogNetCacheDataState
        {
            get
            {
                return base.method_2<DataState>("m_questLogNetCacheDataState");
            }
        }

        public RibbonButtonsUI m_ribbonButtons
        {
            get
            {
                return base.method_3<RibbonButtonsUI>("m_ribbonButtons");
            }
        }

        public BoxDoor m_RightDoor
        {
            get
            {
                return base.method_3<BoxDoor>("m_RightDoor");
            }
        }

        public GameObject m_rootObject
        {
            get
            {
                return base.method_3<GameObject>("m_rootObject");
            }
        }

        public bool m_showRibbonButtons
        {
            get
            {
                return base.method_2<bool>("m_showRibbonButtons");
            }
        }

        public BoxMenuButton m_SoloAdventuresButton
        {
            get
            {
                return base.method_3<BoxMenuButton>("m_SoloAdventuresButton");
            }
        }

        public BoxStartButton m_StartButton
        {
            get
            {
                return base.method_3<BoxStartButton>("m_StartButton");
            }
        }

        public State m_state
        {
            get
            {
                return base.method_2<State>("m_state");
            }
        }

        public List<BoxStateConfig> m_stateConfigs
        {
            get
            {
                Class247<BoxStateConfig> class2 = base.method_3<Class247<BoxStateConfig>>("m_stateConfigs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public BoxStateInfoList m_StateInfoList
        {
            get
            {
                return base.method_3<BoxStateInfoList>("m_StateInfoList");
            }
        }

        public StoreButton m_StoreButton
        {
            get
            {
                return base.method_3<StoreButton>("m_StoreButton");
            }
        }

        public GameObject m_tableTop
        {
            get
            {
                return base.method_3<GameObject>("m_tableTop");
            }
        }

        public string m_tavernBrawlActivateSound
        {
            get
            {
                return base.method_4("m_tavernBrawlActivateSound");
            }
        }

        public TavernBrawlMenuButton m_TavernBrawlButton
        {
            get
            {
                return base.method_3<TavernBrawlMenuButton>("m_TavernBrawlButton");
            }
        }

        public GameObject m_TavernBrawlButtonActivateFX
        {
            get
            {
                return base.method_3<GameObject>("m_TavernBrawlButtonActivateFX");
            }
        }

        public GameObject m_TavernBrawlButtonDeactivateFX
        {
            get
            {
                return base.method_3<GameObject>("m_TavernBrawlButtonDeactivateFX");
            }
        }

        public GameObject m_TavernBrawlButtonVisual
        {
            get
            {
                return base.method_3<GameObject>("m_TavernBrawlButtonVisual");
            }
        }

        public string m_tavernBrawlDeactivateSound
        {
            get
            {
                return base.method_4("m_tavernBrawlDeactivateSound");
            }
        }

        public string m_tavernBrawlPopdownSound
        {
            get
            {
                return base.method_4("m_tavernBrawlPopdownSound");
            }
        }

        public string m_tavernBrawlPopupSound
        {
            get
            {
                return base.method_4("m_tavernBrawlPopupSound");
            }
        }

        public GameObject m_tempInputBlocker
        {
            get
            {
                return base.method_3<GameObject>("m_tempInputBlocker");
            }
        }

        public BoxSpinner m_TopSpinner
        {
            get
            {
                return base.method_3<BoxSpinner>("m_TopSpinner");
            }
        }

        public BoxMenuButton m_TournamentButton
        {
            get
            {
                return base.method_3<BoxMenuButton>("m_TournamentButton");
            }
        }

        public bool m_transitioningToSceneMode
        {
            get
            {
                return base.method_2<bool>("m_transitioningToSceneMode");
            }
        }

        public bool m_waitingForNetData
        {
            get
            {
                return base.method_2<bool>("m_waitingForNetData");
            }
        }

        public bool m_waitingForSceneLoad
        {
            get
            {
                return base.method_2<bool>("m_waitingForSceneLoad");
            }
        }

        public static string SHOW_LOG_COROUTINE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Box", "SHOW_LOG_COROUTINE");
            }
        }

        [Attribute38("Box.BoxStateConfig")]
        public class BoxStateConfig : MonoClass
        {
            public BoxStateConfig(IntPtr address) : this(address, "BoxStateConfig")
            {
            }

            public BoxStateConfig(IntPtr address, string className) : base(address, className)
            {
            }
        }

        public enum ButtonType
        {
            START,
            TOURNAMENT,
            ADVENTURE,
            FORGE,
            OPEN_PACKS,
            COLLECTION,
            TAVERN_BRAWL
        }

        public enum DataState
        {
            NONE,
            REQUEST_SENT,
            RECEIVED,
            UNLOADING
        }

        public enum State
        {
            INVALID,
            STARTUP,
            PRESS_START,
            LOADING,
            HUB,
            HUB_WITH_DRAWER,
            OPEN,
            CLOSED,
            ERROR
        }
    }
}

