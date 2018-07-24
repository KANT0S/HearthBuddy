namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FriendListFriendFrame")]
    public class FriendListFriendFrame : FriendListBaseFriendFrame
    {
        public FriendListFriendFrame(IntPtr address) : this(address, "FriendListFriendFrame")
        {
        }

        public FriendListFriendFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public Vector3 AddWidth(Component component)
        {
            object[] objArray1 = new object[] { component };
            return base.method_11<Vector3>("AddWidth", objArray1);
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

        public static void OnKickSpectatorDialogResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "FriendListFriendFrame", "OnKickSpectatorDialogResponse", objArray1);
        }

        public static void OnLeaveSpectatingDialogResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "FriendListFriendFrame", "OnLeaveSpectatingDialogResponse", objArray1);
        }

        public static void OnPlayerChallengeButtonPressed(FriendListChallengeButton challengeButton, BnetPlayer player)
        {
            object[] objArray1 = new object[] { challengeButton, player };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "FriendListFriendFrame", "OnPlayerChallengeButtonPressed", objArray1);
        }

        public bool SetFriend(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_11<bool>("SetFriend", objArray1);
        }

        public void UpdateFriend()
        {
            base.method_8("UpdateFriend", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public FriendListFriendFrameBones m_Bones
        {
            get
            {
                return base.method_3<FriendListFriendFrameBones>("m_Bones");
            }
        }

        public FriendListChallengeButton m_ChallengeButton
        {
            get
            {
                return base.method_3<FriendListChallengeButton>("m_ChallengeButton");
            }
        }

        public FriendListFriendFrameOffsets m_Offsets
        {
            get
            {
                return base.method_3<FriendListFriendFrameOffsets>("m_Offsets");
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

        public static float REFRESH_FRIENDS_SECONDS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FriendListFriendFrame", "REFRESH_FRIENDS_SECONDS");
            }
        }
    }
}

