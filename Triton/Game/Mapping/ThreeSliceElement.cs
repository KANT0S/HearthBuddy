namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ThreeSliceElement")]
    public class ThreeSliceElement : MonoBehaviour
    {
        public ThreeSliceElement(IntPtr address) : this(address, "ThreeSliceElement")
        {
        }

        public ThreeSliceElement(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Vector3 GetMiddleSize()
        {
            return base.method_11<Vector3>("GetMiddleSize", Array.Empty<object>());
        }

        public Vector3 GetSize()
        {
            return base.method_10<Vector3>("GetSize", new Class272.Enum20[0], Array.Empty<object>());
        }

        public Vector3 GetSize(bool zIsHeight)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { zIsHeight };
            return base.method_10<Vector3>("GetSize", enumArray1, objArray1);
        }

        public void SetInitialValues()
        {
            base.method_8("SetInitialValues", Array.Empty<object>());
        }

        public void SetMiddleWidth(float globalWidth)
        {
            object[] objArray1 = new object[] { globalWidth };
            base.method_8("SetMiddleWidth", objArray1);
        }

        public void SetWidth(float globalWidth)
        {
            object[] objArray1 = new object[] { globalWidth };
            base.method_8("SetWidth", objArray1);
        }

        public void UpdateDisplay()
        {
            base.method_8("UpdateDisplay", Array.Empty<object>());
        }

        public Direction m_direction
        {
            get
            {
                return base.method_2<Direction>("m_direction");
            }
        }

        public Bounds m_initialMiddleBounds
        {
            get
            {
                return base.method_2<Bounds>("m_initialMiddleBounds");
            }
        }

        public Vector3 m_initialScale
        {
            get
            {
                return base.method_2<Vector3>("m_initialScale");
            }
        }

        public GameObject m_left
        {
            get
            {
                return base.method_3<GameObject>("m_left");
            }
        }

        public Vector3 m_leftOffset
        {
            get
            {
                return base.method_2<Vector3>("m_leftOffset");
            }
        }

        public GameObject m_middle
        {
            get
            {
                return base.method_3<GameObject>("m_middle");
            }
        }

        public Vector3 m_middleOffset
        {
            get
            {
                return base.method_2<Vector3>("m_middleOffset");
            }
        }

        public float m_middleScale
        {
            get
            {
                return base.method_2<float>("m_middleScale");
            }
        }

        public PinnedPoint m_pinnedPoint
        {
            get
            {
                return base.method_2<PinnedPoint>("m_pinnedPoint");
            }
        }

        public Vector3 m_pinnedPointOffset
        {
            get
            {
                return base.method_2<Vector3>("m_pinnedPointOffset");
            }
        }

        public GameObject m_right
        {
            get
            {
                return base.method_3<GameObject>("m_right");
            }
        }

        public Vector3 m_rightOffset
        {
            get
            {
                return base.method_2<Vector3>("m_rightOffset");
            }
        }

        public float m_width
        {
            get
            {
                return base.method_2<float>("m_width");
            }
        }

        public enum Direction
        {
            X,
            Y,
            Z
        }

        public enum PinnedPoint
        {
            LEFT,
            MIDDLE,
            RIGHT,
            TOP,
            BOTTOM
        }
    }
}

