namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("AddFriendFrameBones")]
    public class AddFriendFrameBones : MonoClass
    {
        public AddFriendFrameBones(IntPtr address) : this(address, "AddFriendFrameBones")
        {
        }

        public AddFriendFrameBones(IntPtr address, string className) : base(address, className)
        {
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

