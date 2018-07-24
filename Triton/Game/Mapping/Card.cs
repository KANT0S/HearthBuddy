namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Card")]
    public class Card : MonoBehaviour
    {
        public Card(IntPtr address) : this(address, "Card")
        {
        }

        public Card(IntPtr address, string className) : base(address, className)
        {
        }

        public Spell ActivateActorSpell(SpellType spellType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { spellType };
            return base.method_15<Spell>("ActivateActorSpell", enumArray1, objArray1);
        }

        public Spell ActivateActorSpell(Actor actor, SpellType spellType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { actor, spellType };
            return base.method_15<Spell>("ActivateActorSpell", enumArray1, objArray1);
        }

        public bool ActivateActorSpells_HandToPlay(Actor oldActor)
        {
            object[] objArray1 = new object[] { oldActor };
            return base.method_11<bool>("ActivateActorSpells_HandToPlay", objArray1);
        }

        public bool ActivateActorSpells_HandToWeapon(Actor oldActor)
        {
            object[] objArray1 = new object[] { oldActor };
            return base.method_11<bool>("ActivateActorSpells_HandToWeapon", objArray1);
        }

        public bool ActivateActorSpells_PlayToHand(Actor oldActor, bool wasInGraveyard)
        {
            object[] objArray1 = new object[] { oldActor, wasInGraveyard };
            return base.method_11<bool>("ActivateActorSpells_PlayToHand", objArray1);
        }

        public void ActivateCharacterAttackEffects()
        {
            base.method_8("ActivateCharacterAttackEffects", Array.Empty<object>());
        }

        public void ActivateCharacterDeathEffects()
        {
            base.method_8("ActivateCharacterDeathEffects", Array.Empty<object>());
        }

        public void ActivateCharacterPlayEffects()
        {
            base.method_8("ActivateCharacterPlayEffects", Array.Empty<object>());
        }

        public Spell ActivateCreatorSpawnMinionSpell()
        {
            return base.method_15<Spell>("ActivateCreatorSpawnMinionSpell", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void ActivateCustomHandSpawnSpell(Spell spell, Card creatorCard)
        {
            object[] objArray1 = new object[] { spell, creatorCard };
            base.method_8("ActivateCustomHandSpawnSpell", objArray1);
        }

        public void ActivateCustomKeywordEffect()
        {
            base.method_8("ActivateCustomKeywordEffect", Array.Empty<object>());
        }

        public void ActivateCustomSpawnMinionSpell(Spell spell, Card creatorCard)
        {
            object[] objArray1 = new object[] { spell, creatorCard };
            base.method_8("ActivateCustomSpawnMinionSpell", objArray1);
        }

        public Spell ActivateDeathSpell(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            return base.method_14<Spell>("ActivateDeathSpell", objArray1);
        }

        public Spell ActivateHandSpawnSpell()
        {
            return base.method_14<Spell>("ActivateHandSpawnSpell", Array.Empty<object>());
        }

        public void ActivateLifetimeEffects()
        {
            base.method_8("ActivateLifetimeEffects", Array.Empty<object>());
        }

        public void ActivateMinionSpawnEffects()
        {
            base.method_8("ActivateMinionSpawnEffects", Array.Empty<object>());
        }

        public bool ActivateSoundSpell(CardSoundSpell soundSpell)
        {
            object[] objArray1 = new object[] { soundSpell };
            return base.method_11<bool>("ActivateSoundSpell", objArray1);
        }

        public void ActivateStandardSpawnMinionSpell()
        {
            base.method_8("ActivateStandardSpawnMinionSpell", Array.Empty<object>());
        }

        public void AnimateDeckToPlay()
        {
            base.method_9("AnimateDeckToPlay", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void CancelActiveSpell(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            base.method_8("CancelActiveSpell", objArray1);
        }

        public void CancelActiveSpells()
        {
            base.method_8("CancelActiveSpells", Array.Empty<object>());
        }

        public bool CanShowActorVisuals()
        {
            return base.method_11<bool>("CanShowActorVisuals", Array.Empty<object>());
        }

        public bool CanShowSecret()
        {
            return base.method_11<bool>("CanShowSecret", Array.Empty<object>());
        }

        public bool CanShowSecretDeath()
        {
            return base.method_11<bool>("CanShowSecretDeath", Array.Empty<object>());
        }

        public bool CanShowSecretTrigger()
        {
            return base.method_11<bool>("CanShowSecretTrigger", Array.Empty<object>());
        }

        public bool CardStandInIsInteractive()
        {
            return base.method_11<bool>("CardStandInIsInteractive", Array.Empty<object>());
        }

        public void CreateStartingCardStateEffects()
        {
            base.method_8("CreateStartingCardStateEffects", Array.Empty<object>());
        }

        public void CutoffFriendlyCardDraw()
        {
            base.method_8("CutoffFriendlyCardDraw", Array.Empty<object>());
        }

        public void DeactivateBaubles()
        {
            base.method_8("DeactivateBaubles", Array.Empty<object>());
        }

        public void DeactivateCustomKeywordEffect()
        {
            base.method_8("DeactivateCustomKeywordEffect", Array.Empty<object>());
        }

        public void DeactivateLifetimeEffects()
        {
            base.method_8("DeactivateLifetimeEffects", Array.Empty<object>());
        }

        public void Destroy()
        {
            base.method_8("Destroy", Array.Empty<object>());
        }

        public void DestroyCardDefAssets()
        {
            base.method_8("DestroyCardDefAssets", Array.Empty<object>());
        }

        public void DestroyEmoteList()
        {
            base.method_8("DestroyEmoteList", Array.Empty<object>());
        }

        public void DiscardCardBeingDrawn()
        {
            base.method_8("DiscardCardBeingDrawn", Array.Empty<object>());
        }

        public bool DoChoiceHighlight(GameState state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("DoChoiceHighlight", objArray1);
        }

        public void DoDiscardAnimation()
        {
            base.method_8("DoDiscardAnimation", Array.Empty<object>());
        }

        public bool DoesCardReturnFromGraveyard()
        {
            return base.method_11<bool>("DoesCardReturnFromGraveyard", Array.Empty<object>());
        }

        public bool DoesTaskListBlockCardDraw(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("DoesTaskListBlockCardDraw", objArray1);
        }

        public bool DoesTaskListReturnCardFromGraveyard(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("DoesTaskListReturnCardFromGraveyard", objArray1);
        }

        public void DoNullZoneVisuals()
        {
            base.method_8("DoNullZoneVisuals", Array.Empty<object>());
        }

        public bool DoOptionHighlight(GameState state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("DoOptionHighlight", objArray1);
        }

        public bool DoOptionTargetHighlight(GameState state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("DoOptionTargetHighlight", objArray1);
        }

        public void DoPlayToDeckTransition(Actor playActor)
        {
            object[] objArray1 = new object[] { playActor };
            base.method_8("DoPlayToDeckTransition", objArray1);
        }

        public bool DoPlayToHandTransition(Actor oldActor, bool wasInGraveyard)
        {
            object[] objArray1 = new object[] { oldActor, wasInGraveyard };
            return base.method_11<bool>("DoPlayToHandTransition", objArray1);
        }

        public bool DoSubOptionHighlight(GameState state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("DoSubOptionHighlight", objArray1);
        }

        public void DoTauntNotification()
        {
            base.method_8("DoTauntNotification", Array.Empty<object>());
        }

        public void DrawFriendlyCard()
        {
            base.method_8("DrawFriendlyCard", Array.Empty<object>());
        }

        public void DrawOpponentCard()
        {
            base.method_8("DrawOpponentCard", Array.Empty<object>());
        }

        public void EnableAttacking(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableAttacking", objArray1);
        }

        public void EnableTransitioningZones(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableTransitioningZones", objArray1);
        }

        public void FinishActorLoad(Actor oldActor)
        {
            object[] objArray1 = new object[] { oldActor };
            base.method_8("FinishActorLoad", objArray1);
        }

        public void FinishSpellLoad()
        {
            base.method_8("FinishSpellLoad", Array.Empty<object>());
        }

        public void ForceLoadHandActor()
        {
            base.method_8("ForceLoadHandActor", Array.Empty<object>());
        }

        public Actor GetActor()
        {
            return base.method_14<Actor>("GetActor", Array.Empty<object>());
        }

        public Spell GetActorAttackSpellForInput()
        {
            return base.method_14<Spell>("GetActorAttackSpellForInput", Array.Empty<object>());
        }

        public string GetActorName()
        {
            return base.method_13("GetActorName", Array.Empty<object>());
        }

        public Spell GetActorSpell(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            return base.method_14<Spell>("GetActorSpell", objArray1);
        }

        public List<CardSoundSpell> GetAttackSoundSpells(bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { loadIfNeeded };
            Class267<CardSoundSpell> class2 = base.method_14<Class267<CardSoundSpell>>("GetAttackSoundSpells", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Spell GetAttackSpell(bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { loadIfNeeded };
            return base.method_14<Spell>("GetAttackSpell", objArray1);
        }

        public Spell GetBestDeathSpell()
        {
            return base.method_15<Spell>("GetBestDeathSpell", new Class272.Enum20[0], Array.Empty<object>());
        }

        public Spell GetBestDeathSpell(Actor actor)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { actor };
            return base.method_15<Spell>("GetBestDeathSpell", enumArray1, objArray1);
        }

        public Spell GetBestSpawnSpell()
        {
            return base.method_15<Spell>("GetBestSpawnSpell", new Class272.Enum20[0], Array.Empty<object>());
        }

        public Spell GetBestSummonSpell()
        {
            return base.method_15<Spell>("GetBestSummonSpell", new Class272.Enum20[0], Array.Empty<object>());
        }

        public CardDef GetCardDef()
        {
            return base.method_14<CardDef>("GetCardDef", Array.Empty<object>());
        }

        public Player GetController()
        {
            return base.method_14<Player>("GetController", Array.Empty<object>());
        }

        public Player.Side GetControllerSide()
        {
            return base.method_11<Player.Side>("GetControllerSide", Array.Empty<object>());
        }

        public Spell GetCustomDeathSpell()
        {
            return base.method_14<Spell>("GetCustomDeathSpell", Array.Empty<object>());
        }

        public Spell GetCustomDeathSpellOverride()
        {
            return base.method_14<Spell>("GetCustomDeathSpellOverride", Array.Empty<object>());
        }

        public Spell GetCustomSpawnSpell()
        {
            return base.method_14<Spell>("GetCustomSpawnSpell", Array.Empty<object>());
        }

        public Spell GetCustomSpawnSpellOverride()
        {
            return base.method_14<Spell>("GetCustomSpawnSpellOverride", Array.Empty<object>());
        }

        public Spell GetCustomSummonSpell()
        {
            return base.method_14<Spell>("GetCustomSummonSpell", Array.Empty<object>());
        }

        public List<CardSoundSpell> GetDeathSoundSpells(bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { loadIfNeeded };
            Class267<CardSoundSpell> class2 = base.method_14<Class267<CardSoundSpell>>("GetDeathSoundSpells", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public EmoteEntry GetEmoteEntry(EmoteType emoteType)
        {
            object[] objArray1 = new object[] { emoteType };
            return base.method_14<EmoteEntry>("GetEmoteEntry", objArray1);
        }

        public Triton.Game.Mapping.Entity GetEntity()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetEntity", Array.Empty<object>());
        }

        public Material GetGoldenMaterial()
        {
            return base.method_14<Material>("GetGoldenMaterial", Array.Empty<object>());
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

        public List<CardSoundSpell> GetLifetimeSoundSpells(bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { loadIfNeeded };
            Class267<CardSoundSpell> class2 = base.method_14<Class267<CardSoundSpell>>("GetLifetimeSoundSpells", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Spell GetLifetimeSpell(bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { loadIfNeeded };
            return base.method_14<Spell>("GetLifetimeSpell", objArray1);
        }

        public CardEffect GetPlayEffect()
        {
            return base.method_14<CardEffect>("GetPlayEffect", Array.Empty<object>());
        }

        public List<CardSoundSpell> GetPlaySoundSpells(bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { loadIfNeeded };
            Class267<CardSoundSpell> class2 = base.method_14<Class267<CardSoundSpell>>("GetPlaySoundSpells", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Spell GetPlaySpell(bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { loadIfNeeded };
            return base.method_14<Spell>("GetPlaySpell", objArray1);
        }

        public Texture GetPortraitTexture()
        {
            return base.method_14<Texture>("GetPortraitTexture", Array.Empty<object>());
        }

        public int GetPredictedZonePosition()
        {
            return base.method_11<int>("GetPredictedZonePosition", Array.Empty<object>());
        }

        public TAG_PREMIUM GetPremium()
        {
            return base.method_11<TAG_PREMIUM>("GetPremium", Array.Empty<object>());
        }

        public Zone GetPrevZone()
        {
            return base.method_14<Zone>("GetPrevZone", Array.Empty<object>());
        }

        public bool GetShouldShowTooltip()
        {
            return base.method_11<bool>("GetShouldShowTooltip", Array.Empty<object>());
        }

        public CardEffect GetSubOptionEffect(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_14<CardEffect>("GetSubOptionEffect", objArray1);
        }

        public List<CardSoundSpell> GetSubOptionSoundSpells(int index, bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { index, loadIfNeeded };
            Class267<CardSoundSpell> class2 = base.method_14<Class267<CardSoundSpell>>("GetSubOptionSoundSpells", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Spell GetSubOptionSpell(int index, bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { index, loadIfNeeded };
            return base.method_14<Spell>("GetSubOptionSpell", objArray1);
        }

        public float GetTransitionDelay()
        {
            return base.method_11<float>("GetTransitionDelay", Array.Empty<object>());
        }

        public ZoneTransitionStyle GetTransitionStyle()
        {
            return base.method_11<ZoneTransitionStyle>("GetTransitionStyle", Array.Empty<object>());
        }

        public CardEffect GetTriggerEffect(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_14<CardEffect>("GetTriggerEffect", objArray1);
        }

        public List<CardSoundSpell> GetTriggerSoundSpells(int index, bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { index, loadIfNeeded };
            Class267<CardSoundSpell> class2 = base.method_14<Class267<CardSoundSpell>>("GetTriggerSoundSpells", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Spell GetTriggerSpell(int index, bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { index, loadIfNeeded };
            return base.method_14<Spell>("GetTriggerSpell", objArray1);
        }

        public Zone GetZone()
        {
            return base.method_14<Zone>("GetZone", Array.Empty<object>());
        }

        public int GetZonePosition()
        {
            return base.method_11<int>("GetZonePosition", Array.Empty<object>());
        }

        public bool HandleGraveyardToDeck(Actor oldActor)
        {
            object[] objArray1 = new object[] { oldActor };
            return base.method_11<bool>("HandleGraveyardToDeck", objArray1);
        }

        public bool HandleGraveyardToHand(Actor oldActor)
        {
            object[] objArray1 = new object[] { oldActor };
            return base.method_11<bool>("HandleGraveyardToHand", objArray1);
        }

        public bool HandlePlayActorDeath(Actor oldActor)
        {
            object[] objArray1 = new object[] { oldActor };
            return base.method_11<bool>("HandlePlayActorDeath", objArray1);
        }

        public bool HasActiveEmoteSound()
        {
            return base.method_11<bool>("HasActiveEmoteSound", Array.Empty<object>());
        }

        public bool HasBeenGrabbedByEnemyActionHandler()
        {
            return base.method_11<bool>("HasBeenGrabbedByEnemyActionHandler", Array.Empty<object>());
        }

        public void HideCard()
        {
            base.method_8("HideCard", Array.Empty<object>());
        }

        public void HideImpl()
        {
            base.method_8("HideImpl", Array.Empty<object>());
        }

        public void HideTooltip()
        {
            base.method_8("HideTooltip", Array.Empty<object>());
        }

        public void IgnoreDeath(bool ignore)
        {
            object[] objArray1 = new object[] { ignore };
            base.method_8("IgnoreDeath", objArray1);
        }

        public void InitActor(string actorName, Actor actor)
        {
            object[] objArray1 = new object[] { actorName, actor };
            base.method_8("InitActor", objArray1);
        }

        public void InitCardDefAssets()
        {
            base.method_8("InitCardDefAssets", Array.Empty<object>());
        }

        public void InitEmoteList()
        {
            base.method_8("InitEmoteList", Array.Empty<object>());
        }

        public bool IsAbleToShowTooltip()
        {
            return base.method_11<bool>("IsAbleToShowTooltip", Array.Empty<object>());
        }

        public bool IsActorLoading()
        {
            return base.method_11<bool>("IsActorLoading", Array.Empty<object>());
        }

        public bool IsActorReady()
        {
            return base.method_11<bool>("IsActorReady", Array.Empty<object>());
        }

        public bool IsAllowedToShowTooltip()
        {
            return base.method_11<bool>("IsAllowedToShowTooltip", Array.Empty<object>());
        }

        public bool IsAttacking()
        {
            return base.method_11<bool>("IsAttacking", Array.Empty<object>());
        }

        public bool IsBeingDrawnByOpponent()
        {
            return base.method_11<bool>("IsBeingDrawnByOpponent", Array.Empty<object>());
        }

        public bool IsDoNotSort()
        {
            return base.method_11<bool>("IsDoNotSort", Array.Empty<object>());
        }

        public bool IsDoNotWarpToNewZone()
        {
            return base.method_11<bool>("IsDoNotWarpToNewZone", Array.Empty<object>());
        }

        public bool IsHoldingForLinkedCardSwitch()
        {
            return base.method_11<bool>("IsHoldingForLinkedCardSwitch", Array.Empty<object>());
        }

        public bool IsInputEnabled()
        {
            return base.method_11<bool>("IsInputEnabled", Array.Empty<object>());
        }

        public bool IsMousedOver()
        {
            return base.method_11<bool>("IsMousedOver", Array.Empty<object>());
        }

        public bool IsOverPlayfield()
        {
            return base.method_11<bool>("IsOverPlayfield", Array.Empty<object>());
        }

        public bool IsShowingTooltip()
        {
            return base.method_11<bool>("IsShowingTooltip", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public bool IsTransitioningZones()
        {
            return base.method_11<bool>("IsTransitioningZones", Array.Empty<object>());
        }

        public void LoadActor()
        {
            base.method_8("LoadActor", Array.Empty<object>());
        }

        public void LoadActorAndSpells()
        {
            base.method_8("LoadActorAndSpells", Array.Empty<object>());
        }

        public void LoadCardDef(CardDef cardDef)
        {
            object[] objArray1 = new object[] { cardDef };
            base.method_8("LoadCardDef", objArray1);
        }

        public void MarkAsGrabbedByEnemyActionHandler(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("MarkAsGrabbedByEnemyActionHandler", objArray1);
        }

        public void MillCard()
        {
            base.method_8("MillCard", Array.Empty<object>());
        }

        public void NotifyLeftPlayfield()
        {
            base.method_8("NotifyLeftPlayfield", Array.Empty<object>());
        }

        public void NotifyMousedOut()
        {
            base.method_8("NotifyMousedOut", Array.Empty<object>());
        }

        public void NotifyMousedOver()
        {
            base.method_8("NotifyMousedOver", Array.Empty<object>());
        }

        public void NotifyOpponentMousedOffThisCard()
        {
            base.method_8("NotifyOpponentMousedOffThisCard", Array.Empty<object>());
        }

        public void NotifyOpponentMousedOverThisCard()
        {
            base.method_8("NotifyOpponentMousedOverThisCard", Array.Empty<object>());
        }

        public void NotifyOverPlayfield()
        {
            base.method_8("NotifyOverPlayfield", Array.Empty<object>());
        }

        public void NotifyPickedUp()
        {
            base.method_8("NotifyPickedUp", Array.Empty<object>());
        }

        public void NotifyTargetingCanceled()
        {
            base.method_8("NotifyTargetingCanceled", Array.Empty<object>());
        }

        public void OnActorChanged(Actor oldActor)
        {
            object[] objArray1 = new object[] { oldActor };
            base.method_8("OnActorChanged", objArray1);
        }

        public void OnActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnActorLoaded", objArray1);
        }

        public void OnCustomDeathSpellLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnCustomDeathSpellLoaded", objArray1);
        }

        public void OnCustomSpawnSpellLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnCustomSpawnSpellLoaded", objArray1);
        }

        public void OnCustomSummonSpellLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnCustomSummonSpellLoaded", objArray1);
        }

        public void OnEnchantmentAdded(int oldEnchantmentCount, Triton.Game.Mapping.Entity enchantment)
        {
            object[] objArray1 = new object[] { oldEnchantmentCount, enchantment };
            base.method_8("OnEnchantmentAdded", objArray1);
        }

        public void OnEnchantmentRemoved(int oldEnchantmentCount, Triton.Game.Mapping.Entity enchantment)
        {
            object[] objArray1 = new object[] { oldEnchantmentCount, enchantment };
            base.method_8("OnEnchantmentRemoved", objArray1);
        }

        public void OnEnchantmentSpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnEnchantmentSpellStateFinished", objArray1);
        }

        public void OnHandActorForceLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnHandActorForceLoaded", objArray1);
        }

        public void OnMetaData(Network.HistMetaData metaData)
        {
            object[] objArray1 = new object[] { metaData };
            base.method_8("OnMetaData", objArray1);
        }

        public void OnSpellFinished_CustomHandSpawn(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_CustomHandSpawn", objArray1);
        }

        public void OnSpellFinished_CustomSpawnMinion(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_CustomSpawnMinion", objArray1);
        }

        public void OnSpellFinished_Death(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_Death", objArray1);
        }

        public void OnSpellFinished_DefaultHandSpawn(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_DefaultHandSpawn", objArray1);
        }

        public void OnSpellFinished_DefaultPlaySpawn(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_DefaultPlaySpawn", objArray1);
        }

        public void OnSpellFinished_HandToPlay_SummonIn(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_HandToPlay_SummonIn", objArray1);
        }

        public void OnSpellFinished_HandToPlay_SummonOut(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_HandToPlay_SummonOut", objArray1);
        }

        public void OnSpellFinished_HandToWeapon_SummonOut(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_HandToWeapon_SummonOut", objArray1);
        }

        public void OnSpellFinished_PlayToHand_SummonIn(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_PlayToHand_SummonIn", objArray1);
        }

        public void OnSpellFinished_PlayToHand_SummonOut(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_PlayToHand_SummonOut", objArray1);
        }

        public void OnSpellFinished_PlayToHand_SummonOut_FromGraveyard(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_PlayToHand_SummonOut_FromGraveyard", objArray1);
        }

        public void OnSpellFinished_StandardCardSummon(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_StandardCardSummon", objArray1);
        }

        public void OnSpellFinished_StandardSpawnMinion(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_StandardSpawnMinion", objArray1);
        }

        public void OnSpellFinished_UpdateActorComponents(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_UpdateActorComponents", objArray1);
        }

        public void OnSpellStateFinished_CustomDeath(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnSpellStateFinished_CustomDeath", objArray1);
        }

        public void OnSpellStateFinished_DestroyActor(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnSpellStateFinished_DestroyActor", objArray1);
        }

        public void OnSpellStateFinished_DestroySpell(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnSpellStateFinished_DestroySpell", objArray1);
        }

        public void OnSpellStateFinished_PlayToHand_OldActor_SummonOut(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnSpellStateFinished_PlayToHand_OldActor_SummonOut", objArray1);
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

        public void OnZoneChanged()
        {
            base.method_8("OnZoneChanged", Array.Empty<object>());
        }

        public void OverrideCustomDeathSpell(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            base.method_8("OverrideCustomDeathSpell", objArray1);
        }

        public void OverrideCustomSpawnSpell(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            base.method_8("OverrideCustomSpawnSpell", objArray1);
        }

        public CardSoundSpell PlayEmote(EmoteType emoteType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { emoteType };
            return base.method_15<CardSoundSpell>("PlayEmote", enumArray1, objArray1);
        }

        public CardSoundSpell PlayEmote(EmoteType emoteType, Triton.Game.Mapping.Notification.SpeechBubbleDirection overrideDirection)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { emoteType, overrideDirection };
            return base.method_15<CardSoundSpell>("PlayEmote", enumArray1, objArray1);
        }

        public void PrepareForDeathAnimation(Actor dyingActor)
        {
            object[] objArray1 = new object[] { dyingActor };
            base.method_8("PrepareForDeathAnimation", objArray1);
        }

        public SpellType PrioritizedBauble()
        {
            return base.method_11<SpellType>("PrioritizedBauble", Array.Empty<object>());
        }

        public void PurgeInactiveSpells()
        {
            base.method_8("PurgeInactiveSpells", Array.Empty<object>());
        }

        public void RefreshActor()
        {
            base.method_8("RefreshActor", Array.Empty<object>());
        }

        public void ResumeLayoutForPlayZone()
        {
            base.method_8("ResumeLayoutForPlayZone", Array.Empty<object>());
        }

        public void SetActor(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("SetActor", objArray1);
        }

        public void SetActorName(string actorName)
        {
            object[] objArray1 = new object[] { actorName };
            base.method_8("SetActorName", objArray1);
        }

        public void SetBattleCrySource(bool source)
        {
            object[] objArray1 = new object[] { source };
            base.method_8("SetBattleCrySource", objArray1);
        }

        public void SetDoNotSort(bool on)
        {
            object[] objArray1 = new object[] { on };
            base.method_8("SetDoNotSort", objArray1);
        }

        public void SetDoNotWarpToNewZone(bool on)
        {
            object[] objArray1 = new object[] { on };
            base.method_8("SetDoNotWarpToNewZone", objArray1);
        }

        public void SetEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("SetEntity", objArray1);
        }

        public void SetHoldingForLinkedCardSwitch(bool hold)
        {
            object[] objArray1 = new object[] { hold };
            base.method_8("SetHoldingForLinkedCardSwitch", objArray1);
        }

        public void SetInputEnabled(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("SetInputEnabled", objArray1);
        }

        public void SetPredictedZonePosition(int pos)
        {
            object[] objArray1 = new object[] { pos };
            base.method_8("SetPredictedZonePosition", objArray1);
        }

        public void SetSecretTriggered(bool set)
        {
            object[] objArray1 = new object[] { set };
            base.method_8("SetSecretTriggered", objArray1);
        }

        public void SetShouldShowTooltip()
        {
            base.method_8("SetShouldShowTooltip", Array.Empty<object>());
        }

        public void SetTransitionDelay(float delay)
        {
            object[] objArray1 = new object[] { delay };
            base.method_8("SetTransitionDelay", objArray1);
        }

        public void SetTransitionStyle(ZoneTransitionStyle style)
        {
            object[] objArray1 = new object[] { style };
            base.method_8("SetTransitionStyle", objArray1);
        }

        public void SetupDeckToPlayActor(Actor actor, GameObject actorObject)
        {
            object[] objArray1 = new object[] { actor, actorObject };
            base.method_8("SetupDeckToPlayActor", objArray1);
        }

        public Spell SetupOverrideSpell(Spell existingSpell, Spell spell)
        {
            object[] objArray1 = new object[] { existingSpell, spell };
            return base.method_14<Spell>("SetupOverrideSpell", objArray1);
        }

        public void SetZone(Zone zone)
        {
            object[] objArray1 = new object[] { zone };
            base.method_8("SetZone", objArray1);
        }

        public void SetZonePosition(int pos)
        {
            object[] objArray1 = new object[] { pos };
            base.method_8("SetZonePosition", objArray1);
        }

        public void SheatheSecret(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            base.method_8("SheatheSecret", objArray1);
        }

        public void SheatheWeapon()
        {
            base.method_8("SheatheWeapon", Array.Empty<object>());
        }

        public bool ShouldCardDrawWaitForTaskLists()
        {
            return base.method_11<bool>("ShouldCardDrawWaitForTaskLists", Array.Empty<object>());
        }

        public bool ShouldCardDrawWaitForTurnStartSpells()
        {
            return base.method_11<bool>("ShouldCardDrawWaitForTurnStartSpells", Array.Empty<object>());
        }

        public bool ShouldPreloadCardAssets()
        {
            return base.method_11<bool>("ShouldPreloadCardAssets", Array.Empty<object>());
        }

        public void ShowCard()
        {
            base.method_8("ShowCard", Array.Empty<object>());
        }

        public void ShowExhaustedChange(bool exhausted)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { exhausted };
            base.method_9("ShowExhaustedChange", enumArray1, objArray1);
        }

        public void ShowExhaustedChange(int val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { val };
            base.method_9("ShowExhaustedChange", enumArray1, objArray1);
        }

        public void ShowImpl()
        {
            base.method_8("ShowImpl", Array.Empty<object>());
        }

        public void ShowSecretBirth()
        {
            base.method_8("ShowSecretBirth", Array.Empty<object>());
        }

        public void ShowSecretDeath(Actor oldActor)
        {
            object[] objArray1 = new object[] { oldActor };
            base.method_8("ShowSecretDeath", objArray1);
        }

        public void ShowSecretTrigger()
        {
            base.method_8("ShowSecretTrigger", Array.Empty<object>());
        }

        public void ShowTooltip()
        {
            base.method_8("ShowTooltip", Array.Empty<object>());
        }

        public void SuppressActorTriggerSpell(bool suppress)
        {
            object[] objArray1 = new object[] { suppress };
            base.method_8("SuppressActorTriggerSpell", objArray1);
        }

        public void SuppressDeathEffects(bool suppress)
        {
            object[] objArray1 = new object[] { suppress };
            base.method_8("SuppressDeathEffects", objArray1);
        }

        public void SuppressDeathSounds(bool suppress)
        {
            object[] objArray1 = new object[] { suppress };
            base.method_8("SuppressDeathSounds", objArray1);
        }

        public void SuppressKeywordDeaths(bool suppress)
        {
            object[] objArray1 = new object[] { suppress };
            base.method_8("SuppressKeywordDeaths", objArray1);
        }

        public void SuppressPlaySounds(bool suppress)
        {
            object[] objArray1 = new object[] { suppress };
            base.method_8("SuppressPlaySounds", objArray1);
        }

        public bool SwitchOutLinkedDrawnCard()
        {
            return base.method_11<bool>("SwitchOutLinkedDrawnCard", Array.Empty<object>());
        }

        public void ToggleBauble(bool on, SpellType spellType)
        {
            object[] objArray1 = new object[] { on, spellType };
            base.method_8("ToggleBauble", objArray1);
        }

        public void ToggleDeathrattle(bool on)
        {
            object[] objArray1 = new object[] { on };
            base.method_8("ToggleDeathrattle", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public void TransitionToZone(Zone zone)
        {
            object[] objArray1 = new object[] { zone };
            base.method_8("TransitionToZone", objArray1);
        }

        public void UnSheatheSecret(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            base.method_8("UnSheatheSecret", objArray1);
        }

        public void UnSheatheWeapon()
        {
            base.method_8("UnSheatheWeapon", Array.Empty<object>());
        }

        public void UpdateActor()
        {
            base.method_8("UpdateActor", Array.Empty<object>());
        }

        public void UpdateActorComponents()
        {
            base.method_8("UpdateActorComponents", Array.Empty<object>());
        }

        public void UpdateActorState()
        {
            base.method_8("UpdateActorState", Array.Empty<object>());
        }

        public void UpdateEnchantments()
        {
            base.method_8("UpdateEnchantments", Array.Empty<object>());
        }

        public void UpdateProposedManaUsage()
        {
            base.method_8("UpdateProposedManaUsage", Array.Empty<object>());
        }

        public void UpdateTooltip()
        {
            base.method_8("UpdateTooltip", Array.Empty<object>());
        }

        public void UpdateZoneFromTags()
        {
            base.method_8("UpdateZoneFromTags", Array.Empty<object>());
        }

        public bool WasSecretTriggered()
        {
            return base.method_11<bool>("WasSecretTriggered", Array.Empty<object>());
        }

        public bool WillIgnoreDeath()
        {
            return base.method_11<bool>("WillIgnoreDeath", Array.Empty<object>());
        }

        public bool WillSuppressActorTriggerSpell()
        {
            return base.method_11<bool>("WillSuppressActorTriggerSpell", Array.Empty<object>());
        }

        public bool WillSuppressDeathEffects()
        {
            return base.method_11<bool>("WillSuppressDeathEffects", Array.Empty<object>());
        }

        public bool WillSuppressDeathSounds()
        {
            return base.method_11<bool>("WillSuppressDeathSounds", Array.Empty<object>());
        }

        public bool WillSuppressKeywordDeaths()
        {
            return base.method_11<bool>("WillSuppressKeywordDeaths", Array.Empty<object>());
        }

        public bool WillSuppressPlaySounds()
        {
            return base.method_11<bool>("WillSuppressPlaySounds", Array.Empty<object>());
        }

        public static Vector3 ABOVE_DECK_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "Card", "ABOVE_DECK_OFFSET");
            }
        }

        public static Vector3 IN_DECK_ANGLES
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "Card", "IN_DECK_ANGLES");
            }
        }

        public static Vector3 IN_DECK_HIDDEN_ANGLES
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "Card", "IN_DECK_HIDDEN_ANGLES");
            }
        }

        public static Quaternion IN_DECK_HIDDEN_ROTATION
        {
            get
            {
                return MonoClass.smethod_6<Quaternion>(TritonHs.MainAssemblyPath, "", "Card", "IN_DECK_HIDDEN_ROTATION");
            }
        }

        public static Vector3 IN_DECK_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "Card", "IN_DECK_OFFSET");
            }
        }

        public static Quaternion IN_DECK_ROTATION
        {
            get
            {
                return MonoClass.smethod_6<Quaternion>(TritonHs.MainAssemblyPath, "", "Card", "IN_DECK_ROTATION");
            }
        }

        public static Vector3 IN_DECK_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "Card", "IN_DECK_SCALE");
            }
        }

        public int m_activeDeathEffectCount
        {
            get
            {
                return base.method_2<int>("m_activeDeathEffectCount");
            }
        }

        public Actor m_actor
        {
            get
            {
                return base.method_3<Actor>("m_actor");
            }
        }

        public bool m_actorLoading
        {
            get
            {
                return base.method_2<bool>("m_actorLoading");
            }
        }

        public string m_actorName
        {
            get
            {
                return base.method_4("m_actorName");
            }
        }

        public bool m_actorReady
        {
            get
            {
                return base.method_2<bool>("m_actorReady");
            }
        }

        public Actor m_actorWaitingToBeReplaced
        {
            get
            {
                return base.method_3<Actor>("m_actorWaitingToBeReplaced");
            }
        }

        public List<CardEffect> m_allEffects
        {
            get
            {
                Class267<CardEffect> class2 = base.method_3<Class267<CardEffect>>("m_allEffects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public CardAudio m_announcerLine
        {
            get
            {
                return base.method_3<CardAudio>("m_announcerLine");
            }
        }

        public CardEffect m_attackEffect
        {
            get
            {
                return base.method_3<CardEffect>("m_attackEffect");
            }
        }

        public bool m_attacking
        {
            get
            {
                return base.method_2<bool>("m_attacking");
            }
        }

        public bool m_beingDrawnByOpponent
        {
            get
            {
                return base.method_2<bool>("m_beingDrawnByOpponent");
            }
        }

        public CardDef m_cardDef
        {
            get
            {
                return base.method_3<CardDef>("m_cardDef");
            }
        }

        public bool m_cardStandInInteractive
        {
            get
            {
                return base.method_2<bool>("m_cardStandInInteractive");
            }
        }

        public Spell m_customDeathSpell
        {
            get
            {
                return base.method_3<Spell>("m_customDeathSpell");
            }
        }

        public Spell m_customDeathSpellOverride
        {
            get
            {
                return base.method_3<Spell>("m_customDeathSpellOverride");
            }
        }

        public CardEffect m_customKeywordSpell
        {
            get
            {
                return base.method_3<CardEffect>("m_customKeywordSpell");
            }
        }

        public Spell m_customSpawnSpell
        {
            get
            {
                return base.method_3<Spell>("m_customSpawnSpell");
            }
        }

        public Spell m_customSpawnSpellOverride
        {
            get
            {
                return base.method_3<Spell>("m_customSpawnSpellOverride");
            }
        }

        public Spell m_customSummonSpell
        {
            get
            {
                return base.method_3<Spell>("m_customSummonSpell");
            }
        }

        public CardEffect m_deathEffect
        {
            get
            {
                return base.method_3<CardEffect>("m_deathEffect");
            }
        }

        public bool m_doNotSort
        {
            get
            {
                return base.method_2<bool>("m_doNotSort");
            }
        }

        public bool m_doNotWarpToNewZone
        {
            get
            {
                return base.method_2<bool>("m_doNotWarpToNewZone");
            }
        }

        public List<EmoteEntry> m_emotes
        {
            get
            {
                Class267<EmoteEntry> class2 = base.method_3<Class267<EmoteEntry>>("m_emotes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Triton.Game.Mapping.Entity m_entity
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_entity");
            }
        }

        public bool m_hasBeenGrabbedByEnemyActionHandler
        {
            get
            {
                return base.method_2<bool>("m_hasBeenGrabbedByEnemyActionHandler");
            }
        }

        public bool m_holdingForLinkedCardSwitch
        {
            get
            {
                return base.method_2<bool>("m_holdingForLinkedCardSwitch");
            }
        }

        public bool m_ignoreDeath
        {
            get
            {
                return base.method_2<bool>("m_ignoreDeath");
            }
        }

        public bool m_inputEnabled
        {
            get
            {
                return base.method_2<bool>("m_inputEnabled");
            }
        }

        public bool m_isBattleCrySource
        {
            get
            {
                return base.method_2<bool>("m_isBattleCrySource");
            }
        }

        public CardEffect m_lifetimeEffect
        {
            get
            {
                return base.method_3<CardEffect>("m_lifetimeEffect");
            }
        }

        public bool m_mousedOver
        {
            get
            {
                return base.method_2<bool>("m_mousedOver");
            }
        }

        public bool m_mousedOverByOpponent
        {
            get
            {
                return base.method_2<bool>("m_mousedOverByOpponent");
            }
        }

        public bool m_overPlayfield
        {
            get
            {
                return base.method_2<bool>("m_overPlayfield");
            }
        }

        public CardEffect m_playEffect
        {
            get
            {
                return base.method_3<CardEffect>("m_playEffect");
            }
        }

        public int m_predictedZonePosition
        {
            get
            {
                return base.method_2<int>("m_predictedZonePosition");
            }
        }

        public Zone m_prevZone
        {
            get
            {
                return base.method_3<Zone>("m_prevZone");
            }
        }

        public bool m_secretSheathed
        {
            get
            {
                return base.method_2<bool>("m_secretSheathed");
            }
        }

        public bool m_secretTriggered
        {
            get
            {
                return base.method_2<bool>("m_secretTriggered");
            }
        }

        public bool m_shouldShowTooltip
        {
            get
            {
                return base.method_2<bool>("m_shouldShowTooltip");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public bool m_showTooltip
        {
            get
            {
                return base.method_2<bool>("m_showTooltip");
            }
        }

        public int m_spellLoadCount
        {
            get
            {
                return base.method_2<int>("m_spellLoadCount");
            }
        }

        public List<CardEffect> m_subOptionEffects
        {
            get
            {
                Class267<CardEffect> class2 = base.method_3<Class267<CardEffect>>("m_subOptionEffects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_suppressActorTriggerSpell
        {
            get
            {
                return base.method_2<bool>("m_suppressActorTriggerSpell");
            }
        }

        public bool m_suppressDeathEffects
        {
            get
            {
                return base.method_2<bool>("m_suppressDeathEffects");
            }
        }

        public bool m_suppressDeathSounds
        {
            get
            {
                return base.method_2<bool>("m_suppressDeathSounds");
            }
        }

        public bool m_suppressKeywordDeaths
        {
            get
            {
                return base.method_2<bool>("m_suppressKeywordDeaths");
            }
        }

        public bool m_suppressPlaySounds
        {
            get
            {
                return base.method_2<bool>("m_suppressPlaySounds");
            }
        }

        public float m_transitionDelay
        {
            get
            {
                return base.method_2<float>("m_transitionDelay");
            }
        }

        public bool m_transitioningZones
        {
            get
            {
                return base.method_2<bool>("m_transitioningZones");
            }
        }

        public ZoneTransitionStyle m_transitionStyle
        {
            get
            {
                return base.method_2<ZoneTransitionStyle>("m_transitionStyle");
            }
        }

        public List<CardEffect> m_triggerEffects
        {
            get
            {
                Class267<CardEffect> class2 = base.method_3<Class267<CardEffect>>("m_triggerEffects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Zone m_zone
        {
            get
            {
                return base.method_3<Zone>("m_zone");
            }
        }

        public int m_zonePosition
        {
            get
            {
                return base.method_2<int>("m_zonePosition");
            }
        }

        [Attribute38("Card.SpellLoadRequest")]
        public class SpellLoadRequest : MonoClass
        {
            public SpellLoadRequest(IntPtr address) : this(address, "SpellLoadRequest")
            {
            }

            public SpellLoadRequest(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_path
            {
                get
                {
                    return base.method_4("m_path");
                }
            }
        }
    }
}

