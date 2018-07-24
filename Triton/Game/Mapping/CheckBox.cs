namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CheckBox")]
    public class CheckBox : PegUIElement
    {
        public CheckBox(IntPtr address) : this(address, "CheckBox")
        {
        }

        public CheckBox(IntPtr address, string className) : base(address, className)
        {
        }

        public int GetButtonID()
        {
            return base.method_11<int>("GetButtonID", Array.Empty<object>());
        }

        public bool IsChecked()
        {
            return base.method_11<bool>("IsChecked", Array.Empty<object>());
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

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void SetButtonID(int id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetButtonID", objArray1);
        }

        public void SetButtonText(string s)
        {
            object[] objArray1 = new object[] { s };
            base.method_8("SetButtonText", objArray1);
        }

        public void SetChecked(bool isChecked)
        {
            object[] objArray1 = new object[] { isChecked };
            base.method_8("SetChecked", objArray1);
        }

        public void SetState(PegUIElement.InteractionState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("SetState", objArray1);
        }

        public bool ToggleChecked()
        {
            return base.method_11<bool>("ToggleChecked", Array.Empty<object>());
        }

        public int m_buttonID
        {
            get
            {
                return base.method_2<int>("m_buttonID");
            }
        }

        public GameObject m_check
        {
            get
            {
                return base.method_3<GameObject>("m_check");
            }
        }

        public bool m_checked
        {
            get
            {
                return base.method_2<bool>("m_checked");
            }
        }

        public string m_checkOffSound
        {
            get
            {
                return base.method_4("m_checkOffSound");
            }
        }

        public string m_checkOnSound
        {
            get
            {
                return base.method_4("m_checkOnSound");
            }
        }

        public TextMesh m_text
        {
            get
            {
                return base.method_3<TextMesh>("m_text");
            }
        }

        public UberText m_uberText
        {
            get
            {
                return base.method_3<UberText>("m_uberText");
            }
        }
    }
}

