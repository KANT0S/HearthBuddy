namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BaseUIBones")]
    public class BaseUIBones : MonoClass
    {
        public BaseUIBones(IntPtr address) : this(address, "BaseUIBones")
        {
        }

        public BaseUIBones(IntPtr address, string className) : base(address, className)
        {
        }

        public Transform m_AddFriend
        {
            get
            {
                return base.method_3<Transform>("m_AddFriend");
            }
        }

        public Transform m_AddFriendAndroidKeyboard
        {
            get
            {
                return base.method_3<Transform>("m_AddFriendAndroidKeyboard");
            }
        }

        public Transform m_AddFriendPhoneKeyboard
        {
            get
            {
                return base.method_3<Transform>("m_AddFriendPhoneKeyboard");
            }
        }

        public Transform m_AddFriendVirtualKeyboard
        {
            get
            {
                return base.method_3<Transform>("m_AddFriendVirtualKeyboard");
            }
        }

        public Transform m_BoxMenu
        {
            get
            {
                return base.method_3<Transform>("m_BoxMenu");
            }
        }

        public Transform m_BoxMenuWithRatings
        {
            get
            {
                return base.method_3<Transform>("m_BoxMenuWithRatings");
            }
        }

        public Transform m_ChatBubble
        {
            get
            {
                return base.method_3<Transform>("m_ChatBubble");
            }
        }

        public Transform m_InGameMenu
        {
            get
            {
                return base.method_3<Transform>("m_InGameMenu");
            }
        }

        public Transform m_OptionsMenu
        {
            get
            {
                return base.method_3<Transform>("m_OptionsMenu");
            }
        }

        public Transform m_QuickChat
        {
            get
            {
                return base.method_3<Transform>("m_QuickChat");
            }
        }

        public Transform m_QuickChatVirtualKeyboard
        {
            get
            {
                return base.method_3<Transform>("m_QuickChatVirtualKeyboard");
            }
        }

        public Transform m_RecruitAFriend
        {
            get
            {
                return base.method_3<Transform>("m_RecruitAFriend");
            }
        }

        public Transform m_RecruitAFriendVirtualKeyboard
        {
            get
            {
                return base.method_3<Transform>("m_RecruitAFriendVirtualKeyboard");
            }
        }
    }
}

