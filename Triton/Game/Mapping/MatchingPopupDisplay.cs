namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MatchingPopupDisplay")]
    public class MatchingPopupDisplay : TransitionPopup
    {
        public MatchingPopupDisplay(IntPtr address) : this(address, "MatchingPopupDisplay")
        {
        }

        public MatchingPopupDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void GenerateRandomSpinnerTexts()
        {
            base.method_8("GenerateRandomSpinnerTexts", Array.Empty<object>());
        }

        public void IncreaseTooltipProgress()
        {
            base.method_8("IncreaseTooltipProgress", Array.Empty<object>());
        }

        public void OnAnimateShowFinished()
        {
            base.method_8("OnAnimateShowFinished", Array.Empty<object>());
        }

        public void OnCancelButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelButtonReleased", objArray1);
        }

        public void OnGameCanceled(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameCanceled", objArray1);
        }

        public void OnGameConnecting(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameConnecting", objArray1);
        }

        public void OnGameDelayed(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameDelayed", objArray1);
        }

        public void OnGameEntered(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameEntered", objArray1);
        }

        public void OnGameError(FindGameEventData eventData)
        {
            object[] objArray1 = new object[] { eventData };
            base.method_8("OnGameError", objArray1);
        }

        public void OnGameplaySceneLoaded()
        {
            base.method_8("OnGameplaySceneLoaded", Array.Empty<object>());
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void SetupSpinnerText()
        {
            base.method_8("SetupSpinnerText", Array.Empty<object>());
        }

        public void ShowPopup()
        {
            base.method_8("ShowPopup", Array.Empty<object>());
        }

        public void UpdateTipOfTheDay()
        {
            base.method_8("UpdateTipOfTheDay", Array.Empty<object>());
        }

        public SceneMgr.Mode m_gameMode
        {
            get
            {
                return base.method_2<SceneMgr.Mode>("m_gameMode");
            }
        }

        public GameObject m_nameContainer
        {
            get
            {
                return base.method_3<GameObject>("m_nameContainer");
            }
        }

        public List<GameObject> m_spinnerTexts
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_spinnerTexts");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_tipOfTheDay
        {
            get
            {
                return base.method_3<UberText>("m_tipOfTheDay");
            }
        }

        public static int NUM_SPINNER_ENTRIES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "MatchingPopupDisplay", "NUM_SPINNER_ENTRIES");
            }
        }
    }
}

