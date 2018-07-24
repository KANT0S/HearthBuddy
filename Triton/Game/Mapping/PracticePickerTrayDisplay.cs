namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PracticePickerTrayDisplay")]
    public class PracticePickerTrayDisplay : MonoBehaviour
    {
        public PracticePickerTrayDisplay(IntPtr address) : this(address, "PracticePickerTrayDisplay")
        {
        }

        public PracticePickerTrayDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void AIButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("AIButtonPressed", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BackButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("BackButtonReleased", objArray1);
        }

        public void DisableAIButtons()
        {
            base.method_8("DisableAIButtons", Array.Empty<object>());
        }

        public void EnableAIButtons()
        {
            base.method_8("EnableAIButtons", Array.Empty<object>());
        }

        public void FireTrayLoadedEvent()
        {
            base.method_8("FireTrayLoadedEvent", Array.Empty<object>());
        }

        public static PracticePickerTrayDisplay Get()
        {
            return MonoClass.smethod_15<PracticePickerTrayDisplay>(TritonHs.MainAssemblyPath, "", "PracticePickerTrayDisplay", "Get", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void InitMissionRecords()
        {
            base.method_8("InitMissionRecords", Array.Empty<object>());
        }

        public bool IsLoaded()
        {
            return base.method_11<bool>("IsLoaded", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
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

        public void OnFullDefLoaded(string cardId, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardId, def, userData };
            base.method_8("OnFullDefLoaded", objArray1);
        }

        public void OnGameDenied()
        {
            base.method_8("OnGameDenied", Array.Empty<object>());
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void PlayGameButtonRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("PlayGameButtonRelease", objArray1);
        }

        public void SetSelectedButton(PracticeAIButton button)
        {
            object[] objArray1 = new object[] { button };
            base.method_8("SetSelectedButton", objArray1);
        }

        public void SetupHeroAchieves()
        {
            base.method_8("SetupHeroAchieves", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateAIButtonPositions()
        {
            base.method_8("UpdateAIButtonPositions", Array.Empty<object>());
        }

        public void UpdateAIButtons()
        {
            base.method_8("UpdateAIButtons", Array.Empty<object>());
        }

        public void UpdateAIDeckButtons()
        {
            base.method_8("UpdateAIDeckButtons", Array.Empty<object>());
        }

        public float AIButtonHeight
        {
            get
            {
                return base.method_11<float>("get_AIButtonHeight", Array.Empty<object>());
            }
        }

        public float m_AIButtonHeight
        {
            get
            {
                return base.method_2<float>("m_AIButtonHeight");
            }
        }

        public PracticeAIButton m_AIButtonPrefab
        {
            get
            {
                return base.method_3<PracticeAIButton>("m_AIButtonPrefab");
            }
        }

        public GameObject m_AIButtonsContainer
        {
            get
            {
                return base.method_3<GameObject>("m_AIButtonsContainer");
            }
        }

        public StandardPegButtonNew m_backButton
        {
            get
            {
                return base.method_3<StandardPegButtonNew>("m_backButton");
            }
        }

        public bool m_buttonsCreated
        {
            get
            {
                return base.method_2<bool>("m_buttonsCreated");
            }
        }

        public bool m_buttonsReady
        {
            get
            {
                return base.method_2<bool>("m_buttonsReady");
            }
        }

        public int m_heroDefsToLoad
        {
            get
            {
                return base.method_2<int>("m_heroDefsToLoad");
            }
        }

        public bool m_heroesLoaded
        {
            get
            {
                return base.method_2<bool>("m_heroesLoaded");
            }
        }

        public List<Achievement> m_lockedHeroes
        {
            get
            {
                Class267<Achievement> class2 = base.method_3<Class267<Achievement>>("m_lockedHeroes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public PlayButton m_playButton
        {
            get
            {
                return base.method_3<PlayButton>("m_playButton");
            }
        }

        public List<PracticeAIButton> m_practiceAIButtons
        {
            get
            {
                Class267<PracticeAIButton> class2 = base.method_3<Class267<PracticeAIButton>>("m_practiceAIButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public PracticeAIButton m_selectedPracticeAIButton
        {
            get
            {
                return base.method_3<PracticeAIButton>("m_selectedPracticeAIButton");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public List<ScenarioDbfRecord> m_sortedMissionRecords
        {
            get
            {
                Class267<ScenarioDbfRecord> class2 = base.method_3<Class267<ScenarioDbfRecord>>("m_sortedMissionRecords");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_trayAnimationTime
        {
            get
            {
                return base.method_2<float>("m_trayAnimationTime");
            }
        }

        public iTween.EaseType m_trayInEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_trayInEaseType");
            }
        }

        public UberText m_trayLabel
        {
            get
            {
                return base.method_3<UberText>("m_trayLabel");
            }
        }

        public iTween.EaseType m_trayOutEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_trayOutEaseType");
            }
        }

        public static int NUM_AI_BUTTONS_TO_SHOW
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "PracticePickerTrayDisplay", "NUM_AI_BUTTONS_TO_SHOW");
            }
        }

        public static float PRACTICE_TRAY_MATERIAL_Y_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "PracticePickerTrayDisplay", "PRACTICE_TRAY_MATERIAL_Y_OFFSET");
            }
        }
    }
}

