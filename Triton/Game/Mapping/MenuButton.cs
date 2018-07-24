namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MenuButton")]
    public class MenuButton : PegUIElement
    {
        public MenuButton(IntPtr address) : this(address, "MenuButton")
        {
        }

        public MenuButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetText(string s)
        {
            object[] objArray1 = new object[] { s };
            base.method_8("SetText", objArray1);
        }

        public TextMesh m_label
        {
            get
            {
                return base.method_3<TextMesh>("m_label");
            }
        }
    }
}

