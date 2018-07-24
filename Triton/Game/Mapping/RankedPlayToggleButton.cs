namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    [Attribute38("RankedPlayToggleButton")]
    public class RankedPlayToggleButton : PegUIElement
    {
        public RankedPlayToggleButton(IntPtr address) : this(address, "RankedPlayToggleButton")
        {
        }

        public RankedPlayToggleButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Down()
        {
            base.method_8("Down", Array.Empty<object>());
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void Up()
        {
            base.method_8("Up", Array.Empty<object>());
        }

        public void UpdateMaterialTogglers()
        {
            base.method_8("UpdateMaterialTogglers", Array.Empty<object>());
        }

        public GameObject m_button
        {
            get
            {
                return base.method_3<GameObject>("m_button");
            }
        }

        public Material m_buttonDisabledMaterial
        {
            get
            {
                return base.method_3<Material>("m_buttonDisabledMaterial");
            }
        }

        public Material m_buttonDownMaterial
        {
            get
            {
                return base.method_3<Material>("m_buttonDownMaterial");
            }
        }

        public Material m_buttonUpMaterial
        {
            get
            {
                return base.method_3<Material>("m_buttonUpMaterial");
            }
        }

        public Transform m_downBone
        {
            get
            {
                return base.method_3<Transform>("m_downBone");
            }
        }

        public MeshRenderer m_glowQuad
        {
            get
            {
                return base.method_3<MeshRenderer>("m_glowQuad");
            }
        }

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }

        public List<EnabledStateMaterialToggler> m_materialTogglers
        {
            get
            {
                Class246<EnabledStateMaterialToggler> class2 = base.method_3<Class246<EnabledStateMaterialToggler>>("m_materialTogglers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Transform m_upBone
        {
            get
            {
                return base.method_3<Transform>("m_upBone");
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EnabledStateMaterialToggler
        {
            public MeshRenderer m_targetMesh;
            public Material m_enabledMaterial;
            public Material m_disabledMaterial;
        }
    }
}

