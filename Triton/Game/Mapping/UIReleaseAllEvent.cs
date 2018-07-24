namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UIReleaseAllEvent")]
    public class UIReleaseAllEvent : UIEvent
    {
        public UIReleaseAllEvent(IntPtr address) : this(address, "UIReleaseAllEvent")
        {
        }

        public UIReleaseAllEvent(IntPtr address, string className) : base(address, className)
        {
        }

        public bool GetMouseIsOver()
        {
            return base.method_11<bool>("GetMouseIsOver", Array.Empty<object>());
        }

        public bool m_mouseIsOver
        {
            get
            {
                return base.method_2<bool>("m_mouseIsOver");
            }
        }
    }
}

