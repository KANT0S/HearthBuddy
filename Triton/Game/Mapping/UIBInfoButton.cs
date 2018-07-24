namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("UIBInfoButton")]
    public class UIBInfoButton : PegUIElement
    {
        public UIBInfoButton(IntPtr address) : this(address, "UIBInfoButton")
        {
        }

        public UIBInfoButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Depress()
        {
            base.method_8("Depress", Array.Empty<object>());
        }

        public void Deselect()
        {
            base.method_8("Deselect", Array.Empty<object>());
        }

        public void Raise()
        {
            base.method_8("Raise", Array.Empty<object>());
        }

        public void Select()
        {
            base.method_8("Select", Array.Empty<object>());
        }

        public static float DEPRESS_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "UIBInfoButton", "DEPRESS_TIME");
            }
        }

        public Transform m_DownBone
        {
            get
            {
                return base.method_3<Transform>("m_DownBone");
            }
        }

        public GameObject m_Highlight
        {
            get
            {
                return base.method_3<GameObject>("m_Highlight");
            }
        }

        public GameObject m_RootObject
        {
            get
            {
                return base.method_3<GameObject>("m_RootObject");
            }
        }

        public UIBHighlight m_UIBHighlight
        {
            get
            {
                return base.method_3<UIBHighlight>("m_UIBHighlight");
            }
        }

        public Transform m_UpBone
        {
            get
            {
                return base.method_3<Transform>("m_UpBone");
            }
        }

        public static float RAISE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "UIBInfoButton", "RAISE_TIME");
            }
        }
    }
}

