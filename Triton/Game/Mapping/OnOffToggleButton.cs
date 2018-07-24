namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("OnOffToggleButton")]
    public class OnOffToggleButton : CheckBox
    {
        public OnOffToggleButton(IntPtr address) : this(address, "OnOffToggleButton")
        {
        }

        public OnOffToggleButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetChecked(bool isChecked)
        {
            object[] objArray1 = new object[] { isChecked };
            base.method_8("SetChecked", objArray1);
        }

        public string m_offLabel
        {
            get
            {
                return base.method_4("m_offLabel");
            }
        }

        public string m_onLabel
        {
            get
            {
                return base.method_4("m_onLabel");
            }
        }
    }
}

