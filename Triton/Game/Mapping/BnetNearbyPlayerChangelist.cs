namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("BnetNearbyPlayerChangelist")]
    public class BnetNearbyPlayerChangelist : MonoClass
    {
        public BnetNearbyPlayerChangelist(IntPtr address) : this(address, "BnetNearbyPlayerChangelist")
        {
        }

        public BnetNearbyPlayerChangelist(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddAddedFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("AddAddedFriend", objArray1);
        }

        public bool AddAddedPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("AddAddedPlayer", objArray1);
        }

        public bool AddAddedStranger(BnetPlayer stranger)
        {
            object[] objArray1 = new object[] { stranger };
            return base.method_11<bool>("AddAddedStranger", objArray1);
        }

        public bool AddRemovedFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("AddRemovedFriend", objArray1);
        }

        public bool AddRemovedPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("AddRemovedPlayer", objArray1);
        }

        public bool AddRemovedStranger(BnetPlayer stranger)
        {
            object[] objArray1 = new object[] { stranger };
            return base.method_11<bool>("AddRemovedStranger", objArray1);
        }

        public bool AddUpdatedFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("AddUpdatedFriend", objArray1);
        }

        public bool AddUpdatedPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("AddUpdatedPlayer", objArray1);
        }

        public bool AddUpdatedStranger(BnetPlayer stranger)
        {
            object[] objArray1 = new object[] { stranger };
            return base.method_11<bool>("AddUpdatedStranger", objArray1);
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public void ClearAddedFriends()
        {
            base.method_8("ClearAddedFriends", Array.Empty<object>());
        }

        public void ClearAddedPlayers()
        {
            base.method_8("ClearAddedPlayers", Array.Empty<object>());
        }

        public void ClearAddedStrangers()
        {
            base.method_8("ClearAddedStrangers", Array.Empty<object>());
        }

        public void ClearRemovedFriends()
        {
            base.method_8("ClearRemovedFriends", Array.Empty<object>());
        }

        public void ClearRemovedPlayers()
        {
            base.method_8("ClearRemovedPlayers", Array.Empty<object>());
        }

        public void ClearRemovedStrangers()
        {
            base.method_8("ClearRemovedStrangers", Array.Empty<object>());
        }

        public void ClearUpdatedFriends()
        {
            base.method_8("ClearUpdatedFriends", Array.Empty<object>());
        }

        public void ClearUpdatedPlayers()
        {
            base.method_8("ClearUpdatedPlayers", Array.Empty<object>());
        }

        public void ClearUpdatedStrangers()
        {
            base.method_8("ClearUpdatedStrangers", Array.Empty<object>());
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

        public List<BnetPlayer> GetAddedPlayers()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetAddedPlayers", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetPlayer> GetAddedStrangers()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetAddedStrangers", Array.Empty<object>());
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

        public List<BnetPlayer> GetRemovedPlayers()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetRemovedPlayers", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetPlayer> GetRemovedStrangers()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetRemovedStrangers", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetPlayer> GetUpdatedFriends()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetUpdatedFriends", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetPlayer> GetUpdatedPlayers()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetUpdatedPlayers", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetPlayer> GetUpdatedStrangers()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetUpdatedStrangers", Array.Empty<object>());
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

        public bool RemoveAddedPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("RemoveAddedPlayer", objArray1);
        }

        public bool RemoveAddedStranger(BnetPlayer stranger)
        {
            object[] objArray1 = new object[] { stranger };
            return base.method_11<bool>("RemoveAddedStranger", objArray1);
        }

        public bool RemoveRemovedFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("RemoveRemovedFriend", objArray1);
        }

        public bool RemoveRemovedPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("RemoveRemovedPlayer", objArray1);
        }

        public bool RemoveRemovedStranger(BnetPlayer stranger)
        {
            object[] objArray1 = new object[] { stranger };
            return base.method_11<bool>("RemoveRemovedStranger", objArray1);
        }

        public bool RemoveUpdatedFriend(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("RemoveUpdatedFriend", objArray1);
        }

        public bool RemoveUpdatedPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("RemoveUpdatedPlayer", objArray1);
        }

        public bool RemoveUpdatedStranger(BnetPlayer stranger)
        {
            object[] objArray1 = new object[] { stranger };
            return base.method_11<bool>("RemoveUpdatedStranger", objArray1);
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

        public List<BnetPlayer> m_friendsUpdated
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_friendsUpdated");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetPlayer> m_playersAdded
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_playersAdded");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetPlayer> m_playersRemoved
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_playersRemoved");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetPlayer> m_playersUpdated
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_playersUpdated");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetPlayer> m_strangersAdded
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_strangersAdded");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetPlayer> m_strangersRemoved
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_strangersRemoved");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetPlayer> m_strangersUpdated
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_strangersUpdated");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

