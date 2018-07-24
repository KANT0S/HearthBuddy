namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("NetCache")]
    public class NetCache : MonoClass
    {
        public NetCache(IntPtr address) : this(address, "NetCache")
        {
        }

        public NetCache(IntPtr address, string className) : base(address, className)
        {
        }

        public void CheckSeasonForRoll()
        {
            base.method_8("CheckSeasonForRoll", Array.Empty<object>());
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public bool ClientOptionExists(ServerOption type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_11<bool>("ClientOptionExists", objArray1);
        }

        public static void DefaultErrorHandler(ErrorInfo info)
        {
            object[] objArray1 = new object[] { info };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "NetCache", "DefaultErrorHandler", objArray1);
        }

        public void DeleteClientOption(ServerOption type)
        {
            object[] objArray1 = new object[] { type };
            base.method_8("DeleteClientOption", objArray1);
        }

        public static NetCache Get()
        {
            return MonoClass.smethod_15<NetCache>(TritonHs.MainAssemblyPath, "", "NetCache", "Get", Array.Empty<object>());
        }

        public bool GetBoolOption(ServerOption type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { type };
            return base.method_10<bool>("GetBoolOption", enumArray1, objArray1);
        }

        public float GetFloatOption(ServerOption type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { type };
            return base.method_10<float>("GetFloatOption", enumArray1, objArray1);
        }

        public static string GetInternalErrorMessage(ErrorInfo info, bool includeStackTrace)
        {
            object[] objArray1 = new object[] { info, includeStackTrace };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "NetCache", "GetInternalErrorMessage", objArray1);
        }

        public int GetIntOption(ServerOption type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { type };
            return base.method_10<int>("GetIntOption", enumArray1, objArray1);
        }

        public long GetLongOption(ServerOption type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { type };
            return base.method_10<long>("GetLongOption", enumArray1, objArray1);
        }

        public object GetTestData(System.Type type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_14<object>("GetTestData", objArray1);
        }

        public ulong GetULongOption(ServerOption type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { type };
            return base.method_10<ulong>("GetULongOption", enumArray1, objArray1);
        }

        public void Heartbeat()
        {
            base.method_8("Heartbeat", Array.Empty<object>());
        }

        public void InitNetCache()
        {
            base.method_8("InitNetCache", Array.Empty<object>());
        }

        public void NetCacheCheckRequest(NetCacheBatchRequest request)
        {
            object[] objArray1 = new object[] { request };
            base.method_8("NetCacheCheckRequest", objArray1);
        }

        public void NetCacheMakeBatchRequest(NetCacheBatchRequest batchRequest)
        {
            object[] objArray1 = new object[] { batchRequest };
            base.method_8("NetCacheMakeBatchRequest", objArray1);
        }

        public void NetCacheReload_Internal(NetCacheBatchRequest request, System.Type type)
        {
            object[] objArray1 = new object[] { request, type };
            base.method_8("NetCacheReload_Internal", objArray1);
        }

        public void NetCacheRequestReload(System.Type type)
        {
            object[] objArray1 = new object[] { type };
            base.method_8("NetCacheRequestReload", objArray1);
        }

        public void NetCacheUse_Internal(NetCacheBatchRequest request, System.Type type)
        {
            object[] objArray1 = new object[] { request, type };
            base.method_8("NetCacheUse_Internal", objArray1);
        }

        public void OnAccountLicensesInfoResponse()
        {
            base.method_8("OnAccountLicensesInfoResponse", Array.Empty<object>());
        }

        public void OnAllHeroXP()
        {
            base.method_8("OnAllHeroXP", Array.Empty<object>());
        }

        public void OnArcaneDustBalance()
        {
            base.method_8("OnArcaneDustBalance", Array.Empty<object>());
        }

        public void OnArcaneDustBalanceChanged(long balanceChange)
        {
            object[] objArray1 = new object[] { balanceChange };
            base.method_8("OnArcaneDustBalanceChanged", objArray1);
        }

        public void OnBoosters()
        {
            base.method_8("OnBoosters", Array.Empty<object>());
        }

        public void OnCardBacks()
        {
            base.method_8("OnCardBacks", Array.Empty<object>());
        }

        public void OnCardValues()
        {
            base.method_8("OnCardValues", Array.Empty<object>());
        }

        public void OnClientOptions()
        {
            base.method_8("OnClientOptions", Array.Empty<object>());
        }

        public void OnCollection()
        {
            base.method_8("OnCollection", Array.Empty<object>());
        }

        public void OnDBAction()
        {
            base.method_8("OnDBAction", Array.Empty<object>());
        }

        public void OnDecks()
        {
            base.method_8("OnDecks", Array.Empty<object>());
        }

        public void OnFavoriteHeroesResponse()
        {
            base.method_8("OnFavoriteHeroesResponse", Array.Empty<object>());
        }

        public void OnFeaturesChanged()
        {
            base.method_8("OnFeaturesChanged", Array.Empty<object>());
        }

        public void OnGamesInfo()
        {
            base.method_8("OnGamesInfo", Array.Empty<object>());
        }

        public void OnGenericResponse()
        {
            base.method_8("OnGenericResponse", Array.Empty<object>());
        }

        public void OnGoldBalance()
        {
            base.method_8("OnGoldBalance", Array.Empty<object>());
        }

        public void OnHearthstoneUnavailable(bool gamePacket)
        {
            object[] objArray1 = new object[] { gamePacket };
            base.method_8("OnHearthstoneUnavailable", objArray1);
        }

        public void OnHearthstoneUnavailableGame()
        {
            base.method_8("OnHearthstoneUnavailableGame", Array.Empty<object>());
        }

        public void OnHearthstoneUnavailableUtil()
        {
            base.method_8("OnHearthstoneUnavailableUtil", Array.Empty<object>());
        }

        public void OnLastGameInfo()
        {
            base.method_8("OnLastGameInfo", Array.Empty<object>());
        }

        public void OnMedalHistory()
        {
            base.method_8("OnMedalHistory", Array.Empty<object>());
        }

        public void OnMedalInfo()
        {
            base.method_8("OnMedalInfo", Array.Empty<object>());
        }

        public void OnNotSoMassiveLoginReply()
        {
            base.method_8("OnNotSoMassiveLoginReply", Array.Empty<object>());
        }

        public void OnPacketThrottled(int packetID, long retryMillis)
        {
            object[] objArray1 = new object[] { packetID, retryMillis };
            base.method_8("OnPacketThrottled", objArray1);
        }

        public void OnPlayerRecords()
        {
            base.method_8("OnPlayerRecords", Array.Empty<object>());
        }

        public void OnPlayQueue()
        {
            base.method_8("OnPlayQueue", Array.Empty<object>());
        }

        public void OnProfileNotices()
        {
            base.method_8("OnProfileNotices", Array.Empty<object>());
        }

        public void OnProfileProgress()
        {
            base.method_8("OnProfileProgress", Array.Empty<object>());
        }

        public void OnRewardProgress()
        {
            base.method_8("OnRewardProgress", Array.Empty<object>());
        }

        public void OnTavernBrawlInfoResponse()
        {
            base.method_8("OnTavernBrawlInfoResponse", Array.Empty<object>());
        }

        public void OnTavernBrawlRecordResponse()
        {
            base.method_8("OnTavernBrawlRecordResponse", Array.Empty<object>());
        }

        public void RegisterNetCacheHandlers()
        {
            base.method_8("RegisterNetCacheHandlers", Array.Empty<object>());
        }

        public bool RemoveNotice(long ID)
        {
            object[] objArray1 = new object[] { ID };
            return base.method_11<bool>("RemoveNotice", objArray1);
        }

        public void RequestNetCacheObject(System.Type type)
        {
            object[] objArray1 = new object[] { type };
            base.method_8("RequestNetCacheObject", objArray1);
        }

        public void SetBoolOption(ServerOption type, bool val)
        {
            object[] objArray1 = new object[] { type, val };
            base.method_8("SetBoolOption", objArray1);
        }

        public void SetClientOption(ServerOption type, ClientOptionBase newVal)
        {
            object[] objArray1 = new object[] { type, newVal };
            base.method_8("SetClientOption", objArray1);
        }

        public void SetFloatOption(ServerOption type, float val)
        {
            object[] objArray1 = new object[] { type, val };
            base.method_8("SetFloatOption", objArray1);
        }

        public void SetIntOption(ServerOption type, int val)
        {
            object[] objArray1 = new object[] { type, val };
            base.method_8("SetIntOption", objArray1);
        }

        public void SetLongOption(ServerOption type, long val)
        {
            object[] objArray1 = new object[] { type, val };
            base.method_8("SetLongOption", objArray1);
        }

        public void SetULongOption(ServerOption type, ulong val)
        {
            object[] objArray1 = new object[] { type, val };
            base.method_8("SetULongOption", objArray1);
        }

        public void UpdateRequestNeedState(System.Type type, RequestResult result)
        {
            object[] objArray1 = new object[] { type, result };
            base.method_8("UpdateRequestNeedState", objArray1);
        }

        public List<NetCacheBatchRequest> m_cacheRequests
        {
            get
            {
                Class267<NetCacheBatchRequest> class2 = base.method_3<Class267<NetCacheBatchRequest>>("m_cacheRequests");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static bool m_fatalErrorCodeSet
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "NetCache", "m_fatalErrorCodeSet");
            }
        }

        public List<System.Type> m_inTransitRequests
        {
            get
            {
                Class267<System.Type> class2 = base.method_3<Class267<System.Type>>("m_inTransitRequests");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public long m_lastForceCheckedSeason
        {
            get
            {
                return base.method_2<long>("m_lastForceCheckedSeason");
            }
        }

        public NetCacheHeroLevels m_prevHeroLevels
        {
            get
            {
                return base.method_3<NetCacheHeroLevels>("m_prevHeroLevels");
            }
        }

        public NetCacheMedalInfo m_previousMedalInfo
        {
            get
            {
                return base.method_3<NetCacheMedalInfo>("m_previousMedalInfo");
            }
        }

        [Attribute38("NetCache.BoosterCard")]
        public class BoosterCard : MonoClass
        {
            public BoosterCard(IntPtr address) : this(address, "BoosterCard")
            {
            }

            public BoosterCard(IntPtr address, string className) : base(address, className)
            {
            }

            public long Date
            {
                get
                {
                    return base.method_11<long>("get_Date", Array.Empty<object>());
                }
            }

            public NetCache.CardDefinition Def
            {
                get
                {
                    return base.method_14<NetCache.CardDefinition>("get_Def", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.BoosterStack")]
        public class BoosterStack : MonoClass
        {
            public BoosterStack(IntPtr address) : this(address, "BoosterStack")
            {
            }

            public BoosterStack(IntPtr address, string className) : base(address, className)
            {
            }

            public int Count
            {
                get
                {
                    return base.method_11<int>("get_Count", Array.Empty<object>());
                }
            }

            public int Id
            {
                get
                {
                    return base.method_11<int>("get_Id", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.CardDefinition")]
        public class CardDefinition : MonoClass
        {
            public CardDefinition(IntPtr address) : this(address, "CardDefinition")
            {
            }

            public CardDefinition(IntPtr address, string className) : base(address, className)
            {
            }

            public bool Equals(object obj)
            {
                object[] objArray1 = new object[] { obj };
                return base.method_11<bool>("Equals", objArray1);
            }

            public int GetHashCode()
            {
                return base.method_11<int>("GetHashCode", Array.Empty<object>());
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public string Name
            {
                get
                {
                    return base.method_13("get_Name", Array.Empty<object>());
                }
            }

            public TAG_PREMIUM Premium
            {
                get
                {
                    return base.method_11<TAG_PREMIUM>("get_Premium", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.CardStack")]
        public class CardStack : MonoClass
        {
            public CardStack(IntPtr address) : this(address, "CardStack")
            {
            }

            public CardStack(IntPtr address, string className) : base(address, className)
            {
            }

            public int Count
            {
                get
                {
                    return base.method_11<int>("get_Count", Array.Empty<object>());
                }
            }

            public long Date
            {
                get
                {
                    return base.method_11<long>("get_Date", Array.Empty<object>());
                }
            }

            public NetCache.CardDefinition Def
            {
                get
                {
                    return base.method_14<NetCache.CardDefinition>("get_Def", Array.Empty<object>());
                }
            }

            public int NumSeen
            {
                get
                {
                    return base.method_11<int>("get_NumSeen", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.CardValue")]
        public class CardValue : MonoClass
        {
            public CardValue(IntPtr address) : this(address, "CardValue")
            {
            }

            public CardValue(IntPtr address, string className) : base(address, className)
            {
            }

            public int Buy
            {
                get
                {
                    return base.method_11<int>("get_Buy", Array.Empty<object>());
                }
            }

            public bool Nerfed
            {
                get
                {
                    return base.method_11<bool>("get_Nerfed", Array.Empty<object>());
                }
            }

            public int Sell
            {
                get
                {
                    return base.method_11<int>("get_Sell", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ClientOptionBase")]
        public class ClientOptionBase : MonoClass
        {
            public ClientOptionBase(IntPtr address) : this(address, "ClientOptionBase")
            {
            }

            public ClientOptionBase(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("NetCache.ClientOptionBool")]
        public class ClientOptionBool : NetCache.ClientOptionBase
        {
            public ClientOptionBool(IntPtr address) : this(address, "ClientOptionBool")
            {
            }

            public ClientOptionBool(IntPtr address, string className) : base(address, className)
            {
            }

            public bool OptionValue
            {
                get
                {
                    return base.method_11<bool>("get_OptionValue", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ClientOptionFloat")]
        public class ClientOptionFloat : NetCache.ClientOptionBase
        {
            public ClientOptionFloat(IntPtr address) : this(address, "ClientOptionFloat")
            {
            }

            public ClientOptionFloat(IntPtr address, string className) : base(address, className)
            {
            }

            public float OptionValue
            {
                get
                {
                    return base.method_11<float>("get_OptionValue", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ClientOptionInt")]
        public class ClientOptionInt : NetCache.ClientOptionBase
        {
            public ClientOptionInt(IntPtr address) : this(address, "ClientOptionInt")
            {
            }

            public ClientOptionInt(IntPtr address, string className) : base(address, className)
            {
            }

            public int OptionValue
            {
                get
                {
                    return base.method_11<int>("get_OptionValue", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ClientOptionLong")]
        public class ClientOptionLong : NetCache.ClientOptionBase
        {
            public ClientOptionLong(IntPtr address) : this(address, "ClientOptionLong")
            {
            }

            public ClientOptionLong(IntPtr address, string className) : base(address, className)
            {
            }

            public long OptionValue
            {
                get
                {
                    return base.method_11<long>("get_OptionValue", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ClientOptionULong")]
        public class ClientOptionULong : NetCache.ClientOptionBase
        {
            public ClientOptionULong(IntPtr address) : this(address, "ClientOptionULong")
            {
            }

            public ClientOptionULong(IntPtr address, string className) : base(address, className)
            {
            }

            public ulong OptionValue
            {
                get
                {
                    return base.method_11<ulong>("get_OptionValue", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.DeckHeader")]
        public class DeckHeader : MonoClass
        {
            public DeckHeader(IntPtr address) : this(address, "DeckHeader")
            {
            }

            public DeckHeader(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public int CardBack
            {
                get
                {
                    return base.method_11<int>("get_CardBack", Array.Empty<object>());
                }
            }

            public bool CardBackOverridden
            {
                get
                {
                    return base.method_11<bool>("get_CardBackOverridden", Array.Empty<object>());
                }
            }

            public string Hero
            {
                get
                {
                    return base.method_13("get_Hero", Array.Empty<object>());
                }
            }

            public bool HeroOverridden
            {
                get
                {
                    return base.method_11<bool>("get_HeroOverridden", Array.Empty<object>());
                }
            }

            public string HeroPower
            {
                get
                {
                    return base.method_13("get_HeroPower", Array.Empty<object>());
                }
            }

            public TAG_PREMIUM HeroPremium
            {
                get
                {
                    return base.method_11<TAG_PREMIUM>("get_HeroPremium", Array.Empty<object>());
                }
            }

            public long ID
            {
                get
                {
                    return base.method_11<long>("get_ID", Array.Empty<object>());
                }
            }

            public bool IsTourneyValid
            {
                get
                {
                    return base.method_11<bool>("get_IsTourneyValid", Array.Empty<object>());
                }
            }

            public string Name
            {
                get
                {
                    return base.method_13("get_Name", Array.Empty<object>());
                }
            }

            public bool NeedsName
            {
                get
                {
                    return base.method_11<bool>("get_NeedsName", Array.Empty<object>());
                }
            }

            public int SeasonId
            {
                get
                {
                    return base.method_11<int>("get_SeasonId", Array.Empty<object>());
                }
            }

            public long SortOrder
            {
                get
                {
                    return base.method_11<long>("get_SortOrder", Array.Empty<object>());
                }
            }

            public DeckType Type
            {
                get
                {
                    return base.method_11<DeckType>("get_Type", Array.Empty<object>());
                }
            }
        }

        public enum ErrorCode
        {
            NONE,
            TIMEOUT,
            SERVER
        }

        [Attribute38("NetCache.ErrorInfo")]
        public class ErrorInfo : MonoClass
        {
            public ErrorInfo(IntPtr address) : this(address, "ErrorInfo")
            {
            }

            public ErrorInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public NetCache.ErrorCode Error
            {
                get
                {
                    return base.method_11<NetCache.ErrorCode>("get_Error", Array.Empty<object>());
                }
            }

            public string RequestStackTrace
            {
                get
                {
                    return base.method_13("get_RequestStackTrace", Array.Empty<object>());
                }
            }

            public uint ServerError
            {
                get
                {
                    return base.method_11<uint>("get_ServerError", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.HeroLevel")]
        public class HeroLevel : MonoClass
        {
            public HeroLevel(IntPtr address) : this(address, "HeroLevel")
            {
            }

            public HeroLevel(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public TAG_CLASS Class
            {
                get
                {
                    return base.method_11<TAG_CLASS>("get_Class", Array.Empty<object>());
                }
            }

            public LevelInfo CurrentLevel
            {
                get
                {
                    return base.method_14<LevelInfo>("get_CurrentLevel", Array.Empty<object>());
                }
            }

            public NextLevelReward NextReward
            {
                get
                {
                    return base.method_14<NextLevelReward>("get_NextReward", Array.Empty<object>());
                }
            }

            public LevelInfo PrevLevel
            {
                get
                {
                    return base.method_14<LevelInfo>("get_PrevLevel", Array.Empty<object>());
                }
            }

            [Attribute38("NetCache.HeroLevel.LevelInfo")]
            public class LevelInfo : MonoClass
            {
                public LevelInfo(IntPtr address) : this(address, "LevelInfo")
                {
                }

                public LevelInfo(IntPtr address, string className) : base(address, className)
                {
                }

                public bool IsMaxLevel()
                {
                    return base.method_11<bool>("IsMaxLevel", Array.Empty<object>());
                }

                public string ToString()
                {
                    return base.method_13("ToString", Array.Empty<object>());
                }

                public int Level
                {
                    get
                    {
                        return base.method_11<int>("get_Level", Array.Empty<object>());
                    }
                }

                public int MaxLevel
                {
                    get
                    {
                        return base.method_11<int>("get_MaxLevel", Array.Empty<object>());
                    }
                }

                public long MaxXP
                {
                    get
                    {
                        return base.method_11<long>("get_MaxXP", Array.Empty<object>());
                    }
                }

                public long XP
                {
                    get
                    {
                        return base.method_11<long>("get_XP", Array.Empty<object>());
                    }
                }
            }

            [Attribute38("NetCache.HeroLevel.NextLevelReward")]
            public class NextLevelReward : MonoClass
            {
                public NextLevelReward(IntPtr address) : this(address, "NextLevelReward")
                {
                }

                public NextLevelReward(IntPtr address, string className) : base(address, className)
                {
                }

                public string ToString()
                {
                    return base.method_13("ToString", Array.Empty<object>());
                }

                public int Level
                {
                    get
                    {
                        return base.method_11<int>("get_Level", Array.Empty<object>());
                    }
                }

                public RewardData Reward
                {
                    get
                    {
                        return base.method_14<RewardData>("get_Reward", Array.Empty<object>());
                    }
                }
            }
        }

        [Attribute38("NetCache.MedalHistory")]
        public class MedalHistory : MonoClass
        {
            public MedalHistory(IntPtr address) : this(address, "MedalHistory")
            {
            }

            public MedalHistory(IntPtr address, string className) : base(address, className)
            {
            }

            public long Date
            {
                get
                {
                    return base.method_11<long>("get_Date", Array.Empty<object>());
                }
            }

            public int LegendRank
            {
                get
                {
                    return base.method_11<int>("get_LegendRank", Array.Empty<object>());
                }
            }

            public int Season
            {
                get
                {
                    return base.method_11<int>("get_Season", Array.Empty<object>());
                }
            }

            public int StarLevel
            {
                get
                {
                    return base.method_11<int>("get_StarLevel", Array.Empty<object>());
                }
            }

            public int Stars
            {
                get
                {
                    return base.method_11<int>("get_Stars", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.NetCacheAccountLicenses")]
        public class NetCacheAccountLicenses : MonoClass
        {
            public NetCacheAccountLicenses(IntPtr address) : this(address, "NetCacheAccountLicenses")
            {
            }

            public NetCacheAccountLicenses(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("NetCache.NetCacheArcaneDustBalance")]
        public class NetCacheArcaneDustBalance : MonoClass
        {
            public NetCacheArcaneDustBalance(IntPtr address) : this(address, "NetCacheArcaneDustBalance")
            {
            }

            public NetCacheArcaneDustBalance(IntPtr address, string className) : base(address, className)
            {
            }

            public long Balance
            {
                get
                {
                    return base.method_11<long>("get_Balance", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.NetCacheBatchRequest")]
        public class NetCacheBatchRequest : MonoClass
        {
            public NetCacheBatchRequest(IntPtr address) : this(address, "NetCacheBatchRequest")
            {
            }

            public NetCacheBatchRequest(IntPtr address, string className) : base(address, className)
            {
            }

            public void AddRequest(NetCache.Request r)
            {
                object[] objArray1 = new object[] { r };
                base.method_8("AddRequest", objArray1);
            }

            public bool m_canTimeout
            {
                get
                {
                    return base.method_2<bool>("m_canTimeout");
                }
            }

            public string m_requestStackTrace
            {
                get
                {
                    return base.method_4("m_requestStackTrace");
                }
            }

            public DateTime m_timeAdded
            {
                get
                {
                    return base.method_2<DateTime>("m_timeAdded");
                }
            }
        }

        [Attribute38("NetCache.NetCacheBoosters")]
        public class NetCacheBoosters : MonoClass
        {
            public NetCacheBoosters(IntPtr address) : this(address, "NetCacheBoosters")
            {
            }

            public NetCacheBoosters(IntPtr address, string className) : base(address, className)
            {
            }

            public NetCache.BoosterStack GetBoosterStack(int id)
            {
                object[] objArray1 = new object[] { id };
                return base.method_14<NetCache.BoosterStack>("GetBoosterStack", objArray1);
            }

            public int GetTotalNumBoosters()
            {
                return base.method_11<int>("GetTotalNumBoosters", Array.Empty<object>());
            }

            public List<NetCache.BoosterStack> BoosterStacks
            {
                get
                {
                    Class267<NetCache.BoosterStack> class2 = base.method_14<Class267<NetCache.BoosterStack>>("get_BoosterStacks", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        [Attribute38("NetCache.NetCacheCardBacks")]
        public class NetCacheCardBacks : MonoClass
        {
            public NetCacheCardBacks(IntPtr address) : this(address, "NetCacheCardBacks")
            {
            }

            public NetCacheCardBacks(IntPtr address, string className) : base(address, className)
            {
            }

            public int DefaultCardBack
            {
                get
                {
                    return base.method_11<int>("get_DefaultCardBack", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.NetCacheCardValues")]
        public class NetCacheCardValues : MonoClass
        {
            public NetCacheCardValues(IntPtr address) : this(address, "NetCacheCardValues")
            {
            }

            public NetCacheCardValues(IntPtr address, string className) : base(address, className)
            {
            }

            public int CardNerfIndex
            {
                get
                {
                    return base.method_11<int>("get_CardNerfIndex", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.NetCacheClientOptions")]
        public class NetCacheClientOptions : MonoClass
        {
            public NetCacheClientOptions(IntPtr address) : this(address, "NetCacheClientOptions")
            {
            }

            public NetCacheClientOptions(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("NetCache.NetCacheCollection")]
        public class NetCacheCollection : MonoClass
        {
            public NetCacheCollection(IntPtr address) : this(address, "NetCacheCollection")
            {
            }

            public NetCacheCollection(IntPtr address, string className) : base(address, className)
            {
            }

            public List<NetCache.CardStack> Stacks
            {
                get
                {
                    Class267<NetCache.CardStack> class2 = base.method_14<Class267<NetCache.CardStack>>("get_Stacks", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public int TotalCardsOwned
            {
                get
                {
                    return base.method_2<int>("TotalCardsOwned");
                }
            }
        }

        [Attribute38("NetCache.NetCacheDecks")]
        public class NetCacheDecks : MonoClass
        {
            public NetCacheDecks(IntPtr address) : this(address, "NetCacheDecks")
            {
            }

            public NetCacheDecks(IntPtr address, string className) : base(address, className)
            {
            }

            public List<NetCache.DeckHeader> Decks
            {
                get
                {
                    Class267<NetCache.DeckHeader> class2 = base.method_14<Class267<NetCache.DeckHeader>>("get_Decks", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        [Attribute38("NetCache.NetCacheDisconnectedGame")]
        public class NetCacheDisconnectedGame : MonoClass
        {
            public NetCacheDisconnectedGame(IntPtr address) : this(address, "NetCacheDisconnectedGame")
            {
            }

            public NetCacheDisconnectedGame(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("NetCache.NetCacheFavoriteHeroes")]
        public class NetCacheFavoriteHeroes : MonoClass
        {
            public NetCacheFavoriteHeroes(IntPtr address) : this(address, "NetCacheFavoriteHeroes")
            {
            }

            public NetCacheFavoriteHeroes(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("NetCache.NetCacheFeatures")]
        public class NetCacheFeatures : MonoClass
        {
            public NetCacheFeatures(IntPtr address) : this(address, "NetCacheFeatures")
            {
            }

            public NetCacheFeatures(IntPtr address, string className) : base(address, className)
            {
            }

            public CacheCollection Collection
            {
                get
                {
                    return base.method_14<CacheCollection>("get_Collection", Array.Empty<object>());
                }
            }

            public CacheGames Games
            {
                get
                {
                    return base.method_14<CacheGames>("get_Games", Array.Empty<object>());
                }
            }

            public CacheHeroes Heroes
            {
                get
                {
                    return base.method_14<CacheHeroes>("get_Heroes", Array.Empty<object>());
                }
            }

            public CacheStore Store
            {
                get
                {
                    return base.method_14<CacheStore>("get_Store", Array.Empty<object>());
                }
            }

            [Attribute38("NetCache.NetCacheFeatures.CacheCollection")]
            public class CacheCollection : MonoClass
            {
                public CacheCollection(IntPtr address) : this(address, "CacheCollection")
                {
                }

                public CacheCollection(IntPtr address, string className) : base(address, className)
                {
                }

                public bool Crafting
                {
                    get
                    {
                        return base.method_11<bool>("get_Crafting", Array.Empty<object>());
                    }
                }

                public bool Manager
                {
                    get
                    {
                        return base.method_11<bool>("get_Manager", Array.Empty<object>());
                    }
                }
            }

            [Attribute38("NetCache.NetCacheFeatures.CacheGames")]
            public class CacheGames : MonoClass
            {
                public CacheGames(IntPtr address) : this(address, "CacheGames")
                {
                }

                public CacheGames(IntPtr address, string className) : base(address, className)
                {
                }

                public bool Casual
                {
                    get
                    {
                        return base.method_11<bool>("get_Casual", Array.Empty<object>());
                    }
                }

                public bool Forge
                {
                    get
                    {
                        return base.method_11<bool>("get_Forge", Array.Empty<object>());
                    }
                }

                public bool Friendly
                {
                    get
                    {
                        return base.method_11<bool>("get_Friendly", Array.Empty<object>());
                    }
                }

                public bool Practice
                {
                    get
                    {
                        return base.method_11<bool>("get_Practice", Array.Empty<object>());
                    }
                }

                public int ShowUserUI
                {
                    get
                    {
                        return base.method_11<int>("get_ShowUserUI", Array.Empty<object>());
                    }
                }

                public bool TavernBrawl
                {
                    get
                    {
                        return base.method_11<bool>("get_TavernBrawl", Array.Empty<object>());
                    }
                }

                public bool Tournament
                {
                    get
                    {
                        return base.method_11<bool>("get_Tournament", Array.Empty<object>());
                    }
                }
            }

            [Attribute38("NetCache.NetCacheFeatures.CacheHeroes")]
            public class CacheHeroes : MonoClass
            {
                public CacheHeroes(IntPtr address) : this(address, "CacheHeroes")
                {
                }

                public CacheHeroes(IntPtr address, string className) : base(address, className)
                {
                }

                public bool Hunter
                {
                    get
                    {
                        return base.method_11<bool>("get_Hunter", Array.Empty<object>());
                    }
                }

                public bool Mage
                {
                    get
                    {
                        return base.method_11<bool>("get_Mage", Array.Empty<object>());
                    }
                }

                public bool Paladin
                {
                    get
                    {
                        return base.method_11<bool>("get_Paladin", Array.Empty<object>());
                    }
                }

                public bool Priest
                {
                    get
                    {
                        return base.method_11<bool>("get_Priest", Array.Empty<object>());
                    }
                }

                public bool Rogue
                {
                    get
                    {
                        return base.method_11<bool>("get_Rogue", Array.Empty<object>());
                    }
                }

                public bool Shaman
                {
                    get
                    {
                        return base.method_11<bool>("get_Shaman", Array.Empty<object>());
                    }
                }

                public bool Warlock
                {
                    get
                    {
                        return base.method_11<bool>("get_Warlock", Array.Empty<object>());
                    }
                }

                public bool Warrior
                {
                    get
                    {
                        return base.method_11<bool>("get_Warrior", Array.Empty<object>());
                    }
                }
            }

            [Attribute38("NetCache.NetCacheFeatures.CacheStore")]
            public class CacheStore : MonoClass
            {
                public CacheStore(IntPtr address) : this(address, "CacheStore")
                {
                }

                public CacheStore(IntPtr address, string className) : base(address, className)
                {
                }

                public bool BattlePay
                {
                    get
                    {
                        return base.method_11<bool>("get_BattlePay", Array.Empty<object>());
                    }
                }

                public bool BuyWithGold
                {
                    get
                    {
                        return base.method_11<bool>("get_BuyWithGold", Array.Empty<object>());
                    }
                }

                public bool Store
                {
                    get
                    {
                        return base.method_11<bool>("get_Store", Array.Empty<object>());
                    }
                }
            }
        }

        [Attribute38("NetCache.NetCacheGamesPlayed")]
        public class NetCacheGamesPlayed : MonoClass
        {
            public NetCacheGamesPlayed(IntPtr address) : this(address, "NetCacheGamesPlayed")
            {
            }

            public NetCacheGamesPlayed(IntPtr address, string className) : base(address, className)
            {
            }

            public int FreeRewardProgress
            {
                get
                {
                    return base.method_11<int>("get_FreeRewardProgress", Array.Empty<object>());
                }
            }

            public int GamesLost
            {
                get
                {
                    return base.method_11<int>("get_GamesLost", Array.Empty<object>());
                }
            }

            public int GamesStarted
            {
                get
                {
                    return base.method_11<int>("get_GamesStarted", Array.Empty<object>());
                }
            }

            public int GamesWon
            {
                get
                {
                    return base.method_11<int>("get_GamesWon", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.NetCacheGoldBalance")]
        public class NetCacheGoldBalance : MonoClass
        {
            public NetCacheGoldBalance(IntPtr address) : this(address, "NetCacheGoldBalance")
            {
            }

            public NetCacheGoldBalance(IntPtr address, string className) : base(address, className)
            {
            }

            public long GetTotal()
            {
                return base.method_11<long>("GetTotal", Array.Empty<object>());
            }

            public long BonusBalance
            {
                get
                {
                    return base.method_11<long>("get_BonusBalance", Array.Empty<object>());
                }
            }

            public long Cap
            {
                get
                {
                    return base.method_11<long>("get_Cap", Array.Empty<object>());
                }
            }

            public long CappedBalance
            {
                get
                {
                    return base.method_11<long>("get_CappedBalance", Array.Empty<object>());
                }
            }

            public long CapWarning
            {
                get
                {
                    return base.method_11<long>("get_CapWarning", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.NetCacheHeroLevels")]
        public class NetCacheHeroLevels : MonoClass
        {
            public NetCacheHeroLevels(IntPtr address) : this(address, "NetCacheHeroLevels")
            {
            }

            public NetCacheHeroLevels(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public List<NetCache.HeroLevel> Levels
            {
                get
                {
                    Class267<NetCache.HeroLevel> class2 = base.method_14<Class267<NetCache.HeroLevel>>("get_Levels", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        [Attribute38("NetCache.NetCacheMedalHistory")]
        public class NetCacheMedalHistory : MonoClass
        {
            public NetCacheMedalHistory(IntPtr address) : this(address, "NetCacheMedalHistory")
            {
            }

            public NetCacheMedalHistory(IntPtr address, string className) : base(address, className)
            {
            }

            public List<NetCache.MedalHistory> Medals
            {
                get
                {
                    Class267<NetCache.MedalHistory> class2 = base.method_14<Class267<NetCache.MedalHistory>>("get_Medals", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        [Attribute38("NetCache.NetCacheMedalInfo")]
        public class NetCacheMedalInfo : MonoClass
        {
            public NetCacheMedalInfo(IntPtr address) : this(address, "NetCacheMedalInfo")
            {
            }

            public NetCacheMedalInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public NetCache.NetCacheMedalInfo Clone()
            {
                return base.method_14<NetCache.NetCacheMedalInfo>("Clone", Array.Empty<object>());
            }

            public void CopyFrom(NetCache.NetCacheMedalInfo other)
            {
                object[] objArray1 = new object[] { other };
                base.method_8("CopyFrom", objArray1);
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public int BestStarLevel
            {
                get
                {
                    return base.method_11<int>("get_BestStarLevel", Array.Empty<object>());
                }
            }

            public bool CanLoseLevel
            {
                get
                {
                    return base.method_11<bool>("get_CanLoseLevel", Array.Empty<object>());
                }
            }

            public bool CanLoseStars
            {
                get
                {
                    return base.method_11<bool>("get_CanLoseStars", Array.Empty<object>());
                }
            }

            public int GainLevelStars
            {
                get
                {
                    return base.method_11<int>("get_GainLevelStars", Array.Empty<object>());
                }
            }

            public int LegendIndex
            {
                get
                {
                    return base.method_11<int>("get_LegendIndex", Array.Empty<object>());
                }
            }

            public NetCache.NetCacheMedalInfo PreviousMedalInfo
            {
                get
                {
                    return base.method_14<NetCache.NetCacheMedalInfo>("get_PreviousMedalInfo", Array.Empty<object>());
                }
            }

            public int SeasonWins
            {
                get
                {
                    return base.method_11<int>("get_SeasonWins", Array.Empty<object>());
                }
            }

            public int StarLevel
            {
                get
                {
                    return base.method_11<int>("get_StarLevel", Array.Empty<object>());
                }
            }

            public int Stars
            {
                get
                {
                    return base.method_11<int>("get_Stars", Array.Empty<object>());
                }
            }

            public int StartStars
            {
                get
                {
                    return base.method_11<int>("get_StartStars", Array.Empty<object>());
                }
            }

            public int Streak
            {
                get
                {
                    return base.method_11<int>("get_Streak", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.NetCacheNotSoMassiveLogin")]
        public class NetCacheNotSoMassiveLogin : MonoClass
        {
            public NetCacheNotSoMassiveLogin(IntPtr address) : this(address, "NetCacheNotSoMassiveLogin")
            {
            }

            public NetCacheNotSoMassiveLogin(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("NetCache.NetCachePlayerRecords")]
        public class NetCachePlayerRecords : MonoClass
        {
            public NetCachePlayerRecords(IntPtr address) : this(address, "NetCachePlayerRecords")
            {
            }

            public NetCachePlayerRecords(IntPtr address, string className) : base(address, className)
            {
            }

            public List<NetCache.PlayerRecord> Records
            {
                get
                {
                    Class267<NetCache.PlayerRecord> class2 = base.method_14<Class267<NetCache.PlayerRecord>>("get_Records", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        [Attribute38("NetCache.NetCachePlayQueue")]
        public class NetCachePlayQueue : MonoClass
        {
            public NetCachePlayQueue(IntPtr address) : this(address, "NetCachePlayQueue")
            {
            }

            public NetCachePlayQueue(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("NetCache.NetCacheProfileNotices")]
        public class NetCacheProfileNotices : MonoClass
        {
            public NetCacheProfileNotices(IntPtr address) : this(address, "NetCacheProfileNotices")
            {
            }

            public NetCacheProfileNotices(IntPtr address, string className) : base(address, className)
            {
            }

            public List<NetCache.ProfileNotice> Notices
            {
                get
                {
                    Class267<NetCache.ProfileNotice> class2 = base.method_14<Class267<NetCache.ProfileNotice>>("get_Notices", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        [Attribute38("NetCache.NetCacheProfileProgress")]
        public class NetCacheProfileProgress : MonoClass
        {
            public NetCacheProfileProgress(IntPtr address) : this(address, "NetCacheProfileProgress")
            {
            }

            public NetCacheProfileProgress(IntPtr address, string className) : base(address, className)
            {
            }

            public List<AdventureOption> AdventureOptions
            {
                get
                {
                    Class247<AdventureOption> class2 = base.method_14<Class247<AdventureOption>>("get_AdventureOptions", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public int BestForgeWins
            {
                get
                {
                    return base.method_11<int>("get_BestForgeWins", Array.Empty<object>());
                }
            }

            public TutorialProgress CampaignProgress
            {
                get
                {
                    return base.method_11<TutorialProgress>("get_CampaignProgress", Array.Empty<object>());
                }
            }

            public int DisplayBanner
            {
                get
                {
                    return base.method_11<int>("get_DisplayBanner", Array.Empty<object>());
                }
            }

            public long LastForgeDate
            {
                get
                {
                    return base.method_11<long>("get_LastForgeDate", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.NetCacheRewardProgress")]
        public class NetCacheRewardProgress : MonoClass
        {
            public NetCacheRewardProgress(IntPtr address) : this(address, "NetCacheRewardProgress")
            {
            }

            public NetCacheRewardProgress(IntPtr address, string className) : base(address, className)
            {
            }

            public int GoldPerReward
            {
                get
                {
                    return base.method_11<int>("get_GoldPerReward", Array.Empty<object>());
                }
            }

            public int MaxGoldPerDay
            {
                get
                {
                    return base.method_11<int>("get_MaxGoldPerDay", Array.Empty<object>());
                }
            }

            public int MaxHeroLevel
            {
                get
                {
                    return base.method_11<int>("get_MaxHeroLevel", Array.Empty<object>());
                }
            }

            public long NextQuestCancelDate
            {
                get
                {
                    return base.method_11<long>("get_NextQuestCancelDate", Array.Empty<object>());
                }
            }

            public int PackRewardId
            {
                get
                {
                    return base.method_11<int>("get_PackRewardId", Array.Empty<object>());
                }
            }

            public int Season
            {
                get
                {
                    return base.method_11<int>("get_Season", Array.Empty<object>());
                }
            }

            public long SeasonEndDate
            {
                get
                {
                    return base.method_11<long>("get_SeasonEndDate", Array.Empty<object>());
                }
            }

            public float SpecialEventTimingMod
            {
                get
                {
                    return base.method_11<float>("get_SpecialEventTimingMod", Array.Empty<object>());
                }
            }

            public int WinsPerGold
            {
                get
                {
                    return base.method_11<int>("get_WinsPerGold", Array.Empty<object>());
                }
            }

            public int XPSoloLimit
            {
                get
                {
                    return base.method_11<int>("get_XPSoloLimit", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.NetCacheSubscribeResponse")]
        public class NetCacheSubscribeResponse : MonoClass
        {
            public NetCacheSubscribeResponse(IntPtr address) : this(address, "NetCacheSubscribeResponse")
            {
            }

            public NetCacheSubscribeResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public ulong FeaturesSupported
            {
                get
                {
                    return base.method_2<ulong>("FeaturesSupported");
                }
            }

            public ulong KeepAliveDelay
            {
                get
                {
                    return base.method_2<ulong>("KeepAliveDelay");
                }
            }

            public ulong RequestMaxWaitSecs
            {
                get
                {
                    return base.method_2<ulong>("RequestMaxWaitSecs");
                }
            }

            public ulong Route
            {
                get
                {
                    return base.method_2<ulong>("Route");
                }
            }
        }

        [Attribute38("NetCache.NetCacheTavernBrawlInfo")]
        public class NetCacheTavernBrawlInfo : MonoClass
        {
            public NetCacheTavernBrawlInfo(IntPtr address) : this(address, "NetCacheTavernBrawlInfo")
            {
            }

            public NetCacheTavernBrawlInfo(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("NetCache.NetCacheTavernBrawlRecord")]
        public class NetCacheTavernBrawlRecord : MonoClass
        {
            public NetCacheTavernBrawlRecord(IntPtr address) : this(address, "NetCacheTavernBrawlRecord")
            {
            }

            public NetCacheTavernBrawlRecord(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("NetCache.PlayerRecord")]
        public class PlayerRecord : MonoClass
        {
            public PlayerRecord(IntPtr address) : this(address, "PlayerRecord")
            {
            }

            public PlayerRecord(IntPtr address, string className) : base(address, className)
            {
            }

            public int Data
            {
                get
                {
                    return base.method_11<int>("get_Data", Array.Empty<object>());
                }
            }

            public int Losses
            {
                get
                {
                    return base.method_11<int>("get_Losses", Array.Empty<object>());
                }
            }

            public GameType RecordType
            {
                get
                {
                    return base.method_11<GameType>("get_RecordType", Array.Empty<object>());
                }
            }

            public int Ties
            {
                get
                {
                    return base.method_11<int>("get_Ties", Array.Empty<object>());
                }
            }

            public int Wins
            {
                get
                {
                    return base.method_11<int>("get_Wins", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNotice")]
        public class ProfileNotice : MonoClass
        {
            public ProfileNotice(IntPtr address) : this(address, "ProfileNotice")
            {
            }

            public ProfileNotice(IntPtr address, string className) : base(address, className)
            {
            }

            public long Date
            {
                get
                {
                    return base.method_11<long>("get_Date", Array.Empty<object>());
                }
            }

            public NoticeType m_type
            {
                get
                {
                    return base.method_2<NoticeType>("m_type");
                }
            }

            public long NoticeID
            {
                get
                {
                    return base.method_11<long>("get_NoticeID", Array.Empty<object>());
                }
            }

            public NoticeOrigin Origin
            {
                get
                {
                    return base.method_11<NoticeOrigin>("get_Origin", Array.Empty<object>());
                }
            }

            public long OriginData
            {
                get
                {
                    return base.method_11<long>("get_OriginData", Array.Empty<object>());
                }
            }

            public NoticeType Type
            {
                get
                {
                    return base.method_11<NoticeType>("get_Type", Array.Empty<object>());
                }
            }

            public enum NoticeOrigin
            {
                ACCOUNT_LICENSE_FLAGS = 0x15,
                ACHIEVEMENT = 7,
                ACK = 6,
                ADVENTURE_FLAGS = 0x13,
                ADVENTURE_PROGRESS = 0x12,
                BETA_REIMBURSE = 2,
                BLIZZCON = 13,
                DISCONNECTED_GAME = 15,
                EVENT = 14,
                FORGE = 3,
                IGR = 0x11,
                LEVEL_UP = 8,
                OUT_OF_BAND_LICENSE = 0x10,
                PRECON_DECK = 5,
                PURCHASE_CANCELED = 12,
                PURCHASE_COMPLETE = 10,
                PURCHASE_FAILED = 11,
                SEASON = 1,
                TAVERN_BRAWL_REWARD = 20,
                TOURNEY = 4,
                UNKNOWN = -1
            }

            public enum NoticeType
            {
                ACCOUNT_LICENSE = 0x10,
                ADVENTURE_PROGRESS = 14,
                BONUS_STARS = 12,
                DISCONNECTED_GAME = 4,
                GAINED_MEDAL = 1,
                HERO_LEVEL_UP = 15,
                PRECON_DECK = 5,
                PURCHASE = 10,
                REWARD_BOOSTER = 2,
                REWARD_CARD = 3,
                REWARD_CARD_BACK = 11,
                REWARD_DUST = 6,
                REWARD_FORGE = 8,
                REWARD_GOLD = 9,
                REWARD_MOUNT = 7
            }
        }

        [Attribute38("NetCache.ProfileNoticeAcccountLicense")]
        public class ProfileNoticeAcccountLicense : NetCache.ProfileNotice
        {
            public ProfileNoticeAcccountLicense(IntPtr address) : this(address, "ProfileNoticeAcccountLicense")
            {
            }

            public ProfileNoticeAcccountLicense(IntPtr address, string className) : base(address, className)
            {
            }

            public long CasID
            {
                get
                {
                    return base.method_11<long>("get_CasID", Array.Empty<object>());
                }
            }

            public long License
            {
                get
                {
                    return base.method_11<long>("get_License", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeAdventureProgress")]
        public class ProfileNoticeAdventureProgress : NetCache.ProfileNotice
        {
            public ProfileNoticeAdventureProgress(IntPtr address) : this(address, "ProfileNoticeAdventureProgress")
            {
            }

            public ProfileNoticeAdventureProgress(IntPtr address, string className) : base(address, className)
            {
            }

            public int Wing
            {
                get
                {
                    return base.method_11<int>("get_Wing", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeBonusStars")]
        public class ProfileNoticeBonusStars : NetCache.ProfileNotice
        {
            public ProfileNoticeBonusStars(IntPtr address) : this(address, "ProfileNoticeBonusStars")
            {
            }

            public ProfileNoticeBonusStars(IntPtr address, string className) : base(address, className)
            {
            }

            public int StarLevel
            {
                get
                {
                    return base.method_11<int>("get_StarLevel", Array.Empty<object>());
                }
            }

            public int Stars
            {
                get
                {
                    return base.method_11<int>("get_Stars", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeDisconnectedGame")]
        public class ProfileNoticeDisconnectedGame : NetCache.ProfileNotice
        {
            public ProfileNoticeDisconnectedGame(IntPtr address) : this(address, "ProfileNoticeDisconnectedGame")
            {
            }

            public ProfileNoticeDisconnectedGame(IntPtr address, string className) : base(address, className)
            {
            }

            public Triton.Game.Mapping.GameType GameType
            {
                get
                {
                    return base.method_11<Triton.Game.Mapping.GameType>("get_GameType", Array.Empty<object>());
                }
            }

            public int MissionId
            {
                get
                {
                    return base.method_11<int>("get_MissionId", Array.Empty<object>());
                }
            }

            public int PlayerIndex
            {
                get
                {
                    return base.method_11<int>("get_PlayerIndex", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeLevelUp")]
        public class ProfileNoticeLevelUp : NetCache.ProfileNotice
        {
            public ProfileNoticeLevelUp(IntPtr address) : this(address, "ProfileNoticeLevelUp")
            {
            }

            public ProfileNoticeLevelUp(IntPtr address, string className) : base(address, className)
            {
            }

            public int HeroClass
            {
                get
                {
                    return base.method_11<int>("get_HeroClass", Array.Empty<object>());
                }
            }

            public int NewLevel
            {
                get
                {
                    return base.method_11<int>("get_NewLevel", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeMedal")]
        public class ProfileNoticeMedal : NetCache.ProfileNotice
        {
            public ProfileNoticeMedal(IntPtr address) : this(address, "ProfileNoticeMedal")
            {
            }

            public ProfileNoticeMedal(IntPtr address, string className) : base(address, className)
            {
            }

            public int BestStarLevel
            {
                get
                {
                    return base.method_11<int>("get_BestStarLevel", Array.Empty<object>());
                }
            }

            public int LegendRank
            {
                get
                {
                    return base.method_11<int>("get_LegendRank", Array.Empty<object>());
                }
            }

            public int StarLevel
            {
                get
                {
                    return base.method_11<int>("get_StarLevel", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticePreconDeck")]
        public class ProfileNoticePreconDeck : NetCache.ProfileNotice
        {
            public ProfileNoticePreconDeck(IntPtr address) : this(address, "ProfileNoticePreconDeck")
            {
            }

            public ProfileNoticePreconDeck(IntPtr address, string className) : base(address, className)
            {
            }

            public long DeckID
            {
                get
                {
                    return base.method_11<long>("get_DeckID", Array.Empty<object>());
                }
            }

            public int HeroAsset
            {
                get
                {
                    return base.method_11<int>("get_HeroAsset", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticePurchase")]
        public class ProfileNoticePurchase : NetCache.ProfileNotice
        {
            public ProfileNoticePurchase(IntPtr address) : this(address, "ProfileNoticePurchase")
            {
            }

            public ProfileNoticePurchase(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public Triton.Game.Mapping.Currency CurrencyType
            {
                get
                {
                    return base.method_11<Triton.Game.Mapping.Currency>("get_CurrencyType", Array.Empty<object>());
                }
            }

            public long Data
            {
                get
                {
                    return base.method_11<long>("get_Data", Array.Empty<object>());
                }
            }

            public string ProductID
            {
                get
                {
                    return base.method_13("get_ProductID", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeRewardBooster")]
        public class ProfileNoticeRewardBooster : NetCache.ProfileNotice
        {
            public ProfileNoticeRewardBooster(IntPtr address) : this(address, "ProfileNoticeRewardBooster")
            {
            }

            public ProfileNoticeRewardBooster(IntPtr address, string className) : base(address, className)
            {
            }

            public int Count
            {
                get
                {
                    return base.method_11<int>("get_Count", Array.Empty<object>());
                }
            }

            public int Id
            {
                get
                {
                    return base.method_11<int>("get_Id", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeRewardCard")]
        public class ProfileNoticeRewardCard : NetCache.ProfileNotice
        {
            public ProfileNoticeRewardCard(IntPtr address) : this(address, "ProfileNoticeRewardCard")
            {
            }

            public ProfileNoticeRewardCard(IntPtr address, string className) : base(address, className)
            {
            }

            public string CardID
            {
                get
                {
                    return base.method_13("get_CardID", Array.Empty<object>());
                }
            }

            public TAG_PREMIUM Premium
            {
                get
                {
                    return base.method_11<TAG_PREMIUM>("get_Premium", Array.Empty<object>());
                }
            }

            public int Quantity
            {
                get
                {
                    return base.method_11<int>("get_Quantity", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeRewardCardBack")]
        public class ProfileNoticeRewardCardBack : NetCache.ProfileNotice
        {
            public ProfileNoticeRewardCardBack(IntPtr address) : this(address, "ProfileNoticeRewardCardBack")
            {
            }

            public ProfileNoticeRewardCardBack(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public int CardBackID
            {
                get
                {
                    return base.method_11<int>("get_CardBackID", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeRewardDust")]
        public class ProfileNoticeRewardDust : NetCache.ProfileNotice
        {
            public ProfileNoticeRewardDust(IntPtr address) : this(address, "ProfileNoticeRewardDust")
            {
            }

            public ProfileNoticeRewardDust(IntPtr address, string className) : base(address, className)
            {
            }

            public int Amount
            {
                get
                {
                    return base.method_11<int>("get_Amount", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeRewardForge")]
        public class ProfileNoticeRewardForge : NetCache.ProfileNotice
        {
            public ProfileNoticeRewardForge(IntPtr address) : this(address, "ProfileNoticeRewardForge")
            {
            }

            public ProfileNoticeRewardForge(IntPtr address, string className) : base(address, className)
            {
            }

            public int Quantity
            {
                get
                {
                    return base.method_11<int>("get_Quantity", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeRewardGold")]
        public class ProfileNoticeRewardGold : NetCache.ProfileNotice
        {
            public ProfileNoticeRewardGold(IntPtr address) : this(address, "ProfileNoticeRewardGold")
            {
            }

            public ProfileNoticeRewardGold(IntPtr address, string className) : base(address, className)
            {
            }

            public int Amount
            {
                get
                {
                    return base.method_11<int>("get_Amount", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.ProfileNoticeRewardMount")]
        public class ProfileNoticeRewardMount : NetCache.ProfileNotice
        {
            public ProfileNoticeRewardMount(IntPtr address) : this(address, "ProfileNoticeRewardMount")
            {
            }

            public ProfileNoticeRewardMount(IntPtr address, string className) : base(address, className)
            {
            }

            public int MountID
            {
                get
                {
                    return base.method_11<int>("get_MountID", Array.Empty<object>());
                }
            }
        }

        [Attribute38("NetCache.Request")]
        public class Request : MonoClass
        {
            public Request(IntPtr address) : this(address, "Request")
            {
            }

            public Request(IntPtr address, string className) : base(address, className)
            {
            }

            public bool m_reload
            {
                get
                {
                    return base.method_2<bool>("m_reload");
                }
            }

            public NetCache.RequestResult m_result
            {
                get
                {
                    return base.method_2<NetCache.RequestResult>("m_result");
                }
            }

            public System.Type m_type
            {
                get
                {
                    return base.method_3<System.Type>("m_type");
                }
            }

            public static bool RELOAD
            {
                get
                {
                    return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "NetCache/Request", "RELOAD");
                }
            }
        }

        public enum RequestResult
        {
            UNKNOWN,
            PENDING,
            IN_PROCESS,
            GENERIC_COMPLETE,
            DATA_COMPLETE,
            ERROR
        }
    }
}

