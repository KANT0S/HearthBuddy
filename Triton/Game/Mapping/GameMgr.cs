namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameMgr")]
    public class GameMgr : MonoClass
    {
        public GameMgr(IntPtr address) : this(address, "GameMgr")
        {
        }

        public GameMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CancelFindGame()
        {
            return base.method_11<bool>("CancelFindGame", Array.Empty<object>());
        }

        public void ChangeBoardIfNecessary()
        {
            base.method_8("ChangeBoardIfNecessary", Array.Empty<object>());
        }

        public bool ChangeFindGameState(FindGameState state)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { state };
            return base.method_10<bool>("ChangeFindGameState", enumArray1, objArray1);
        }

        public bool ChangeFindGameState(FindGameState state, Network.GameCancelInfo cancelInfo)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.Class };
            object[] objArray1 = new object[] { state, cancelInfo };
            return base.method_10<bool>("ChangeFindGameState", enumArray1, objArray1);
        }

        public GameEntity CreateGameEntity()
        {
            return base.method_14<GameEntity>("CreateGameEntity", Array.Empty<object>());
        }

        public void DestroyTransitionPopup()
        {
            base.method_8("DestroyTransitionPopup", Array.Empty<object>());
        }

        public string DetermineTransitionPopupForFindGame(GameType gameType, int missionId)
        {
            object[] objArray1 = new object[] { gameType, missionId };
            return base.method_13("DetermineTransitionPopupForFindGame", objArray1);
        }

        public void DoDefaultFindGameEventBehavior(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("DoDefaultFindGameEventBehavior", objArray1);
        }

        public void FinalizeState(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("FinalizeState", objArray1);
        }

        public void FindGame(GameType type, int missionId, long deckId, long aiDeckId)
        {
            object[] objArray1 = new object[] { type, missionId, deckId, aiDeckId };
            base.method_8("FindGame", objArray1);
        }

        public bool FireFindGameEvent(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            return base.method_11<bool>("FireFindGameEvent", objArray1);
        }

        public static GameMgr Get()
        {
            return MonoClass.smethod_15<GameMgr>(TritonHs.MainAssemblyPath, "", "GameMgr", "Get", Array.Empty<object>());
        }

        public FindGameState GetFindGameState()
        {
            return base.method_11<FindGameState>("GetFindGameState", Array.Empty<object>());
        }

        public Network.GameSetup GetGameSetup()
        {
            return base.method_14<Network.GameSetup>("GetGameSetup", Array.Empty<object>());
        }

        public GameType GetGameType()
        {
            return base.method_11<GameType>("GetGameType", Array.Empty<object>());
        }

        public uint GetLastEnterGameError()
        {
            return base.method_11<uint>("GetLastEnterGameError", Array.Empty<object>());
        }

        public int GetMissionId()
        {
            return base.method_11<int>("GetMissionId", Array.Empty<object>());
        }

        public GameType GetNextGameType()
        {
            return base.method_11<GameType>("GetNextGameType", Array.Empty<object>());
        }

        public int GetNextMissionId()
        {
            return base.method_11<int>("GetNextMissionId", Array.Empty<object>());
        }

        public ReconnectType GetNextReconnectType()
        {
            return base.method_11<ReconnectType>("GetNextReconnectType", Array.Empty<object>());
        }

        public SceneMgr.Mode GetPostDisconnectSceneMode()
        {
            return base.method_11<SceneMgr.Mode>("GetPostDisconnectSceneMode", Array.Empty<object>());
        }

        public SceneMgr.Mode GetPostGameSceneMode()
        {
            return base.method_11<SceneMgr.Mode>("GetPostGameSceneMode", Array.Empty<object>());
        }

        public GameType GetPreviousGameType()
        {
            return base.method_11<GameType>("GetPreviousGameType", Array.Empty<object>());
        }

        public int GetPreviousMissionId()
        {
            return base.method_11<int>("GetPreviousMissionId", Array.Empty<object>());
        }

        public ReconnectType GetPreviousReconnectType()
        {
            return base.method_11<ReconnectType>("GetPreviousReconnectType", Array.Empty<object>());
        }

        public ReconnectType GetReconnectType()
        {
            return base.method_11<ReconnectType>("GetReconnectType", Array.Empty<object>());
        }

        public TransitionPopup GetTransitionPopup()
        {
            return base.method_14<TransitionPopup>("GetTransitionPopup", Array.Empty<object>());
        }

        public void HandleGameCanceled()
        {
            base.method_8("HandleGameCanceled", Array.Empty<object>());
        }

        public void HideTransitionPopup()
        {
            base.method_8("HideTransitionPopup", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool IsAboutToStopFindingGame()
        {
            return base.method_11<bool>("IsAboutToStopFindingGame", Array.Empty<object>());
        }

        public bool IsAI()
        {
            return base.method_11<bool>("IsAI", Array.Empty<object>());
        }

        public bool IsArena()
        {
            return base.method_11<bool>("IsArena", Array.Empty<object>());
        }

        public bool IsClassChallengeMission()
        {
            return base.method_11<bool>("IsClassChallengeMission", Array.Empty<object>());
        }

        public bool IsClassicMission()
        {
            return base.method_11<bool>("IsClassicMission", Array.Empty<object>());
        }

        public bool IsExpansionMission()
        {
            return base.method_11<bool>("IsExpansionMission", Array.Empty<object>());
        }

        public bool IsFindingGame()
        {
            return base.method_11<bool>("IsFindingGame", Array.Empty<object>());
        }

        public bool IsFriendly()
        {
            return base.method_11<bool>("IsFriendly", Array.Empty<object>());
        }

        public bool IsNextAI()
        {
            return base.method_11<bool>("IsNextAI", Array.Empty<object>());
        }

        public bool IsNextArena()
        {
            return base.method_11<bool>("IsNextArena", Array.Empty<object>());
        }

        public bool IsNextClassicMission()
        {
            return base.method_11<bool>("IsNextClassicMission", Array.Empty<object>());
        }

        public bool IsNextExpansionMission()
        {
            return base.method_11<bool>("IsNextExpansionMission", Array.Empty<object>());
        }

        public bool IsNextFriendly()
        {
            return base.method_11<bool>("IsNextFriendly", Array.Empty<object>());
        }

        public bool IsNextPlay()
        {
            return base.method_11<bool>("IsNextPlay", Array.Empty<object>());
        }

        public bool IsNextPractice()
        {
            return base.method_11<bool>("IsNextPractice", Array.Empty<object>());
        }

        public bool IsNextRankedPlay()
        {
            return base.method_11<bool>("IsNextRankedPlay", Array.Empty<object>());
        }

        public bool IsNextReconnect()
        {
            return base.method_11<bool>("IsNextReconnect", Array.Empty<object>());
        }

        public bool IsNextSpectator()
        {
            return base.method_11<bool>("IsNextSpectator", Array.Empty<object>());
        }

        public bool IsNextTavernBrawl()
        {
            return base.method_11<bool>("IsNextTavernBrawl", Array.Empty<object>());
        }

        public bool IsNextTutorial()
        {
            return base.method_11<bool>("IsNextTutorial", Array.Empty<object>());
        }

        public bool IsNextUnrankedPlay()
        {
            return base.method_11<bool>("IsNextUnrankedPlay", Array.Empty<object>());
        }

        public bool IsPendingAutoConcede()
        {
            return base.method_11<bool>("IsPendingAutoConcede", Array.Empty<object>());
        }

        public bool IsPlay()
        {
            return base.method_11<bool>("IsPlay", Array.Empty<object>());
        }

        public bool IsPractice()
        {
            return base.method_11<bool>("IsPractice", Array.Empty<object>());
        }

        public bool IsPreviousReconnect()
        {
            return base.method_11<bool>("IsPreviousReconnect", Array.Empty<object>());
        }

        public bool IsRankedPlay()
        {
            return base.method_11<bool>("IsRankedPlay", Array.Empty<object>());
        }

        public bool IsReconnect()
        {
            return base.method_11<bool>("IsReconnect", Array.Empty<object>());
        }

        public bool IsSpectator()
        {
            return base.method_11<bool>("IsSpectator", Array.Empty<object>());
        }

        public bool IsTavernBrawl()
        {
            return base.method_11<bool>("IsTavernBrawl", Array.Empty<object>());
        }

        public bool IsTransitionPopupShown()
        {
            return base.method_11<bool>("IsTransitionPopupShown", Array.Empty<object>());
        }

        public bool IsTutorial()
        {
            return base.method_11<bool>("IsTutorial", Array.Empty<object>());
        }

        public bool IsUnrankedPlay()
        {
            return base.method_11<bool>("IsUnrankedPlay", Array.Empty<object>());
        }

        public void LoadTransitionPopup(string popupName)
        {
            object[] objArray1 = new object[] { popupName };
            base.method_8("LoadTransitionPopup", objArray1);
        }

        public void OnGameCanceled()
        {
            base.method_8("OnGameCanceled", Array.Empty<object>());
        }

        public void OnGameEnded()
        {
            base.method_8("OnGameEnded", Array.Empty<object>());
        }

        public void OnGameSetup()
        {
            base.method_8("OnGameSetup", Array.Empty<object>());
        }

        public void OnLoggedIn()
        {
            base.method_8("OnLoggedIn", Array.Empty<object>());
        }

        public bool OnReconnectTimeout(object userData)
        {
            object[] objArray1 = new object[] { userData };
            return base.method_11<bool>("OnReconnectTimeout", objArray1);
        }

        public void OnScenePreLoad(SceneMgr.Mode prevMode, SceneMgr.Mode mode, object userData)
        {
            object[] objArray1 = new object[] { prevMode, mode, userData };
            base.method_8("OnScenePreLoad", objArray1);
        }

        public void OnSceneUnloaded(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("OnSceneUnloaded", objArray1);
        }

        public void OnServerResult()
        {
            base.method_8("OnServerResult", Array.Empty<object>());
        }

        public void OnServerResult_Retry(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnServerResult_Retry", objArray1);
        }

        public void OnTransitionPopupCanceled()
        {
            base.method_8("OnTransitionPopupCanceled", Array.Empty<object>());
        }

        public void PreloadTransitionPopup()
        {
            base.method_8("PreloadTransitionPopup", Array.Empty<object>());
        }

        public void PreparePostGameSceneMode(SceneMgr.Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("PreparePostGameSceneMode", objArray1);
        }

        public void SetPendingAutoConcede(bool pendingAutoConcede)
        {
            object[] objArray1 = new object[] { pendingAutoConcede };
            base.method_8("SetPendingAutoConcede", objArray1);
        }

        public void ShowTransitionPopup(string popupName)
        {
            object[] objArray1 = new object[] { popupName };
            base.method_8("ShowTransitionPopup", objArray1);
        }

        public void UpdatePresence()
        {
            base.method_8("UpdatePresence", Array.Empty<object>());
        }

        public void WaitForFriendChallengeToStart(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            base.method_8("WaitForFriendChallengeToStart", objArray1);
        }

        public bool WasAI()
        {
            return base.method_11<bool>("WasAI", Array.Empty<object>());
        }

        public bool WasArena()
        {
            return base.method_11<bool>("WasArena", Array.Empty<object>());
        }

        public bool WasClassicMission()
        {
            return base.method_11<bool>("WasClassicMission", Array.Empty<object>());
        }

        public bool WasExpansionMission()
        {
            return base.method_11<bool>("WasExpansionMission", Array.Empty<object>());
        }

        public bool WasFriendly()
        {
            return base.method_11<bool>("WasFriendly", Array.Empty<object>());
        }

        public bool WasPlay()
        {
            return base.method_11<bool>("WasPlay", Array.Empty<object>());
        }

        public bool WasPractice()
        {
            return base.method_11<bool>("WasPractice", Array.Empty<object>());
        }

        public bool WasRankedPlay()
        {
            return base.method_11<bool>("WasRankedPlay", Array.Empty<object>());
        }

        public bool WasSpectator()
        {
            return base.method_11<bool>("WasSpectator", Array.Empty<object>());
        }

        public bool WasTutorial()
        {
            return base.method_11<bool>("WasTutorial", Array.Empty<object>());
        }

        public bool WasUnrankedPlay()
        {
            return base.method_11<bool>("WasUnrankedPlay", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public static string LOADING_POPUP_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameMgr", "LOADING_POPUP_NAME");
            }
        }

        public FindGameState m_findGameState
        {
            get
            {
                return base.method_2<FindGameState>("m_findGameState");
            }
        }

        public Network.GameSetup m_gameSetup
        {
            get
            {
                return base.method_3<Network.GameSetup>("m_gameSetup");
            }
        }

        public GameType m_gameType
        {
            get
            {
                return base.method_2<GameType>("m_gameType");
            }
        }

        public Vector3 m_initialTransitionPopupPos
        {
            get
            {
                return base.method_2<Vector3>("m_initialTransitionPopupPos");
            }
        }

        public uint m_lastEnterGameError
        {
            get
            {
                return base.method_2<uint>("m_lastEnterGameError");
            }
        }

        public int m_missionId
        {
            get
            {
                return base.method_2<int>("m_missionId");
            }
        }

        public GameType m_nextGameType
        {
            get
            {
                return base.method_2<GameType>("m_nextGameType");
            }
        }

        public int m_nextMissionId
        {
            get
            {
                return base.method_2<int>("m_nextMissionId");
            }
        }

        public ReconnectType m_nextReconnectType
        {
            get
            {
                return base.method_2<ReconnectType>("m_nextReconnectType");
            }
        }

        public bool m_nextSpectator
        {
            get
            {
                return base.method_2<bool>("m_nextSpectator");
            }
        }

        public bool m_pendingAutoConcede
        {
            get
            {
                return base.method_2<bool>("m_pendingAutoConcede");
            }
        }

        public GameType m_prevGameType
        {
            get
            {
                return base.method_2<GameType>("m_prevGameType");
            }
        }

        public int m_prevMissionId
        {
            get
            {
                return base.method_2<int>("m_prevMissionId");
            }
        }

        public ReconnectType m_prevReconnectType
        {
            get
            {
                return base.method_2<ReconnectType>("m_prevReconnectType");
            }
        }

        public bool m_prevSpectator
        {
            get
            {
                return base.method_2<bool>("m_prevSpectator");
            }
        }

        public ReconnectType m_reconnectType
        {
            get
            {
                return base.method_2<ReconnectType>("m_reconnectType");
            }
        }

        public bool m_spectator
        {
            get
            {
                return base.method_2<bool>("m_spectator");
            }
        }

        public TransitionPopup m_transitionPopup
        {
            get
            {
                return base.method_3<TransitionPopup>("m_transitionPopup");
            }
        }

        public static string MATCHING_POPUP_PC_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameMgr", "MATCHING_POPUP_PC_NAME");
            }
        }

        public static string MATCHING_POPUP_PHONE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameMgr", "MATCHING_POPUP_PHONE_NAME");
            }
        }
    }
}

