namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Tutorial_05")]
    public class Tutorial_05 : TutorialEntity
    {
        public Tutorial_05(IntPtr address) : this(address, "Tutorial_05")
        {
        }

        public Tutorial_05(IntPtr address, string className) : base(address, className)
        {
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

        public bool NotifyOfEndTurnButtonPushed()
        {
            return base.method_11<bool>("NotifyOfEndTurnButtonPushed", Array.Empty<object>());
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

        public bool NotifyOfTooltipDisplay(TooltipZone specificZone)
        {
            object[] objArray1 = new object[] { specificZone };
            return base.method_11<bool>("NotifyOfTooltipDisplay", objArray1);
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public void ShowEndTurnBouncingArrow()
        {
            base.method_8("ShowEndTurnBouncingArrow", Array.Empty<object>());
        }

        public bool heroPowerHasNotBeenUsed
        {
            get
            {
                return base.method_2<bool>("heroPowerHasNotBeenUsed");
            }
        }

        public int numTimesRemindedAboutGoal
        {
            get
            {
                return base.method_2<int>("numTimesRemindedAboutGoal");
            }
        }

        public bool victory
        {
            get
            {
                return base.method_2<bool>("victory");
            }
        }

        public int weaponsPlayed
        {
            get
            {
                return base.method_2<int>("weaponsPlayed");
            }
        }
    }
}

