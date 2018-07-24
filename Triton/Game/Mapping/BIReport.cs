namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BIReport")]
    public class BIReport : MonoBehaviour
    {
        public BIReport(IntPtr address) : this(address, "BIReport")
        {
        }

        public BIReport(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static double ConvertDateTimeToUnixEpoch(DateTime time)
        {
            object[] objArray1 = new object[] { time };
            return MonoClass.smethod_14<double>(TritonHs.MainAssemblyPath, "", "BIReport", "ConvertDateTimeToUnixEpoch", objArray1);
        }

        public void GenerateSessionID()
        {
            base.method_8("GenerateSessionID", Array.Empty<object>());
        }

        public static BIReport Get()
        {
            return MonoClass.smethod_15<BIReport>(TritonHs.MainAssemblyPath, "", "BIReport", "Get", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public static string BIURL
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "BIReport", "BIURL");
            }
        }

        public static string DOP_PROTO_MESSAGE_TYPE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "BIReport", "DOP_PROTO_MESSAGE_TYPE");
            }
        }

        public static string s_sessionId
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "BIReport", "s_sessionId");
            }
        }

        public static string TELEMETRY_PROTO_MESSAGE_TYPE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "BIReport", "TELEMETRY_PROTO_MESSAGE_TYPE");
            }
        }

        public enum TelemetryEvent
        {
            EVENT_ERROR_NETWORK_UNAVAILABLE = 900,
            EVENT_ERROR_UNKNOWN_ERROR = 0x3e8,
            EVENT_FATAL_BNET_ERROR = 600,
            EVENT_IGNORABLE_BNET_ERROR = 500,
            EVENT_LOGIN_ERROR_RESOLVE_HOST = 110,
            EVENT_LOGIN_REQUEST = 100,
            EVENT_LOGIN_SUCCESS = 200,
            EVENT_ON_RESET = 700,
            EVENT_ON_RESET_WITH_LOGIN = 710,
            EVENT_THIRD_PARTY_PURCHASE_AUTO_CANCEL = 0x37d,
            EVENT_THIRD_PARTY_PURCHASE_CANCEL_RESPONSE = 0x37e,
            EVENT_THIRD_PARTY_PURCHASE_DEFERRED = 840,
            EVENT_THIRD_PARTY_PURCHASE_FAILED = 830,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_CONSUMED = 0x383,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_RECEIVED = 860,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_REQUEST = 890,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_REQUEST_FOUND = 0x37c,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_REQUEST_NOT_FOUND = 0x37b,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_SIZE = 850,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_SUBMITTED = 870,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_SUBMITTED_DANGLING = 880,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_SUBMITTED_DANGLING_FAILED = 0x371,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_SUBMITTED_FAILED = 0x367,
            EVENT_THIRD_PARTY_PURCHASE_RECEIPT_SUBMITTED_RESPONSE = 0x368,
            EVENT_THIRD_PARTY_PURCHASE_REQUEST = 800,
            EVENT_THIRD_PARTY_PURCHASE_SUCCESS = 810,
            EVENT_THIRD_PARTY_PURCHASE_SUCCESS_MALFORMED = 820,
            EVENT_WEB_LOGIN_ERROR = 410,
            EVENT_WEB_LOGIN_TOKEN_PROVIDED = 300
        }
    }
}

