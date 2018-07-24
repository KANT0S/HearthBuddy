namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AndroidDeviceSettings")]
    public class AndroidDeviceSettings : MonoClass
    {
        public AndroidDeviceSettings(IntPtr address) : this(address, "AndroidDeviceSettings")
        {
        }

        public AndroidDeviceSettings(IntPtr address, string className) : base(address, className)
        {
        }

        public static AndroidDeviceSettings Get()
        {
            return MonoClass.smethod_15<AndroidDeviceSettings>(TritonHs.MainAssemblyPath, "", "AndroidDeviceSettings", "Get", Array.Empty<object>());
        }

        public static bool IsCurrentTextureFormatSupported()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AndroidDeviceSettings", "IsCurrentTextureFormatSupported", Array.Empty<object>());
        }

        public bool IsMusicPlaying()
        {
            return base.method_11<bool>("IsMusicPlaying", Array.Empty<object>());
        }

        public string applicationStorageFolder
        {
            get
            {
                return base.method_4("applicationStorageFolder");
            }
        }

        public float aspectRatio
        {
            get
            {
                return base.method_2<float>("aspectRatio");
            }
        }

        public int densityDpi
        {
            get
            {
                return base.method_2<int>("densityDpi");
            }
        }

        public float diagonalInches
        {
            get
            {
                return base.method_2<float>("diagonalInches");
            }
        }

        public float heightInches
        {
            get
            {
                return base.method_2<float>("heightInches");
            }
        }

        public float heightPixels
        {
            get
            {
                return base.method_2<float>("heightPixels");
            }
        }

        public bool isExtraLarge
        {
            get
            {
                return base.method_2<bool>("isExtraLarge");
            }
        }

        public bool isOnPhoneWhitelist
        {
            get
            {
                return base.method_2<bool>("isOnPhoneWhitelist");
            }
        }

        public bool isOnTabletWhitelist
        {
            get
            {
                return base.method_2<bool>("isOnTabletWhitelist");
            }
        }

        public int screenLayout
        {
            get
            {
                return base.method_2<int>("screenLayout");
            }
        }

        public static int SCREENLAYOUT_SIZE_XLARGE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AndroidDeviceSettings", "SCREENLAYOUT_SIZE_XLARGE");
            }
        }

        public float widthInches
        {
            get
            {
                return base.method_2<float>("widthInches");
            }
        }

        public float widthPixels
        {
            get
            {
                return base.method_2<float>("widthPixels");
            }
        }

        public float xdpi
        {
            get
            {
                return base.method_2<float>("xdpi");
            }
        }

        public float ydpi
        {
            get
            {
                return base.method_2<float>("ydpi");
            }
        }
    }
}

