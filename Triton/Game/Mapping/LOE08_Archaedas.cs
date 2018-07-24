namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE08_Archaedas")]
    public class LOE08_Archaedas : LOE_MissionEntity
    {
        public LOE08_Archaedas(IntPtr address) : this(address, "LOE08_Archaedas")
        {
        }

        public LOE08_Archaedas(IntPtr address, string className) : base(address, className)
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

