namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Tutorial_02")]
    public class Tutorial_02 : TutorialEntity
    {
        public Tutorial_02(IntPtr address) : this(address, "Tutorial_02")
        {
        }

        public Tutorial_02(IntPtr address, string className) : base(address, className)
        {
        }

        public void FadeInManaSpotlight()
        {
            base.method_8("FadeInManaSpotlight", Array.Empty<object>());
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

        public string GetTurnStartReminderText()
        {
            return base.method_13("GetTurnStartReminderText", Array.Empty<object>());
        }

        public void ManaLabelLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("ManaLabelLoadedCallback", objArray1);
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

        public void NotifyOfEnemyManaCrystalSpawned()
        {
            base.method_8("NotifyOfEnemyManaCrystalSpawned", Array.Empty<object>());
        }

        public void NotifyOfGameOver(TAG_PLAYSTATE gameResult)
        {
            object[] objArray1 = new object[] { gameResult };
            base.method_8("NotifyOfGameOver", objArray1);
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

        public void NotifyOfManaError()
        {
            base.method_8("NotifyOfManaError", Array.Empty<object>());
        }

        public void NotifyOfTooltipZoneMouseOver(TooltipZone tooltip)
        {
            object[] objArray1 = new object[] { tooltip };
            base.method_8("NotifyOfTooltipZoneMouseOver", objArray1);
        }

        public void Plus1ActorLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("Plus1ActorLoadedCallback", objArray1);
        }

        public void Plus1ActorLoadedCallbackEnemy(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("Plus1ActorLoadedCallbackEnemy", objArray1);
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public void ShowEndTurnBouncingArrow()
        {
            base.method_8("ShowEndTurnBouncingArrow", Array.Empty<object>());
        }

        public GameObject costLabel
        {
            get
            {
                return base.method_3<GameObject>("costLabel");
            }
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

        public Triton.Game.Mapping.Notification manaNotifier
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("manaNotifier");
            }
        }

        public Triton.Game.Mapping.Notification manaNotifier2
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("manaNotifier2");
            }
        }

        public int numManaThisTurn
        {
            get
            {
                return base.method_2<int>("numManaThisTurn");
            }
        }
    }
}

