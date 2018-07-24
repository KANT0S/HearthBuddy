namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FriendListBaseFriendFrame")]
    public class FriendListBaseFriendFrame : MonoBehaviour
    {
        public FriendListBaseFriendFrame(IntPtr address) : this(address, "FriendListBaseFriendFrame")
        {
        }

        public FriendListBaseFriendFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public BnetPlayer GetFriend()
        {
            return base.method_14<BnetPlayer>("GetFriend", Array.Empty<object>());
        }

        public Network.RecruitInfo GetRecruitInfo()
        {
            return base.method_14<Network.RecruitInfo>("GetRecruitInfo", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnPlayerChatInfoChanged(PlayerChatInfo chatInfo, object userData)
        {
            object[] objArray1 = new object[] { chatInfo, userData };
            base.method_8("OnPlayerChatInfoChanged", objArray1);
        }

        public void OnPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnPlayersChanged", objArray1);
        }

        public void OnRecruitsChanged()
        {
            base.method_8("OnRecruitsChanged", Array.Empty<object>());
        }

        public void RankMedalOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("RankMedalOver", objArray1);
        }

        public bool SetFriend(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("SetFriend", objArray1);
        }

        public void UpdateFriend()
        {
            base.method_8("UpdateFriend", Array.Empty<object>());
        }

        public void UpdateOfflineStatus()
        {
            base.method_8("UpdateOfflineStatus", Array.Empty<object>());
        }

        public void UpdateOnlineStatus()
        {
            base.method_8("UpdateOnlineStatus", Array.Empty<object>());
        }

        public FriendListChatIcon m_ChatIcon
        {
            get
            {
                return base.method_3<FriendListChatIcon>("m_ChatIcon");
            }
        }

        public MedalInfoTranslator m_medal
        {
            get
            {
                return base.method_3<MedalInfoTranslator>("m_medal");
            }
        }

        public BnetPlayer m_player
        {
            get
            {
                return base.method_3<BnetPlayer>("m_player");
            }
        }

        public PlayerIcon m_PlayerIcon
        {
            get
            {
                return base.method_3<PlayerIcon>("m_PlayerIcon");
            }
        }

        public UberText m_PlayerNameText
        {
            get
            {
                return base.method_3<UberText>("m_PlayerNameText");
            }
        }

        public FriendListFrameBasePrefabs m_Prefabs
        {
            get
            {
                return base.method_3<FriendListFrameBasePrefabs>("m_Prefabs");
            }
        }

        public TournamentMedal m_rankMedal
        {
            get
            {
                return base.method_3<TournamentMedal>("m_rankMedal");
            }
        }

        public TournamentMedal m_rankMedalPrefab
        {
            get
            {
                return base.method_3<TournamentMedal>("m_rankMedalPrefab");
            }
        }

        public Spawner m_rankMedalSpawner
        {
            get
            {
                return base.method_3<Spawner>("m_rankMedalSpawner");
            }
        }

        public Network.RecruitInfo m_recruitInfo
        {
            get
            {
                return base.method_3<Network.RecruitInfo>("m_recruitInfo");
            }
        }

        public FriendListRecruitUI m_RecruitUI
        {
            get
            {
                return base.method_3<FriendListRecruitUI>("m_RecruitUI");
            }
        }

        public UberText m_StatusText
        {
            get
            {
                return base.method_3<UberText>("m_StatusText");
            }
        }

        public static Color TEXT_COLOR_AWAY
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "FriendListBaseFriendFrame", "TEXT_COLOR_AWAY");
            }
        }

        public static Color TEXT_COLOR_BUSY
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "FriendListBaseFriendFrame", "TEXT_COLOR_BUSY");
            }
        }

        public static Color TEXT_COLOR_NORMAL
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "FriendListBaseFriendFrame", "TEXT_COLOR_NORMAL");
            }
        }

        public static Color TEXT_COLOR_OFFLINE
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "FriendListBaseFriendFrame", "TEXT_COLOR_OFFLINE");
            }
        }
    }
}

