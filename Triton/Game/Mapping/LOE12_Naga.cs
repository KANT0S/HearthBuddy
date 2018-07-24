namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE12_Naga")]
    public class LOE12_Naga : LOE_MissionEntity
    {
        public LOE12_Naga(IntPtr address) : this(address, "LOE12_Naga")
        {
        }

        public LOE12_Naga(IntPtr address, string className) : base(address, className)
        {
        }

        public void InitEmoteResponses()
        {
            base.method_8("InitEmoteResponses", Array.Empty<object>());
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public bool m_pearlLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_pearlLinePlayed");
            }
        }
    }
}

