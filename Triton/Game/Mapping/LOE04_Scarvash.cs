namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE04_Scarvash")]
    public class LOE04_Scarvash : LOE_MissionEntity
    {
        public LOE04_Scarvash(IntPtr address) : this(address, "LOE04_Scarvash")
        {
        }

        public LOE04_Scarvash(IntPtr address, string className) : base(address, className)
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

