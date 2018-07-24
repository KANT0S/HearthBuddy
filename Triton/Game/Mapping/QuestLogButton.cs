namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("QuestLogButton")]
    public class QuestLogButton : PegUIElement
    {
        public QuestLogButton(IntPtr address) : this(address, "QuestLogButton")
        {
        }

        public QuestLogButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnButtonOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnButtonOut", objArray1);
        }

        public void OnButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnButtonOver", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }
    }
}

