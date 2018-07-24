namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("RichPresence")]
    public class RichPresence : MonoClass
    {
        public RichPresence(IntPtr address) : this(address, "RichPresence")
        {
        }

        public RichPresence(IntPtr address, string className) : base(address, className)
        {
        }

        public static uint FIELD_INDEX_START
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "RichPresence", "FIELD_INDEX_START");
            }
        }

        public static FourCC SCENARIOS_STREAMID
        {
            get
            {
                return MonoClass.smethod_7<FourCC>(TritonHs.MainAssemblyPath, "", "RichPresence", "SCENARIOS_STREAMID");
            }
        }

        public static FourCC STATUS_STREAMID
        {
            get
            {
                return MonoClass.smethod_7<FourCC>(TritonHs.MainAssemblyPath, "", "RichPresence", "STATUS_STREAMID");
            }
        }

        public static FourCC TUTORIAL_STREAMID
        {
            get
            {
                return MonoClass.smethod_7<FourCC>(TritonHs.MainAssemblyPath, "", "RichPresence", "TUTORIAL_STREAMID");
            }
        }
    }
}

