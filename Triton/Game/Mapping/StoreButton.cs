namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("StoreButton")]
    public class StoreButton : PegUIElement
    {
        public StoreButton(IntPtr address) : this(address, "StoreButton")
        {
        }

        public StoreButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool IsVisualClosed()
        {
            return base.method_11<bool>("IsVisualClosed", Array.Empty<object>());
        }

        public void OnButtonOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnButtonOut", objArray1);
        }

        public void OnButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnButtonOver", objArray1);
        }

        public void OnStoreStatusChanged(bool isOpen, object userData)
        {
            object[] objArray1 = new object[] { isOpen, userData };
            base.method_8("OnStoreStatusChanged", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public GameObject m_highlight
        {
            get
            {
                return base.method_3<GameObject>("m_highlight");
            }
        }

        public HighlightState m_highlightState
        {
            get
            {
                return base.method_3<HighlightState>("m_highlightState");
            }
        }

        public GameObject m_storeClosed
        {
            get
            {
                return base.method_3<GameObject>("m_storeClosed");
            }
        }

        public UberText m_storeClosedText
        {
            get
            {
                return base.method_3<UberText>("m_storeClosedText");
            }
        }

        public UberText m_storeText
        {
            get
            {
                return base.method_3<UberText>("m_storeText");
            }
        }
    }
}

