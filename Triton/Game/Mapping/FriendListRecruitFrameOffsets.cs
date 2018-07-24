namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FriendListRecruitFrameOffsets")]
    public class FriendListRecruitFrameOffsets : MonoClass
    {
        public FriendListRecruitFrameOffsets(IntPtr address) : this(address, "FriendListRecruitFrameOffsets")
        {
        }

        public FriendListRecruitFrameOffsets(IntPtr address, string className) : base(address, className)
        {
        }

        public Vector3 m_PlayerNameText
        {
            get
            {
                return base.method_2<Vector3>("m_PlayerNameText");
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

