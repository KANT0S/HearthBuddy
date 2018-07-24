namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureClassChallenge")]
    public class AdventureClassChallenge : MonoBehaviour
    {
        public AdventureClassChallenge(IntPtr address) : this(address, "AdventureClassChallenge")
        {
        }

        public AdventureClassChallenge(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BackButton()
        {
            base.method_8("BackButton", Array.Empty<object>());
        }

        public int BossCreateParamsSortComparison(ClassChallengeData data1, ClassChallengeData data2)
        {
            object[] objArray1 = new object[] { data1, data2 };
            return base.method_11<int>("BossCreateParamsSortComparison", objArray1);
        }

        public void ButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ButtonPressed", objArray1);
        }

        public void GetRewardCardForSelectedScenario()
        {
            base.method_8("GetRewardCardForSelectedScenario", Array.Empty<object>());
        }

        public void InitAdventureChallenges()
        {
            base.method_8("InitAdventureChallenges", Array.Empty<object>());
        }

        public void InitModeName()
        {
            base.method_8("InitModeName", Array.Empty<object>());
        }

        public void LoadButtonPortrait(AdventureClassChallengeButton button, string heroID)
        {
            object[] objArray1 = new object[] { button, heroID };
            base.method_8("LoadButtonPortrait", objArray1);
        }

        public void LoadHero(int heroNum, string heroID)
        {
            object[] objArray1 = new object[] { heroNum, heroID };
            base.method_8("LoadHero", objArray1);
        }

        public void OnActorLoaded(string name, GameObject actorObject, object userData)
        {
            object[] objArray1 = new object[] { name, actorObject, userData };
            base.method_8("OnActorLoaded", objArray1);
        }

        public void OnButtonFullDefLoaded(string cardId, FullDef fullDef, object userData)
        {
            object[] objArray1 = new object[] { cardId, fullDef, userData };
            base.method_8("OnButtonFullDefLoaded", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
        }

        public void OnHeroFullDefLoaded(string cardId, FullDef fullDef, object userData)
        {
            object[] objArray1 = new object[] { cardId, fullDef, userData };
            base.method_8("OnHeroFullDefLoaded", objArray1);
        }

        public static bool OnNavigateBack()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AdventureClassChallenge", "OnNavigateBack", Array.Empty<object>());
        }

        public void OnVersusLettersLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnVersusLettersLoaded", objArray1);
        }

        public void Play()
        {
            base.method_8("Play", Array.Empty<object>());
        }

        public void RewardCardLoaded(Reward reward, object callbackData)
        {
            object[] objArray1 = new object[] { reward, callbackData };
            base.method_8("RewardCardLoaded", objArray1);
        }

        public void SetScenario(int scenarioID)
        {
            object[] objArray1 = new object[] { scenarioID };
            base.method_8("SetScenario", objArray1);
        }

        public void SetSelectedButton(AdventureClassChallengeButton button)
        {
            object[] objArray1 = new object[] { button };
            base.method_8("SetSelectedButton", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public static float CHALLENGE_BUTTON_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AdventureClassChallenge", "CHALLENGE_BUTTON_OFFSET");
            }
        }

        public List<float> EMPTY_SLOT_UV_OFFSET
        {
            get
            {
                Class246<float> class2 = base.method_3<Class246<float>>("EMPTY_SLOT_UV_OFFSET");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UIBButton m_BackButton
        {
            get
            {
                return base.method_3<UIBButton>("m_BackButton");
            }
        }

        public GameObject m_ChallengeButtonContainer
        {
            get
            {
                return base.method_3<GameObject>("m_ChallengeButtonContainer");
            }
        }

        public float m_ChallengeButtonHeight
        {
            get
            {
                return base.method_2<float>("m_ChallengeButtonHeight");
            }
        }

        public UIBScrollable m_ChallengeButtonScroller
        {
            get
            {
                return base.method_3<UIBScrollable>("m_ChallengeButtonScroller");
            }
        }

        public UberText m_ChallengeDescription
        {
            get
            {
                return base.method_3<UberText>("m_ChallengeDescription");
            }
        }

        public UberText m_ChallengeTitle
        {
            get
            {
                return base.method_3<UberText>("m_ChallengeTitle");
            }
        }

        public AdventureClassChallengeChestButton m_ChestButton
        {
            get
            {
                return base.method_3<AdventureClassChallengeChestButton>("m_ChestButton");
            }
        }

        public GameObject m_ChestButtonCover
        {
            get
            {
                return base.method_3<GameObject>("m_ChestButtonCover");
            }
        }

        public GameObject m_ClassChallengeButtonPrefab
        {
            get
            {
                return base.method_3<GameObject>("m_ClassChallengeButtonPrefab");
            }
        }

        public Vector3 m_ClassChallengeButtonSpacing
        {
            get
            {
                return base.method_2<Vector3>("m_ClassChallengeButtonSpacing");
            }
        }

        public List<ClassChallengeData> m_ClassChallenges
        {
            get
            {
                Class267<ClassChallengeData> class2 = base.method_3<Class267<ClassChallengeData>>("m_ClassChallenges");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_EmptyChallengeButtonSlot
        {
            get
            {
                return base.method_3<GameObject>("m_EmptyChallengeButtonSlot");
            }
        }

        public bool m_gameDenied
        {
            get
            {
                return base.method_2<bool>("m_gameDenied");
            }
        }

        public GameObject m_LeftHero
        {
            get
            {
                return base.method_3<GameObject>("m_LeftHero");
            }
        }

        public GameObject m_LeftHeroContainer
        {
            get
            {
                return base.method_3<GameObject>("m_LeftHeroContainer");
            }
        }

        public UberText m_LeftHeroName
        {
            get
            {
                return base.method_3<UberText>("m_LeftHeroName");
            }
        }

        public UberText m_ModeName
        {
            get
            {
                return base.method_3<UberText>("m_ModeName");
            }
        }

        public PlayButton m_PlayButton
        {
            get
            {
                return base.method_3<PlayButton>("m_PlayButton");
            }
        }

        public Transform m_RewardBone
        {
            get
            {
                return base.method_3<Transform>("m_RewardBone");
            }
        }

        public GameObject m_RightHero
        {
            get
            {
                return base.method_3<GameObject>("m_RightHero");
            }
        }

        public GameObject m_RightHeroContainer
        {
            get
            {
                return base.method_3<GameObject>("m_RightHeroContainer");
            }
        }

        public UberText m_RightHeroName
        {
            get
            {
                return base.method_3<UberText>("m_RightHeroName");
            }
        }

        public AdventureClassChallengeButton m_SelectedButton
        {
            get
            {
                return base.method_3<AdventureClassChallengeButton>("m_SelectedButton");
            }
        }

        public int m_SelectedScenario
        {
            get
            {
                return base.method_2<int>("m_SelectedScenario");
            }
        }

        public int m_UVoffset
        {
            get
            {
                return base.method_2<int>("m_UVoffset");
            }
        }

        public Color m_VersusTextColor
        {
            get
            {
                return base.method_2<Color>("m_VersusTextColor");
            }
        }

        public GameObject m_VersusTextContainer
        {
            get
            {
                return base.method_3<GameObject>("m_VersusTextContainer");
            }
        }

        public string m_VersusTextPrefab
        {
            get
            {
                return base.method_4("m_VersusTextPrefab");
            }
        }

        public static int VISIBLE_SLOT_COUNT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AdventureClassChallenge", "VISIBLE_SLOT_COUNT");
            }
        }

        [Attribute38("AdventureClassChallenge.ClassChallengeData")]
        public class ClassChallengeData : MonoClass
        {
            public ClassChallengeData(IntPtr address) : this(address, "ClassChallengeData")
            {
            }

            public ClassChallengeData(IntPtr address, string className) : base(address, className)
            {
            }

            public string completedDescription
            {
                get
                {
                    return base.method_4("completedDescription");
                }
            }

            public bool defeated
            {
                get
                {
                    return base.method_2<bool>("defeated");
                }
            }

            public string description
            {
                get
                {
                    return base.method_4("description");
                }
            }

            public string heroID0
            {
                get
                {
                    return base.method_4("heroID0");
                }
            }

            public string heroID1
            {
                get
                {
                    return base.method_4("heroID1");
                }
            }

            public string name
            {
                get
                {
                    return base.method_4("name");
                }
            }

            public string opponentName
            {
                get
                {
                    return base.method_4("opponentName");
                }
            }

            public ScenarioDbfRecord scenarioRecord
            {
                get
                {
                    return base.method_3<ScenarioDbfRecord>("scenarioRecord");
                }
            }

            public string title
            {
                get
                {
                    return base.method_4("title");
                }
            }

            public bool unlocked
            {
                get
                {
                    return base.method_2<bool>("unlocked");
                }
            }
        }

        [Attribute38("AdventureClassChallenge.HeroLoadData")]
        public class HeroLoadData : MonoClass
        {
            public HeroLoadData(IntPtr address) : this(address, "HeroLoadData")
            {
            }

            public HeroLoadData(IntPtr address, string className) : base(address, className)
            {
            }

            public FullDef fulldef
            {
                get
                {
                    return base.method_3<FullDef>("fulldef");
                }
            }

            public string heroID
            {
                get
                {
                    return base.method_4("heroID");
                }
            }

            public int heroNum
            {
                get
                {
                    return base.method_2<int>("heroNum");
                }
            }
        }
    }
}

