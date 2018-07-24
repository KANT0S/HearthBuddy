namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PlatformSettings")]
    public class PlatformSettings : MonoClass
    {
        public PlatformSettings(IntPtr address) : this(address, "PlatformSettings")
        {
        }

        public PlatformSettings(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool EmulateMobileDevice()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "EmulateMobileDevice", Array.Empty<object>());
        }

        public static void RecomputeDeviceSettings()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "PlatformSettings", "RecomputeDeviceSettings");
        }

        public static void Refresh()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "PlatformSettings", "Refresh");
        }

        public static void SetAndroidSettings()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "PlatformSettings", "SetAndroidSettings");
        }

        public static void SetIOSSettings()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "PlatformSettings", "SetIOSSettings");
        }

        public static string DeviceName
        {
            get
            {
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "PlatformSettings", "get_DeviceName", Array.Empty<object>());
            }
        }

        public static InputCategory Input
        {
            get
            {
                return MonoClass.smethod_14<InputCategory>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "get_Input", Array.Empty<object>());
            }
        }

        public static MemoryCategory Memory
        {
            get
            {
                return MonoClass.smethod_14<MemoryCategory>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "get_Memory", Array.Empty<object>());
            }
        }

        public static OSCategory OS
        {
            get
            {
                return MonoClass.smethod_14<OSCategory>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "get_OS", Array.Empty<object>());
            }
        }

        public static InputCategory s_input
        {
            get
            {
                return MonoClass.smethod_6<InputCategory>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "s_input");
            }
        }

        public static bool s_isDeviceSupported
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "s_isDeviceSupported");
            }
        }

        public static MemoryCategory s_memory
        {
            get
            {
                return MonoClass.smethod_6<MemoryCategory>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "s_memory");
            }
        }

        public static OSCategory s_os
        {
            get
            {
                return MonoClass.smethod_6<OSCategory>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "s_os");
            }
        }

        public static ScreenCategory s_screen
        {
            get
            {
                return MonoClass.smethod_6<ScreenCategory>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "s_screen");
            }
        }

        public static ScreenDensityCategory s_screenDensity
        {
            get
            {
                return MonoClass.smethod_6<ScreenDensityCategory>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "s_screenDensity");
            }
        }

        public static ScreenCategory Screen
        {
            get
            {
                return MonoClass.smethod_14<ScreenCategory>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "get_Screen", Array.Empty<object>());
            }
        }

        public static ScreenDensityCategory ScreenDensity
        {
            get
            {
                return MonoClass.smethod_14<ScreenDensityCategory>(TritonHs.MainAssemblyPath, "", "PlatformSettings", "get_ScreenDensity", Array.Empty<object>());
            }
        }
    }
}

