namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BaseUI")]
    public class BaseUI : MonoBehaviour
    {
        public BaseUI(IntPtr address) : this(address, "BaseUI")
        {
        }

        public BaseUI(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static BaseUI Get()
        {
            return MonoClass.smethod_15<BaseUI>(TritonHs.MainAssemblyPath, "", "BaseUI", "Get", Array.Empty<object>());
        }

        public Transform GetAddFriendBone()
        {
            return base.method_14<Transform>("GetAddFriendBone", Array.Empty<object>());
        }

        public Camera GetBnetCamera()
        {
            return base.method_14<Camera>("GetBnetCamera", Array.Empty<object>());
        }

        public Camera GetBnetDialogCamera()
        {
            return base.method_14<Camera>("GetBnetDialogCamera", Array.Empty<object>());
        }

        public Transform GetChatBubbleBone()
        {
            return base.method_14<Transform>("GetChatBubbleBone", Array.Empty<object>());
        }

        public Transform GetGameMenuBone(bool withRatings)
        {
            object[] objArray1 = new object[] { withRatings };
            return base.method_14<Transform>("GetGameMenuBone", objArray1);
        }

        public Transform GetOptionsMenuBone()
        {
            return base.method_14<Transform>("GetOptionsMenuBone", Array.Empty<object>());
        }

        public Transform GetQuickChatBone()
        {
            return base.method_14<Transform>("GetQuickChatBone", Array.Empty<object>());
        }

        public Transform GetRecruitAFriendBone()
        {
            return base.method_14<Transform>("GetRecruitAFriendBone", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public void OnLoggedIn()
        {
            base.method_8("OnLoggedIn", Array.Empty<object>());
        }

        public void OnScreenSizeChanged(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnScreenSizeChanged", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void TakeScreenshot()
        {
            base.method_8("TakeScreenshot", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public BnetBar m_BnetBar
        {
            get
            {
                return base.method_3<BnetBar>("m_BnetBar");
            }
        }

        public Camera m_BnetCamera
        {
            get
            {
                return base.method_3<Camera>("m_BnetCamera");
            }
        }

        public Camera m_BnetDialogCamera
        {
            get
            {
                return base.method_3<Camera>("m_BnetDialogCamera");
            }
        }

        public BaseUIBones m_Bones
        {
            get
            {
                return base.method_3<BaseUIBones>("m_Bones");
            }
        }

        public ExistingAccountPopup m_ExistingAccountPopup
        {
            get
            {
                return base.method_3<ExistingAccountPopup>("m_ExistingAccountPopup");
            }
        }

        public BaseUIPrefabs m_Prefabs
        {
            get
            {
                return base.method_3<BaseUIPrefabs>("m_Prefabs");
            }
        }
    }
}

