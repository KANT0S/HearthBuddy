namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Entity")]
    public class Entity : EntityBase
    {
        public Entity(IntPtr address) : this(address, "Entity")
        {
        }

        public Entity(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddAttachment(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("AddAttachment", objArray1);
        }

        public void AddSubCard(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("AddSubCard", objArray1);
        }

        public void ClearBattlecryFlag()
        {
            base.method_8("ClearBattlecryFlag", Array.Empty<object>());
        }

        public void ClearTags()
        {
            base.method_8("ClearTags", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity CloneForHistory(int damageBonus, int damageBonusDouble, int healingDouble)
        {
            object[] objArray1 = new object[] { damageBonus, damageBonusDouble, healingDouble };
            return base.method_14<Triton.Game.Mapping.Entity>("CloneForHistory", objArray1);
        }

        public Triton.Game.Mapping.Entity CloneForZoneMgr()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("CloneForZoneMgr", Array.Empty<object>());
        }

        public PlayErrors.SourceEntityInfo ConvertToSourceInfo(PlayErrors.PlayRequirementInfo playRequirementInfo, Triton.Game.Mapping.Entity parent)
        {
            object[] objArray1 = new object[] { playRequirementInfo, parent };
            return base.method_14<PlayErrors.SourceEntityInfo>("ConvertToSourceInfo", objArray1);
        }

        public PlayErrors.TargetEntityInfo ConvertToTargetInfo()
        {
            return base.method_14<PlayErrors.TargetEntityInfo>("ConvertToTargetInfo", Array.Empty<object>());
        }

        public void Destroy()
        {
            base.method_8("Destroy", Array.Empty<object>());
        }

        public bool DoEnchantmentsHaveTriggerVisuals()
        {
            return base.method_11<bool>("DoEnchantmentsHaveTriggerVisuals", Array.Empty<object>());
        }

        public void FinishCardLoad()
        {
            base.method_8("FinishCardLoad", Array.Empty<object>());
        }

        public List<Triton.Game.Mapping.Entity> GetAttachments()
        {
            Class267<Triton.Game.Mapping.Entity> class2 = base.method_14<Class267<Triton.Game.Mapping.Entity>>("GetAttachments", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Power GetAttackPower()
        {
            return base.method_14<Power>("GetAttackPower", Array.Empty<object>());
        }

        public Card GetCard()
        {
            return base.method_14<Card>("GetCard", Array.Empty<object>());
        }

        public string GetCardId()
        {
            return base.method_13("GetCardId", Array.Empty<object>());
        }

        public TAG_CARD_SET GetCardSet()
        {
            return base.method_11<TAG_CARD_SET>("GetCardSet", Array.Empty<object>());
        }

        public string GetCardTextInHand()
        {
            return base.method_13("GetCardTextInHand", Array.Empty<object>());
        }

        public string GetCardTextInHistory()
        {
            return base.method_13("GetCardTextInHistory", Array.Empty<object>());
        }

        public TAG_CLASS GetClass()
        {
            return base.method_11<TAG_CLASS>("GetClass", Array.Empty<object>());
        }

        public Player GetController()
        {
            return base.method_14<Player>("GetController", Array.Empty<object>());
        }

        public Player.Side GetControllerSide()
        {
            return base.method_11<Player.Side>("GetControllerSide", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetCreator()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetCreator", Array.Empty<object>());
        }

        public int GetDamageBonus()
        {
            return base.method_11<int>("GetDamageBonus", Array.Empty<object>());
        }

        public int GetDamageBonusDouble()
        {
            return base.method_11<int>("GetDamageBonusDouble", Array.Empty<object>());
        }

        public string GetDebugName()
        {
            return base.method_13("GetDebugName", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetDisplayedCreator()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetDisplayedCreator", Array.Empty<object>());
        }

        public TAG_ENCHANTMENT_VISUAL GetEnchantmentBirthVisual()
        {
            return base.method_11<TAG_ENCHANTMENT_VISUAL>("GetEnchantmentBirthVisual", Array.Empty<object>());
        }

        public TAG_ENCHANTMENT_VISUAL GetEnchantmentIdleVisual()
        {
            return base.method_11<TAG_ENCHANTMENT_VISUAL>("GetEnchantmentIdleVisual", Array.Empty<object>());
        }

        public List<Triton.Game.Mapping.Entity> GetEnchantments()
        {
            Class267<Triton.Game.Mapping.Entity> class2 = base.method_14<Class267<Triton.Game.Mapping.Entity>>("GetEnchantments", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public EntityDef GetEntityDef()
        {
            return base.method_14<EntityDef>("GetEntityDef", Array.Empty<object>());
        }

        public int GetHealingDouble()
        {
            return base.method_11<int>("GetHealingDouble", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetHero()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetHero", Array.Empty<object>());
        }

        public Card GetHeroCard()
        {
            return base.method_14<Card>("GetHeroCard", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetHeroPower()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetHeroPower", Array.Empty<object>());
        }

        public Card GetHeroPowerCard()
        {
            return base.method_14<Card>("GetHeroPowerCard", Array.Empty<object>());
        }

        public int GetHistoryDamageBonus()
        {
            return base.method_11<int>("GetHistoryDamageBonus", Array.Empty<object>());
        }

        public int GetHistoryDamageBonusDouble()
        {
            return base.method_11<int>("GetHistoryDamageBonusDouble", Array.Empty<object>());
        }

        public int GetHistoryHealingDouble()
        {
            return base.method_11<int>("GetHistoryHealingDouble", Array.Empty<object>());
        }

        public LoadState GetLoadState()
        {
            return base.method_11<LoadState>("GetLoadState", Array.Empty<object>());
        }

        public Power GetMasterPower()
        {
            return base.method_14<Power>("GetMasterPower", Array.Empty<object>());
        }

        public string GetName()
        {
            return base.method_13("GetName", Array.Empty<object>());
        }

        public int GetOriginalATK()
        {
            return base.method_11<int>("GetOriginalATK", Array.Empty<object>());
        }

        public bool GetOriginalCharge()
        {
            return base.method_11<bool>("GetOriginalCharge", Array.Empty<object>());
        }

        public int GetOriginalCost()
        {
            return base.method_11<int>("GetOriginalCost", Array.Empty<object>());
        }

        public int GetOriginalDurability()
        {
            return base.method_11<int>("GetOriginalDurability", Array.Empty<object>());
        }

        public int GetOriginalHealth()
        {
            return base.method_11<int>("GetOriginalHealth", Array.Empty<object>());
        }

        public TAG_PREMIUM GetPremiumType()
        {
            return base.method_11<TAG_PREMIUM>("GetPremiumType", Array.Empty<object>());
        }

        public TAG_RACE GetRace()
        {
            return base.method_11<TAG_RACE>("GetRace", Array.Empty<object>());
        }

        public string GetRaceText()
        {
            return base.method_13("GetRaceText", Array.Empty<object>());
        }

        public TAG_RARITY GetRarity()
        {
            return base.method_11<TAG_RARITY>("GetRarity", Array.Empty<object>());
        }

        public int GetRealTimeAttack()
        {
            return base.method_11<int>("GetRealTimeAttack", Array.Empty<object>());
        }

        public int GetRealTimeCost()
        {
            return base.method_11<int>("GetRealTimeCost", Array.Empty<object>());
        }

        public bool GetRealTimePoweredUp()
        {
            return base.method_11<bool>("GetRealTimePoweredUp", Array.Empty<object>());
        }

        public int GetRealTimeRemainingHP()
        {
            return base.method_11<int>("GetRealTimeRemainingHP", Array.Empty<object>());
        }

        public int GetReferencedTag(int tag)
        {
            object[] objArray1 = new object[] { tag };
            return base.method_11<int>("GetReferencedTag", objArray1);
        }

        public string GetStringTag(int tag)
        {
            object[] objArray1 = new object[] { tag };
            return base.method_13("GetStringTag", objArray1);
        }

        public List<int> GetSubCardIDs()
        {
            Class266<int> class2 = base.method_14<Class266<int>>("GetSubCardIDs", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public string GetTargetingArrowText()
        {
            return base.method_13("GetTargetingArrowText", Array.Empty<object>());
        }

        public Card GetWeaponCard()
        {
            return base.method_14<Card>("GetWeaponCard", Array.Empty<object>());
        }

        public void HandleTagChange(TagDelta change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("HandleTagChange", objArray1);
        }

        public Card InitCard()
        {
            return base.method_14<Card>("InitCard", Array.Empty<object>());
        }

        public void InitRealTimeValues(Network.Entity netEntity)
        {
            object[] objArray1 = new object[] { netEntity };
            base.method_8("InitRealTimeValues", objArray1);
        }

        public bool IsBusy()
        {
            return base.method_11<bool>("IsBusy", Array.Empty<object>());
        }

        public bool IsControlledByConcealedPlayer()
        {
            return base.method_11<bool>("IsControlledByConcealedPlayer", Array.Empty<object>());
        }

        public bool IsControlledByFriendlySidePlayer()
        {
            return base.method_11<bool>("IsControlledByFriendlySidePlayer", Array.Empty<object>());
        }

        public bool IsControlledByLocalUser()
        {
            return base.method_11<bool>("IsControlledByLocalUser", Array.Empty<object>());
        }

        public bool IsControlledByOpposingSidePlayer()
        {
            return base.method_11<bool>("IsControlledByOpposingSidePlayer", Array.Empty<object>());
        }

        public bool IsControlledByRevealedPlayer()
        {
            return base.method_11<bool>("IsControlledByRevealedPlayer", Array.Empty<object>());
        }

        public bool IsEnchanted()
        {
            return base.method_11<bool>("IsEnchanted", Array.Empty<object>());
        }

        public bool IsHidden()
        {
            return base.method_11<bool>("IsHidden", Array.Empty<object>());
        }

        public bool IsHistoryDupe()
        {
            return base.method_11<bool>("IsHistoryDupe", Array.Empty<object>());
        }

        public bool IsLoadingAssets()
        {
            return base.method_11<bool>("IsLoadingAssets", Array.Empty<object>());
        }

        public bool IsNameChange(TagDelta change)
        {
            object[] objArray1 = new object[] { change };
            return base.method_11<bool>("IsNameChange", objArray1);
        }

        public void LoadCard(string cardId)
        {
            object[] objArray1 = new object[] { cardId };
            base.method_8("LoadCard", objArray1);
        }

        public void LoadEntityDef(string cardId)
        {
            object[] objArray1 = new object[] { cardId };
            base.method_8("LoadEntityDef", objArray1);
        }

        public void OnCardDefLoaded(string cardId, CardDef cardDef, object callbackData)
        {
            object[] objArray1 = new object[] { cardId, cardDef, callbackData };
            base.method_8("OnCardDefLoaded", objArray1);
        }

        public void OnFullEntity(Network.HistFullEntity fullEntity)
        {
            object[] objArray1 = new object[] { fullEntity };
            base.method_8("OnFullEntity", objArray1);
        }

        public void OnMetaData(Network.HistMetaData metaData)
        {
            object[] objArray1 = new object[] { metaData };
            base.method_8("OnMetaData", objArray1);
        }

        public void OnRealTimeFullEntity(Network.HistFullEntity fullEntity)
        {
            object[] objArray1 = new object[] { fullEntity };
            base.method_8("OnRealTimeFullEntity", objArray1);
        }

        public void OnRealTimeShowEntity(Network.HistShowEntity showEntity)
        {
            object[] objArray1 = new object[] { showEntity };
            base.method_8("OnRealTimeShowEntity", objArray1);
        }

        public void OnRealTimeTagChanged(Network.HistTagChange change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnRealTimeTagChanged", objArray1);
        }

        public void OnShowEntity(Network.HistShowEntity showEntity)
        {
            object[] objArray1 = new object[] { showEntity };
            base.method_8("OnShowEntity", objArray1);
        }

        public void OnTagChanged(TagDelta change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnTagChanged", objArray1);
        }

        public void OnTagsChanged(TagDeltaSet changeSet)
        {
            object[] objArray1 = new object[] { changeSet };
            base.method_8("OnTagsChanged", objArray1);
        }

        public void RemoveAttachment(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("RemoveAttachment", objArray1);
        }

        public void RemoveSubCard(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("RemoveSubCard", objArray1);
        }

        public void SetCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("SetCard", objArray1);
        }

        public void SetCardId(string cardId)
        {
            object[] objArray1 = new object[] { cardId };
            base.method_8("SetCardId", objArray1);
        }

        public void SetRealTimeArmor(int newArmor)
        {
            object[] objArray1 = new object[] { newArmor };
            base.method_8("SetRealTimeArmor", objArray1);
        }

        public void SetRealTimeAttack(int newAttack)
        {
            object[] objArray1 = new object[] { newAttack };
            base.method_8("SetRealTimeAttack", objArray1);
        }

        public void SetRealTimeCost(int newCost)
        {
            object[] objArray1 = new object[] { newCost };
            base.method_8("SetRealTimeCost", objArray1);
        }

        public void SetRealTimeDamage(int newDamage)
        {
            object[] objArray1 = new object[] { newDamage };
            base.method_8("SetRealTimeDamage", objArray1);
        }

        public void SetRealTimeHealth(int newHealth)
        {
            object[] objArray1 = new object[] { newHealth };
            base.method_8("SetRealTimeHealth", objArray1);
        }

        public void SetRealTimePoweredUp(int poweredUp)
        {
            object[] objArray1 = new object[] { poweredUp };
            base.method_8("SetRealTimePoweredUp", objArray1);
        }

        public TagDelta SetTagAndHandleChange(int tag, int tagValue)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag, tagValue };
            return base.method_15<TagDelta>("SetTagAndHandleChange", enumArray1, objArray1);
        }

        public bool ShouldUseBattlecryPower()
        {
            return base.method_11<bool>("ShouldUseBattlecryPower", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public void UpdateCardName()
        {
            base.method_8("UpdateCardName", Array.Empty<object>());
        }

        public void UpdateUseBattlecryFlag(bool fromGameState)
        {
            object[] objArray1 = new object[] { fromGameState };
            base.method_8("UpdateUseBattlecryFlag", objArray1);
        }

        public static string HIDDEN_CARD_ASSET_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Entity", "HIDDEN_CARD_ASSET_NAME");
            }
        }

        public List<Triton.Game.Mapping.Entity> m_attachments
        {
            get
            {
                Class267<Triton.Game.Mapping.Entity> class2 = base.method_3<Class267<Triton.Game.Mapping.Entity>>("m_attachments");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Card m_card
        {
            get
            {
                return base.method_3<Card>("m_card");
            }
        }

        public int m_cardAssetLoadCount
        {
            get
            {
                return base.method_2<int>("m_cardAssetLoadCount");
            }
        }

        public string m_cardId
        {
            get
            {
                return base.method_4("m_cardId");
            }
        }

        public bool m_duplicateForHistory
        {
            get
            {
                return base.method_2<bool>("m_duplicateForHistory");
            }
        }

        public EntityDef m_entityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_entityDef");
            }
        }

        public int m_historyDamageBonus
        {
            get
            {
                return base.method_2<int>("m_historyDamageBonus");
            }
        }

        public int m_historyDamageBonusDouble
        {
            get
            {
                return base.method_2<int>("m_historyDamageBonusDouble");
            }
        }

        public int m_historyHealingDouble
        {
            get
            {
                return base.method_2<int>("m_historyHealingDouble");
            }
        }

        public LoadState m_loadState
        {
            get
            {
                return base.method_2<LoadState>("m_loadState");
            }
        }

        public int m_realTimeArmor
        {
            get
            {
                return base.method_2<int>("m_realTimeArmor");
            }
        }

        public int m_realTimeAttack
        {
            get
            {
                return base.method_2<int>("m_realTimeAttack");
            }
        }

        public int m_realTimeCost
        {
            get
            {
                return base.method_2<int>("m_realTimeCost");
            }
        }

        public int m_realTimeDamage
        {
            get
            {
                return base.method_2<int>("m_realTimeDamage");
            }
        }

        public int m_realTimeHealth
        {
            get
            {
                return base.method_2<int>("m_realTimeHealth");
            }
        }

        public bool m_realTimePoweredUp
        {
            get
            {
                return base.method_2<bool>("m_realTimePoweredUp");
            }
        }

        public List<int> m_subCardIDs
        {
            get
            {
                Class266<int> class2 = base.method_3<Class266<int>>("m_subCardIDs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_useBattlecryPower
        {
            get
            {
                return base.method_2<bool>("m_useBattlecryPower");
            }
        }

        public static string PLACEHOLDER_CARD_ASSET_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Entity", "PLACEHOLDER_CARD_ASSET_NAME");
            }
        }

        public enum LoadState
        {
            INVALID,
            PENDING,
            LOADING,
            DONE
        }
    }
}

