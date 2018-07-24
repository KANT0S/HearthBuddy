namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("JaraxxusMinionSpell")]
    public class JaraxxusMinionSpell : Spell
    {
        public JaraxxusMinionSpell(IntPtr address) : this(address, "JaraxxusMinionSpell")
        {
        }

        public JaraxxusMinionSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public PowerTask FindFullEntityTask()
        {
            return base.method_14<PowerTask>("FindFullEntityTask", Array.Empty<object>());
        }

        public void Finish()
        {
            base.method_8("Finish", Array.Empty<object>());
        }

        public void MoveToHeroSpot(Card minionCard, Card heroCard, Zone heroZone)
        {
            object[] objArray1 = new object[] { minionCard, heroCard, heroZone };
            base.method_8("MoveToHeroSpot", objArray1);
        }

        public void MoveToSpellLocation(Card minionCard, Card heroCard)
        {
            object[] objArray1 = new object[] { minionCard, heroCard };
            base.method_8("MoveToSpellLocation", objArray1);
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void OnMoveToHeroSpotComplete()
        {
            base.method_8("OnMoveToHeroSpotComplete", Array.Empty<object>());
        }

        public float m_MoveToHeroSpotDelay
        {
            get
            {
                return base.method_2<float>("m_MoveToHeroSpotDelay");
            }
        }

        public float m_MoveToHeroSpotDuration
        {
            get
            {
                return base.method_2<float>("m_MoveToHeroSpotDuration");
            }
        }

        public iTween.EaseType m_MoveToHeroSpotEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_MoveToHeroSpotEaseType");
            }
        }

        public float m_MoveToLocationDelay
        {
            get
            {
                return base.method_2<float>("m_MoveToLocationDelay");
            }
        }

        public float m_MoveToLocationDuration
        {
            get
            {
                return base.method_2<float>("m_MoveToLocationDuration");
            }
        }

        public iTween.EaseType m_MoveToLocationEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_MoveToLocationEaseType");
            }
        }
    }
}

