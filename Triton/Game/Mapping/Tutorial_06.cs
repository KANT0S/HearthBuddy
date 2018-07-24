namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Tutorial_06")]
    public class Tutorial_06 : TutorialEntity
    {
        public Tutorial_06(IntPtr address) : this(address, "Tutorial_06")
        {
        }

        public Tutorial_06(IntPtr address, string className) : base(address, className)
        {
        }

        public Spell BlowUpHero(Card card, SpellType spellType)
        {
            object[] objArray1 = new object[] { card, spellType };
            return base.method_14<Spell>("BlowUpHero", objArray1);
        }

        public float GetAdditionalTimeToWaitForSpells()
        {
            return base.method_11<float>("GetAdditionalTimeToWaitForSpells", Array.Empty<object>());
        }

        public List<RewardData> GetCustomRewards()
        {
            Class267<RewardData> class2 = base.method_14<Class267<RewardData>>("GetCustomRewards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public bool IsKeywordHelpDelayOverridden()
        {
            return base.method_11<bool>("IsKeywordHelpDelayOverridden", Array.Empty<object>());
        }

        public void NotifyOfDefeatCoinAnimation()
        {
            base.method_8("NotifyOfDefeatCoinAnimation", Array.Empty<object>());
        }

        public bool NotifyOfEndTurnButtonPushed()
        {
            return base.method_11<bool>("NotifyOfEndTurnButtonPushed", Array.Empty<object>());
        }

        public void NotifyOfGameOver(TAG_PLAYSTATE gameResult)
        {
            object[] objArray1 = new object[] { gameResult };
            base.method_8("NotifyOfGameOver", objArray1);
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Notification endTurnNotifier
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("endTurnNotifier");
            }
        }

        public bool m_choSpeaking
        {
            get
            {
                return base.method_2<bool>("m_choSpeaking");
            }
        }

        public bool victory
        {
            get
            {
                return base.method_2<bool>("victory");
            }
        }
    }
}

