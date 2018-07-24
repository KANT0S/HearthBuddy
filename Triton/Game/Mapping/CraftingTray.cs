namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CraftingTray")]
    public class CraftingTray : MonoBehaviour
    {
        public CraftingTray(IntPtr address) : this(address, "CraftingTray")
        {
        }

        public CraftingTray(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static CraftingTray Get()
        {
            return MonoClass.smethod_15<CraftingTray>(TritonHs.MainAssemblyPath, "", "CraftingTray", "Get", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDoneButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDoneButtonReleased", objArray1);
        }

        public void OnMassDisenchantButtonOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnMassDisenchantButtonOut", objArray1);
        }

        public void OnMassDisenchantButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnMassDisenchantButtonOver", objArray1);
        }

        public void OnMassDisenchantButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnMassDisenchantButtonReleased", objArray1);
        }

        public void SetMassDisenchantAmount()
        {
            base.method_8("SetMassDisenchantAmount", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void ToggleShowGolden(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ToggleShowGolden", objArray1);
        }

        public void ToggleShowSoulbound(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ToggleShowSoulbound", objArray1);
        }

        public void UpdateMassDisenchantAmount()
        {
            base.method_8("UpdateMassDisenchantAmount", Array.Empty<object>());
        }

        public UIBButton m_doneButton
        {
            get
            {
                return base.method_3<UIBButton>("m_doneButton");
            }
        }

        public int m_dustAmount
        {
            get
            {
                return base.method_2<int>("m_dustAmount");
            }
        }

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }

        public PegUIElement m_massDisenchantButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_massDisenchantButton");
            }
        }

        public Material m_massDisenchantDisabledMaterial
        {
            get
            {
                return base.method_3<Material>("m_massDisenchantDisabledMaterial");
            }
        }

        public Material m_massDisenchantMaterial
        {
            get
            {
                return base.method_3<Material>("m_massDisenchantMaterial");
            }
        }

        public GameObject m_massDisenchantMesh
        {
            get
            {
                return base.method_3<GameObject>("m_massDisenchantMesh");
            }
        }

        public UberText m_massDisenchantText
        {
            get
            {
                return base.method_3<UberText>("m_massDisenchantText");
            }
        }

        public UberText m_potentialDustAmount
        {
            get
            {
                return base.method_3<UberText>("m_potentialDustAmount");
            }
        }

        public CheckBox m_showGoldenCheckbox
        {
            get
            {
                return base.method_3<CheckBox>("m_showGoldenCheckbox");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public CheckBox m_showSoulboundCheckbox
        {
            get
            {
                return base.method_3<CheckBox>("m_showSoulboundCheckbox");
            }
        }
    }
}

