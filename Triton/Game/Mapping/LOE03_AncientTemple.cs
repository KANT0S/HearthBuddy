namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE03_AncientTemple")]
    public class LOE03_AncientTemple : LOE_MissionEntity
    {
        public LOE03_AncientTemple(IntPtr address) : this(address, "LOE03_AncientTemple")
        {
        }

        public LOE03_AncientTemple(IntPtr address, string className) : base(address, className)
        {
        }

        public string CustomChoiceBannerText()
        {
            return base.method_13("CustomChoiceBannerText", Array.Empty<object>());
        }

        public void InitTempleArt(int cost)
        {
            object[] objArray1 = new object[] { cost };
            base.method_8("InitTempleArt", objArray1);
        }

        public void InitTurnCounter(int cost)
        {
            object[] objArray1 = new object[] { cost };
            base.method_8("InitTurnCounter", objArray1);
        }

        public void InitVisuals()
        {
            base.method_8("InitVisuals", Array.Empty<object>());
        }

        public void NotifyOfMulliganEnded()
        {
            base.method_8("NotifyOfMulliganEnded", Array.Empty<object>());
        }

        public void NotifyOfMulliganInitialized()
        {
            base.method_8("NotifyOfMulliganInitialized", Array.Empty<object>());
        }

        public void OnTagChanged(TagDelta change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnTagChanged", objArray1);
        }

        public void PlayEmoteResponse(EmoteType emoteType, CardSoundSpell emoteSpell)
        {
            object[] objArray1 = new object[] { emoteType, emoteSpell };
            base.method_8("PlayEmoteResponse", objArray1);
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public bool ShouldHandleCoin()
        {
            return base.method_11<bool>("ShouldHandleCoin", Array.Empty<object>());
        }

        public void UpdateTempleArt(int cost)
        {
            object[] objArray1 = new object[] { cost };
            base.method_8("UpdateTempleArt", objArray1);
        }

        public void UpdateTurnCounter(int cost)
        {
            object[] objArray1 = new object[] { cost };
            base.method_8("UpdateTurnCounter", objArray1);
        }

        public void UpdateTurnCounterText(int cost)
        {
            object[] objArray1 = new object[] { cost };
            base.method_8("UpdateTurnCounterText", objArray1);
        }

        public void UpdateVisuals(int cost)
        {
            object[] objArray1 = new object[] { cost };
            base.method_8("UpdateVisuals", objArray1);
        }

        public int m_mostRecentMissionEvent
        {
            get
            {
                return base.method_2<int>("m_mostRecentMissionEvent");
            }
        }

        public TempleArt m_templeArt
        {
            get
            {
                return base.method_3<TempleArt>("m_templeArt");
            }
        }

        public Triton.Game.Mapping.Notification m_turnCounter
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_turnCounter");
            }
        }
    }
}

