namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("DevicePreset")]
    public class DevicePreset : MonoClass
    {
        public DevicePreset(IntPtr address) : this(address, "DevicePreset")
        {
        }

        public DevicePreset(IntPtr address, string className) : base(address, className)
        {
        }

        public object Clone()
        {
            return base.method_14<object>("Clone", Array.Empty<object>());
        }

        public void ReadFromConfig(ConfigFile config)
        {
            object[] objArray1 = new object[] { config };
            base.method_8("ReadFromConfig", objArray1);
        }

        public void WriteToConfig(ConfigFile config)
        {
            object[] objArray1 = new object[] { config };
            base.method_8("WriteToConfig", objArray1);
        }

        public InputCategory input
        {
            get
            {
                return base.method_2<InputCategory>("input");
            }
        }

        public string name
        {
            get
            {
                return base.method_4("name");
            }
        }

        public OSCategory os
        {
            get
            {
                return base.method_2<OSCategory>("os");
            }
        }

        public ScreenCategory screen
        {
            get
            {
                return base.method_2<ScreenCategory>("screen");
            }
        }

        public ScreenDensityCategory screenDensity
        {
            get
            {
                return base.method_2<ScreenDensityCategory>("screenDensity");
            }
        }
    }
}

