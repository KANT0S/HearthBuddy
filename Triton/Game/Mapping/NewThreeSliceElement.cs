namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NewThreeSliceElement")]
    public class NewThreeSliceElement : MonoBehaviour
    {
        public NewThreeSliceElement(IntPtr address) : this(address, "NewThreeSliceElement")
        {
        }

        public NewThreeSliceElement(IntPtr address, string className) : base(address, className)
        {
        }

        public void DisplayOnXAxis()
        {
            base.method_8("DisplayOnXAxis", Array.Empty<object>());
        }

        public void DisplayOnYAxis()
        {
            base.method_8("DisplayOnYAxis", Array.Empty<object>());
        }

        public void DisplayOnZAxis()
        {
            base.method_8("DisplayOnZAxis", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void SetSize(Vector3 size)
        {
            object[] objArray1 = new object[] { size };
            base.method_8("SetSize", objArray1);
        }

        public Vector3 m_bottomAnchor
        {
            get
            {
                return base.method_2<Vector3>("m_bottomAnchor");
            }
        }

        public Direction m_direction
        {
            get
            {
                return base.method_2<Direction>("m_direction");
            }
        }

        public Transform m_identity
        {
            get
            {
                return base.method_3<Transform>("m_identity");
            }
        }

        public Vector3 m_leftAnchor
        {
            get
            {
                return base.method_2<Vector3>("m_leftAnchor");
            }
        }

        public Vector3 m_leftOffset
        {
            get
            {
                return base.method_2<Vector3>("m_leftOffset");
            }
        }

        public GameObject m_leftOrTop
        {
            get
            {
                return base.method_3<GameObject>("m_leftOrTop");
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

        public Vector3 m_middleScale
        {
            get
            {
                return base.method_2<Vector3>("m_middleScale");
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

        public Vector3 m_rightAnchor
        {
            get
            {
                return base.method_2<Vector3>("m_rightAnchor");
            }
        }

        public Vector3 m_rightOffset
        {
            get
            {
                return base.method_2<Vector3>("m_rightOffset");
            }
        }

        public GameObject m_rightOrBottom
        {
            get
            {
                return base.method_3<GameObject>("m_rightOrBottom");
            }
        }

        public Vector3 m_topAnchor
        {
            get
            {
                return base.method_2<Vector3>("m_topAnchor");
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

        public enum PlaneAxis
        {
            XY,
            XZ
        }
    }
}

