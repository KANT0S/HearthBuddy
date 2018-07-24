namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ManaCrystalMgr")]
    public class ManaCrystalMgr : MonoBehaviour
    {
        public ManaCrystalMgr(IntPtr address) : this(address, "ManaCrystalMgr")
        {
        }

        public ManaCrystalMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddManaCrystals(int numCrystals, bool isTurnStart)
        {
            object[] objArray1 = new object[] { numCrystals, isTurnStart };
            base.method_8("AddManaCrystals", objArray1);
        }

        public void AddTempManaCrystals(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("AddTempManaCrystals", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CancelAllProposedMana(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("CancelAllProposedMana", objArray1);
        }

        public void DestroyManaCrystal()
        {
            base.method_8("DestroyManaCrystal", Array.Empty<object>());
        }

        public void DestroyManaCrystals(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("DestroyManaCrystals", objArray1);
        }

        public void DestroyTempManaCrystal()
        {
            base.method_8("DestroyTempManaCrystal", Array.Empty<object>());
        }

        public void DestroyTempManaCrystals(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("DestroyTempManaCrystals", objArray1);
        }

        public static ManaCrystalMgr Get()
        {
            return MonoClass.smethod_15<ManaCrystalMgr>(TritonHs.MainAssemblyPath, "", "ManaCrystalMgr", "Get", Array.Empty<object>());
        }

        public Vector3 GetManaCrystalSpawnPosition()
        {
            return base.method_11<Vector3>("GetManaCrystalSpawnPosition", Array.Empty<object>());
        }

        public int GetSpendableManaCrystals()
        {
            return base.method_11<int>("GetSpendableManaCrystals", Array.Empty<object>());
        }

        public float GetWidth()
        {
            return base.method_11<float>("GetWidth", Array.Empty<object>());
        }

        public void HandleSameTurnOverloadChanged(int crystalsChanged)
        {
            object[] objArray1 = new object[] { crystalsChanged };
            base.method_8("HandleSameTurnOverloadChanged", objArray1);
        }

        public void HidePhoneManaTray()
        {
            base.method_8("HidePhoneManaTray", Array.Empty<object>());
        }

        public void LoadCrystalCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadCrystalCallback", objArray1);
        }

        public void MarkCrystalsOwedForOverload(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("MarkCrystalsOwedForOverload", objArray1);
        }

        public void OnCurrentPlayerChanged()
        {
            base.method_8("OnCurrentPlayerChanged", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void ProposeManaCrystalUsage(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("ProposeManaCrystalUsage", objArray1);
        }

        public void ReadyManaCrystal()
        {
            base.method_8("ReadyManaCrystal", Array.Empty<object>());
        }

        public void ReadyManaCrystals(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("ReadyManaCrystals", objArray1);
        }

        public void ReclaimCrystalsOwedForOverload(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("ReclaimCrystalsOwedForOverload", objArray1);
        }

        public void SetFriendlyManaGemTexture(Texture texture)
        {
            object[] objArray1 = new object[] { texture };
            base.method_8("SetFriendlyManaGemTexture", objArray1);
        }

        public void SetFriendlyManaGemTint(Color tint)
        {
            object[] objArray1 = new object[] { tint };
            base.method_8("SetFriendlyManaGemTint", objArray1);
        }

        public bool ShouldShowOverloadTooltip()
        {
            return base.method_11<bool>("ShouldShowOverloadTooltip", Array.Empty<object>());
        }

        public void ShowPhoneManaTray()
        {
            base.method_8("ShowPhoneManaTray", Array.Empty<object>());
        }

        public void SpendManaCrystal()
        {
            base.method_8("SpendManaCrystal", Array.Empty<object>());
        }

        public void SpendManaCrystals(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("SpendManaCrystals", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UnlockCrystals(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("UnlockCrystals", objArray1);
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateSpentMana(int shownChangeAmount)
        {
            object[] objArray1 = new object[] { shownChangeAmount };
            base.method_8("UpdateSpentMana", objArray1);
        }

        public static float ANIMATE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ManaCrystalMgr", "ANIMATE_TIME");
            }
        }

        public GameObject friendlyManaCounter
        {
            get
            {
                return base.method_3<GameObject>("friendlyManaCounter");
            }
        }

        public Texture friendlyManaGemTexture
        {
            get
            {
                return base.method_3<Texture>("friendlyManaGemTexture");
            }
        }

        public string GEM_FLIP_ANIM_NAME
        {
            get
            {
                return base.method_4("GEM_FLIP_ANIM_NAME");
            }
        }

        public static float GEM_FLIP_TEXT_FADE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ManaCrystalMgr", "GEM_FLIP_TEXT_FADE_TIME");
            }
        }

        public int m_additionalOverloadedCrystalsOwedNextTurn
        {
            get
            {
                return base.method_2<int>("m_additionalOverloadedCrystalsOwedNextTurn");
            }
        }

        public int m_additionalOverloadedCrystalsOwedThisTurn
        {
            get
            {
                return base.method_2<int>("m_additionalOverloadedCrystalsOwedThisTurn");
            }
        }

        public ManaCrystalEventSpells m_eventSpells
        {
            get
            {
                return base.method_3<ManaCrystalEventSpells>("m_eventSpells");
            }
        }

        public GameObject m_friendlyManaGem
        {
            get
            {
                return base.method_3<GameObject>("m_friendlyManaGem");
            }
        }

        public UberText m_friendlyManaText
        {
            get
            {
                return base.method_3<UberText>("m_friendlyManaText");
            }
        }

        public float m_manaCrystalWidth
        {
            get
            {
                return base.method_2<float>("m_manaCrystalWidth");
            }
        }

        public int m_numCrystalsLoading
        {
            get
            {
                return base.method_2<int>("m_numCrystalsLoading");
            }
        }

        public int m_numQueuedToReady
        {
            get
            {
                return base.method_2<int>("m_numQueuedToReady");
            }
        }

        public int m_numQueuedToSpawn
        {
            get
            {
                return base.method_2<int>("m_numQueuedToSpawn");
            }
        }

        public int m_numQueuedToSpend
        {
            get
            {
                return base.method_2<int>("m_numQueuedToSpend");
            }
        }

        public bool m_overloadLocksAreShowing
        {
            get
            {
                return base.method_2<bool>("m_overloadLocksAreShowing");
            }
        }

        public List<ManaCrystal> m_permanentCrystals
        {
            get
            {
                Class267<ManaCrystal> class2 = base.method_3<Class267<ManaCrystal>>("m_permanentCrystals");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_proposedManaSourceEntID
        {
            get
            {
                return base.method_2<int>("m_proposedManaSourceEntID");
            }
        }

        public List<ManaCrystal> m_temporaryCrystals
        {
            get
            {
                Class267<ManaCrystal> class2 = base.method_3<Class267<ManaCrystal>>("m_temporaryCrystals");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Transform manaGemBone
        {
            get
            {
                return base.method_3<Transform>("manaGemBone");
            }
        }

        public SlidingTray manaTrayPhone
        {
            get
            {
                return base.method_3<SlidingTray>("manaTrayPhone");
            }
        }

        public static float SECS_BETW_MANA_READIES
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ManaCrystalMgr", "SECS_BETW_MANA_READIES");
            }
        }

        public static float SECS_BETW_MANA_SPAWNS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ManaCrystalMgr", "SECS_BETW_MANA_SPAWNS");
            }
        }

        public static float SECS_BETW_MANA_SPENDS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ManaCrystalMgr", "SECS_BETW_MANA_SPENDS");
            }
        }

        public Material tempManaCrystalMaterial
        {
            get
            {
                return base.method_3<Material>("tempManaCrystalMaterial");
            }
        }

        public Material tempManaCrystalProposedQuadMaterial
        {
            get
            {
                return base.method_3<Material>("tempManaCrystalProposedQuadMaterial");
            }
        }

        [Attribute38("ManaCrystalMgr.LoadCrystalCallbackData")]
        public class LoadCrystalCallbackData : MonoClass
        {
            public LoadCrystalCallbackData(IntPtr address) : this(address, "LoadCrystalCallbackData")
            {
            }

            public LoadCrystalCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public bool IsTempCrystal
            {
                get
                {
                    return base.method_11<bool>("get_IsTempCrystal", Array.Empty<object>());
                }
            }

            public bool IsTurnStart
            {
                get
                {
                    return base.method_11<bool>("get_IsTurnStart", Array.Empty<object>());
                }
            }

            public bool m_isTempCrystal
            {
                get
                {
                    return base.method_2<bool>("m_isTempCrystal");
                }
            }

            public bool m_isTurnStart
            {
                get
                {
                    return base.method_2<bool>("m_isTurnStart");
                }
            }
        }
    }
}

