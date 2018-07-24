namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UIBScrollableTrack")]
    public class UIBScrollableTrack : MonoBehaviour
    {
        public UIBScrollableTrack(IntPtr address) : this(address, "UIBScrollableTrack")
        {
        }

        public UIBScrollableTrack(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void OnScrollEnabled(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("OnScrollEnabled", objArray1);
        }

        public Vector3 m_hideRotation
        {
            get
            {
                return base.method_2<Vector3>("m_hideRotation");
            }
        }

        public bool m_lastEnabled
        {
            get
            {
                return base.method_2<bool>("m_lastEnabled");
            }
        }

        public UIBScrollable m_parentScrollbar
        {
            get
            {
                return base.method_3<UIBScrollable>("m_parentScrollbar");
            }
        }

        public float m_rotateAnimationTime
        {
            get
            {
                return base.method_2<float>("m_rotateAnimationTime");
            }
        }

        public GameObject m_scrollTrack
        {
            get
            {
                return base.method_3<GameObject>("m_scrollTrack");
            }
        }

        public Vector3 m_showRotation
        {
            get
            {
                return base.method_2<Vector3>("m_showRotation");
            }
        }
    }
}

