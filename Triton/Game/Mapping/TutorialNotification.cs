namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TutorialNotification")]
    public class TutorialNotification : Triton.Game.Mapping.Notification
    {
        public TutorialNotification(IntPtr address) : this(address, "TutorialNotification")
        {
        }

        public TutorialNotification(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetWantedText(string txt)
        {
            object[] objArray1 = new object[] { txt };
            base.method_8("SetWantedText", objArray1);
        }

        public UIBButton m_ButtonStart
        {
            get
            {
                return base.method_3<UIBButton>("m_ButtonStart");
            }
        }

        public UberText m_WantedText
        {
            get
            {
                return base.method_3<UberText>("m_WantedText");
            }
        }
    }
}

