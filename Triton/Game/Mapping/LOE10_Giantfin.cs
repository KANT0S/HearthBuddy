namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE10_Giantfin")]
    public class LOE10_Giantfin : LOE_MissionEntity
    {
        public LOE10_Giantfin(IntPtr address) : this(address, "LOE10_Giantfin")
        {
        }

        public LOE10_Giantfin(IntPtr address, string className) : base(address, className)
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

        public void StartGameplaySoundtracks()
        {
            base.method_8("StartGameplaySoundtracks", Array.Empty<object>());
        }

        public bool m_cardLinePlayed1
        {
            get
            {
                return base.method_2<bool>("m_cardLinePlayed1");
            }
        }

        public bool m_cardLinePlayed2
        {
            get
            {
                return base.method_2<bool>("m_cardLinePlayed2");
            }
        }

        public bool m_nyahLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_nyahLinePlayed");
            }
        }

        public int m_turnToPlayFoundLine
        {
            get
            {
                return base.method_2<int>("m_turnToPlayFoundLine");
            }
        }
    }
}

