namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX15_KelThuzad")]
    public class NAX15_KelThuzad : NAX_MissionEntity
    {
        public NAX15_KelThuzad(IntPtr address) : this(address, "NAX15_KelThuzad")
        {
        }

        public NAX15_KelThuzad(IntPtr address, string className) : base(address, className)
        {
        }

        public void HandleRealTimeMissionEvent(int missionEvent)
        {
            object[] objArray1 = new object[] { missionEvent };
            base.method_8("HandleRealTimeMissionEvent", objArray1);
        }

        public void OnPlayThinkEmote()
        {
            base.method_8("OnPlayThinkEmote", Array.Empty<object>());
        }

        public void OnStealTurnSpellLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnStealTurnSpellLoaded", objArray1);
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

        public bool m_bigglesLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_bigglesLinePlayed");
            }
        }

        public bool m_frostHeroPowerLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_frostHeroPowerLinePlayed");
            }
        }

        public bool m_hurryLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_hurryLinePlayed");
            }
        }

        public int m_numTimesMindControlPlayed
        {
            get
            {
                return base.method_2<int>("m_numTimesMindControlPlayed");
            }
        }
    }
}

