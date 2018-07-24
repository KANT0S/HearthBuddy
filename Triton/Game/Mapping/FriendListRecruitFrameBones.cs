namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FriendListRecruitFrameBones")]
    public class FriendListRecruitFrameBones : MonoClass
    {
        public FriendListRecruitFrameBones(IntPtr address) : this(address, "FriendListRecruitFrameBones")
        {
        }

        public FriendListRecruitFrameBones(IntPtr address, string className) : base(address, className)
        {
        }

        public Transform m_PlayerNameText
        {
            get
            {
                return base.method_3<Transform>("m_PlayerNameText");
            }
        }

        public Transform m_RightComponent
        {
            get
            {
                return base.method_3<Transform>("m_RightComponent");
            }
        }

        public Transform m_StatusText
        {
            get
            {
                return base.method_3<Transform>("m_StatusText");
            }
        }
    }
}

