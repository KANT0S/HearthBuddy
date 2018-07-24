namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Power")]
    public class Power : MonoClass
    {
        public Power(IntPtr address) : this(address, "Power")
        {
        }

        public Power(IntPtr address, string className) : base(address, className)
        {
        }

        public static Power GetDefaultAttackPower()
        {
            return MonoClass.smethod_15<Power>(TritonHs.MainAssemblyPath, "", "Power", "GetDefaultAttackPower", Array.Empty<object>());
        }

        public static Power GetDefaultMasterPower()
        {
            return MonoClass.smethod_15<Power>(TritonHs.MainAssemblyPath, "", "Power", "GetDefaultMasterPower", Array.Empty<object>());
        }

        public string GetDefinition()
        {
            return base.method_13("GetDefinition", Array.Empty<object>());
        }

        public PlayErrors.PlayRequirementInfo GetPlayRequirementInfo()
        {
            return base.method_14<PlayErrors.PlayRequirementInfo>("GetPlayRequirementInfo", Array.Empty<object>());
        }

        public string mDefinition
        {
            get
            {
                return base.method_4("mDefinition");
            }
        }

        public PlayErrors.PlayRequirementInfo mPlayRequirementInfo
        {
            get
            {
                return base.method_3<PlayErrors.PlayRequirementInfo>("mPlayRequirementInfo");
            }
        }

        public static Power s_defaultAttackPower
        {
            get
            {
                return MonoClass.smethod_7<Power>(TritonHs.MainAssemblyPath, "", "Power", "s_defaultAttackPower");
            }
        }

        public static Power s_defaultMasterPower
        {
            get
            {
                return MonoClass.smethod_7<Power>(TritonHs.MainAssemblyPath, "", "Power", "s_defaultMasterPower");
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PowerInfo
        {
            public PlayErrors.ErrorType reqId;
            public int param;
        }
    }
}

