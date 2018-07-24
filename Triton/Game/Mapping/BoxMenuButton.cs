namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoxMenuButton")]
    public class BoxMenuButton : PegUIElement
    {
        public BoxMenuButton(IntPtr address) : this(address, "BoxMenuButton")
        {
        }

        public BoxMenuButton(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetText()
        {
            return base.method_13("GetText", Array.Empty<object>());
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

        public void SetText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetText", objArray1);
        }

        public HighlightState m_HighlightState
        {
            get
            {
                return base.method_3<HighlightState>("m_HighlightState");
            }
        }

        public Spell m_Spell
        {
            get
            {
                return base.method_3<Spell>("m_Spell");
            }
        }

        public UberText m_TextMesh
        {
            get
            {
                return base.method_3<UberText>("m_TextMesh");
            }
        }
    }
}

