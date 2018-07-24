namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FriendListRequestFrame")]
    public class FriendListRequestFrame : MonoBehaviour
    {
        public FriendListRequestFrame(IntPtr address) : this(address, "FriendListRequestFrame")
        {
        }

        public FriendListRequestFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public BnetInvitation GetInvite()
        {
            return base.method_14<BnetInvitation>("GetInvite", Array.Empty<object>());
        }

        public void OnAcceptButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnAcceptButtonPressed", objArray1);
        }

        public void OnDeclineButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeclineButtonPressed", objArray1);
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void SetInvite(BnetInvitation invite)
        {
            object[] objArray1 = new object[] { invite };
            base.method_8("SetInvite", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateInvite()
        {
            base.method_8("UpdateInvite", Array.Empty<object>());
        }

        public void UpdateTimeText()
        {
            base.method_8("UpdateTimeText", Array.Empty<object>());
        }

        public FriendListUIElement m_AcceptButton
        {
            get
            {
                return base.method_3<FriendListUIElement>("m_AcceptButton");
            }
        }

        public GameObject m_Background
        {
            get
            {
                return base.method_3<GameObject>("m_Background");
            }
        }

        public FriendListUIElement m_DeclineButton
        {
            get
            {
                return base.method_3<FriendListUIElement>("m_DeclineButton");
            }
        }

        public BnetInvitation m_invite
        {
            get
            {
                return base.method_3<BnetInvitation>("m_invite");
            }
        }

        public UberText m_PlayerNameText
        {
            get
            {
                return base.method_3<UberText>("m_PlayerNameText");
            }
        }

        public UberText m_TimeText
        {
            get
            {
                return base.method_3<UberText>("m_TimeText");
            }
        }
    }
}

