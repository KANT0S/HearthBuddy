namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BaseUIPrefabs")]
    public class BaseUIPrefabs : MonoClass
    {
        public BaseUIPrefabs(IntPtr address) : this(address, "BaseUIPrefabs")
        {
        }

        public BaseUIPrefabs(IntPtr address, string className) : base(address, className)
        {
        }

        public ChatMgr m_ChatMgrPrefab
        {
            get
            {
                return base.method_3<ChatMgr>("m_ChatMgrPrefab");
            }
        }
    }
}

