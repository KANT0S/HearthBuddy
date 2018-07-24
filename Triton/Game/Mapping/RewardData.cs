namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("RewardData")]
    public class RewardData : MonoClass
    {
        public RewardData(IntPtr address) : this(address, "RewardData")
        {
        }

        public RewardData(IntPtr address, string className) : base(address, className)
        {
        }

        public void AcknowledgeNotices()
        {
            base.method_8("AcknowledgeNotices", Array.Empty<object>());
        }

        public void AddNoticeID(long noticeID)
        {
            object[] objArray1 = new object[] { noticeID };
            base.method_8("AddNoticeID", objArray1);
        }

        public string GetGameObjectName()
        {
            return base.method_13("GetGameObjectName", Array.Empty<object>());
        }

        public List<long> GetNoticeIDs()
        {
            Class266<long> class2 = base.method_14<Class266<long>>("GetNoticeIDs", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void MarkAsDummyReward()
        {
            base.method_8("MarkAsDummyReward", Array.Empty<object>());
        }

        public void OnRewardObjectLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnRewardObjectLoaded", objArray1);
        }

        public void SetOrigin(NetCache.ProfileNotice.NoticeOrigin origin, long originData)
        {
            object[] objArray1 = new object[] { origin, originData };
            base.method_8("SetOrigin", objArray1);
        }

        public bool IsDummyReward
        {
            get
            {
                return base.method_11<bool>("get_IsDummyReward", Array.Empty<object>());
            }
        }

        public bool m_isDummyReward
        {
            get
            {
                return base.method_2<bool>("m_isDummyReward");
            }
        }

        public List<long> m_noticeIDs
        {
            get
            {
                Class266<long> class2 = base.method_3<Class266<long>>("m_noticeIDs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public NetCache.ProfileNotice.NoticeOrigin m_origin
        {
            get
            {
                return base.method_2<NetCache.ProfileNotice.NoticeOrigin>("m_origin");
            }
        }

        public long m_originData
        {
            get
            {
                return base.method_2<long>("m_originData");
            }
        }

        public Reward.Type m_type
        {
            get
            {
                return base.method_2<Reward.Type>("m_type");
            }
        }

        public NetCache.ProfileNotice.NoticeOrigin Origin
        {
            get
            {
                return base.method_11<NetCache.ProfileNotice.NoticeOrigin>("get_Origin", Array.Empty<object>());
            }
        }

        public long OriginData
        {
            get
            {
                return base.method_11<long>("get_OriginData", Array.Empty<object>());
            }
        }

        public Reward.Type RewardType
        {
            get
            {
                return base.method_11<Reward.Type>("get_RewardType", Array.Empty<object>());
            }
        }
    }
}

