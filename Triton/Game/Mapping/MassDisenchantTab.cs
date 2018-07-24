namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MassDisenchantTab")]
    public class MassDisenchantTab : PegUIElement
    {
        public MassDisenchantTab(IntPtr address) : this(address, "MassDisenchantTab")
        {
        }

        public MassDisenchantTab(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Deselect()
        {
            base.method_8("Deselect", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsVisible()
        {
            return base.method_11<bool>("IsVisible", Array.Empty<object>());
        }

        public void OnRollout(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRollout", objArray1);
        }

        public void OnRollover(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRollover", objArray1);
        }

        public void Select()
        {
            base.method_8("Select", Array.Empty<object>());
        }

        public void SetAmount(int amount)
        {
            object[] objArray1 = new object[] { amount };
            base.method_8("SetAmount", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public UberText m_amount
        {
            get
            {
                return base.method_3<UberText>("m_amount");
            }
        }

        public GameObject m_highlight
        {
            get
            {
                return base.method_3<GameObject>("m_highlight");
            }
        }

        public bool m_isSelected
        {
            get
            {
                return base.method_2<bool>("m_isSelected");
            }
        }

        public bool m_isVisible
        {
            get
            {
                return base.method_2<bool>("m_isVisible");
            }
        }

        public Vector3 m_originalLocalPos
        {
            get
            {
                return base.method_2<Vector3>("m_originalLocalPos");
            }
        }

        public Vector3 m_originalScale
        {
            get
            {
                return base.method_2<Vector3>("m_originalScale");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public static float SELECTED_LOCAL_Y_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MassDisenchantTab", "SELECTED_LOCAL_Y_OFFSET");
            }
        }

        public static Vector3 SELECTED_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "MassDisenchantTab", "SELECTED_SCALE");
            }
        }
    }
}

