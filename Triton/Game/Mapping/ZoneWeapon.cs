namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ZoneWeapon")]
    public class ZoneWeapon : Zone
    {
        public ZoneWeapon(IntPtr address) : this(address, "ZoneWeapon")
        {
        }

        public ZoneWeapon(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanAcceptTags(int controllerId, TAG_ZONE zoneTag, TAG_CARDTYPE cardType)
        {
            object[] objArray1 = new object[] { controllerId, zoneTag, cardType };
            return base.method_11<bool>("CanAcceptTags", objArray1);
        }

        public int RemoveCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<int>("RemoveCard", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public static float DESTROYED_WEAPON_WAIT_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneWeapon", "DESTROYED_WEAPON_WAIT_SEC");
            }
        }

        public static float FINAL_TRANSITION_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneWeapon", "FINAL_TRANSITION_SEC");
            }
        }

        public static float INTERMEDIATE_TRANSITION_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneWeapon", "INTERMEDIATE_TRANSITION_SEC");
            }
        }

        public static float INTERMEDIATE_Y_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneWeapon", "INTERMEDIATE_Y_OFFSET");
            }
        }

        public List<Card> m_destroyedWeapons
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_destroyedWeapons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

