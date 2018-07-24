namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GhostCard")]
    public class GhostCard : MonoBehaviour
    {
        public GhostCard(IntPtr address) : this(address, "GhostCard")
        {
        }

        public GhostCard(IntPtr address, string className) : base(address, className)
        {
        }

        public void ApplyGhostMaterials()
        {
            base.method_8("ApplyGhostMaterials", Array.Empty<object>());
        }

        public void ApplyMaterial(GameObject go, Material mat)
        {
            object[] objArray1 = new object[] { go, mat };
            base.method_8("ApplyMaterial", objArray1);
        }

        public void ApplyMaterialByIdx(GameObject go, Material mat, int idx)
        {
            object[] objArray1 = new object[] { go, mat, idx };
            base.method_8("ApplyMaterialByIdx", objArray1);
        }

        public void ApplySharedMaterialByIdx(GameObject go, Material mat, int idx)
        {
            object[] objArray1 = new object[] { go, mat, idx };
            base.method_8("ApplySharedMaterialByIdx", objArray1);
        }

        public void Disable()
        {
            base.method_8("Disable", Array.Empty<object>());
        }

        public void DisableGhost()
        {
            base.method_8("DisableGhost", Array.Empty<object>());
        }

        public void Init(bool forceRender)
        {
            object[] objArray1 = new object[] { forceRender };
            base.method_8("Init", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void RenderGhost()
        {
            base.method_9("RenderGhost", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void RenderGhost(bool forceRender)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { forceRender };
            base.method_9("RenderGhost", enumArray1, objArray1);
        }

        public void RenderGhostCard()
        {
            base.method_9("RenderGhostCard", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void RenderGhostCard(bool forceRender)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { forceRender };
            base.method_9("RenderGhostCard", enumArray1, objArray1);
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void RestoreOrgMaterials()
        {
            base.method_8("RestoreOrgMaterials", Array.Empty<object>());
        }

        public void StoreOrgMaterials()
        {
            base.method_8("StoreOrgMaterials", Array.Empty<object>());
        }

        public Actor m_Actor
        {
            get
            {
                return base.method_3<Actor>("m_Actor");
            }
        }

        public GameObject m_AttackMesh
        {
            get
            {
                return base.method_3<GameObject>("m_AttackMesh");
            }
        }

        public int m_CardFrontIdx
        {
            get
            {
                return base.method_2<int>("m_CardFrontIdx");
            }
        }

        public GameObject m_CardMesh
        {
            get
            {
                return base.method_3<GameObject>("m_CardMesh");
            }
        }

        public Vector3 m_CardOffset
        {
            get
            {
                return base.method_2<Vector3>("m_CardOffset");
            }
        }

        public GameObject m_DescriptionMesh
        {
            get
            {
                return base.method_3<GameObject>("m_DescriptionMesh");
            }
        }

        public GameObject m_DescriptionTrimMesh
        {
            get
            {
                return base.method_3<GameObject>("m_DescriptionTrimMesh");
            }
        }

        public GameObject m_EffectRoot
        {
            get
            {
                return base.method_3<GameObject>("m_EffectRoot");
            }
        }

        public GameObject m_EliteMesh
        {
            get
            {
                return base.method_3<GameObject>("m_EliteMesh");
            }
        }

        public Material m_GhostMaterial
        {
            get
            {
                return base.method_3<Material>("m_GhostMaterial");
            }
        }

        public Material m_GhostMaterialMod2x
        {
            get
            {
                return base.method_3<Material>("m_GhostMaterialMod2x");
            }
        }

        public Material m_GhostMaterialTransparent
        {
            get
            {
                return base.method_3<Material>("m_GhostMaterialTransparent");
            }
        }

        public GameObject m_GlowPlane
        {
            get
            {
                return base.method_3<GameObject>("m_GlowPlane");
            }
        }

        public GameObject m_GlowPlaneElite
        {
            get
            {
                return base.method_3<GameObject>("m_GlowPlaneElite");
            }
        }

        public GameObject m_HealthMesh
        {
            get
            {
                return base.method_3<GameObject>("m_HealthMesh");
            }
        }

        public bool m_Init
        {
            get
            {
                return base.method_2<bool>("m_Init");
            }
        }

        public GameObject m_ManaCostMesh
        {
            get
            {
                return base.method_3<GameObject>("m_ManaCostMesh");
            }
        }

        public GameObject m_NameMesh
        {
            get
            {
                return base.method_3<GameObject>("m_NameMesh");
            }
        }

        public Material m_OrgMat_Attack
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_Attack");
            }
        }

        public Material m_OrgMat_CardFront
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_CardFront");
            }
        }

        public Material m_OrgMat_Description
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_Description");
            }
        }

        public Material m_OrgMat_Description2
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_Description2");
            }
        }

        public Material m_OrgMat_DescriptionTrim
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_DescriptionTrim");
            }
        }

        public Material m_OrgMat_Elite
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_Elite");
            }
        }

        public Material m_OrgMat_Health
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_Health");
            }
        }

        public Material m_OrgMat_ManaCost
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_ManaCost");
            }
        }

        public Material m_OrgMat_Name
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_Name");
            }
        }

        public Material m_OrgMat_PortraitFrame
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_PortraitFrame");
            }
        }

        public Material m_OrgMat_PremiumRibbon
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_PremiumRibbon");
            }
        }

        public Material m_OrgMat_RacePlate
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_RacePlate");
            }
        }

        public Material m_OrgMat_RarityFrame
        {
            get
            {
                return base.method_3<Material>("m_OrgMat_RarityFrame");
            }
        }

        public int m_PortraitFrameIdx
        {
            get
            {
                return base.method_2<int>("m_PortraitFrameIdx");
            }
        }

        public GameObject m_PortraitMesh
        {
            get
            {
                return base.method_3<GameObject>("m_PortraitMesh");
            }
        }

        public int m_PremiumRibbonIdx
        {
            get
            {
                return base.method_2<int>("m_PremiumRibbonIdx");
            }
        }

        public RenderToTexture m_R2T_BaseCard
        {
            get
            {
                return base.method_3<RenderToTexture>("m_R2T_BaseCard");
            }
        }

        public RenderToTexture m_R2T_EffectGhost
        {
            get
            {
                return base.method_3<RenderToTexture>("m_R2T_EffectGhost");
            }
        }

        public GameObject m_RacePlateMesh
        {
            get
            {
                return base.method_3<GameObject>("m_RacePlateMesh");
            }
        }

        public GameObject m_RarityFrameMesh
        {
            get
            {
                return base.method_3<GameObject>("m_RarityFrameMesh");
            }
        }
    }
}

