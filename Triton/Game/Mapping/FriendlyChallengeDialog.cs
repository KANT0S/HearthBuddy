namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FriendlyChallengeDialog")]
    public class FriendlyChallengeDialog : DialogBase
    {
        public FriendlyChallengeDialog(IntPtr address) : this(address, "FriendlyChallengeDialog")
        {
        }

        public FriendlyChallengeDialog(IntPtr address, string className) : base(address, className)
        {
        }

        public void CancelButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("CancelButtonPress", objArray1);
        }

        public void ConfirmButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ConfirmButtonPress", objArray1);
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void SetInfo(Info info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SetInfo", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public UIBButton m_acceptButton
        {
            get
            {
                return base.method_3<UIBButton>("m_acceptButton");
            }
        }

        public UberText m_challengerName
        {
            get
            {
                return base.method_3<UberText>("m_challengerName");
            }
        }

        public UberText m_challengeText1
        {
            get
            {
                return base.method_3<UberText>("m_challengeText1");
            }
        }

        public UberText m_challengeText2
        {
            get
            {
                return base.method_3<UberText>("m_challengeText2");
            }
        }

        public UIBButton m_denyButton
        {
            get
            {
                return base.method_3<UIBButton>("m_denyButton");
            }
        }

        public UberText m_nearbyPlayerNote
        {
            get
            {
                return base.method_3<UberText>("m_nearbyPlayerNote");
            }
        }

        [Attribute38("FriendlyChallengeDialog.Info")]
        public class Info : MonoClass
        {
            public Info(IntPtr address) : this(address, "Info")
            {
            }

            public Info(IntPtr address, string className) : base(address, className)
            {
            }

            public BnetPlayer m_challenger
            {
                get
                {
                    return base.method_3<BnetPlayer>("m_challenger");
                }
            }
        }
    }
}

