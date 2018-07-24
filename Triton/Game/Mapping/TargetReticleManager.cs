namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TargetReticleManager")]
    public class TargetReticleManager : MonoBehaviour
    {
        public TargetReticleManager(IntPtr address) : this(address, "TargetReticleManager")
        {
        }

        public TargetReticleManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateArrow(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("ActivateArrow", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CreateEnemyTargetArrow(Triton.Game.Mapping.Entity originEntity)
        {
            object[] objArray1 = new object[] { originEntity };
            base.method_8("CreateEnemyTargetArrow", objArray1);
        }

        public void CreateFriendlyTargetArrow(Triton.Game.Mapping.Entity originLocationEntity, Triton.Game.Mapping.Entity sourceEntity, bool showDamageIndicatorText, bool showArrow, string overrideText, bool useHandAsOrigin)
        {
            object[] objArray1 = new object[] { originLocationEntity, sourceEntity, showDamageIndicatorText, showArrow, overrideText, useHandAsOrigin };
            base.method_8("CreateFriendlyTargetArrow", objArray1);
        }

        public void CreateTargetArrow(bool isEnemyArrow, int originLocationEntityID, int sourceEntityID, string damageIndicatorText, bool showArrow, bool useHandAsOrigin)
        {
            object[] objArray1 = new object[] { isEnemyArrow, originLocationEntityID, sourceEntityID, damageIndicatorText, showArrow, useHandAsOrigin };
            base.method_8("CreateTargetArrow", objArray1);
        }

        public void DestroyCurrentArrow(bool isLocallyCanceled)
        {
            object[] objArray1 = new object[] { isLocallyCanceled };
            base.method_8("DestroyCurrentArrow", objArray1);
        }

        public void DestroyEnemyTargetArrow()
        {
            base.method_8("DestroyEnemyTargetArrow", Array.Empty<object>());
        }

        public void DestroyFriendlyTargetArrow(bool isLocallyCanceled)
        {
            object[] objArray1 = new object[] { isLocallyCanceled };
            base.method_8("DestroyFriendlyTargetArrow", objArray1);
        }

        public void DestroyTargetArrow(bool destroyEnemyArrow, bool isLocallyCanceled)
        {
            object[] objArray1 = new object[] { destroyEnemyArrow, isLocallyCanceled };
            base.method_8("DestroyTargetArrow", objArray1);
        }

        public void DisableCollidersForUntargetableCards(Card sourceCard)
        {
            object[] objArray1 = new object[] { sourceCard };
            base.method_8("DisableCollidersForUntargetableCards", objArray1);
        }

        public void EnableCollidersThatWereDisabled()
        {
            base.method_8("EnableCollidersThatWereDisabled", Array.Empty<object>());
        }

        public static TargetReticleManager Get()
        {
            return MonoClass.smethod_15<TargetReticleManager>(TritonHs.MainAssemblyPath, "", "TargetReticleManager", "Get", Array.Empty<object>());
        }

        public bool IsActive()
        {
            return base.method_11<bool>("IsActive", Array.Empty<object>());
        }

        public bool IsEnemyArrow()
        {
            return base.method_11<bool>("IsEnemyArrow", Array.Empty<object>());
        }

        public bool IsEnemyArrowActive()
        {
            return base.method_11<bool>("IsEnemyArrowActive", Array.Empty<object>());
        }

        public bool IsLocalArrow()
        {
            return base.method_11<bool>("IsLocalArrow", Array.Empty<object>());
        }

        public bool IsLocalArrowActive()
        {
            return base.method_11<bool>("IsLocalArrowActive", Array.Empty<object>());
        }

        public void LoadArrowCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadArrowCallback", objArray1);
        }

        public void LoadDamageIndicatorCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadDamageIndicatorCallback", objArray1);
        }

        public void LoadHunterReticleCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadHunterReticleCallback", objArray1);
        }

        public void LoadLinkCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadLinkCallback", objArray1);
        }

        public int NumberOfRequiredLinks(float lengthOfArrow)
        {
            object[] objArray1 = new object[] { lengthOfArrow };
            return base.method_11<int>("NumberOfRequiredLinks", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void PreloadTargetArrows()
        {
            base.method_8("PreloadTargetArrows", Array.Empty<object>());
        }

        public void SetLinkAlpha(GameObject linkGameObject, float alpha)
        {
            object[] objArray1 = new object[] { linkGameObject, alpha };
            base.method_8("SetLinkAlpha", objArray1);
        }

        public void SetRemotePlayerArrowPosition(Vector3 newPosition)
        {
            object[] objArray1 = new object[] { newPosition };
            base.method_8("SetRemotePlayerArrowPosition", objArray1);
        }

        public void ShowArrow(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowArrow", objArray1);
        }

        public void ShowBullseye(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowBullseye", objArray1);
        }

        public void ShowDamageIndicator(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowDamageIndicator", objArray1);
        }

        public void UpdateArrowOriginPosition()
        {
            base.method_8("UpdateArrowOriginPosition", Array.Empty<object>());
        }

        public void UpdateArrowPosition()
        {
            base.method_8("UpdateArrowPosition", Array.Empty<object>());
        }

        public void UpdateDamageIndicator()
        {
            base.method_8("UpdateDamageIndicator", Array.Empty<object>());
        }

        public void UpdateTargetArrowLinks(float lengthOfArrow)
        {
            object[] objArray1 = new object[] { lengthOfArrow };
            base.method_8("UpdateTargetArrowLinks", objArray1);
        }

        public int ArrowSourceEntityID
        {
            get
            {
                return base.method_11<int>("get_ArrowSourceEntityID", Array.Empty<object>());
            }
        }

        public static float FRIENDLY_HERO_ORIGIN_Z_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TargetReticleManager", "FRIENDLY_HERO_ORIGIN_Z_OFFSET");
            }
        }

        public static float LENGTH_BETWEEN_LINKS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TargetReticleManager", "LENGTH_BETWEEN_LINKS");
            }
        }

        public static float LINK_ANIMATION_SPEED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TargetReticleManager", "LINK_ANIMATION_SPEED");
            }
        }

        public static float LINK_FADE_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TargetReticleManager", "LINK_FADE_OFFSET");
            }
        }

        public static float LINK_PARABOLA_HEIGHT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TargetReticleManager", "LINK_PARABOLA_HEIGHT");
            }
        }

        public static float LINK_Y_LENGTH
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TargetReticleManager", "LINK_Y_LENGTH");
            }
        }

        public GameObject m_arrow
        {
            get
            {
                return base.method_3<GameObject>("m_arrow");
            }
        }

        public GameObject m_damageIndicator
        {
            get
            {
                return base.method_3<GameObject>("m_damageIndicator");
            }
        }

        public GameObject m_hunterReticle
        {
            get
            {
                return base.method_3<GameObject>("m_hunterReticle");
            }
        }

        public bool m_isActive
        {
            get
            {
                return base.method_2<bool>("m_isActive");
            }
        }

        public bool m_isEnemyArrow
        {
            get
            {
                return base.method_2<bool>("m_isEnemyArrow");
            }
        }

        public float m_linkAnimationZOffset
        {
            get
            {
                return base.method_2<float>("m_linkAnimationZOffset");
            }
        }

        public int m_numActiveLinks
        {
            get
            {
                return base.method_2<int>("m_numActiveLinks");
            }
        }

        public int m_originLocationEntityID
        {
            get
            {
                return base.method_2<int>("m_originLocationEntityID");
            }
        }

        public Vector3 m_remoteArrowPosition
        {
            get
            {
                return base.method_2<Vector3>("m_remoteArrowPosition");
            }
        }

        public TARGET_RETICLE_TYPE m_ReticleType
        {
            get
            {
                return base.method_2<TARGET_RETICLE_TYPE>("m_ReticleType");
            }
        }

        public bool m_showArrow
        {
            get
            {
                return base.method_2<bool>("m_showArrow");
            }
        }

        public int m_sourceEntityID
        {
            get
            {
                return base.method_2<int>("m_sourceEntityID");
            }
        }

        public List<GameObject> m_targetArrowLinks
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_targetArrowLinks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 m_targetArrowOrigin
        {
            get
            {
                return base.method_2<Vector3>("m_targetArrowOrigin");
            }
        }

        public bool m_useHandAsOrigin
        {
            get
            {
                return base.method_2<bool>("m_useHandAsOrigin");
            }
        }

        public static int MAX_TARGET_ARROW_LINKS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TargetReticleManager", "MAX_TARGET_ARROW_LINKS");
            }
        }
    }
}

