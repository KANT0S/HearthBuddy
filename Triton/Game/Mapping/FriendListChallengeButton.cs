namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FriendListChallengeButton")]
    public class FriendListChallengeButton : FriendListUIElement
    {
        public FriendListChallengeButton(IntPtr address) : this(address, "FriendListChallengeButton")
        {
        }

        public FriendListChallengeButton(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanChallenge()
        {
            return base.method_11<bool>("CanChallenge", Array.Empty<object>());
        }

        public BnetPlayer GetPlayer()
        {
            return base.method_14<BnetPlayer>("GetPlayer", Array.Empty<object>());
        }

        public void HideTooltip()
        {
            base.method_8("HideTooltip", Array.Empty<object>());
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

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }

        public bool SetPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("SetPlayer", objArray1);
        }

        public bool ShouldBeHighlighted()
        {
            return base.method_11<bool>("ShouldBeHighlighted", Array.Empty<object>());
        }

        public void ShowTooltip()
        {
            base.method_8("ShowTooltip", Array.Empty<object>());
        }

        public void UpdateButton()
        {
            base.method_8("UpdateButton", Array.Empty<object>());
        }

        public bool UpdateEditModeButtonState()
        {
            return base.method_11<bool>("UpdateEditModeButtonState", Array.Empty<object>());
        }

        public bool UpdateSpectateButtonState()
        {
            return base.method_11<bool>("UpdateSpectateButtonState", Array.Empty<object>());
        }

        public void UpdateTooltip()
        {
            base.method_8("UpdateTooltip", Array.Empty<object>());
        }

        public GameObject m_AvailableIcon
        {
            get
            {
                return base.method_3<GameObject>("m_AvailableIcon");
            }
        }

        public GameObject m_BusyIcon
        {
            get
            {
                return base.method_3<GameObject>("m_BusyIcon");
            }
        }

        public GameObject m_DeleteIcon
        {
            get
            {
                return base.method_3<GameObject>("m_DeleteIcon");
            }
        }

        public BnetPlayer m_player
        {
            get
            {
                return base.method_3<BnetPlayer>("m_player");
            }
        }

        public TextureOffsetStates m_SpectatorIcon
        {
            get
            {
                return base.method_3<TextureOffsetStates>("m_SpectatorIcon");
            }
        }

        public GameObject m_SpectatorIconHighlight
        {
            get
            {
                return base.method_3<GameObject>("m_SpectatorIconHighlight");
            }
        }

        public GameObject m_TavernBrawlBusyIcon
        {
            get
            {
                return base.method_3<GameObject>("m_TavernBrawlBusyIcon");
            }
        }

        public GameObject m_TavernBrawlChallengeIcon
        {
            get
            {
                return base.method_3<GameObject>("m_TavernBrawlChallengeIcon");
            }
        }

        public TooltipZone m_TooltipZone
        {
            get
            {
                return base.method_3<TooltipZone>("m_TooltipZone");
            }
        }
    }
}

