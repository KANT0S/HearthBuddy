namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PegUI")]
    public class PegUI : MonoBehaviour
    {
        public PegUI(IntPtr address) : this(address, "PegUI")
        {
        }

        public PegUI(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DoMouseDown(PegUIElement element, Vector3 mouseDownPos)
        {
            object[] objArray1 = new object[] { element, mouseDownPos };
            base.method_8("DoMouseDown", objArray1);
        }

        public PegUIElement FindHitElement()
        {
            return base.method_14<PegUIElement>("FindHitElement", Array.Empty<object>());
        }

        public static PegUI Get()
        {
            return MonoClass.smethod_15<PegUI>(TritonHs.MainAssemblyPath, "", "PegUI", "Get", Array.Empty<object>());
        }

        public PegUIElement GetMousedOverElement()
        {
            return base.method_14<PegUIElement>("GetMousedOverElement", Array.Empty<object>());
        }

        public PegUIElement GetPrevMousedOverElement()
        {
            return base.method_14<PegUIElement>("GetPrevMousedOverElement", Array.Empty<object>());
        }

        public void MouseInputUpdate()
        {
            base.method_8("MouseInputUpdate", Array.Empty<object>());
        }

        public void OnAppFocusChanged(bool focus, object userData)
        {
            object[] objArray1 = new object[] { focus, userData };
            base.method_8("OnAppFocusChanged", objArray1);
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

        public void RegisterCustomBehavior(PegUICustomBehavior behavior)
        {
            object[] objArray1 = new object[] { behavior };
            base.method_8("RegisterCustomBehavior", objArray1);
        }

        public void SetInputCamera(Camera cam)
        {
            object[] objArray1 = new object[] { cam };
            base.method_8("SetInputCamera", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UnregisterCustomBehavior(PegUICustomBehavior behavior)
        {
            object[] objArray1 = new object[] { behavior };
            base.method_8("UnregisterCustomBehavior", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool UpdateMouseLeftClick()
        {
            return base.method_11<bool>("UpdateMouseLeftClick", Array.Empty<object>());
        }

        public bool UpdateMouseLeftHold()
        {
            return base.method_11<bool>("UpdateMouseLeftHold", Array.Empty<object>());
        }

        public void UpdateMouseOver()
        {
            base.method_8("UpdateMouseOver", Array.Empty<object>());
        }

        public bool UpdateMouseRightClick()
        {
            return base.method_11<bool>("UpdateMouseRightClick", Array.Empty<object>());
        }

        public static float DOUBLECLICK_COUNT_DISABLED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "PegUI", "DOUBLECLICK_COUNT_DISABLED");
            }
        }

        public static float DOUBLECLICK_TOLERANCE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "PegUI", "DOUBLECLICK_TOLERANCE");
            }
        }

        public static List<GameLayer> HIT_TEST_PRIORITY
        {
            get
            {
                Class246<GameLayer> class2 = MonoClass.smethod_7<Class246<GameLayer>>(TritonHs.MainAssemblyPath, "", "PegUI", "HIT_TEST_PRIORITY");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public PegUIElement m_currentElement
        {
            get
            {
                return base.method_3<PegUIElement>("m_currentElement");
            }
        }

        public List<PegUICustomBehavior> m_customBehaviors
        {
            get
            {
                Class267<PegUICustomBehavior> class2 = base.method_3<Class267<PegUICustomBehavior>>("m_customBehaviors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_hasFocus
        {
            get
            {
                return base.method_2<bool>("m_hasFocus");
            }
        }

        public Vector3 m_lastClickPosition
        {
            get
            {
                return base.method_2<Vector3>("m_lastClickPosition");
            }
        }

        public float m_lastClickTimer
        {
            get
            {
                return base.method_2<float>("m_lastClickTimer");
            }
        }

        public PegUIElement m_mouseDownElement
        {
            get
            {
                return base.method_3<PegUIElement>("m_mouseDownElement");
            }
        }

        public float m_mouseDownTimer
        {
            get
            {
                return base.method_2<float>("m_mouseDownTimer");
            }
        }

        public PegUIElement m_prevElement
        {
            get
            {
                return base.method_3<PegUIElement>("m_prevElement");
            }
        }

        public Camera m_UICam
        {
            get
            {
                return base.method_3<Camera>("m_UICam");
            }
        }

        public static float MOUSEDOWN_COUNT_DISABLED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "PegUI", "MOUSEDOWN_COUNT_DISABLED");
            }
        }

        public Camera orthographicUICam
        {
            get
            {
                return base.method_3<Camera>("orthographicUICam");
            }
        }

        public static float PRESS_VS_TAP_TOLERANCE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "PegUI", "PRESS_VS_TAP_TOLERANCE");
            }
        }

        public enum Layer
        {
            MANUAL,
            RELATIVE_TO_PARENT,
            BACKGROUND,
            HUD,
            DIALOG
        }

        public enum SWIPE_DIRECTION
        {
            RIGHT,
            LEFT
        }
    }
}

