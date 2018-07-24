namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CraftingModeButton")]
    public class CraftingModeButton : UIBButton
    {
        public CraftingModeButton(IntPtr address) : this(address, "CraftingModeButton")
        {
        }

        public CraftingModeButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void BottleJiggle()
        {
            base.method_8("BottleJiggle", Array.Empty<object>());
        }

        public void Enable(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("Enable", objArray1);
        }

        public void ShowActiveGlow(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowActiveGlow", objArray1);
        }

        public void ShowDustBottle(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowDustBottle", objArray1);
        }

        public void StartBottleJiggle()
        {
            base.method_8("StartBottleJiggle", Array.Empty<object>());
        }

        public GameObject m_activeGlow
        {
            get
            {
                return base.method_3<GameObject>("m_activeGlow");
            }
        }

        public Material m_disabledMaterial
        {
            get
            {
                return base.method_3<Material>("m_disabledMaterial");
            }
        }

        public GameObject m_dustBottle
        {
            get
            {
                return base.method_3<GameObject>("m_dustBottle");
            }
        }

        public Material m_enabledMaterial
        {
            get
            {
                return base.method_3<Material>("m_enabledMaterial");
            }
        }

        public bool m_isGlowEnabled
        {
            get
            {
                return base.method_2<bool>("m_isGlowEnabled");
            }
        }

        public bool m_isJiggling
        {
            get
            {
                return base.method_2<bool>("m_isJiggling");
            }
        }

        public Vector3 m_jarJiggleRotation
        {
            get
            {
                return base.method_2<Vector3>("m_jarJiggleRotation");
            }
        }

        public MeshRenderer m_mainMesh
        {
            get
            {
                return base.method_3<MeshRenderer>("m_mainMesh");
            }
        }

        public bool m_showDustBottle
        {
            get
            {
                return base.method_2<bool>("m_showDustBottle");
            }
        }

        public GameObject m_textObject
        {
            get
            {
                return base.method_3<GameObject>("m_textObject");
            }
        }
    }
}

