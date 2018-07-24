namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Tutorial_01")]
    public class Tutorial_01 : TutorialEntity
    {
        public Tutorial_01(IntPtr address) : this(address, "Tutorial_01")
        {
        }

        public Tutorial_01(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AreTooltipsDisabled()
        {
            return base.method_11<bool>("AreTooltipsDisabled", Array.Empty<object>());
        }

        public void AttackLabelLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("AttackLabelLoadedCallback", objArray1);
        }

        public bool DoAlternateMulliganIntro()
        {
            return base.method_11<bool>("DoAlternateMulliganIntro", Array.Empty<object>());
        }

        public void EnsureCardGemsAreOnTheCorrectLayer()
        {
            base.method_8("EnsureCardGemsAreOnTheCorrectLayer", Array.Empty<object>());
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

        public void HealthLabelLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("HealthLabelLoadedCallback", objArray1);
        }

        public void HideFadeArrow()
        {
            base.method_8("HideFadeArrow", Array.Empty<object>());
        }

        public bool IsMouseOverDelayOverriden()
        {
            return base.method_11<bool>("IsMouseOverDelayOverriden", Array.Empty<object>());
        }

        public void ManaLabelLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("ManaLabelLoadedCallback", objArray1);
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

        public void NotifyOfCustomIntroFinished()
        {
            base.method_8("NotifyOfCustomIntroFinished", Array.Empty<object>());
        }

        public void NotifyOfDefeatCoinAnimation()
        {
            base.method_8("NotifyOfDefeatCoinAnimation", Array.Empty<object>());
        }

        public bool NotifyOfEndTurnButtonPushed()
        {
            return base.method_11<bool>("NotifyOfEndTurnButtonPushed", Array.Empty<object>());
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

        public bool NotifyOfPlayError(PlayErrors.ErrorType error, Triton.Game.Mapping.Entity errorSource)
        {
            object[] objArray1 = new object[] { error, errorSource };
            return base.method_11<bool>("NotifyOfPlayError", objArray1);
        }

        public void NotifyOfTargetModeCancelled()
        {
            base.method_8("NotifyOfTargetModeCancelled", Array.Empty<object>());
        }

        public void NukeNumberLabels()
        {
            base.method_8("NukeNumberLabels", Array.Empty<object>());
        }

        public void OnPhoneHandHidden(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnPhoneHandHidden", objArray1);
        }

        public void OnPhoneHandShown(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnPhoneHandShown", objArray1);
        }

        public void PackLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("PackLoadedCallback", objArray1);
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public bool ShouldDoAlternateMulliganIntro()
        {
            return base.method_11<bool>("ShouldDoAlternateMulliganIntro", Array.Empty<object>());
        }

        public bool ShouldShowArrowOnCardInHand(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("ShouldShowArrowOnCardInHand", objArray1);
        }

        public bool ShouldShowBigCard()
        {
            return base.method_11<bool>("ShouldShowBigCard", Array.Empty<object>());
        }

        public bool ShouldShowHeroTooltips()
        {
            return base.method_11<bool>("ShouldShowHeroTooltips", Array.Empty<object>());
        }

        public void ShowAttackTooltip(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("ShowAttackTooltip", objArray1);
        }

        public void ShowAttackWithYourMinionPopup()
        {
            base.method_8("ShowAttackWithYourMinionPopup", Array.Empty<object>());
        }

        public void ShowDontFireballYourselfPopup(Vector3 origin)
        {
            object[] objArray1 = new object[] { origin };
            base.method_8("ShowDontFireballYourselfPopup", objArray1);
        }

        public void ShowEndTurnBouncingArrow()
        {
            base.method_8("ShowEndTurnBouncingArrow", Array.Empty<object>());
        }

        public void ShowFadeArrow(Card card, Card target)
        {
            object[] objArray1 = new object[] { card, target };
            base.method_8("ShowFadeArrow", objArray1);
        }

        public void ShowHandBouncingArrow()
        {
            base.method_8("ShowHandBouncingArrow", Array.Empty<object>());
        }

        public void ShowHandFadeArrow()
        {
            base.method_8("ShowHandFadeArrow", Array.Empty<object>());
        }

        public void ShowHealthTooltip(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("ShowHealthTooltip", objArray1);
        }

        public bool announcerIsFinishedYapping
        {
            get
            {
                return base.method_2<bool>("announcerIsFinishedYapping");
            }
        }

        public KeywordHelpPanel attackHelpPanel
        {
            get
            {
                return base.method_3<KeywordHelpPanel>("attackHelpPanel");
            }
        }

        public GameObject attackLabel
        {
            get
            {
                return base.method_3<GameObject>("attackLabel");
            }
        }

        public Triton.Game.Mapping.Notification attackWithYourMinion
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("attackWithYourMinion");
            }
        }

        public GameObject costLabel
        {
            get
            {
                return base.method_3<GameObject>("costLabel");
            }
        }

        public Triton.Game.Mapping.Notification crushThisGnoll
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("crushThisGnoll");
            }
        }

        public Triton.Game.Mapping.Notification endTurnNotifier
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("endTurnNotifier");
            }
        }

        public bool firstAttackFinished
        {
            get
            {
                return base.method_2<bool>("firstAttackFinished");
            }
        }

        public Card firstMurlocCard
        {
            get
            {
                return base.method_3<Card>("firstMurlocCard");
            }
        }

        public Card firstRaptorCard
        {
            get
            {
                return base.method_3<Card>("firstRaptorCard");
            }
        }

        public Triton.Game.Mapping.Notification freeCardsPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("freeCardsPopup");
            }
        }

        public Triton.Game.Mapping.Notification handBounceArrow
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("handBounceArrow");
            }
        }

        public Triton.Game.Mapping.Notification handFadeArrow
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("handFadeArrow");
            }
        }

        public KeywordHelpPanel healthHelpPanel
        {
            get
            {
                return base.method_3<KeywordHelpPanel>("healthHelpPanel");
            }
        }

        public GameObject healthLabel
        {
            get
            {
                return base.method_3<GameObject>("healthLabel");
            }
        }

        public bool m_isShowingAttackHelpPanel
        {
            get
            {
                return base.method_2<bool>("m_isShowingAttackHelpPanel");
            }
        }

        public bool m_jainaSpeaking
        {
            get
            {
                return base.method_2<bool>("m_jainaSpeaking");
            }
        }

        public Card mousedOverCard
        {
            get
            {
                return base.method_3<Card>("mousedOverCard");
            }
        }

        public Triton.Game.Mapping.Notification noFireballPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("noFireballPopup");
            }
        }

        public int numTimesTextSwapStarted
        {
            get
            {
                return base.method_2<int>("numTimesTextSwapStarted");
            }
        }

        public bool packOpened
        {
            get
            {
                return base.method_2<bool>("packOpened");
            }
        }

        public GameObject startingPack
        {
            get
            {
                return base.method_3<GameObject>("startingPack");
            }
        }

        public string textToShowForAttackTip
        {
            get
            {
                return base.method_4("textToShowForAttackTip");
            }
        }

        public bool tooltipsDisabled
        {
            get
            {
                return base.method_2<bool>("tooltipsDisabled");
            }
        }
    }
}

