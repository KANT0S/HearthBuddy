namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ConstructCard")]
    public class ConstructCard : MonoBehaviour
    {
        public ConstructCard(IntPtr address) : this(address, "ConstructCard")
        {
        }

        public ConstructCard(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateAttack()
        {
            base.method_8("AnimateAttack", Array.Empty<object>());
        }

        public void AnimateDescription()
        {
            base.method_8("AnimateDescription", Array.Empty<object>());
        }

        public void AnimateHealth()
        {
            base.method_8("AnimateHealth", Array.Empty<object>());
        }

        public void AnimateManaGem()
        {
            base.method_8("AnimateManaGem", Array.Empty<object>());
        }

        public void AnimateName()
        {
            base.method_8("AnimateName", Array.Empty<object>());
        }

        public void AnimatePortrait()
        {
            base.method_8("AnimatePortrait", Array.Empty<object>());
        }

        public void AnimateRarity()
        {
            base.method_8("AnimateRarity", Array.Empty<object>());
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

        public void Cancel()
        {
            base.method_8("Cancel", Array.Empty<object>());
        }

        public void Construct()
        {
            base.method_8("Construct", Array.Empty<object>());
        }

        public void CreateInstances()
        {
            base.method_8("CreateInstances", Array.Empty<object>());
        }

        public void DestroyInstances()
        {
            base.method_8("DestroyInstances", Array.Empty<object>());
        }

        public void DisableAttack()
        {
            base.method_8("DisableAttack", Array.Empty<object>());
        }

        public void DisableDescription()
        {
            base.method_8("DisableDescription", Array.Empty<object>());
        }

        public void DisableHealth()
        {
            base.method_8("DisableHealth", Array.Empty<object>());
        }

        public void DisableManaGem()
        {
            base.method_8("DisableManaGem", Array.Empty<object>());
        }

        public void DisableName()
        {
            base.method_8("DisableName", Array.Empty<object>());
        }

        public void DisablePortrait()
        {
            base.method_8("DisablePortrait", Array.Empty<object>());
        }

        public void DisableRarity()
        {
            base.method_8("DisableRarity", Array.Empty<object>());
        }

        public void HideAllMeshObjects()
        {
            base.method_8("HideAllMeshObjects", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void RestoreOrgMaterials()
        {
            base.method_8("RestoreOrgMaterials", Array.Empty<object>());
        }

        public void StopAllParticles()
        {
            base.method_8("StopAllParticles", Array.Empty<object>());
        }

        public void StoreOrgMaterials()
        {
            base.method_8("StoreOrgMaterials", Array.Empty<object>());
        }

        public Vector3 IMPACT_CAMERA_SHAKE_AMOUNT
        {
            get
            {
                return base.method_2<Vector3>("IMPACT_CAMERA_SHAKE_AMOUNT");
            }
        }

        public float IMPACT_CAMERA_SHAKE_TIME
        {
            get
            {
                return base.method_2<float>("IMPACT_CAMERA_SHAKE_TIME");
            }
        }

        public bool isInit
        {
            get
            {
                return base.method_2<bool>("isInit");
            }
        }

        public Actor m_Actor
        {
            get
            {
                return base.method_3<Actor>("m_Actor");
            }
        }

        public float m_AnimationRarityScaleCommon
        {
            get
            {
                return base.method_2<float>("m_AnimationRarityScaleCommon");
            }
        }

        public float m_AnimationRarityScaleEpic
        {
            get
            {
                return base.method_2<float>("m_AnimationRarityScaleEpic");
            }
        }

        public float m_AnimationRarityScaleLegendary
        {
            get
            {
                return base.method_2<float>("m_AnimationRarityScaleLegendary");
            }
        }

        public float m_AnimationRarityScaleRare
        {
            get
            {
                return base.method_2<float>("m_AnimationRarityScaleRare");
            }
        }

        public float m_AnimationScale
        {
            get
            {
                return base.method_2<float>("m_AnimationScale");
            }
        }

        public float m_AttackAnimTime
        {
            get
            {
                return base.method_2<float>("m_AttackAnimTime");
            }
        }

        public GameObject m_AttackGlow
        {
            get
            {
                return base.method_3<GameObject>("m_AttackGlow");
            }
        }

        public Vector3 m_AttackImpactRotation
        {
            get
            {
                return base.method_2<Vector3>("m_AttackImpactRotation");
            }
        }

        public GameObject m_AttackInstance
        {
            get
            {
                return base.method_3<GameObject>("m_AttackInstance");
            }
        }

        public GameObject m_AttackMesh
        {
            get
            {
                return base.method_3<GameObject>("m_AttackMesh");
            }
        }

        public float m_AttackStartDelay
        {
            get
            {
                return base.method_2<float>("m_AttackStartDelay");
            }
        }

        public Transform m_AttackStartPosition
        {
            get
            {
                return base.method_3<Transform>("m_AttackStartPosition");
            }
        }

        public Transform m_AttackTargetPosition
        {
            get
            {
                return base.method_3<Transform>("m_AttackTargetPosition");
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

        public float m_DescriptionAnimTime
        {
            get
            {
                return base.method_2<float>("m_DescriptionAnimTime");
            }
        }

        public GameObject m_DescriptionGlow
        {
            get
            {
                return base.method_3<GameObject>("m_DescriptionGlow");
            }
        }

        public Vector3 m_DescriptionImpactRotation
        {
            get
            {
                return base.method_2<Vector3>("m_DescriptionImpactRotation");
            }
        }

        public GameObject m_DescriptionInstance
        {
            get
            {
                return base.method_3<GameObject>("m_DescriptionInstance");
            }
        }

        public GameObject m_DescriptionMesh
        {
            get
            {
                return base.method_3<GameObject>("m_DescriptionMesh");
            }
        }

        public float m_DescriptionStartDelay
        {
            get
            {
                return base.method_2<float>("m_DescriptionStartDelay");
            }
        }

        public Transform m_DescriptionStartPosition
        {
            get
            {
                return base.method_3<Transform>("m_DescriptionStartPosition");
            }
        }

        public Transform m_DescriptionTargetPosition
        {
            get
            {
                return base.method_3<Transform>("m_DescriptionTargetPosition");
            }
        }

        public GameObject m_DescriptionTrimMesh
        {
            get
            {
                return base.method_3<GameObject>("m_DescriptionTrimMesh");
            }
        }

        public GameObject m_EliteMesh
        {
            get
            {
                return base.method_3<GameObject>("m_EliteMesh");
            }
        }

        public GameObject m_FuseGlow
        {
            get
            {
                return base.method_3<GameObject>("m_FuseGlow");
            }
        }

        public GameObject m_GhostGlow
        {
            get
            {
                return base.method_3<GameObject>("m_GhostGlow");
            }
        }

        public Material m_GhostMaterial
        {
            get
            {
                return base.method_3<Material>("m_GhostMaterial");
            }
        }

        public Material m_GhostMaterialTransparent
        {
            get
            {
                return base.method_3<Material>("m_GhostMaterialTransparent");
            }
        }

        public Spell m_GhostSpell
        {
            get
            {
                return base.method_3<Spell>("m_GhostSpell");
            }
        }

        public Texture m_GhostTextureUnique
        {
            get
            {
                return base.method_3<Texture>("m_GhostTextureUnique");
            }
        }

        public float m_HealthAnimTime
        {
            get
            {
                return base.method_2<float>("m_HealthAnimTime");
            }
        }

        public GameObject m_HealthGlow
        {
            get
            {
                return base.method_3<GameObject>("m_HealthGlow");
            }
        }

        public Vector3 m_HealthImpactRotation
        {
            get
            {
                return base.method_2<Vector3>("m_HealthImpactRotation");
            }
        }

        public GameObject m_HealthInstance
        {
            get
            {
                return base.method_3<GameObject>("m_HealthInstance");
            }
        }

        public GameObject m_HealthMesh
        {
            get
            {
                return base.method_3<GameObject>("m_HealthMesh");
            }
        }

        public float m_HealthStartDelay
        {
            get
            {
                return base.method_2<float>("m_HealthStartDelay");
            }
        }

        public Transform m_HealthStartPosition
        {
            get
            {
                return base.method_3<Transform>("m_HealthStartPosition");
            }
        }

        public Transform m_HealthTargetPosition
        {
            get
            {
                return base.method_3<Transform>("m_HealthTargetPosition");
            }
        }

        public float m_ImpactRotationTime
        {
            get
            {
                return base.method_2<float>("m_ImpactRotationTime");
            }
        }

        public GameObject m_ManaCostMesh
        {
            get
            {
                return base.method_3<GameObject>("m_ManaCostMesh");
            }
        }

        public float m_ManaGemAnimTime
        {
            get
            {
                return base.method_2<float>("m_ManaGemAnimTime");
            }
        }

        public GameObject m_ManaGemClone
        {
            get
            {
                return base.method_3<GameObject>("m_ManaGemClone");
            }
        }

        public GameObject m_ManaGemGlow
        {
            get
            {
                return base.method_3<GameObject>("m_ManaGemGlow");
            }
        }

        public Vector3 m_ManaGemImpactRotation
        {
            get
            {
                return base.method_2<Vector3>("m_ManaGemImpactRotation");
            }
        }

        public GameObject m_ManaGemInstance
        {
            get
            {
                return base.method_3<GameObject>("m_ManaGemInstance");
            }
        }

        public float m_ManaGemStartDelay
        {
            get
            {
                return base.method_2<float>("m_ManaGemStartDelay");
            }
        }

        public Transform m_ManaGemStartPosition
        {
            get
            {
                return base.method_3<Transform>("m_ManaGemStartPosition");
            }
        }

        public Transform m_ManaGemTargetPosition
        {
            get
            {
                return base.method_3<Transform>("m_ManaGemTargetPosition");
            }
        }

        public float m_NameAnimTime
        {
            get
            {
                return base.method_2<float>("m_NameAnimTime");
            }
        }

        public GameObject m_NameGlow
        {
            get
            {
                return base.method_3<GameObject>("m_NameGlow");
            }
        }

        public Vector3 m_NameImpactRotation
        {
            get
            {
                return base.method_2<Vector3>("m_NameImpactRotation");
            }
        }

        public GameObject m_NameInstance
        {
            get
            {
                return base.method_3<GameObject>("m_NameInstance");
            }
        }

        public GameObject m_NameMesh
        {
            get
            {
                return base.method_3<GameObject>("m_NameMesh");
            }
        }

        public float m_NameStartDelay
        {
            get
            {
                return base.method_2<float>("m_NameStartDelay");
            }
        }

        public Transform m_NameStartPosition
        {
            get
            {
                return base.method_3<Transform>("m_NameStartPosition");
            }
        }

        public Transform m_NameTargetPosition
        {
            get
            {
                return base.method_3<Transform>("m_NameTargetPosition");
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

        public float m_PortraitAnimTime
        {
            get
            {
                return base.method_2<float>("m_PortraitAnimTime");
            }
        }

        public int m_PortraitFrameIdx
        {
            get
            {
                return base.method_2<int>("m_PortraitFrameIdx");
            }
        }

        public GameObject m_PortraitGlow
        {
            get
            {
                return base.method_3<GameObject>("m_PortraitGlow");
            }
        }

        public GameObject m_PortraitGlowStandard
        {
            get
            {
                return base.method_3<GameObject>("m_PortraitGlowStandard");
            }
        }

        public GameObject m_PortraitGlowUnique
        {
            get
            {
                return base.method_3<GameObject>("m_PortraitGlowUnique");
            }
        }

        public Vector3 m_PortraitImpactRotation
        {
            get
            {
                return base.method_2<Vector3>("m_PortraitImpactRotation");
            }
        }

        public GameObject m_PortraitInstance
        {
            get
            {
                return base.method_3<GameObject>("m_PortraitInstance");
            }
        }

        public GameObject m_PortraitMesh
        {
            get
            {
                return base.method_3<GameObject>("m_PortraitMesh");
            }
        }

        public float m_PortraitStartDelay
        {
            get
            {
                return base.method_2<float>("m_PortraitStartDelay");
            }
        }

        public Transform m_PortraitStartPosition
        {
            get
            {
                return base.method_3<Transform>("m_PortraitStartPosition");
            }
        }

        public Transform m_PortraitTargetPosition
        {
            get
            {
                return base.method_3<Transform>("m_PortraitTargetPosition");
            }
        }

        public GameObject m_RacePlateMesh
        {
            get
            {
                return base.method_3<GameObject>("m_RacePlateMesh");
            }
        }

        public float m_RandomDelayVariance
        {
            get
            {
                return base.method_2<float>("m_RandomDelayVariance");
            }
        }

        public float m_RarityAnimTime
        {
            get
            {
                return base.method_2<float>("m_RarityAnimTime");
            }
        }

        public GameObject m_RarityFrameMesh
        {
            get
            {
                return base.method_3<GameObject>("m_RarityFrameMesh");
            }
        }

        public GameObject m_RarityGemMesh
        {
            get
            {
                return base.method_3<GameObject>("m_RarityGemMesh");
            }
        }

        public GameObject m_RarityGlowCommon
        {
            get
            {
                return base.method_3<GameObject>("m_RarityGlowCommon");
            }
        }

        public GameObject m_RarityGlowEpic
        {
            get
            {
                return base.method_3<GameObject>("m_RarityGlowEpic");
            }
        }

        public GameObject m_RarityGlowLegendary
        {
            get
            {
                return base.method_3<GameObject>("m_RarityGlowLegendary");
            }
        }

        public GameObject m_RarityGlowRare
        {
            get
            {
                return base.method_3<GameObject>("m_RarityGlowRare");
            }
        }

        public Vector3 m_RarityImpactRotation
        {
            get
            {
                return base.method_2<Vector3>("m_RarityImpactRotation");
            }
        }

        public GameObject m_RarityInstance
        {
            get
            {
                return base.method_3<GameObject>("m_RarityInstance");
            }
        }

        public float m_RarityStartDelay
        {
            get
            {
                return base.method_2<float>("m_RarityStartDelay");
            }
        }

        public Transform m_RarityStartPosition
        {
            get
            {
                return base.method_3<Transform>("m_RarityStartPosition");
            }
        }

        public Transform m_RarityTargetPosition
        {
            get
            {
                return base.method_3<Transform>("m_RarityTargetPosition");
            }
        }

        [Attribute38("ConstructCard.AnimationData")]
        public class AnimationData : MonoClass
        {
            public AnimationData(IntPtr address) : this(address, "AnimationData")
            {
            }

            public AnimationData(IntPtr address, string className) : base(address, className)
            {
            }

            public Transform AnimateTransform
            {
                get
                {
                    return base.method_3<Transform>("AnimateTransform");
                }
            }

            public float AnimationTime
            {
                get
                {
                    return base.method_2<float>("AnimationTime");
                }
            }

            public GameObject GlowObject
            {
                get
                {
                    return base.method_3<GameObject>("GlowObject");
                }
            }

            public GameObject GlowObjectStandard
            {
                get
                {
                    return base.method_3<GameObject>("GlowObjectStandard");
                }
            }

            public GameObject GlowObjectUnique
            {
                get
                {
                    return base.method_3<GameObject>("GlowObjectUnique");
                }
            }

            public Vector3 ImpactRotation
            {
                get
                {
                    return base.method_2<Vector3>("ImpactRotation");
                }
            }

            public string Name
            {
                get
                {
                    return base.method_4("Name");
                }
            }

            public string OnComplete
            {
                get
                {
                    return base.method_4("OnComplete");
                }
            }

            public float StartDelay
            {
                get
                {
                    return base.method_2<float>("StartDelay");
                }
            }

            public Transform StartTransform
            {
                get
                {
                    return base.method_3<Transform>("StartTransform");
                }
            }

            public Transform TargetTransform
            {
                get
                {
                    return base.method_3<Transform>("TargetTransform");
                }
            }
        }
    }
}

