namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("QuickChatFrameBones")]
    public class QuickChatFrameBones : MonoClass
    {
        public QuickChatFrameBones(IntPtr address) : this(address, "QuickChatFrameBones")
        {
        }

        public QuickChatFrameBones(IntPtr address, string className) : base(address, className)
        {
        }

        public Transform m_ChatLog
        {
            get
            {
                return base.method_3<Transform>("m_ChatLog");
            }
        }

        public Transform m_InputBlocker
        {
            get
            {
                return base.method_3<Transform>("m_InputBlocker");
            }
        }

        public Transform m_InputBottomRight
        {
            get
            {
                return base.method_3<Transform>("m_InputBottomRight");
            }
        }

        public Transform m_InputTopLeft
        {
            get
            {
                return base.method_3<Transform>("m_InputTopLeft");
            }
        }

        public Transform m_LastMessage
        {
            get
            {
                return base.method_3<Transform>("m_LastMessage");
            }
        }

        public Transform m_RecentPlayerDropdown
        {
            get
            {
                return base.method_3<Transform>("m_RecentPlayerDropdown");
            }
        }
    }
}

