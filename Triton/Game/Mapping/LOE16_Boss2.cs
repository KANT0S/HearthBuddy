namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE16_Boss2")]
    public class LOE16_Boss2 : LOE_MissionEntity
    {
        public LOE16_Boss2(IntPtr address) : this(address, "LOE16_Boss2")
        {
        }

        public LOE16_Boss2(IntPtr address, string className) : base(address, className)
        {
        }

        public void InitEmoteResponses()
        {
            base.method_8("InitEmoteResponses", Array.Empty<object>());
        }

        public void OnTagChanged(TagDelta change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnTagChanged", objArray1);
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public void StartGameplaySoundtracks()
        {
            base.method_8("StartGameplaySoundtracks", Array.Empty<object>());
        }

        public string UpdateCardText(Card card, Actor bigCardActor, string text)
        {
            object[] objArray1 = new object[] { card, bigCardActor, text };
            return base.method_13("UpdateCardText", objArray1);
        }

        public bool m_artifactLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_artifactLinePlayed");
            }
        }

        public bool m_firstExplorerHelp
        {
            get
            {
                return base.method_2<bool>("m_firstExplorerHelp");
            }
        }
    }
}

