namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("CanvasAnchors")]
    public class CanvasAnchors : MonoClass
    {
        public CanvasAnchors(IntPtr address) : this(address, "CanvasAnchors")
        {
        }

        public CanvasAnchors(IntPtr address, string className) : base(address, className)
        {
        }

        public Transform GetAnchor(CanvasAnchor type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_14<Transform>("GetAnchor", objArray1);
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public Transform m_BottomLeft
        {
            get
            {
                return base.method_3<Transform>("m_BottomLeft");
            }
        }

        public Transform m_BottomRight
        {
            get
            {
                return base.method_3<Transform>("m_BottomRight");
            }
        }

        public Transform m_Center
        {
            get
            {
                return base.method_3<Transform>("m_Center");
            }
        }

        public Transform m_TopLeft
        {
            get
            {
                return base.method_3<Transform>("m_TopLeft");
            }
        }

        public Transform m_TopRight
        {
            get
            {
                return base.method_3<Transform>("m_TopRight");
            }
        }
    }
}

