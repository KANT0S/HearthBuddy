namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GamesWonIndicator")]
    public class GamesWonIndicator : MonoBehaviour
    {
        public GamesWonIndicator(IntPtr address) : this(address, "GamesWonIndicator")
        {
        }

        public GamesWonIndicator(IntPtr address, string className) : base(address, className)
        {
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Init(Reward.Type rewardType, int rewardAmount, int numSegments, int numActiveSegments, InnKeeperTrigger trigger)
        {
            object[] objArray1 = new object[] { rewardType, rewardAmount, numSegments, numActiveSegments, trigger };
            base.method_8("Init", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public static float FUDGE_FACTOR
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GamesWonIndicator", "FUDGE_FACTOR");
            }
        }

        public GamesWonIndicatorSegment m_gamesWonSegmentPrefab
        {
            get
            {
                return base.method_3<GamesWonIndicatorSegment>("m_gamesWonSegmentPrefab");
            }
        }

        public InnKeeperTrigger m_innkeeperTrigger
        {
            get
            {
                return base.method_2<InnKeeperTrigger>("m_innkeeperTrigger");
            }
        }

        public int m_numActiveSegments
        {
            get
            {
                return base.method_2<int>("m_numActiveSegments");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public GameObject m_segmentContainer
        {
            get
            {
                return base.method_3<GameObject>("m_segmentContainer");
            }
        }

        public List<GamesWonIndicatorSegment> m_segments
        {
            get
            {
                Class267<GamesWonIndicatorSegment> class2 = base.method_3<Class267<GamesWonIndicatorSegment>>("m_segments");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_winCountText
        {
            get
            {
                return base.method_3<UberText>("m_winCountText");
            }
        }

        public enum InnKeeperTrigger
        {
            NONE
        }
    }
}

