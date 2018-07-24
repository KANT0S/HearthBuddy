namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE09_LordSlitherspear")]
    public class LOE09_LordSlitherspear : LOE_MissionEntity
    {
        public LOE09_LordSlitherspear(IntPtr address) : this(address, "LOE09_LordSlitherspear")
        {
        }

        public LOE09_LordSlitherspear(IntPtr address, string className) : base(address, className)
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

        public Card m_cauldronCard
        {
            get
            {
                return base.method_3<Card>("m_cauldronCard");
            }
        }

        public bool m_finley_death_line
        {
            get
            {
                return base.method_2<bool>("m_finley_death_line");
            }
        }

        public bool m_finley_saved
        {
            get
            {
                return base.method_2<bool>("m_finley_saved");
            }
        }
    }
}

