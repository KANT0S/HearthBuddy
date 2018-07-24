namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("WeaponSocketRequirement")]
    public class WeaponSocketRequirement : MonoClass
    {
        public WeaponSocketRequirement(IntPtr address) : this(address, "WeaponSocketRequirement")
        {
        }

        public WeaponSocketRequirement(IntPtr address, string className) : base(address, className)
        {
        }

        public bool m_HasWeapon
        {
            get
            {
                return base.method_2<bool>("m_HasWeapon");
            }
        }

        public Player.Side m_Side
        {
            get
            {
                return base.method_2<Player.Side>("m_Side");
            }
        }
    }
}

