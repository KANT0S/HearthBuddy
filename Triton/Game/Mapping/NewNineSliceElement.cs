namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NewNineSliceElement")]
    public class NewNineSliceElement : MonoBehaviour
    {
        public NewNineSliceElement(IntPtr address) : this(address, "NewNineSliceElement")
        {
        }

        public NewNineSliceElement(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetPieceHeight(GameObject piece, float height)
        {
            object[] objArray1 = new object[] { piece, height };
            base.method_8("SetPieceHeight", objArray1);
        }

        public void SetPieceWidth(GameObject piece, float width)
        {
            object[] objArray1 = new object[] { piece, width };
            base.method_8("SetPieceWidth", objArray1);
        }

        public void SetSize(float width, float height)
        {
            object[] objArray1 = new object[] { width, height };
            base.method_8("SetSize", objArray1);
        }

        public GameObject m_anchorBone
        {
            get
            {
                return base.method_3<GameObject>("m_anchorBone");
            }
        }

        public GameObject m_bottom
        {
            get
            {
                return base.method_3<GameObject>("m_bottom");
            }
        }

        public GameObject m_bottomLeft
        {
            get
            {
                return base.method_3<GameObject>("m_bottomLeft");
            }
        }

        public GameObject m_bottomRight
        {
            get
            {
                return base.method_3<GameObject>("m_bottomRight");
            }
        }

        public GameObject m_left
        {
            get
            {
                return base.method_3<GameObject>("m_left");
            }
        }

        public GameObject m_middle
        {
            get
            {
                return base.method_3<GameObject>("m_middle");
            }
        }

        public Vector2 m_middleScale
        {
            get
            {
                return base.method_2<Vector2>("m_middleScale");
            }
        }

        public Mode m_mode
        {
            get
            {
                return base.method_2<Mode>("m_mode");
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

        public PlaneAxis m_planeAxis
        {
            get
            {
                return base.method_2<PlaneAxis>("m_planeAxis");
            }
        }

        public GameObject m_right
        {
            get
            {
                return base.method_3<GameObject>("m_right");
            }
        }

        public Vector2 m_size
        {
            get
            {
                return base.method_2<Vector2>("m_size");
            }
        }

        public GameObject m_top
        {
            get
            {
                return base.method_3<GameObject>("m_top");
            }
        }

        public GameObject m_topLeft
        {
            get
            {
                return base.method_3<GameObject>("m_topLeft");
            }
        }

        public GameObject m_topRight
        {
            get
            {
                return base.method_3<GameObject>("m_topRight");
            }
        }

        public enum Mode
        {
            UseMiddleScale,
            UseSize
        }

        public enum PinnedPoint
        {
            TOPLEFT,
            TOP,
            TOPRIGHT,
            LEFT,
            MIDDLE,
            RIGHT,
            BOTTOMLEFT,
            BOTTOM,
            BOTTOMRIGHT
        }

        public enum PlaneAxis
        {
            XY,
            XZ
        }
    }
}

