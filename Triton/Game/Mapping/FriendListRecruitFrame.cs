namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("FriendListRecruitFrame")]
    public class FriendListRecruitFrame : MonoBehaviour
    {
        public FriendListRecruitFrame(IntPtr address) : this(address, "FriendListRecruitFrame")
        {
        }

        public FriendListRecruitFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public float ComputeLeftComponentWidth(Transform bone, Vector3 offset, Component rightComponent)
        {
            object[] objArray1 = new object[] { bone, offset, rightComponent };
            return base.method_11<float>("ComputeLeftComponentWidth", objArray1);
        }

        public Network.RecruitInfo GetRecruitInfo()
        {
            return base.method_14<Network.RecruitInfo>("GetRecruitInfo", Array.Empty<object>());
        }

        public void LayoutLeftText(UberText text, Transform bone, Vector3 offset, Component rightComponent)
        {
            object[] objArray1 = new object[] { text, bone, offset, rightComponent };
            base.method_8("LayoutLeftText", objArray1);
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void SetRecruitInfo(Network.RecruitInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SetRecruitInfo", objArray1);
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateRecruit()
        {
            base.method_8("UpdateRecruit", Array.Empty<object>());
        }

        public FriendListRecruitFrameBones m_Bones
        {
            get
            {
                return base.method_3<FriendListRecruitFrameBones>("m_Bones");
            }
        }

        public FriendListRecruitFrameOffsets m_Offsets
        {
            get
            {
                return base.method_3<FriendListRecruitFrameOffsets>("m_Offsets");
            }
        }

        public UberText m_PlayerNameText
        {
            get
            {
                return base.method_3<UberText>("m_PlayerNameText");
            }
        }

        public FriendListRecruitFramePrefabs m_Prefabs
        {
            get
            {
                return base.method_3<FriendListRecruitFramePrefabs>("m_Prefabs");
            }
        }

        public Network.RecruitInfo m_recruitInfo
        {
            get
            {
                return base.method_3<Network.RecruitInfo>("m_recruitInfo");
            }
        }

        public FriendListRecruitUI m_RecruitUI
        {
            get
            {
                return base.method_3<FriendListRecruitUI>("m_RecruitUI");
            }
        }

        public List<Component> m_rightComponentOrder
        {
            get
            {
                Class247<Component> class2 = base.method_3<Class247<Component>>("m_rightComponentOrder");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_StatusText
        {
            get
            {
                return base.method_3<UberText>("m_StatusText");
            }
        }
    }
}

