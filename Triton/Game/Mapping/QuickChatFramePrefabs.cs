namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("QuickChatFramePrefabs")]
    public class QuickChatFramePrefabs : MonoClass
    {
        public QuickChatFramePrefabs(IntPtr address) : this(address, "QuickChatFramePrefabs")
        {
        }

        public QuickChatFramePrefabs(IntPtr address, string className) : base(address, className)
        {
        }

        public ChatLogFrame m_ChatLogFrame
        {
            get
            {
                return base.method_3<ChatLogFrame>("m_ChatLogFrame");
            }
        }

        public DropdownControl m_Dropdown
        {
            get
            {
                return base.method_3<DropdownControl>("m_Dropdown");
            }
        }
    }
}

