namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Scrollbar")]
    public class Scrollbar : MonoBehaviour
    {
        public Scrollbar(IntPtr address) : this(address, "Scrollbar")
        {
        }

        public Scrollbar(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Drag()
        {
            base.method_8("Drag", Array.Empty<object>());
        }

        public void GetBoundsOfChildren(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            base.method_8("GetBoundsOfChildren", objArray1);
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public bool InputIsOver()
        {
            return base.method_11<bool>("InputIsOver", Array.Empty<object>());
        }

        public bool IsActive()
        {
            return base.method_11<bool>("IsActive", Array.Empty<object>());
        }

        public void OverrideScrollWindowHeight(float scrollWindowHeight)
        {
            object[] objArray1 = new object[] { scrollWindowHeight };
            base.method_8("OverrideScrollWindowHeight", objArray1);
        }

        public void Scroll(float amount, bool lerp)
        {
            object[] objArray1 = new object[] { amount, lerp };
            base.method_8("Scroll", objArray1);
        }

        public void ScrollDown()
        {
            base.method_8("ScrollDown", Array.Empty<object>());
        }

        public void ScrollTo(float value, bool clamp, bool lerp)
        {
            object[] objArray1 = new object[] { value, clamp, lerp };
            base.method_8("ScrollTo", objArray1);
        }

        public void ScrollUp()
        {
            base.method_8("ScrollUp", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowThumb(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowThumb", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateScrollAreaBounds()
        {
            base.method_8("UpdateScrollAreaBounds", Array.Empty<object>());
        }

        public void UpdateScrollAreaPosition(bool tween)
        {
            object[] objArray1 = new object[] { tween };
            base.method_8("UpdateScrollAreaPosition", objArray1);
        }

        public void UpdateThumbPosition()
        {
            base.method_8("UpdateThumbPosition", Array.Empty<object>());
        }

        public Bounds m_childrenBounds
        {
            get
            {
                return base.method_2<Bounds>("m_childrenBounds");
            }
        }

        public bool m_isActive
        {
            get
            {
                return base.method_2<bool>("m_isActive");
            }
        }

        public bool m_isDragging
        {
            get
            {
                return base.method_2<bool>("m_isDragging");
            }
        }

        public GameObject m_scrollArea
        {
            get
            {
                return base.method_3<GameObject>("m_scrollArea");
            }
        }

        public Vector3 m_scrollAreaEndPos
        {
            get
            {
                return base.method_2<Vector3>("m_scrollAreaEndPos");
            }
        }

        public Vector3 m_scrollAreaStartPos
        {
            get
            {
                return base.method_2<Vector3>("m_scrollAreaStartPos");
            }
        }

        public float m_scrollValue
        {
            get
            {
                return base.method_2<float>("m_scrollValue");
            }
        }

        public BoxCollider m_scrollWindow
        {
            get
            {
                return base.method_3<BoxCollider>("m_scrollWindow");
            }
        }

        public float m_scrollWindowHeight
        {
            get
            {
                return base.method_2<float>("m_scrollWindowHeight");
            }
        }

        public Vector3 m_sliderEndLocalPos
        {
            get
            {
                return base.method_2<Vector3>("m_sliderEndLocalPos");
            }
        }

        public Vector3 m_sliderStartLocalPos
        {
            get
            {
                return base.method_2<Vector3>("m_sliderStartLocalPos");
            }
        }

        public float m_stepSize
        {
            get
            {
                return base.method_2<float>("m_stepSize");
            }
        }

        public ScrollBarThumb m_thumb
        {
            get
            {
                return base.method_3<ScrollBarThumb>("m_thumb");
            }
        }

        public Vector3 m_thumbPosition
        {
            get
            {
                return base.method_2<Vector3>("m_thumbPosition");
            }
        }

        public GameObject m_track
        {
            get
            {
                return base.method_3<GameObject>("m_track");
            }
        }

        public float ScrollValue
        {
            get
            {
                return base.method_11<float>("get_ScrollValue", Array.Empty<object>());
            }
        }
    }
}

