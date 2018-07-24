namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpecialEventVisualDef")]
    public class SpecialEventVisualDef : MonoClass
    {
        public SpecialEventVisualDef(IntPtr address) : this(address, "SpecialEventVisualDef")
        {
        }

        public SpecialEventVisualDef(IntPtr address, string className) : base(address, className)
        {
        }

        public SpecialEventType m_EventType
        {
            get
            {
                return base.method_2<SpecialEventType>("m_EventType");
            }
        }

        public string m_Prefab
        {
            get
            {
                return base.method_4("m_Prefab");
            }
        }
    }
}

