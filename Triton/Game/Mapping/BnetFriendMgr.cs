namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetFriendMgr")]
    public class BnetFriendMgr : MonoClass
    {
        public BnetFriendMgr(IntPtr address) : this(address, "BnetFriendMgr")
        {
        }

        public BnetFriendMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void AcceptInvite(BnetInvitationId inviteId)
        {
            object[] objArray1 = new object[] { inviteId };
            base.method_8("AcceptInvite", objArray1);
        }

        public void AddPendingFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            base.method_8("AddPendingFriend", objArray1);
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public void DeclineInvite(BnetInvitationId inviteId)
        {
            object[] objArray1 = new object[] { inviteId };
            base.method_8("DeclineInvite", objArray1);
        }

        public void FireChangeEvent(BnetFriendChangelist changelist)
        {
            object[] objArray1 = new object[] { changelist };
            base.method_8("FireChangeEvent", objArray1);
        }

        public void FirePendingFriendsChangedEvent()
        {
            base.method_8("FirePendingFriendsChangedEvent", Array.Empty<object>());
        }

        public static BnetFriendMgr Get()
        {
            return MonoClass.smethod_15<BnetFriendMgr>(TritonHs.MainAssemblyPath, "", "BnetFriendMgr", "Get", Array.Empty<object>());
        }

        public int GetActiveOnlineFriendCount()
        {
            return base.method_11<int>("GetActiveOnlineFriendCount", Array.Empty<object>());
        }

        public int GetFriendCount()
        {
            return base.method_11<int>("GetFriendCount", Array.Empty<object>());
        }

        public List<BnetPlayer> GetFriends()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetFriends", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetMaxFriends()
        {
            return base.method_11<int>("GetMaxFriends", Array.Empty<object>());
        }

        public int GetMaxReceivedInvites()
        {
            return base.method_11<int>("GetMaxReceivedInvites", Array.Empty<object>());
        }

        public int GetMaxSentInvites()
        {
            return base.method_11<int>("GetMaxSentInvites", Array.Empty<object>());
        }

        public int GetOnlineFriendCount()
        {
            return base.method_11<int>("GetOnlineFriendCount", Array.Empty<object>());
        }

        public List<BnetPlayer> GetPendingFriends()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetPendingFriends", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetInvitation> GetReceivedInvites()
        {
            Class267<BnetInvitation> class2 = base.method_14<Class267<BnetInvitation>>("GetReceivedInvites", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetInvitation> GetSentInvites()
        {
            Class267<BnetInvitation> class2 = base.method_14<Class267<BnetInvitation>>("GetSentInvites", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void IgnoreInvite(BnetInvitationId inviteId)
        {
            object[] objArray1 = new object[] { inviteId };
            base.method_8("IgnoreInvite", objArray1);
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public void InitMaximums()
        {
            base.method_8("InitMaximums", Array.Empty<object>());
        }

        public bool IsFriend(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_10<bool>("IsFriend", enumArray1, objArray1);
        }

        public bool IsNonPendingFriend(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_10<bool>("IsNonPendingFriend", enumArray1, objArray1);
        }

        public bool IsPendingFriend(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_10<bool>("IsPendingFriend", enumArray1, objArray1);
        }

        public void OnPendingPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnPendingPlayersChanged", objArray1);
        }

        public void ProcessPendingFriends()
        {
            base.method_8("ProcessPendingFriends", Array.Empty<object>());
        }

        public bool RemoveFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("RemoveFriend", objArray1);
        }

        public void RemovePendingFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            base.method_8("RemovePendingFriend", objArray1);
        }

        public void RevokeInvite(BnetInvitationId inviteId)
        {
            object[] objArray1 = new object[] { inviteId };
            base.method_8("RevokeInvite", objArray1);
        }

        public void SendInvite(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("SendInvite", objArray1);
        }

        public void SendInviteByBattleTag(string battleTagString)
        {
            object[] objArray1 = new object[] { battleTagString };
            base.method_8("SendInviteByBattleTag", objArray1);
        }

        public void SendInviteByEmail(string email)
        {
            object[] objArray1 = new object[] { email };
            base.method_8("SendInviteByEmail", objArray1);
        }

        public void Shutdown()
        {
            base.method_8("Shutdown", Array.Empty<object>());
        }

        public List<BnetPlayer> m_friends
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_friends");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_maxFriends
        {
            get
            {
                return base.method_2<int>("m_maxFriends");
            }
        }

        public int m_maxReceivedInvites
        {
            get
            {
                return base.method_2<int>("m_maxReceivedInvites");
            }
        }

        public int m_maxSentInvites
        {
            get
            {
                return base.method_2<int>("m_maxSentInvites");
            }
        }

        public PendingBnetFriendChangelist m_pendingChangelist
        {
            get
            {
                return base.method_3<PendingBnetFriendChangelist>("m_pendingChangelist");
            }
        }

        public List<BnetInvitation> m_receivedInvites
        {
            get
            {
                Class267<BnetInvitation> class2 = base.method_3<Class267<BnetInvitation>>("m_receivedInvites");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetInvitation> m_sentInvites
        {
            get
            {
                Class267<BnetInvitation> class2 = base.method_3<Class267<BnetInvitation>>("m_sentInvites");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

