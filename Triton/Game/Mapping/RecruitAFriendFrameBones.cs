namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("RecruitAFriendFrameBones")]
    public class RecruitAFriendFrameBones : MonoClass
    {
        public RecruitAFriendFrameBones(IntPtr address) : this(address, "RecruitAFriendFrameBones")
        {
        }

        public RecruitAFriendFrameBones(IntPtr address, string className) : base(address, className)
        {
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
    }
}

