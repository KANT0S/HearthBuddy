namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FriendListNearbyPlayerFrameOffsets")]
    public class FriendListNearbyPlayerFrameOffsets : MonoClass
    {
        public FriendListNearbyPlayerFrameOffsets(IntPtr address) : this(address, "FriendListNearbyPlayerFrameOffsets")
        {
        }

        public FriendListNearbyPlayerFrameOffsets(IntPtr address, string className) : base(address, className)
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
    }
}

