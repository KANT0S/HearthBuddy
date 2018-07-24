namespace Triton.Game.Abstraction
{
    using System;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class EntityBase
    {
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        [CompilerGenerated]
        private bool bool_10;
        [CompilerGenerated]
        private bool bool_11;
        [CompilerGenerated]
        private bool bool_12;
        [CompilerGenerated]
        private bool bool_13;
        [CompilerGenerated]
        private bool bool_14;
        [CompilerGenerated]
        private bool bool_15;
        [CompilerGenerated]
        private bool bool_16;
        [CompilerGenerated]
        private bool bool_17;
        [CompilerGenerated]
        private bool bool_18;
        [CompilerGenerated]
        private bool bool_19;
        [CompilerGenerated]
        private bool bool_2;
        [CompilerGenerated]
        private bool bool_20;
        [CompilerGenerated]
        private bool bool_21;
        [CompilerGenerated]
        private bool bool_22;
        [CompilerGenerated]
        private bool bool_23;
        [CompilerGenerated]
        private bool bool_24;
        [CompilerGenerated]
        private bool bool_25;
        [CompilerGenerated]
        private bool bool_26;
        [CompilerGenerated]
        private bool bool_27;
        [CompilerGenerated]
        private bool bool_28;
        [CompilerGenerated]
        private bool bool_29;
        [CompilerGenerated]
        private bool bool_3;
        [CompilerGenerated]
        private bool bool_30;
        [CompilerGenerated]
        private bool bool_31;
        [CompilerGenerated]
        private bool bool_32;
        [CompilerGenerated]
        private bool bool_33;
        [CompilerGenerated]
        private bool bool_34;
        [CompilerGenerated]
        private bool bool_35;
        [CompilerGenerated]
        private bool bool_36;
        [CompilerGenerated]
        private bool bool_37;
        [CompilerGenerated]
        private bool bool_38;
        [CompilerGenerated]
        private bool bool_39;
        [CompilerGenerated]
        private bool bool_4;
        [CompilerGenerated]
        private bool bool_40;
        [CompilerGenerated]
        private bool bool_41;
        [CompilerGenerated]
        private bool bool_42;
        [CompilerGenerated]
        private bool bool_43;
        [CompilerGenerated]
        private bool bool_44;
        [CompilerGenerated]
        private bool bool_45;
        [CompilerGenerated]
        private bool bool_46;
        [CompilerGenerated]
        private bool bool_47;
        [CompilerGenerated]
        private bool bool_48;
        [CompilerGenerated]
        private bool bool_49;
        [CompilerGenerated]
        private bool bool_5;
        [CompilerGenerated]
        private bool bool_50;
        [CompilerGenerated]
        private bool bool_51;
        [CompilerGenerated]
        private bool bool_52;
        [CompilerGenerated]
        private bool bool_53;
        [CompilerGenerated]
        private bool bool_54;
        [CompilerGenerated]
        private bool bool_55;
        [CompilerGenerated]
        private bool bool_56;
        [CompilerGenerated]
        private bool bool_57;
        [CompilerGenerated]
        private bool bool_58;
        [CompilerGenerated]
        private bool bool_59;
        [CompilerGenerated]
        private bool bool_6;
        [CompilerGenerated]
        private bool bool_60;
        [CompilerGenerated]
        private bool bool_61;
        [CompilerGenerated]
        private bool bool_62;
        [CompilerGenerated]
        private bool bool_63;
        [CompilerGenerated]
        private bool bool_64;
        [CompilerGenerated]
        private bool bool_65;
        [CompilerGenerated]
        private bool bool_66;
        [CompilerGenerated]
        private bool bool_67;
        [CompilerGenerated]
        private bool bool_68;
        [CompilerGenerated]
        private bool bool_7;
        [CompilerGenerated]
        private bool bool_8;
        [CompilerGenerated]
        private bool bool_9;
        [CompilerGenerated]
        private Triton.Game.Mapping.EntityBase entityBase_0;
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private int int_1;
        [CompilerGenerated]
        private int int_10;
        [CompilerGenerated]
        private int int_11;
        [CompilerGenerated]
        private int int_12;
        [CompilerGenerated]
        private int int_13;
        [CompilerGenerated]
        private int int_14;
        [CompilerGenerated]
        private int int_15;
        [CompilerGenerated]
        private int int_16;
        [CompilerGenerated]
        private int int_17;
        [CompilerGenerated]
        private int int_18;
        [CompilerGenerated]
        private int int_19;
        [CompilerGenerated]
        private int int_2;
        [CompilerGenerated]
        private int int_20;
        [CompilerGenerated]
        private int int_21;
        [CompilerGenerated]
        private int int_22;
        [CompilerGenerated]
        private int int_23;
        [CompilerGenerated]
        private int int_3;
        [CompilerGenerated]
        private int int_4;
        [CompilerGenerated]
        private int int_5;
        [CompilerGenerated]
        private int int_6;
        [CompilerGenerated]
        private int int_7;
        [CompilerGenerated]
        private int int_8;
        [CompilerGenerated]
        private int int_9;
        [CompilerGenerated]
        private TAG_CARD_SET tag_CARD_SET_0;
        [CompilerGenerated]
        private TAG_CARDTYPE tag_CARDTYPE_0;
        [CompilerGenerated]
        private TAG_ZONE tag_ZONE_0;

        internal EntityBase(Triton.Game.Mapping.Entity backingObject)
        {
            this.EntityBase_0 = backingObject;
            this.CanAttack = this.EntityBase_0.CanAttack();
            this.CanBeAttacked = this.EntityBase_0.CanBeAttacked();
            this.CanBeDamaged = this.EntityBase_0.CanBeDamaged();
            this.CanBeTargetedByAbilities = this.EntityBase_0.CanBeTargetedByAbilities();
            this.CanBeTargetedByHeroPowers = this.EntityBase_0.CanBeTargetedByHeroPowers();
            this.CanBeTargetedByOpponents = this.EntityBase_0.CanBeTargetedByOpponents();
            this.Armor = this.EntityBase_0.GetArmor();
            this.Attack = this.EntityBase_0.GetATK();
            this.Attached = this.EntityBase_0.GetAttached();
            this.CardSet = this.EntityBase_0.GetCardSet();
            this.CardType = this.EntityBase_0.GetCardType();
            this.Cost = this.EntityBase_0.GetCost();
            this.CreatorId = this.EntityBase_0.GetCreatorId();
            this.Damage = this.EntityBase_0.GetDamage();
            this.Durability = this.EntityBase_0.GetDurability();
            this.EntityId = this.EntityBase_0.GetEntityId();
            this.Fatigue = this.EntityBase_0.GetFatigue();
            this.Health = this.EntityBase_0.GetHealth();
            this.NumAttacksThisTurn = this.EntityBase_0.GetNumAttacksThisTurn();
            this.NumTurnsInPlay = this.EntityBase_0.GetNumTurnsInPlay();
            this.RemainingHP = this.EntityBase_0.GetRemainingHP();
            this.SpellPower = this.EntityBase_0.GetSpellPower();
            this.Zone = this.EntityBase_0.GetZone();
            this.ZonePosition = this.EntityBase_0.GetZonePosition();
            this.HasAura = this.EntityBase_0.HasAura();
            this.ControllerId = this.EntityBase_0.GetControllerId();
            this.HasBattlecry = this.EntityBase_0.HasBattlecry();
            this.HasCharge = this.EntityBase_0.HasCharge();
            this.HasCombo = this.EntityBase_0.HasCombo();
            this.HasCustomKeywordEffect = this.EntityBase_0.HasCustomKeywordEffect();
            this.DisplayedCreatorId = this.EntityBase_0.GetDisplayedCreatorId();
            this.HasDeathrattle = this.EntityBase_0.HasDeathrattle();
            this.HasDivineShield = this.EntityBase_0.HasDivineShield();
            this.HasHealthMin = this.EntityBase_0.HasHealthMin();
            this.HasSpellPower = this.EntityBase_0.HasSpellPower();
            this.HasSpellPowerDouble = this.EntityBase_0.HasSpellPowerDouble();
            this.HasTaunt = this.EntityBase_0.HasTaunt();
            this.HasTriggerVisual = this.EntityBase_0.HasTriggerVisual();
            this.HasWindfury = this.EntityBase_0.HasWindfury();
            this.IsAffectedBySpellPower = this.EntityBase_0.IsAffectedBySpellPower();
            this.IsAsleep = this.EntityBase_0.IsAsleep();
            this.IsAttached = this.EntityBase_0.IsAttached();
            this.IsCharacter = this.EntityBase_0.IsCharacter();
            this.IsDamaged = this.EntityBase_0.IsDamaged();
            this.IsElite = this.EntityBase_0.IsElite();
            this.IsEnchantment = this.EntityBase_0.IsEnchantment();
            this.IsEnraged = this.EntityBase_0.IsEnraged();
            this.IsExhausted = this.EntityBase_0.IsExhausted();
            this.IsFreeze = this.EntityBase_0.IsFreeze();
            this.IsFrozen = this.EntityBase_0.IsFrozen();
            this.IsGame = this.EntityBase_0.IsGame();
            this.IsHero = this.EntityBase_0.IsHero();
            this.IsHeroPower = this.EntityBase_0.IsHeroPower();
            this.IsImmune = this.EntityBase_0.IsImmune();
            this.IsImmuneWhileAttacking = this.EntityBase_0.GetTag(GAME_TAG.IMMUNE_WHILE_ATTACKING) == 1;
            this.IsItem = this.EntityBase_0.IsItem();
            this.IsMagnet = this.EntityBase_0.IsMagnet();
            this.IsMinion = this.EntityBase_0.IsMinion();
            this.IsPlayer = this.EntityBase_0.IsPlayer();
            this.IsPoisonous = this.EntityBase_0.IsPoisonous();
            this.IsRecentlyArrived = this.EntityBase_0.IsRecentlyArrived();
            this.IsSecret = this.EntityBase_0.IsSecret();
            this.IsSilenced = this.EntityBase_0.IsSilenced();
            this.IsSpell = this.EntityBase_0.IsSpell();
            this.IsStealthed = this.EntityBase_0.IsStealthed();
            this.IsToken = this.EntityBase_0.IsToken();
            this.IsWeapon = this.EntityBase_0.IsWeapon();
            this.ReferencesBattlecry = this.EntityBase_0.ReferencesBattlecry();
            this.ReferencesCharge = this.EntityBase_0.ReferencesCharge();
            this.ReferencesDeathrattle = this.EntityBase_0.ReferencesDeathrattle();
            this.ReferencesDivineShield = this.EntityBase_0.ReferencesDivineShield();
            this.ReferencesImmune = this.EntityBase_0.ReferencesImmune();
            this.ReferencesSecret = this.EntityBase_0.ReferencesSecret();
            this.ReferencesSpellPower = this.EntityBase_0.ReferencesSpellPower();
            this.ReferencesStealth = this.EntityBase_0.ReferencesStealth();
            this.ReferencesTaunt = this.EntityBase_0.ReferencesTaunt();
            this.ReferencesWindfury = this.EntityBase_0.ReferencesWindfury();
            this.LastAffectedBy = this.EntityBase_0.GetTag(GAME_TAG.LAST_AFFECTED_BY);
            this.CardTarget = this.EntityBase_0.GetTag(GAME_TAG.CARD_TARGET);
            this.NumMinionsPlayedThisTurn = this.EntityBase_0.GetTag(GAME_TAG.NUM_MINIONS_PLAYED_THIS_TURN);
            this.NumCardsPlayedThisTurn = this.EntityBase_0.GetTag(GAME_TAG.NUM_MINIONS_PLAYED_THIS_TURN);
            this.OverloadOwed = this.EntityBase_0.GetTag(GAME_TAG.OVERLOAD_OWED);
            this.OverloadLocked = this.EntityBase_0.GetTag(GAME_TAG.OVERLOAD_LOCKED);
            this.HasInspire = this.EntityBase_0.HasInspire();
            this.CanBeTargetedByBattlecries = this.EntityBase_0.CanBeTargetedByBattlecries();
            this.DontShowImmune = this.EntityBase_0.DontShowImmune();
            this.IsObfuscated = this.EntityBase_0.IsObfuscated();
            this.CannotAttackHeroes = this.EntityBase_0.CannotAttackHeroes();
            this.HasHeroPowerDamage = this.EntityBase_0.HasHeroPowerDamage();
            this.Windfury = this.EntityBase_0.GetWindfury();
            this.HasOverload = this.EntityBase_0.HasOverload();
            this.IsBasicCardUnlock = this.EntityBase_0.IsBasicCardUnlock();
            this.HasEvilGlow = this.EntityBase_0.HasEvilGlow();
        }

        public int Armor
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            private set
            {
                this.int_0 = value;
            }
        }

        public int Attached
        {
            [CompilerGenerated]
            get
            {
                return this.int_2;
            }
            [CompilerGenerated]
            private set
            {
                this.int_2 = value;
            }
        }

        public int Attack
        {
            [CompilerGenerated]
            get
            {
                return this.int_1;
            }
            [CompilerGenerated]
            private set
            {
                this.int_1 = value;
            }
        }

        public bool CanAttack
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_0 = value;
            }
        }

        public bool CanBeAttacked
        {
            [CompilerGenerated]
            get
            {
                return this.bool_1;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_1 = value;
            }
        }

        public bool CanBeDamaged
        {
            [CompilerGenerated]
            get
            {
                return this.bool_2;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_2 = value;
            }
        }

        public bool CanBeTargetedByAbilities
        {
            [CompilerGenerated]
            get
            {
                return this.bool_3;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_3 = value;
            }
        }

        public bool CanBeTargetedByBattlecries
        {
            [CompilerGenerated]
            get
            {
                return this.bool_60;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_60 = value;
            }
        }

        public bool CanBeTargetedByHeroPowers
        {
            [CompilerGenerated]
            get
            {
                return this.bool_4;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_4 = value;
            }
        }

        public bool CanBeTargetedByOpponents
        {
            [CompilerGenerated]
            get
            {
                return this.bool_5;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_5 = value;
            }
        }

        public bool CannotAttackHeroes
        {
            [CompilerGenerated]
            get
            {
                return this.bool_64;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_64 = value;
            }
        }

        public TAG_CARD_SET CardSet
        {
            [CompilerGenerated]
            get
            {
                return this.tag_CARD_SET_0;
            }
            [CompilerGenerated]
            private set
            {
                this.tag_CARD_SET_0 = value;
            }
        }

        public int CardTarget
        {
            [CompilerGenerated]
            get
            {
                return this.int_18;
            }
            [CompilerGenerated]
            private set
            {
                this.int_18 = value;
            }
        }

        public TAG_CARDTYPE CardType
        {
            [CompilerGenerated]
            get
            {
                return this.tag_CARDTYPE_0;
            }
            [CompilerGenerated]
            private set
            {
                this.tag_CARDTYPE_0 = value;
            }
        }

        public int ControllerId
        {
            [CompilerGenerated]
            get
            {
                return this.int_5;
            }
            [CompilerGenerated]
            private set
            {
                this.int_5 = value;
            }
        }

        public int Cost
        {
            [CompilerGenerated]
            get
            {
                return this.int_3;
            }
            [CompilerGenerated]
            private set
            {
                this.int_3 = value;
            }
        }

        public int CreatorId
        {
            [CompilerGenerated]
            get
            {
                return this.int_4;
            }
            [CompilerGenerated]
            private set
            {
                this.int_4 = value;
            }
        }

        public int Damage
        {
            [CompilerGenerated]
            get
            {
                return this.int_6;
            }
            [CompilerGenerated]
            private set
            {
                this.int_6 = value;
            }
        }

        public int DisplayedCreatorId
        {
            [CompilerGenerated]
            get
            {
                return this.int_16;
            }
            [CompilerGenerated]
            private set
            {
                this.int_16 = value;
            }
        }

        public bool DontShowImmune
        {
            [CompilerGenerated]
            get
            {
                return this.bool_62;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_62 = value;
            }
        }

        public int Durability
        {
            [CompilerGenerated]
            get
            {
                return this.int_7;
            }
            [CompilerGenerated]
            private set
            {
                this.int_7 = value;
            }
        }

        internal Triton.Game.Mapping.EntityBase EntityBase_0
        {
            [CompilerGenerated]
            get
            {
                return this.entityBase_0;
            }
            [CompilerGenerated]
            set
            {
                this.entityBase_0 = value;
            }
        }

        public int EntityId
        {
            [CompilerGenerated]
            get
            {
                return this.int_8;
            }
            [CompilerGenerated]
            private set
            {
                this.int_8 = value;
            }
        }

        public int Fatigue
        {
            [CompilerGenerated]
            get
            {
                return this.int_9;
            }
            [CompilerGenerated]
            private set
            {
                this.int_9 = value;
            }
        }

        public bool HasAura
        {
            [CompilerGenerated]
            get
            {
                return this.bool_6;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_6 = value;
            }
        }

        public bool HasBattlecry
        {
            [CompilerGenerated]
            get
            {
                return this.bool_7;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_7 = value;
            }
        }

        public bool HasCharge
        {
            [CompilerGenerated]
            get
            {
                return this.bool_8;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_8 = value;
            }
        }

        public bool HasCombo
        {
            [CompilerGenerated]
            get
            {
                return this.bool_9;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_9 = value;
            }
        }

        public bool HasCustomKeywordEffect
        {
            [CompilerGenerated]
            get
            {
                return this.bool_10;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_10 = value;
            }
        }

        public bool HasDeathrattle
        {
            [CompilerGenerated]
            get
            {
                return this.bool_11;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_11 = value;
            }
        }

        public bool HasDivineShield
        {
            [CompilerGenerated]
            get
            {
                return this.bool_12;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_12 = value;
            }
        }

        public bool HasEvilGlow
        {
            [CompilerGenerated]
            get
            {
                return this.bool_68;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_68 = value;
            }
        }

        public bool HasHealthMin
        {
            [CompilerGenerated]
            get
            {
                return this.bool_13;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_13 = value;
            }
        }

        public bool HasHeroPowerDamage
        {
            [CompilerGenerated]
            get
            {
                return this.bool_65;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_65 = value;
            }
        }

        public bool HasInspire
        {
            [CompilerGenerated]
            get
            {
                return this.bool_61;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_61 = value;
            }
        }

        public bool HasOverload
        {
            [CompilerGenerated]
            get
            {
                return this.bool_66;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_66 = value;
            }
        }

        public bool HasRecall
        {
            [CompilerGenerated]
            get
            {
                return this.bool_14;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_14 = value;
            }
        }

        public bool HasSpellPower
        {
            [CompilerGenerated]
            get
            {
                return this.bool_15;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_15 = value;
            }
        }

        public bool HasSpellPowerDouble
        {
            [CompilerGenerated]
            get
            {
                return this.bool_16;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_16 = value;
            }
        }

        public bool HasTaunt
        {
            [CompilerGenerated]
            get
            {
                return this.bool_17;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_17 = value;
            }
        }

        public bool HasTriggerVisual
        {
            [CompilerGenerated]
            get
            {
                return this.bool_18;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_18 = value;
            }
        }

        public bool HasWindfury
        {
            [CompilerGenerated]
            get
            {
                return this.bool_19;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_19 = value;
            }
        }

        public int Health
        {
            [CompilerGenerated]
            get
            {
                return this.int_10;
            }
            [CompilerGenerated]
            private set
            {
                this.int_10 = value;
            }
        }

        public bool IsAffectedBySpellPower
        {
            [CompilerGenerated]
            get
            {
                return this.bool_20;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_20 = value;
            }
        }

        public bool IsAsleep
        {
            [CompilerGenerated]
            get
            {
                return this.bool_21;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_21 = value;
            }
        }

        public bool IsAttached
        {
            [CompilerGenerated]
            get
            {
                return this.bool_22;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_22 = value;
            }
        }

        public bool IsBasicCardUnlock
        {
            [CompilerGenerated]
            get
            {
                return this.bool_67;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_67 = value;
            }
        }

        public bool IsCard
        {
            [CompilerGenerated]
            get
            {
                return this.bool_23;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_23 = value;
            }
        }

        public bool IsCharacter
        {
            [CompilerGenerated]
            get
            {
                return this.bool_24;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_24 = value;
            }
        }

        public bool IsDamaged
        {
            [CompilerGenerated]
            get
            {
                return this.bool_25;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_25 = value;
            }
        }

        public bool IsElite
        {
            [CompilerGenerated]
            get
            {
                return this.bool_26;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_26 = value;
            }
        }

        public bool IsEnchantment
        {
            [CompilerGenerated]
            get
            {
                return this.bool_27;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_27 = value;
            }
        }

        public bool IsEnraged
        {
            [CompilerGenerated]
            get
            {
                return this.bool_28;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_28 = value;
            }
        }

        public bool IsExhausted
        {
            [CompilerGenerated]
            get
            {
                return this.bool_29;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_29 = value;
            }
        }

        public bool IsFreeze
        {
            [CompilerGenerated]
            get
            {
                return this.bool_30;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_30 = value;
            }
        }

        public bool IsFrozen
        {
            [CompilerGenerated]
            get
            {
                return this.bool_31;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_31 = value;
            }
        }

        public bool IsGame
        {
            [CompilerGenerated]
            get
            {
                return this.bool_32;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_32 = value;
            }
        }

        public bool IsHero
        {
            [CompilerGenerated]
            get
            {
                return this.bool_33;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_33 = value;
            }
        }

        public bool IsHeroPower
        {
            [CompilerGenerated]
            get
            {
                return this.bool_34;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_34 = value;
            }
        }

        public bool IsImmune
        {
            [CompilerGenerated]
            get
            {
                return this.bool_35;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_35 = value;
            }
        }

        public bool IsImmuneWhileAttacking
        {
            [CompilerGenerated]
            get
            {
                return this.bool_36;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_36 = value;
            }
        }

        public bool IsItem
        {
            [CompilerGenerated]
            get
            {
                return this.bool_37;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_37 = value;
            }
        }

        public bool IsMagnet
        {
            [CompilerGenerated]
            get
            {
                return this.bool_38;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_38 = value;
            }
        }

        public bool IsMinion
        {
            [CompilerGenerated]
            get
            {
                return this.bool_39;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_39 = value;
            }
        }

        public bool IsObfuscated
        {
            [CompilerGenerated]
            get
            {
                return this.bool_63;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_63 = value;
            }
        }

        public bool IsPlayer
        {
            [CompilerGenerated]
            get
            {
                return this.bool_40;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_40 = value;
            }
        }

        public bool IsPoisonous
        {
            [CompilerGenerated]
            get
            {
                return this.bool_41;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_41 = value;
            }
        }

        public bool IsPower
        {
            [CompilerGenerated]
            get
            {
                return this.bool_42;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_42 = value;
            }
        }

        public bool IsRecentlyArrived
        {
            [CompilerGenerated]
            get
            {
                return this.bool_43;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_43 = value;
            }
        }

        public bool IsSecret
        {
            [CompilerGenerated]
            get
            {
                return this.bool_44;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_44 = value;
            }
        }

        public bool IsSilenced
        {
            [CompilerGenerated]
            get
            {
                return this.bool_45;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_45 = value;
            }
        }

        public bool IsSpell
        {
            [CompilerGenerated]
            get
            {
                return this.bool_46;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_46 = value;
            }
        }

        public bool IsStealthed
        {
            [CompilerGenerated]
            get
            {
                return this.bool_47;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_47 = value;
            }
        }

        public bool IsToken
        {
            [CompilerGenerated]
            get
            {
                return this.bool_48;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_48 = value;
            }
        }

        public bool IsWeapon
        {
            [CompilerGenerated]
            get
            {
                return this.bool_49;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_49 = value;
            }
        }

        public int LastAffectedBy
        {
            [CompilerGenerated]
            get
            {
                return this.int_17;
            }
            [CompilerGenerated]
            private set
            {
                this.int_17 = value;
            }
        }

        public int NumAttacksThisTurn
        {
            [CompilerGenerated]
            get
            {
                return this.int_11;
            }
            [CompilerGenerated]
            private set
            {
                this.int_11 = value;
            }
        }

        public int NumCardsPlayedThisTurn
        {
            [CompilerGenerated]
            get
            {
                return this.int_19;
            }
            [CompilerGenerated]
            private set
            {
                this.int_19 = value;
            }
        }

        public int NumMinionsPlayedThisTurn
        {
            [CompilerGenerated]
            get
            {
                return this.int_20;
            }
            [CompilerGenerated]
            private set
            {
                this.int_20 = value;
            }
        }

        public int NumTurnsInPlay
        {
            [CompilerGenerated]
            get
            {
                return this.int_12;
            }
            [CompilerGenerated]
            private set
            {
                this.int_12 = value;
            }
        }

        public int OverloadLocked
        {
            [CompilerGenerated]
            get
            {
                return this.int_22;
            }
            [CompilerGenerated]
            private set
            {
                this.int_22 = value;
            }
        }

        public int OverloadOwed
        {
            [CompilerGenerated]
            get
            {
                return this.int_21;
            }
            [CompilerGenerated]
            private set
            {
                this.int_21 = value;
            }
        }

        public bool ReferencesBattlecry
        {
            [CompilerGenerated]
            get
            {
                return this.bool_50;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_50 = value;
            }
        }

        public bool ReferencesCharge
        {
            [CompilerGenerated]
            get
            {
                return this.bool_51;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_51 = value;
            }
        }

        public bool ReferencesDeathrattle
        {
            [CompilerGenerated]
            get
            {
                return this.bool_52;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_52 = value;
            }
        }

        public bool ReferencesDivineShield
        {
            [CompilerGenerated]
            get
            {
                return this.bool_53;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_53 = value;
            }
        }

        public bool ReferencesImmune
        {
            [CompilerGenerated]
            get
            {
                return this.bool_54;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_54 = value;
            }
        }

        public bool ReferencesSecret
        {
            [CompilerGenerated]
            get
            {
                return this.bool_55;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_55 = value;
            }
        }

        public bool ReferencesSpellPower
        {
            [CompilerGenerated]
            get
            {
                return this.bool_56;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_56 = value;
            }
        }

        public bool ReferencesStealth
        {
            [CompilerGenerated]
            get
            {
                return this.bool_57;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_57 = value;
            }
        }

        public bool ReferencesTaunt
        {
            [CompilerGenerated]
            get
            {
                return this.bool_58;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_58 = value;
            }
        }

        public bool ReferencesWindfury
        {
            [CompilerGenerated]
            get
            {
                return this.bool_59;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_59 = value;
            }
        }

        public int RemainingHP
        {
            [CompilerGenerated]
            get
            {
                return this.int_13;
            }
            [CompilerGenerated]
            private set
            {
                this.int_13 = value;
            }
        }

        public int SpellPower
        {
            [CompilerGenerated]
            get
            {
                return this.int_14;
            }
            [CompilerGenerated]
            private set
            {
                this.int_14 = value;
            }
        }

        public int Windfury
        {
            [CompilerGenerated]
            get
            {
                return this.int_23;
            }
            [CompilerGenerated]
            private set
            {
                this.int_23 = value;
            }
        }

        public TAG_ZONE Zone
        {
            [CompilerGenerated]
            get
            {
                return this.tag_ZONE_0;
            }
            [CompilerGenerated]
            private set
            {
                this.tag_ZONE_0 = value;
            }
        }

        public int ZonePosition
        {
            [CompilerGenerated]
            get
            {
                return this.int_15;
            }
            [CompilerGenerated]
            private set
            {
                this.int_15 = value;
            }
        }
    }
}

