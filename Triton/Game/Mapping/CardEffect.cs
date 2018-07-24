namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("CardEffect")]
    public class CardEffect : MonoClass
    {
        public CardEffect(IntPtr address) : this(address, "CardEffect")
        {
        }

        public CardEffect(IntPtr address, string className) : base(address, className)
        {
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public List<CardSoundSpell> GetSoundSpells(bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { loadIfNeeded };
            Class267<CardSoundSpell> class2 = base.method_14<Class267<CardSoundSpell>>("GetSoundSpells", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Spell GetSpell(bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { loadIfNeeded };
            return base.method_14<Spell>("GetSpell", objArray1);
        }

        public void LoadAll()
        {
            base.method_8("LoadAll", Array.Empty<object>());
        }

        public void LoadSoundSpell(int index)
        {
            object[] objArray1 = new object[] { index };
            base.method_8("LoadSoundSpell", objArray1);
        }

        public void LoadSpell()
        {
            base.method_8("LoadSpell", Array.Empty<object>());
        }

        public void PurgeInactiveSpells()
        {
            base.method_8("PurgeInactiveSpells", Array.Empty<object>());
        }

        public void TryPurge(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            base.method_8("TryPurge", objArray1);
        }

        public Card m_owner
        {
            get
            {
                return base.method_3<Card>("m_owner");
            }
        }

        public List<string> m_soundSpellPathes
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_soundSpellPathes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<CardSoundSpell> m_soundSpells
        {
            get
            {
                Class267<CardSoundSpell> class2 = base.method_3<Class267<CardSoundSpell>>("m_soundSpells");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Spell m_spell
        {
            get
            {
                return base.method_3<Spell>("m_spell");
            }
        }

        public string m_spellPath
        {
            get
            {
                return base.method_4("m_spellPath");
            }
        }
    }
}

