namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DropdownMenuItem")]
    public class DropdownMenuItem : PegUIElement
    {
        public DropdownMenuItem(IntPtr address) : this(address, "DropdownMenuItem")
        {
        }

        public DropdownMenuItem(IntPtr address, string className) : base(address, className)
        {
        }

        public object GetValue()
        {
            return base.method_14<object>("GetValue", Array.Empty<object>());
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

        public void SetSelected(bool selected)
        {
            object[] objArray1 = new object[] { selected };
            base.method_8("SetSelected", objArray1);
        }

        public void SetValue(object val, string text)
        {
            object[] objArray1 = new object[] { val, text };
            base.method_8("SetValue", objArray1);
        }

        public GameObject m_selected
        {
            get
            {
                return base.method_3<GameObject>("m_selected");
            }
        }

        public UberText m_text
        {
            get
            {
                return base.method_3<UberText>("m_text");
            }
        }

        public object m_value
        {
            get
            {
                return base.method_3<object>("m_value");
            }
        }
    }
}

