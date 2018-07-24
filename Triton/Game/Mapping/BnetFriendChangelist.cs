namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("BnetFriendChangelist")]
    public class BnetFriendChangelist : MonoClass
    {
        public BnetFriendChangelist(IntPtr address) : this(address, "BnetFriendChangelist")
        {
        }

        public BnetFriendChangelist(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddAddedFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("AddAddedFriend", objArray1);
        }

        public bool AddAddedReceivedInvite(BnetInvitation invite)
        {
            object[] objArray1 = new object[] { invite };
            return base.method_11<bool>("AddAddedReceivedInvite", objArray1);
        }

        public bool AddAddedSentInvite(BnetInvitation invite)
        {
            object[] objArray1 = new object[] { invite };
            return base.method_11<bool>("AddAddedSentInvite", objArray1);
        }

        public bool AddRemovedFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("AddRemovedFriend", objArray1);
        }

        public bool AddRemovedReceivedInvite(BnetInvitation invite)
        {
            object[] objArray1 = new object[] { invite };
            return base.method_11<bool>("AddRemovedReceivedInvite", objArray1);
        }

        public bool AddRemovedSentInvite(BnetInvitation invite)
        {
            object[] objArray1 = new object[] { invite };
            return base.method_11<bool>("AddRemovedSentInvite", objArray1);
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public void ClearAddedFriends()
        {
            base.method_8("ClearAddedFriends", Array.Empty<object>());
        }

        public void ClearAddedReceivedInvites()
        {
            base.method_8("ClearAddedReceivedInvites", Array.Empty<object>());
        }

        public void ClearAddedSentInvites()
        {
            base.method_8("ClearAddedSentInvites", Array.Empty<object>());
        }

        public void ClearRemovedFriends()
        {
            base.method_8("ClearRemovedFriends", Array.Empty<object>());
        }

        public void ClearRemovedReceivedInvites()
        {
            base.method_8("ClearRemovedReceivedInvites", Array.Empty<object>());
        }

        public void ClearRemovedSentInvites()
        {
            base.method_8("ClearRemovedSentInvites", Array.Empty<object>());
        }

        public List<BnetPlayer> GetAddedFriends()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetAddedFriends", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetInvitation> GetAddedReceivedInvites()
        {
            Class267<BnetInvitation> class2 = base.method_14<Class267<BnetInvitation>>("GetAddedReceivedInvites", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetInvitation> GetAddedSentInvites()
        {
            Class267<BnetInvitation> class2 = base.method_14<Class267<BnetInvitation>>("GetAddedSentInvites", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetPlayer> GetRemovedFriends()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetRemovedFriends", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetInvitation> GetRemovedReceivedInvites()
        {
            Class267<BnetInvitation> class2 = base.method_14<Class267<BnetInvitation>>("GetRemovedReceivedInvites", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetInvitation> GetRemovedSentInvites()
        {
            Class267<BnetInvitation> class2 = base.method_14<Class267<BnetInvitation>>("GetRemovedSentInvites", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public bool IsEmpty()
        {
            return base.method_11<bool>("IsEmpty", Array.Empty<object>());
        }

        public bool RemoveAddedFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("RemoveAddedFriend", objArray1);
        }

        public bool RemoveAddedReceivedInvite(BnetInvitation invite)
        {
            object[] objArray1 = new object[] { invite };
            return base.method_11<bool>("RemoveAddedReceivedInvite", objArray1);
        }

        public bool RemoveAddedSentInvite(BnetInvitation invite)
        {
            object[] objArray1 = new object[] { invite };
            return base.method_11<bool>("RemoveAddedSentInvite", objArray1);
        }

        public bool RemoveRemovedFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("RemoveRemovedFriend", objArray1);
        }

        public bool RemoveRemovedReceivedInvite(BnetInvitation invite)
        {
            object[] objArray1 = new object[] { invite };
            return base.method_11<bool>("RemoveRemovedReceivedInvite", objArray1);
        }

        public bool RemoveRemovedSentInvite(BnetInvitation invite)
        {
            object[] objArray1 = new object[] { invite };
            return base.method_11<bool>("RemoveRemovedSentInvite", objArray1);
        }

        public List<BnetPlayer> m_friendsAdded
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_friendsAdded");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetPlayer> m_friendsRemoved
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_friendsRemoved");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetInvitation> m_receivedInvitesAdded
        {
            get
            {
                Class267<BnetInvitation> class2 = base.method_3<Class267<BnetInvitation>>("m_receivedInvitesAdded");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetInvitation> m_receivedInvitesRemoved
        {
            get
            {
                Class267<BnetInvitation> class2 = base.method_3<Class267<BnetInvitation>>("m_receivedInvitesRemoved");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetInvitation> m_sentInvitesAdded
        {
            get
            {
                Class267<BnetInvitation> class2 = base.method_3<Class267<BnetInvitation>>("m_sentInvitesAdded");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetInvitation> m_sentInvitesRemoved
        {
            get
            {
                Class267<BnetInvitation> class2 = base.method_3<Class267<BnetInvitation>>("m_sentInvitesRemoved");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

