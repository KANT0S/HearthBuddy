namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ArenaTrayDisplay")]
    public class ArenaTrayDisplay : MonoBehaviour
    {
        public ArenaTrayDisplay(IntPtr address) : this(address, "ArenaTrayDisplay")
        {
        }

        public ArenaTrayDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateKey()
        {
            base.method_8("ActivateKey", Array.Empty<object>());
        }

        public void AnimateRewards()
        {
            base.method_8("AnimateRewards", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static ArenaTrayDisplay Get()
        {
            return MonoClass.smethod_15<ArenaTrayDisplay>(TritonHs.MainAssemblyPath, "", "ArenaTrayDisplay", "Get", Array.Empty<object>());
        }

        public void HidePaper()
        {
            base.method_8("HidePaper", Array.Empty<object>());
        }

        public void KeyFXCancel()
        {
            base.method_8("KeyFXCancel", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void OnIdleEffectsLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnIdleEffectsLoaded", objArray1);
        }

        public void OnRewardBoxesDone()
        {
            base.method_8("OnRewardBoxesDone", Array.Empty<object>());
        }

        public void OpenRewardBox()
        {
            base.method_9("OpenRewardBox", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void OpenRewardBox(UIEvent e)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { e };
            base.method_9("OpenRewardBox", enumArray1, objArray1);
        }

        public void ShowOpenedRewards()
        {
            base.method_8("ShowOpenedRewards", Array.Empty<object>());
        }

        public void ShowPlainPaper()
        {
            base.method_8("ShowPlainPaper", Array.Empty<object>());
        }

        public void ShowPlainPaperBackground()
        {
            base.method_8("ShowPlainPaperBackground", Array.Empty<object>());
        }

        public void ShowRewardPaper()
        {
            base.method_8("ShowRewardPaper", Array.Empty<object>());
        }

        public void ShowRewardsOpenAtStart()
        {
            base.method_8("ShowRewardsOpenAtStart", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateKeyArt(int rank)
        {
            object[] objArray1 = new object[] { rank };
            base.method_8("UpdateKeyArt", objArray1);
        }

        public void UpdateTray()
        {
            base.method_9("UpdateTray", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void UpdateTray(bool showNewKey)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { showNewKey };
            base.method_9("UpdateTray", enumArray1, objArray1);
        }

        public void UpdateXBoxes()
        {
            base.method_8("UpdateXBoxes", Array.Empty<object>());
        }

        public List<ArenaKeyVisualData> m_ArenaKeyVisualData
        {
            get
            {
                Class267<ArenaKeyVisualData> class2 = base.method_3<Class267<ArenaKeyVisualData>>("m_ArenaKeyVisualData");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_BehindTheDoors
        {
            get
            {
                return base.method_3<GameObject>("m_BehindTheDoors");
            }
        }

        public GameObject m_InstructionText
        {
            get
            {
                return base.method_3<GameObject>("m_InstructionText");
            }
        }

        public bool m_isTheKeyIdleEffectsLoading
        {
            get
            {
                return base.method_2<bool>("m_isTheKeyIdleEffectsLoading");
            }
        }

        public UberText m_LossesUberText
        {
            get
            {
                return base.method_3<UberText>("m_LossesUberText");
            }
        }

        public GameObject m_Paper
        {
            get
            {
                return base.method_3<GameObject>("m_Paper");
            }
        }

        public GameObject m_PaperMain
        {
            get
            {
                return base.method_3<GameObject>("m_PaperMain");
            }
        }

        public Material m_PlainPaperMaterial
        {
            get
            {
                return base.method_3<Material>("m_PlainPaperMaterial");
            }
        }

        public int m_Rank
        {
            get
            {
                return base.method_2<int>("m_Rank");
            }
        }

        public RewardBoxesDisplay m_RewardBoxes
        {
            get
            {
                return base.method_3<RewardBoxesDisplay>("m_RewardBoxes");
            }
        }

        public GameObject m_RewardBoxesBone
        {
            get
            {
                return base.method_3<GameObject>("m_RewardBoxesBone");
            }
        }

        public GameObject m_RewardDoorPlates
        {
            get
            {
                return base.method_3<GameObject>("m_RewardDoorPlates");
            }
        }

        public Material m_RewardPaperMaterial
        {
            get
            {
                return base.method_3<Material>("m_RewardPaperMaterial");
            }
        }

        public GameObject m_TheKeyGlowHoleMesh
        {
            get
            {
                return base.method_3<GameObject>("m_TheKeyGlowHoleMesh");
            }
        }

        public GameObject m_TheKeyGlowPlane
        {
            get
            {
                return base.method_3<GameObject>("m_TheKeyGlowPlane");
            }
        }

        public GameObject m_TheKeyIdleEffects
        {
            get
            {
                return base.method_3<GameObject>("m_TheKeyIdleEffects");
            }
        }

        public GameObject m_TheKeyMesh
        {
            get
            {
                return base.method_3<GameObject>("m_TheKeyMesh");
            }
        }

        public GameObject m_TheKeyOldSelectionGlow
        {
            get
            {
                return base.method_3<GameObject>("m_TheKeyOldSelectionGlow");
            }
        }

        public GameObject m_TheKeyParticleSystems
        {
            get
            {
                return base.method_3<GameObject>("m_TheKeyParticleSystems");
            }
        }

        public GameObject m_TheKeySelectionGlow
        {
            get
            {
                return base.method_3<GameObject>("m_TheKeySelectionGlow");
            }
        }

        public float m_TheKeyTransitionDelay
        {
            get
            {
                return base.method_2<float>("m_TheKeyTransitionDelay");
            }
        }

        public float m_TheKeyTransitionFadeInTime
        {
            get
            {
                return base.method_2<float>("m_TheKeyTransitionFadeInTime");
            }
        }

        public float m_TheKeyTransitionFadeOutTime
        {
            get
            {
                return base.method_2<float>("m_TheKeyTransitionFadeOutTime");
            }
        }

        public string m_TheKeyTransitionSound
        {
            get
            {
                return base.method_4("m_TheKeyTransitionSound");
            }
        }

        public UberText m_WinCountUberText
        {
            get
            {
                return base.method_3<UberText>("m_WinCountUberText");
            }
        }

        public UberText m_WinsUberText
        {
            get
            {
                return base.method_3<UberText>("m_WinsUberText");
            }
        }

        public GameObject m_Xmark1
        {
            get
            {
                return base.method_3<GameObject>("m_Xmark1");
            }
        }

        public GameObject m_Xmark2
        {
            get
            {
                return base.method_3<GameObject>("m_Xmark2");
            }
        }

        public GameObject m_Xmark3
        {
            get
            {
                return base.method_3<GameObject>("m_Xmark3");
            }
        }

        public List<GameObject> m_XmarkBox
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_XmarkBox");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_XmarksRoot
        {
            get
            {
                return base.method_3<GameObject>("m_XmarksRoot");
            }
        }

        public static ArenaTrayDisplay s_Instance
        {
            get
            {
                return MonoClass.smethod_7<ArenaTrayDisplay>(TritonHs.MainAssemblyPath, "", "ArenaTrayDisplay", "s_Instance");
            }
        }

        [Attribute38("ArenaTrayDisplay.ArenaKeyVisualData")]
        public class ArenaKeyVisualData : MonoClass
        {
            public ArenaKeyVisualData(IntPtr address) : this(address, "ArenaKeyVisualData")
            {
            }

            public ArenaKeyVisualData(IntPtr address, string className) : base(address, className)
            {
            }

            public Texture m_EffectGlowTexture
            {
                get
                {
                    return base.method_3<Texture>("m_EffectGlowTexture");
                }
            }

            public string m_IdleEffectsPrefabName
            {
                get
                {
                    return base.method_4("m_IdleEffectsPrefabName");
                }
            }

            public Mesh m_KeyHoleGlowMesh
            {
                get
                {
                    return base.method_3<Mesh>("m_KeyHoleGlowMesh");
                }
            }

            public Material m_Material
            {
                get
                {
                    return base.method_3<Material>("m_Material");
                }
            }

            public Mesh m_Mesh
            {
                get
                {
                    return base.method_3<Mesh>("m_Mesh");
                }
            }

            public GameObject m_ParticlePrefab
            {
                get
                {
                    return base.method_3<GameObject>("m_ParticlePrefab");
                }
            }

            public Texture m_SelectionGlowTexture
            {
                get
                {
                    return base.method_3<Texture>("m_SelectionGlowTexture");
                }
            }
        }
    }
}

