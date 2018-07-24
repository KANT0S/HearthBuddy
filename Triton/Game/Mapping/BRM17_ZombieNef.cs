namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM17_ZombieNef")]
    public class BRM17_ZombieNef : BRM_MissionEntity
    {
        public BRM17_ZombieNef(IntPtr address) : this(address, "BRM17_ZombieNef")
        {
        }

        public BRM17_ZombieNef(IntPtr address, string className) : base(address, className)
        {
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

        public bool m_cardLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_cardLinePlayed");
            }
        }

        public bool m_heroPowerLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPowerLinePlayed");
            }
        }

        public bool m_inOnyxiaState
        {
            get
            {
                return base.method_2<bool>("m_inOnyxiaState");
            }
        }

        public Actor m_nefActor
        {
            get
            {
                return base.method_3<Actor>("m_nefActor");
            }
        }
    }
}

