namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PegCursor")]
    public class PegCursor : MonoBehaviour
    {
        public PegCursor(IntPtr address) : this(address, "PegCursor")
        {
        }

        public PegCursor(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static PegCursor Get()
        {
            return MonoClass.smethod_15<PegCursor>(TritonHs.MainAssemblyPath, "", "PegCursor", "Get", Array.Empty<object>());
        }

        public GameObject GetExplosionPrefab()
        {
            return base.method_14<GameObject>("GetExplosionPrefab", Array.Empty<object>());
        }

        public Mode GetMode()
        {
            return base.method_11<Mode>("GetMode", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void SetMode(Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("SetMode", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public Mode m_currentMode
        {
            get
            {
                return base.method_2<Mode>("m_currentMode");
            }
        }

        public Vector2 m_cursorDownHotspot
        {
            get
            {
                return base.method_2<Vector2>("m_cursorDownHotspot");
            }
        }

        public Vector2 m_cursorDownHotspot64
        {
            get
            {
                return base.method_2<Vector2>("m_cursorDownHotspot64");
            }
        }

        public Vector2 m_cursorDragHotspot
        {
            get
            {
                return base.method_2<Vector2>("m_cursorDragHotspot");
            }
        }

        public Vector2 m_cursorDragHotspot64
        {
            get
            {
                return base.method_2<Vector2>("m_cursorDragHotspot64");
            }
        }

        public Vector2 m_cursorOverHotspot
        {
            get
            {
                return base.method_2<Vector2>("m_cursorOverHotspot");
            }
        }

        public Vector2 m_cursorOverHotspot64
        {
            get
            {
                return base.method_2<Vector2>("m_cursorOverHotspot64");
            }
        }

        public Vector2 m_cursorUpHotspot
        {
            get
            {
                return base.method_2<Vector2>("m_cursorUpHotspot");
            }
        }

        public Vector2 m_cursorUpHotspot64
        {
            get
            {
                return base.method_2<Vector2>("m_cursorUpHotspot64");
            }
        }

        public Vector2 m_cursorWaitingDownHotspot
        {
            get
            {
                return base.method_2<Vector2>("m_cursorWaitingDownHotspot");
            }
        }

        public Vector2 m_cursorWaitingDownHotspot64
        {
            get
            {
                return base.method_2<Vector2>("m_cursorWaitingDownHotspot64");
            }
        }

        public Vector2 m_cursorWaitingHotspot
        {
            get
            {
                return base.method_2<Vector2>("m_cursorWaitingHotspot");
            }
        }

        public Vector2 m_cursorWaitingHotspot64
        {
            get
            {
                return base.method_2<Vector2>("m_cursorWaitingHotspot64");
            }
        }

        public Vector2 m_cursorWaitingUpHotspot
        {
            get
            {
                return base.method_2<Vector2>("m_cursorWaitingUpHotspot");
            }
        }

        public Vector2 m_cursorWaitingUpHotspot64
        {
            get
            {
                return base.method_2<Vector2>("m_cursorWaitingUpHotspot64");
            }
        }

        public GameObject m_explosionPrefab
        {
            get
            {
                return base.method_3<GameObject>("m_explosionPrefab");
            }
        }

        public Vector2 m_leftArrowHotspot
        {
            get
            {
                return base.method_2<Vector2>("m_leftArrowHotspot");
            }
        }

        public Vector2 m_leftArrowHotspot64
        {
            get
            {
                return base.method_2<Vector2>("m_leftArrowHotspot64");
            }
        }

        public Vector2 m_rightArrowHotspot
        {
            get
            {
                return base.method_2<Vector2>("m_rightArrowHotspot");
            }
        }

        public Vector2 m_rightArrowHotspot64
        {
            get
            {
                return base.method_2<Vector2>("m_rightArrowHotspot64");
            }
        }

        public enum Mode
        {
            UP,
            DOWN,
            OVER,
            DRAG,
            STOPDRAG,
            WAITING,
            STOPWAITING,
            LEFTARROW,
            RIGHTARROW,
            NONE
        }
    }
}

