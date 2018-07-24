namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PlayerIcon")]
    public class PlayerIcon : PegUIElement
    {
        public PlayerIcon(IntPtr address) : this(address, "PlayerIcon")
        {
        }

        public PlayerIcon(IntPtr address, string className) : base(address, className)
        {
        }

        public BnetPlayer GetPlayer()
        {
            return base.method_14<BnetPlayer>("GetPlayer", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool SetPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("SetPlayer", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void UpdateIcon()
        {
            base.method_8("UpdateIcon", Array.Empty<object>());
        }

        public bool m_hidden
        {
            get
            {
                return base.method_2<bool>("m_hidden");
            }
        }

        public GameObject m_OfflineIcon
        {
            get
            {
                return base.method_3<GameObject>("m_OfflineIcon");
            }
        }

        public GameObject m_OnlineIcon
        {
            get
            {
                return base.method_3<GameObject>("m_OnlineIcon");
            }
        }

        public PlayerPortrait m_OnlinePortrait
        {
            get
            {
                return base.method_3<PlayerPortrait>("m_OnlinePortrait");
            }
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

