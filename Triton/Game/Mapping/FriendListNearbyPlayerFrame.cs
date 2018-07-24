namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("FriendListNearbyPlayerFrame")]
    public class FriendListNearbyPlayerFrame : MonoBehaviour
    {
        public FriendListNearbyPlayerFrame(IntPtr address) : this(address, "FriendListNearbyPlayerFrame")
        {
        }

        public FriendListNearbyPlayerFrame(IntPtr address, string className) : base(address, className)
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

        public BnetPlayer GetNearbyPlayer()
        {
            return base.method_14<BnetPlayer>("GetNearbyPlayer", Array.Empty<object>());
        }

        public void LayoutLeftText(UberText text, Transform bone, Vector3 offset, Component rightComponent)
        {
            object[] objArray1 = new object[] { text, bone, offset, rightComponent };
            base.method_8("LayoutLeftText", objArray1);
        }

        public void OnChallengeButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnChallengeButtonReleased", objArray1);
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public bool SetNearbyPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("SetNearbyPlayer", objArray1);
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateNearbyPlayer()
        {
            base.method_8("UpdateNearbyPlayer", Array.Empty<object>());
        }

        public FriendListNearbyPlayerFrameBones m_Bones
        {
            get
            {
                return base.method_3<FriendListNearbyPlayerFrameBones>("m_Bones");
            }
        }

        public FriendListChallengeButton m_ChallengeButton
        {
            get
            {
                return base.method_3<FriendListChallengeButton>("m_ChallengeButton");
            }
        }

        public FriendListNearbyPlayerFrameOffsets m_Offsets
        {
            get
            {
                return base.method_3<FriendListNearbyPlayerFrameOffsets>("m_Offsets");
            }
        }

        public BnetPlayer m_player
        {
            get
            {
                return base.method_3<BnetPlayer>("m_player");
            }
        }

        public UberText m_PlayerNameText
        {
            get
            {
                return base.method_3<UberText>("m_PlayerNameText");
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
    }
}

