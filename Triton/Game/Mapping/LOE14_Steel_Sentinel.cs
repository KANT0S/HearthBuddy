namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE14_Steel_Sentinel")]
    public class LOE14_Steel_Sentinel : LOE_MissionEntity
    {
        public LOE14_Steel_Sentinel(IntPtr address) : this(address, "LOE14_Steel_Sentinel")
        {
        }

        public LOE14_Steel_Sentinel(IntPtr address, string className) : base(address, className)
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
    }
}

