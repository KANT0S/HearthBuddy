namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("UIBScrollable")]
    public class UIBScrollable : PegUICustomBehavior
    {
        public UIBScrollable(IntPtr address) : this(address, "UIBScrollable")
        {
        }

        public UIBScrollable(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddScroll(float amount)
        {
            object[] objArray1 = new object[] { amount };
            base.method_8("AddScroll", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CenterWorldPosition(Vector3 position)
        {
            object[] objArray1 = new object[] { position };
            base.method_8("CenterWorldPosition", objArray1);
        }

        public static void DefaultVisibleAffectedCallback(GameObject obj, bool visible)
        {
            object[] objArray1 = new object[] { obj, visible };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "UIBScrollable", "DefaultVisibleAffectedCallback", objArray1);
        }

        public void Drag()
        {
            base.method_8("Drag", Array.Empty<object>());
        }

        public void Enable(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("Enable", objArray1);
        }

        public bool EnableIfNeeded()
        {
            return base.method_11<bool>("EnableIfNeeded", Array.Empty<object>());
        }

        public void FireEnableScrollEvent()
        {
            base.method_8("FireEnableScrollEvent", Array.Empty<object>());
        }

        public void FireTouchEndEvent()
        {
            base.method_8("FireTouchEndEvent", Array.Empty<object>());
        }

        public void FireTouchStartEvent()
        {
            base.method_8("FireTouchStartEvent", Array.Empty<object>());
        }

        public void ForceVisibleAffectedObjectsShow(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ForceVisibleAffectedObjectsShow", objArray1);
        }

        public float GetOutOfBoundsDist(float scrollValue)
        {
            object[] objArray1 = new object[] { scrollValue };
            return base.method_11<float>("GetOutOfBoundsDist", objArray1);
        }

        public float GetScroll()
        {
            return base.method_11<float>("GetScroll", Array.Empty<object>());
        }

        public float GetScrollableItemsHeight()
        {
            return base.method_11<float>("GetScrollableItemsHeight", Array.Empty<object>());
        }

        public float GetScrollBoundsHeight()
        {
            return base.method_11<float>("GetScrollBoundsHeight", Array.Empty<object>());
        }

        public Camera GetScrollCamera()
        {
            return base.method_14<Camera>("GetScrollCamera", Array.Empty<object>());
        }

        public Vector3 GetScrollTrackBtm()
        {
            return base.method_11<Vector3>("GetScrollTrackBtm", Array.Empty<object>());
        }

        public float GetScrollTrackBtm1D()
        {
            return base.method_11<float>("GetScrollTrackBtm1D", Array.Empty<object>());
        }

        public Vector3 GetScrollTrackTop()
        {
            return base.method_11<Vector3>("GetScrollTrackTop", Array.Empty<object>());
        }

        public float GetScrollTrackTop1D()
        {
            return base.method_11<float>("GetScrollTrackTop1D", Array.Empty<object>());
        }

        public float GetScrollValueDelta(float worldDelta)
        {
            object[] objArray1 = new object[] { worldDelta };
            return base.method_11<float>("GetScrollValueDelta", objArray1);
        }

        public float GetTotalScrollHeight()
        {
            return base.method_11<float>("GetTotalScrollHeight", Array.Empty<object>());
        }

        public Vector3 GetTotalScrollHeightVector()
        {
            return base.method_11<Vector3>("GetTotalScrollHeightVector", Array.Empty<object>());
        }

        public bool IsDragging()
        {
            return base.method_11<bool>("IsDragging", Array.Empty<object>());
        }

        public bool IsEnabled()
        {
            return base.method_11<bool>("IsEnabled", Array.Empty<object>());
        }

        public bool IsEnabledAndScrollable()
        {
            return base.method_11<bool>("IsEnabledAndScrollable", Array.Empty<object>());
        }

        public bool IsObjectVisibleInScrollArea(GameObject obj, Vector3 extents)
        {
            object[] objArray1 = new object[] { obj, extents };
            return base.method_11<bool>("IsObjectVisibleInScrollArea", objArray1);
        }

        public bool IsScrollNeeded()
        {
            return base.method_11<bool>("IsScrollNeeded", Array.Empty<object>());
        }

        public bool IsTouchDragging()
        {
            return base.method_11<bool>("IsTouchDragging", Array.Empty<object>());
        }

        public void LoadScroll(string savedName)
        {
            object[] objArray1 = new object[] { savedName };
            base.method_8("LoadScroll", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Pause(bool pause)
        {
            object[] objArray1 = new object[] { pause };
            base.method_8("Pause", objArray1);
        }

        public float PollScrollHeight()
        {
            return base.method_11<float>("PollScrollHeight", Array.Empty<object>());
        }

        public void ResetScrollStartPosition()
        {
            base.method_9("ResetScrollStartPosition", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void ResetScrollStartPosition(Vector3 position)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { position };
            base.method_9("ResetScrollStartPosition", enumArray1, objArray1);
        }

        public void ResetTouchDrag()
        {
            base.method_8("ResetTouchDrag", Array.Empty<object>());
        }

        public void SaveScroll(string savedName)
        {
            object[] objArray1 = new object[] { savedName };
            base.method_8("SaveScroll", objArray1);
        }

        public void SetHeight(float height)
        {
            object[] objArray1 = new object[] { height };
            base.method_8("SetHeight", objArray1);
        }

        public void SetScroll(float percentage, bool blockInputWhileScrolling, bool clamp)
        {
            object[] objArray1 = new object[] { percentage, blockInputWhileScrolling, clamp };
            base.method_9("SetScroll", new Class272.Enum20[] { Class272.Enum20.R4 }, objArray1);
        }

        public void SetScroll(float percentage, iTween.EaseType tweenType, float tweenTime, bool blockInputWhileScrolling, bool clamp)
        {
            object[] objArray1 = new object[] { percentage, tweenType, tweenTime, blockInputWhileScrolling, clamp };
            base.method_9("SetScroll", new Class272.Enum20[] { Class272.Enum20.R4 }, objArray1);
        }

        public void SetScrollSnap(float percentage, bool clamp)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { percentage, clamp };
            base.method_9("SetScrollSnap", enumArray1, objArray1);
        }

        public void StartDragging()
        {
            base.method_8("StartDragging", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateAndFireVisibleAffectedObjects()
        {
            base.method_8("UpdateAndFireVisibleAffectedObjects", Array.Empty<object>());
        }

        public void UpdateHeight()
        {
            base.method_8("UpdateHeight", Array.Empty<object>());
        }

        public void UpdateScroll()
        {
            base.method_8("UpdateScroll", Array.Empty<object>());
        }

        public void UpdateThumbPosition()
        {
            base.method_8("UpdateThumbPosition", Array.Empty<object>());
        }

        public void UpdateTouch()
        {
            base.method_8("UpdateTouch", Array.Empty<object>());
        }

        public bool UpdateUI()
        {
            return base.method_11<bool>("UpdateUI", Array.Empty<object>());
        }

        public float m_DeckTileDragThreshold
        {
            get
            {
                return base.method_2<float>("m_DeckTileDragThreshold");
            }
        }

        public bool m_Enabled
        {
            get
            {
                return base.method_2<bool>("m_Enabled");
            }
        }

        public bool m_ForceScrollAreaHitTest
        {
            get
            {
                return base.method_2<bool>("m_ForceScrollAreaHitTest");
            }
        }

        public bool m_ForceShowVisibleAffectedObjects
        {
            get
            {
                return base.method_2<bool>("m_ForceShowVisibleAffectedObjects");
            }
        }

        public HeightMode m_HeightMode
        {
            get
            {
                return base.method_2<HeightMode>("m_HeightMode");
            }
        }

        public bool m_HideThumbWhenDisabled
        {
            get
            {
                return base.method_2<bool>("m_HideThumbWhenDisabled");
            }
        }

        public bool m_InputBlocked
        {
            get
            {
                return base.method_2<bool>("m_InputBlocked");
            }
        }

        public float m_KineticScrollFriction
        {
            get
            {
                return base.method_2<float>("m_KineticScrollFriction");
            }
        }

        public float m_LastScrollHeightRecorded
        {
            get
            {
                return base.method_2<float>("m_LastScrollHeightRecorded");
            }
        }

        public float m_LastTouchScrollValue
        {
            get
            {
                return base.method_2<float>("m_LastTouchScrollValue");
            }
        }

        public float m_MinKineticScrollSpeed
        {
            get
            {
                return base.method_2<float>("m_MinKineticScrollSpeed");
            }
        }

        public float m_MinOutOfBoundsScrollValue
        {
            get
            {
                return base.method_2<float>("m_MinOutOfBoundsScrollValue");
            }
        }

        public bool m_OverridePegUI
        {
            get
            {
                return base.method_2<bool>("m_OverridePegUI");
            }
        }

        public bool m_Pause
        {
            get
            {
                return base.method_2<bool>("m_Pause");
            }
        }

        public float m_PolledScrollHeight
        {
            get
            {
                return base.method_2<float>("m_PolledScrollHeight");
            }
        }

        public Vector3 m_ScrollAreaStartPos
        {
            get
            {
                return base.method_2<Vector3>("m_ScrollAreaStartPos");
            }
        }

        public float m_ScrollBottomPadding
        {
            get
            {
                return base.method_2<float>("m_ScrollBottomPadding");
            }
        }

        public BoxCollider m_ScrollBounds
        {
            get
            {
                return base.method_3<BoxCollider>("m_ScrollBounds");
            }
        }

        public float m_ScrollBoundsSpringK
        {
            get
            {
                return base.method_2<float>("m_ScrollBoundsSpringK");
            }
        }

        public float m_ScrollDeltaMultiplier
        {
            get
            {
                return base.method_2<float>("m_ScrollDeltaMultiplier");
            }
        }

        public bool m_ScrollDirectionReverse
        {
            get
            {
                return base.method_2<bool>("m_ScrollDirectionReverse");
            }
        }

        public float m_ScrollDragThreshold
        {
            get
            {
                return base.method_2<float>("m_ScrollDragThreshold");
            }
        }

        public iTween.EaseType m_ScrollEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_ScrollEaseType");
            }
        }

        public GameObject m_ScrollObject
        {
            get
            {
                return base.method_3<GameObject>("m_ScrollObject");
            }
        }

        public ScrollDirection m_ScrollPlane
        {
            get
            {
                return base.method_2<ScrollDirection>("m_ScrollPlane");
            }
        }

        public ScrollBarThumb m_ScrollThumb
        {
            get
            {
                return base.method_3<ScrollBarThumb>("m_ScrollThumb");
            }
        }

        public BoxCollider m_ScrollTrack
        {
            get
            {
                return base.method_3<BoxCollider>("m_ScrollTrack");
            }
        }

        public float m_ScrollTweenTime
        {
            get
            {
                return base.method_2<float>("m_ScrollTweenTime");
            }
        }

        public float m_ScrollValue
        {
            get
            {
                return base.method_2<float>("m_ScrollValue");
            }
        }

        public float m_ScrollWheelAmount
        {
            get
            {
                return base.method_2<float>("m_ScrollWheelAmount");
            }
        }

        public float m_TouchDragBeginScrollValue
        {
            get
            {
                return base.method_2<float>("m_TouchDragBeginScrollValue");
            }
        }

        public BoxCollider m_TouchDragFullArea
        {
            get
            {
                return base.method_3<BoxCollider>("m_TouchDragFullArea");
            }
        }

        public List<BoxCollider> m_TouchScrollBlockers
        {
            get
            {
                Class267<BoxCollider> class2 = base.method_3<Class267<BoxCollider>>("m_TouchScrollBlockers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_UseCameraFromLayer
        {
            get
            {
                return base.method_2<bool>("m_UseCameraFromLayer");
            }
        }

        public List<VisibleAffectedObject> m_VisibleAffectedObjects
        {
            get
            {
                Class267<VisibleAffectedObject> class2 = base.method_3<Class267<VisibleAffectedObject>>("m_VisibleAffectedObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_VisibleObjectThreshold
        {
            get
            {
                return base.method_2<float>("m_VisibleObjectThreshold");
            }
        }

        public float ScrollValue
        {
            get
            {
                return base.method_11<float>("get_ScrollValue", Array.Empty<object>());
            }
        }

        public enum HeightMode
        {
            UseHeightCallback,
            UseScrollableItem,
            UseBoxCollider
        }

        public enum ScrollDirection
        {
            X,
            Y,
            Z
        }

        [Attribute38("UIBScrollable.VisibleAffectedObject")]
        public class VisibleAffectedObject : MonoClass
        {
            public VisibleAffectedObject(IntPtr address) : this(address, "VisibleAffectedObject")
            {
            }

            public VisibleAffectedObject(IntPtr address, string className) : base(address, className)
            {
            }

            public Vector3 Extents
            {
                get
                {
                    return base.method_2<Vector3>("Extents");
                }
            }

            public GameObject Obj
            {
                get
                {
                    return base.method_3<GameObject>("Obj");
                }
            }

            public bool Visible
            {
                get
                {
                    return base.method_2<bool>("Visible");
                }
            }
        }
    }
}

