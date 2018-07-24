namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("HistoryInfo")]
    public class HistoryInfo : MonoClass
    {
        public HistoryInfo(IntPtr address) : this(address, "HistoryInfo")
        {
        }

        public HistoryInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public void CacheBonuses()
        {
            base.method_8("CacheBonuses", Array.Empty<object>());
        }

        public bool CanCacheBonuses()
        {
            return base.method_11<bool>("CanCacheBonuses", Array.Empty<object>());
        }

        public bool CanDuplicateEntity()
        {
            return base.method_11<bool>("CanDuplicateEntity", Array.Empty<object>());
        }

        public void DuplicateEntity()
        {
            base.method_8("DuplicateEntity", Array.Empty<object>());
        }

        public Card GetCard()
        {
            return base.method_14<Card>("GetCard", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetDuplicatedEntity()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetDuplicatedEntity", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetOriginalEntity()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetOriginalEntity", Array.Empty<object>());
        }

        public int GetSplatAmount()
        {
            return base.method_11<int>("GetSplatAmount", Array.Empty<object>());
        }

        public void SetOriginalEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("SetOriginalEntity", objArray1);
        }

        public int m_armorChangeAmount
        {
            get
            {
                return base.method_2<int>("m_armorChangeAmount");
            }
        }

        public Material m_bigCardGoldenMaterial
        {
            get
            {
                return base.method_3<Material>("m_bigCardGoldenMaterial");
            }
        }

        public Texture m_bigCardPortraitTexture
        {
            get
            {
                return base.method_3<Texture>("m_bigCardPortraitTexture");
            }
        }

        public bool m_cachedBonuses
        {
            get
            {
                return base.method_2<bool>("m_cachedBonuses");
            }
        }

        public int m_damageChangeAmount
        {
            get
            {
                return base.method_2<int>("m_damageChangeAmount");
            }
        }

        public bool m_died
        {
            get
            {
                return base.method_2<bool>("m_died");
            }
        }

        public Triton.Game.Mapping.Entity m_duplicatedEntity
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_duplicatedEntity");
            }
        }

        public HistoryInfoType m_infoType
        {
            get
            {
                return base.method_2<HistoryInfoType>("m_infoType");
            }
        }

        public int m_originalDamageBonus
        {
            get
            {
                return base.method_2<int>("m_originalDamageBonus");
            }
        }

        public int m_originalDamageBonusDouble
        {
            get
            {
                return base.method_2<int>("m_originalDamageBonusDouble");
            }
        }

        public Triton.Game.Mapping.Entity m_originalEntity
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_originalEntity");
            }
        }

        public int m_originalHealingDouble
        {
            get
            {
                return base.method_2<int>("m_originalHealingDouble");
            }
        }
    }
}

