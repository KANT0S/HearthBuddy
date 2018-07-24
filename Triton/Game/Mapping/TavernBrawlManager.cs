namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TavernBrawlManager")]
    public class TavernBrawlManager : MonoClass
    {
        public TavernBrawlManager(IntPtr address) : this(address, "TavernBrawlManager")
        {
        }

        public TavernBrawlManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Cheat_ResetSeenStuff(int newValue)
        {
            object[] objArray1 = new object[] { newValue };
            base.method_8("Cheat_ResetSeenStuff", objArray1);
        }

        public void Cheat_ResetToServerData()
        {
            base.method_8("Cheat_ResetToServerData", Array.Empty<object>());
        }

        public void Cheat_SetScenario(int scenarioId)
        {
            object[] objArray1 = new object[] { scenarioId };
            base.method_8("Cheat_SetScenario", objArray1);
        }

        public void CheckLatestSeenSeason(bool canSetOption)
        {
            object[] objArray1 = new object[] { canSetOption };
            base.method_8("CheckLatestSeenSeason", objArray1);
        }

        public CollectionDeck CurrentDeck()
        {
            return base.method_14<CollectionDeck>("CurrentDeck", Array.Empty<object>());
        }

        public TavernBrawlMission CurrentMission()
        {
            return base.method_14<TavernBrawlMission>("CurrentMission", Array.Empty<object>());
        }

        public void FireTavernBrawlInfoReceived()
        {
            base.method_8("FireTavernBrawlInfoReceived", Array.Empty<object>());
        }

        public int GamesWon()
        {
            return base.method_11<int>("GamesWon", Array.Empty<object>());
        }

        public static TavernBrawlManager Get()
        {
            return MonoClass.smethod_15<TavernBrawlManager>(TritonHs.MainAssemblyPath, "", "TavernBrawlManager", "Get", Array.Empty<object>());
        }

        public DeckBuilder GetDeckBuilder()
        {
            return base.method_14<DeckBuilder>("GetDeckBuilder", Array.Empty<object>());
        }

        public bool HasCreatedDeck()
        {
            return base.method_11<bool>("HasCreatedDeck", Array.Empty<object>());
        }

        public bool HasValidDeck()
        {
            return base.method_11<bool>("HasValidDeck", Array.Empty<object>());
        }

        public static void Init()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "TavernBrawlManager", "Init");
        }

        public void InitImpl()
        {
            base.method_8("InitImpl", Array.Empty<object>());
        }

        public static bool IsInTavernBrawlFriendlyChallenge()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "TavernBrawlManager", "IsInTavernBrawlFriendlyChallenge", Array.Empty<object>());
        }

        public void NetCache_OnClientOptions()
        {
            base.method_8("NetCache_OnClientOptions", Array.Empty<object>());
        }

        public void NetCache_OnTavernBrawlInfo()
        {
            base.method_8("NetCache_OnTavernBrawlInfo", Array.Empty<object>());
        }

        public void Network_OnGetAssetResponse()
        {
            base.method_8("Network_OnGetAssetResponse", Array.Empty<object>());
        }

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
        }

        public void OnOptionChangedCallback(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnOptionChangedCallback", objArray1);
        }

        public static void PruneCachedAssetFiles(object userData)
        {
            object[] objArray1 = new object[] { userData };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "TavernBrawlManager", "PruneCachedAssetFiles", objArray1);
        }

        public void RefreshServerData()
        {
            base.method_8("RefreshServerData", Array.Empty<object>());
        }

        public void RegisterOptionsListeners(bool register)
        {
            object[] objArray1 = new object[] { register };
            base.method_8("RegisterOptionsListeners", objArray1);
        }

        public int RewardProgress()
        {
            return base.method_11<int>("RewardProgress", Array.Empty<object>());
        }

        public void ScheduledEndOfCurrentTBCallback(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("ScheduledEndOfCurrentTBCallback", objArray1);
        }

        public void ScheduledRefreshTBSpecCallback(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("ScheduledRefreshTBSpecCallback", objArray1);
        }

        public bool SelectHeroBeforeMission()
        {
            return base.method_11<bool>("SelectHeroBeforeMission", Array.Empty<object>());
        }

        public bool ShouldNewFriendlyChallengeBeTavernBrawl()
        {
            return base.method_11<bool>("ShouldNewFriendlyChallengeBeTavernBrawl", Array.Empty<object>());
        }

        public void StartGame(long deckId)
        {
            object[] objArray1 = new object[] { deckId };
            base.method_8("StartGame", objArray1);
        }

        public int WinStreak()
        {
            return base.method_11<int>("WinStreak", Array.Empty<object>());
        }

        public int CurrentTavernBrawlSeasonEnd
        {
            get
            {
                return base.method_11<int>("get_CurrentTavernBrawlSeasonEnd", Array.Empty<object>());
            }
        }

        public static float DEFAULT_REFRESH_SPEC_SLUSH_SECONDS_MAX
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TavernBrawlManager", "DEFAULT_REFRESH_SPEC_SLUSH_SECONDS_MAX");
            }
        }

        public static float DEFAULT_REFRESH_SPEC_SLUSH_SECONDS_MIN
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TavernBrawlManager", "DEFAULT_REFRESH_SPEC_SLUSH_SECONDS_MIN");
            }
        }

        public bool HasSeenTavernBrawlScreen
        {
            get
            {
                return base.method_11<bool>("get_HasSeenTavernBrawlScreen", Array.Empty<object>());
            }
        }

        public bool HasUnlockedTavernBrawl
        {
            get
            {
                return base.method_11<bool>("get_HasUnlockedTavernBrawl", Array.Empty<object>());
            }
        }

        public bool IsCheated
        {
            get
            {
                return base.method_11<bool>("get_IsCheated", Array.Empty<object>());
            }
        }

        public bool IsFirstTimeSeeingCurrentSeason
        {
            get
            {
                return base.method_11<bool>("get_IsFirstTimeSeeingCurrentSeason", Array.Empty<object>());
            }
        }

        public bool IsFirstTimeSeeingThisFeature
        {
            get
            {
                return base.method_11<bool>("get_IsFirstTimeSeeingThisFeature", Array.Empty<object>());
            }
        }

        public bool IsRefreshingTavernBrawlInfo
        {
            get
            {
                return base.method_11<bool>("get_IsRefreshingTavernBrawlInfo", Array.Empty<object>());
            }
        }

        public bool IsScenarioDataReady
        {
            get
            {
                return base.method_11<bool>("get_IsScenarioDataReady", Array.Empty<object>());
            }
        }

        public bool IsTavernBrawlActive
        {
            get
            {
                return base.method_11<bool>("get_IsTavernBrawlActive", Array.Empty<object>());
            }
        }

        public bool IsTavernBrawlInfoReady
        {
            get
            {
                return base.method_11<bool>("get_IsTavernBrawlInfoReady", Array.Empty<object>());
            }
        }

        public TavernBrawlMission m_currentMission
        {
            get
            {
                return base.method_3<TavernBrawlMission>("m_currentMission");
            }
        }

        public bool m_hasGottenClientOptionsAtLeastOnce
        {
            get
            {
                return base.method_2<bool>("m_hasGottenClientOptionsAtLeastOnce");
            }
        }

        public bool m_scenarioAssetPendingLoad
        {
            get
            {
                return base.method_2<bool>("m_scenarioAssetPendingLoad");
            }
        }

        public static int MINIMUM_CLASS_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TavernBrawlManager", "MINIMUM_CLASS_LEVEL");
            }
        }

        public static int NextCallbackToken
        {
            get
            {
                return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "TavernBrawlManager", "get_NextCallbackToken", Array.Empty<object>());
            }
        }

        public int NextTavernBrawlSeasonStart
        {
            get
            {
                return base.method_11<int>("get_NextTavernBrawlSeasonStart", Array.Empty<object>());
            }
        }

        public static int PRUNE_CACHED_ASSETS_MAX_AGE_DAYS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TavernBrawlManager", "PRUNE_CACHED_ASSETS_MAX_AGE_DAYS");
            }
        }

        public bool s_isFirstTimeSeeingCurrentSeason
        {
            get
            {
                return base.method_2<bool>("s_isFirstTimeSeeingCurrentSeason");
            }
        }

        public bool s_isFirstTimeSeeingThisFeature
        {
            get
            {
                return base.method_2<bool>("s_isFirstTimeSeeingThisFeature");
            }
        }

        public static int s_nextCallbackToken
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TavernBrawlManager", "s_nextCallbackToken");
            }
        }

        public float ScheduledSecondsToRefresh
        {
            get
            {
                return base.method_11<float>("get_ScheduledSecondsToRefresh", Array.Empty<object>());
            }
        }
    }
}

