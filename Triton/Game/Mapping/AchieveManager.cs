namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AchieveManager")]
    public class AchieveManager : MonoClass
    {
        public AchieveManager(IntPtr address) : this(address, "AchieveManager")
        {
        }

        public AchieveManager(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanCancelQuest(int achieveID)
        {
            object[] objArray1 = new object[] { achieveID };
            return base.method_11<bool>("CanCancelQuest", objArray1);
        }

        public bool CanCancelQuestNow()
        {
            return base.method_11<bool>("CanCancelQuestNow", Array.Empty<object>());
        }

        public void CancelQuest(int achieveID)
        {
            object[] objArray1 = new object[] { achieveID };
            base.method_8("CancelQuest", objArray1);
        }

        public void CheckAllCardGainAchieves()
        {
            base.method_8("CheckAllCardGainAchieves", Array.Empty<object>());
        }

        public void CheckTimedTimedEventsAndLicenses(DateTime utcNow)
        {
            object[] objArray1 = new object[] { utcNow };
            base.method_8("CheckTimedTimedEventsAndLicenses", objArray1);
        }

        public void FireAchieveCanceledEvent(int achieveID, bool success)
        {
            object[] objArray1 = new object[] { achieveID, success };
            base.method_8("FireAchieveCanceledEvent", objArray1);
        }

        public void FireLicenseAddedAchievesUpdatedEvent()
        {
            base.method_8("FireLicenseAddedAchievesUpdatedEvent", Array.Empty<object>());
        }

        public static AchieveManager Get()
        {
            return MonoClass.smethod_15<AchieveManager>(TritonHs.MainAssemblyPath, "", "AchieveManager", "Get", Array.Empty<object>());
        }

        public Achievement GetAchievement(int achieveID)
        {
            object[] objArray1 = new object[] { achieveID };
            return base.method_14<Achievement>("GetAchievement", objArray1);
        }

        public List<Achievement> GetAchievesInGroup(Achievement.Group achieveGroup)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { achieveGroup };
            Class267<Achievement> class2 = base.method_15<Class267<Achievement>>("GetAchievesInGroup", enumArray1, objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<Achievement> GetAchievesInGroup(Achievement.Group achieveGroup, bool isComplete)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { achieveGroup, isComplete };
            Class267<Achievement> class2 = base.method_15<Class267<Achievement>>("GetAchievesInGroup", enumArray1, objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<Achievement> GetActiveLicenseAddedAchieves()
        {
            Class267<Achievement> class2 = base.method_14<Class267<Achievement>>("GetActiveLicenseAddedAchieves", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<Achievement> GetActiveQuests(bool onlyNewlyActive)
        {
            object[] objArray1 = new object[] { onlyNewlyActive };
            Class267<Achievement> class2 = base.method_14<Class267<Achievement>>("GetActiveQuests", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<Achievement> GetCompletedAchieves()
        {
            Class267<Achievement> class2 = base.method_14<Class267<Achievement>>("GetCompletedAchieves", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<Achievement> GetNewCompletedAchieves()
        {
            Class267<Achievement> class2 = base.method_14<Class267<Achievement>>("GetNewCompletedAchieves", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<Achievement> GetNewlyProgressedQuests()
        {
            Class267<Achievement> class2 = base.method_14<Class267<Achievement>>("GetNewlyProgressedQuests", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetNumAchievesInGroup(Achievement.Group achieveGroup)
        {
            object[] objArray1 = new object[] { achieveGroup };
            return base.method_11<int>("GetNumAchievesInGroup", objArray1);
        }

        public Achievement GetUnlockGoldenHeroAchievement(string heroCardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { heroCardID, premium };
            return base.method_14<Achievement>("GetUnlockGoldenHeroAchievement", objArray1);
        }

        public bool HasActiveAchievesForEvent(SpecialEventType eventTrigger)
        {
            object[] objArray1 = new object[] { eventTrigger };
            return base.method_11<bool>("HasActiveAchievesForEvent", objArray1);
        }

        public bool HasActiveLicenseAddedAchieves()
        {
            return base.method_11<bool>("HasActiveLicenseAddedAchieves", Array.Empty<object>());
        }

        public bool HasActiveQuests(bool onlyNewlyActive)
        {
            object[] objArray1 = new object[] { onlyNewlyActive };
            return base.method_11<bool>("HasActiveQuests", objArray1);
        }

        public bool HasIncompletePurchaseAchieves()
        {
            return base.method_11<bool>("HasIncompletePurchaseAchieves", Array.Empty<object>());
        }

        public bool HasUnlockedFeature(Achievement.UnlockableFeature feature)
        {
            object[] objArray1 = new object[] { feature };
            return base.method_11<bool>("HasUnlockedFeature", objArray1);
        }

        public void Heartbeat()
        {
            base.method_8("Heartbeat", Array.Empty<object>());
        }

        public static void Init()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "AchieveManager", "Init");
        }

        public void InitAchieveManager()
        {
            base.method_8("InitAchieveManager", Array.Empty<object>());
        }

        public void InitAchievement(Achievement achievement)
        {
            object[] objArray1 = new object[] { achievement };
            base.method_8("InitAchievement", objArray1);
        }

        public static void InitRequests()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "AchieveManager", "InitRequests");
        }

        public static bool IsActiveQuest(Achievement obj, bool onlyNewlyActive)
        {
            object[] objArray1 = new object[] { obj, onlyNewlyActive };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AchieveManager", "IsActiveQuest", objArray1);
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public void LoadAchievesFromDBF()
        {
            base.method_8("LoadAchievesFromDBF", Array.Empty<object>());
        }

        public void NotifyOfCardGained(EntityDef entityDef, TAG_PREMIUM premium, int totalCount)
        {
            object[] objArray1 = new object[] { entityDef, premium, totalCount };
            base.method_8("NotifyOfCardGained", objArray1);
        }

        public void NotifyOfClick(Achievement.ClickTriggerType clickType)
        {
            object[] objArray1 = new object[] { clickType };
            base.method_8("NotifyOfClick", objArray1);
        }

        public void OnAccountLicenseAchieveResponse()
        {
            base.method_8("OnAccountLicenseAchieveResponse", Array.Empty<object>());
        }

        public void OnAccountLicenseAchievesUpdated(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnAccountLicenseAchievesUpdated", objArray1);
        }

        public void OnAchieves()
        {
            base.method_8("OnAchieves", Array.Empty<object>());
        }

        public void OnAchieveValidated()
        {
            base.method_8("OnAchieveValidated", Array.Empty<object>());
        }

        public void OnActiveAndNewCompleteAchieves(Network.AchieveList activeAchievesList)
        {
            object[] objArray1 = new object[] { activeAchievesList };
            base.method_8("OnActiveAndNewCompleteAchieves", objArray1);
        }

        public void OnAllAchieves(Network.AchieveList allAchievesList)
        {
            object[] objArray1 = new object[] { allAchievesList };
            base.method_8("OnAllAchieves", objArray1);
        }

        public void OnEventTriggered()
        {
            base.method_8("OnEventTriggered", Array.Empty<object>());
        }

        public void OnQuestCanceled()
        {
            base.method_8("OnQuestCanceled", Array.Empty<object>());
        }

        public void TriggerLaunchDayEvent()
        {
            base.method_8("TriggerLaunchDayEvent", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public static long CHECK_LICENSE_ADDED_ACHIEVE_DELAY_TICKS
        {
            get
            {
                return MonoClass.smethod_6<long>(TritonHs.MainAssemblyPath, "", "AchieveManager", "CHECK_LICENSE_ADDED_ACHIEVE_DELAY_TICKS");
            }
        }

        public bool m_allNetAchievesReceived
        {
            get
            {
                return base.method_2<bool>("m_allNetAchievesReceived");
            }
        }

        public bool m_disableCancelButtonUntilServerReturns
        {
            get
            {
                return base.method_2<bool>("m_disableCancelButtonUntilServerReturns");
            }
        }

        public long m_lastEventTimingAndLicenseAchieveCheck
        {
            get
            {
                return base.method_2<long>("m_lastEventTimingAndLicenseAchieveCheck");
            }
        }

        public int m_numEventResponsesNeeded
        {
            get
            {
                return base.method_2<int>("m_numEventResponsesNeeded");
            }
        }

        public bool m_waitingForActiveAchieves
        {
            get
            {
                return base.method_2<bool>("m_waitingForActiveAchieves");
            }
        }

        public static long TIMED_ACHIEVE_VALIDATION_DELAY_TICKS
        {
            get
            {
                return MonoClass.smethod_6<long>(TritonHs.MainAssemblyPath, "", "AchieveManager", "TIMED_ACHIEVE_VALIDATION_DELAY_TICKS");
            }
        }

        public static long TIMED_AND_LICENSE_ACHIEVE_CHECK_DELAY_TICKS
        {
            get
            {
                return MonoClass.smethod_6<long>(TritonHs.MainAssemblyPath, "", "AchieveManager", "TIMED_AND_LICENSE_ACHIEVE_CHECK_DELAY_TICKS");
            }
        }
    }
}

