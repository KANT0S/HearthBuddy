namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FriendListFrameBasePrefabs")]
    public class FriendListFrameBasePrefabs : MonoClass
    {
        public FriendListFrameBasePrefabs(IntPtr address) : this(address, "FriendListFrameBasePrefabs")
        {
        }

        public FriendListFrameBasePrefabs(IntPtr address, string className) : base(address, className)
        {
        }

        public FriendListRecruitUI recruitUI
        {
            get
            {
                return base.method_3<FriendListRecruitUI>("recruitUI");
            }
        }
    }
}

