namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("RecruitListMgr")]
    public class RecruitListMgr : MonoClass
    {
        public RecruitListMgr(IntPtr address) : this(address, "RecruitListMgr")
        {
        }

        public RecruitListMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanAddMoreRecruits()
        {
            return base.method_11<bool>("CanAddMoreRecruits", Array.Empty<object>());
        }

        public void FireRecruitAcceptedEvent()
        {
            base.method_8("FireRecruitAcceptedEvent", Array.Empty<object>());
        }

        public void FireRecruitsChangedEvent()
        {
            base.method_8("FireRecruitsChangedEvent", Array.Empty<object>());
        }

        public static RecruitListMgr Get()
        {
            return MonoClass.smethod_15<RecruitListMgr>(TritonHs.MainAssemblyPath, "", "RecruitListMgr", "Get", Array.Empty<object>());
        }

        public Network.RecruitInfo GetRecruitInfoFromId(ulong uniqueID)
        {
            object[] objArray1 = new object[] { uniqueID };
            return base.method_14<Network.RecruitInfo>("GetRecruitInfoFromId", objArray1);
        }

        public List<Network.RecruitInfo> GetRecruitList()
        {
            Class267<Network.RecruitInfo> class2 = base.method_14<Class267<Network.RecruitInfo>>("GetRecruitList", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public static bool IsValidRecruitInput(string email)
        {
            object[] objArray1 = new object[] { email };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "RecruitListMgr", "IsValidRecruitInput", objArray1);
        }

        public void OnRecruitListResponse()
        {
            base.method_8("OnRecruitListResponse", Array.Empty<object>());
        }

        public void OnReset()
        {
            base.method_8("OnReset", Array.Empty<object>());
        }

        public void RecruitFriendCancel(ulong uniqueID)
        {
            object[] objArray1 = new object[] { uniqueID };
            base.method_8("RecruitFriendCancel", objArray1);
        }

        public void RefreshRecruitList()
        {
            base.method_8("RefreshRecruitList", Array.Empty<object>());
        }

        public int secondsSinceEpoch()
        {
            return base.method_11<int>("secondsSinceEpoch", Array.Empty<object>());
        }

        public void SendRecruitAFriendInvite(string email)
        {
            object[] objArray1 = new object[] { email };
            base.method_8("SendRecruitAFriendInvite", objArray1);
        }

        public List<Network.RecruitInfo> m_lastRecruits
        {
            get
            {
                Class267<Network.RecruitInfo> class2 = base.method_3<Class267<Network.RecruitInfo>>("m_lastRecruits");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Network.RecruitInfo> m_recruits
        {
            get
            {
                Class267<Network.RecruitInfo> class2 = base.method_3<Class267<Network.RecruitInfo>>("m_recruits");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public ulong s_id
        {
            get
            {
                return base.method_2<ulong>("s_id");
            }
        }

        public enum RecruitStatus
        {
            NOTHING,
            PENDING,
            INELIGIBLE,
            FAILED,
            ACCEPTED
        }
    }
}

