namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FriendListRecruitFramePrefabs")]
    public class FriendListRecruitFramePrefabs : MonoClass
    {
        public FriendListRecruitFramePrefabs(IntPtr address) : this(address, "FriendListRecruitFramePrefabs")
        {
        }

        public FriendListRecruitFramePrefabs(IntPtr address, string className) : base(address, className)
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

