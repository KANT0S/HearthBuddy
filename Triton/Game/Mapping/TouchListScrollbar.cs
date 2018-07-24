namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TouchListScrollbar")]
    public class TouchListScrollbar : PegUIElement
    {
        public TouchListScrollbar(IntPtr address) : this(address, "TouchListScrollbar")
        {
        }

        public TouchListScrollbar(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Vector3 GetTouchPoint(Plane dragPlane, Camera camera)
        {
            object[] objArray1 = new object[] { dragPlane, camera };
            return base.method_11<Vector3>("GetTouchPoint", objArray1);
        }

        public void ShowThumb(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowThumb", objArray1);
        }

        public void ThumbPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ThumbPressed", objArray1);
        }

        public void TrackPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("TrackPressed", objArray1);
        }

        public void UpdateActive(bool canScroll)
        {
            object[] objArray1 = new object[] { canScroll };
            base.method_8("UpdateActive", objArray1);
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateThumb()
        {
            base.method_8("UpdateThumb", Array.Empty<object>());
        }

        public GameObject cover
        {
            get
            {
                return base.method_3<GameObject>("cover");
            }
        }

        public bool isActive
        {
            get
            {
                return base.method_2<bool>("isActive");
            }
        }

        public TouchList list
        {
            get
            {
                return base.method_3<TouchList>("list");
            }
        }

        public PegUIElement thumb
        {
            get
            {
                return base.method_3<PegUIElement>("thumb");
            }
        }

        public Transform thumbMax
        {
            get
            {
                return base.method_3<Transform>("thumbMax");
            }
        }

        public Transform thumbMin
        {
            get
            {
                return base.method_3<Transform>("thumbMin");
            }
        }

        public PegUIElement track
        {
            get
            {
                return base.method_3<PegUIElement>("track");
            }
        }
    }
}

