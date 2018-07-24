namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PegUIElement")]
    public class PegUIElement : MonoBehaviour
    {
        public PegUIElement(IntPtr address) : this(address, "PegUIElement")
        {
        }

        public PegUIElement(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearEventListeners()
        {
            base.method_8("ClearEventListeners", Array.Empty<object>());
        }

        public void DispatchEvent(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("DispatchEvent", objArray1);
        }

        public PegCursor.Mode GetCursorDown()
        {
            return base.method_11<PegCursor.Mode>("GetCursorDown", Array.Empty<object>());
        }

        public PegCursor.Mode GetCursorOver()
        {
            return base.method_11<PegCursor.Mode>("GetCursorOver", Array.Empty<object>());
        }

        public object GetData()
        {
            return base.method_14<object>("GetData", Array.Empty<object>());
        }

        public bool GetDoubleClickEnabled()
        {
            return base.method_11<bool>("GetDoubleClickEnabled", Array.Empty<object>());
        }

        public float GetDragTolerance()
        {
            return base.method_11<float>("GetDragTolerance", Array.Empty<object>());
        }

        public InteractionState GetInteractionState()
        {
            return base.method_11<InteractionState>("GetInteractionState", Array.Empty<object>());
        }

        public Vector3 GetOriginalLocalPosition()
        {
            return base.method_11<Vector3>("GetOriginalLocalPosition", Array.Empty<object>());
        }

        public bool GetReceiveOverWithMouseDown()
        {
            return base.method_11<bool>("GetReceiveOverWithMouseDown", Array.Empty<object>());
        }

        public bool GetReceiveReleaseWithoutMouseDown()
        {
            return base.method_11<bool>("GetReceiveReleaseWithoutMouseDown", Array.Empty<object>());
        }

        public bool HasEventListener(UIEventType type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_11<bool>("HasEventListener", objArray1);
        }

        public bool HasOverriddenDoubleClick()
        {
            return base.method_11<bool>("HasOverriddenDoubleClick", Array.Empty<object>());
        }

        public bool IsEnabled()
        {
            return base.method_11<bool>("IsEnabled", Array.Empty<object>());
        }

        public void OnDoubleClick()
        {
            base.method_8("OnDoubleClick", Array.Empty<object>());
        }

        public void OnHold()
        {
            base.method_8("OnHold", Array.Empty<object>());
        }

        public void OnOut(InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void OnReleaseAll(bool mouseIsOver)
        {
            object[] objArray1 = new object[] { mouseIsOver };
            base.method_8("OnReleaseAll", objArray1);
        }

        public void OnRightClick()
        {
            base.method_8("OnRightClick", Array.Empty<object>());
        }

        public void OnTap()
        {
            base.method_8("OnTap", Array.Empty<object>());
        }

        public void SetCursorDown(PegCursor.Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("SetCursorDown", objArray1);
        }

        public void SetCursorOver(PegCursor.Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("SetCursorOver", objArray1);
        }

        public void SetData(object data)
        {
            object[] objArray1 = new object[] { data };
            base.method_8("SetData", objArray1);
        }

        public void SetDragTolerance(float newTolerance)
        {
            object[] objArray1 = new object[] { newTolerance };
            base.method_8("SetDragTolerance", objArray1);
        }

        public void SetEnabled(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("SetEnabled", objArray1);
        }

        public void SetInteractionState(InteractionState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("SetInteractionState", objArray1);
        }

        public void SetOriginalLocalPosition()
        {
            base.method_9("SetOriginalLocalPosition", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void SetOriginalLocalPosition(Vector3 pos)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { pos };
            base.method_9("SetOriginalLocalPosition", enumArray1, objArray1);
        }

        public void SetReceiveReleaseWithoutMouseDown(bool receiveReleaseWithoutMouseDown)
        {
            object[] objArray1 = new object[] { receiveReleaseWithoutMouseDown };
            base.method_8("SetReceiveReleaseWithoutMouseDown", objArray1);
        }

        public void TriggerDoubleClick()
        {
            base.method_8("TriggerDoubleClick", Array.Empty<object>());
        }

        public void TriggerHold()
        {
            base.method_8("TriggerHold", Array.Empty<object>());
        }

        public void TriggerOut()
        {
            base.method_8("TriggerOut", Array.Empty<object>());
        }

        public void TriggerOver()
        {
            base.method_8("TriggerOver", Array.Empty<object>());
        }

        public void TriggerPress()
        {
            base.method_8("TriggerPress", Array.Empty<object>());
        }

        public void TriggerRelease()
        {
            base.method_8("TriggerRelease", Array.Empty<object>());
        }

        public void TriggerReleaseAll(bool mouseIsOver)
        {
            object[] objArray1 = new object[] { mouseIsOver };
            base.method_8("TriggerReleaseAll", objArray1);
        }

        public void TriggerRightClick()
        {
            base.method_8("TriggerRightClick", Array.Empty<object>());
        }

        public void TriggerTap()
        {
            base.method_8("TriggerTap", Array.Empty<object>());
        }

        public Collider m_collider
        {
            get
            {
                return base.method_3<Collider>("m_collider");
            }
        }

        public PegCursor.Mode m_cursorDownOverride
        {
            get
            {
                return base.method_2<PegCursor.Mode>("m_cursorDownOverride");
            }
        }

        public PegCursor.Mode m_cursorOverOverride
        {
            get
            {
                return base.method_2<PegCursor.Mode>("m_cursorOverOverride");
            }
        }

        public object m_data
        {
            get
            {
                return base.method_3<object>("m_data");
            }
        }

        public bool m_doubleClickEnabled
        {
            get
            {
                return base.method_2<bool>("m_doubleClickEnabled");
            }
        }

        public float m_dragTolerance
        {
            get
            {
                return base.method_2<float>("m_dragTolerance");
            }
        }

        public bool m_enabled
        {
            get
            {
                return base.method_2<bool>("m_enabled");
            }
        }

        public bool m_focused
        {
            get
            {
                return base.method_2<bool>("m_focused");
            }
        }

        public InteractionState m_interactionState
        {
            get
            {
                return base.method_2<InteractionState>("m_interactionState");
            }
        }

        public Vector3 m_originalLocalPosition
        {
            get
            {
                return base.method_2<Vector3>("m_originalLocalPosition");
            }
        }

        public bool m_receiveReleaseWithoutMouseDown
        {
            get
            {
                return base.method_2<bool>("m_receiveReleaseWithoutMouseDown");
            }
        }

        public MeshRenderer m_renderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_renderer");
            }
        }

        public enum InteractionState
        {
            None,
            Out,
            Over,
            Down,
            Up,
            Disabled
        }
    }
}

