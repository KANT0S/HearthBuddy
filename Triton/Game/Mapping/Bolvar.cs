namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Bolvar")]
    public class Bolvar : SuperSpell
    {
        public Bolvar(IntPtr address) : this(address, "Bolvar")
        {
        }

        public Bolvar(IntPtr address, string className) : base(address, className)
        {
        }

        public Spell DetermineRangePrefab(int atk)
        {
            object[] objArray1 = new object[] { atk };
            return base.method_14<Spell>("DetermineRangePrefab", objArray1);
        }

        public int GetRangePrefabMax()
        {
            return base.method_11<int>("GetRangePrefabMax", Array.Empty<object>());
        }

        public int GetRangePrefabMin()
        {
            return base.method_11<int>("GetRangePrefabMin", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public List<AttackRangePrefabs> m_atkPrefabs
        {
            get
            {
                Class247<AttackRangePrefabs> class2 = base.method_3<Class247<AttackRangePrefabs>>("m_atkPrefabs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

