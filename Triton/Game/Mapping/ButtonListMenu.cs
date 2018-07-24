namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ButtonListMenu")]
    public class ButtonListMenu : MonoBehaviour
    {
        public ButtonListMenu(IntPtr address) : this(address, "ButtonListMenu")
        {
        }

        public ButtonListMenu(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public List<UIBButton> GetButtons()
        {
            Class267<UIBButton> class2 = base.method_14<Class267<UIBButton>>("GetButtons", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideAllButtons()
        {
            base.method_8("HideAllButtons", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void LayoutMenu()
        {
            base.method_8("LayoutMenu", Array.Empty<object>());
        }

        public void LayoutMenuBackground()
        {
            base.method_8("LayoutMenuBackground", Array.Empty<object>());
        }

        public void LayoutMenuButtons()
        {
            base.method_8("LayoutMenuButtons", Array.Empty<object>());
        }

        public void OnBlockerRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBlockerRelease", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFatalError(FatalErrorMessage message, object userData)
        {
            object[] objArray1 = new object[] { message, userData };
            base.method_8("OnFatalError", objArray1);
        }

        public void SetTransform()
        {
            base.method_8("SetTransform", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public static Vector3 HIDDEN_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "ButtonListMenu", "HIDDEN_SCALE");
            }
        }

        public List<UIBButton> m_allButtons
        {
            get
            {
                Class267<UIBButton> class2 = base.method_3<Class267<UIBButton>>("m_allButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public PegUIElement m_blocker
        {
            get
            {
                return base.method_3<PegUIElement>("m_blocker");
            }
        }

        public List<GameObject> m_horizontalDividers
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_horizontalDividers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_isShown
        {
            get
            {
                return base.method_2<bool>("m_isShown");
            }
        }

        public ButtonListMenuDef m_menu
        {
            get
            {
                return base.method_3<ButtonListMenuDef>("m_menu");
            }
        }

        public string m_menuDefPrefab
        {
            get
            {
                return base.method_4("m_menuDefPrefab");
            }
        }

        public Transform m_menuParent
        {
            get
            {
                return base.method_3<Transform>("m_menuParent");
            }
        }

        public Vector3 NORMAL_SCALE
        {
            get
            {
                return base.method_2<Vector3>("NORMAL_SCALE");
            }
        }

        public float PUNCH_SCALE
        {
            get
            {
                return base.method_2<float>("PUNCH_SCALE");
            }
        }
    }
}

