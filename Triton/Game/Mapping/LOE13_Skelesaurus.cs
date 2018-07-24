namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE13_Skelesaurus")]
    public class LOE13_Skelesaurus : LOE_MissionEntity
    {
        public LOE13_Skelesaurus(IntPtr address) : this(address, "LOE13_Skelesaurus")
        {
        }

        public LOE13_Skelesaurus(IntPtr address, string className) : base(address, className)
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

