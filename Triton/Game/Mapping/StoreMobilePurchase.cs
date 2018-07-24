namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StoreMobilePurchase")]
    public class StoreMobilePurchase : MonoClass
    {
        public StoreMobilePurchase(IntPtr address) : this(address, "StoreMobilePurchase")
        {
        }

        public StoreMobilePurchase(IntPtr address, string className) : base(address, className)
        {
        }

        public static void AddProductById(string mobileProductId)
        {
            object[] objArray1 = new object[] { mobileProductId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "AddProductById", objArray1);
        }

        public static void AddProductToAllProductsList(string mobileProductId)
        {
            object[] objArray1 = new object[] { mobileProductId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "AddProductToAllProductsList", objArray1);
        }

        public static void ClearMobileStoreProducts()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "ClearMobileStoreProducts");
        }

        public static void ClearProductList()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "ClearProductList");
        }

        public static bool DeviceIsWaitingForPurchase()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "DeviceIsWaitingForPurchase", Array.Empty<object>());
        }

        public static void DismissNextReceipt(bool consume)
        {
            object[] objArray1 = new object[] { consume };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "DismissNextReceipt", objArray1);
        }

        public static void DismissReceipt(bool consume)
        {
            object[] objArray1 = new object[] { consume };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "DismissReceipt", objArray1);
        }

        public static void FinishTransactionForId(string transactionId)
        {
            object[] objArray1 = new object[] { transactionId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "FinishTransactionForId", objArray1);
        }

        public static void FinishTransactionId(string transactionId)
        {
            object[] objArray1 = new object[] { transactionId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "FinishTransactionId", objArray1);
        }

        public static void GamePurchaseStatusResponse(string transactionId, bool isSuccess)
        {
            object[] objArray1 = new object[] { transactionId, isSuccess };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GamePurchaseStatusResponse", objArray1);
        }

        public static int GetLastPurchaseStatusCode()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GetLastPurchaseStatusCode", Array.Empty<object>());
        }

        public static string GetLastPurchaseStatusDescription()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GetLastPurchaseStatusDescription", Array.Empty<object>());
        }

        public static string GetLocalizedPrice(double price)
        {
            object[] objArray1 = new object[] { price };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GetLocalizedPrice", objArray1);
        }

        public static string GetLocalizedProductPrice(string mobileProductId)
        {
            object[] objArray1 = new object[] { mobileProductId };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GetLocalizedProductPrice", objArray1);
        }

        public static IntPtr GetNextReceipt()
        {
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GetNextReceipt", Array.Empty<object>());
        }

        public static int GetNumReceiptsAvailable()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GetNumReceiptsAvailable", Array.Empty<object>());
        }

        public static double GetProductPrice(string mobileProductId)
        {
            object[] objArray1 = new object[] { mobileProductId };
            return MonoClass.smethod_14<double>(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GetProductPrice", objArray1);
        }

        public static PURCHASE_STATUS_CODE GetStatusCodeOfLastPurchase()
        {
            return MonoClass.smethod_14<PURCHASE_STATUS_CODE>(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GetStatusCodeOfLastPurchase", Array.Empty<object>());
        }

        public static string GetStatusDescriptionOfLastPurchase()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GetStatusDescriptionOfLastPurchase", Array.Empty<object>());
        }

        public static string GetThirdPartyUserId()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "GetThirdPartyUserId", Array.Empty<object>());
        }

        public static bool IsWaitingForPurchase()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "IsWaitingForPurchase", Array.Empty<object>());
        }

        public static string LocalizedPrice(double price)
        {
            object[] objArray1 = new object[] { price };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "LocalizedPrice", objArray1);
        }

        public static string LocalizedProductPriceById(string mobileProductId)
        {
            object[] objArray1 = new object[] { mobileProductId };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "LocalizedProductPriceById", objArray1);
        }

        public static IntPtr NextReceipt()
        {
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "NextReceipt", Array.Empty<object>());
        }

        public static int NumReceiptsAvailable()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "NumReceiptsAvailable", Array.Empty<object>());
        }

        public static void OnGamePurchaseStatusResponse(string transactionId, bool isSuccess)
        {
            object[] objArray1 = new object[] { transactionId, isSuccess };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "OnGamePurchaseStatusResponse", objArray1);
        }

        public static void OnReset()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "OnReset");
        }

        public static void OnThirdPartyPurchaseStatus(string transactionId, int status)
        {
            object[] objArray1 = new object[] { transactionId, status };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "OnThirdPartyPurchaseStatus", objArray1);
        }

        public static void ProcessNextPendingTransaction()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "ProcessNextPendingTransaction");
        }

        public static double ProductPriceById(string mobileProductId)
        {
            object[] objArray1 = new object[] { mobileProductId };
            return MonoClass.smethod_14<double>(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "ProductPriceById", objArray1);
        }

        public static void PurchaseProductById(string mobileProductId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { mobileProductId };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "PurchaseProductById", enumArray1, objArray1);
        }

        public static void PurchaseProductById(string mobileProductId, string transactionId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.String };
            object[] objArray1 = new object[] { mobileProductId, transactionId };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "PurchaseProductById", enumArray1, objArray1);
        }

        public static string ReceiptStringForTransactionId(string transactionId)
        {
            object[] objArray1 = new object[] { transactionId };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "ReceiptStringForTransactionId", objArray1);
        }

        public static void RequestPurchaseByProductId(string mobileProductId, string transactionId)
        {
            object[] objArray1 = new object[] { mobileProductId, transactionId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "RequestPurchaseByProductId", objArray1);
        }

        public static void RequestThirdPartyReceipt(string mobileProductId)
        {
            object[] objArray1 = new object[] { mobileProductId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "RequestThirdPartyReceipt", objArray1);
        }

        public static void Reset()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "Reset");
        }

        public static void SetBattleNetGameAccountIdAndRegion(ulong gameAccountId, int gameRegion)
        {
            object[] objArray1 = new object[] { gameAccountId, gameRegion };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "SetBattleNetGameAccountIdAndRegion", objArray1);
        }

        public static void SetGameAccountIdAndRegion(ulong gameAccountId, int gameRegion)
        {
            object[] objArray1 = new object[] { gameAccountId, gameRegion };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "SetGameAccountIdAndRegion", objArray1);
        }

        public static void StoreTransactionStatusNotReady()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "StoreTransactionStatusNotReady");
        }

        public static void StoreTransactionStatusReady()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "StoreTransactionStatusReady");
        }

        public static void SubmitNextPendingTransaction()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "SubmitNextPendingTransaction");
        }

        public static void ThirdPartyPurchaseStatus(string transactionId, Network.ThirdPartyPurchaseStatusResponse.PurchaseStatus status)
        {
            object[] objArray1 = new object[] { transactionId, status };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "ThirdPartyPurchaseStatus", objArray1);
        }

        public static string ThirdPartyUserId()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "ThirdPartyUserId", Array.Empty<object>());
        }

        public static void TransactionStatusNotReady()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "TransactionStatusNotReady");
        }

        public static void TransactionStatusReady()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "TransactionStatusReady");
        }

        public static void ValidateAllProducts(string gameObjectName)
        {
            object[] objArray1 = new object[] { gameObjectName };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "ValidateAllProducts", objArray1);
        }

        public static void ValidateProducts(string gameObjectName)
        {
            object[] objArray1 = new object[] { gameObjectName };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "ValidateProducts", objArray1);
        }

        public static void WaitingOnThirdPartyReceipt(string mobileProductId)
        {
            object[] objArray1 = new object[] { mobileProductId };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "StoreMobilePurchase", "WaitingOnThirdPartyReceipt", objArray1);
        }

        public enum PURCHASE_STATUS_CODE
        {
            PURCHASE_SUCCESSFUL,
            PURCHASE_FAILED,
            PURCHASE_RECOVERED,
            PURCHASE_NOT_AVAILABLE
        }
    }
}

