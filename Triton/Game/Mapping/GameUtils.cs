namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameUtils")]
    public class GameUtils : MonoClass
    {
        public GameUtils(IntPtr address) : this(address, "GameUtils")
        {
        }

        public GameUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static void ApplyHideEntity(Triton.Game.Mapping.Entity entity, Network.HistHideEntity hideEntity)
        {
            object[] objArray1 = new object[] { entity, hideEntity };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "GameUtils", "ApplyHideEntity", objArray1);
        }

        public static void ApplyPower(Triton.Game.Mapping.Entity entity, Network.PowerHistory power)
        {
            object[] objArray1 = new object[] { entity, power };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "GameUtils", "ApplyPower", objArray1);
        }

        public static void ApplyShowEntity(Triton.Game.Mapping.Entity entity, Network.HistShowEntity showEntity)
        {
            object[] objArray1 = new object[] { entity, showEntity };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "GameUtils", "ApplyShowEntity", objArray1);
        }

        public static void ApplyTagChange(Triton.Game.Mapping.Entity entity, Network.HistTagChange tagChange)
        {
            object[] objArray1 = new object[] { entity, tagChange };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "GameUtils", "ApplyTagChange", objArray1);
        }

        public static bool AreAllTutorialsComplete()
        {
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "AreAllTutorialsComplete", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static bool AreAllTutorialsComplete(long campaignProgress)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I8 };
            object[] objArray1 = new object[] { campaignProgress };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "AreAllTutorialsComplete", enumArray1, objArray1);
        }

        public static bool AreAllTutorialsComplete(TutorialProgress progress)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { progress };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "AreAllTutorialsComplete", enumArray1, objArray1);
        }

        public static int CardPremiumSortComparisonAsc(TAG_PREMIUM premium1, TAG_PREMIUM premium2)
        {
            object[] objArray1 = new object[] { premium1, premium2 };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "CardPremiumSortComparisonAsc", objArray1);
        }

        public static int CardPremiumSortComparisonDesc(TAG_PREMIUM premium1, TAG_PREMIUM premium2)
        {
            object[] objArray1 = new object[] { premium1, premium2 };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "CardPremiumSortComparisonDesc", objArray1);
        }

        public static long CardUID(int cardDbId, TAG_PREMIUM premium)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cardDbId, premium };
            return MonoClass.smethod_11<long>(TritonHs.MainAssemblyPath, "", "GameUtils", "CardUID", enumArray1, objArray1);
        }

        public static long CardUID(string cardStringId, TAG_PREMIUM premium)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cardStringId, premium };
            return MonoClass.smethod_11<long>(TritonHs.MainAssemblyPath, "", "GameUtils", "CardUID", enumArray1, objArray1);
        }

        public static long ClientCardUID(int cardDbId, TAG_PREMIUM premium, bool owned)
        {
            object[] objArray1 = new object[] { cardDbId, premium, owned };
            return MonoClass.smethod_11<long>(TritonHs.MainAssemblyPath, "", "GameUtils", "ClientCardUID", new Class272.Enum20[] { Class272.Enum20.I4 }, objArray1);
        }

        public static long ClientCardUID(string cardStringId, TAG_PREMIUM premium, bool owned)
        {
            object[] objArray1 = new object[] { cardStringId, premium, owned };
            return MonoClass.smethod_11<long>(TritonHs.MainAssemblyPath, "", "GameUtils", "ClientCardUID", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public static int CountAllCollectibleCards()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "CountAllCollectibleCards", Array.Empty<object>());
        }

        public static int CountNonHeroCollectibleCards()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "CountNonHeroCollectibleCards", Array.Empty<object>());
        }

        public static void DoDamageTasks(PowerTaskList powerTaskList, Card sourceCard, Card targetCard)
        {
            object[] objArray1 = new object[] { powerTaskList, sourceCard, targetCard };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "GameUtils", "DoDamageTasks", objArray1);
        }

        public static AdventureDataDbfRecord GetAdventureDataRecord(int adventureId, int modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            return MonoClass.smethod_15<AdventureDataDbfRecord>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetAdventureDataRecord", objArray1);
        }

        public static List<AdventureDataDbfRecord> GetAdventureDataRecordsWithSubDefPrefab()
        {
            Class267<AdventureDataDbfRecord> class2 = MonoClass.smethod_15<Class267<AdventureDataDbfRecord>>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetAdventureDataRecordsWithSubDefPrefab", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static AdventureDbId GetAdventureId(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_14<AdventureDbId>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetAdventureId", objArray1);
        }

        public static AdventureModeDbId GetAdventureModeId(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_14<AdventureModeDbId>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetAdventureModeId", objArray1);
        }

        public static AdventureDbfRecord GetAdventureRecord(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_15<AdventureDbfRecord>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetAdventureRecord", objArray1);
        }

        public static List<AdventureDbfRecord> GetAdventureRecordsWithDefPrefab()
        {
            Class267<AdventureDbfRecord> class2 = MonoClass.smethod_15<Class267<AdventureDbfRecord>>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetAdventureRecordsWithDefPrefab", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<AdventureDbfRecord> GetAdventureRecordsWithStorePrefab()
        {
            Class267<AdventureDbfRecord> class2 = MonoClass.smethod_15<Class267<AdventureDbfRecord>>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetAdventureRecordsWithStorePrefab", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<string> GetAllCardIds()
        {
            Class268 class2 = MonoClass.smethod_15<Class268>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetAllCardIds", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<int> GetAllCollectibleCardDbIds()
        {
            Class266<int> class2 = MonoClass.smethod_15<Class266<int>>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetAllCollectibleCardDbIds", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<string> GetAllCollectibleCardIds()
        {
            Class268 class2 = MonoClass.smethod_15<Class268>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetAllCollectibleCardIds", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static string GetBasicHeroCardIdFromClass(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameUtils", "GetBasicHeroCardIdFromClass", objArray1);
        }

        public static int GetBoardIdFromAssetName(string name)
        {
            object[] objArray1 = new object[] { name };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetBoardIdFromAssetName", objArray1);
        }

        public static int GetBoosterCount()
        {
            return MonoClass.smethod_11<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetBoosterCount", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static int GetBoosterCount(int boosterStackId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { boosterStackId };
            return MonoClass.smethod_11<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetBoosterCount", enumArray1, objArray1);
        }

        public static CardDbfRecord GetCardRecord(int dbId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { dbId };
            return MonoClass.smethod_16<CardDbfRecord>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetCardRecord", enumArray1, objArray1);
        }

        public static CardDbfRecord GetCardRecord(string cardId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { cardId };
            return MonoClass.smethod_16<CardDbfRecord>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetCardRecord", enumArray1, objArray1);
        }

        public static TAG_CARD_SET GetCardSetFromCardID(string cardID)
        {
            object[] objArray1 = new object[] { cardID };
            return MonoClass.smethod_14<TAG_CARD_SET>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetCardSetFromCardID", objArray1);
        }

        public static TAG_CLASS GetClassChallengeHeroClass(ScenarioDbfRecord rec)
        {
            object[] objArray1 = new object[] { rec };
            return MonoClass.smethod_14<TAG_CLASS>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetClassChallengeHeroClass", objArray1);
        }

        public static List<TAG_CLASS> GetClassChallengeHeroClasses(int adventureId, int wingId)
        {
            object[] objArray1 = new object[] { adventureId, wingId };
            Class266<TAG_CLASS> class2 = MonoClass.smethod_15<Class266<TAG_CLASS>>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetClassChallengeHeroClasses", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<ScenarioDbfRecord> GetClassChallengeRecords(int adventureId, int wingId)
        {
            object[] objArray1 = new object[] { adventureId, wingId };
            Class267<ScenarioDbfRecord> class2 = MonoClass.smethod_15<Class267<ScenarioDbfRecord>>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetClassChallengeRecords", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static string GetCurrentTutorialCardRewardDetails()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameUtils", "GetCurrentTutorialCardRewardDetails", Array.Empty<object>());
        }

        public static int GetFakePackCount()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetFakePackCount", Array.Empty<object>());
        }

        public static TAG_ZONE GetFinalZoneForEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return MonoClass.smethod_14<TAG_ZONE>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetFinalZoneForEntity", objArray1);
        }

        public static List<FixedRewardActionDbfRecord> GetFixedActionRecords(FixedActionType actionType)
        {
            object[] objArray1 = new object[] { actionType };
            Class267<FixedRewardActionDbfRecord> class2 = MonoClass.smethod_15<Class267<FixedRewardActionDbfRecord>>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetFixedActionRecords", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static FixedRewardDbfRecord GetFixedRewardForCard(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return MonoClass.smethod_15<FixedRewardDbfRecord>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetFixedRewardForCard", objArray1);
        }

        public static List<FixedRewardMapDbfRecord> GetFixedRewardMapRecordsForAction(int actionID)
        {
            object[] objArray1 = new object[] { actionID };
            Class267<FixedRewardMapDbfRecord> class2 = MonoClass.smethod_15<Class267<FixedRewardMapDbfRecord>>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetFixedRewardMapRecordsForAction", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static NetCache.HeroLevel GetHeroLevel(TAG_CLASS heroClass)
        {
            object[] objArray1 = new object[] { heroClass };
            return MonoClass.smethod_15<NetCache.HeroLevel>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetHeroLevel", objArray1);
        }

        public static string GetHeroPowerCardIdFromHero(int heroDbId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { heroDbId };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "GameUtils", "GetHeroPowerCardIdFromHero", enumArray1, objArray1);
        }

        public static string GetHeroPowerCardIdFromHero(string heroCardId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { heroCardId };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "GameUtils", "GetHeroPowerCardIdFromHero", enumArray1, objArray1);
        }

        public static Card GetJoustWinner(Network.HistMetaData metaData)
        {
            object[] objArray1 = new object[] { metaData };
            return MonoClass.smethod_15<Card>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetJoustWinner", objArray1);
        }

        public static string GetMissionHeroCardId(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameUtils", "GetMissionHeroCardId", objArray1);
        }

        public static string GetMissionHeroName(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameUtils", "GetMissionHeroName", objArray1);
        }

        public static string GetMissionHeroPowerCardId(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameUtils", "GetMissionHeroPowerCardId", objArray1);
        }

        public static int GetNextTutorial()
        {
            return MonoClass.smethod_11<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetNextTutorial", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static int GetNextTutorial(TutorialProgress progress)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { progress };
            return MonoClass.smethod_11<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetNextTutorial", enumArray1, objArray1);
        }

        public static List<string> GetNonHeroAllCardIds()
        {
            Class268 class2 = MonoClass.smethod_15<Class268>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetNonHeroAllCardIds", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<string> GetNonHeroCollectibleCardIds()
        {
            Class268 class2 = MonoClass.smethod_15<Class268>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetNonHeroCollectibleCardIds", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static PackOpeningRarity GetPackOpeningRarity(TAG_RARITY tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<PackOpeningRarity>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetPackOpeningRarity", objArray1);
        }

        public static List<BoosterDbfRecord> GetPackRecordsWithStorePrefab()
        {
            Class267<BoosterDbfRecord> class2 = MonoClass.smethod_15<Class267<BoosterDbfRecord>>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetPackRecordsWithStorePrefab", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<int> GetSortedPackIds()
        {
            Class266<int> class2 = MonoClass.smethod_15<Class266<int>>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetSortedPackIds", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static string GetTutorialCardRewardDetails(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameUtils", "GetTutorialCardRewardDetails", objArray1);
        }

        public static WingDbfRecord GetWingRecord(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_15<WingDbfRecord>(TritonHs.MainAssemblyPath, "", "GameUtils", "GetWingRecord", objArray1);
        }

        public static bool HaveBoosters()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "HaveBoosters", Array.Empty<object>());
        }

        public static UnityObject Instantiate(object original)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { original };
            return MonoClass.smethod_16<UnityObject>(TritonHs.MainAssemblyPath, "", "GameUtils", "Instantiate", enumArray1, objArray1);
        }

        public static UnityObject Instantiate(Component original, GameObject parent, bool withRotation)
        {
            object[] objArray1 = new object[] { original, parent, withRotation };
            return MonoClass.smethod_16<UnityObject>(TritonHs.MainAssemblyPath, "", "GameUtils", "Instantiate", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static UnityObject Instantiate(GameObject original, GameObject parent, bool withRotation)
        {
            object[] objArray1 = new object[] { original, parent, withRotation };
            return MonoClass.smethod_16<UnityObject>(TritonHs.MainAssemblyPath, "", "GameUtils", "Instantiate", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static UnityObject InstantiateGameObject(string name, GameObject parent, bool withRotation)
        {
            object[] objArray1 = new object[] { name, parent, withRotation };
            return MonoClass.smethod_15<UnityObject>(TritonHs.MainAssemblyPath, "", "GameUtils", "InstantiateGameObject", objArray1);
        }

        public static bool IsAIMission(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsAIMission", objArray1);
        }

        public static bool IsAnyTransitionActive()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsAnyTransitionActive", Array.Empty<object>());
        }

        public static bool IsBeginPhase(TAG_STEP step)
        {
            object[] objArray1 = new object[] { step };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsBeginPhase", objArray1);
        }

        public static bool IsCardCollectible(string cardId)
        {
            object[] objArray1 = new object[] { cardId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsCardCollectible", objArray1);
        }

        public static bool IsCharacterDeathTagChange(Network.HistTagChange tagChange)
        {
            object[] objArray1 = new object[] { tagChange };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsCharacterDeathTagChange", objArray1);
        }

        public static bool IsClassChallengeMission(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsClassChallengeMission", objArray1);
        }

        public static bool IsClassicMission(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsClassicMission", objArray1);
        }

        public static bool IsCoopMission(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsCoopMission", objArray1);
        }

        public static bool IsEntityHiddenAfterCurrentTasklist(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsEntityHiddenAfterCurrentTasklist", objArray1);
        }

        public static bool IsExpansionAdventure(AdventureDbId adventureId)
        {
            object[] objArray1 = new object[] { adventureId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsExpansionAdventure", objArray1);
        }

        public static bool IsExpansionMission(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsExpansionMission", objArray1);
        }

        public static bool IsFakePackOpeningEnabled()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsFakePackOpeningEnabled", Array.Empty<object>());
        }

        public static bool IsFriendlyConcede(Network.HistTagChange tagChange)
        {
            object[] objArray1 = new object[] { tagChange };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsFriendlyConcede", objArray1);
        }

        public static bool IsGameOverTag(int entityId, int tag, int val)
        {
            object[] objArray1 = new object[] { entityId, tag, val };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsGameOverTag", new Class272.Enum20[] { Class272.Enum20.I4 }, objArray1);
        }

        public static bool IsGameOverTag(Player player, int tag, int val)
        {
            object[] objArray1 = new object[] { player, tag, val };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsGameOverTag", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static bool IsHeroicAdventureMission(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsHeroicAdventureMission", objArray1);
        }

        public static bool IsHistoryDeathTagChange(Network.HistTagChange tagChange)
        {
            object[] objArray1 = new object[] { tagChange };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsHistoryDeathTagChange", objArray1);
        }

        public static bool IsMainPhase(TAG_STEP step)
        {
            object[] objArray1 = new object[] { step };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsMainPhase", objArray1);
        }

        public static bool IsMatchmadeGameType(GameType gameType)
        {
            object[] objArray1 = new object[] { gameType };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsMatchmadeGameType", objArray1);
        }

        public static bool IsMissionForAdventure(int missionId, int adventureId)
        {
            object[] objArray1 = new object[] { missionId, adventureId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsMissionForAdventure", objArray1);
        }

        public static bool IsPastBeginPhase(TAG_STEP step)
        {
            object[] objArray1 = new object[] { step };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsPastBeginPhase", objArray1);
        }

        public static bool IsPracticeMission(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsPracticeMission", objArray1);
        }

        public static bool IsTutorialMission(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsTutorialMission", objArray1);
        }

        public static bool IsWingComplete(int advId, int modeId, int wingId)
        {
            object[] objArray1 = new object[] { advId, modeId, wingId };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "IsWingComplete", objArray1);
        }

        public static void LogoutConfirmation()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "GameUtils", "LogoutConfirmation");
        }

        public static int MissionSortComparison(ScenarioDbfRecord rec1, ScenarioDbfRecord rec2)
        {
            object[] objArray1 = new object[] { rec1, rec2 };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "MissionSortComparison", objArray1);
        }

        public static void OnLogoutConfirmationResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "GameUtils", "OnLogoutConfirmationResponse", objArray1);
        }

        public static int PackSortComparison(int id1, int id2)
        {
            object[] objArray1 = new object[] { id1, id2 };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "PackSortComparison", objArray1);
        }

        public static void PlayCardEffectDefSounds(CardEffectDef cardEffectDef)
        {
            object[] objArray1 = new object[] { cardEffectDef };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "GameUtils", "PlayCardEffectDefSounds", objArray1);
        }

        public static void ResetTransform(Component comp)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { comp };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "GameUtils", "ResetTransform", enumArray1, objArray1);
        }

        public static void ResetTransform(GameObject obj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { obj };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "GameUtils", "ResetTransform", enumArray1, objArray1);
        }

        public static void SetParent(Component child, Component parent, bool withRotation)
        {
            object[] objArray1 = new object[] { child, parent, withRotation };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "GameUtils", "SetParent", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetParent(Component child, GameObject parent, bool withRotation)
        {
            object[] objArray1 = new object[] { child, parent, withRotation };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "GameUtils", "SetParent", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetParent(GameObject child, Component parent, bool withRotation)
        {
            object[] objArray1 = new object[] { child, parent, withRotation };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "GameUtils", "SetParent", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetParent(GameObject child, GameObject parent, bool withRotation)
        {
            object[] objArray1 = new object[] { child, parent, withRotation };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "GameUtils", "SetParent", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetParent(Transform child, Transform parent, bool withRotation)
        {
            object[] objArray1 = new object[] { child, parent, withRotation };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "GameUtils", "SetParent", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static bool ShouldShowRankedMedals()
        {
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "ShouldShowRankedMedals", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static bool ShouldShowRankedMedals(GameType gameType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { gameType };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "GameUtils", "ShouldShowRankedMedals", enumArray1, objArray1);
        }

        public static int TranslateCardIdToDbId(string cardId)
        {
            object[] objArray1 = new object[] { cardId };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameUtils", "TranslateCardIdToDbId", objArray1);
        }

        public static string TranslateDbIdToCardId(int dbId)
        {
            object[] objArray1 = new object[] { dbId };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameUtils", "TranslateDbIdToCardId", objArray1);
        }
    }
}

