namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameToastMgr")]
    public class GameToastMgr : MonoBehaviour
    {
        public GameToastMgr(IntPtr address) : this(address, "GameToastMgr")
        {
        }

        public GameToastMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddQuestProgressToast(string questName, string questDescription, int progress, int maxProgress)
        {
            object[] objArray1 = new object[] { questName, questDescription, progress, maxProgress };
            base.method_8("AddQuestProgressToast", objArray1);
        }

        public void AddSeasonTimeRemainingToast()
        {
            base.method_8("AddSeasonTimeRemainingToast", Array.Empty<object>());
        }

        public void AddToast(GameToast toast)
        {
            object[] objArray1 = new object[] { toast };
            base.method_8("AddToast", objArray1);
        }

        public bool AreToastsActive()
        {
            return base.method_11<bool>("AreToastsActive", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DeactivateToast(GameToast toast)
        {
            object[] objArray1 = new object[] { toast };
            base.method_8("DeactivateToast", objArray1);
        }

        public void FadeOutToast(GameToast toast)
        {
            object[] objArray1 = new object[] { toast };
            base.method_8("FadeOutToast", objArray1);
        }

        public static GameToastMgr Get()
        {
            return MonoClass.smethod_15<GameToastMgr>(TritonHs.MainAssemblyPath, "", "GameToastMgr", "Get", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void UpdateQuestProgressToasts()
        {
            base.method_8("UpdateQuestProgressToasts", Array.Empty<object>());
        }

        public void UpdateToastPositions()
        {
            base.method_8("UpdateToastPositions", Array.Empty<object>());
        }

        public static float FADE_IN_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GameToastMgr", "FADE_IN_TIME");
            }
        }

        public static float FADE_OUT_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GameToastMgr", "FADE_OUT_TIME");
            }
        }

        public static float HOLD_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GameToastMgr", "HOLD_TIME");
            }
        }

        public int m_numToastsShown
        {
            get
            {
                return base.method_2<int>("m_numToastsShown");
            }
        }

        public QuestProgressToast m_questProgressToastPrefab
        {
            get
            {
                return base.method_3<QuestProgressToast>("m_questProgressToastPrefab");
            }
        }

        public SeasonTimeRemainingToast m_seasonTimeRemainingToastPrefab
        {
            get
            {
                return base.method_3<SeasonTimeRemainingToast>("m_seasonTimeRemainingToastPrefab");
            }
        }

        public List<GameToast> m_toasts
        {
            get
            {
                Class267<GameToast> class2 = base.method_3<Class267<GameToast>>("m_toasts");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static int MAX_DAYS_TO_SHOW_TIME_REMAINING
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "GameToastMgr", "MAX_DAYS_TO_SHOW_TIME_REMAINING");
            }
        }

        public enum SEASON_TOAST_THRESHHOLDS
        {
            FIVE = 5,
            FOUR = 4,
            NONE = 0,
            ONE = 1,
            TEN = 10,
            THREE = 3,
            TWO = 2
        }

        public enum TOAST_TYPE
        {
            NORMAL,
            NO_COUNT
        }
    }
}

