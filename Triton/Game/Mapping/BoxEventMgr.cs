namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoxEventMgr")]
    public class BoxEventMgr : MonoBehaviour
    {
        public BoxEventMgr(IntPtr address) : this(address, "BoxEventMgr")
        {
        }

        public BoxEventMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Spell GetEventSpell(BoxEventType eventType)
        {
            object[] objArray1 = new object[] { eventType };
            return base.method_14<Spell>("GetEventSpell", objArray1);
        }

        public BoxEventInfo m_EventInfo
        {
            get
            {
                return base.method_3<BoxEventInfo>("m_EventInfo");
            }
        }
    }
}

