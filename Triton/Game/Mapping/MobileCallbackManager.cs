namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MobileCallbackManager")]
    public class MobileCallbackManager : MonoBehaviour
    {
        public MobileCallbackManager(IntPtr address) : this(address, "MobileCallbackManager")
        {
        }

        public MobileCallbackManager(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool AreMotionEffectsEnabled()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "AreMotionEffectsEnabled", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static MobileCallbackManager Get()
        {
            return MonoClass.smethod_15<MobileCallbackManager>(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "Get", Array.Empty<object>());
        }

        public static uint GetMemoryUsage()
        {
            return MonoClass.smethod_14<uint>(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "GetMemoryUsage", Array.Empty<object>());
        }

        public static bool IsAndroidDeviceTabletSized()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "IsAndroidDeviceTabletSized", Array.Empty<object>());
        }

        public static bool IsDevice(string deviceModel)
        {
            object[] objArray1 = new object[] { deviceModel };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "IsDevice", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public static void RegisterForPushNotifications()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "RegisterForPushNotifications");
        }

        public static void RegisterPushNotifications()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "RegisterPushNotifications");
        }

        public static void SetBattleNetRegionAndGameLocale(int gameRegion, string gameLocale)
        {
            object[] objArray1 = new object[] { gameRegion, gameLocale };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "SetBattleNetRegionAndGameLocale", objArray1);
        }

        public static void SetRegionAndLocale(int gameRegion, string gameLocale)
        {
            object[] objArray1 = new object[] { gameRegion, gameLocale };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "SetRegionAndLocale", objArray1);
        }

        public static string CHINESE_COUNTRY_CODE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "CHINESE_COUNTRY_CODE");
            }
        }

        public static string CHINESE_CURRENCY_CODE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "CHINESE_CURRENCY_CODE");
            }
        }

        public bool m_wasBreakingNewsShown
        {
            get
            {
                return base.method_2<bool>("m_wasBreakingNewsShown");
            }
        }

        public static MobileCallbackManager s_Instance
        {
            get
            {
                return MonoClass.smethod_7<MobileCallbackManager>(TritonHs.MainAssemblyPath, "", "MobileCallbackManager", "s_Instance");
            }
        }
    }
}

