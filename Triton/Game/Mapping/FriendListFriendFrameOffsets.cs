namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FriendListFriendFrameOffsets")]
    public class FriendListFriendFrameOffsets : MonoClass
    {
        public FriendListFriendFrameOffsets(IntPtr address) : this(address, "FriendListFriendFrameOffsets")
        {
        }

        public FriendListFriendFrameOffsets(IntPtr address, string className) : base(address, className)
        {
        }

        public Vector3 m_PlayerNameText
        {
            get
            {
                return base.method_2<Vector3>("m_PlayerNameText");
            }
        }

        public Vector3 m_RecruitUI
        {
            get
            {
                return base.method_2<Vector3>("m_RecruitUI");
            }
        }

        public Vector3 m_RightComponent
        {
            get
            {
                return base.method_2<Vector3>("m_RightComponent");
            }
        }

        public Vector3 m_StatusText
        {
            get
            {
                return base.method_2<Vector3>("m_StatusText");
            }
        }
    }
}

