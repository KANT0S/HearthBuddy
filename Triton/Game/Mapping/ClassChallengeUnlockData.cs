namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ClassChallengeUnlockData")]
    public class ClassChallengeUnlockData : RewardData
    {
        public ClassChallengeUnlockData(IntPtr address) : this(address, "ClassChallengeUnlockData")
        {
        }

        public ClassChallengeUnlockData(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetGameObjectName()
        {
            return base.method_13("GetGameObjectName", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public int WingID
        {
            get
            {
                return base.method_11<int>("get_WingID", Array.Empty<object>());
            }
        }
    }
}

