namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AddFriendFrame")]
    public class AddFriendFrame : MonoBehaviour
    {
        public AddFriendFrame(IntPtr address) : this(address, "AddFriendFrame")
        {
        }

        public AddFriendFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Close()
        {
            base.method_8("Close", Array.Empty<object>());
        }

        public void InitInput()
        {
            base.method_8("InitInput", Array.Empty<object>());
        }

        public void InitInputBlocker()
        {
            base.method_8("InitInputBlocker", Array.Empty<object>());
        }

        public void InitInputTextField()
        {
            base.method_8("InitInputTextField", Array.Empty<object>());
        }

        public void InitItems()
        {
            base.method_8("InitItems", Array.Empty<object>());
        }

        public void Layout()
        {
            base.method_8("Layout", Array.Empty<object>());
        }

        public void OnClosed()
        {
            base.method_8("OnClosed", Array.Empty<object>());
        }

        public void OnInputBlockerReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnInputBlockerReleased", objArray1);
        }

        public void OnInputCanceled()
        {
            base.method_8("OnInputCanceled", Array.Empty<object>());
        }

        public void OnInputChanged(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("OnInputChanged", objArray1);
        }

        public void OnInputSubmitted(string input)
        {
            object[] objArray1 = new object[] { input };
            base.method_8("OnInputSubmitted", objArray1);
        }

        public void SetPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("SetPlayer", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateInstructions()
        {
            base.method_8("UpdateInstructions", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public AddFriendFrameBones m_Bones
        {
            get
            {
                return base.method_3<AddFriendFrameBones>("m_Bones");
            }
        }

        public UberText m_HeaderText
        {
            get
            {
                return base.method_3<UberText>("m_HeaderText");
            }
        }

        public PegUIElement m_inputBlocker
        {
            get
            {
                return base.method_3<PegUIElement>("m_inputBlocker");
            }
        }

        public string m_inputText
        {
            get
            {
                return base.method_4("m_inputText");
            }
        }

        public TextField m_InputTextField
        {
            get
            {
                return base.method_3<TextField>("m_InputTextField");
            }
        }

        public UberText m_InstructionText
        {
            get
            {
                return base.method_3<UberText>("m_InstructionText");
            }
        }

        public BnetPlayer m_player
        {
            get
            {
                return base.method_3<BnetPlayer>("m_player");
            }
        }

        public string m_playerDisplayName
        {
            get
            {
                return base.method_4("m_playerDisplayName");
            }
        }

        public bool m_usePlayer
        {
            get
            {
                return base.method_2<bool>("m_usePlayer");
            }
        }
    }
}

