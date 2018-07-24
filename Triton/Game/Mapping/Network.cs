namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Network")]
    public class Network : MonoClass
    {
        public Network(IntPtr address) : this(address, "Network")
        {
        }

        public Network(IntPtr address, string className) : base(address, className)
        {
        }

        public static void AcceptFriendInvite(BnetInvitationId inviteid)
        {
            object[] objArray1 = new object[] { inviteid };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "AcceptFriendInvite", objArray1);
        }

        public static AchieveList Achieves()
        {
            return MonoClass.smethod_15<AchieveList>(TritonHs.MainAssemblyPath, "", "Network", "Achieves", Array.Empty<object>());
        }

        public static void AckAchieveProgress(int ID, int ackProgress)
        {
            object[] objArray1 = new object[] { ID, ackProgress };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "AckAchieveProgress", objArray1);
        }

        public static void AckCardSeenBefore(int assetID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { assetID, premium };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "AckCardSeenBefore", objArray1);
        }

        public static void AckDraftRewards(long deckID, int slot)
        {
            object[] objArray1 = new object[] { deckID, slot };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "AckDraftRewards", objArray1);
        }

        public static void AckNotice(long ID)
        {
            object[] objArray1 = new object[] { ID };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "AckNotice", objArray1);
        }

        public static void AcknowledgeBanner(int banner)
        {
            object[] objArray1 = new object[] { banner };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "AcknowledgeBanner", objArray1);
        }

        public static void AckWingProgress(int wingId, int ackId)
        {
            object[] objArray1 = new object[] { wingId, ackId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "AckWingProgress", objArray1);
        }

        public static void AddPendingRequestTimeout(int requestId, int requestSubId)
        {
            object[] objArray1 = new object[] { requestId, requestSubId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "AddPendingRequestTimeout", objArray1);
        }

        public void AnswerChallenge(ulong challengeID, string answer)
        {
            object[] objArray1 = new object[] { challengeID, answer };
            base.method_8("AnswerChallenge", objArray1);
        }

        public static void AppAbort()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "AppAbort");
        }

        public static void ApplicationPaused()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "ApplicationPaused");
        }

        public static void ApplicationUnpaused()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "ApplicationUnpaused");
        }

        public static void AppQuit()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "AppQuit");
        }

        public static void AutoConcede()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "AutoConcede");
        }

        public static BnetLoginState BattleNetStatus()
        {
            return MonoClass.smethod_14<BnetLoginState>(TritonHs.MainAssemblyPath, "", "Network", "BattleNetStatus", Array.Empty<object>());
        }

        public static void BuyCard(int assetID, TAG_PREMIUM premium, int count, int unitBuyPrice)
        {
            object[] objArray1 = new object[] { assetID, premium, count, unitBuyPrice };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "BuyCard", objArray1);
        }

        public void CancelChallenge(ulong challengeID)
        {
            object[] objArray1 = new object[] { challengeID };
            base.method_8("CancelChallenge", objArray1);
        }

        public void CancelFindGame()
        {
            base.method_8("CancelFindGame", Array.Empty<object>());
        }

        public bool CanIgnoreUnhandledPacket(int id)
        {
            object[] objArray1 = new object[] { id };
            return base.method_11<bool>("CanIgnoreUnhandledPacket", objArray1);
        }

        public static void CheckAccountLicenseAchieve(int achieveID)
        {
            object[] objArray1 = new object[] { achieveID };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "CheckAccountLicenseAchieve", objArray1);
        }

        public void ClearLastGameServerJoined()
        {
            base.method_8("ClearLastGameServerJoined", Array.Empty<object>());
        }

        public static void CloseCardMarket()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "CloseCardMarket");
        }

        public static void Concede()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "Concede");
        }

        public static void ConcedeIfReconnectDisabled()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "ConcedeIfReconnectDisabled");
        }

        public static void ConfirmPurchase()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "ConfirmPurchase");
        }

        public void CreateDeck(DeckType deckType, string name, int heroDatabaseAssetID, TAG_PREMIUM heroPremium)
        {
            object[] objArray1 = new object[] { deckType, name, heroDatabaseAssetID, heroPremium };
            base.method_8("CreateDeck", objArray1);
        }

        public static void DeclineFriendInvite(BnetInvitationId inviteid)
        {
            object[] objArray1 = new object[] { inviteid };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "DeclineFriendInvite", objArray1);
        }

        public float DelayForConnectionFailures(int numFailures)
        {
            object[] objArray1 = new object[] { numFailures };
            return base.method_11<float>("DelayForConnectionFailures", objArray1);
        }

        public void DeleteDeck(long deck)
        {
            object[] objArray1 = new object[] { deck };
            base.method_8("DeleteDeck", objArray1);
        }

        public static void DisconnectFromGameServer()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "DisconnectFromGameServer");
        }

        public bool FakeHandleType(int id)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { id };
            return base.method_10<bool>("FakeHandleType", enumArray1, objArray1);
        }

        public bool FakeHandleType(object enumId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { enumId };
            return base.method_10<bool>("FakeHandleType", enumArray1, objArray1);
        }

        public void FindGame(GameType gameType, int missionId, long deckId, long aiDeckId)
        {
            object[] objArray1 = new object[] { gameType, missionId, deckId, aiDeckId };
            base.method_8("FindGame", objArray1);
        }

        public static void FindOutCurrentDraftState()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "FindOutCurrentDraftState");
        }

        public static Network Get()
        {
            return MonoClass.smethod_15<Network>(TritonHs.MainAssemblyPath, "", "Network", "Get", Array.Empty<object>());
        }

        public static AccountLicenseAchieveResponse GetAccountLicenseAchieveResponse()
        {
            return MonoClass.smethod_15<AccountLicenseAchieveResponse>(TritonHs.MainAssemblyPath, "", "Network", "GetAccountLicenseAchieveResponse", Array.Empty<object>());
        }

        public static List<AdventureProgress> GetAdventureProgressResponse()
        {
            Class267<AdventureProgress> class2 = MonoClass.smethod_15<Class267<AdventureProgress>>(TritonHs.MainAssemblyPath, "", "Network", "GetAdventureProgressResponse", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static void GetAllClientOptions()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "GetAllClientOptions");
        }

        public static int GetAssetsVersion()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "Network", "GetAssetsVersion", Array.Empty<object>());
        }

        public static BattlePayConfig GetBattlePayConfigResponse()
        {
            return MonoClass.smethod_15<BattlePayConfig>(TritonHs.MainAssemblyPath, "", "Network", "GetBattlePayConfigResponse", Array.Empty<object>());
        }

        public static BattlePayStatus GetBattlePayStatusResponse()
        {
            return MonoClass.smethod_15<BattlePayStatus>(TritonHs.MainAssemblyPath, "", "Network", "GetBattlePayStatusResponse", Array.Empty<object>());
        }

        public static CanceledQuest GetCanceledQuest()
        {
            return MonoClass.smethod_15<CanceledQuest>(TritonHs.MainAssemblyPath, "", "Network", "GetCanceledQuest", Array.Empty<object>());
        }

        public static CardSaleResult GetCardSaleResult()
        {
            return MonoClass.smethod_15<CardSaleResult>(TritonHs.MainAssemblyPath, "", "Network", "GetCardSaleResult", Array.Empty<object>());
        }

        public static DraftChosen GetChosenAndNext()
        {
            return MonoClass.smethod_15<DraftChosen>(TritonHs.MainAssemblyPath, "", "Network", "GetChosenAndNext", Array.Empty<object>());
        }

        public static NetCache.DeckHeader GetCreatedDeck()
        {
            return MonoClass.smethod_15<NetCache.DeckHeader>(TritonHs.MainAssemblyPath, "", "Network", "GetCreatedDeck", Array.Empty<object>());
        }

        public static DeckContents GetDeckContents()
        {
            return MonoClass.smethod_15<DeckContents>(TritonHs.MainAssemblyPath, "", "Network", "GetDeckContents", Array.Empty<object>());
        }

        public void GetDeckContents(long deck)
        {
            object[] objArray1 = new object[] { deck };
            base.method_8("GetDeckContents", objArray1);
        }

        public static DBAction GetDeckResponse()
        {
            return MonoClass.smethod_15<DBAction>(TritonHs.MainAssemblyPath, "", "Network", "GetDeckResponse", Array.Empty<object>());
        }

        public static long GetDeletedDeckID()
        {
            return MonoClass.smethod_14<long>(TritonHs.MainAssemblyPath, "", "Network", "GetDeletedDeckID", Array.Empty<object>());
        }

        public static DraftChoicesAndContents GetDraftChoicesAndContents()
        {
            return MonoClass.smethod_15<DraftChoicesAndContents>(TritonHs.MainAssemblyPath, "", "Network", "GetDraftChoicesAndContents", Array.Empty<object>());
        }

        public static DraftError GetDraftError()
        {
            return MonoClass.smethod_14<DraftError>(TritonHs.MainAssemblyPath, "", "Network", "GetDraftError", Array.Empty<object>());
        }

        public static EntitiesChosen GetEntitiesChosen()
        {
            return MonoClass.smethod_15<EntitiesChosen>(TritonHs.MainAssemblyPath, "", "Network", "GetEntitiesChosen", Array.Empty<object>());
        }

        public static EntityChoices GetEntityChoices()
        {
            return MonoClass.smethod_15<EntityChoices>(TritonHs.MainAssemblyPath, "", "Network", "GetEntityChoices", Array.Empty<object>());
        }

        public static GameCancelInfo GetGameCancelInfo()
        {
            return MonoClass.smethod_15<GameCancelInfo>(TritonHs.MainAssemblyPath, "", "Network", "GetGameCancelInfo", Array.Empty<object>());
        }

        public static GameSetup GetGameSetupInfo()
        {
            return MonoClass.smethod_15<GameSetup>(TritonHs.MainAssemblyPath, "", "Network", "GetGameSetupInfo", Array.Empty<object>());
        }

        public void GetGameState()
        {
            base.method_8("GetGameState", Array.Empty<object>());
        }

        public static UnavailableReason GetHearthstoneUnavailable(bool gamePacket)
        {
            object[] objArray1 = new object[] { gamePacket };
            return MonoClass.smethod_15<UnavailableReason>(TritonHs.MainAssemblyPath, "", "Network", "GetHearthstoneUnavailable", objArray1);
        }

        public static List<int> GetIntArray(IntPtr ints, int size)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { ints, size };
            Class266<int> class2 = MonoClass.smethod_16<Class266<int>>(TritonHs.MainAssemblyPath, "", "Network", "GetIntArray", enumArray1, objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static bool GetIsVersionIntFromConfig()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Network", "GetIsVersionIntFromConfig", Array.Empty<object>());
        }

        public static MassDisenchantResponse GetMassDisenchantResponse()
        {
            return MonoClass.smethod_15<MassDisenchantResponse>(TritonHs.MainAssemblyPath, "", "Network", "GetMassDisenchantResponse", Array.Empty<object>());
        }

        public static TimeSpan GetMaxDeferredWait()
        {
            return MonoClass.smethod_14<TimeSpan>(TritonHs.MainAssemblyPath, "", "Network", "GetMaxDeferredWait", Array.Empty<object>());
        }

        public static int GetNAckOption()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "Network", "GetNAckOption", Array.Empty<object>());
        }

        public static BeginDraft GetNewDraftDeckID()
        {
            return MonoClass.smethod_15<BeginDraft>(TritonHs.MainAssemblyPath, "", "Network", "GetNewDraftDeckID", Array.Empty<object>());
        }

        public static Options GetOptions()
        {
            return MonoClass.smethod_15<Options>(TritonHs.MainAssemblyPath, "", "Network", "GetOptions", Array.Empty<object>());
        }

        public static int GetPort()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "Network", "GetPort", Array.Empty<object>());
        }

        public static List<PowerHistory> GetPowerHistory()
        {
            Class267<PowerHistory> class2 = MonoClass.smethod_15<Class267<PowerHistory>>(TritonHs.MainAssemblyPath, "", "Network", "GetPowerHistory", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static PurchaseCanceledResponse GetPurchaseCanceledResponse()
        {
            return MonoClass.smethod_15<PurchaseCanceledResponse>(TritonHs.MainAssemblyPath, "", "Network", "GetPurchaseCanceledResponse", Array.Empty<object>());
        }

        public static void GetPurchaseMethod(string productID, int quantity, Triton.Game.Mapping.Currency currency)
        {
            object[] objArray1 = new object[] { productID, quantity, currency };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "GetPurchaseMethod", objArray1);
        }

        public static PurchaseMethod GetPurchaseMethodResponse()
        {
            return MonoClass.smethod_15<PurchaseMethod>(TritonHs.MainAssemblyPath, "", "Network", "GetPurchaseMethodResponse", Array.Empty<object>());
        }

        public static PurchaseResponse GetPurchaseResponse()
        {
            return MonoClass.smethod_15<PurchaseResponse>(TritonHs.MainAssemblyPath, "", "Network", "GetPurchaseResponse", Array.Empty<object>());
        }

        public static PurchaseViaGoldResponse GetPurchaseWithGoldResponse()
        {
            return MonoClass.smethod_15<PurchaseViaGoldResponse>(TritonHs.MainAssemblyPath, "", "Network", "GetPurchaseWithGoldResponse", Array.Empty<object>());
        }

        public static DeckName GetRenamedDeck()
        {
            return MonoClass.smethod_15<DeckName>(TritonHs.MainAssemblyPath, "", "Network", "GetRenamedDeck", Array.Empty<object>());
        }

        public static DraftRetired GetRetiredDraft()
        {
            return MonoClass.smethod_15<DraftRetired>(TritonHs.MainAssemblyPath, "", "Network", "GetRetiredDraft", Array.Empty<object>());
        }

        public static long GetRewardsAckDraftID()
        {
            return MonoClass.smethod_14<long>(TritonHs.MainAssemblyPath, "", "Network", "GetRewardsAckDraftID", Array.Empty<object>());
        }

        public static SetFavoriteHeroResponse GetSetFavoriteHeroResponse()
        {
            return MonoClass.smethod_15<SetFavoriteHeroResponse>(TritonHs.MainAssemblyPath, "", "Network", "GetSetFavoriteHeroResponse", Array.Empty<object>());
        }

        public static string GetStoredBNetIP()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Network", "GetStoredBNetIP", Array.Empty<object>());
        }

        public static string GetStoredUserName()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Network", "GetStoredUserName", Array.Empty<object>());
        }

        public static string GetStoredVersion()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Network", "GetStoredVersion", Array.Empty<object>());
        }

        public static List<Entity.Tag> GetTags(IntPtr src, IntPtr flags)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { src, flags };
            Class267<Entity.Tag> class2 = MonoClass.smethod_16<Class267<Entity.Tag>>(TritonHs.MainAssemblyPath, "", "Network", "GetTags", enumArray1, objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static string GetTargetServer()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Network", "GetTargetServer", Array.Empty<object>());
        }

        public static void GetThirdPartyPurchaseStatus(string transactionID)
        {
            object[] objArray1 = new object[] { transactionID };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "GetThirdPartyPurchaseStatus", objArray1);
        }

        public static ThirdPartyPurchaseStatusResponse GetThirdPartyPurchaseStatusResponse()
        {
            return MonoClass.smethod_15<ThirdPartyPurchaseStatusResponse>(TritonHs.MainAssemblyPath, "", "Network", "GetThirdPartyPurchaseStatusResponse", Array.Empty<object>());
        }

        public static TriggeredEvent GetTriggerEventResponse()
        {
            return MonoClass.smethod_15<TriggeredEvent>(TritonHs.MainAssemblyPath, "", "Network", "GetTriggerEventResponse", Array.Empty<object>());
        }

        public static TurnTimerInfo GetTurnTimerInfo()
        {
            return MonoClass.smethod_15<TurnTimerInfo>(TritonHs.MainAssemblyPath, "", "Network", "GetTurnTimerInfo", Array.Empty<object>());
        }

        public static string GetUsername()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Network", "GetUsername", Array.Empty<object>());
        }

        public static UserUI GetUserUI()
        {
            return MonoClass.smethod_15<UserUI>(TritonHs.MainAssemblyPath, "", "Network", "GetUserUI", Array.Empty<object>());
        }

        public static ValidatedAchieve GetValidatedAchieve()
        {
            return MonoClass.smethod_15<ValidatedAchieve>(TritonHs.MainAssemblyPath, "", "Network", "GetValidatedAchieve", Array.Empty<object>());
        }

        public static string GetVersion()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Network", "GetVersion", Array.Empty<object>());
        }

        public static string GetVersionFromConfig()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Network", "GetVersionFromConfig", Array.Empty<object>());
        }

        public bool HandleType(int id)
        {
            object[] objArray1 = new object[] { id };
            return base.method_11<bool>("HandleType", objArray1);
        }

        public bool HaveUnhandledPackets()
        {
            return base.method_11<bool>("HaveUnhandledPackets", Array.Empty<object>());
        }

        public static void Heartbeat()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "Heartbeat");
        }

        public static void IgnoreFriendInvite(BnetInvitationId inviteid)
        {
            object[] objArray1 = new object[] { inviteid };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "IgnoreFriendInvite", objArray1);
        }

        public static bool InitBattleNet()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Network", "InitBattleNet", Array.Empty<object>());
        }

        public static void Initialize()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "Initialize");
        }

        public static List<int> IntPtrToIntArray(IntPtr src, int length)
        {
            object[] objArray1 = new object[] { src, length };
            Class246<int> class2 = MonoClass.smethod_15<Class246<int>>(TritonHs.MainAssemblyPath, "", "Network", "IntPtrToIntArray", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<long> IntPtrToLongArray(IntPtr src, int length)
        {
            object[] objArray1 = new object[] { src, length };
            Class246<long> class2 = MonoClass.smethod_15<Class246<long>>(TritonHs.MainAssemblyPath, "", "Network", "IntPtrToLongArray", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static bool IsConnectedToGameServer()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Network", "IsConnectedToGameServer", Array.Empty<object>());
        }

        public bool IsFindingGame()
        {
            return base.method_11<bool>("IsFindingGame", Array.Empty<object>());
        }

        public static bool IsLoggedIn()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Network", "IsLoggedIn", Array.Empty<object>());
        }

        public static bool IsRunning()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Network", "IsRunning", Array.Empty<object>());
        }

        public static bool IsVersionInt()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Network", "IsVersionInt", Array.Empty<object>());
        }

        public static void LoginOk()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "LoginOk");
        }

        public static List<int> MakeChoicesList(int choice1, int choice2, int choice3)
        {
            object[] objArray1 = new object[] { choice1, choice2, choice3 };
            Class266<int> class2 = MonoClass.smethod_15<Class266<int>>(TritonHs.MainAssemblyPath, "", "Network", "MakeChoicesList", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static void MakeDraftChoice(long deckID, int slot, int index)
        {
            object[] objArray1 = new object[] { deckID, slot, index };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "MakeDraftChoice", objArray1);
        }

        public static void MassDisenchant()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "MassDisenchant");
        }

        public static void OnGenericResponse()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "OnGenericResponse");
        }

        public void OnLoginStarted()
        {
            base.method_8("OnLoginStarted", Array.Empty<object>());
        }

        public static void OnRequestTimeout(int pendingResponseId, int requestId, int requestSubId)
        {
            object[] objArray1 = new object[] { pendingResponseId, requestId, requestSubId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "OnRequestTimeout", objArray1);
        }

        public static void OnSubscribeResponse()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "OnSubscribeResponse");
        }

        public static void OpenBooster(int id)
        {
            object[] objArray1 = new object[] { id };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "OpenBooster", objArray1);
        }

        public static List<NetCache.BoosterCard> OpenedBooster()
        {
            Class267<NetCache.BoosterCard> class2 = MonoClass.smethod_15<Class267<NetCache.BoosterCard>>(TritonHs.MainAssemblyPath, "", "Network", "OpenedBooster", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void ProcessAurora()
        {
            base.method_8("ProcessAurora", Array.Empty<object>());
        }

        public void ProcessBnetEvents()
        {
            base.method_8("ProcessBnetEvents", Array.Empty<object>());
        }

        public void ProcessBroadcasts()
        {
            base.method_8("ProcessBroadcasts", Array.Empty<object>());
        }

        public void ProcessChallenges()
        {
            base.method_8("ProcessChallenges", Array.Empty<object>());
        }

        public bool ProcessConsole()
        {
            return base.method_11<bool>("ProcessConsole", Array.Empty<object>());
        }

        public bool ProcessDelayedError()
        {
            return base.method_11<bool>("ProcessDelayedError", Array.Empty<object>());
        }

        public void ProcessErrors()
        {
            base.method_8("ProcessErrors", Array.Empty<object>());
        }

        public void ProcessFriends()
        {
            base.method_8("ProcessFriends", Array.Empty<object>());
        }

        public bool ProcessGameQueue()
        {
            return base.method_11<bool>("ProcessGameQueue", Array.Empty<object>());
        }

        public bool ProcessGameServer()
        {
            return base.method_11<bool>("ProcessGameServer", Array.Empty<object>());
        }

        public void ProcessNetwork()
        {
            base.method_8("ProcessNetwork", Array.Empty<object>());
        }

        public void ProcessNotifications()
        {
            base.method_8("ProcessNotifications", Array.Empty<object>());
        }

        public void ProcessParties()
        {
            base.method_8("ProcessParties", Array.Empty<object>());
        }

        public void ProcessPresence()
        {
            base.method_8("ProcessPresence", Array.Empty<object>());
        }

        public void ProcessQueuePosition()
        {
            base.method_8("ProcessQueuePosition", Array.Empty<object>());
        }

        public static void ProcessRequestTimeouts()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "ProcessRequestTimeouts");
        }

        public bool ProcessUtilServer()
        {
            return base.method_11<bool>("ProcessUtilServer", Array.Empty<object>());
        }

        public void ProcessWhispers()
        {
            base.method_8("ProcessWhispers", Array.Empty<object>());
        }

        public static int ProductVersion()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "Network", "ProductVersion", Array.Empty<object>());
        }

        public static void RemovePendingRequestTimeout(int pendingResponseId)
        {
            object[] objArray1 = new object[] { pendingResponseId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "RemovePendingRequestTimeout", objArray1);
        }

        public void RenameDeck(long deck, string name)
        {
            object[] objArray1 = new object[] { deck, name };
            base.method_8("RenameDeck", objArray1);
        }

        public static void RequestAchieves(bool activeOrNewCompleteOnly)
        {
            object[] objArray1 = new object[] { activeOrNewCompleteOnly };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "RequestAchieves", objArray1);
        }

        public static void RequestAdventureProgress()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "RequestAdventureProgress");
        }

        public static void RequestAssetsVersion()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "RequestAssetsVersion");
        }

        public static void RequestBattlePayConfig()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "RequestBattlePayConfig");
        }

        public static void RequestBattlePayStatus()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "RequestBattlePayStatus");
        }

        public static void RequestCancelQuest(int achieveID)
        {
            object[] objArray1 = new object[] { achieveID };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "RequestCancelQuest", objArray1);
        }

        public static void Reset()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "Reset");
        }

        public static void ResetConnectionFailureCount()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "ResetConnectionFailureCount");
        }

        public static void RetireDraftDeck(long deckID, int slot)
        {
            object[] objArray1 = new object[] { deckID, slot };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "RetireDraftDeck", objArray1);
        }

        public bool RetryGotoGameServer()
        {
            return base.method_11<bool>("RetryGotoGameServer", Array.Empty<object>());
        }

        public static void RevokeFriendInvite(BnetInvitationId inviteid)
        {
            object[] objArray1 = new object[] { inviteid };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "RevokeFriendInvite", objArray1);
        }

        public static void SellCard(int assetID, TAG_PREMIUM premium, int count, int unitSellPrice)
        {
            object[] objArray1 = new object[] { assetID, premium, count, unitSellPrice };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "SellCard", objArray1);
        }

        public static void SendAckCardsSeen()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "SendAckCardsSeen");
        }

        public static bool SendConsoleCmdToServer(string command)
        {
            object[] objArray1 = new object[] { command };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Network", "SendConsoleCmdToServer", objArray1);
        }

        public void SendEmote(EmoteType emote)
        {
            object[] objArray1 = new object[] { emote };
            base.method_8("SendEmote", objArray1);
        }

        public static void SendFriendInvite(string sender, string target, bool byEmail)
        {
            object[] objArray1 = new object[] { sender, target, byEmail };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "SendFriendInvite", objArray1);
        }

        public static void SendFriendInviteByBattleTag(string sender, string target)
        {
            object[] objArray1 = new object[] { sender, target };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "SendFriendInviteByBattleTag", objArray1);
        }

        public static void SendFriendInviteByEmail(string sender, string target)
        {
            object[] objArray1 = new object[] { sender, target };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "SendFriendInviteByEmail", objArray1);
        }

        public void SendOption(int ID, int index, int target, int sub, int pos)
        {
            object[] objArray1 = new object[] { ID, index, target, sub, pos };
            base.method_8("SendOption", objArray1);
        }

        public void SendRemoveAllSpectators(bool regenerateSpectatorPassword)
        {
            object[] objArray1 = new object[] { regenerateSpectatorPassword };
            base.method_8("SendRemoveAllSpectators", objArray1);
        }

        public void SendUserUI(int overCard, int heldCard, int arrowOrigin, int x, int y)
        {
            object[] objArray1 = new object[] { overCard, heldCard, arrowOrigin, x, y };
            base.method_8("SendUserUI", objArray1);
        }

        public static void SetAdventureOptions(int id, ulong options)
        {
            object[] objArray1 = new object[] { id, options };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "SetAdventureOptions", objArray1);
        }

        public void SetDeckTemplateSource(long deck, int templateID)
        {
            object[] objArray1 = new object[] { deck, templateID };
            base.method_8("SetDeckTemplateSource", objArray1);
        }

        public static void SetFavoriteHero(TAG_CLASS heroClass, NetCache.CardDefinition hero)
        {
            object[] objArray1 = new object[] { heroClass, hero };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "SetFavoriteHero", objArray1);
        }

        public static void SetShouldBeConnectedToAurora(bool shouldBeConnected)
        {
            object[] objArray1 = new object[] { shouldBeConnected };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "SetShouldBeConnectedToAurora", objArray1);
        }

        public static bool ShouldBeConnectedToAurora()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Network", "ShouldBeConnectedToAurora", Array.Empty<object>());
        }

        public void ShowBreakingNewsOrError(string error, float timeBeforeAllowReset)
        {
            object[] objArray1 = new object[] { error, timeBeforeAllowReset };
            base.method_8("ShowBreakingNewsOrError", objArray1);
        }

        public void ShowConnectionFailureError(string error)
        {
            object[] objArray1 = new object[] { error };
            base.method_8("ShowConnectionFailureError", objArray1);
        }

        public static void StartANewDraft()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Network", "StartANewDraft");
        }

        public static void SubmitThirdPartyReceipt(long bpayID, string thirdPartyID, string base64receipt, string thirdPartyUserID)
        {
            object[] objArray1 = new object[] { bpayID, thirdPartyID, base64receipt, thirdPartyUserID };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "SubmitThirdPartyReceipt", objArray1);
        }

        public void ThrowDnsResolveError(string environment)
        {
            object[] objArray1 = new object[] { environment };
            base.method_8("ThrowDnsResolveError", objArray1);
        }

        public static void TrackClient(TrackLevel level, TrackWhat what)
        {
            object[] objArray1 = new object[] { level, what };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "TrackClient", objArray1);
        }

        public static void ValidateAchieve(int achieveID)
        {
            object[] objArray1 = new object[] { achieveID };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Network", "ValidateAchieve", objArray1);
        }

        public static bool WasDisconnectRequested()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Network", "WasDisconnectRequested", Array.Empty<object>());
        }

        public static bool WasGameConceded()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Network", "WasGameConceded", Array.Empty<object>());
        }

        public static string CosmeticVersion
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Network", "CosmeticVersion");
            }
        }

        public static string DEFAULT_INTERNAL_ENVIRONMENT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Network", "DEFAULT_INTERNAL_ENVIRONMENT");
            }
        }

        public static string DEFAULT_PUBLIC_ENVIRONMENT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Network", "DEFAULT_PUBLIC_ENVIRONMENT");
            }
        }

        public DateTime lastCall
        {
            get
            {
                return base.method_2<DateTime>("lastCall");
            }
        }

        public DateTime lastCallReport
        {
            get
            {
                return base.method_2<DateTime>("lastCallReport");
            }
        }

        public static TimeSpan LOGIN_TIMEOUT
        {
            get
            {
                return MonoClass.smethod_6<TimeSpan>(TritonHs.MainAssemblyPath, "", "Network", "LOGIN_TIMEOUT");
            }
        }

        public string m_delayedError
        {
            get
            {
                return base.method_4("m_delayedError");
            }
        }

        public static List<RequestContext> m_inTransitRequests
        {
            get
            {
                Class267<RequestContext> class2 = MonoClass.smethod_7<Class267<RequestContext>>(TritonHs.MainAssemblyPath, "", "Network", "m_inTransitRequests");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameServerInfo m_lastGameServerInfo
        {
            get
            {
                return base.method_3<GameServerInfo>("m_lastGameServerInfo");
            }
        }

        public DateTime m_loginStarted
        {
            get
            {
                return base.method_2<DateTime>("m_loginStarted");
            }
        }

        public bool m_loginWaiting
        {
            get
            {
                return base.method_2<bool>("m_loginWaiting");
            }
        }

        public float m_timeBeforeAllowReset
        {
            get
            {
                return base.method_2<float>("m_timeBeforeAllowReset");
            }
        }

        public static TimeSpan MAX_DEFERRED_WAIT
        {
            get
            {
                return MonoClass.smethod_6<TimeSpan>(TritonHs.MainAssemblyPath, "", "Network", "MAX_DEFERRED_WAIT");
            }
        }

        public static int MIN_DEFERRED_WAIT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Network", "MIN_DEFERRED_WAIT");
            }
        }

        public static int NoPosition
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Network", "NoPosition");
            }
        }

        public static int NoSubOption
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Network", "NoSubOption");
            }
        }

        public static TimeSpan PROCESS_WARNING
        {
            get
            {
                return MonoClass.smethod_6<TimeSpan>(TritonHs.MainAssemblyPath, "", "Network", "PROCESS_WARNING");
            }
        }

        public static TimeSpan PROCESS_WARNING_REPORT_GAP
        {
            get
            {
                return MonoClass.smethod_6<TimeSpan>(TritonHs.MainAssemblyPath, "", "Network", "PROCESS_WARNING_REPORT_GAP");
            }
        }

        public static int s_numConnectionFailures
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Network", "s_numConnectionFailures");
            }
        }

        public static bool s_running
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "Network", "s_running");
            }
        }

        public static bool s_shouldBeConnectedToAurora
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "Network", "s_shouldBeConnectedToAurora");
            }
        }

        public static UnityUrlDownloader s_urlDownloader
        {
            get
            {
                return MonoClass.smethod_7<UnityUrlDownloader>(TritonHs.MainAssemblyPath, "", "Network", "s_urlDownloader");
            }
        }

        public static string TutorialServer
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Network", "TutorialServer");
            }
        }

        [Attribute38("Network.AccountLicenseAchieveResponse")]
        public class AccountLicenseAchieveResponse : MonoClass
        {
            public AccountLicenseAchieveResponse(IntPtr address) : this(address, "AccountLicenseAchieveResponse")
            {
            }

            public AccountLicenseAchieveResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public int Achieve
            {
                get
                {
                    return base.method_11<int>("get_Achieve", Array.Empty<object>());
                }
            }

            public AchieveResult Result
            {
                get
                {
                    return base.method_11<AchieveResult>("get_Result", Array.Empty<object>());
                }
            }

            public enum AchieveResult
            {
                COMPLETE = 4,
                IN_PROGRESS = 3,
                INVALID_ACHIEVE = 1,
                NOT_ACTIVE = 2,
                STATUS_UNKNOWN = 5
            }
        }

        [Attribute38("Network.AchieveList")]
        public class AchieveList : MonoClass
        {
            public AchieveList(IntPtr address) : this(address, "AchieveList")
            {
            }

            public AchieveList(IntPtr address, string className) : base(address, className)
            {
            }

            public List<Achieve> Achieves
            {
                get
                {
                    Class267<Achieve> class2 = base.method_14<Class267<Achieve>>("get_Achieves", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            [Attribute38("Network.AchieveList.Achieve")]
            public class Achieve : MonoClass
            {
                public Achieve(IntPtr address) : this(address, "Achieve")
                {
                }

                public Achieve(IntPtr address, string className) : base(address, className)
                {
                }

                public int AckProgress
                {
                    get
                    {
                        return base.method_11<int>("get_AckProgress", Array.Empty<object>());
                    }
                }

                public bool Active
                {
                    get
                    {
                        return base.method_11<bool>("get_Active", Array.Empty<object>());
                    }
                }

                public bool CanAck
                {
                    get
                    {
                        return base.method_11<bool>("get_CanAck", Array.Empty<object>());
                    }
                }

                public int CompletionCount
                {
                    get
                    {
                        return base.method_11<int>("get_CompletionCount", Array.Empty<object>());
                    }
                }

                public long DateCompleted
                {
                    get
                    {
                        return base.method_11<long>("get_DateCompleted", Array.Empty<object>());
                    }
                }

                public long DateGiven
                {
                    get
                    {
                        return base.method_11<long>("get_DateGiven", Array.Empty<object>());
                    }
                }

                public int ID
                {
                    get
                    {
                        return base.method_11<int>("get_ID", Array.Empty<object>());
                    }
                }

                public int Progress
                {
                    get
                    {
                        return base.method_11<int>("get_Progress", Array.Empty<object>());
                    }
                }
            }
        }

        [Attribute38("Network.AdventureProgress")]
        public class AdventureProgress : MonoClass
        {
            public AdventureProgress(IntPtr address) : this(address, "AdventureProgress")
            {
            }

            public AdventureProgress(IntPtr address, string className) : base(address, className)
            {
            }

            public int Ack
            {
                get
                {
                    return base.method_11<int>("get_Ack", Array.Empty<object>());
                }
            }

            public ulong Flags
            {
                get
                {
                    return base.method_11<ulong>("get_Flags", Array.Empty<object>());
                }
            }

            public int Progress
            {
                get
                {
                    return base.method_11<int>("get_Progress", Array.Empty<object>());
                }
            }

            public int Wing
            {
                get
                {
                    return base.method_11<int>("get_Wing", Array.Empty<object>());
                }
            }
        }

        public enum AuthResult
        {
            UNKNOWN,
            ALLOWED,
            INVALID,
            SECOND,
            OFFLINE
        }

        [Attribute38("Network.BattleNetLogger")]
        public class BattleNetLogger : MonoClass
        {
            public BattleNetLogger(IntPtr address) : this(address, "BattleNetLogger")
            {
            }

            public BattleNetLogger(IntPtr address, string className) : base(address, className)
            {
            }

            public void Log(Triton.Game.Mapping.LogLevel logLevel, string str)
            {
                object[] objArray1 = new object[] { logLevel, str };
                base.method_8("Log", objArray1);
            }
        }

        [Attribute38("Network.BattlePayConfig")]
        public class BattlePayConfig : MonoClass
        {
            public BattlePayConfig(IntPtr address) : this(address, "BattlePayConfig")
            {
            }

            public BattlePayConfig(IntPtr address, string className) : base(address, className)
            {
            }

            public bool Available
            {
                get
                {
                    return base.method_11<bool>("get_Available", Array.Empty<object>());
                }
            }

            public List<Network.Bundle> Bundles
            {
                get
                {
                    Class267<Network.Bundle> class2 = base.method_14<Class267<Network.Bundle>>("get_Bundles", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public Triton.Game.Mapping.Currency Currency
            {
                get
                {
                    return base.method_11<Triton.Game.Mapping.Currency>("get_Currency", Array.Empty<object>());
                }
            }

            public long GoldCostArena
            {
                get
                {
                    return base.method_11<long>("get_GoldCostArena", Array.Empty<object>());
                }
            }

            public List<Network.GoldCostBooster> GoldCostBoosters
            {
                get
                {
                    Class267<Network.GoldCostBooster> class2 = base.method_14<Class267<Network.GoldCostBooster>>("get_GoldCostBoosters", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public int SecondsBeforeAutoCancel
            {
                get
                {
                    return base.method_11<int>("get_SecondsBeforeAutoCancel", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.BattlePayStatus")]
        public class BattlePayStatus : MonoClass
        {
            public BattlePayStatus(IntPtr address) : this(address, "BattlePayStatus")
            {
            }

            public BattlePayStatus(IntPtr address, string className) : base(address, className)
            {
            }

            public bool BattlePayAvailable
            {
                get
                {
                    return base.method_11<bool>("get_BattlePayAvailable", Array.Empty<object>());
                }
            }

            public Triton.Game.Mapping.Currency CurrencyType
            {
                get
                {
                    return base.method_11<Triton.Game.Mapping.Currency>("get_CurrencyType", Array.Empty<object>());
                }
            }

            public string ProductID
            {
                get
                {
                    return base.method_13("get_ProductID", Array.Empty<object>());
                }
            }

            public Network.PurchaseErrorInfo PurchaseError
            {
                get
                {
                    return base.method_14<Network.PurchaseErrorInfo>("get_PurchaseError", Array.Empty<object>());
                }
            }

            public PurchaseState State
            {
                get
                {
                    return base.method_11<PurchaseState>("get_State", Array.Empty<object>());
                }
            }

            public string ThirdPartyID
            {
                get
                {
                    return base.method_13("get_ThirdPartyID", Array.Empty<object>());
                }
            }

            public long TransactionID
            {
                get
                {
                    return base.method_11<long>("get_TransactionID", Array.Empty<object>());
                }
            }

            public enum PurchaseState
            {
                CHECK_RESULTS = 1,
                ERROR = 2,
                READY = 0,
                UNKNOWN = -1
            }
        }

        [Attribute38("Network.BeginDraft")]
        public class BeginDraft : MonoClass
        {
            public BeginDraft(IntPtr address) : this(address, "BeginDraft")
            {
            }

            public BeginDraft(IntPtr address, string className) : base(address, className)
            {
            }

            public long DeckID
            {
                get
                {
                    return base.method_11<long>("get_DeckID", Array.Empty<object>());
                }
            }

            public List<NetCache.CardDefinition> Heroes
            {
                get
                {
                    Class267<NetCache.CardDefinition> class2 = base.method_14<Class267<NetCache.CardDefinition>>("get_Heroes", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        public enum BnetLoginState
        {
            BATTLE_NET_UNKNOWN,
            BATTLE_NET_LOGGING_IN,
            BATTLE_NET_TIMEOUT,
            BATTLE_NET_LOGIN_FAILED,
            BATTLE_NET_LOGGED_IN
        }

        public enum BoosterSource
        {
            ARENA_REWARD = 3,
            BOUGHT = 4,
            BOUGHT_GOLD = 11,
            CS_GIFT = 8,
            LICENSED = 6,
            QUEST_REWARD = 10,
            UNKNOWN = 0
        }

        [Attribute38("Network.Bundle")]
        public class Bundle : MonoClass
        {
            public Bundle(IntPtr address) : this(address, "Bundle")
            {
            }

            public Bundle(IntPtr address, string className) : base(address, className)
            {
            }

            public bool IsFree()
            {
                return base.method_11<bool>("IsFree", Array.Empty<object>());
            }

            public bool IsPreOrder()
            {
                return base.method_11<bool>("IsPreOrder", Array.Empty<object>());
            }

            public string AmazonID
            {
                get
                {
                    return base.method_13("get_AmazonID", Array.Empty<object>());
                }
            }

            public string AppleID
            {
                get
                {
                    return base.method_13("get_AppleID", Array.Empty<object>());
                }
            }

            public double Cost
            {
                get
                {
                    return base.method_11<double>("get_Cost", Array.Empty<object>());
                }
            }

            public long GoldCost
            {
                get
                {
                    return base.method_11<long>("get_GoldCost", Array.Empty<object>());
                }
            }

            public string GooglePlayID
            {
                get
                {
                    return base.method_13("get_GooglePlayID", Array.Empty<object>());
                }
            }

            public List<Network.BundleItem> Items
            {
                get
                {
                    Class267<Network.BundleItem> class2 = base.method_14<Class267<Network.BundleItem>>("get_Items", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public SpecialEventType ProductEvent
            {
                get
                {
                    return base.method_11<SpecialEventType>("get_ProductEvent", Array.Empty<object>());
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

        [Attribute38("Network.BundleItem")]
        public class BundleItem : MonoClass
        {
            public BundleItem(IntPtr address) : this(address, "BundleItem")
            {
            }

            public BundleItem(IntPtr address, string className) : base(address, className)
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

            public int ProductData
            {
                get
                {
                    return base.method_11<int>("get_ProductData", Array.Empty<object>());
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

        [Attribute38("Network.CanceledQuest")]
        public class CanceledQuest : MonoClass
        {
            public CanceledQuest(IntPtr address) : this(address, "CanceledQuest")
            {
            }

            public CanceledQuest(IntPtr address, string className) : base(address, className)
            {
            }

            public int AchieveID
            {
                get
                {
                    return base.method_11<int>("get_AchieveID", Array.Empty<object>());
                }
            }

            public bool Canceled
            {
                get
                {
                    return base.method_11<bool>("get_Canceled", Array.Empty<object>());
                }
            }

            public long NextQuestCancelDate
            {
                get
                {
                    return base.method_11<long>("get_NextQuestCancelDate", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.CardBackResponse")]
        public class CardBackResponse : MonoClass
        {
            public CardBackResponse(IntPtr address) : this(address, "CardBackResponse")
            {
            }

            public CardBackResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public int CardBack
            {
                get
                {
                    return base.method_11<int>("get_CardBack", Array.Empty<object>());
                }
            }

            public bool Success
            {
                get
                {
                    return base.method_11<bool>("get_Success", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.CardQuote")]
        public class CardQuote : MonoClass
        {
            public CardQuote(IntPtr address) : this(address, "CardQuote")
            {
            }

            public CardQuote(IntPtr address, string className) : base(address, className)
            {
            }

            public int AssetID
            {
                get
                {
                    return base.method_11<int>("get_AssetID", Array.Empty<object>());
                }
            }

            public int BuyPrice
            {
                get
                {
                    return base.method_11<int>("get_BuyPrice", Array.Empty<object>());
                }
            }

            public int SaleValue
            {
                get
                {
                    return base.method_11<int>("get_SaleValue", Array.Empty<object>());
                }
            }

            public QuoteState Status
            {
                get
                {
                    return base.method_11<QuoteState>("get_Status", Array.Empty<object>());
                }
            }

            public enum QuoteState
            {
                SUCCESS,
                UNKNOWN_ERROR
            }
        }

        [Attribute38("Network.CardSaleResult")]
        public class CardSaleResult : MonoClass
        {
            public CardSaleResult(IntPtr address) : this(address, "CardSaleResult")
            {
            }

            public CardSaleResult(IntPtr address, string className) : base(address, className)
            {
            }

            public SaleResult Action
            {
                get
                {
                    return base.method_11<SaleResult>("get_Action", Array.Empty<object>());
                }
            }

            public int Amount
            {
                get
                {
                    return base.method_11<int>("get_Amount", Array.Empty<object>());
                }
            }

            public int AssetID
            {
                get
                {
                    return base.method_11<int>("get_AssetID", Array.Empty<object>());
                }
            }

            public string AssetName
            {
                get
                {
                    return base.method_13("get_AssetName", Array.Empty<object>());
                }
            }

            public int Count
            {
                get
                {
                    return base.method_11<int>("get_Count", Array.Empty<object>());
                }
            }

            public bool Nerfed
            {
                get
                {
                    return base.method_11<bool>("get_Nerfed", Array.Empty<object>());
                }
            }

            public TAG_PREMIUM Premium
            {
                get
                {
                    return base.method_11<TAG_PREMIUM>("get_Premium", Array.Empty<object>());
                }
            }

            public int UnitBuyPrice
            {
                get
                {
                    return base.method_11<int>("get_UnitBuyPrice", Array.Empty<object>());
                }
            }

            public int UnitSellPrice
            {
                get
                {
                    return base.method_11<int>("get_UnitSellPrice", Array.Empty<object>());
                }
            }

            public enum SaleResult
            {
                CARD_WAS_BOUGHT = 3,
                CARD_WAS_SOLD = 2,
                FAILED_EVENT_NOT_ACTIVE = 8,
                FAILED_NO_PERMISSION = 7,
                FAILED_WRONG_BUY_PRICE = 6,
                FAILED_WRONG_SELL_PRICE = 5,
                GENERIC_FAILURE = 1,
                SOULBOUND = 4
            }
        }

        [Attribute38("Network.CardUserData")]
        public class CardUserData : MonoClass
        {
            public CardUserData(IntPtr address) : this(address, "CardUserData")
            {
            }

            public CardUserData(IntPtr address, string className) : base(address, className)
            {
            }

            public int Count
            {
                get
                {
                    return base.method_11<int>("get_Count", Array.Empty<object>());
                }
            }

            public int DbId
            {
                get
                {
                    return base.method_11<int>("get_DbId", Array.Empty<object>());
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

        [Attribute38("Network.DBAction")]
        public class DBAction : MonoClass
        {
            public DBAction(IntPtr address) : this(address, "DBAction")
            {
            }

            public DBAction(IntPtr address, string className) : base(address, className)
            {
            }

            public ActionType Action
            {
                get
                {
                    return base.method_11<ActionType>("get_Action", Array.Empty<object>());
                }
            }

            public long MetaData
            {
                get
                {
                    return base.method_11<long>("get_MetaData", Array.Empty<object>());
                }
            }

            public ResultType Result
            {
                get
                {
                    return base.method_11<ResultType>("get_Result", Array.Empty<object>());
                }
            }

            public enum ActionType
            {
                UNKNOWN,
                GET_DECK,
                CREATE_DECK,
                RENAME_DECK,
                DELETE_DECK,
                SET_DECK,
                OPEN_BOOSTER,
                GAMES_INFO
            }

            public enum ResultType
            {
                UNKNOWN,
                SUCCESS,
                NOT_OWNED,
                CONSTRAINT
            }
        }

        [Attribute38("Network.DebugConsoleResponse")]
        public class DebugConsoleResponse : MonoClass
        {
            public DebugConsoleResponse(IntPtr address) : this(address, "DebugConsoleResponse")
            {
            }

            public DebugConsoleResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public string Response
            {
                get
                {
                    return base.method_13("get_Response", Array.Empty<object>());
                }
            }

            public int Type
            {
                get
                {
                    return base.method_11<int>("get_Type", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.DeckCard")]
        public class DeckCard : MonoClass
        {
            public DeckCard(IntPtr address) : this(address, "DeckCard")
            {
            }

            public DeckCard(IntPtr address, string className) : base(address, className)
            {
            }

            public long Card
            {
                get
                {
                    return base.method_11<long>("get_Card", Array.Empty<object>());
                }
            }

            public long Deck
            {
                get
                {
                    return base.method_11<long>("get_Deck", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.DeckContents")]
        public class DeckContents : MonoClass
        {
            public DeckContents(IntPtr address) : this(address, "DeckContents")
            {
            }

            public DeckContents(IntPtr address, string className) : base(address, className)
            {
            }

            public List<Network.CardUserData> Cards
            {
                get
                {
                    Class267<Network.CardUserData> class2 = base.method_14<Class267<Network.CardUserData>>("get_Cards", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public long Deck
            {
                get
                {
                    return base.method_11<long>("get_Deck", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.DeckName")]
        public class DeckName : MonoClass
        {
            public DeckName(IntPtr address) : this(address, "DeckName")
            {
            }

            public DeckName(IntPtr address, string className) : base(address, className)
            {
            }

            public long Deck
            {
                get
                {
                    return base.method_11<long>("get_Deck", Array.Empty<object>());
                }
            }

            public string Name
            {
                get
                {
                    return base.method_13("get_Name", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.DraftChoicesAndContents")]
        public class DraftChoicesAndContents : MonoClass
        {
            public DraftChoicesAndContents(IntPtr address) : this(address, "DraftChoicesAndContents")
            {
            }

            public DraftChoicesAndContents(IntPtr address, string className) : base(address, className)
            {
            }

            public List<NetCache.CardDefinition> Choices
            {
                get
                {
                    Class267<NetCache.CardDefinition> class2 = base.method_14<Class267<NetCache.CardDefinition>>("get_Choices", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public Network.DeckContents DeckInfo
            {
                get
                {
                    return base.method_14<Network.DeckContents>("get_DeckInfo", Array.Empty<object>());
                }
            }

            public NetCache.CardDefinition Hero
            {
                get
                {
                    return base.method_14<NetCache.CardDefinition>("get_Hero", Array.Empty<object>());
                }
            }

            public int Losses
            {
                get
                {
                    return base.method_11<int>("get_Losses", Array.Empty<object>());
                }
            }

            public int MaxWins
            {
                get
                {
                    return base.method_11<int>("get_MaxWins", Array.Empty<object>());
                }
            }

            public int Slot
            {
                get
                {
                    return base.method_11<int>("get_Slot", Array.Empty<object>());
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

        [Attribute38("Network.DraftChosen")]
        public class DraftChosen : MonoClass
        {
            public DraftChosen(IntPtr address) : this(address, "DraftChosen")
            {
            }

            public DraftChosen(IntPtr address, string className) : base(address, className)
            {
            }

            public NetCache.CardDefinition ChosenCard
            {
                get
                {
                    return base.method_14<NetCache.CardDefinition>("get_ChosenCard", Array.Empty<object>());
                }
            }

            public List<NetCache.CardDefinition> NextChoices
            {
                get
                {
                    Class267<NetCache.CardDefinition> class2 = base.method_14<Class267<NetCache.CardDefinition>>("get_NextChoices", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        public enum DraftError
        {
            DE_UNKNOWN,
            DE_NO_LICENSE,
            DE_RETIRE_FIRST,
            DE_NOT_IN_DRAFT,
            DE_BAD_DECK,
            DE_BAD_SLOT,
            DE_BAD_INDEX,
            DE_NOT_IN_DRAFT_BUT_COULD_BE,
            DE_FEATURE_DISABLED
        }

        [Attribute38("Network.DraftRetired")]
        public class DraftRetired : MonoClass
        {
            public DraftRetired(IntPtr address) : this(address, "DraftRetired")
            {
            }

            public DraftRetired(IntPtr address, string className) : base(address, className)
            {
            }

            public long Deck
            {
                get
                {
                    return base.method_11<long>("get_Deck", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.EntitiesChosen")]
        public class EntitiesChosen : MonoClass
        {
            public EntitiesChosen(IntPtr address) : this(address, "EntitiesChosen")
            {
            }

            public EntitiesChosen(IntPtr address, string className) : base(address, className)
            {
            }

            public List<int> Entities
            {
                get
                {
                    Class266<int> class2 = base.method_14<Class266<int>>("get_Entities", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public int ID
            {
                get
                {
                    return base.method_11<int>("get_ID", Array.Empty<object>());
                }
            }

            public int PlayerId
            {
                get
                {
                    return base.method_11<int>("get_PlayerId", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.Entity")]
        public class Entity : MonoClass
        {
            public Entity(IntPtr address) : this(address, "Entity")
            {
            }

            public Entity(IntPtr address, string className) : base(address, className)
            {
            }

            public static Network.Entity CreateFromProto(Network.Entity src)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { src };
                return MonoClass.smethod_16<Network.Entity>(TritonHs.MainAssemblyPath, "", "Entity", "CreateFromProto", enumArray1, objArray1);
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public string CardID
            {
                get
                {
                    return base.method_13("get_CardID", Array.Empty<object>());
                }
            }

            public int ID
            {
                get
                {
                    return base.method_11<int>("get_ID", Array.Empty<object>());
                }
            }

            public List<Tag> Tags
            {
                get
                {
                    Class267<Tag> class2 = base.method_14<Class267<Tag>>("get_Tags", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            [Attribute38("Network.Entity.Tag")]
            public class Tag : MonoClass
            {
                public Tag(IntPtr address) : this(address, "Tag")
                {
                }

                public Tag(IntPtr address, string className) : base(address, className)
                {
                }

                public int Name
                {
                    get
                    {
                        return base.method_11<int>("get_Name", Array.Empty<object>());
                    }
                }

                public int Value
                {
                    get
                    {
                        return base.method_11<int>("get_Value", Array.Empty<object>());
                    }
                }
            }
        }

        [Attribute38("Network.EntityChoices")]
        public class EntityChoices : MonoClass
        {
            public EntityChoices(IntPtr address) : this(address, "EntityChoices")
            {
            }

            public EntityChoices(IntPtr address, string className) : base(address, className)
            {
            }

            public CHOICE_TYPE ChoiceType
            {
                get
                {
                    return base.method_11<CHOICE_TYPE>("get_ChoiceType", Array.Empty<object>());
                }
            }

            public int CountMax
            {
                get
                {
                    return base.method_11<int>("get_CountMax", Array.Empty<object>());
                }
            }

            public int CountMin
            {
                get
                {
                    return base.method_11<int>("get_CountMin", Array.Empty<object>());
                }
            }

            public List<int> Entities
            {
                get
                {
                    Class266<int> class2 = base.method_14<Class266<int>>("get_Entities", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public int ID
            {
                get
                {
                    return base.method_11<int>("get_ID", Array.Empty<object>());
                }
            }

            public int PlayerId
            {
                get
                {
                    return base.method_11<int>("get_PlayerId", Array.Empty<object>());
                }
            }

            public int Source
            {
                get
                {
                    return base.method_11<int>("get_Source", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.GameCancelInfo")]
        public class GameCancelInfo : MonoClass
        {
            public GameCancelInfo(IntPtr address) : this(address, "GameCancelInfo")
            {
            }

            public GameCancelInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public Reason CancelReason
            {
                get
                {
                    return base.method_11<Reason>("get_CancelReason", Array.Empty<object>());
                }
            }

            public enum Reason
            {
                OPPONENT_TIMEOUT = 1
            }
        }

        [Attribute38("Network.GameEnd")]
        public class GameEnd : MonoClass
        {
            public GameEnd(IntPtr address) : this(address, "GameEnd")
            {
            }

            public GameEnd(IntPtr address, string className) : base(address, className)
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

        [Attribute38("Network.GameSetup")]
        public class GameSetup : MonoClass
        {
            public GameSetup(IntPtr address) : this(address, "GameSetup")
            {
            }

            public GameSetup(IntPtr address, string className) : base(address, className)
            {
            }

            public int Board
            {
                get
                {
                    return base.method_11<int>("get_Board", Array.Empty<object>());
                }
            }

            public int MaxFriendlyMinionsPerPlayer
            {
                get
                {
                    return base.method_11<int>("get_MaxFriendlyMinionsPerPlayer", Array.Empty<object>());
                }
            }

            public int MaxSecretsPerPlayer
            {
                get
                {
                    return base.method_11<int>("get_MaxSecretsPerPlayer", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.GenericResponse")]
        public class GenericResponse : MonoClass
        {
            public GenericResponse(IntPtr address) : this(address, "GenericResponse")
            {
            }

            public GenericResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public object GenericData
            {
                get
                {
                    return base.method_14<object>("get_GenericData", Array.Empty<object>());
                }
            }

            public int RequestId
            {
                get
                {
                    return base.method_11<int>("get_RequestId", Array.Empty<object>());
                }
            }

            public int RequestSubId
            {
                get
                {
                    return base.method_11<int>("get_RequestSubId", Array.Empty<object>());
                }
            }

            public Result ResultCode
            {
                get
                {
                    return base.method_11<Result>("get_ResultCode", Array.Empty<object>());
                }
            }

            public enum Result
            {
                DATA_MIGRATION_ERROR = 0x69,
                DB_ERROR = 0x66,
                FIRST_ERROR = 100,
                INTERNAL_ERROR = 0x65,
                INVALID_REQUEST = 0x67,
                LOGIN_LOAD = 0x68,
                OK = 0,
                REQUEST_COMPLETE = 2,
                REQUEST_IN_PROCESS = 1
            }
        }

        [Attribute38("Network.GoldCostBooster")]
        public class GoldCostBooster : MonoClass
        {
            public GoldCostBooster(IntPtr address) : this(address, "GoldCostBooster")
            {
            }

            public GoldCostBooster(IntPtr address, string className) : base(address, className)
            {
            }

            public long Cost
            {
                get
                {
                    return base.method_11<long>("get_Cost", Array.Empty<object>());
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

        [Attribute38("Network.HistActionEnd")]
        public class HistActionEnd : Network.PowerHistory
        {
            public HistActionEnd(IntPtr address) : this(address, "HistActionEnd")
            {
            }

            public HistActionEnd(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("Network.HistActionStart")]
        public class HistActionStart : Network.PowerHistory
        {
            public HistActionStart(IntPtr address) : this(address, "HistActionStart")
            {
            }

            public HistActionStart(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public string EffectCardId
            {
                get
                {
                    return base.method_13("get_EffectCardId", Array.Empty<object>());
                }
            }

            public int EffectIndex
            {
                get
                {
                    return base.method_11<int>("get_EffectIndex", Array.Empty<object>());
                }
            }

            public int Entity
            {
                get
                {
                    return base.method_11<int>("get_Entity", Array.Empty<object>());
                }
            }

            public int Target
            {
                get
                {
                    return base.method_11<int>("get_Target", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.HistCreateGame")]
        public class HistCreateGame : Network.PowerHistory
        {
            public HistCreateGame(IntPtr address) : this(address, "HistCreateGame")
            {
            }

            public HistCreateGame(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public Network.Entity Game
            {
                get
                {
                    return base.method_14<Network.Entity>("get_Game", Array.Empty<object>());
                }
            }

            public List<PlayerData> Players
            {
                get
                {
                    Class267<PlayerData> class2 = base.method_14<Class267<PlayerData>>("get_Players", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            [Attribute38("Network.HistCreateGame.PlayerData")]
            public class PlayerData : MonoClass
            {
                public PlayerData(IntPtr address) : this(address, "PlayerData")
                {
                }

                public PlayerData(IntPtr address, string className) : base(address, className)
                {
                }

                public static Network.HistCreateGame.PlayerData CreateFromProto(Triton.Game.Mapping.Player src)
                {
                    object[] objArray1 = new object[] { src };
                    return MonoClass.smethod_15<Network.HistCreateGame.PlayerData>(TritonHs.MainAssemblyPath, "", "PlayerData", "CreateFromProto", objArray1);
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

                public int ID
                {
                    get
                    {
                        return base.method_11<int>("get_ID", Array.Empty<object>());
                    }
                }

                public Network.Entity Player
                {
                    get
                    {
                        return base.method_14<Network.Entity>("get_Player", Array.Empty<object>());
                    }
                }
            }
        }

        [Attribute38("Network.HistFullEntity")]
        public class HistFullEntity : Network.PowerHistory
        {
            public HistFullEntity(IntPtr address) : this(address, "HistFullEntity")
            {
            }

            public HistFullEntity(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public Triton.Game.Mapping.Network.Entity Entity
            {
                get
                {
                    return base.method_14<Triton.Game.Mapping.Network.Entity>("get_Entity", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.HistHideEntity")]
        public class HistHideEntity : Network.PowerHistory
        {
            public HistHideEntity(IntPtr address) : this(address, "HistHideEntity")
            {
            }

            public HistHideEntity(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public int Entity
            {
                get
                {
                    return base.method_11<int>("get_Entity", Array.Empty<object>());
                }
            }

            public int Zone
            {
                get
                {
                    return base.method_11<int>("get_Zone", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.HistMetaData")]
        public class HistMetaData : Network.PowerHistory
        {
            public HistMetaData(IntPtr address) : this(address, "HistMetaData")
            {
            }

            public HistMetaData(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public int Data
            {
                get
                {
                    return base.method_11<int>("get_Data", Array.Empty<object>());
                }
            }

            public List<int> Info
            {
                get
                {
                    Class266<int> class2 = base.method_14<Class266<int>>("get_Info", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        [Attribute38("Network.HistShowEntity")]
        public class HistShowEntity : Network.PowerHistory
        {
            public HistShowEntity(IntPtr address) : this(address, "HistShowEntity")
            {
            }

            public HistShowEntity(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public Triton.Game.Mapping.Network.Entity Entity
            {
                get
                {
                    return base.method_14<Triton.Game.Mapping.Network.Entity>("get_Entity", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.HistTagChange")]
        public class HistTagChange : Network.PowerHistory
        {
            public HistTagChange(IntPtr address) : this(address, "HistTagChange")
            {
            }

            public HistTagChange(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public int Entity
            {
                get
                {
                    return base.method_11<int>("get_Entity", Array.Empty<object>());
                }
            }

            public int Tag
            {
                get
                {
                    return base.method_11<int>("get_Tag", Array.Empty<object>());
                }
            }

            public int Value
            {
                get
                {
                    return base.method_11<int>("get_Value", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.HSClientInterface")]
        public class HSClientInterface : MonoClass
        {
            public HSClientInterface(IntPtr address) : this(address, "HSClientInterface")
            {
            }

            public HSClientInterface(IntPtr address, string className) : base(address, className)
            {
            }

            public string GetAuroraVersionName()
            {
                return base.method_13("GetAuroraVersionName", Array.Empty<object>());
            }

            public string GetBasePersistentDataPath()
            {
                return base.method_13("GetBasePersistentDataPath", Array.Empty<object>());
            }

            public bool GetDisableConnectionMetering()
            {
                return base.method_11<bool>("GetDisableConnectionMetering", Array.Empty<object>());
            }

            public string GetLocaleName()
            {
                return base.method_13("GetLocaleName", Array.Empty<object>());
            }

            public string GetPlatformName()
            {
                return base.method_13("GetPlatformName", Array.Empty<object>());
            }

            public string GetTemporaryCachePath()
            {
                return base.method_13("GetTemporaryCachePath", Array.Empty<object>());
            }

            public string GetUserAgent()
            {
                return base.method_13("GetUserAgent", Array.Empty<object>());
            }

            public string GetVersion()
            {
                return base.method_13("GetVersion", Array.Empty<object>());
            }

            public bool IsVersionInt()
            {
                return base.method_11<bool>("IsVersionInt", Array.Empty<object>());
            }

            public string s_tempCachePath
            {
                get
                {
                    return base.method_4("s_tempCachePath");
                }
            }
        }

        [Attribute38("Network.MassDisenchantResponse")]
        public class MassDisenchantResponse : MonoClass
        {
            public MassDisenchantResponse(IntPtr address) : this(address, "MassDisenchantResponse")
            {
            }

            public MassDisenchantResponse(IntPtr address, string className) : base(address, className)
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

        [Attribute38("Network.Notification")]
        public class Notification : MonoClass
        {
            public Notification(IntPtr address) : this(address, "Notification")
            {
            }

            public Notification(IntPtr address, string className) : base(address, className)
            {
            }

            public Type NotificationType
            {
                get
                {
                    return base.method_11<Type>("get_NotificationType", Array.Empty<object>());
                }
            }

            public enum Type
            {
                IN_HAND_CARD_CAP = 1,
                MANA_CAP = 2
            }
        }

        [Attribute38("Network.Options")]
        public class Options : MonoClass
        {
            public Options(IntPtr address) : this(address, "Options")
            {
            }

            public Options(IntPtr address, string className) : base(address, className)
            {
            }

            public void CopyFrom(Network.Options options)
            {
                object[] objArray1 = new object[] { options };
                base.method_8("CopyFrom", objArray1);
            }

            public int ID
            {
                get
                {
                    return base.method_11<int>("get_ID", Array.Empty<object>());
                }
            }

            public List<Option> List
            {
                get
                {
                    Class267<Option> class2 = base.method_14<Class267<Option>>("get_List", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            [Attribute38("Network.Options.Option")]
            public class Option : MonoClass
            {
                public Option(IntPtr address) : this(address, "Option")
                {
                }

                public Option(IntPtr address, string className) : base(address, className)
                {
                }

                public void CopyFrom(Network.Options.Option option)
                {
                    object[] objArray1 = new object[] { option };
                    base.method_8("CopyFrom", objArray1);
                }

                public SubOption Main
                {
                    get
                    {
                        return base.method_14<SubOption>("get_Main", Array.Empty<object>());
                    }
                }

                public List<SubOption> Subs
                {
                    get
                    {
                        Class267<SubOption> class2 = base.method_14<Class267<SubOption>>("get_Subs", Array.Empty<object>());
                        if (class2 != null)
                        {
                            return class2.method_25();
                        }
                        return null;
                    }
                }

                public OptionType Type
                {
                    get
                    {
                        return base.method_11<OptionType>("get_Type", Array.Empty<object>());
                    }
                }

                public enum OptionType
                {
                    END_TURN = 2,
                    PASS = 1,
                    POWER = 3
                }

                [Attribute38("Network.Options.Option.SubOption")]
                public class SubOption : MonoClass
                {
                    public SubOption(IntPtr address) : this(address, "SubOption")
                    {
                    }

                    public SubOption(IntPtr address, string className) : base(address, className)
                    {
                    }

                    public void CopyFrom(Network.Options.Option.SubOption subOption)
                    {
                        object[] objArray1 = new object[] { subOption };
                        base.method_8("CopyFrom", objArray1);
                    }

                    public int ID
                    {
                        get
                        {
                            return base.method_11<int>("get_ID", Array.Empty<object>());
                        }
                    }

                    public List<int> Targets
                    {
                        get
                        {
                            Class266<int> class2 = base.method_14<Class266<int>>("get_Targets", Array.Empty<object>());
                            if (class2 != null)
                            {
                                return class2.method_25();
                            }
                            return null;
                        }
                    }
                }
            }
        }

        [Attribute38("Network.PowerHistory")]
        public class PowerHistory : MonoClass
        {
            public PowerHistory(IntPtr address) : this(address, "PowerHistory")
            {
            }

            public PowerHistory(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public Network.PowerType Type
            {
                get
                {
                    return base.method_11<Network.PowerType>("get_Type", Array.Empty<object>());
                }
            }
        }

        public enum PowerType
        {
            ACTION_END = 6,
            ACTION_START = 5,
            CREATE_GAME = 7,
            FULL_ENTITY = 1,
            HIDE_ENTITY = 3,
            META_DATA = 8,
            SHOW_ENTITY = 2,
            TAG_CHANGE = 4
        }

        [Attribute38("Network.ProfileNotices")]
        public class ProfileNotices : MonoClass
        {
            public ProfileNotices(IntPtr address) : this(address, "ProfileNotices")
            {
            }

            public ProfileNotices(IntPtr address, string className) : base(address, className)
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

        [Attribute38("Network.PurchaseCanceledResponse")]
        public class PurchaseCanceledResponse : MonoClass
        {
            public PurchaseCanceledResponse(IntPtr address) : this(address, "PurchaseCanceledResponse")
            {
            }

            public PurchaseCanceledResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public Triton.Game.Mapping.Currency CurrencyType
            {
                get
                {
                    return base.method_11<Triton.Game.Mapping.Currency>("get_CurrencyType", Array.Empty<object>());
                }
            }

            public string ProductID
            {
                get
                {
                    return base.method_13("get_ProductID", Array.Empty<object>());
                }
            }

            public CancelResult Result
            {
                get
                {
                    return base.method_11<CancelResult>("get_Result", Array.Empty<object>());
                }
            }

            public long TransactionID
            {
                get
                {
                    return base.method_11<long>("get_TransactionID", Array.Empty<object>());
                }
            }

            public enum CancelResult
            {
                SUCCESS,
                NOT_ALLOWED,
                NOTHING_TO_CANCEL
            }
        }

        [Attribute38("Network.PurchaseErrorInfo")]
        public class PurchaseErrorInfo : MonoClass
        {
            public PurchaseErrorInfo(IntPtr address) : this(address, "PurchaseErrorInfo")
            {
            }

            public PurchaseErrorInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public ErrorType Error
            {
                get
                {
                    return base.method_11<ErrorType>("get_Error", Array.Empty<object>());
                }
            }

            public string ErrorCode
            {
                get
                {
                    return base.method_13("get_ErrorCode", Array.Empty<object>());
                }
            }

            public string PurchaseInProgressProductID
            {
                get
                {
                    return base.method_13("get_PurchaseInProgressProductID", Array.Empty<object>());
                }
            }

            public enum ErrorType
            {
                BP_GENERIC_FAIL = 100,
                BP_INVALID_CC_EXPIRY = 0x65,
                BP_NO_VALID_PAYMENT = 0x67,
                BP_PARENTAL_CONTROL = 0x6c,
                BP_PAYMENT_AUTH = 0x68,
                BP_PRODUCT_UNIQUENESS_VIOLATED = 0x70,
                BP_PROVIDER_DENIED = 0x69,
                BP_PURCHASE_BAN = 0x6a,
                BP_REGION_IS_DOWN = 0x71,
                BP_RISK_ERROR = 0x66,
                BP_SPENDING_LIMIT = 0x6b,
                BP_THIRD_PARTY_BAD_RECEIPT = 110,
                BP_THIRD_PARTY_RECEIPT_USED = 0x6f,
                BP_THROTTLED = 0x6d,
                CANCELED = 11,
                DATABASE = 5,
                DUPLICATE_LICENSE = 7,
                E_BP_CHALLENGE_ID_FAILED_VERIFICATION = 0x74,
                E_BP_GENERIC_FAIL_RETRY_CONTACT_CS_IF_PERSISTS = 0x73,
                FAILED_RISK = 10,
                INVALID_BNET = 2,
                INVALID_QUANTITY = 6,
                NO_ACTIVE_BPAY = 9,
                PRODUCT_ALREADY_OWNED = 0x11,
                PRODUCT_EVENT_HAS_ENDED = 0x13,
                PRODUCT_NA = 15,
                PURCHASE_IN_PROGRESS = 4,
                REQUEST_NOT_SENT = 8,
                RISK_TIMEOUT = 0x10,
                SERVICE_NA = 3,
                STILL_IN_PROGRESS = 1,
                SUCCESS = 0,
                UNKNOWN = -1,
                WAIT_CONFIRM = 13,
                WAIT_MOP = 12,
                WAIT_RISK = 14,
                WAIT_THIRD_PARTY_RECEIPT = 0x12
            }
        }

        [Attribute38("Network.PurchaseMethod")]
        public class PurchaseMethod : MonoClass
        {
            public PurchaseMethod(IntPtr address) : this(address, "PurchaseMethod")
            {
            }

            public PurchaseMethod(IntPtr address, string className) : base(address, className)
            {
            }

            public string ChallengeID
            {
                get
                {
                    return base.method_13("get_ChallengeID", Array.Empty<object>());
                }
            }

            public string ChallengeURL
            {
                get
                {
                    return base.method_13("get_ChallengeURL", Array.Empty<object>());
                }
            }

            public Triton.Game.Mapping.Currency Currency
            {
                get
                {
                    return base.method_11<Triton.Game.Mapping.Currency>("get_Currency", Array.Empty<object>());
                }
            }

            public bool IsZeroCostLicense
            {
                get
                {
                    return base.method_11<bool>("get_IsZeroCostLicense", Array.Empty<object>());
                }
            }

            public string ProductID
            {
                get
                {
                    return base.method_13("get_ProductID", Array.Empty<object>());
                }
            }

            public Network.PurchaseErrorInfo PurchaseError
            {
                get
                {
                    return base.method_14<Network.PurchaseErrorInfo>("get_PurchaseError", Array.Empty<object>());
                }
            }

            public int Quantity
            {
                get
                {
                    return base.method_11<int>("get_Quantity", Array.Empty<object>());
                }
            }

            public long TransactionID
            {
                get
                {
                    return base.method_11<long>("get_TransactionID", Array.Empty<object>());
                }
            }

            public bool UseEBalance
            {
                get
                {
                    return base.method_11<bool>("get_UseEBalance", Array.Empty<object>());
                }
            }

            public string WalletName
            {
                get
                {
                    return base.method_13("get_WalletName", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.PurchaseResponse")]
        public class PurchaseResponse : MonoClass
        {
            public PurchaseResponse(IntPtr address) : this(address, "PurchaseResponse")
            {
            }

            public PurchaseResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public Triton.Game.Mapping.Currency CurrencyType
            {
                get
                {
                    return base.method_11<Triton.Game.Mapping.Currency>("get_CurrencyType", Array.Empty<object>());
                }
            }

            public string ProductID
            {
                get
                {
                    return base.method_13("get_ProductID", Array.Empty<object>());
                }
            }

            public Network.PurchaseErrorInfo PurchaseError
            {
                get
                {
                    return base.method_14<Network.PurchaseErrorInfo>("get_PurchaseError", Array.Empty<object>());
                }
            }

            public string ThirdPartyID
            {
                get
                {
                    return base.method_13("get_ThirdPartyID", Array.Empty<object>());
                }
            }

            public long TransactionID
            {
                get
                {
                    return base.method_11<long>("get_TransactionID", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.PurchaseViaGoldResponse")]
        public class PurchaseViaGoldResponse : MonoClass
        {
            public PurchaseViaGoldResponse(IntPtr address) : this(address, "PurchaseViaGoldResponse")
            {
            }

            public PurchaseViaGoldResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public ErrorType Error
            {
                get
                {
                    return base.method_11<ErrorType>("get_Error", Array.Empty<object>());
                }
            }

            public long GoldUsed
            {
                get
                {
                    return base.method_11<long>("get_GoldUsed", Array.Empty<object>());
                }
            }

            public enum ErrorType
            {
                FEATURE_NA = 4,
                INSUFFICIENT_GOLD = 2,
                INVALID_QUANTITY = 5,
                PRODUCT_NA = 3,
                SUCCESS = 1,
                UNKNOWN = -1
            }
        }

        [Attribute38("Network.QueueInfo")]
        public class QueueInfo : MonoClass
        {
            public QueueInfo(IntPtr address) : this(address, "QueueInfo")
            {
            }

            public QueueInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public long end
            {
                get
                {
                    return base.method_2<long>("end");
                }
            }

            public int position
            {
                get
                {
                    return base.method_2<int>("position");
                }
            }

            public long stdev
            {
                get
                {
                    return base.method_2<long>("stdev");
                }
            }
        }

        [Attribute38("Network.RecruitInfo")]
        public class RecruitInfo : MonoClass
        {
            public RecruitInfo(IntPtr address) : this(address, "RecruitInfo")
            {
            }

            public RecruitInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public ulong CreationTimeMicrosec
            {
                get
                {
                    return base.method_11<ulong>("get_CreationTimeMicrosec", Array.Empty<object>());
                }
            }

            public ulong ID
            {
                get
                {
                    return base.method_11<ulong>("get_ID", Array.Empty<object>());
                }
            }

            public int Level
            {
                get
                {
                    return base.method_11<int>("get_Level", Array.Empty<object>());
                }
            }

            public string Nickname
            {
                get
                {
                    return base.method_13("get_Nickname", Array.Empty<object>());
                }
            }

            public int Status
            {
                get
                {
                    return base.method_11<int>("get_Status", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.RequestContext")]
        public class RequestContext : MonoClass
        {
            public RequestContext(IntPtr address) : this(address, "RequestContext")
            {
            }

            public RequestContext(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_pendingResponseId
            {
                get
                {
                    return base.method_2<int>("m_pendingResponseId");
                }
            }

            public int m_requestId
            {
                get
                {
                    return base.method_2<int>("m_requestId");
                }
            }

            public int m_requestSubId
            {
                get
                {
                    return base.method_2<int>("m_requestSubId");
                }
            }

            public DateTime m_waitUntil
            {
                get
                {
                    return base.method_2<DateTime>("m_waitUntil");
                }
            }
        }

        [Attribute38("Network.SetFavoriteHeroResponse")]
        public class SetFavoriteHeroResponse : MonoClass
        {
            public SetFavoriteHeroResponse(IntPtr address) : this(address, "SetFavoriteHeroResponse")
            {
            }

            public SetFavoriteHeroResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public NetCache.CardDefinition Hero
            {
                get
                {
                    return base.method_3<NetCache.CardDefinition>("Hero");
                }
            }

            public TAG_CLASS HeroClass
            {
                get
                {
                    return base.method_2<TAG_CLASS>("HeroClass");
                }
            }

            public bool Success
            {
                get
                {
                    return base.method_2<bool>("Success");
                }
            }
        }

        [Attribute38("Network.ThirdPartyPurchaseStatusResponse")]
        public class ThirdPartyPurchaseStatusResponse : MonoClass
        {
            public ThirdPartyPurchaseStatusResponse(IntPtr address) : this(address, "ThirdPartyPurchaseStatusResponse")
            {
            }

            public ThirdPartyPurchaseStatusResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public PurchaseStatus Status
            {
                get
                {
                    return base.method_11<PurchaseStatus>("get_Status", Array.Empty<object>());
                }
            }

            public string ThirdPartyID
            {
                get
                {
                    return base.method_13("get_ThirdPartyID", Array.Empty<object>());
                }
            }

            public enum PurchaseStatus
            {
                FAILED = 3,
                IN_PROGRESS = 4,
                NOT_FOUND = 1,
                SUCCEEDED = 2,
                UNKNOWN = -1
            }
        }

        public enum TrackLevel
        {
            LEVEL_ERROR = 3,
            LEVEL_INFO = 1,
            LEVEL_WARN = 2
        }

        public enum TrackWhat
        {
            TRACK_ACCEPT_FRIEND_GAME_WITH_CUSTOM_DECK = 10,
            TRACK_ACCEPT_FRIEND_GAME_WITH_PRECON_DECK = 11,
            TRACK_AUTO_COMPLETE_DECK_CLICKED = 0x24,
            TRACK_BOOSTER_OPENED = 0x1b,
            TRACK_BOX_SCREEN_VISIT = 0x23,
            TRACK_BUTTON_DRAFT = 13,
            TRACK_BUTTON_PRACTICE = 15,
            TRACK_BUTTON_TOURNAMENT = 12,
            TRACK_CANCEL_MATCHMAKER = 0x18,
            TRACK_CHALLENGE_FRIEND_WITH_CUSTOM_DECK = 8,
            TRACK_CHALLENGE_FRIEND_WITH_PRECON_DECK = 9,
            TRACK_CM_CARDS_SEARCHED = 30,
            TRACK_CM_HIDE_PREMIUMS_NOT_OWNED = 0x26,
            TRACK_CM_MANA_FILTER_CLICKED = 0x1c,
            TRACK_CM_MANA_FILTER_OFF = 0x1d,
            TRACK_CM_NEW_DECK_CREATED = 0x21,
            TRACK_CM_PAGE_TURNED = 0x22,
            TRACK_CM_SHOW_CARDS_I_DONT_OWN_TURNED_OFF = 0x20,
            TRACK_CM_SHOW_CARDS_I_DONT_OWN_TURNED_ON = 0x1f,
            TRACK_CM_SHOW_PREMIUMS_NOT_OWNED = 0x25,
            TRACK_COLLECTION_MANAGER = 1,
            TRACK_DISPLAYED_LOSS_SCREEN = 0x12,
            TRACK_DISPLAYED_TIE_SCREEN = 0x13,
            TRACK_DISPLAYED_WIN_SCREEN = 0x11,
            TRACK_GAME_START = 0x17,
            TRACK_LOGIN_FINISHED = 0x15,
            TRACK_LOGOUT_STARTING = 0x16,
            TRACK_PLAY_CASUAL_WITH_CUSTOM_DECK = 4,
            TRACK_PLAY_CASUAL_WITH_PRECON_DECK = 5,
            TRACK_PLAY_FORGE_QUEUE = 0x27,
            TRACK_PLAY_PRACTICE_WITH_CUSTOM_DECK = 2,
            TRACK_PLAY_PRACTICE_WITH_PRECON_DECK = 3,
            TRACK_PLAY_TOURNAMENT_WITH_CUSTOM_DECK = 6,
            TRACK_PLAY_TOURNAMENT_WITH_PRECON_DECK = 7,
            TRACK_RECEIVED_BOOSTER_PACK = 20,
            TRACK_START_TUTORIAL = 0x10,
            TRACK_TOGGLE_DECK_TYPE = 0x1a,
            TRACK_VISIT_PACK_OPEN_SCREEN = 0x19,
            ZZ_DEPRECATED_TRACK_BUTTON_CASUAL = 14
        }

        [Attribute38("Network.TriggeredEvent")]
        public class TriggeredEvent : MonoClass
        {
            public TriggeredEvent(IntPtr address) : this(address, "TriggeredEvent")
            {
            }

            public TriggeredEvent(IntPtr address, string className) : base(address, className)
            {
            }

            public int EventID
            {
                get
                {
                    return base.method_11<int>("get_EventID", Array.Empty<object>());
                }
            }

            public bool Success
            {
                get
                {
                    return base.method_11<bool>("get_Success", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.TurnTimerInfo")]
        public class TurnTimerInfo : MonoClass
        {
            public TurnTimerInfo(IntPtr address) : this(address, "TurnTimerInfo")
            {
            }

            public TurnTimerInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public float Seconds
            {
                get
                {
                    return base.method_11<float>("get_Seconds", Array.Empty<object>());
                }
            }

            public bool Show
            {
                get
                {
                    return base.method_11<bool>("get_Show", Array.Empty<object>());
                }
            }

            public int Turn
            {
                get
                {
                    return base.method_11<int>("get_Turn", Array.Empty<object>());
                }
            }
        }

        [Attribute38("Network.UnavailableReason")]
        public class UnavailableReason : MonoClass
        {
            public UnavailableReason(IntPtr address) : this(address, "UnavailableReason")
            {
            }

            public UnavailableReason(IntPtr address, string className) : base(address, className)
            {
            }

            public string extraData
            {
                get
                {
                    return base.method_4("extraData");
                }
            }

            public string mainReason
            {
                get
                {
                    return base.method_4("mainReason");
                }
            }

            public string subReason
            {
                get
                {
                    return base.method_4("subReason");
                }
            }
        }

        [Attribute38("Network.UserUI")]
        public class UserUI : MonoClass
        {
            public UserUI(IntPtr address) : this(address, "UserUI")
            {
            }

            public UserUI(IntPtr address, string className) : base(address, className)
            {
            }

            public EmoteInfo emoteInfo
            {
                get
                {
                    return base.method_3<EmoteInfo>("emoteInfo");
                }
            }

            public MouseInfo mouseInfo
            {
                get
                {
                    return base.method_3<MouseInfo>("mouseInfo");
                }
            }

            [Attribute38("Network.UserUI.EmoteInfo")]
            public class EmoteInfo : MonoClass
            {
                public EmoteInfo(IntPtr address) : this(address, "EmoteInfo")
                {
                }

                public EmoteInfo(IntPtr address, string className) : base(address, className)
                {
                }

                public int Emote
                {
                    get
                    {
                        return base.method_11<int>("get_Emote", Array.Empty<object>());
                    }
                }
            }

            [Attribute38("Network.UserUI.MouseInfo")]
            public class MouseInfo : MonoClass
            {
                public MouseInfo(IntPtr address) : this(address, "MouseInfo")
                {
                }

                public MouseInfo(IntPtr address, string className) : base(address, className)
                {
                }

                public int ArrowOriginID
                {
                    get
                    {
                        return base.method_11<int>("get_ArrowOriginID", Array.Empty<object>());
                    }
                }

                public int HeldCardID
                {
                    get
                    {
                        return base.method_11<int>("get_HeldCardID", Array.Empty<object>());
                    }
                }

                public int OverCardID
                {
                    get
                    {
                        return base.method_11<int>("get_OverCardID", Array.Empty<object>());
                    }
                }

                public int X
                {
                    get
                    {
                        return base.method_11<int>("get_X", Array.Empty<object>());
                    }
                }

                public int Y
                {
                    get
                    {
                        return base.method_11<int>("get_Y", Array.Empty<object>());
                    }
                }
            }
        }

        [Attribute38("Network.ValidatedAchieve")]
        public class ValidatedAchieve : MonoClass
        {
            public ValidatedAchieve(IntPtr address) : this(address, "ValidatedAchieve")
            {
            }

            public ValidatedAchieve(IntPtr address, string className) : base(address, className)
            {
            }

            public int AchieveID
            {
                get
                {
                    return base.method_11<int>("get_AchieveID", Array.Empty<object>());
                }
            }
        }

        public enum Version
        {
            Major = 4,
            Minor = 2,
            Patch = 0,
            Sku = 0
        }
    }
}

