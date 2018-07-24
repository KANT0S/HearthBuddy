namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM11_Vaelastrasz")]
    public class BRM11_Vaelastrasz : BRM_MissionEntity
    {
        public BRM11_Vaelastrasz(IntPtr address) : this(address, "BRM11_Vaelastrasz")
        {
        }

        public BRM11_Vaelastrasz(IntPtr address, string className) : base(address, className)
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

        public bool m_cardLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_cardLinePlayed");
            }
        }
    }
}

