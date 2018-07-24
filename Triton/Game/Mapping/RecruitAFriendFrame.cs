namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RecruitAFriendFrame")]
    public class RecruitAFriendFrame : MonoBehaviour
    {
        public RecruitAFriendFrame(IntPtr address) : this(address, "RecruitAFriendFrame")
        {
        }

        public RecruitAFriendFrame(IntPtr address, string className) : base(address, className)
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

        public void FireClosedEvent()
        {
            base.method_8("FireClosedEvent", Array.Empty<object>());
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

        public void ShowAlertPopup(string msgGameStringKey)
        {
            object[] objArray1 = new object[] { msgGameStringKey };
            base.method_8("ShowAlertPopup", objArray1);
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

        public RecruitAFriendFrameBones m_Bones
        {
            get
            {
                return base.method_3<RecruitAFriendFrameBones>("m_Bones");
            }
        }

        public UberText m_DescriptionText
        {
            get
            {
                return base.method_3<UberText>("m_DescriptionText");
            }
        }

        public UberText m_DisclaimerText
        {
            get
            {
                return base.method_3<UberText>("m_DisclaimerText");
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

        public UberText m_TitleText
        {
            get
            {
                return base.method_3<UberText>("m_TitleText");
            }
        }
    }
}

