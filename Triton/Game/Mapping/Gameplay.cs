namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Gameplay")]
    public class Gameplay : Scene
    {
        public Gameplay(IntPtr address) : this(address, "Gameplay")
        {
        }

        public Gameplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddGamePlayNameBannerPhone()
        {
            base.method_8("AddGamePlayNameBannerPhone", Array.Empty<object>());
        }

        public bool AreCriticalAssetsLoaded()
        {
            return base.method_11<bool>("AreCriticalAssetsLoaded", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CheckCriticalAssetLoads()
        {
            return base.method_11<bool>("CheckCriticalAssetLoads", Array.Empty<object>());
        }

        public static Gameplay Get()
        {
            return MonoClass.smethod_15<Gameplay>(TritonHs.MainAssemblyPath, "", "Gameplay", "Get", Array.Empty<object>());
        }

        public Actor GetCardDrawStandIn()
        {
            return base.method_14<Actor>("GetCardDrawStandIn", Array.Empty<object>());
        }

        public void HandleDisconnect()
        {
            base.method_8("HandleDisconnect", Array.Empty<object>());
        }

        public void HandleLastFatalBnetError()
        {
            base.method_8("HandleLastFatalBnetError", Array.Empty<object>());
        }

        public void InitCardBacks()
        {
            base.method_8("InitCardBacks", Array.Empty<object>());
        }

        public bool IsDoneUpdatingGame()
        {
            return base.method_11<bool>("IsDoneUpdatingGame", Array.Empty<object>());
        }

        public bool IsHandlingNetworkProblem()
        {
            return base.method_11<bool>("IsHandlingNetworkProblem", Array.Empty<object>());
        }

        public bool IsLeavingGameUnfinished()
        {
            return base.method_11<bool>("IsLeavingGameUnfinished", Array.Empty<object>());
        }

        public bool IsUnloading()
        {
            return base.method_11<bool>("IsUnloading", Array.Empty<object>());
        }

        public void LayoutProgressGUI()
        {
            base.method_8("LayoutProgressGUI", Array.Empty<object>());
        }

        public void LayoutSpellControllerKillTimeGUI()
        {
            base.method_8("LayoutSpellControllerKillTimeGUI", Array.Empty<object>());
        }

        public void LoadBoard(Network.GameSetup setup)
        {
            object[] objArray1 = new object[] { setup };
            base.method_8("LoadBoard", objArray1);
        }

        public void OnAllOptions()
        {
            base.method_8("OnAllOptions", Array.Empty<object>());
        }

        public void OnBnetErrorResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnBnetErrorResponse", objArray1);
        }

        public void OnBoardCamerasLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnBoardCamerasLoaded", objArray1);
        }

        public void OnBoardLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnBoardLoaded", objArray1);
        }

        public void OnBoardProgressUpdate(string name, float progress, object callbackData)
        {
            object[] objArray1 = new object[] { name, progress, callbackData };
            base.method_8("OnBoardProgressUpdate", objArray1);
        }

        public void OnBoardStandardGameLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnBoardStandardGameLoaded", objArray1);
        }

        public void OnBoardTutorialLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnBoardTutorialLoaded", objArray1);
        }

        public void OnCardDrawStandinLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnCardDrawStandinLoaded", objArray1);
        }

        public void OnChoiceCardMgrLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnChoiceCardMgrLoaded", objArray1);
        }

        public void OnCreateGame(GameState.CreateGamePhase phase, object userData)
        {
            object[] objArray1 = new object[] { phase, userData };
            base.method_8("OnCreateGame", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnEndTurnButtonLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnEndTurnButtonLoaded", objArray1);
        }

        public void OnEntitiesChosen()
        {
            base.method_8("OnEntitiesChosen", Array.Empty<object>());
        }

        public void OnEntityChoices()
        {
            base.method_8("OnEntityChoices", Array.Empty<object>());
        }

        public void OnGameplayErrorManagerLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnGameplayErrorManagerLoaded", objArray1);
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public void OnInputManagerLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnInputManagerLoaded", objArray1);
        }

        public void OnMulliganManagerLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnMulliganManagerLoaded", objArray1);
        }

        public void OnOptionRejected()
        {
            base.method_8("OnOptionRejected", Array.Empty<object>());
        }

        public void OnPlayerBannerLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnPlayerBannerLoaded", objArray1);
        }

        public void OnPowerHistory()
        {
            base.method_8("OnPowerHistory", Array.Empty<object>());
        }

        public void OnRemoteActionHandlerLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnRemoteActionHandlerLoaded", objArray1);
        }

        public void OnSpectatorNotify()
        {
            base.method_8("OnSpectatorNotify", Array.Empty<object>());
        }

        public void OnTargetReticleManagerLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnTargetReticleManagerLoaded", objArray1);
        }

        public void OnTransitionFinished(bool cutoff, object userData)
        {
            object[] objArray1 = new object[] { cutoff, userData };
            base.method_8("OnTransitionFinished", objArray1);
        }

        public void OnTurnStartManagerLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnTurnStartManagerLoaded", objArray1);
        }

        public void OnTurnTimerLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnTurnTimerLoaded", objArray1);
        }

        public void OnTurnTimerUpdate()
        {
            base.method_8("OnTurnTimerUpdate", Array.Empty<object>());
        }

        public void OnUserUI()
        {
            base.method_8("OnUserUI", Array.Empty<object>());
        }

        public void PreUnload()
        {
            base.method_8("PreUnload", Array.Empty<object>());
        }

        public void ProcessGameSetupPacket()
        {
            base.method_8("ProcessGameSetupPacket", Array.Empty<object>());
        }

        public void ProcessQueuedPowerHistory()
        {
            base.method_8("ProcessQueuedPowerHistory", Array.Empty<object>());
        }

        public void RemoveClassNames()
        {
            base.method_8("RemoveClassNames", Array.Empty<object>());
        }

        public void RemoveGamePlayNameBannerPhone()
        {
            base.method_8("RemoveGamePlayNameBannerPhone", Array.Empty<object>());
        }

        public void RemoveNameBanners()
        {
            base.method_8("RemoveNameBanners", Array.Empty<object>());
        }

        public void SetGameStateBusy(bool busy, float delay)
        {
            object[] objArray1 = new object[] { busy, delay };
            base.method_8("SetGameStateBusy", objArray1);
        }

        public bool ShouldHandleDisconnect()
        {
            return base.method_11<bool>("ShouldHandleDisconnect", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void SwapCardBacks()
        {
            base.method_8("SwapCardBacks", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateEnemySideNameBannerName(string newName)
        {
            object[] objArray1 = new object[] { newName };
            base.method_8("UpdateEnemySideNameBannerName", objArray1);
        }

        public void UpdateFriendlySideMedalChange(MedalInfoTranslator medalInfo)
        {
            object[] objArray1 = new object[] { medalInfo };
            base.method_8("UpdateFriendlySideMedalChange", objArray1);
        }

        public float m_boardProgress
        {
            get
            {
                return base.method_2<float>("m_boardProgress");
            }
        }

        public Actor m_cardDrawStandIn
        {
            get
            {
                return base.method_3<Actor>("m_cardDrawStandIn");
            }
        }

        public bool m_criticalAssetsLoaded
        {
            get
            {
                return base.method_2<bool>("m_criticalAssetsLoaded");
            }
        }

        public bool m_handleLastFatalBnetErrorNow
        {
            get
            {
                return base.method_2<bool>("m_handleLastFatalBnetErrorNow");
            }
        }

        public NameBannerGamePlayPhone m_nameBannerGamePlayPhone
        {
            get
            {
                return base.method_3<NameBannerGamePlayPhone>("m_nameBannerGamePlayPhone");
            }
        }

        public List<NameBanner> m_nameBanners
        {
            get
            {
                Class267<NameBanner> class2 = base.method_3<Class267<NameBanner>>("m_nameBanners");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_unloading
        {
            get
            {
                return base.method_2<bool>("m_unloading");
            }
        }

        public static float TIME_TO_SET_ASYNC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Gameplay", "TIME_TO_SET_ASYNC");
            }
        }
    }
}

