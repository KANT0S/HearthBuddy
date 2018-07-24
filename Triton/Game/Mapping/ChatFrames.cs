namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ChatFrames")]
    public class ChatFrames : MonoBehaviour
    {
        public ChatFrames(IntPtr address) : this(address, "ChatFrames")
        {
        }

        public ChatFrames(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Back()
        {
            base.method_8("Back", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void OnCloseButtonReleased()
        {
            base.method_8("OnCloseButtonReleased", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFramesMoved()
        {
            base.method_8("OnFramesMoved", Array.Empty<object>());
        }

        public void OnPopupClosed()
        {
            base.method_8("OnPopupClosed", Array.Empty<object>());
        }

        public void OnPopupOpened()
        {
            base.method_8("OnPopupOpened", Array.Empty<object>());
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public MobileChatLogFrame chatLogFrame
        {
            get
            {
                return base.method_3<MobileChatLogFrame>("chatLogFrame");
            }
        }

        public BnetPlayer Receiver
        {
            get
            {
                return base.method_14<BnetPlayer>("get_Receiver", Array.Empty<object>());
            }
        }

        public bool wasShowingDialog
        {
            get
            {
                return base.method_2<bool>("wasShowingDialog");
            }
        }
    }
}

