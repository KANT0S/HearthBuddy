namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CollectionPageManagerTouchBehavior")]
    public class CollectionPageManagerTouchBehavior : PegUICustomBehavior
    {
        public CollectionPageManagerTouchBehavior(IntPtr address) : this(address, "CollectionPageManagerTouchBehavior")
        {
        }

        public CollectionPageManagerTouchBehavior(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Vector2 GetTouchPosition()
        {
            return base.method_11<Vector2>("GetTouchPosition", Array.Empty<object>());
        }

        public PegUIElement HitTestPageTurnRegions()
        {
            return base.method_14<PegUIElement>("HitTestPageTurnRegions", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnPageDraggableRegionDown(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnPageDraggableRegionDown", objArray1);
        }

        public void TryStartPageTurnGesture()
        {
            base.method_8("TryStartPageTurnGesture", Array.Empty<object>());
        }

        public bool UpdateUI()
        {
            return base.method_11<bool>("UpdateUI", Array.Empty<object>());
        }

        public Vector2 m_swipeStartPosition
        {
            get
            {
                return base.method_2<Vector2>("m_swipeStartPosition");
            }
        }

        public PegUIElement pageDragRegion
        {
            get
            {
                return base.method_3<PegUIElement>("pageDragRegion");
            }
        }

        public PegUIElement pageLeftRegion
        {
            get
            {
                return base.method_3<PegUIElement>("pageLeftRegion");
            }
        }

        public PegUIElement pageRightRegion
        {
            get
            {
                return base.method_3<PegUIElement>("pageRightRegion");
            }
        }

        public SwipeState swipeState
        {
            get
            {
                return base.method_2<SwipeState>("swipeState");
            }
        }

        public float TurnDist
        {
            get
            {
                return base.method_2<float>("TurnDist");
            }
        }

        public enum SwipeState
        {
            None,
            Update,
            Success
        }
    }
}

