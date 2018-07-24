namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FriendChallengeMgr")]
    public class FriendChallengeMgr : MonoClass
    {
        public FriendChallengeMgr(IntPtr address) : this(address, "FriendChallengeMgr")
        {
        }

        public FriendChallengeMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void AcceptChallenge()
        {
            base.method_8("AcceptChallenge", Array.Empty<object>());
        }

        public bool AmIAvailable()
        {
            return base.method_11<bool>("AmIAvailable", Array.Empty<object>());
        }

        public void CancelChallenge()
        {
            base.method_8("CancelChallenge", Array.Empty<object>());
        }

        public bool CanChallenge(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("CanChallenge", objArray1);
        }

        public bool CanPromptReceivedChallenge()
        {
            return base.method_11<bool>("CanPromptReceivedChallenge", Array.Empty<object>());
        }

        public void CleanUpChallengeData(bool updateAvailability)
        {
            object[] objArray1 = new object[] { updateAvailability };
            base.method_8("CleanUpChallengeData", objArray1);
        }

        public void DeclineChallenge()
        {
            base.method_8("DeclineChallenge", Array.Empty<object>());
        }

        public void DeselectDeck()
        {
            base.method_8("DeselectDeck", Array.Empty<object>());
        }

        public bool DidISelectDeck()
        {
            return base.method_11<bool>("DidISelectDeck", Array.Empty<object>());
        }

        public bool DidOpponentSelectDeck()
        {
            return base.method_11<bool>("DidOpponentSelectDeck", Array.Empty<object>());
        }

        public bool DidReceiveChallenge()
        {
            return base.method_11<bool>("DidReceiveChallenge", Array.Empty<object>());
        }

        public bool DidSendChallenge()
        {
            return base.method_11<bool>("DidSendChallenge", Array.Empty<object>());
        }

        public void FireChangedEvent(FriendChallengeEvent challengeEvent, BnetPlayer player)
        {
            object[] objArray1 = new object[] { challengeEvent, player };
            base.method_8("FireChangedEvent", objArray1);
        }

        public static FriendChallengeMgr Get()
        {
            return MonoClass.smethod_15<FriendChallengeMgr>(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "Get", Array.Empty<object>());
        }

        public FriendListAvailabilityBlockerReasons GetAvailabilityBlockerReason()
        {
            return base.method_11<FriendListAvailabilityBlockerReasons>("GetAvailabilityBlockerReason", Array.Empty<object>());
        }

        public BnetPlayer GetChallengee()
        {
            return base.method_14<BnetPlayer>("GetChallengee", Array.Empty<object>());
        }

        public BnetPlayer GetChallenger()
        {
            return base.method_14<BnetPlayer>("GetChallenger", Array.Empty<object>());
        }

        public BnetPlayer GetMyOpponent()
        {
            return base.method_14<BnetPlayer>("GetMyOpponent", Array.Empty<object>());
        }

        public BnetPlayer GetOpponent(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_14<BnetPlayer>("GetOpponent", objArray1);
        }

        public int GetScenarioId()
        {
            return base.method_11<int>("GetScenarioId", Array.Empty<object>());
        }

        public bool HasAvailabilityBlocker()
        {
            return base.method_11<bool>("HasAvailabilityBlocker", Array.Empty<object>());
        }

        public bool HasChallenge()
        {
            return base.method_11<bool>("HasChallenge", Array.Empty<object>());
        }

        public bool IsChallengeTavernBrawl()
        {
            return base.method_11<bool>("IsChallengeTavernBrawl", Array.Empty<object>());
        }

        public void OnChallengeChanged(FriendChallengeEvent challengeEvent, BnetPlayer player, object userData)
        {
            object[] objArray1 = new object[] { challengeEvent, player, userData };
            base.method_8("OnChallengeChanged", objArray1);
        }

        public bool OnChallengeReceivedDialogProcessed(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnChallengeReceivedDialogProcessed", objArray1);
        }

        public void OnChallengeReceivedDialogResponse(bool accept)
        {
            object[] objArray1 = new object[] { accept };
            base.method_8("OnChallengeReceivedDialogResponse", objArray1);
        }

        public bool OnChallengeSentDialogProcessed(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnChallengeSentDialogProcessed", objArray1);
        }

        public void OnChallengeSentDialogResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnChallengeSentDialogResponse", objArray1);
        }

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
        }

        public void OnFriendsChanged(BnetFriendChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnFriendsChanged", objArray1);
        }

        public void OnLoggedIn()
        {
            base.method_8("OnLoggedIn", Array.Empty<object>());
        }

        public void OnNearbyPlayersChanged(BnetNearbyPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnNearbyPlayersChanged", objArray1);
        }

        public void OnNetCacheReady()
        {
            base.method_8("OnNetCacheReady", Array.Empty<object>());
        }

        public void OnPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnPlayersChanged", objArray1);
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void OnSceneUnloaded(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("OnSceneUnloaded", objArray1);
        }

        public void OnStoreClosed()
        {
            base.method_8("OnStoreClosed", Array.Empty<object>());
        }

        public void OnStoreOpened()
        {
            base.method_8("OnStoreOpened", Array.Empty<object>());
        }

        public void RescindChallenge()
        {
            base.method_8("RescindChallenge", Array.Empty<object>());
        }

        public void ResolveChallengeConflict()
        {
            base.method_8("ResolveChallengeConflict", Array.Empty<object>());
        }

        public bool RevertTavernBrawlStatus()
        {
            return base.method_11<bool>("RevertTavernBrawlStatus", Array.Empty<object>());
        }

        public void SelectDeck(long deckId)
        {
            object[] objArray1 = new object[] { deckId };
            base.method_8("SelectDeck", objArray1);
        }

        public void SendChallenge(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("SendChallenge", objArray1);
        }

        public void ShowIReceivedChallengeDialog(BnetPlayer challenger)
        {
            object[] objArray1 = new object[] { challenger };
            base.method_8("ShowIReceivedChallengeDialog", objArray1);
        }

        public void ShowISentChallengeDialog(BnetPlayer challengee)
        {
            object[] objArray1 = new object[] { challengee };
            base.method_8("ShowISentChallengeDialog", objArray1);
        }

        public void ShowOpponentCanceledChallengeDialog(BnetPlayer otherPlayer)
        {
            object[] objArray1 = new object[] { otherPlayer };
            base.method_8("ShowOpponentCanceledChallengeDialog", objArray1);
        }

        public void ShowOpponentDeclinedChallengeDialog(BnetPlayer challengee)
        {
            object[] objArray1 = new object[] { challengee };
            base.method_8("ShowOpponentDeclinedChallengeDialog", objArray1);
        }

        public void ShowOpponentRemovedFromFriendsDialog(BnetPlayer otherPlayer)
        {
            object[] objArray1 = new object[] { otherPlayer };
            base.method_8("ShowOpponentRemovedFromFriendsDialog", objArray1);
        }

        public void SkipDeckSelection()
        {
            base.method_8("SkipDeckSelection", Array.Empty<object>());
        }

        public void StartChallengeProcess()
        {
            base.method_8("StartChallengeProcess", Array.Empty<object>());
        }

        public void TavernBrawl_ReceivedChallenge_OnEnsureServerDataReady()
        {
            base.method_8("TavernBrawl_ReceivedChallenge_OnEnsureServerDataReady", Array.Empty<object>());
        }

        public void TavernBrawl_ReceivedChallenge_OnEnsureServerDataReady_OnDeckContentsReady(long deckId)
        {
            object[] objArray1 = new object[] { deckId };
            base.method_8("TavernBrawl_ReceivedChallenge_OnEnsureServerDataReady_OnDeckContentsReady", objArray1);
        }

        public void UpdateChallengeSentDialog()
        {
            base.method_8("UpdateChallengeSentDialog", Array.Empty<object>());
        }

        public void UpdateMyAvailability()
        {
            base.method_8("UpdateMyAvailability", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public static string ATTRIBUTE_CB
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_CB");
            }
        }

        public static string ATTRIBUTE_DECK_PLAYER1
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_DECK_PLAYER1");
            }
        }

        public static string ATTRIBUTE_DECK_PLAYER2
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_DECK_PLAYER2");
            }
        }

        public static string ATTRIBUTE_DLL
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_DLL");
            }
        }

        public static string ATTRIBUTE_ERROR
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_ERROR");
            }
        }

        public static string ATTRIBUTE_LEFT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_LEFT");
            }
        }

        public static string ATTRIBUTE_PARM
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_PARM");
            }
        }

        public static string ATTRIBUTE_STATE_PLAYER1
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_STATE_PLAYER1");
            }
        }

        public static string ATTRIBUTE_STATE_PLAYER2
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_STATE_PLAYER2");
            }
        }

        public static string ATTRIBUTE_VALUE_STATE_DECK
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_VALUE_STATE_DECK");
            }
        }

        public static string ATTRIBUTE_VALUE_STATE_GAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_VALUE_STATE_GAME");
            }
        }

        public static string ATTRIBUTE_VALUE_STATE_GOTO
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_VALUE_STATE_GOTO");
            }
        }

        public static string ATTRIBUTE_VALUE_STATE_WAIT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "ATTRIBUTE_VALUE_STATE_WAIT");
            }
        }

        public static int DEFAULT_SCENARIO_ID
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "DEFAULT_SCENARIO_ID");
            }
        }

        public DialogBase m_challengeDialog
        {
            get
            {
                return base.method_3<DialogBase>("m_challengeDialog");
            }
        }

        public BnetPlayer m_challengee
        {
            get
            {
                return base.method_3<BnetPlayer>("m_challengee");
            }
        }

        public bool m_challengeeAccepted
        {
            get
            {
                return base.method_2<bool>("m_challengeeAccepted");
            }
        }

        public bool m_challengeeDeckSelected
        {
            get
            {
                return base.method_2<bool>("m_challengeeDeckSelected");
            }
        }

        public BnetPlayer m_challenger
        {
            get
            {
                return base.method_3<BnetPlayer>("m_challenger");
            }
        }

        public bool m_challengerDeckSelected
        {
            get
            {
                return base.method_2<bool>("m_challengerDeckSelected");
            }
        }

        public bool m_challengerPending
        {
            get
            {
                return base.method_2<bool>("m_challengerPending");
            }
        }

        public bool m_hasSeenDeclinedReason
        {
            get
            {
                return base.method_2<bool>("m_hasSeenDeclinedReason");
            }
        }

        public bool m_isChallengeTavernBrawl
        {
            get
            {
                return base.method_2<bool>("m_isChallengeTavernBrawl");
            }
        }

        public bool m_myPlayerReady
        {
            get
            {
                return base.method_2<bool>("m_myPlayerReady");
            }
        }

        public bool m_netCacheReady
        {
            get
            {
                return base.method_2<bool>("m_netCacheReady");
            }
        }

        public int m_scenarioId
        {
            get
            {
                return base.method_2<int>("m_scenarioId");
            }
        }

        public static float SPECTATE_GAME_SERVER_SETUP_TIMEOUT_SECONDS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FriendChallengeMgr", "SPECTATE_GAME_SERVER_SETUP_TIMEOUT_SECONDS");
            }
        }

        public enum DeclineReason
        {
            None,
            UserDeclined,
            NoValidDeck,
            NotUnlocked
        }

        public enum FriendListAvailabilityBlockerReasons
        {
            NONE,
            NETCACHE_NOT_READY,
            MY_PLAYER_NOT_READY,
            HAS_EXISTING_CHALLENGE,
            FINDING_GAME,
            HAS_FATAL_ERROR,
            LOGGING_IN,
            STARTING_UP,
            PLAYING_NON_AI_GAME,
            TUTORIALS_INCOMPLETE,
            STORE_IS_SHOWN,
            PLAYING_AI_GAME,
            SPECTATING_GAME,
            EDITING_TAVERN_BRAWL
        }
    }
}

