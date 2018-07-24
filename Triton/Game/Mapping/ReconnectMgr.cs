namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ReconnectMgr")]
    public class ReconnectMgr : MonoBehaviour
    {
        public ReconnectMgr(IntPtr address) : this(address, "ReconnectMgr")
        {
        }

        public ReconnectMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void AckNotice(NetCache.ProfileNoticeDisconnectedGame notice)
        {
            object[] objArray1 = new object[] { notice };
            base.method_8("AckNotice", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ChangeDialogToReconnected()
        {
            base.method_8("ChangeDialogToReconnected", Array.Empty<object>());
        }

        public void ChangeDialogToTimeout()
        {
            base.method_8("ChangeDialogToTimeout", Array.Empty<object>());
        }

        public void CheckReconnectTimeout()
        {
            base.method_8("CheckReconnectTimeout", Array.Empty<object>());
        }

        public void ClearReconnectData()
        {
            base.method_8("ClearReconnectData", Array.Empty<object>());
        }

        public void FireTimeoutEvent()
        {
            base.method_8("FireTimeoutEvent", Array.Empty<object>());
        }

        public static ReconnectMgr Get()
        {
            return MonoClass.smethod_15<ReconnectMgr>(TritonHs.MainAssemblyPath, "", "ReconnectMgr", "Get", Array.Empty<object>());
        }

        public NetCache.ProfileNoticeDisconnectedGame GetDCGameNotice()
        {
            return base.method_14<NetCache.ProfileNoticeDisconnectedGame>("GetDCGameNotice", Array.Empty<object>());
        }

        public string GetGameTypeName(GameType gameType, int missionId)
        {
            object[] objArray1 = new object[] { gameType, missionId };
            return base.method_13("GetGameTypeName", objArray1);
        }

        public float GetRetryTime()
        {
            return base.method_11<float>("GetRetryTime", Array.Empty<object>());
        }

        public float GetTimeout()
        {
            return base.method_11<float>("GetTimeout", Array.Empty<object>());
        }

        public void HideDialog()
        {
            base.method_8("HideDialog", Array.Empty<object>());
        }

        public bool IsReconnectEnabled()
        {
            return base.method_11<bool>("IsReconnectEnabled", Array.Empty<object>());
        }

        public bool IsReconnecting()
        {
            return base.method_11<bool>("IsReconnecting", Array.Empty<object>());
        }

        public bool IsStartingReconnectGame()
        {
            return base.method_11<bool>("IsStartingReconnectGame", Array.Empty<object>());
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

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
        }

        public void OnGameResult(NetCache.ProfileNoticeDisconnectedGame dcGameNotice)
        {
            object[] objArray1 = new object[] { dcGameNotice };
            base.method_8("OnGameResult", objArray1);
        }

        public void OnNetCacheReady()
        {
            base.method_8("OnNetCacheReady", Array.Empty<object>());
        }

        public void OnPreviousSceneDestroyed(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnPreviousSceneDestroyed", objArray1);
        }

        public bool OnReconnectingDialogProcessed(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnReconnectingDialogProcessed", objArray1);
        }

        public void OnReconnectingDialogResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnReconnectingDialogResponse", objArray1);
        }

        public void OnReconnectTimeout()
        {
            base.method_8("OnReconnectTimeout", Array.Empty<object>());
        }

        public void OnTimeoutDialogResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnTimeoutDialogResponse", objArray1);
        }

        public bool ReconnectFromGameplay()
        {
            return base.method_11<bool>("ReconnectFromGameplay", Array.Empty<object>());
        }

        public bool ReconnectFromLogin()
        {
            return base.method_11<bool>("ReconnectFromLogin", Array.Empty<object>());
        }

        public bool ShowDisconnectedGameResult(NetCache.ProfileNoticeDisconnectedGame dcGame)
        {
            object[] objArray1 = new object[] { dcGame };
            return base.method_11<bool>("ShowDisconnectedGameResult", objArray1);
        }

        public void ShowReconnectingDialog()
        {
            base.method_8("ShowReconnectingDialog", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartGame()
        {
            base.method_9("StartGame", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void StartReconnecting(ReconnectType reconnectType)
        {
            object[] objArray1 = new object[] { reconnectType };
            base.method_8("StartReconnecting", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public AlertPopup m_dialog
        {
            get
            {
                return base.method_3<AlertPopup>("m_dialog");
            }
        }

        public NetCache.ProfileNoticeDisconnectedGame m_pendingReconnectNotice
        {
            get
            {
                return base.method_3<NetCache.ProfileNoticeDisconnectedGame>("m_pendingReconnectNotice");
            }
        }

        public float m_reconnectStartTimestamp
        {
            get
            {
                return base.method_2<float>("m_reconnectStartTimestamp");
            }
        }

        public ReconnectType m_reconnectType
        {
            get
            {
                return base.method_2<ReconnectType>("m_reconnectType");
            }
        }

        public float m_retryStartTimestamp
        {
            get
            {
                return base.method_2<float>("m_retryStartTimestamp");
            }
        }

        public SavedStartGameParameters m_savedStartGameParams
        {
            get
            {
                return base.method_3<SavedStartGameParameters>("m_savedStartGameParams");
            }
        }

        [Attribute38("ReconnectMgr.SavedStartGameParameters")]
        public class SavedStartGameParameters : MonoClass
        {
            public SavedStartGameParameters(IntPtr address) : this(address, "SavedStartGameParameters")
            {
            }

            public SavedStartGameParameters(IntPtr address, string className) : base(address, className)
            {
            }

            public Triton.Game.Mapping.GameType GameType
            {
                get
                {
                    return base.method_2<Triton.Game.Mapping.GameType>("GameType");
                }
            }

            public Triton.Game.Mapping.ReconnectType ReconnectType
            {
                get
                {
                    return base.method_2<Triton.Game.Mapping.ReconnectType>("ReconnectType");
                }
            }
        }
    }
}

