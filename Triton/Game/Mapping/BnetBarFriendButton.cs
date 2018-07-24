namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetBarFriendButton")]
    public class BnetBarFriendButton : FriendListUIElement
    {
        public BnetBarFriendButton(IntPtr address) : this(address, "BnetBarFriendButton")
        {
        }

        public BnetBarFriendButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static BnetBarFriendButton Get()
        {
            return MonoClass.smethod_15<BnetBarFriendButton>(TritonHs.MainAssemblyPath, "", "BnetBarFriendButton", "Get", Array.Empty<object>());
        }

        public void HideTooltip()
        {
            base.method_8("HideTooltip", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFriendsChanged(BnetFriendChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnFriendsChanged", objArray1);
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void OnPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnPlayersChanged", objArray1);
        }

        public void ShowPendingInvitesIcon(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowPendingInvitesIcon", objArray1);
        }

        public void UpdateOnlineCount()
        {
            base.method_8("UpdateOnlineCount", Array.Empty<object>());
        }

        public Color m_AllOfflineColor
        {
            get
            {
                return base.method_2<Color>("m_AllOfflineColor");
            }
        }

        public Color m_AnyOnlineColor
        {
            get
            {
                return base.method_2<Color>("m_AnyOnlineColor");
            }
        }

        public UberText m_OnlineCountText
        {
            get
            {
                return base.method_3<UberText>("m_OnlineCountText");
            }
        }

        public GameObject m_PendingInvitesIcon
        {
            get
            {
                return base.method_3<GameObject>("m_PendingInvitesIcon");
            }
        }
    }
}

