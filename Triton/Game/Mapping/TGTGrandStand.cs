namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TGTGrandStand")]
    public class TGTGrandStand : MonoBehaviour
    {
        public TGTGrandStand(IntPtr address) : this(address, "TGTGrandStand")
        {
        }

        public TGTGrandStand(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FriendlyHeroDamage(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("FriendlyHeroDamage", objArray1);
        }

        public void FriendlyLegendaryDeath(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("FriendlyLegendaryDeath", objArray1);
        }

        public void FriendlyLegendarySpawn(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("FriendlyLegendarySpawn", objArray1);
        }

        public void FriendlyMinionDamage(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("FriendlyMinionDamage", objArray1);
        }

        public void FriendlyMinionDeath(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("FriendlyMinionDeath", objArray1);
        }

        public void FriendlyMinionSpawn(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("FriendlyMinionSpawn", objArray1);
        }

        public static TGTGrandStand Get()
        {
            return MonoClass.smethod_15<TGTGrandStand>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "Get", Array.Empty<object>());
        }

        public void HandleClicks()
        {
            base.method_8("HandleClicks", Array.Empty<object>());
        }

        public void HumanClick()
        {
            base.method_8("HumanClick", Array.Empty<object>());
        }

        public bool IsOver(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("IsOver", objArray1);
        }

        public void KnightClick()
        {
            base.method_8("KnightClick", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OpponentHeroDamage(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("OpponentHeroDamage", objArray1);
        }

        public void OpponentLegendaryDeath(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("OpponentLegendaryDeath", objArray1);
        }

        public void OpponentLegendarySpawn(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("OpponentLegendarySpawn", objArray1);
        }

        public void OpponentMinionDamage(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("OpponentMinionDamage", objArray1);
        }

        public void OpponentMinionDeath(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("OpponentMinionDeath", objArray1);
        }

        public void OpponentMinionSpawn(float weight)
        {
            object[] objArray1 = new object[] { weight };
            base.method_8("OpponentMinionSpawn", objArray1);
        }

        public void OrcClick()
        {
            base.method_8("OrcClick", Array.Empty<object>());
        }

        public void PlayCheerAnimation()
        {
            base.method_8("PlayCheerAnimation", Array.Empty<object>());
        }

        public void PlayOhNoAnimation()
        {
            base.method_8("PlayOhNoAnimation", Array.Empty<object>());
        }

        public void PlayScoreCard(string humanScore, string orcScore, string knightScore)
        {
            object[] objArray1 = new object[] { humanScore, orcScore, knightScore };
            base.method_8("PlayScoreCard", objArray1);
        }

        public void PlaySound(string soundString)
        {
            object[] objArray1 = new object[] { soundString };
            base.method_8("PlaySound", objArray1);
        }

        public void Shake()
        {
            base.method_8("Shake", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public List<string> ANIMATION_CHEER
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("ANIMATION_CHEER");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static string ANIMATION_IDLE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "ANIMATION_IDLE");
            }
        }

        public List<string> ANIMATION_OHNO
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("ANIMATION_OHNO");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static string ANIMATION_SCORE_CARD
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "ANIMATION_SCORE_CARD");
            }
        }

        public static float CHEER_ANIMATION_PLAY_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "CHEER_ANIMATION_PLAY_TIME");
            }
        }

        public static float FRIENDLY_HERO_DAMAGE_WEIGHT_TRGGER
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "FRIENDLY_HERO_DAMAGE_WEIGHT_TRGGER");
            }
        }

        public static float FRIENDLY_LEGENDARY_DEATH_MIN_COST_TRGGER
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "FRIENDLY_LEGENDARY_DEATH_MIN_COST_TRGGER");
            }
        }

        public static float FRIENDLY_LEGENDARY_SPAWN_MIN_COST_TRGGER
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "FRIENDLY_LEGENDARY_SPAWN_MIN_COST_TRGGER");
            }
        }

        public static float FRIENDLY_MINION_DAMAGE_WEIGHT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "FRIENDLY_MINION_DAMAGE_WEIGHT");
            }
        }

        public static float FRIENDLY_MINION_DEATH_WEIGHT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "FRIENDLY_MINION_DEATH_WEIGHT");
            }
        }

        public static float FRIENDLY_MINION_SPAWN_WEIGHT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "FRIENDLY_MINION_SPAWN_WEIGHT");
            }
        }

        public BoardEvents m_boardEvents
        {
            get
            {
                return base.method_3<BoardEvents>("m_boardEvents");
            }
        }

        public List<string> m_CheerHumanSounds
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_CheerHumanSounds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<string> m_CheerKnightSounds
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_CheerKnightSounds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<string> m_CheerOrcSounds
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_CheerOrcSounds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_ClickHumanSound
        {
            get
            {
                return base.method_4("m_ClickHumanSound");
            }
        }

        public string m_ClickKnightSound
        {
            get
            {
                return base.method_4("m_ClickKnightSound");
            }
        }

        public string m_ClickOrcSound
        {
            get
            {
                return base.method_4("m_ClickOrcSound");
            }
        }

        public GameObject m_HumanRoot
        {
            get
            {
                return base.method_3<GameObject>("m_HumanRoot");
            }
        }

        public GameObject m_HumanScoreCard
        {
            get
            {
                return base.method_3<GameObject>("m_HumanScoreCard");
            }
        }

        public UberText m_HumanScoreUberText
        {
            get
            {
                return base.method_3<UberText>("m_HumanScoreUberText");
            }
        }

        public bool m_isAnimating
        {
            get
            {
                return base.method_2<bool>("m_isAnimating");
            }
        }

        public GameObject m_KnightRoot
        {
            get
            {
                return base.method_3<GameObject>("m_KnightRoot");
            }
        }

        public GameObject m_KnightScoreCard
        {
            get
            {
                return base.method_3<GameObject>("m_KnightScoreCard");
            }
        }

        public UberText m_KnightScoreUberText
        {
            get
            {
                return base.method_3<UberText>("m_KnightScoreUberText");
            }
        }

        public List<string> m_OhNoHumanSounds
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_OhNoHumanSounds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<string> m_OhNoKnightSounds
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_OhNoKnightSounds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<string> m_OhNoOrcSounds
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_OhNoOrcSounds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_OrcRoot
        {
            get
            {
                return base.method_3<GameObject>("m_OrcRoot");
            }
        }

        public GameObject m_OrcScoreCard
        {
            get
            {
                return base.method_3<GameObject>("m_OrcScoreCard");
            }
        }

        public UberText m_OrcScoreUberText
        {
            get
            {
                return base.method_3<UberText>("m_OrcScoreUberText");
            }
        }

        public string m_ScoreCardSound
        {
            get
            {
                return base.method_4("m_ScoreCardSound");
            }
        }

        public static float MAX_RANDOM_TIME_FACTOR
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "MAX_RANDOM_TIME_FACTOR");
            }
        }

        public static float MIN_RANDOM_TIME_FACTOR
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "MIN_RANDOM_TIME_FACTOR");
            }
        }

        public static float OHNO_ANIMATION_PLAY_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "OHNO_ANIMATION_PLAY_TIME");
            }
        }

        public static float OPPONENT_HERO_DAMAGE_SCORE_CARD_10S_TRIGGER
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "OPPONENT_HERO_DAMAGE_SCORE_CARD_10S_TRIGGER");
            }
        }

        public static float OPPONENT_HERO_DAMAGE_SCORE_CARD_TRIGGER
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "OPPONENT_HERO_DAMAGE_SCORE_CARD_TRIGGER");
            }
        }

        public static float OPPONENT_HERO_DAMAGE_WEIGHT_TRGGER
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "OPPONENT_HERO_DAMAGE_WEIGHT_TRGGER");
            }
        }

        public static float OPPONENT_LEGENDARY_DEATH_MIN_COST_TRGGER
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "OPPONENT_LEGENDARY_DEATH_MIN_COST_TRGGER");
            }
        }

        public static float OPPONENT_LEGENDARY_SPAWN_MIN_COST_TRGGER
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "OPPONENT_LEGENDARY_SPAWN_MIN_COST_TRGGER");
            }
        }

        public static float OPPONENT_MINION_DAMAGE_WEIGHT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "OPPONENT_MINION_DAMAGE_WEIGHT");
            }
        }

        public static float OPPONENT_MINION_DEATH_WEIGHT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "OPPONENT_MINION_DEATH_WEIGHT");
            }
        }

        public static float OPPONENT_MINION_SPAWN_WEIGHT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TGTGrandStand", "OPPONENT_MINION_SPAWN_WEIGHT");
            }
        }
    }
}

