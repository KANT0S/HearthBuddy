namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RibbonButton")]
    public class RibbonButton : PegUIElement
    {
        public RibbonButton(IntPtr address) : this(address, "RibbonButton")
        {
        }

        public RibbonButton(IntPtr address, string className) : base(address, className)
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

        public GameObject m_highlight
        {
            get
            {
                return base.method_3<GameObject>("m_highlight");
            }
        }
    }
}

