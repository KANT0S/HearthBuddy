namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FriendListChatIcon")]
    public class FriendListChatIcon : MonoBehaviour
    {
        public FriendListChatIcon(IntPtr address) : this(address, "FriendListChatIcon")
        {
        }

        public FriendListChatIcon(IntPtr address, string className) : base(address, className)
        {
        }

        public BnetPlayer GetPlayer()
        {
            return base.method_14<BnetPlayer>("GetPlayer", Array.Empty<object>());
        }

        public bool SetPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("SetPlayer", objArray1);
        }

        public void UpdateIcon()
        {
            base.method_8("UpdateIcon", Array.Empty<object>());
        }

        public BnetPlayer m_player
        {
            get
            {
                return base.method_3<BnetPlayer>("m_player");
            }
        }
    }
}

