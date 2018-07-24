namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GamesWonIndicatorSegment")]
    public class GamesWonIndicatorSegment : MonoBehaviour
    {
        public GamesWonIndicatorSegment(IntPtr address) : this(address, "GamesWonIndicatorSegment")
        {
        }

        public GamesWonIndicatorSegment(IntPtr address, string className) : base(address, className)
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

        public void Init(Type segmentType, Reward.Type rewardType, int rewardAmount, bool hideCrown)
        {
            object[] objArray1 = new object[] { segmentType, rewardType, rewardAmount, hideCrown };
            base.method_8("Init", objArray1);
        }

        public GamesWonSegment m_activeSegment
        {
            get
            {
                return base.method_3<GamesWonSegment>("m_activeSegment");
            }
        }

        public GamesWonSegment m_leftSegment
        {
            get
            {
                return base.method_3<GamesWonSegment>("m_leftSegment");
            }
        }

        public MiddleGamesWonSegment m_middleSegment
        {
            get
            {
                return base.method_3<MiddleGamesWonSegment>("m_middleSegment");
            }
        }

        public RightGamesWonSegment m_rightSegment
        {
            get
            {
                return base.method_3<RightGamesWonSegment>("m_rightSegment");
            }
        }

        public enum Type
        {
            LEFT,
            MIDDLE,
            RIGHT
        }
    }
}

