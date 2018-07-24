namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("PendingBnetFriendChangelist")]
    public class PendingBnetFriendChangelist : MonoClass
    {
        public PendingBnetFriendChangelist(IntPtr address) : this(address, "PendingBnetFriendChangelist")
        {
        }

        public PendingBnetFriendChangelist(IntPtr address, string className) : base(address, className)
        {
        }

        public bool Add(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("Add", objArray1);
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public BnetFriendChangelist CreateChangelist()
        {
            return base.method_14<BnetFriendChangelist>("CreateChangelist", Array.Empty<object>());
        }

        public int GetCount()
        {
            return base.method_11<int>("GetCount", Array.Empty<object>());
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

        public bool IsFriend(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_10<bool>("IsFriend", enumArray1, objArray1);
        }

        public bool Remove(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_11<bool>("Remove", objArray1);
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
    }
}

