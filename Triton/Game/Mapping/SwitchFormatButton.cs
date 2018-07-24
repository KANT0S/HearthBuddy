namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SwitchFormatButton")]
    public class SwitchFormatButton : UIBButton
    {
        public SwitchFormatButton(IntPtr address) : this(address, "SwitchFormatButton")
        {
        }

        public SwitchFormatButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Disable()
        {
            base.method_8("Disable", Array.Empty<object>());
        }

        public void Enable()
        {
            base.method_8("Enable", Array.Empty<object>());
        }

        public void EnableHighlight(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("EnableHighlight", objArray1);
        }

        public void EnableHighlightImpl(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("EnableHighlightImpl", objArray1);
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void OnRotateComplete()
        {
            base.method_8("OnRotateComplete", Array.Empty<object>());
        }

        public void SetFormat(bool isWild, bool animate)
        {
            object[] objArray1 = new object[] { isWild, animate };
            base.method_8("SetFormat", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public MeshRenderer m_buttonRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_buttonRenderer");
            }
        }

        public bool m_cachedHighlightEnabled
        {
            get
            {
                return base.method_2<bool>("m_cachedHighlightEnabled");
            }
        }

        public bool m_cachedIsEnabled
        {
            get
            {
                return base.method_2<bool>("m_cachedIsEnabled");
            }
        }

        public GameObject m_coverObject
        {
            get
            {
                return base.method_3<GameObject>("m_coverObject");
            }
        }

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }

        public bool m_isHighlightEnabled
        {
            get
            {
                return base.method_2<bool>("m_isHighlightEnabled");
            }
        }

        public bool m_isRotating
        {
            get
            {
                return base.method_2<bool>("m_isRotating");
            }
        }

        public bool m_isWild
        {
            get
            {
                return base.method_2<bool>("m_isWild");
            }
        }
    }
}

