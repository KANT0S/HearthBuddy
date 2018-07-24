namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TouchList")]
    public class TouchList : PegUIElement
    {
        public TouchList(IntPtr address) : this(address, "TouchList")
        {
        }

        public TouchList(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Bounds CalculateLocalClipBounds()
        {
            return base.method_11<Bounds>("CalculateLocalClipBounds", Array.Empty<object>());
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public void EnforceInitialized()
        {
            base.method_8("EnforceInitialized", Array.Empty<object>());
        }

        public void FixUpScrolling()
        {
            base.method_8("FixUpScrolling", Array.Empty<object>());
        }

        public float GetBreadthPosition(int itemIndex)
        {
            object[] objArray1 = new object[] { itemIndex };
            return base.method_11<float>("GetBreadthPosition", objArray1);
        }

        public float GetItemDragDelta(Vector3 touchPosition)
        {
            object[] objArray1 = new object[] { touchPosition };
            return base.method_11<float>("GetItemDragDelta", objArray1);
        }

        public Vector3 GetNegatedScale(Vector3 scale)
        {
            object[] objArray1 = new object[] { scale };
            return base.method_11<Vector3>("GetNegatedScale", objArray1);
        }

        public int GetNumItemsAheadOfView()
        {
            return base.method_11<int>("GetNumItemsAheadOfView", Array.Empty<object>());
        }

        public int GetNumItemsBehindView()
        {
            return base.method_11<int>("GetNumItemsBehindView", Array.Empty<object>());
        }

        public float GetOutOfBoundsDist(float contentPosition)
        {
            object[] objArray1 = new object[] { contentPosition };
            return base.method_11<float>("GetOutOfBoundsDist", objArray1);
        }

        public Vector3 GetTouchPosition()
        {
            return base.method_11<Vector3>("GetTouchPosition", Array.Empty<object>());
        }

        public int GetVector2Dimension(int vec3Dimension)
        {
            object[] objArray1 = new object[] { vec3Dimension };
            return base.method_11<int>("GetVector2Dimension", objArray1);
        }

        public int GetVector3Dimension(int vec2Dimension)
        {
            object[] objArray1 = new object[] { vec2Dimension };
            return base.method_11<int>("GetVector3Dimension", objArray1);
        }

        public bool IsItemVisible(int visualizedListIndex)
        {
            object[] objArray1 = new object[] { visualizedListIndex };
            return base.method_11<bool>("IsItemVisible", objArray1);
        }

        public void LoadAhead()
        {
            base.method_8("LoadAhead", Array.Empty<object>());
        }

        public void LoadBehind()
        {
            base.method_8("LoadBehind", Array.Empty<object>());
        }

        public void OnHover(bool isKnownOver)
        {
            object[] objArray1 = new object[] { isKnownOver };
            base.method_8("OnHover", objArray1);
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
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

        public void OnScrolled()
        {
            base.method_8("OnScrolled", Array.Empty<object>());
        }

        public void OnScrollingEnabledChanged()
        {
            base.method_8("OnScrollingEnabledChanged", Array.Empty<object>());
        }

        public void PreBufferLongListItems(bool scrolledAhead)
        {
            object[] objArray1 = new object[] { scrolledAhead };
            base.method_8("PreBufferLongListItems", objArray1);
        }

        public bool RecalculateLongListContentSize(bool fireOnScroll)
        {
            object[] objArray1 = new object[] { fireOnScroll };
            return base.method_11<bool>("RecalculateLongListContentSize", objArray1);
        }

        public void RecalculateSize()
        {
            base.method_8("RecalculateSize", Array.Empty<object>());
        }

        public void RefreshList(int startingLongListIndex, bool preserveScrolling)
        {
            object[] objArray1 = new object[] { startingLongListIndex, preserveScrolling };
            base.method_8("RefreshList", objArray1);
        }

        public void RemoveAt(int index)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { index };
            base.method_9("RemoveAt", enumArray1, objArray1);
        }

        public void RemoveAt(int index, bool repositionItems)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { index, repositionItems };
            base.method_9("RemoveAt", enumArray1, objArray1);
        }

        public void ResetState()
        {
            base.method_8("ResetState", Array.Empty<object>());
        }

        public void ResumeLayout(bool repositionItems)
        {
            object[] objArray1 = new object[] { repositionItems };
            base.method_8("ResumeLayout", objArray1);
        }

        public void SetVisibilityOfAllItems()
        {
            base.method_8("SetVisibilityOfAllItems", Array.Empty<object>());
        }

        public void SuspendLayout()
        {
            base.method_8("SuspendLayout", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateBackgroundBounds()
        {
            base.method_8("UpdateBackgroundBounds", Array.Empty<object>());
        }

        public void UpdateBackgroundScroll()
        {
            base.method_8("UpdateBackgroundScroll", Array.Empty<object>());
        }

        public void UpdateMouseInput()
        {
            base.method_8("UpdateMouseInput", Array.Empty<object>());
        }

        public void UpdateTouchInput()
        {
            base.method_8("UpdateTouchInput", Array.Empty<object>());
        }

        public void ValidateBreadth()
        {
            base.method_8("ValidateBreadth", Array.Empty<object>());
        }

        public Alignment alignment
        {
            get
            {
                return base.method_2<Alignment>("alignment");
            }
        }

        public bool allowModification
        {
            get
            {
                return base.method_2<bool>("allowModification");
            }
        }

        public TiledBackground background
        {
            get
            {
                return base.method_3<TiledBackground>("background");
            }
        }

        public int breadth
        {
            get
            {
                return base.method_2<int>("breadth");
            }
        }

        public bool CanScrollAhead
        {
            get
            {
                return base.method_11<bool>("get_CanScrollAhead", Array.Empty<object>());
            }
        }

        public bool CanScrollBehind
        {
            get
            {
                return base.method_11<bool>("get_CanScrollBehind", Array.Empty<object>());
            }
        }

        public Vector2 ClipSize
        {
            get
            {
                return base.method_11<Vector2>("get_ClipSize", Array.Empty<object>());
            }
        }

        public static float CLIPSIZE_EPSILON
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TouchList", "CLIPSIZE_EPSILON");
            }
        }

        public GameObject content
        {
            get
            {
                return base.method_3<GameObject>("content");
            }
        }

        public float contentSize
        {
            get
            {
                return base.method_2<float>("contentSize");
            }
        }

        public int Count
        {
            get
            {
                return base.method_11<int>("get_Count", Array.Empty<object>());
            }
        }

        public Vector3 dragBeginContentPosition
        {
            get
            {
                return base.method_2<Vector3>("dragBeginContentPosition");
            }
        }

        public float elementSpacing
        {
            get
            {
                return base.method_2<float>("elementSpacing");
            }
        }

        public float excessContentSize
        {
            get
            {
                return base.method_2<float>("excessContentSize");
            }
        }

        public bool IsInitialized
        {
            get
            {
                return base.method_11<bool>("get_IsInitialized", Array.Empty<object>());
            }
        }

        public bool IsLayoutSuspended
        {
            get
            {
                return base.method_11<bool>("get_IsLayoutSuspended", Array.Empty<object>());
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return base.method_11<bool>("get_IsReadOnly", Array.Empty<object>());
            }
        }

        public float itemDragFinishDistance
        {
            get
            {
                return base.method_2<float>("itemDragFinishDistance");
            }
        }

        public static float ItemDragThreshold
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TouchList", "ItemDragThreshold");
            }
        }

        public static float KineticScrollFriction
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TouchList", "KineticScrollFriction");
            }
        }

        public float lastContentPosition
        {
            get
            {
                return base.method_2<float>("lastContentPosition");
            }
        }

        public Vector3 lastTouchPosition
        {
            get
            {
                return base.method_2<Vector3>("lastTouchPosition");
            }
        }

        public int layoutDimension1
        {
            get
            {
                return base.method_2<int>("layoutDimension1");
            }
        }

        public int layoutDimension2
        {
            get
            {
                return base.method_2<int>("layoutDimension2");
            }
        }

        public int layoutDimension3
        {
            get
            {
                return base.method_2<int>("layoutDimension3");
            }
        }

        public LayoutPlane layoutPlane
        {
            get
            {
                return base.method_2<LayoutPlane>("layoutPlane");
            }
        }

        public bool layoutSuspended
        {
            get
            {
                return base.method_2<bool>("layoutSuspended");
            }
        }

        public float m_fullListContentSize
        {
            get
            {
                return base.method_2<float>("m_fullListContentSize");
            }
        }

        public PegUIElement m_hoveredOverItem
        {
            get
            {
                return base.method_3<PegUIElement>("m_hoveredOverItem");
            }
        }

        public bool m_isHoveredOverTouchList
        {
            get
            {
                return base.method_2<bool>("m_isHoveredOverTouchList");
            }
        }

        public static float MinKineticScrollSpeed
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TouchList", "MinKineticScrollSpeed");
            }
        }

        public static float MinOutOfBoundsDistance
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TouchList", "MinOutOfBoundsDistance");
            }
        }

        public Orientation orientation
        {
            get
            {
                return base.method_2<Orientation>("orientation");
            }
        }

        public Vector2 padding
        {
            get
            {
                return base.method_2<Vector2>("padding");
            }
        }

        public float ScrollableAmount
        {
            get
            {
                return base.method_11<float>("get_ScrollableAmount", Array.Empty<object>());
            }
        }

        public static float ScrollBoundsSpringB
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TouchList", "ScrollBoundsSpringB");
            }
        }

        public static float ScrollBoundsSpringK
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TouchList", "ScrollBoundsSpringK");
            }
        }

        public static float ScrollDragThreshold
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TouchList", "ScrollDragThreshold");
            }
        }

        public float ScrollValue
        {
            get
            {
                return base.method_11<float>("get_ScrollValue", Array.Empty<object>());
            }
        }

        public float scrollWheelIncrement
        {
            get
            {
                return base.method_2<float>("scrollWheelIncrement");
            }
        }

        public int SelectedIndex
        {
            get
            {
                return base.method_11<int>("get_SelectedIndex", Array.Empty<object>());
            }
        }

        public bool SelectionEnabled
        {
            get
            {
                return base.method_11<bool>("get_SelectionEnabled", Array.Empty<object>());
            }
        }

        public float ViewWindowMaxValue
        {
            get
            {
                return base.method_11<float>("get_ViewWindowMaxValue", Array.Empty<object>());
            }
        }

        public float ViewWindowMinValue
        {
            get
            {
                return base.method_11<float>("get_ViewWindowMinValue", Array.Empty<object>());
            }
        }

        public enum Alignment
        {
            Min,
            Mid,
            Max
        }

        [Attribute38("TouchList.ItemInfo")]
        public class ItemInfo : MonoClass
        {
            public ItemInfo(IntPtr address) : this(address, "ItemInfo")
            {
            }

            public ItemInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public bool Contains(Vector2 point, TouchList.LayoutPlane layoutPlane)
            {
                object[] objArray1 = new object[] { point, layoutPlane };
                return base.method_11<bool>("Contains", objArray1);
            }

            public int LongListIndex
            {
                get
                {
                    return base.method_11<int>("get_LongListIndex", Array.Empty<object>());
                }
            }

            public Vector3 Max
            {
                get
                {
                    return base.method_11<Vector3>("get_Max", Array.Empty<object>());
                }
            }

            public Vector3 Min
            {
                get
                {
                    return base.method_11<Vector3>("get_Min", Array.Empty<object>());
                }
            }

            public Vector3 Offset
            {
                get
                {
                    return base.method_11<Vector3>("get_Offset", Array.Empty<object>());
                }
            }

            public Vector3 Size
            {
                get
                {
                    return base.method_11<Vector3>("get_Size", Array.Empty<object>());
                }
            }
        }

        public enum LayoutPlane
        {
            XY,
            XZ
        }

        public enum Orientation
        {
            Horizontal,
            Vertical
        }
    }
}

