namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FriendListNearbyPlayerFrameBones")]
    public class FriendListNearbyPlayerFrameBones : MonoClass
    {
        public FriendListNearbyPlayerFrameBones(IntPtr address) : this(address, "FriendListNearbyPlayerFrameBones")
        {
        }

        public FriendListNearbyPlayerFrameBones(IntPtr address, string className) : base(address, className)
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
    }
}

