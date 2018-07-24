namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FriendListCurrentGameFrame")]
    public class FriendListCurrentGameFrame : FriendListBaseFriendFrame
    {
        public FriendListCurrentGameFrame(IntPtr address) : this(address, "FriendListCurrentGameFrame")
        {
        }

        public FriendListCurrentGameFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void OnPlayButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnPlayButtonPressed", objArray1);
        }

        public void UpdateFriend()
        {
            base.method_8("UpdateFriend", Array.Empty<object>());
        }

        public GameObject m_Background
        {
            get
            {
                return base.method_3<GameObject>("m_Background");
            }
        }

        public FriendListButton m_PlayButton
        {
            get
            {
                return base.method_3<FriendListButton>("m_PlayButton");
            }
        }
    }
}

