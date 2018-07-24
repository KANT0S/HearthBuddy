namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("SpellTable")]
    public class SpellTable : MonoBehaviour
    {
        public SpellTable(IntPtr address) : this(address, "SpellTable")
        {
        }

        public SpellTable(IntPtr address, string className) : base(address, className)
        {
        }

        public SpellTableEntry FindEntry(SpellType type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_14<SpellTableEntry>("FindEntry", objArray1);
        }

        public Spell GetSpell(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            return base.method_14<Spell>("GetSpell", objArray1);
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsLoaded(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            return base.method_11<bool>("IsLoaded", objArray1);
        }

        public void ReleaseAllSpells()
        {
            base.method_8("ReleaseAllSpells", Array.Empty<object>());
        }

        public void ReleaseSpell(GameObject spellObject)
        {
            object[] objArray1 = new object[] { spellObject };
            base.method_8("ReleaseSpell", objArray1);
        }

        public void SetSpell(SpellType type, Spell spell)
        {
            object[] objArray1 = new object[] { type, spell };
            base.method_8("SetSpell", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public List<SpellTableEntry> m_Table
        {
            get
            {
                Class267<SpellTableEntry> class2 = base.method_3<Class267<SpellTableEntry>>("m_Table");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

