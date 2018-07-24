namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("GamesWonSegment")]
    public class GamesWonSegment : MonoClass
    {
        public GamesWonSegment(IntPtr address) : this(address, "GamesWonSegment")
        {
        }

        public GamesWonSegment(IntPtr address, string className) : base(address, className)
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

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Init(Reward.Type rewardType, int rewardAmount, bool hideCrown)
        {
            object[] objArray1 = new object[] { rewardType, rewardAmount, hideCrown };
            base.method_8("Init", objArray1);
        }

        public GamesWonCrown m_crown
        {
            get
            {
                return base.method_3<GamesWonCrown>("m_crown");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }
    }
}

