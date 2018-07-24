namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StoreManager")]
    public class StoreManager : MonoClass
    {
        public StoreManager(IntPtr address) : this(address, "StoreManager")
        {
        }

        public StoreManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateStoreCover()
        {
            base.method_8("ActivateStoreCover", Array.Empty<object>());
        }

        public bool AutoCancelPurchaseIfNeeded(long now)
        {
            object[] objArray1 = new object[] { now };
            return base.method_11<bool>("AutoCancelPurchaseIfNeeded", objArray1);
        }

        public bool AutoCancelPurchaseIfPossible()
        {
            return base.method_11<bool>("AutoCancelPurchaseIfPossible", Array.Empty<object>());
        }

        public bool CanBuyBoosterWithGold(int boosterDbId)
        {
            object[] objArray1 = new object[] { boosterDbId };
            return base.method_11<bool>("CanBuyBoosterWithGold", objArray1);
        }

        public bool CanBuyBundle(Network.Bundle bundleToBuy)
        {
            object[] objArray1 = new object[] { bundleToBuy };
            return base.method_11<bool>("CanBuyBundle", objArray1);
        }

        public void CompletePurchaseFailure(PurchaseErrorSource source, MoneyOrGTAPPTransaction moneyOrGTAPPTransaction, string failDetails, string thirdPartyID, bool removeThirdPartyReceipt)
        {
            object[] objArray1 = new object[] { source, moneyOrGTAPPTransaction, failDetails, thirdPartyID, removeThirdPartyReceipt };
            base.method_8("CompletePurchaseFailure", objArray1);
        }

        public void ConfirmActiveMoneyTransaction(long id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("ConfirmActiveMoneyTransaction", objArray1);
        }

        public void ConfirmPurchase()
        {
            base.method_8("ConfirmPurchase", Array.Empty<object>());
        }

        public void DeactivateStoreCover()
        {
            base.method_8("DeactivateStoreCover", Array.Empty<object>());
        }

        public static void DestroyInstance()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreManager", "DestroyInstance");
        }

        public void FireStatusChangedEventIfNeeded()
        {
            base.method_8("FireStatusChangedEventIfNeeded", Array.Empty<object>());
        }

        public string FormatCostBundle(Network.Bundle bundle)
        {
            object[] objArray1 = new object[] { bundle };
            return base.method_13("FormatCostBundle", objArray1);
        }

        public string FormatCostText(double cost)
        {
            object[] objArray1 = new object[] { cost };
            return base.method_13("FormatCostText", objArray1);
        }

        public static string FormatCostText(double cost, Triton.Game.Mapping.Currency currency)
        {
            object[] objArray1 = new object[] { cost, currency };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StoreManager", "FormatCostText", objArray1);
        }

        public static StoreManager Get()
        {
            return MonoClass.smethod_15<StoreManager>(TritonHs.MainAssemblyPath, "", "StoreManager", "Get", Array.Empty<object>());
        }

        public long GetArenaGoldCostNoGTAPP()
        {
            return base.method_11<long>("GetArenaGoldCostNoGTAPP", Array.Empty<object>());
        }

        public long GetBoosterGoldCostNoGTAPP(int boosterId)
        {
            object[] objArray1 = new object[] { boosterId };
            return base.method_11<long>("GetBoosterGoldCostNoGTAPP", objArray1);
        }

        public Network.Bundle GetBundle(string productID)
        {
            object[] objArray1 = new object[] { productID };
            return base.method_14<Network.Bundle>("GetBundle", objArray1);
        }

        public Store GetCurrentStore()
        {
            return base.method_14<Store>("GetCurrentStore", Array.Empty<object>());
        }

        public long GetGoldCostNoGTAPP(NoGTAPPTransactionData noGTAPPTransactionData)
        {
            object[] objArray1 = new object[] { noGTAPPTransactionData };
            return base.method_11<long>("GetGoldCostNoGTAPP", objArray1);
        }

        public long GetIncreasedRequestDelayTicks(long currentRequestDelayTicks, long minimumDelayTicks)
        {
            object[] objArray1 = new object[] { currentRequestDelayTicks, minimumDelayTicks };
            return base.method_11<long>("GetIncreasedRequestDelayTicks", objArray1);
        }

        public NetCache.NetCacheFeatures GetNetCacheFeatures()
        {
            return base.method_14<NetCache.NetCacheFeatures>("GetNetCacheFeatures", Array.Empty<object>());
        }

        public string GetSingleItemProductName(Network.BundleItem item)
        {
            object[] objArray1 = new object[] { item };
            return base.method_13("GetSingleItemProductName", objArray1);
        }

        public Store GetStore(StoreType storeType)
        {
            object[] objArray1 = new object[] { storeType };
            return base.method_14<Store>("GetStore", objArray1);
        }

        public string GetTaxText()
        {
            return base.method_13("GetTaxText", Array.Empty<object>());
        }

        public void GetThirdPartyPurchaseStatus(string transactionID)
        {
            object[] objArray1 = new object[] { transactionID };
            base.method_8("GetThirdPartyPurchaseStatus", objArray1);
        }

        public void HandleFailedRiskError(PurchaseErrorSource source)
        {
            object[] objArray1 = new object[] { source };
            base.method_8("HandleFailedRiskError", objArray1);
        }

        public void HandlePurchaseError(PurchaseErrorSource source, Network.PurchaseErrorInfo.ErrorType purchaseErrorType, string purchaseErrorCode, string thirdPartyID, bool isGTAPP)
        {
            object[] objArray1 = new object[] { source, purchaseErrorType, purchaseErrorCode, thirdPartyID, isGTAPP };
            base.method_8("HandlePurchaseError", objArray1);
        }

        public void HandleSendToBAMError(PurchaseErrorSource source, StoreSendToBAM.BAMReason reason, string errorCode)
        {
            object[] objArray1 = new object[] { source, reason, errorCode };
            base.method_8("HandleSendToBAMError", objArray1);
        }

        public void HandleZeroCostLicensePurchaseMethod(Network.PurchaseMethod method)
        {
            object[] objArray1 = new object[] { method };
            base.method_8("HandleZeroCostLicensePurchaseMethod", objArray1);
        }

        public bool HaveProductsToSell()
        {
            return base.method_11<bool>("HaveProductsToSell", Array.Empty<object>());
        }

        public void Heartbeat()
        {
            base.method_8("Heartbeat", Array.Empty<object>());
        }

        public void HideAllPurchasePopups()
        {
            base.method_8("HideAllPurchasePopups", Array.Empty<object>());
        }

        public void HideArenaStore()
        {
            base.method_8("HideArenaStore", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public bool IsBattlePayFeatureEnabled()
        {
            return base.method_11<bool>("IsBattlePayFeatureEnabled", Array.Empty<object>());
        }

        public bool IsBuyWithGoldFeatureEnabled()
        {
            return base.method_11<bool>("IsBuyWithGoldFeatureEnabled", Array.Empty<object>());
        }

        public bool IsChinaCustomer()
        {
            return base.method_11<bool>("IsChinaCustomer", Array.Empty<object>());
        }

        public bool IsConclusiveState(Network.PurchaseErrorInfo.ErrorType errorType)
        {
            object[] objArray1 = new object[] { errorType };
            return base.method_11<bool>("IsConclusiveState", objArray1);
        }

        public bool IsCurrentStoreLoaded()
        {
            return base.method_11<bool>("IsCurrentStoreLoaded", Array.Empty<object>());
        }

        public bool IsEuropeanCustomer()
        {
            return base.method_11<bool>("IsEuropeanCustomer", Array.Empty<object>());
        }

        public bool IsKoreanCustomer()
        {
            return base.method_11<bool>("IsKoreanCustomer", Array.Empty<object>());
        }

        public bool IsNorthAmericanCustomer()
        {
            return base.method_11<bool>("IsNorthAmericanCustomer", Array.Empty<object>());
        }

        public bool IsOpen()
        {
            return base.method_11<bool>("IsOpen", Array.Empty<object>());
        }

        public bool IsProductAlreadyOwned(Network.Bundle bundle)
        {
            object[] objArray1 = new object[] { bundle };
            return base.method_11<bool>("IsProductAlreadyOwned", objArray1);
        }

        public bool IsPromptShowing()
        {
            return base.method_11<bool>("IsPromptShowing", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public bool IsShownOrWaitingToShow()
        {
            return base.method_11<bool>("IsShownOrWaitingToShow", Array.Empty<object>());
        }

        public bool IsStoreFeatureEnabled()
        {
            return base.method_11<bool>("IsStoreFeatureEnabled", Array.Empty<object>());
        }

        public bool IsWaitingToShow()
        {
            return base.method_11<bool>("IsWaitingToShow", Array.Empty<object>());
        }

        public void Load(StoreType storeType)
        {
            object[] objArray1 = new object[] { storeType };
            base.method_8("Load", objArray1);
        }

        public void NotifyMobileGamePurchaseResponse(string thirdPartyID, bool isSuccess)
        {
            object[] objArray1 = new object[] { thirdPartyID, isSuccess };
            base.method_8("NotifyMobileGamePurchaseResponse", objArray1);
        }

        public void OnAchievesUpdated(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnAchievesUpdated", objArray1);
        }

        public void OnAdventureStoreLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnAdventureStoreLoaded", objArray1);
        }

        public void OnArenaStoreLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnArenaStoreLoaded", objArray1);
        }

        public void OnAuthExit()
        {
            base.method_8("OnAuthExit", Array.Empty<object>());
        }

        public void OnBattlePayConfigResponse()
        {
            base.method_8("OnBattlePayConfigResponse", Array.Empty<object>());
        }

        public void OnBattlePayStatusResponse()
        {
            base.method_8("OnBattlePayStatusResponse", Array.Empty<object>());
        }

        public void OnChallengeCancel(string challengeID)
        {
            object[] objArray1 = new object[] { challengeID };
            base.method_8("OnChallengeCancel", objArray1);
        }

        public void OnDoneWithBAM()
        {
            base.method_8("OnDoneWithBAM", Array.Empty<object>());
        }

        public void OnGeneralStoreLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnGeneralStoreLoaded", objArray1);
        }

        public void OnGoldBalanceChanged(NetCache.NetCacheGoldBalance balance)
        {
            object[] objArray1 = new object[] { balance };
            base.method_8("OnGoldBalanceChanged", objArray1);
        }

        public void OnNetCacheFeaturesReady()
        {
            base.method_8("OnNetCacheFeaturesReady", Array.Empty<object>());
        }

        public void OnPurchaseCanceledResponse()
        {
            base.method_8("OnPurchaseCanceledResponse", Array.Empty<object>());
        }

        public void OnPurchaseMethod()
        {
            base.method_8("OnPurchaseMethod", Array.Empty<object>());
        }

        public void OnPurchaseResponse()
        {
            base.method_8("OnPurchaseResponse", Array.Empty<object>());
        }

        public void OnPurchaseResultAcknowledged(bool success, MoneyOrGTAPPTransaction moneyOrGTAPPTransaction)
        {
            object[] objArray1 = new object[] { success, moneyOrGTAPPTransaction };
            base.method_8("OnPurchaseResultAcknowledged", objArray1);
        }

        public void OnPurchaseViaGoldResponse()
        {
            base.method_8("OnPurchaseViaGoldResponse", Array.Empty<object>());
        }

        public void OnSceneUnloaded(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("OnSceneUnloaded", objArray1);
        }

        public void OnSendToBAMCancel(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction };
            base.method_8("OnSendToBAMCancel", objArray1);
        }

        public void OnSendToBAMLegal(StoreLegalBAMLinks.BAMReason reason)
        {
            object[] objArray1 = new object[] { reason };
            base.method_8("OnSendToBAMLegal", objArray1);
        }

        public void OnSendToBAMLegalCancel()
        {
            base.method_8("OnSendToBAMLegalCancel", Array.Empty<object>());
        }

        public void OnSendToBAMOkay(MoneyOrGTAPPTransaction moneyOrGTAPPTransaction, StoreSendToBAM.BAMReason reason)
        {
            object[] objArray1 = new object[] { moneyOrGTAPPTransaction, reason };
            base.method_8("OnSendToBAMOkay", objArray1);
        }

        public void OnStoreBuyWithGoldNoGTAPP(NoGTAPPTransactionData noGTAPPtransactionData, object userData)
        {
            object[] objArray1 = new object[] { noGTAPPtransactionData, userData };
            base.method_8("OnStoreBuyWithGoldNoGTAPP", objArray1);
        }

        public void OnStoreBuyWithGTAPP(string productID, int quantity, object userData)
        {
            object[] objArray1 = new object[] { productID, quantity, userData };
            base.method_8("OnStoreBuyWithGTAPP", objArray1);
        }

        public void OnStoreBuyWithMoney(string productID, int quantity, object userData)
        {
            object[] objArray1 = new object[] { productID, quantity, userData };
            base.method_8("OnStoreBuyWithMoney", objArray1);
        }

        public void OnStoreChallengePromptLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnStoreChallengePromptLoaded", objArray1);
        }

        public void OnStoreComponentReady(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnStoreComponentReady", objArray1);
        }

        public void OnStoreDoneWithBAMLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnStoreDoneWithBAMLoaded", objArray1);
        }

        public void OnStoreExit(bool authorizationBackButtonPressed, object userData)
        {
            object[] objArray1 = new object[] { authorizationBackButtonPressed, userData };
            base.method_8("OnStoreExit", objArray1);
        }

        public void OnStoreInfo(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnStoreInfo", objArray1);
        }

        public void OnStoreLegalBAMLinksLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnStoreLegalBAMLinksLoaded", objArray1);
        }

        public void OnStorePurchaseAuthLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnStorePurchaseAuthLoaded", objArray1);
        }

        public void OnStoreSendToBAMLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnStoreSendToBAMLoaded", objArray1);
        }

        public void OnStoreShown()
        {
            base.method_8("OnStoreShown", Array.Empty<object>());
        }

        public void OnStoreSummaryLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnStoreSummaryLoaded", objArray1);
        }

        public void OnSummaryCancel(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnSummaryCancel", objArray1);
        }

        public void OnSummaryConfirm(string productID, int quantity, object userData)
        {
            object[] objArray1 = new object[] { productID, quantity, userData };
            base.method_8("OnSummaryConfirm", objArray1);
        }

        public void OnSummaryInfo(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnSummaryInfo", objArray1);
        }

        public void OnSummaryPaymentAndTOS(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnSummaryPaymentAndTOS", objArray1);
        }

        public void OnThirdPartyPurchaseApproved()
        {
            base.method_8("OnThirdPartyPurchaseApproved", Array.Empty<object>());
        }

        public void OnThirdPartyPurchaseStatusResponse()
        {
            base.method_8("OnThirdPartyPurchaseStatusResponse", Array.Empty<object>());
        }

        public bool ReloadNoticesIfNecessary(Network.PurchaseErrorInfo.ErrorType errorType)
        {
            object[] objArray1 = new object[] { errorType };
            return base.method_11<bool>("ReloadNoticesIfNecessary", objArray1);
        }

        public void RemoveThirdPartyReceipt(string transactionID)
        {
            object[] objArray1 = new object[] { transactionID };
            base.method_8("RemoveThirdPartyReceipt", objArray1);
        }

        public void RequestConfigIfNeeded(long now)
        {
            object[] objArray1 = new object[] { now };
            base.method_8("RequestConfigIfNeeded", objArray1);
        }

        public void RequestStatusIfNeeded(long now)
        {
            object[] objArray1 = new object[] { now };
            base.method_8("RequestStatusIfNeeded", objArray1);
        }

        public void ResolveFirstMoneyOrGTAPPTransactionIfPossible()
        {
            base.method_8("ResolveFirstMoneyOrGTAPPTransactionIfPossible", Array.Empty<object>());
        }

        public void SetupLoadedStore(Store store)
        {
            object[] objArray1 = new object[] { store };
            base.method_8("SetupLoadedStore", objArray1);
        }

        public bool ShouldEnablePurchaseAuthBackButton(StoreType storeType)
        {
            object[] objArray1 = new object[] { storeType };
            return base.method_11<bool>("ShouldEnablePurchaseAuthBackButton", objArray1);
        }

        public void ShowCompletedAchieve()
        {
            base.method_8("ShowCompletedAchieve", Array.Empty<object>());
        }

        public void ShowStore()
        {
            base.method_8("ShowStore", Array.Empty<object>());
        }

        public void ShowStoreWhenLoaded()
        {
            base.method_8("ShowStoreWhenLoaded", Array.Empty<object>());
        }

        public void StartGeneralTransaction()
        {
            base.method_9("StartGeneralTransaction", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void StartGeneralTransaction(GeneralStoreMode mode)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { mode };
            base.method_9("StartGeneralTransaction", enumArray1, objArray1);
        }

        public bool TransactionInProgress()
        {
            return base.method_11<bool>("TransactionInProgress", Array.Empty<object>());
        }

        public void UnloadAndFreeMemory()
        {
            base.method_8("UnloadAndFreeMemory", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public bool BattlePayAvailable
        {
            get
            {
                return base.method_11<bool>("get_BattlePayAvailable", Array.Empty<object>());
            }
        }

        public static long CHALLENGE_CANCEL_STATUS_REQUEST_DELAY_TICKS
        {
            get
            {
                return MonoClass.smethod_6<long>(TritonHs.MainAssemblyPath, "", "StoreManager", "CHALLENGE_CANCEL_STATUS_REQUEST_DELAY_TICKS");
            }
        }

        public bool ConfigLoaded
        {
            get
            {
                return base.method_11<bool>("get_ConfigLoaded", Array.Empty<object>());
            }
        }

        public static string DEFAULT_CURRENCY_FORMAT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreManager", "DEFAULT_CURRENCY_FORMAT");
            }
        }

        public static int DEFAULT_SECONDS_BEFORE_AUTO_CANCEL
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "StoreManager", "DEFAULT_SECONDS_BEFORE_AUTO_CANCEL");
            }
        }

        public static int DEFAULT_SECONDS_BEFORE_AUTO_CANCEL_THIRD_PARTY
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "StoreManager", "DEFAULT_SECONDS_BEFORE_AUTO_CANCEL_THIRD_PARTY");
            }
        }

        public static long EARLY_STATUS_REQUEST_DELAY_TICKS
        {
            get
            {
                return MonoClass.smethod_6<long>(TritonHs.MainAssemblyPath, "", "StoreManager", "EARLY_STATUS_REQUEST_DELAY_TICKS");
            }
        }

        public bool FeaturesReady
        {
            get
            {
                return base.method_11<bool>("get_FeaturesReady", Array.Empty<object>());
            }
        }

        public MoneyOrGTAPPTransaction m_activeMoneyOrGTAPPTransaction
        {
            get
            {
                return base.method_3<MoneyOrGTAPPTransaction>("m_activeMoneyOrGTAPPTransaction");
            }
        }

        public bool m_battlePayAvailable
        {
            get
            {
                return base.method_2<bool>("m_battlePayAvailable");
            }
        }

        public Network.PurchaseMethod m_challengePurchaseMethod
        {
            get
            {
                return base.method_3<Network.PurchaseMethod>("m_challengePurchaseMethod");
            }
        }

        public List<Achievement> m_completedAchieves
        {
            get
            {
                Class267<Achievement> class2 = base.method_3<Class267<Achievement>>("m_completedAchieves");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_configLoaded
        {
            get
            {
                return base.method_2<bool>("m_configLoaded");
            }
        }

        public long m_configRequestDelayTicks
        {
            get
            {
                return base.method_2<long>("m_configRequestDelayTicks");
            }
        }

        public Triton.Game.Mapping.Currency m_currency
        {
            get
            {
                return base.method_2<Triton.Game.Mapping.Currency>("m_currency");
            }
        }

        public StoreType m_currentStoreType
        {
            get
            {
                return base.method_2<StoreType>("m_currentStoreType");
            }
        }

        public bool m_featuresReady
        {
            get
            {
                return base.method_2<bool>("m_featuresReady");
            }
        }

        public bool m_firstMoneyOrGTAPPTransactionSet
        {
            get
            {
                return base.method_2<bool>("m_firstMoneyOrGTAPPTransactionSet");
            }
        }

        public long m_goldCostArena
        {
            get
            {
                return base.method_2<long>("m_goldCostArena");
            }
        }

        public bool m_initComplete
        {
            get
            {
                return base.method_2<bool>("m_initComplete");
            }
        }

        public long m_lastCancelRequestTime
        {
            get
            {
                return base.method_2<long>("m_lastCancelRequestTime");
            }
        }

        public long m_lastConfigRequestTime
        {
            get
            {
                return base.method_2<long>("m_lastConfigRequestTime");
            }
        }

        public long m_lastStatusRequestTime
        {
            get
            {
                return base.method_2<long>("m_lastStatusRequestTime");
            }
        }

        public bool m_licenseAchievesListenerRegistered
        {
            get
            {
                return base.method_2<bool>("m_licenseAchievesListenerRegistered");
            }
        }

        public bool m_noticesReady
        {
            get
            {
                return base.method_2<bool>("m_noticesReady");
            }
        }

        public bool m_openWhenLastEventFired
        {
            get
            {
                return base.method_2<bool>("m_openWhenLastEventFired");
            }
        }

        public bool m_outOfSessionThirdPartyTransaction
        {
            get
            {
                return base.method_2<bool>("m_outOfSessionThirdPartyTransaction");
            }
        }

        public List<NetCache.ProfileNoticePurchase> m_outstandingPurchaseNotices
        {
            get
            {
                Class267<NetCache.ProfileNoticePurchase> class2 = base.method_3<Class267<NetCache.ProfileNoticePurchase>>("m_outstandingPurchaseNotices");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public TransactionStatus m_previousStatusBeforeAutoCancel
        {
            get
            {
                return base.method_2<TransactionStatus>("m_previousStatusBeforeAutoCancel");
            }
        }

        public string m_requestedThirdPartyProductId
        {
            get
            {
                return base.method_4("m_requestedThirdPartyProductId");
            }
        }

        public bool m_shouldAutoCancelThirdPartyTransaction
        {
            get
            {
                return base.method_2<bool>("m_shouldAutoCancelThirdPartyTransaction");
            }
        }

        public ShowStoreData m_showStoreData
        {
            get
            {
                return base.method_2<ShowStoreData>("m_showStoreData");
            }
        }

        public TransactionStatus m_status
        {
            get
            {
                return base.method_2<TransactionStatus>("m_status");
            }
        }

        public long m_statusRequestDelayTicks
        {
            get
            {
                return base.method_2<long>("m_statusRequestDelayTicks");
            }
        }

        public StoreChallengePrompt m_storeChallengePrompt
        {
            get
            {
                return base.method_3<StoreChallengePrompt>("m_storeChallengePrompt");
            }
        }

        public StoreDoneWithBAM m_storeDoneWithBAM
        {
            get
            {
                return base.method_3<StoreDoneWithBAM>("m_storeDoneWithBAM");
            }
        }

        public StoreLegalBAMLinks m_storeLegalBAMLinks
        {
            get
            {
                return base.method_3<StoreLegalBAMLinks>("m_storeLegalBAMLinks");
            }
        }

        public StorePurchaseAuth m_storePurchaseAuth
        {
            get
            {
                return base.method_3<StorePurchaseAuth>("m_storePurchaseAuth");
            }
        }

        public StoreSendToBAM m_storeSendToBAM
        {
            get
            {
                return base.method_3<StoreSendToBAM>("m_storeSendToBAM");
            }
        }

        public StoreSummary m_storeSummary
        {
            get
            {
                return base.method_3<StoreSummary>("m_storeSummary");
            }
        }

        public long m_ticksBeforeAutoCancel
        {
            get
            {
                return base.method_2<long>("m_ticksBeforeAutoCancel");
            }
        }

        public long m_ticksBeforeAutoCancelThirdParty
        {
            get
            {
                return base.method_2<long>("m_ticksBeforeAutoCancelThirdParty");
            }
        }

        public bool m_waitingToShowStore
        {
            get
            {
                return base.method_2<bool>("m_waitingToShowStore");
            }
        }

        public static long MAX_REQUEST_DELAY_TICKS
        {
            get
            {
                return MonoClass.smethod_6<long>(TritonHs.MainAssemblyPath, "", "StoreManager", "MAX_REQUEST_DELAY_TICKS");
            }
        }

        public static long MIN_CONFIG_REQUEST_DELAY_TICKS
        {
            get
            {
                return MonoClass.smethod_6<long>(TritonHs.MainAssemblyPath, "", "StoreManager", "MIN_CONFIG_REQUEST_DELAY_TICKS");
            }
        }

        public static long MIN_STATUS_REQUEST_DELAY_TICKS
        {
            get
            {
                return MonoClass.smethod_6<long>(TritonHs.MainAssemblyPath, "", "StoreManager", "MIN_STATUS_REQUEST_DELAY_TICKS");
            }
        }

        public static int NO_ITEM_COUNT_REQUIREMENT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "StoreManager", "NO_ITEM_COUNT_REQUIREMENT");
            }
        }

        public static int NO_PRODUCT_DATA_REQUIREMENT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "StoreManager", "NO_PRODUCT_DATA_REQUIREMENT");
            }
        }

        public bool NoticesReady
        {
            get
            {
                return base.method_11<bool>("get_NoticesReady", Array.Empty<object>());
            }
        }

        public TransactionStatus Status
        {
            get
            {
                return base.method_11<TransactionStatus>("get_Status", Array.Empty<object>());
            }
        }

        public static int UNKNOWN_TRANSACTION_ID
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "StoreManager", "UNKNOWN_TRANSACTION_ID");
            }
        }

        public enum PurchaseErrorSource
        {
            FROM_PURCHASE_METHOD_RESPONSE,
            FROM_STATUS_OR_PURCHASE_RESPONSE,
            FROM_PREVIOUS_PURCHASE
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ShowStoreData
        {
            public bool m_isTotallyFake;
            public object m_exitCallbackUserData;
            public int m_storeProductData;
            public GeneralStoreMode m_storeMode;
            public StoreManager.ZeroCostTransactionData m_zeroCostTransactionData;
        }

        [Attribute38("StoreManager.StoreAchievesData")]
        public class StoreAchievesData : MonoClass
        {
            public StoreAchievesData(IntPtr address) : this(address, "StoreAchievesData")
            {
            }

            public StoreAchievesData(IntPtr address, string className) : base(address, className)
            {
            }

            public Triton.Game.Mapping.Network.Bundle Bundle
            {
                get
                {
                    return base.method_14<Triton.Game.Mapping.Network.Bundle>("get_Bundle", Array.Empty<object>());
                }
            }

            public PaymentMethod MethodOfPayment
            {
                get
                {
                    return base.method_11<PaymentMethod>("get_MethodOfPayment", Array.Empty<object>());
                }
            }
        }

        public enum TransactionStatus
        {
            UNKNOWN,
            IN_PROGRESS_MONEY,
            IN_PROGRESS_GOLD_GTAPP,
            IN_PROGRESS_GOLD_NO_GTAPP,
            READY,
            WAIT_ZERO_COST_LICENSE,
            WAIT_METHOD_OF_PAYMENT,
            WAIT_THIRD_PARTY_INIT,
            WAIT_THIRD_PARTY_RECEIPT,
            WAIT_CONFIRM,
            WAIT_RISK,
            CHALLENGE_SUBMITTED,
            CHALLENGE_CANCELED,
            USER_CANCELING,
            AUTO_CANCELING
        }

        [Attribute38("StoreManager.ZeroCostTransactionData")]
        public class ZeroCostTransactionData : MonoClass
        {
            public ZeroCostTransactionData(IntPtr address) : this(address, "ZeroCostTransactionData")
            {
            }

            public ZeroCostTransactionData(IntPtr address, string className) : base(address, className)
            {
            }

            public Triton.Game.Mapping.Network.Bundle Bundle
            {
                get
                {
                    return base.method_14<Triton.Game.Mapping.Network.Bundle>("get_Bundle", Array.Empty<object>());
                }
            }
        }
    }
}

