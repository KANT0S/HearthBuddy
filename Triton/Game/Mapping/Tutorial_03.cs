namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Tutorial_03")]
    public class Tutorial_03 : TutorialEntity
    {
        public Tutorial_03(IntPtr address) : this(address, "Tutorial_03")
        {
        }

        public Tutorial_03(IntPtr address, string className) : base(address, className)
        {
        }

        public void DialogLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("DialogLoadedCallback", objArray1);
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

        public bool IsMouseOverDelayOverriden()
        {
            return base.method_11<bool>("IsMouseOverDelayOverriden", Array.Empty<object>());
        }

        public bool NotifyOfBattlefieldCardClicked(Triton.Game.Mapping.Entity clickedEntity, bool wasInTargetMode)
        {
            object[] objArray1 = new object[] { clickedEntity, wasInTargetMode };
            return base.method_11<bool>("NotifyOfBattlefieldCardClicked", objArray1);
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

        public void NotifyOfDefeatCoinAnimation()
        {
            base.method_8("NotifyOfDefeatCoinAnimation", Array.Empty<object>());
        }

        public void NotifyOfGameOver(TAG_PLAYSTATE gameResult)
        {
            object[] objArray1 = new object[] { gameResult };
            base.method_8("NotifyOfGameOver", objArray1);
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public bool ShouldShowCrazyKeywordTooltip()
        {
            return base.method_11<bool>("ShouldShowCrazyKeywordTooltip", Array.Empty<object>());
        }

        public void ShowDontFireballYourselfPopup(Vector3 origin)
        {
            object[] objArray1 = new object[] { origin };
            base.method_8("ShowDontFireballYourselfPopup", objArray1);
        }

        public void ShowDontPolymorphYourselfPopup(Vector3 origin)
        {
            object[] objArray1 = new object[] { origin };
            base.method_8("ShowDontPolymorphYourselfPopup", objArray1);
        }

        public bool defenselessVoPlayed
        {
            get
            {
                return base.method_2<bool>("defenselessVoPlayed");
            }
        }

        public bool enemyPlayedBigBrother
        {
            get
            {
                return base.method_2<bool>("enemyPlayedBigBrother");
            }
        }

        public bool monkeyLinePlayedOnce
        {
            get
            {
                return base.method_2<bool>("monkeyLinePlayedOnce");
            }
        }

        public bool needATaunterVOPlayed
        {
            get
            {
                return base.method_2<bool>("needATaunterVOPlayed");
            }
        }

        public int numTauntGorillasPlayed
        {
            get
            {
                return base.method_2<int>("numTauntGorillasPlayed");
            }
        }

        public bool overrideMouseOver
        {
            get
            {
                return base.method_2<bool>("overrideMouseOver");
            }
        }

        public bool seenTheBrother
        {
            get
            {
                return base.method_2<bool>("seenTheBrother");
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

        public bool warnedAgainstAttackingGorilla
        {
            get
            {
                return base.method_2<bool>("warnedAgainstAttackingGorilla");
            }
        }
    }
}

