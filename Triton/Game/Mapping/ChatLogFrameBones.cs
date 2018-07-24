namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ChatLogFrameBones")]
    public class ChatLogFrameBones : MonoClass
    {
        public ChatLogFrameBones(IntPtr address) : this(address, "ChatLogFrameBones")
        {
        }

        public ChatLogFrameBones(IntPtr address, string className) : base(address, className)
        {
        }

        public Transform m_MessagesBottomRight
        {
            get
            {
                return base.method_3<Transform>("m_MessagesBottomRight");
            }
        }

        public Transform m_MessagesTopLeft
        {
            get
            {
                return base.method_3<Transform>("m_MessagesTopLeft");
            }
        }

        public Transform m_PlayerIcon
        {
            get
            {
                return base.method_3<Transform>("m_PlayerIcon");
            }
        }
    }
}

