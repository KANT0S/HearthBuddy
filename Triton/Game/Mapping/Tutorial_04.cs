namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Tutorial_04")]
    public class Tutorial_04 : TutorialEntity
    {
        public Tutorial_04(IntPtr address) : this(address, "Tutorial_04")
        {
        }

        public Tutorial_04(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AllowEndTurn()
        {
            return base.method_11<bool>("AllowEndTurn", Array.Empty<object>());
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

        public bool IsKeywordHelpDelayOverridden()
        {
            return base.method_11<bool>("IsKeywordHelpDelayOverridden", Array.Empty<object>());
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

        public void NotifyOfCoinFlipResult()
        {
            base.method_8("NotifyOfCoinFlipResult", Array.Empty<object>());
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

        public void NotifyOfTargetModeCancelled()
        {
            base.method_8("NotifyOfTargetModeCancelled", Array.Empty<object>());
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public bool ShouldAllowCardGrab(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("ShouldAllowCardGrab", objArray1);
        }

        public bool ShouldShowArrowOnCardInHand(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("ShouldShowArrowOnCardInHand", objArray1);
        }

        public void ShowEndTurnBouncingArrow()
        {
            base.method_8("ShowEndTurnBouncingArrow", Array.Empty<object>());
        }

        public void ShowHandBouncingArrow()
        {
            base.method_8("ShowHandBouncingArrow", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Notification endTurnNotifier
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("endTurnNotifier");
            }
        }

        public Triton.Game.Mapping.Notification handBounceArrow
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("handBounceArrow");
            }
        }

        public Triton.Game.Mapping.Notification heroPowerHelp
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("heroPowerHelp");
            }
        }

        public bool m_hemetSpeaking
        {
            get
            {
                return base.method_2<bool>("m_hemetSpeaking");
            }
        }

        public GameObject m_heroPowerCostLabel
        {
            get
            {
                return base.method_3<GameObject>("m_heroPowerCostLabel");
            }
        }

        public bool m_isBogSheeped
        {
            get
            {
                return base.method_2<bool>("m_isBogSheeped");
            }
        }

        public bool m_isPolymorphGrabbed
        {
            get
            {
                return base.method_2<bool>("m_isPolymorphGrabbed");
            }
        }

        public bool m_shouldSignalPolymorph
        {
            get
            {
                return base.method_2<bool>("m_shouldSignalPolymorph");
            }
        }

        public Triton.Game.Mapping.Notification noSheepPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("noSheepPopup");
            }
        }

        public int numBeastsPlayed
        {
            get
            {
                return base.method_2<int>("numBeastsPlayed");
            }
        }

        public int numComplaintsMade
        {
            get
            {
                return base.method_2<int>("numComplaintsMade");
            }
        }

        public Triton.Game.Mapping.Notification sheepTheBog
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("sheepTheBog");
            }
        }

        public Triton.Game.Mapping.Notification thatsABadPlayPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("thatsABadPlayPopup");
            }
        }

        public bool victory
        {
            get
            {
                return base.method_2<bool>("victory");
            }
        }
    }
}

