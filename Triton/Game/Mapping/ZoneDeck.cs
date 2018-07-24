namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ZoneDeck")]
    public class ZoneDeck : Zone
    {
        public ZoneDeck(IntPtr address) : this(address, "ZoneDeck")
        {
        }

        public ZoneDeck(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AreEmotesSuppressed()
        {
            return base.method_11<bool>("AreEmotesSuppressed", Array.Empty<object>());
        }

        public void DoFatigueGlow()
        {
            base.method_8("DoFatigueGlow", Array.Empty<object>());
        }

        public GameObject GetActiveThickness()
        {
            return base.method_14<GameObject>("GetActiveThickness", Array.Empty<object>());
        }

        public GameObject GetThicknessForLayout()
        {
            return base.method_14<GameObject>("GetThicknessForLayout", Array.Empty<object>());
        }

        public bool IsFatigued()
        {
            return base.method_11<bool>("IsFatigued", Array.Empty<object>());
        }

        public void SetCardToInDeckState(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("SetCardToInDeckState", objArray1);
        }

        public void SetSuppressEmotes(bool suppress)
        {
            object[] objArray1 = new object[] { suppress };
            base.method_8("SetSuppressEmotes", objArray1);
        }

        public void SetVisibility(bool visible)
        {
            object[] objArray1 = new object[] { visible };
            base.method_8("SetVisibility", objArray1);
        }

        public void UpdateDeckStateEmotes()
        {
            base.method_8("UpdateDeckStateEmotes", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateThickness()
        {
            base.method_8("UpdateThickness", Array.Empty<object>());
        }

        public Spell m_DeckFatigueGlow
        {
            get
            {
                return base.method_3<Spell>("m_DeckFatigueGlow");
            }
        }

        public bool m_suppressEmotes
        {
            get
            {
                return base.method_2<bool>("m_suppressEmotes");
            }
        }

        public GameObject m_Thickness1
        {
            get
            {
                return base.method_3<GameObject>("m_Thickness1");
            }
        }

        public GameObject m_Thickness25
        {
            get
            {
                return base.method_3<GameObject>("m_Thickness25");
            }
        }

        public GameObject m_Thickness50
        {
            get
            {
                return base.method_3<GameObject>("m_Thickness50");
            }
        }

        public GameObject m_Thickness75
        {
            get
            {
                return base.method_3<GameObject>("m_Thickness75");
            }
        }

        public GameObject m_ThicknessFull
        {
            get
            {
                return base.method_3<GameObject>("m_ThicknessFull");
            }
        }

        public bool m_warnedAboutLastCard
        {
            get
            {
                return base.method_2<bool>("m_warnedAboutLastCard");
            }
        }

        public bool m_warnedAboutNoCards
        {
            get
            {
                return base.method_2<bool>("m_warnedAboutNoCards");
            }
        }

        public bool m_wasFatigued
        {
            get
            {
                return base.method_2<bool>("m_wasFatigued");
            }
        }

        public static int MAX_THICKNESS_CARD_COUNT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ZoneDeck", "MAX_THICKNESS_CARD_COUNT");
            }
        }
    }
}

