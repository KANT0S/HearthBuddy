namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ArmorSpell")]
    public class ArmorSpell : Spell
    {
        public ArmorSpell(IntPtr address) : this(address, "ArmorSpell")
        {
        }

        public ArmorSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public int GetArmor()
        {
            return base.method_11<int>("GetArmor", Array.Empty<object>());
        }

        public void SetArmor(int armor)
        {
            object[] objArray1 = new object[] { armor };
            base.method_8("SetArmor", objArray1);
        }

        public void UpdateArmorText()
        {
            base.method_8("UpdateArmorText", Array.Empty<object>());
        }

        public int m_armor
        {
            get
            {
                return base.method_2<int>("m_armor");
            }
        }

        public UberText m_ArmorText
        {
            get
            {
                return base.method_3<UberText>("m_ArmorText");
            }
        }
    }
}

