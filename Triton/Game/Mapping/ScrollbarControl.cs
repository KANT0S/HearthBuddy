namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ScrollbarControl")]
    public class ScrollbarControl : MonoBehaviour
    {
        public ScrollbarControl(IntPtr address) : this(address, "ScrollbarControl")
        {
        }

        public ScrollbarControl(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FireFinishEvent()
        {
            base.method_8("FireFinishEvent", Array.Empty<object>());
        }

        public void FireUpdateEvent()
        {
            base.method_8("FireUpdateEvent", Array.Empty<object>());
        }

        public float GetValue()
        {
            return base.method_11<float>("GetValue", Array.Empty<object>());
        }

        public void HandleOutOfBounds()
        {
            base.method_8("HandleOutOfBounds", Array.Empty<object>());
        }

        public void HandlePress()
        {
            base.method_8("HandlePress", Array.Empty<object>());
        }

        public void HandleRelease()
        {
            base.method_8("HandleRelease", Array.Empty<object>());
        }

        public void HandleThumbUpdate()
        {
            base.method_8("HandleThumbUpdate", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnMouseOnOrOffScreen(bool onScreen)
        {
            object[] objArray1 = new object[] { onScreen };
            base.method_8("OnMouseOnOrOffScreen", objArray1);
        }

        public void OnPressElementPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnPressElementPress", objArray1);
        }

        public void OnPressElementReleaseAll(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnPressElementReleaseAll", objArray1);
        }

        public void SetValue(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetValue", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateDrag()
        {
            base.method_8("UpdateDrag", Array.Empty<object>());
        }

        public void UpdateThumb()
        {
            base.method_8("UpdateThumb", Array.Empty<object>());
        }

        public Collider m_DragCollider
        {
            get
            {
                return base.method_3<Collider>("m_DragCollider");
            }
        }

        public bool m_dragging
        {
            get
            {
                return base.method_2<bool>("m_dragging");
            }
        }

        public Transform m_LeftBone
        {
            get
            {
                return base.method_3<Transform>("m_LeftBone");
            }
        }

        public PegUIElement m_PressElement
        {
            get
            {
                return base.method_3<PegUIElement>("m_PressElement");
            }
        }

        public float m_prevThumbUnitPos
        {
            get
            {
                return base.method_2<float>("m_prevThumbUnitPos");
            }
        }

        public Transform m_RightBone
        {
            get
            {
                return base.method_3<Transform>("m_RightBone");
            }
        }

        public GameObject m_Thumb
        {
            get
            {
                return base.method_3<GameObject>("m_Thumb");
            }
        }

        public float m_thumbUnitPos
        {
            get
            {
                return base.method_2<float>("m_thumbUnitPos");
            }
        }
    }
}

