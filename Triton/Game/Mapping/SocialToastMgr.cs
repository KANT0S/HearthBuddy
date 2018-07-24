namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SocialToastMgr")]
    public class SocialToastMgr : MonoBehaviour
    {
        public SocialToastMgr(IntPtr address) : this(address, "SocialToastMgr")
        {
        }

        public SocialToastMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddToast(string textArg)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { textArg };
            base.method_9("AddToast", enumArray1, objArray1);
        }

        public void AddToast(string textArg, TOAST_TYPE toastType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { textArg, toastType };
            base.method_9("AddToast", enumArray1, objArray1);
        }

        public void AddToast(string textArg, TOAST_TYPE toastType, bool playSound)
        {
            object[] objArray1 = new object[] { textArg, toastType, playSound };
            base.method_9("AddToast", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void AddToast(string textArg, TOAST_TYPE toastType, float displayTime)
        {
            object[] objArray1 = new object[] { textArg, toastType, displayTime };
            base.method_9("AddToast", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void AddToast(string textArg, TOAST_TYPE toastType, float displayTime, bool playSound)
        {
            object[] objArray1 = new object[] { textArg, toastType, displayTime, playSound };
            base.method_9("AddToast", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CheckArenaGameStarted(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("CheckArenaGameStarted", objArray1);
        }

        public void CheckArenaRecordChanged(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("CheckArenaRecordChanged", objArray1);
        }

        public void CheckForCardOpened(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForCardOpened", objArray1);
        }

        public void CheckForDruidLevelChanged(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForDruidLevelChanged", objArray1);
        }

        public void CheckForHunterLevelChanged(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForHunterLevelChanged", objArray1);
        }

        public void CheckForMageLevelChanged(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForMageLevelChanged", objArray1);
        }

        public void CheckForMissionComplete(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForMissionComplete", objArray1);
        }

        public void CheckForNewRank(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("CheckForNewRank", objArray1);
        }

        public void CheckForOnlineStatusChanged(BnetPlayer oldPlayer, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayer, newPlayer };
            base.method_8("CheckForOnlineStatusChanged", objArray1);
        }

        public void CheckForPaladinLevelChanged(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForPaladinLevelChanged", objArray1);
        }

        public void CheckForPriestLevelChanged(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForPriestLevelChanged", objArray1);
        }

        public void CheckForRogueLevelChanged(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForRogueLevelChanged", objArray1);
        }

        public void CheckForShamanLevelChanged(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForShamanLevelChanged", objArray1);
        }

        public void CheckForWarlockLevelChanged(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForWarlockLevelChanged", objArray1);
        }

        public void CheckForWarriorLevelChanged(BnetGameAccount oldPlayerAccount, BnetGameAccount newPlayerAccount, BnetPlayer newPlayer)
        {
            object[] objArray1 = new object[] { oldPlayerAccount, newPlayerAccount, newPlayer };
            base.method_8("CheckForWarriorLevelChanged", objArray1);
        }

        public void DeactivateToast()
        {
            base.method_8("DeactivateToast", Array.Empty<object>());
        }

        public void FadeOutToast(float displayTime)
        {
            object[] objArray1 = new object[] { displayTime };
            base.method_8("FadeOutToast", objArray1);
        }

        public static SocialToastMgr Get()
        {
            return MonoClass.smethod_15<SocialToastMgr>(TritonHs.MainAssemblyPath, "", "SocialToastMgr", "Get", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFriendsChanged(BnetFriendChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnFriendsChanged", objArray1);
        }

        public void OnPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnPlayersChanged", objArray1);
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public bool ShouldToastThisLevel(int oldLevel, int newLevel)
        {
            object[] objArray1 = new object[] { oldLevel, newLevel };
            return base.method_11<bool>("ShouldToastThisLevel", objArray1);
        }

        public void ShutdownHandler(int minutes)
        {
            object[] objArray1 = new object[] { minutes };
            base.method_8("ShutdownHandler", objArray1);
        }

        public static float FADE_IN_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SocialToastMgr", "FADE_IN_TIME");
            }
        }

        public static float FADE_OUT_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SocialToastMgr", "FADE_OUT_TIME");
            }
        }

        public static float HOLD_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SocialToastMgr", "HOLD_TIME");
            }
        }

        public SocialToast m_socialToastPrefab
        {
            get
            {
                return base.method_3<SocialToast>("m_socialToastPrefab");
            }
        }

        public SocialToast m_toast
        {
            get
            {
                return base.method_3<SocialToast>("m_toast");
            }
        }

        public bool m_toastIsShown
        {
            get
            {
                return base.method_2<bool>("m_toastIsShown");
            }
        }

        public static float OFFLINE_TOAST_DELAY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SocialToastMgr", "OFFLINE_TOAST_DELAY");
            }
        }

        public static float SHUTDOWN_MESSAGE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SocialToastMgr", "SHUTDOWN_MESSAGE_TIME");
            }
        }

        [Attribute38("SocialToastMgr.LastOnlineTracker")]
        public class LastOnlineTracker : MonoClass
        {
            public LastOnlineTracker(IntPtr address) : this(address, "LastOnlineTracker")
            {
            }

            public LastOnlineTracker(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_localLastOnlineTime
            {
                get
                {
                    return base.method_2<float>("m_localLastOnlineTime");
                }
            }
        }

        public enum TOAST_TYPE
        {
            DEFAULT,
            FRIEND_ONLINE,
            FRIEND_OFFLINE,
            FRIEND_INVITE,
            HEALTHY_GAMING,
            HEALTHY_GAMING_OVER_THRESHOLD,
            FRIEND_ARENA_COMPLETE,
            SPECTATOR_INVITE_SENT,
            SPECTATOR_INVITE_RECEIVED,
            SPECTATOR_ADDED,
            SPECTATOR_REMOVED
        }
    }
}

