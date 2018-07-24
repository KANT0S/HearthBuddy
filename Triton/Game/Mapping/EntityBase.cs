namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("EntityBase")]
    public class EntityBase : MonoClass
    {
        public EntityBase(IntPtr address) : this(address, "EntityBase")
        {
        }

        public EntityBase(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanAttack()
        {
            return base.method_11<bool>("CanAttack", Array.Empty<object>());
        }

        public bool CanBeAttacked()
        {
            return base.method_11<bool>("CanBeAttacked", Array.Empty<object>());
        }

        public bool CanBeDamaged()
        {
            return base.method_11<bool>("CanBeDamaged", Array.Empty<object>());
        }

        public bool CanBeTargetedByAbilities()
        {
            return base.method_11<bool>("CanBeTargetedByAbilities", Array.Empty<object>());
        }

        public bool CanBeTargetedByBattlecries()
        {
            return base.method_11<bool>("CanBeTargetedByBattlecries", Array.Empty<object>());
        }

        public bool CanBeTargetedByHeroPowers()
        {
            return base.method_11<bool>("CanBeTargetedByHeroPowers", Array.Empty<object>());
        }

        public bool CanBeTargetedByOpponents()
        {
            return base.method_11<bool>("CanBeTargetedByOpponents", Array.Empty<object>());
        }

        public bool CannotAttackHeroes()
        {
            return base.method_11<bool>("CannotAttackHeroes", Array.Empty<object>());
        }

        public bool DontShowImmune()
        {
            return base.method_11<bool>("DontShowImmune", Array.Empty<object>());
        }

        public int GetArmor()
        {
            return base.method_11<int>("GetArmor", Array.Empty<object>());
        }

        public int GetATK()
        {
            return base.method_11<int>("GetATK", Array.Empty<object>());
        }

        public int GetAttached()
        {
            return base.method_11<int>("GetAttached", Array.Empty<object>());
        }

        public TAG_CARD_SET GetCardSet()
        {
            return base.method_11<TAG_CARD_SET>("GetCardSet", Array.Empty<object>());
        }

        public TAG_CARDTYPE GetCardType()
        {
            return base.method_11<TAG_CARDTYPE>("GetCardType", Array.Empty<object>());
        }

        public int GetControllerId()
        {
            return base.method_11<int>("GetControllerId", Array.Empty<object>());
        }

        public int GetCost()
        {
            return base.method_11<int>("GetCost", Array.Empty<object>());
        }

        public int GetCreatorId()
        {
            return base.method_11<int>("GetCreatorId", Array.Empty<object>());
        }

        public int GetDamage()
        {
            return base.method_11<int>("GetDamage", Array.Empty<object>());
        }

        public int GetDisplayedCreatorId()
        {
            return base.method_11<int>("GetDisplayedCreatorId", Array.Empty<object>());
        }

        public int GetDurability()
        {
            return base.method_11<int>("GetDurability", Array.Empty<object>());
        }

        public int GetEntityId()
        {
            return base.method_11<int>("GetEntityId", Array.Empty<object>());
        }

        public int GetFatigue()
        {
            return base.method_11<int>("GetFatigue", Array.Empty<object>());
        }

        public int GetHealth()
        {
            return base.method_11<int>("GetHealth", Array.Empty<object>());
        }

        public int GetNumAttacksThisTurn()
        {
            return base.method_11<int>("GetNumAttacksThisTurn", Array.Empty<object>());
        }

        public int GetNumTurnsInPlay()
        {
            return base.method_11<int>("GetNumTurnsInPlay", Array.Empty<object>());
        }

        public int GetReferencedTag(int tag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag };
            return base.method_10<int>("GetReferencedTag", enumArray1, objArray1);
        }

        public int GetReferencedTag(GAME_TAG enumTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { enumTag };
            return base.method_10<int>("GetReferencedTag", enumArray1, objArray1);
        }

        public int GetRemainingHP()
        {
            return base.method_11<int>("GetRemainingHP", Array.Empty<object>());
        }

        public int GetSpellPower()
        {
            return base.method_11<int>("GetSpellPower", Array.Empty<object>());
        }

        public string GetStringTag(int tag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag };
            return base.method_12("GetStringTag", enumArray1, objArray1);
        }

        public string GetStringTag(GAME_TAG enumTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { enumTag };
            return base.method_12("GetStringTag", enumArray1, objArray1);
        }

        public int GetTag(int tag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag };
            return base.method_10<int>("GetTag", enumArray1, objArray1);
        }

        public int GetTag(GAME_TAG enumTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { enumTag };
            return base.method_10<int>("GetTag", enumArray1, objArray1);
        }

        public TagSet GetTags()
        {
            return base.method_14<TagSet>("GetTags", Array.Empty<object>());
        }

        public int GetWindfury()
        {
            return base.method_11<int>("GetWindfury", Array.Empty<object>());
        }

        public TAG_ZONE GetZone()
        {
            return base.method_11<TAG_ZONE>("GetZone", Array.Empty<object>());
        }

        public int GetZonePosition()
        {
            return base.method_11<int>("GetZonePosition", Array.Empty<object>());
        }

        public bool HasAura()
        {
            return base.method_11<bool>("HasAura", Array.Empty<object>());
        }

        public bool HasBattlecry()
        {
            return base.method_11<bool>("HasBattlecry", Array.Empty<object>());
        }

        public bool HasCharge()
        {
            return base.method_11<bool>("HasCharge", Array.Empty<object>());
        }

        public bool HasCombo()
        {
            return base.method_11<bool>("HasCombo", Array.Empty<object>());
        }

        public bool HasCustomKeywordEffect()
        {
            return base.method_11<bool>("HasCustomKeywordEffect", Array.Empty<object>());
        }

        public bool HasDeathrattle()
        {
            return base.method_11<bool>("HasDeathrattle", Array.Empty<object>());
        }

        public bool HasDivineShield()
        {
            return base.method_11<bool>("HasDivineShield", Array.Empty<object>());
        }

        public bool HasEvilGlow()
        {
            return base.method_11<bool>("HasEvilGlow", Array.Empty<object>());
        }

        public bool HasHealthMin()
        {
            return base.method_11<bool>("HasHealthMin", Array.Empty<object>());
        }

        public bool HasHeroPowerDamage()
        {
            return base.method_11<bool>("HasHeroPowerDamage", Array.Empty<object>());
        }

        public bool HasInspire()
        {
            return base.method_11<bool>("HasInspire", Array.Empty<object>());
        }

        public bool HasOverload()
        {
            return base.method_11<bool>("HasOverload", Array.Empty<object>());
        }

        public bool HasReferencedTag(int tag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag };
            return base.method_10<bool>("HasReferencedTag", enumArray1, objArray1);
        }

        public bool HasReferencedTag(GAME_TAG enumTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { enumTag };
            return base.method_10<bool>("HasReferencedTag", enumArray1, objArray1);
        }

        public bool HasSpellPower()
        {
            return base.method_11<bool>("HasSpellPower", Array.Empty<object>());
        }

        public bool HasSpellPowerDouble()
        {
            return base.method_11<bool>("HasSpellPowerDouble", Array.Empty<object>());
        }

        public bool HasStringTag(int tag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag };
            return base.method_10<bool>("HasStringTag", enumArray1, objArray1);
        }

        public bool HasStringTag(GAME_TAG enumTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { enumTag };
            return base.method_10<bool>("HasStringTag", enumArray1, objArray1);
        }

        public bool HasTag(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            return base.method_11<bool>("HasTag", objArray1);
        }

        public bool HasTaunt()
        {
            return base.method_11<bool>("HasTaunt", Array.Empty<object>());
        }

        public bool HasTriggerVisual()
        {
            return base.method_11<bool>("HasTriggerVisual", Array.Empty<object>());
        }

        public bool HasWindfury()
        {
            return base.method_11<bool>("HasWindfury", Array.Empty<object>());
        }

        public bool IsAffectedBySpellPower()
        {
            return base.method_11<bool>("IsAffectedBySpellPower", Array.Empty<object>());
        }

        public bool IsAsleep()
        {
            return base.method_11<bool>("IsAsleep", Array.Empty<object>());
        }

        public bool IsAttached()
        {
            return base.method_11<bool>("IsAttached", Array.Empty<object>());
        }

        public bool IsBasicCardUnlock()
        {
            return base.method_11<bool>("IsBasicCardUnlock", Array.Empty<object>());
        }

        public bool IsCharacter()
        {
            return base.method_11<bool>("IsCharacter", Array.Empty<object>());
        }

        public bool IsDamaged()
        {
            return base.method_11<bool>("IsDamaged", Array.Empty<object>());
        }

        public bool IsElite()
        {
            return base.method_11<bool>("IsElite", Array.Empty<object>());
        }

        public bool IsEnchantment()
        {
            return base.method_11<bool>("IsEnchantment", Array.Empty<object>());
        }

        public bool IsEnraged()
        {
            return base.method_11<bool>("IsEnraged", Array.Empty<object>());
        }

        public bool IsExhausted()
        {
            return base.method_11<bool>("IsExhausted", Array.Empty<object>());
        }

        public bool IsFreeze()
        {
            return base.method_11<bool>("IsFreeze", Array.Empty<object>());
        }

        public bool IsFrozen()
        {
            return base.method_11<bool>("IsFrozen", Array.Empty<object>());
        }

        public bool IsGame()
        {
            return base.method_11<bool>("IsGame", Array.Empty<object>());
        }

        public bool IsHero()
        {
            return base.method_11<bool>("IsHero", Array.Empty<object>());
        }

        public bool IsHeroPower()
        {
            return base.method_11<bool>("IsHeroPower", Array.Empty<object>());
        }

        public bool IsImmune()
        {
            return base.method_11<bool>("IsImmune", Array.Empty<object>());
        }

        public bool IsItem()
        {
            return base.method_11<bool>("IsItem", Array.Empty<object>());
        }

        public bool IsMagnet()
        {
            return base.method_11<bool>("IsMagnet", Array.Empty<object>());
        }

        public bool IsMinion()
        {
            return base.method_11<bool>("IsMinion", Array.Empty<object>());
        }

        public bool IsObfuscated()
        {
            return base.method_11<bool>("IsObfuscated", Array.Empty<object>());
        }

        public bool IsPlayer()
        {
            return base.method_11<bool>("IsPlayer", Array.Empty<object>());
        }

        public bool IsPoisonous()
        {
            return base.method_11<bool>("IsPoisonous", Array.Empty<object>());
        }

        public bool IsRecentlyArrived()
        {
            return base.method_11<bool>("IsRecentlyArrived", Array.Empty<object>());
        }

        public bool IsSecret()
        {
            return base.method_11<bool>("IsSecret", Array.Empty<object>());
        }

        public bool IsSilenced()
        {
            return base.method_11<bool>("IsSilenced", Array.Empty<object>());
        }

        public bool IsSpell()
        {
            return base.method_11<bool>("IsSpell", Array.Empty<object>());
        }

        public bool IsStealthed()
        {
            return base.method_11<bool>("IsStealthed", Array.Empty<object>());
        }

        public bool IsToken()
        {
            return base.method_11<bool>("IsToken", Array.Empty<object>());
        }

        public bool IsWeapon()
        {
            return base.method_11<bool>("IsWeapon", Array.Empty<object>());
        }

        public bool ReferencesBattlecry()
        {
            return base.method_11<bool>("ReferencesBattlecry", Array.Empty<object>());
        }

        public bool ReferencesCharge()
        {
            return base.method_11<bool>("ReferencesCharge", Array.Empty<object>());
        }

        public bool ReferencesDeathrattle()
        {
            return base.method_11<bool>("ReferencesDeathrattle", Array.Empty<object>());
        }

        public bool ReferencesDivineShield()
        {
            return base.method_11<bool>("ReferencesDivineShield", Array.Empty<object>());
        }

        public bool ReferencesImmune()
        {
            return base.method_11<bool>("ReferencesImmune", Array.Empty<object>());
        }

        public bool ReferencesSecret()
        {
            return base.method_11<bool>("ReferencesSecret", Array.Empty<object>());
        }

        public bool ReferencesSpellPower()
        {
            return base.method_11<bool>("ReferencesSpellPower", Array.Empty<object>());
        }

        public bool ReferencesStealth()
        {
            return base.method_11<bool>("ReferencesStealth", Array.Empty<object>());
        }

        public bool ReferencesTaunt()
        {
            return base.method_11<bool>("ReferencesTaunt", Array.Empty<object>());
        }

        public bool ReferencesWindfury()
        {
            return base.method_11<bool>("ReferencesWindfury", Array.Empty<object>());
        }

        public void ReplaceTags(TagSet tags)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { tags };
            base.method_9("ReplaceTags", enumArray1, objArray1);
        }

        public void SetTag(int tag, int tagValue)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag, tagValue };
            base.method_9("SetTag", enumArray1, objArray1);
        }

        public void SetTag(GAME_TAG tag, int tagValue)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag, tagValue };
            base.method_9("SetTag", enumArray1, objArray1);
        }

        public TagSet m_tags
        {
            get
            {
                return base.method_3<TagSet>("m_tags");
            }
        }
    }
}

