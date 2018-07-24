namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ChatMgrPrefabs")]
    public class ChatMgrPrefabs : MonoClass
    {
        public ChatMgrPrefabs(IntPtr address) : this(address, "ChatMgrPrefabs")
        {
        }

        public ChatMgrPrefabs(IntPtr address, string className) : base(address, className)
        {
        }

        public ChatBubbleFrame m_ChatBubbleOneLineFrame
        {
            get
            {
                return base.method_3<ChatBubbleFrame>("m_ChatBubbleOneLineFrame");
            }
        }

        public ChatBubbleFrame m_ChatBubbleSmallFrame
        {
            get
            {
                return base.method_3<ChatBubbleFrame>("m_ChatBubbleSmallFrame");
            }
        }

        public FriendListFrame m_friendListFramePrefab
        {
            get
            {
                return base.method_3<FriendListFrame>("m_friendListFramePrefab");
            }
        }
    }
}

