namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Carousel")]
    public class Carousel : MonoBehaviour
    {
        public Carousel(IntPtr address) : this(address, "Carousel")
        {
        }

        public Carousel(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AreVisibleItemsLoaded()
        {
            return base.method_11<bool>("AreVisibleItemsLoaded", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public float CalculateVelocity()
        {
            return base.method_11<float>("CalculateVelocity", Array.Empty<object>());
        }

        public void ClearItems()
        {
            base.method_8("ClearItems", Array.Empty<object>());
        }

        public float DistanceFromSettle()
        {
            return base.method_11<float>("DistanceFromSettle", Array.Empty<object>());
        }

        public void DoFlyIn()
        {
            base.method_8("DoFlyIn", Array.Empty<object>());
        }

        public float GetCarouselPosition(float x)
        {
            object[] objArray1 = new object[] { x };
            return base.method_11<float>("GetCarouselPosition", objArray1);
        }

        public int GetCurrentIndex()
        {
            return base.method_11<int>("GetCurrentIndex", Array.Empty<object>());
        }

        public CarouselItem GetCurrentItem()
        {
            return base.method_14<CarouselItem>("GetCurrentItem", Array.Empty<object>());
        }

        public int GetTargetPosition()
        {
            return base.method_11<int>("GetTargetPosition", Array.Empty<object>());
        }

        public void InitVelocity()
        {
            base.method_8("InitVelocity", Array.Empty<object>());
        }

        public bool IsScrolling()
        {
            return base.method_11<bool>("IsScrolling", Array.Empty<object>());
        }

        public bool MouseOver()
        {
            return base.method_11<bool>("MouseOver", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void SetPosition(int n, bool animate)
        {
            object[] objArray1 = new object[] { n, animate };
            base.method_8("SetPosition", objArray1);
        }

        public void SettlePosition(float bias)
        {
            object[] objArray1 = new object[] { bias };
            base.method_8("SettlePosition", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartScrolling()
        {
            base.method_8("StartScrolling", Array.Empty<object>());
        }

        public void UpdateUI(bool mouseDown)
        {
            object[] objArray1 = new object[] { mouseDown };
            base.method_8("UpdateUI", objArray1);
        }

        public void UpdateVisibleItems()
        {
            base.method_8("UpdateVisibleItems", Array.Empty<object>());
        }

        public static float DRAG
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Carousel", "DRAG");
            }
        }

        public List<GameObject> m_bones
        {
            get
            {
                Class247<GameObject> class2 = base.method_3<Class247<GameObject>>("m_bones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Collider m_collider
        {
            get
            {
                return base.method_3<Collider>("m_collider");
            }
        }

        public bool m_doFlyIn
        {
            get
            {
                return base.method_2<bool>("m_doFlyIn");
            }
        }

        public float m_flyInState
        {
            get
            {
                return base.method_2<float>("m_flyInState");
            }
        }

        public float m_hitCarouselPosition
        {
            get
            {
                return base.method_2<float>("m_hitCarouselPosition");
            }
        }

        public int m_hitIndex
        {
            get
            {
                return base.method_2<int>("m_hitIndex");
            }
        }

        public CarouselItem m_hitItem
        {
            get
            {
                return base.method_3<CarouselItem>("m_hitItem");
            }
        }

        public Vector3 m_hitWorldPosition
        {
            get
            {
                return base.method_2<Vector3>("m_hitWorldPosition");
            }
        }

        public int m_intPosition
        {
            get
            {
                return base.method_2<int>("m_intPosition");
            }
        }

        public List<CarouselItem> m_items
        {
            get
            {
                Class247<CarouselItem> class2 = base.method_3<Class247<CarouselItem>>("m_items");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_maxPosition
        {
            get
            {
                return base.method_2<int>("m_maxPosition");
            }
        }

        public int m_momentumCounter
        {
            get
            {
                return base.method_2<int>("m_momentumCounter");
            }
        }

        public List<float> m_momentumHistory
        {
            get
            {
                Class246<float> class2 = base.method_3<Class246<float>>("m_momentumHistory");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_momentumTotal
        {
            get
            {
                return base.method_2<int>("m_momentumTotal");
            }
        }

        public float m_moveAdjustment
        {
            get
            {
                return base.method_2<float>("m_moveAdjustment");
            }
        }

        public bool m_noMouseMovement
        {
            get
            {
                return base.method_2<bool>("m_noMouseMovement");
            }
        }

        public int m_numItems
        {
            get
            {
                return base.method_2<int>("m_numItems");
            }
        }

        public float m_position
        {
            get
            {
                return base.method_2<float>("m_position");
            }
        }

        public int m_radius
        {
            get
            {
                return base.method_2<int>("m_radius");
            }
        }

        public bool m_scrolling
        {
            get
            {
                return base.method_2<bool>("m_scrolling");
            }
        }

        public bool m_settleCallbackCalled
        {
            get
            {
                return base.method_2<bool>("m_settleCallbackCalled");
            }
        }

        public float m_startX
        {
            get
            {
                return base.method_2<float>("m_startX");
            }
        }

        public float m_targetPosition
        {
            get
            {
                return base.method_2<float>("m_targetPosition");
            }
        }

        public float m_totalMove
        {
            get
            {
                return base.method_2<float>("m_totalMove");
            }
        }

        public bool m_touchActive
        {
            get
            {
                return base.method_2<bool>("m_touchActive");
            }
        }

        public Vector2 m_touchStart
        {
            get
            {
                return base.method_2<Vector2>("m_touchStart");
            }
        }

        public float m_touchX
        {
            get
            {
                return base.method_2<float>("m_touchX");
            }
        }

        public bool m_trackItemHit
        {
            get
            {
                return base.method_2<bool>("m_trackItemHit");
            }
        }

        public bool m_useFlyIn
        {
            get
            {
                return base.method_2<bool>("m_useFlyIn");
            }
        }

        public float m_velocity
        {
            get
            {
                return base.method_2<float>("m_velocity");
            }
        }

        public static float MIN_VELOCITY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Carousel", "MIN_VELOCITY");
            }
        }

        public static float SCROLL_THRESHOLD
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Carousel", "SCROLL_THRESHOLD");
            }
        }
    }
}

