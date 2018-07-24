namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BnetBarKeyboard")]
    public class BnetBarKeyboard : PegUIElement
    {
        public BnetBarKeyboard(IntPtr address) : this(address, "BnetBarKeyboard")
        {
        }

        public BnetBarKeyboard(IntPtr address, string className) : base(address, className)
        {
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

        public void ShowHighlight(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowHighlight", objArray1);
        }

        public Color m_highlight
        {
            get
            {
                return base.method_2<Color>("m_highlight");
            }
        }

        public Color m_origColor
        {
            get
            {
                return base.method_2<Color>("m_origColor");
            }
        }
    }
}

