namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ChatLogFramePrefabs")]
    public class ChatLogFramePrefabs : MonoClass
    {
        public ChatLogFramePrefabs(IntPtr address) : this(address, "ChatLogFramePrefabs")
        {
        }

        public ChatLogFramePrefabs(IntPtr address, string className) : base(address, className)
        {
        }

        public PlayerIcon m_PlayerIcon
        {
            get
            {
                return base.method_3<PlayerIcon>("m_PlayerIcon");
            }
        }
    }
}

