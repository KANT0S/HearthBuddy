namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SpectatorManager")]
    public class SpectatorManager : MonoClass
    {
        public SpectatorManager(IntPtr address) : this(address, "SpectatorManager")
        {
        }

        public SpectatorManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void AutoSpectateOpposingSide()
        {
            base.method_8("AutoSpectateOpposingSide", Array.Empty<object>());
        }

        public void BnetFriendMgr_OnFriendsChanged(BnetFriendChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("BnetFriendMgr_OnFriendsChanged", objArray1);
        }

        public void BnetParty_OnLostPartyReference_RemoveKnownCreator(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("BnetParty_OnLostPartyReference_RemoveKnownCreator", objArray1);
        }

        public bool CanAddSpectators()
        {
            return base.method_11<bool>("CanAddSpectators", Array.Empty<object>());
        }

        public bool CanSpectate(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("CanSpectate", objArray1);
        }

        public void ClearAllGameServerKnownSpectators()
        {
            base.method_8("ClearAllGameServerKnownSpectators", Array.Empty<object>());
        }

        public void ClearAllReceivedInvitations()
        {
            base.method_8("ClearAllReceivedInvitations", Array.Empty<object>());
        }

        public void ClearAllSentInvitations()
        {
            base.method_8("ClearAllSentInvitations", Array.Empty<object>());
        }

        public void CloseWaitingForNextGameDialog()
        {
            base.method_8("CloseWaitingForNextGameDialog", Array.Empty<object>());
        }

        public static SpectatorManager CreateInstance()
        {
            return MonoClass.smethod_15<SpectatorManager>(TritonHs.MainAssemblyPath, "", "SpectatorManager", "CreateInstance", Array.Empty<object>());
        }

        public bool CreatePartyIfNecessary()
        {
            return base.method_11<bool>("CreatePartyIfNecessary", Array.Empty<object>());
        }

        public void DeclineAllReceivedInvitations()
        {
            base.method_8("DeclineAllReceivedInvitations", Array.Empty<object>());
        }

        public static void DisplayErrorDialog(string header, string body)
        {
            object[] objArray1 = new object[] { header, body };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SpectatorManager", "DisplayErrorDialog", objArray1);
        }

        public void EndCurrentSpectatedGame(bool isLeavingGameplay)
        {
            object[] objArray1 = new object[] { isLeavingGameplay };
            base.method_8("EndCurrentSpectatedGame", objArray1);
        }

        public void EndGameScreen_OnTwoScoopsShown(bool shown, EndGameTwoScoop twoScoops)
        {
            object[] objArray1 = new object[] { shown, twoScoops };
            base.method_8("EndGameScreen_OnTwoScoopsShown", objArray1);
        }

        public void EndGameScreen_OnTwoScoopsShown_AutoClose(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("EndGameScreen_OnTwoScoopsShown_AutoClose", objArray1);
        }

        public void EndSpectatorMode(bool wasKnownSpectating)
        {
            object[] objArray1 = new object[] { wasKnownSpectating };
            base.method_8("EndSpectatorMode", objArray1);
        }

        public void EnterSpectatorMode_OnTransitionPopupHide(TransitionPopup popup)
        {
            object[] objArray1 = new object[] { popup };
            base.method_8("EnterSpectatorMode_OnTransitionPopupHide", objArray1);
        }

        public void GameState_CreateGameEvent(GameState.CreateGamePhase createGamePhase, object userData)
        {
            object[] objArray1 = new object[] { createGamePhase, userData };
            base.method_8("GameState_CreateGameEvent", objArray1);
        }

        public void GameState_InitializedEvent(GameState instance, object userData)
        {
            object[] objArray1 = new object[] { instance, userData };
            base.method_8("GameState_InitializedEvent", objArray1);
        }

        public static SpectatorManager Get()
        {
            return MonoClass.smethod_15<SpectatorManager>(TritonHs.MainAssemblyPath, "", "SpectatorManager", "Get", Array.Empty<object>());
        }

        public int GetCountSpectatingMe()
        {
            return base.method_11<int>("GetCountSpectatingMe", Array.Empty<object>());
        }

        public string GetWaitingForNextGameDialogText()
        {
            return base.method_13("GetWaitingForNextGameDialogText", Array.Empty<object>());
        }

        public bool HandleDisconnectFromGameplay()
        {
            return base.method_11<bool>("HandleDisconnectFromGameplay", Array.Empty<object>());
        }

        public bool HasAnyReceivedInvites()
        {
            return base.method_11<bool>("HasAnyReceivedInvites", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public void InviteToSpectateMe(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("InviteToSpectateMe", objArray1);
        }

        public bool IsBeingSpectated()
        {
            return base.method_11<bool>("IsBeingSpectated", Array.Empty<object>());
        }

        public bool IsInSpectatableGame()
        {
            return base.method_11<bool>("IsInSpectatableGame", Array.Empty<object>());
        }

        public bool IsInSpectatorMode()
        {
            return base.method_11<bool>("IsInSpectatorMode", Array.Empty<object>());
        }

        public bool IsSpectatingOpposingSide()
        {
            return base.method_11<bool>("IsSpectatingOpposingSide", Array.Empty<object>());
        }

        public static bool IsSpectatorSlotAvailable(BnetGameAccount gameAccount)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { gameAccount };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "SpectatorManager", "IsSpectatorSlotAvailable", enumArray1, objArray1);
        }

        public void KickSpectator(BnetPlayer player, bool regenerateSpectatorPassword)
        {
            object[] objArray1 = new object[] { player, regenerateSpectatorPassword };
            base.method_8("KickSpectator", objArray1);
        }

        public void KickSpectator_Internal(BnetPlayer player, bool regenerateSpectatorPassword, bool addToKickList)
        {
            object[] objArray1 = new object[] { player, regenerateSpectatorPassword, addToKickList };
            base.method_8("KickSpectator_Internal", objArray1);
        }

        public void LeaveGameScene()
        {
            base.method_8("LeaveGameScene", Array.Empty<object>());
        }

        public void LeaveSpectatorMode()
        {
            base.method_8("LeaveSpectatorMode", Array.Empty<object>());
        }

        public bool MyGameHasSpectators()
        {
            return base.method_11<bool>("MyGameHasSpectators", Array.Empty<object>());
        }

        public void Network_OnSpectatorInviteReceived_ResponseCallback(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("Network_OnSpectatorInviteReceived_ResponseCallback", objArray1);
        }

        public void Network_OnSpectatorNotifyEvent()
        {
            base.method_8("Network_OnSpectatorNotifyEvent", Array.Empty<object>());
        }

        public void Network_OnSpectatorNotifyEvent_Removed_GoToNextMode(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("Network_OnSpectatorNotifyEvent_Removed_GoToNextMode", objArray1);
        }

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
        }

        public void OnRealTimeGameOver()
        {
            base.method_8("OnRealTimeGameOver", Array.Empty<object>());
        }

        public void OnSceneUnloaded(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("OnSceneUnloaded", objArray1);
        }

        public bool OnSceneUnloaded_AwaitingNextGame_DialogProcessCallback(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnSceneUnloaded_AwaitingNextGame_DialogProcessCallback", objArray1);
        }

        public void OnSceneUnloaded_AwaitingNextGame_LeaveSpectatorMode(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnSceneUnloaded_AwaitingNextGame_LeaveSpectatorMode", objArray1);
        }

        public void OnSpectatorOpenJoinOptionChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnSpectatorOpenJoinOptionChanged", objArray1);
        }

        public void PruneOldInvites()
        {
            base.method_8("PruneOldInvites", Array.Empty<object>());
        }

        public void ReceivedInvitation_ExpireTimeout(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("ReceivedInvitation_ExpireTimeout", objArray1);
        }

        public void ReinviteKnownSpectatorsNotInParty()
        {
            base.method_8("ReinviteKnownSpectatorsNotInParty", Array.Empty<object>());
        }

        public void ResetAllCache()
        {
            base.method_8("ResetAllCache", Array.Empty<object>());
        }

        public void RevokeAllSentInvitations()
        {
            base.method_8("RevokeAllSentInvitations", Array.Empty<object>());
        }

        public bool ShouldBeSpectatingInGame()
        {
            return base.method_11<bool>("ShouldBeSpectatingInGame", Array.Empty<object>());
        }

        public void ShowWaitingForNextGameDialog()
        {
            base.method_8("ShowWaitingForNextGameDialog", Array.Empty<object>());
        }

        public void SpectatePlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("SpectatePlayer", objArray1);
        }

        public void SpectatePlayer_RequestInvite_FriendlySide_Timeout(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("SpectatePlayer_RequestInvite_FriendlySide_Timeout", objArray1);
        }

        public void SpectatePlayer_RequestInvite_OpposingSide_Timeout(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("SpectatePlayer_RequestInvite_OpposingSide_Timeout", objArray1);
        }

        public void SpectatorManager_UpdatePresenceNextFrame(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("SpectatorManager_UpdatePresenceNextFrame", objArray1);
        }

        public void UpdateMySpectatorInfo()
        {
            base.method_8("UpdateMySpectatorInfo", Array.Empty<object>());
        }

        public void UpdateSpectatorPartyServerInfo()
        {
            base.method_8("UpdateSpectatorPartyServerInfo", Array.Empty<object>());
        }

        public void UpdateSpectatorPresence()
        {
            base.method_8("UpdateSpectatorPresence", Array.Empty<object>());
        }

        public void UpdateWaitingForNextGameDialog()
        {
            base.method_8("UpdateWaitingForNextGameDialog", Array.Empty<object>());
        }

        public static void WaitingForNextGame_AutoLeaveSpectatorMode(object userData)
        {
            object[] objArray1 = new object[] { userData };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SpectatorManager", "WaitingForNextGame_AutoLeaveSpectatorMode", objArray1);
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public static string ALERTPOPUPID_WAITINGFORNEXTGAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "SpectatorManager", "ALERTPOPUPID_WAITINGFORNEXTGAME");
            }
        }

        public static float ENDGAMESCREEN_AUTO_CLOSE_SECONDS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SpectatorManager", "ENDGAMESCREEN_AUTO_CLOSE_SECONDS");
            }
        }

        public static bool IsGameOver
        {
            get
            {
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SpectatorManager", "get_IsGameOver", Array.Empty<object>());
            }
        }

        public static float KICKED_FROM_SPECTATING_BLACKOUT_DURATION_SECONDS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SpectatorManager", "KICKED_FROM_SPECTATING_BLACKOUT_DURATION_SECONDS");
            }
        }

        public bool m_initialized
        {
            get
            {
                return base.method_2<bool>("m_initialized");
            }
        }

        public bool m_isExpectingArriveInGameplayAsSpectator
        {
            get
            {
                return base.method_2<bool>("m_isExpectingArriveInGameplayAsSpectator");
            }
        }

        public bool m_isShowingRemovedAsSpectatorPopup
        {
            get
            {
                return base.method_2<bool>("m_isShowingRemovedAsSpectatorPopup");
            }
        }

        public PendingSpectatePlayer m_pendingSpectatePlayerAfterLeave
        {
            get
            {
                return base.method_3<PendingSpectatePlayer>("m_pendingSpectatePlayerAfterLeave");
            }
        }

        public IntendedSpectateeParty m_requestedInvite
        {
            get
            {
                return base.method_3<IntendedSpectateeParty>("m_requestedInvite");
            }
        }

        public AlertPopup m_waitingForNextGameDialog
        {
            get
            {
                return base.method_3<AlertPopup>("m_waitingForNextGameDialog");
            }
        }

        public static int MAX_SPECTATORS_PER_SIDE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "SpectatorManager", "MAX_SPECTATORS_PER_SIDE");
            }
        }

        public static float RECEIVED_INVITE_TIMEOUT_SECONDS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SpectatorManager", "RECEIVED_INVITE_TIMEOUT_SECONDS");
            }
        }

        public static float REQUEST_INVITE_TIMEOUT_SECONDS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SpectatorManager", "REQUEST_INVITE_TIMEOUT_SECONDS");
            }
        }

        public static float SENT_INVITE_TIMEOUT_SECONDS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SpectatorManager", "SENT_INVITE_TIMEOUT_SECONDS");
            }
        }

        [Attribute38("SpectatorManager.IntendedSpectateeParty")]
        public class IntendedSpectateeParty : MonoClass
        {
            public IntendedSpectateeParty(IntPtr address) : this(address, "IntendedSpectateeParty")
            {
            }

            public IntendedSpectateeParty(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("SpectatorManager.PendingSpectatePlayer")]
        public class PendingSpectatePlayer : MonoClass
        {
            public PendingSpectatePlayer(IntPtr address) : this(address, "PendingSpectatePlayer")
            {
            }

            public PendingSpectatePlayer(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ReceivedInvite
        {
            public float m_timestamp;
        }
    }
}

