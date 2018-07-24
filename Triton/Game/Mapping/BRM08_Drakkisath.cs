namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM08_Drakkisath")]
    public class BRM08_Drakkisath : BRM_MissionEntity
    {
        public BRM08_Drakkisath(IntPtr address) : this(address, "BRM08_Drakkisath")
        {
        }

        public BRM08_Drakkisath(IntPtr address, string className) : base(address, className)
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

