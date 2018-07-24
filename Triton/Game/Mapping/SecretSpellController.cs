namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("SecretSpellController")]
    public class SecretSpellController : SpellController
    {
        public SecretSpellController(IntPtr address) : this(address, "SecretSpellController")
        {
        }

        public SecretSpellController(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerSourceAndTargets(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("AddPowerSourceAndTargets", objArray1);
        }

        public Spell DetermineBannerSpellPrefab(Triton.Game.Mapping.Entity sourceEntity)
        {
            object[] objArray1 = new object[] { sourceEntity };
            return base.method_14<Spell>("DetermineBannerSpellPrefab", objArray1);
        }

        public bool FireBannerSpell()
        {
            return base.method_11<bool>("FireBannerSpell", Array.Empty<object>());
        }

        public bool FireSecretActorSpell()
        {
            return base.method_11<bool>("FireSecretActorSpell", Array.Empty<object>());
        }

        public bool FireTriggerSpell()
        {
            return base.method_11<bool>("FireTriggerSpell", Array.Empty<object>());
        }

        public Spell GetTriggerSpell(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_14<Spell>("GetTriggerSpell", objArray1);
        }

        public bool InitBannerSpell(Triton.Game.Mapping.Entity sourceEntity)
        {
            object[] objArray1 = new object[] { sourceEntity };
            return base.method_11<bool>("InitBannerSpell", objArray1);
        }

        public bool InitTriggerSpell(Card card, Spell triggerSpell)
        {
            object[] objArray1 = new object[] { card, triggerSpell };
            return base.method_11<bool>("InitTriggerSpell", objArray1);
        }

        public void OnBannerSpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnBannerSpellStateFinished", objArray1);
        }

        public void OnProcessTaskList()
        {
            base.method_8("OnProcessTaskList", Array.Empty<object>());
        }

        public void OnTriggerSpellFinished(Spell triggerSpell, object userData)
        {
            object[] objArray1 = new object[] { triggerSpell, userData };
            base.method_8("OnTriggerSpellFinished", objArray1);
        }

        public void OnTriggerSpellStateFinished(Spell triggerSpell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { triggerSpell, prevStateType, userData };
            base.method_8("OnTriggerSpellStateFinished", objArray1);
        }

        public List<SecretBannerDef> m_BannerDefs
        {
            get
            {
                Class267<SecretBannerDef> class2 = base.method_3<Class267<SecretBannerDef>>("m_BannerDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Spell m_bannerSpell
        {
            get
            {
                return base.method_3<Spell>("m_bannerSpell");
            }
        }

        public Spell m_DefaultBannerSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_DefaultBannerSpellPrefab");
            }
        }

        public Spell m_triggerSpell
        {
            get
            {
                return base.method_3<Spell>("m_triggerSpell");
            }
        }
    }
}

