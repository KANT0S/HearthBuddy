namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MiddleGamesWonSegment")]
    public class MiddleGamesWonSegment : GamesWonSegment
    {
        public MiddleGamesWonSegment(IntPtr address) : this(address, "MiddleGamesWonSegment")
        {
        }

        public MiddleGamesWonSegment(IntPtr address, string className) : base(address, className)
        {
        }

        public float GetWidth()
        {
            return base.method_11<float>("GetWidth", Array.Empty<object>());
        }

        public void Init(Reward.Type rewardType, int rewardAmount, bool hideCrown)
        {
            object[] objArray1 = new object[] { rewardType, rewardAmount, hideCrown };
            base.method_8("Init", objArray1);
        }

        public GameObject m_activeRoot
        {
            get
            {
                return base.method_3<GameObject>("m_activeRoot");
            }
        }

        public GameObject m_root1
        {
            get
            {
                return base.method_3<GameObject>("m_root1");
            }
        }

        public GameObject m_root2
        {
            get
            {
                return base.method_3<GameObject>("m_root2");
            }
        }
    }
}

