namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("UIEvent")]
    public class UIEvent : MonoClass
    {
        public UIEvent(IntPtr address) : this(address, "UIEvent")
        {
        }

        public UIEvent(IntPtr address, string className) : base(address, className)
        {
        }

        public PegUIElement GetElement()
        {
            return base.method_14<PegUIElement>("GetElement", Array.Empty<object>());
        }

        public UIEventType GetEventType()
        {
            return base.method_11<UIEventType>("GetEventType", Array.Empty<object>());
        }

        public PegUIElement m_element
        {
            get
            {
                return base.method_3<PegUIElement>("m_element");
            }
        }

        public UIEventType m_eventType
        {
            get
            {
                return base.method_2<UIEventType>("m_eventType");
            }
        }
    }
}

