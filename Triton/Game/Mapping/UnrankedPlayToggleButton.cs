namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UnrankedPlayToggleButton")]
    public class UnrankedPlayToggleButton : PegUIElement
    {
        public UnrankedPlayToggleButton(IntPtr address) : this(address, "UnrankedPlayToggleButton")
        {
        }

        public UnrankedPlayToggleButton(IntPtr address, string className) : base(address, className)
        {
        }

        public bool GetIsRanked()
        {
            return base.method_11<bool>("GetIsRanked", Array.Empty<object>());
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

        public void SetRankedMode(bool isRankedMode)
        {
            object[] objArray1 = new object[] { isRankedMode };
            base.method_8("SetRankedMode", objArray1);
        }

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }

        public bool m_isRankedMode
        {
            get
            {
                return base.method_2<bool>("m_isRankedMode");
            }
        }

        public GameObject m_xIcon
        {
            get
            {
                return base.method_3<GameObject>("m_xIcon");
            }
        }
    }
}

