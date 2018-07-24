namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("StoreDoneWithBAM")]
    public class StoreDoneWithBAM : UIBPopup
    {
        public StoreDoneWithBAM(IntPtr address) : this(address, "StoreDoneWithBAM")
        {
        }

        public StoreDoneWithBAM(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnOkayPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnOkayPressed", objArray1);
        }

        public UberText m_headlineText
        {
            get
            {
                return base.method_3<UberText>("m_headlineText");
            }
        }

        public UberText m_messageText
        {
            get
            {
                return base.method_3<UberText>("m_messageText");
            }
        }

        public UIBButton m_okayButton
        {
            get
            {
                return base.method_3<UIBButton>("m_okayButton");
            }
        }
    }
}

