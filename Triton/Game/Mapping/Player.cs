namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Player")]
    public class Player : Triton.Game.Mapping.Entity
    {
        public Player(IntPtr address) : this(address, "Player")
        {
        }

        public Player(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddManaCrystal(int numCrystals)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { numCrystals };
            base.method_9("AddManaCrystal", enumArray1, objArray1);
        }

        public void AddManaCrystal(int numCrystals, bool isTurnStart)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { numCrystals, isTurnStart };
            base.method_9("AddManaCrystal", enumArray1, objArray1);
        }

        public void AddTempManaCrystal(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("AddTempManaCrystal", objArray1);
        }

        public void AssignPlayerBoardObjects()
        {
            base.method_8("AssignPlayerBoardObjects", Array.Empty<object>());
        }

        public void CancelAllProposedMana(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("CancelAllProposedMana", objArray1);
        }

        public PlayErrors.PlayerInfo ConvertToPlayerInfo()
        {
            return base.method_14<PlayErrors.PlayerInfo>("ConvertToPlayerInfo", Array.Empty<object>());
        }

        public void DestroyManaCrystal(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("DestroyManaCrystal", objArray1);
        }

        public void DestroyTempManaCrystal(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("DestroyTempManaCrystal", objArray1);
        }

        public ZonePlay GetBattlefieldZone()
        {
            return base.method_14<ZonePlay>("GetBattlefieldZone", Array.Empty<object>());
        }

        public BnetPlayer GetBnetPlayer()
        {
            return base.method_14<BnetPlayer>("GetBnetPlayer", Array.Empty<object>());
        }

        public int GetCardBackId()
        {
            return base.method_11<int>("GetCardBackId", Array.Empty<object>());
        }

        public string GetDebugName()
        {
            return base.method_13("GetDebugName", Array.Empty<object>());
        }

        public ZoneDeck GetDeckZone()
        {
            return base.method_14<ZoneDeck>("GetDeckZone", Array.Empty<object>());
        }

        public ZoneGraveyard GetGraveyardZone()
        {
            return base.method_14<ZoneGraveyard>("GetGraveyardZone", Array.Empty<object>());
        }

        public ZoneHand GetHandZone()
        {
            return base.method_14<ZoneHand>("GetHandZone", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetHero()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetHero", Array.Empty<object>());
        }

        public Card GetHeroCard()
        {
            return base.method_14<Card>("GetHeroCard", Array.Empty<object>());
        }

        public EntityDef GetHeroEntityDef()
        {
            return base.method_14<EntityDef>("GetHeroEntityDef", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetHeroPower()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetHeroPower", Array.Empty<object>());
        }

        public Card GetHeroPowerCard()
        {
            return base.method_14<Card>("GetHeroPowerCard", Array.Empty<object>());
        }

        public string GetName()
        {
            return base.method_13("GetName", Array.Empty<object>());
        }

        public int GetNumAvailableResources()
        {
            return base.method_11<int>("GetNumAvailableResources", Array.Empty<object>());
        }

        public int GetNumDragonsInHand()
        {
            return base.method_11<int>("GetNumDragonsInHand", Array.Empty<object>());
        }

        public int GetNumMinionsInPlay()
        {
            return base.method_11<int>("GetNumMinionsInPlay", Array.Empty<object>());
        }

        public int GetNumTotalMinionsInPlay()
        {
            return base.method_11<int>("GetNumTotalMinionsInPlay", Array.Empty<object>());
        }

        public int GetPlayerId()
        {
            return base.method_11<int>("GetPlayerId", Array.Empty<object>());
        }

        public int GetQueuedSpentMana()
        {
            return base.method_11<int>("GetQueuedSpentMana", Array.Empty<object>());
        }

        public int GetQueuedUsedTempMana()
        {
            return base.method_11<int>("GetQueuedUsedTempMana", Array.Empty<object>());
        }

        public MedalInfoTranslator GetRank()
        {
            return base.method_14<MedalInfoTranslator>("GetRank", Array.Empty<object>());
        }

        public int GetRealTimeTempMana()
        {
            return base.method_11<int>("GetRealTimeTempMana", Array.Empty<object>());
        }

        public List<string> GetSecretDefinitions()
        {
            Class268 class2 = base.method_14<Class268>("GetSecretDefinitions", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public ZoneSecret GetSecretZone()
        {
            return base.method_14<ZoneSecret>("GetSecretZone", Array.Empty<object>());
        }

        public Side GetSide()
        {
            return base.method_11<Side>("GetSide", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetStartingHero()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetStartingHero", Array.Empty<object>());
        }

        public Card GetWeaponCard()
        {
            return base.method_14<Card>("GetWeaponCard", Array.Empty<object>());
        }

        public void HandleSameTurnOverloadChanged(int crystalsChanged)
        {
            object[] objArray1 = new object[] { crystalsChanged };
            base.method_8("HandleSameTurnOverloadChanged", objArray1);
        }

        public bool HasATauntMinion()
        {
            return base.method_11<bool>("HasATauntMinion", Array.Empty<object>());
        }

        public bool HasReadyAttackers()
        {
            return base.method_11<bool>("HasReadyAttackers", Array.Empty<object>());
        }

        public bool HasWeapon()
        {
            return base.method_11<bool>("HasWeapon", Array.Empty<object>());
        }

        public void InitManaCrystalMgr()
        {
            base.method_8("InitManaCrystalMgr", Array.Empty<object>());
        }

        public void InitPlayer(Network.HistCreateGame.PlayerData netPlayer)
        {
            object[] objArray1 = new object[] { netPlayer };
            base.method_8("InitPlayer", objArray1);
        }

        public bool IsAI()
        {
            return base.method_11<bool>("IsAI", Array.Empty<object>());
        }

        public bool IsBnetPlayer()
        {
            return base.method_11<bool>("IsBnetPlayer", Array.Empty<object>());
        }

        public bool IsComboActive()
        {
            return base.method_11<bool>("IsComboActive", Array.Empty<object>());
        }

        public bool IsCurrentPlayer()
        {
            return base.method_11<bool>("IsCurrentPlayer", Array.Empty<object>());
        }

        public bool IsDisplayable()
        {
            return base.method_11<bool>("IsDisplayable", Array.Empty<object>());
        }

        public bool IsFriendlySide()
        {
            return base.method_11<bool>("IsFriendlySide", Array.Empty<object>());
        }

        public bool IsGuestPlayer()
        {
            return base.method_11<bool>("IsGuestPlayer", Array.Empty<object>());
        }

        public bool IsHeroPowerAffectedByBonusDamage()
        {
            return base.method_11<bool>("IsHeroPowerAffectedByBonusDamage", Array.Empty<object>());
        }

        public bool IsHuman()
        {
            return base.method_11<bool>("IsHuman", Array.Empty<object>());
        }

        public bool IsLocalUser()
        {
            return base.method_11<bool>("IsLocalUser", Array.Empty<object>());
        }

        public bool IsOpposingSide()
        {
            return base.method_11<bool>("IsOpposingSide", Array.Empty<object>());
        }

        public bool IsRealTimeComboActive()
        {
            return base.method_11<bool>("IsRealTimeComboActive", Array.Empty<object>());
        }

        public bool IsRevealed()
        {
            return base.method_11<bool>("IsRevealed", Array.Empty<object>());
        }

        public void NotifyOfSpentMana(int spentMana)
        {
            object[] objArray1 = new object[] { spentMana };
            base.method_8("NotifyOfSpentMana", objArray1);
        }

        public void NotifyOfUsedTempMana(int usedMana)
        {
            object[] objArray1 = new object[] { usedMana };
            base.method_8("NotifyOfUsedTempMana", objArray1);
        }

        public void OnBnetPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnBnetPlayersChanged", objArray1);
        }

        public void OnBoardLoaded()
        {
            base.method_8("OnBoardLoaded", Array.Empty<object>());
        }

        public void OnFriendlyPlayerTagChanged(TagDelta change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnFriendlyPlayerTagChanged", objArray1);
        }

        public void OnOpposingPlayerTagChanged(TagDelta change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnOpposingPlayerTagChanged", objArray1);
        }

        public void OnRealTimeTagChanged(Network.HistTagChange change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnRealTimeTagChanged", objArray1);
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

        public void OnTurnChanged(int oldTurn, int newTurn, object userData)
        {
            object[] objArray1 = new object[] { oldTurn, newTurn, userData };
            base.method_8("OnTurnChanged", objArray1);
        }

        public void PlayConcedeEmote()
        {
            base.method_8("PlayConcedeEmote", Array.Empty<object>());
        }

        public void ProposeManaCrystalUsage(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("ProposeManaCrystalUsage", objArray1);
        }

        public void ReadyManaCrystal(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("ReadyManaCrystal", objArray1);
        }

        public void RequestPlayerPresence()
        {
            base.method_8("RequestPlayerPresence", Array.Empty<object>());
        }

        public void SetCardBackId(int id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetCardBackId", objArray1);
        }

        public void SetHero(Triton.Game.Mapping.Entity hero)
        {
            object[] objArray1 = new object[] { hero };
            base.method_8("SetHero", objArray1);
        }

        public void SetHeroPower(Triton.Game.Mapping.Entity heroPower)
        {
            object[] objArray1 = new object[] { heroPower };
            base.method_8("SetHeroPower", objArray1);
        }

        public void SetLocalUser(bool local)
        {
            object[] objArray1 = new object[] { local };
            base.method_8("SetLocalUser", objArray1);
        }

        public void SetName(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("SetName", objArray1);
        }

        public void SetPlayerId(int playerId)
        {
            object[] objArray1 = new object[] { playerId };
            base.method_8("SetPlayerId", objArray1);
        }

        public void SetRealTimeComboActive(bool active)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { active };
            base.method_9("SetRealTimeComboActive", enumArray1, objArray1);
        }

        public void SetRealTimeComboActive(int tagValue)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tagValue };
            base.method_9("SetRealTimeComboActive", enumArray1, objArray1);
        }

        public void SetRealTimeTempMana(int tempMana)
        {
            object[] objArray1 = new object[] { tempMana };
            base.method_8("SetRealTimeTempMana", objArray1);
        }

        public void SetSide(Side side)
        {
            object[] objArray1 = new object[] { side };
            base.method_8("SetSide", objArray1);
        }

        public bool ShouldUseBogusRank()
        {
            return base.method_11<bool>("ShouldUseBogusRank", Array.Empty<object>());
        }

        public bool ShouldUseHeroName()
        {
            return base.method_11<bool>("ShouldUseHeroName", Array.Empty<object>());
        }

        public void SpendManaCrystal(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("SpendManaCrystal", objArray1);
        }

        public void ToggleActorSpellOnCard(Card card, TagDelta change, SpellType spellType)
        {
            object[] objArray1 = new object[] { card, change, spellType };
            base.method_8("ToggleActorSpellOnCard", objArray1);
        }

        public void UnlockCrystals(int numCrystals)
        {
            object[] objArray1 = new object[] { numCrystals };
            base.method_8("UnlockCrystals", objArray1);
        }

        public void UpdateDisplayInfo()
        {
            base.method_8("UpdateDisplayInfo", Array.Empty<object>());
        }

        public void UpdateLocal()
        {
            base.method_8("UpdateLocal", Array.Empty<object>());
        }

        public void UpdateManaCounter()
        {
            base.method_8("UpdateManaCounter", Array.Empty<object>());
        }

        public void UpdateName()
        {
            base.method_8("UpdateName", Array.Empty<object>());
        }

        public void UpdateNameWithHeroName()
        {
            base.method_8("UpdateNameWithHeroName", Array.Empty<object>());
        }

        public void UpdateRank()
        {
            base.method_8("UpdateRank", Array.Empty<object>());
        }

        public void UpdateSide()
        {
            base.method_8("UpdateSide", Array.Empty<object>());
        }

        public void WipeZzzs()
        {
            base.method_8("WipeZzzs", Array.Empty<object>());
        }

        public int m_cardBackId
        {
            get
            {
                return base.method_2<int>("m_cardBackId");
            }
        }

        public bool m_concedeEmotePlayed
        {
            get
            {
                return base.method_2<bool>("m_concedeEmotePlayed");
            }
        }

        public Triton.Game.Mapping.Entity m_hero
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_hero");
            }
        }

        public Triton.Game.Mapping.Entity m_heroPower
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_heroPower");
            }
        }

        public bool m_local
        {
            get
            {
                return base.method_2<bool>("m_local");
            }
        }

        public ManaCounter m_manaCounter
        {
            get
            {
                return base.method_3<ManaCounter>("m_manaCounter");
            }
        }

        public MedalInfoTranslator m_medalInfo
        {
            get
            {
                return base.method_3<MedalInfoTranslator>("m_medalInfo");
            }
        }

        public string m_name
        {
            get
            {
                return base.method_4("m_name");
            }
        }

        public int m_queuedSpentMana
        {
            get
            {
                return base.method_2<int>("m_queuedSpentMana");
            }
        }

        public bool m_realTimeComboActive
        {
            get
            {
                return base.method_2<bool>("m_realTimeComboActive");
            }
        }

        public int m_realtimeTempMana
        {
            get
            {
                return base.method_2<int>("m_realtimeTempMana");
            }
        }

        public Side m_side
        {
            get
            {
                return base.method_2<Side>("m_side");
            }
        }

        public Triton.Game.Mapping.Entity m_startingHero
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_startingHero");
            }
        }

        public int m_usedTempMana
        {
            get
            {
                return base.method_2<int>("m_usedTempMana");
            }
        }

        public bool m_waitingForHeroEntity
        {
            get
            {
                return base.method_2<bool>("m_waitingForHeroEntity");
            }
        }

        public enum Side
        {
            NEUTRAL,
            FRIENDLY,
            OPPOSING
        }
    }
}

