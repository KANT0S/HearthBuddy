namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE07_MineCart")]
    public class LOE07_MineCart : LOE_MissionEntity
    {
        public LOE07_MineCart(IntPtr address) : this(address, "LOE07_MineCart")
        {
        }

        public LOE07_MineCart(IntPtr address, string className) : base(address, className)
        {
        }

        public void InitMineCartArt()
        {
            base.method_8("InitMineCartArt", Array.Empty<object>());
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

        public bool ShouldDoAlternateMulliganIntro()
        {
            return base.method_11<bool>("ShouldDoAlternateMulliganIntro", Array.Empty<object>());
        }

        public bool ShouldHandleCoin()
        {
            return base.method_11<bool>("ShouldHandleCoin", Array.Empty<object>());
        }

        public void StartGameplaySoundtracks()
        {
            base.method_8("StartGameplaySoundtracks", Array.Empty<object>());
        }

        public void UpdateMineCartArt()
        {
            base.method_8("UpdateMineCartArt", Array.Empty<object>());
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

        public MineCartRushArt m_mineCartArt
        {
            get
            {
                return base.method_3<MineCartRushArt>("m_mineCartArt");
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

