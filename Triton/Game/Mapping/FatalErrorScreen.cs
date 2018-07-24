namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FatalErrorScreen")]
    public class FatalErrorScreen : MonoBehaviour
    {
        public FatalErrorScreen(IntPtr address) : this(address, "FatalErrorScreen")
        {
        }

        public FatalErrorScreen(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnClick(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnClick", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool m_allowClick
        {
            get
            {
                return base.method_2<bool>("m_allowClick");
            }
        }

        public Camera m_camera
        {
            get
            {
                return base.method_3<Camera>("m_camera");
            }
        }

        public UberText m_closedSignText
        {
            get
            {
                return base.method_3<UberText>("m_closedSignText");
            }
        }

        public UberText m_closedSignTitle
        {
            get
            {
                return base.method_3<UberText>("m_closedSignTitle");
            }
        }

        public float m_delayBeforeNextReset
        {
            get
            {
                return base.method_2<float>("m_delayBeforeNextReset");
            }
        }

        public UberText m_errorCodeText
        {
            get
            {
                return base.method_3<UberText>("m_errorCodeText");
            }
        }

        public PegUIElement m_inputBlocker
        {
            get
            {
                return base.method_3<PegUIElement>("m_inputBlocker");
            }
        }

        public UberText m_reconnectTip
        {
            get
            {
                return base.method_3<UberText>("m_reconnectTip");
            }
        }

        public bool m_redirectToStore
        {
            get
            {
                return base.method_2<bool>("m_redirectToStore");
            }
        }
    }
}

