namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FriendMgr")]
    public class FriendMgr : MonoClass
    {
        public FriendMgr(IntPtr address) : this(address, "FriendMgr")
        {
        }

        public FriendMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void FireRecentOpponentEvent(BnetPlayer recentOpponent)
        {
            object[] objArray1 = new object[] { recentOpponent };
            base.method_8("FireRecentOpponentEvent", objArray1);
        }

        public static FriendMgr Get()
        {
            return MonoClass.smethod_15<FriendMgr>(TritonHs.MainAssemblyPath, "", "FriendMgr", "Get", Array.Empty<object>());
        }

        public float GetFriendListScrollCamPosY()
        {
            return base.method_11<float>("GetFriendListScrollCamPosY", Array.Empty<object>());
        }

        public BnetPlayer GetRecentOpponent()
        {
            return base.method_14<BnetPlayer>("GetRecentOpponent", Array.Empty<object>());
        }

        public BnetPlayer GetSelectedFriend()
        {
            return base.method_14<BnetPlayer>("GetSelectedFriend", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool IsFriendListScrollEnabled()
        {
            return base.method_11<bool>("IsFriendListScrollEnabled", Array.Empty<object>());
        }

        public void OnFriendsChanged(BnetFriendChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnFriendsChanged", objArray1);
        }

        public void OnGameOver(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnGameOver", objArray1);
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

        public void SetFriendListScrollCamPosY(float y)
        {
            object[] objArray1 = new object[] { y };
            base.method_8("SetFriendListScrollCamPosY", objArray1);
        }

        public void SetFriendListScrollEnabled(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("SetFriendListScrollEnabled", objArray1);
        }

        public void SetSelectedFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            base.method_8("SetSelectedFriend", objArray1);
        }

        public void UpdateRecentOpponent()
        {
            base.method_8("UpdateRecentOpponent", Array.Empty<object>());
        }

        public float m_friendListScrollCamPosY
        {
            get
            {
                return base.method_2<float>("m_friendListScrollCamPosY");
            }
        }

        public bool m_friendListScrollEnabled
        {
            get
            {
                return base.method_2<bool>("m_friendListScrollEnabled");
            }
        }

        public BnetPlayer m_recentOpponent
        {
            get
            {
                return base.method_3<BnetPlayer>("m_recentOpponent");
            }
        }

        public BnetPlayer m_selectedFriend
        {
            get
            {
                return base.method_3<BnetPlayer>("m_selectedFriend");
            }
        }
    }
}

