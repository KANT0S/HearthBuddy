namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("GameEntity")]
    public class GameEntity : Triton.Game.Mapping.Entity
    {
        public GameEntity(IntPtr address) : this(address, "GameEntity")
        {
        }

        public GameEntity(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AreTooltipsDisabled()
        {
            return base.method_11<bool>("AreTooltipsDisabled", Array.Empty<object>());
        }

        public Spell BlowUpHero(Card card, SpellType spellType)
        {
            object[] objArray1 = new object[] { card, spellType };
            return base.method_14<Spell>("BlowUpHero", objArray1);
        }

        public bool CheckPreloadedSound(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_11<bool>("CheckPreloadedSound", objArray1);
        }

        public string CustomChoiceBannerText()
        {
            return base.method_13("CustomChoiceBannerText", Array.Empty<object>());
        }

        public bool DoAlternateMulliganIntro()
        {
            return base.method_11<bool>("DoAlternateMulliganIntro", Array.Empty<object>());
        }

        public void EmoteHandlerDoneLoadingCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("EmoteHandlerDoneLoadingCallback", objArray1);
        }

        public void EnemyEmoteHandlerDoneLoadingCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("EnemyEmoteHandlerDoneLoadingCallback", objArray1);
        }

        public void FadeInActor(Actor actorToFade)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { actorToFade };
            base.method_9("FadeInActor", enumArray1, objArray1);
        }

        public void FadeInActor(Actor actorToFade, float lightBlendAmount)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { actorToFade, lightBlendAmount };
            base.method_9("FadeInActor", enumArray1, objArray1);
        }

        public void FadeInHeroActor(Actor actorToFade)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { actorToFade };
            base.method_9("FadeInHeroActor", enumArray1, objArray1);
        }

        public void FadeInHeroActor(Actor actorToFade, float lightBlendAmount)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { actorToFade, lightBlendAmount };
            base.method_9("FadeInHeroActor", enumArray1, objArray1);
        }

        public void FadeOutActor(Actor actorToFade)
        {
            object[] objArray1 = new object[] { actorToFade };
            base.method_8("FadeOutActor", objArray1);
        }

        public void FadeOutHeroActor(Actor actorToFade)
        {
            object[] objArray1 = new object[] { actorToFade };
            base.method_8("FadeOutHeroActor", objArray1);
        }

        public float GetAdditionalTimeToWaitForSpells()
        {
            return base.method_11<float>("GetAdditionalTimeToWaitForSpells", Array.Empty<object>());
        }

        public string GetAlternatePlayerName()
        {
            return base.method_13("GetAlternatePlayerName", Array.Empty<object>());
        }

        public List<RewardData> GetCustomRewards()
        {
            Class267<RewardData> class2 = base.method_14<Class267<RewardData>>("GetCustomRewards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public string GetDebugName()
        {
            return base.method_13("GetDebugName", Array.Empty<object>());
        }

        public string GetName()
        {
            return base.method_13("GetName", Array.Empty<object>());
        }

        public string GetTurnStartReminderText()
        {
            return base.method_13("GetTurnStartReminderText", Array.Empty<object>());
        }

        public void HandleRealTimeMissionEvent(int missionEvent)
        {
            object[] objArray1 = new object[] { missionEvent };
            base.method_8("HandleRealTimeMissionEvent", objArray1);
        }

        public bool IsEnemySpeaking()
        {
            return base.method_11<bool>("IsEnemySpeaking", Array.Empty<object>());
        }

        public bool IsKeywordHelpDelayOverridden()
        {
            return base.method_11<bool>("IsKeywordHelpDelayOverridden", Array.Empty<object>());
        }

        public bool IsMouseOverDelayOverriden()
        {
            return base.method_11<bool>("IsMouseOverDelayOverriden", Array.Empty<object>());
        }

        public bool IsPreloadingAssets()
        {
            return base.method_11<bool>("IsPreloadingAssets", Array.Empty<object>());
        }

        public bool NotifyOfBattlefieldCardClicked(Triton.Game.Mapping.Entity clickedEntity, bool wasInTargetMode)
        {
            object[] objArray1 = new object[] { clickedEntity, wasInTargetMode };
            return base.method_11<bool>("NotifyOfBattlefieldCardClicked", objArray1);
        }

        public void NotifyOfCardDropped(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("NotifyOfCardDropped", objArray1);
        }

        public void NotifyOfCardGrabbed(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("NotifyOfCardGrabbed", objArray1);
        }

        public void NotifyOfCardMousedOff(Triton.Game.Mapping.Entity mousedOffEntity)
        {
            object[] objArray1 = new object[] { mousedOffEntity };
            base.method_8("NotifyOfCardMousedOff", objArray1);
        }

        public void NotifyOfCardMousedOver(Triton.Game.Mapping.Entity mousedOverEntity)
        {
            object[] objArray1 = new object[] { mousedOverEntity };
            base.method_8("NotifyOfCardMousedOver", objArray1);
        }

        public void NotifyOfCardTooltipDisplayHide(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("NotifyOfCardTooltipDisplayHide", objArray1);
        }

        public bool NotifyOfCardTooltipDisplayShow(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("NotifyOfCardTooltipDisplayShow", objArray1);
        }

        public void NotifyOfCoinFlipResult()
        {
            base.method_8("NotifyOfCoinFlipResult", Array.Empty<object>());
        }

        public void NotifyOfCustomIntroFinished()
        {
            base.method_8("NotifyOfCustomIntroFinished", Array.Empty<object>());
        }

        public void NotifyOfDebugCommand(int command)
        {
            object[] objArray1 = new object[] { command };
            base.method_8("NotifyOfDebugCommand", objArray1);
        }

        public void NotifyOfDefeatCoinAnimation()
        {
            base.method_8("NotifyOfDefeatCoinAnimation", Array.Empty<object>());
        }

        public bool NotifyOfEndTurnButtonPushed()
        {
            return base.method_11<bool>("NotifyOfEndTurnButtonPushed", Array.Empty<object>());
        }

        public void NotifyOfEnemyManaCrystalSpawned()
        {
            base.method_8("NotifyOfEnemyManaCrystalSpawned", Array.Empty<object>());
        }

        public void NotifyOfFriendlyPlayedCard(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("NotifyOfFriendlyPlayedCard", objArray1);
        }

        public void NotifyOfGameOver(TAG_PLAYSTATE gameResult)
        {
            object[] objArray1 = new object[] { gameResult };
            base.method_8("NotifyOfGameOver", objArray1);
        }

        public void NotifyOfGamePackOpened()
        {
            base.method_8("NotifyOfGamePackOpened", Array.Empty<object>());
        }

        public void NotifyOfHelpPanelDisplay(int numPanels)
        {
            object[] objArray1 = new object[] { numPanels };
            base.method_8("NotifyOfHelpPanelDisplay", objArray1);
        }

        public void NotifyOfHeroesFinishedAnimatingInMulligan()
        {
            base.method_8("NotifyOfHeroesFinishedAnimatingInMulligan", Array.Empty<object>());
        }

        public void NotifyOfHistoryTokenMousedOut()
        {
            base.method_8("NotifyOfHistoryTokenMousedOut", Array.Empty<object>());
        }

        public void NotifyOfHistoryTokenMousedOver(GameObject mousedOverTile)
        {
            object[] objArray1 = new object[] { mousedOverTile };
            base.method_8("NotifyOfHistoryTokenMousedOver", objArray1);
        }

        public List<string> NotifyOfKeywordHelpPanelDisplay(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            Class245 class2 = base.method_14<Class245>("NotifyOfKeywordHelpPanelDisplay", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void NotifyOfManaCrystalSpawned()
        {
            base.method_8("NotifyOfManaCrystalSpawned", Array.Empty<object>());
        }

        public void NotifyOfMulliganEnded()
        {
            base.method_8("NotifyOfMulliganEnded", Array.Empty<object>());
        }

        public void NotifyOfMulliganInitialized()
        {
            base.method_8("NotifyOfMulliganInitialized", Array.Empty<object>());
        }

        public void NotifyOfOpponentPlayedCard(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("NotifyOfOpponentPlayedCard", objArray1);
        }

        public void NotifyOfOpponentWillPlayCard(string cardId)
        {
            object[] objArray1 = new object[] { cardId };
            base.method_8("NotifyOfOpponentWillPlayCard", objArray1);
        }

        public bool NotifyOfPlayError(PlayErrors.ErrorType error, Triton.Game.Mapping.Entity errorSource)
        {
            object[] objArray1 = new object[] { error, errorSource };
            return base.method_11<bool>("NotifyOfPlayError", objArray1);
        }

        public void NotifyOfStartOfTurnEventsFinished()
        {
            base.method_8("NotifyOfStartOfTurnEventsFinished", Array.Empty<object>());
        }

        public void NotifyOfTargetModeCancelled()
        {
            base.method_8("NotifyOfTargetModeCancelled", Array.Empty<object>());
        }

        public bool NotifyOfTooltipDisplay(TooltipZone tooltip)
        {
            object[] objArray1 = new object[] { tooltip };
            return base.method_11<bool>("NotifyOfTooltipDisplay", objArray1);
        }

        public void NotifyOfTooltipZoneMouseOver(TooltipZone tooltip)
        {
            object[] objArray1 = new object[] { tooltip };
            base.method_8("NotifyOfTooltipZoneMouseOver", objArray1);
        }

        public void OnEmotePlayed(Card card, EmoteType emoteType, CardSoundSpell emoteSpell)
        {
            object[] objArray1 = new object[] { card, emoteType, emoteSpell };
            base.method_8("OnEmotePlayed", objArray1);
        }

        public void OnEndGameScreenLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnEndGameScreenLoaded", objArray1);
        }

        public void OnPlayThinkEmote()
        {
            base.method_8("OnPlayThinkEmote", Array.Empty<object>());
        }

        public void OnRealTimeTagChanged(Network.HistTagChange change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnRealTimeTagChanged", objArray1);
        }

        public void OnSoundLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnSoundLoaded", objArray1);
        }

        public void OnTagsChanged(TagDeltaSet changeSet)
        {
            object[] objArray1 = new object[] { changeSet };
            base.method_8("OnTagsChanged", objArray1);
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public void PreloadSound(string soundName)
        {
            object[] objArray1 = new object[] { soundName };
            base.method_8("PreloadSound", objArray1);
        }

        public void RemovePreloadedSound(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("RemovePreloadedSound", objArray1);
        }

        public void SendCustomEvent(int eventID)
        {
            object[] objArray1 = new object[] { eventID };
            base.method_8("SendCustomEvent", objArray1);
        }

        public bool ShouldAllowCardGrab(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("ShouldAllowCardGrab", objArray1);
        }

        public bool ShouldDelayCardSoundSpells()
        {
            return base.method_11<bool>("ShouldDelayCardSoundSpells", Array.Empty<object>());
        }

        public bool ShouldDoAlternateMulliganIntro()
        {
            return base.method_11<bool>("ShouldDoAlternateMulliganIntro", Array.Empty<object>());
        }

        public bool ShouldDoOpeningTaunts()
        {
            return base.method_11<bool>("ShouldDoOpeningTaunts", Array.Empty<object>());
        }

        public bool ShouldHandleCoin()
        {
            return base.method_11<bool>("ShouldHandleCoin", Array.Empty<object>());
        }

        public bool ShouldShowBigCard()
        {
            return base.method_11<bool>("ShouldShowBigCard", Array.Empty<object>());
        }

        public bool ShouldShowCrazyKeywordTooltip()
        {
            return base.method_11<bool>("ShouldShowCrazyKeywordTooltip", Array.Empty<object>());
        }

        public bool ShouldShowHeroTooltips()
        {
            return base.method_11<bool>("ShouldShowHeroTooltips", Array.Empty<object>());
        }

        public bool ShouldUseSecretClassNames()
        {
            return base.method_11<bool>("ShouldUseSecretClassNames", Array.Empty<object>());
        }

        public void ShowEndScreen(TAG_PLAYSTATE gameResult, Spell enemyBlowUpSpell, Spell friendlyBlowUpSpell)
        {
            object[] objArray1 = new object[] { gameResult, enemyBlowUpSpell, friendlyBlowUpSpell };
            base.method_8("ShowEndScreen", objArray1);
        }

        public void StartGameplaySoundtracks()
        {
            base.method_8("StartGameplaySoundtracks", Array.Empty<object>());
        }

        public string UpdateCardText(Card card, Actor bigCardActor, string text)
        {
            object[] objArray1 = new object[] { card, bigCardActor, text };
            return base.method_13("UpdateCardText", objArray1);
        }

        public int m_preloadsNeeded
        {
            get
            {
                return base.method_2<int>("m_preloadsNeeded");
            }
        }

        [Attribute38("GameEntity.EndGameScreenContext")]
        public class EndGameScreenContext : MonoClass
        {
            public EndGameScreenContext(IntPtr address) : this(address, "EndGameScreenContext")
            {
            }

            public EndGameScreenContext(IntPtr address, string className) : base(address, className)
            {
            }

            public bool AreBlowUpSpellsFinished()
            {
                return base.method_11<bool>("AreBlowUpSpellsFinished", Array.Empty<object>());
            }

            public void OnBlowUpSpellFinished(Spell spell, object userData)
            {
                object[] objArray1 = new object[] { spell, userData };
                base.method_8("OnBlowUpSpellFinished", objArray1);
            }

            public void ShowScreen(EndGameScreen screen)
            {
                object[] objArray1 = new object[] { screen };
                base.method_8("ShowScreen", objArray1);
            }

            public Spell m_enemyBlowUpSpell
            {
                get
                {
                    return base.method_3<Spell>("m_enemyBlowUpSpell");
                }
            }

            public Spell m_friendlyBlowUpSpell
            {
                get
                {
                    return base.method_3<Spell>("m_friendlyBlowUpSpell");
                }
            }
        }
    }
}

