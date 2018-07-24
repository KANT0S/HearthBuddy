namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("BRMAnvilWeapons")]
    public class BRMAnvilWeapons : MonoBehaviour
    {
        public BRMAnvilWeapons(IntPtr address) : this(address, "BRMAnvilWeapons")
        {
        }

        public BRMAnvilWeapons(IntPtr address, string className) : base(address, className)
        {
        }

        public int RandomSubWeapon(AnvilWeapon weapon)
        {
            object[] objArray1 = new object[] { weapon };
            return base.method_11<int>("RandomSubWeapon", objArray1);
        }

        public void RandomWeaponEvent()
        {
            base.method_8("RandomWeaponEvent", Array.Empty<object>());
        }

        public int m_LastWeaponIndex
        {
            get
            {
                return base.method_2<int>("m_LastWeaponIndex");
            }
        }

        public List<AnvilWeapon> m_Weapons
        {
            get
            {
                Class267<AnvilWeapon> class2 = base.method_3<Class267<AnvilWeapon>>("m_Weapons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        [Attribute38("BRMAnvilWeapons.AnvilWeapon")]
        public class AnvilWeapon : MonoClass
        {
            public AnvilWeapon(IntPtr address) : this(address, "AnvilWeapon")
            {
            }

            public AnvilWeapon(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_CurrentWeaponIndex
            {
                get
                {
                    return base.method_2<int>("m_CurrentWeaponIndex");
                }
            }

            public List<string> m_Events
            {
                get
                {
                    Class268 class2 = base.method_3<Class268>("m_Events");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }
    }
}

