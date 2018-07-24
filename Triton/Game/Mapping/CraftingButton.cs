namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CraftingButton")]
    public class CraftingButton : PegUIElement
    {
        public CraftingButton(IntPtr address) : this(address, "CraftingButton")
        {
        }

        public CraftingButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void DisableButton()
        {
            base.method_8("DisableButton", Array.Empty<object>());
        }

        public void EnableButton()
        {
            base.method_8("EnableButton", Array.Empty<object>());
        }

        public void EnterUndoMode()
        {
            base.method_8("EnterUndoMode", Array.Empty<object>());
        }

        public bool IsButtonEnabled()
        {
            return base.method_11<bool>("IsButtonEnabled", Array.Empty<object>());
        }

        public void OnEnabled(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("OnEnabled", objArray1);
        }

        public MeshRenderer buttonRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("buttonRenderer");
            }
        }

        public Material disabledMaterial
        {
            get
            {
                return base.method_3<Material>("disabledMaterial");
            }
        }

        public Material enabledMaterial
        {
            get
            {
                return base.method_3<Material>("enabledMaterial");
            }
        }

        public bool isEnabled
        {
            get
            {
                return base.method_2<bool>("isEnabled");
            }
        }

        public UberText labelText
        {
            get
            {
                return base.method_3<UberText>("labelText");
            }
        }

        public GameObject m_costObject
        {
            get
            {
                return base.method_3<GameObject>("m_costObject");
            }
        }

        public Transform m_disabledCostBone
        {
            get
            {
                return base.method_3<Transform>("m_disabledCostBone");
            }
        }

        public Transform m_enabledCostBone
        {
            get
            {
                return base.method_3<Transform>("m_enabledCostBone");
            }
        }

        public Material undoMaterial
        {
            get
            {
                return base.method_3<Material>("undoMaterial");
            }
        }
    }
}

