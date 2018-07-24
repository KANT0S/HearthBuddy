namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SwipeHandler")]
    public class SwipeHandler : PegUICustomBehavior
    {
        public SwipeHandler(IntPtr address) : this(address, "SwipeHandler")
        {
        }

        public SwipeHandler(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CheckSwipe()
        {
            return base.method_11<bool>("CheckSwipe", Array.Empty<object>());
        }

        public bool HandleSwipeGesture()
        {
            return base.method_11<bool>("HandleSwipeGesture", Array.Empty<object>());
        }

        public bool InSwipeRect(Vector2 v)
        {
            object[] objArray1 = new object[] { v };
            return base.method_11<bool>("InSwipeRect", objArray1);
        }

        public bool UpdateUI()
        {
            return base.method_11<bool>("UpdateUI", Array.Empty<object>());
        }

        public bool m_checkingPossibleSwipe
        {
            get
            {
                return base.method_2<bool>("m_checkingPossibleSwipe");
            }
        }

        public Transform m_lowerRightBone
        {
            get
            {
                return base.method_3<Transform>("m_lowerRightBone");
            }
        }

        public float m_swipeDetectTimer
        {
            get
            {
                return base.method_2<float>("m_swipeDetectTimer");
            }
        }

        public PegUIElement m_swipeElement
        {
            get
            {
                return base.method_3<PegUIElement>("m_swipeElement");
            }
        }

        public Rect m_swipeRect
        {
            get
            {
                return base.method_2<Rect>("m_swipeRect");
            }
        }

        public Vector3 m_swipeStart
        {
            get
            {
                return base.method_2<Vector3>("m_swipeStart");
            }
        }

        public Transform m_upperLeftBone
        {
            get
            {
                return base.method_3<Transform>("m_upperLeftBone");
            }
        }

        public static float SWIPE_DETECT_DURATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SwipeHandler", "SWIPE_DETECT_DURATION");
            }
        }

        public static float SWIPE_DETECT_WIDTH
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SwipeHandler", "SWIPE_DETECT_WIDTH");
            }
        }

        public static float SWIPE_FROM_TARGET_PENALTY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SwipeHandler", "SWIPE_FROM_TARGET_PENALTY");
            }
        }

        public enum SWIPE_DIRECTION
        {
            RIGHT,
            LEFT
        }
    }
}

