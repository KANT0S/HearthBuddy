namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RightGamesWonSegment")]
    public class RightGamesWonSegment : GamesWonSegment
    {
        public RightGamesWonSegment(IntPtr address) : this(address, "RightGamesWonSegment")
        {
        }

        public RightGamesWonSegment(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateReward()
        {
            base.method_8("AnimateReward", Array.Empty<object>());
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

        public GameObject m_boosterRoot
        {
            get
            {
                return base.method_3<GameObject>("m_boosterRoot");
            }
        }

        public UberText m_dustAmountText
        {
            get
            {
                return base.method_3<UberText>("m_dustAmountText");
            }
        }

        public GameObject m_dustRoot
        {
            get
            {
                return base.method_3<GameObject>("m_dustRoot");
            }
        }

        public UberText m_goldAmountText
        {
            get
            {
                return base.method_3<UberText>("m_goldAmountText");
            }
        }

        public GameObject m_goldRoot
        {
            get
            {
                return base.method_3<GameObject>("m_goldRoot");
            }
        }

        public Reward.Type m_rewardType
        {
            get
            {
                return base.method_2<Reward.Type>("m_rewardType");
            }
        }
    }
}

