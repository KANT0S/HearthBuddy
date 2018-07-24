namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CardColorSwitcher")]
    public class CardColorSwitcher : MonoBehaviour
    {
        public CardColorSwitcher(IntPtr address) : this(address, "CardColorSwitcher")
        {
        }

        public CardColorSwitcher(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static CardColorSwitcher Get()
        {
            return MonoClass.smethod_15<CardColorSwitcher>(TritonHs.MainAssemblyPath, "", "CardColorSwitcher", "Get", Array.Empty<object>());
        }

        public Texture GetMinionTexture(CardColorType colorType)
        {
            object[] objArray1 = new object[] { colorType };
            return base.method_14<Texture>("GetMinionTexture", objArray1);
        }

        public Texture GetPremiumMinionTexture(CardColorType colorType)
        {
            object[] objArray1 = new object[] { colorType };
            return base.method_14<Texture>("GetPremiumMinionTexture", objArray1);
        }

        public Texture GetSpellTexture(CardColorType colorType)
        {
            object[] objArray1 = new object[] { colorType };
            return base.method_14<Texture>("GetSpellTexture", objArray1);
        }

        public Texture GetWeaponTexture(CardColorType colorType)
        {
            object[] objArray1 = new object[] { colorType };
            return base.method_14<Texture>("GetWeaponTexture", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public List<Texture> minionCardTextures
        {
            get
            {
                Class247<Texture> class2 = base.method_3<Class247<Texture>>("minionCardTextures");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Texture> premiumMinionCardTextures
        {
            get
            {
                Class247<Texture> class2 = base.method_3<Class247<Texture>>("premiumMinionCardTextures");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Texture> spellCardTextures
        {
            get
            {
                Class247<Texture> class2 = base.method_3<Class247<Texture>>("spellCardTextures");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Texture> weaponCardTextures
        {
            get
            {
                Class247<Texture> class2 = base.method_3<Class247<Texture>>("weaponCardTextures");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public enum CardColorType
        {
            TYPE_GENERIC,
            TYPE_WARLOCK,
            TYPE_ROGUE,
            TYPE_DRUID,
            TYPE_SHAMAN,
            TYPE_HUNTER,
            TYPE_MAGE,
            TYPE_PALADIN,
            TYPE_PRIEST,
            TYPE_WARRIOR
        }
    }
}

