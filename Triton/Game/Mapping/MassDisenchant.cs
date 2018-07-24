namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MassDisenchant")]
    public class MassDisenchant : MonoBehaviour
    {
        public MassDisenchant(IntPtr address) : this(address, "MassDisenchant")
        {
        }

        public MassDisenchant(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BlockUI(bool block)
        {
            object[] objArray1 = new object[] { block };
            base.method_8("BlockUI", objArray1);
        }

        public float DrainBarAndDust(DisenchantBar bar, int drainRun, float duration, float rate)
        {
            object[] objArray1 = new object[] { bar, drainRun, duration, rate };
            return base.method_11<float>("DrainBarAndDust", objArray1);
        }

        public static MassDisenchant Get()
        {
            return MonoClass.smethod_15<MassDisenchant>(TritonHs.MainAssemblyPath, "", "MassDisenchant", "Get", Array.Empty<object>());
        }

        public Vector3 GetRanBoxPt(GameObject box)
        {
            object[] objArray1 = new object[] { box };
            return base.method_11<Vector3>("GetRanBoxPt", objArray1);
        }

        public RarityFX GetRarityFX(DisenchantBar bar)
        {
            object[] objArray1 = new object[] { bar };
            return base.method_11<RarityFX>("GetRarityFX", objArray1);
        }

        public RaritySound GetRaritySound(DisenchantBar bar)
        {
            object[] objArray1 = new object[] { bar };
            return base.method_14<RaritySound>("GetRaritySound", objArray1);
        }

        public int GetTotalAmount()
        {
            return base.method_11<int>("GetTotalAmount", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisenchantButtonOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDisenchantButtonOut", objArray1);
        }

        public void OnDisenchantButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDisenchantButtonOver", objArray1);
        }

        public void OnDisenchantButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDisenchantButtonPressed", objArray1);
        }

        public void OnInfoButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnInfoButtonPressed", objArray1);
        }

        public void OnMassDisenchant(int amount)
        {
            object[] objArray1 = new object[] { amount };
            base.method_8("OnMassDisenchant", objArray1);
        }

        public void SetDustBalance(float bal)
        {
            object[] objArray1 = new object[] { bal };
            base.method_8("SetDustBalance", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UncolorTotal(float newVal)
        {
            object[] objArray1 = new object[] { newVal };
            base.method_8("UncolorTotal", objArray1);
        }

        public List<GameObject> m_cleanupObjects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_cleanupObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_detailsHeadlineText
        {
            get
            {
                return base.method_3<UberText>("m_detailsHeadlineText");
            }
        }

        public UberText m_detailsText
        {
            get
            {
                return base.method_3<UberText>("m_detailsText");
            }
        }

        public NormalButton m_disenchantButton
        {
            get
            {
                return base.method_3<NormalButton>("m_disenchantButton");
            }
        }

        public GameObject m_disenchantContainer
        {
            get
            {
                return base.method_3<GameObject>("m_disenchantContainer");
            }
        }

        public List<DisenchantBar> m_doubleDisenchantBars
        {
            get
            {
                Class267<DisenchantBar> class2 = base.method_3<Class267<DisenchantBar>>("m_doubleDisenchantBars");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_doubleRoot
        {
            get
            {
                return base.method_3<GameObject>("m_doubleRoot");
            }
        }

        public UberText m_doubleSubHeadlineText
        {
            get
            {
                return base.method_3<UberText>("m_doubleSubHeadlineText");
            }
        }

        public MassDisenchantFX m_FX
        {
            get
            {
                return base.method_3<MassDisenchantFX>("m_FX");
            }
        }

        public UberText m_headlineText
        {
            get
            {
                return base.method_3<UberText>("m_headlineText");
            }
        }

        public int m_highestGlowBalls
        {
            get
            {
                return base.method_2<int>("m_highestGlowBalls");
            }
        }

        public UIBButton m_infoButton
        {
            get
            {
                return base.method_3<UIBButton>("m_infoButton");
            }
        }

        public Vector3 m_origDustScale
        {
            get
            {
                return base.method_2<Vector3>("m_origDustScale");
            }
        }

        public Vector3 m_origTotalScale
        {
            get
            {
                return base.method_2<Vector3>("m_origTotalScale");
            }
        }

        public Material m_rarityBarGoldMaterial
        {
            get
            {
                return base.method_3<Material>("m_rarityBarGoldMaterial");
            }
        }

        public Mesh m_rarityBarGoldMesh
        {
            get
            {
                return base.method_3<Mesh>("m_rarityBarGoldMesh");
            }
        }

        public Material m_rarityBarNormalMaterial
        {
            get
            {
                return base.method_3<Material>("m_rarityBarNormalMaterial");
            }
        }

        public Mesh m_rarityBarNormalMesh
        {
            get
            {
                return base.method_3<Mesh>("m_rarityBarNormalMesh");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public List<DisenchantBar> m_singleDisenchantBars
        {
            get
            {
                Class267<DisenchantBar> class2 = base.method_3<Class267<DisenchantBar>>("m_singleDisenchantBars");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_singleRoot
        {
            get
            {
                return base.method_3<GameObject>("m_singleRoot");
            }
        }

        public UberText m_singleSubHeadlineText
        {
            get
            {
                return base.method_3<UberText>("m_singleSubHeadlineText");
            }
        }

        public MassDisenchantSound m_sound
        {
            get
            {
                return base.method_3<MassDisenchantSound>("m_sound");
            }
        }

        public int m_totalAmount
        {
            get
            {
                return base.method_2<int>("m_totalAmount");
            }
        }

        public UberText m_totalAmountText
        {
            get
            {
                return base.method_3<UberText>("m_totalAmountText");
            }
        }

        public int m_totalCardsToDisenchant
        {
            get
            {
                return base.method_2<int>("m_totalCardsToDisenchant");
            }
        }

        public bool m_useSingle
        {
            get
            {
                return base.method_2<bool>("m_useSingle");
            }
        }

        public static MassDisenchant s_Instance
        {
            get
            {
                return MonoClass.smethod_7<MassDisenchant>(TritonHs.MainAssemblyPath, "", "MassDisenchant", "s_Instance");
            }
        }
    }
}

