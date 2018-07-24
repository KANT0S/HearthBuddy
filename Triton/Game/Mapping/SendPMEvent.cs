namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SendPMEvent")]
    public class SendPMEvent : MonoBehaviour
    {
        public SendPMEvent(IntPtr address) : this(address, "SendPMEvent")
        {
        }

        public SendPMEvent(IntPtr address, string className) : base(address, className)
        {
        }

        public void SendEvent()
        {
            base.method_8("SendEvent", Array.Empty<object>());
        }

        public string eventName
        {
            get
            {
                return base.method_4("eventName");
            }
        }
    }
}

