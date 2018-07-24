namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TutorialEntity")]
    public class TutorialEntity : MissionEntity
    {
        public TutorialEntity(IntPtr address) : this(address, "TutorialEntity")
        {
        }

        public TutorialEntity(IntPtr address, string className) : base(address, className)
        {
        }

        public bool DidLoseTutorial(TutorialProgress val)
        {
            object[] objArray1 = new object[] { val };
            return base.method_11<bool>("DidLoseTutorial", objArray1);
        }

        public void HandleGameStartEvent()
        {
            base.method_8("HandleGameStartEvent", Array.Empty<object>());
        }

        public void HandleMulliganTagChange()
        {
            base.method_8("HandleMulliganTagChange", Array.Empty<object>());
        }

        public void HighlightTaunters()
        {
            base.method_8("HighlightTaunters", Array.Empty<object>());
        }

        public bool NotifyOfBattlefieldCardClicked(Triton.Game.Mapping.Entity clickedEntity, bool wasInTargetMode)
        {
            object[] objArray1 = new object[] { clickedEntity, wasInTargetMode };
            return base.method_11<bool>("NotifyOfBattlefieldCardClicked", objArray1);
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

        public void NotifyOfManaError()
        {
            base.method_8("NotifyOfManaError", Array.Empty<object>());
        }

        public bool NotifyOfPlayError(PlayErrors.ErrorType error, Triton.Game.Mapping.Entity errorSource)
        {
            object[] objArray1 = new object[] { error, errorSource };
            return base.method_11<bool>("NotifyOfPlayError", objArray1);
        }

        public bool NotifyOfTooltipDisplay(TooltipZone tooltip)
        {
            object[] objArray1 = new object[] { tooltip };
            return base.method_11<bool>("NotifyOfTooltipDisplay", objArray1);
        }

        public void ResetTutorialLostProgress()
        {
            base.method_8("ResetTutorialLostProgress", Array.Empty<object>());
        }

        public void SetTutorialLostProgress(TutorialProgress val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetTutorialLostProgress", objArray1);
        }

        public void SetTutorialProgress(TutorialProgress val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetTutorialProgress", objArray1);
        }

        public bool ShouldDoOpeningTaunts()
        {
            return base.method_11<bool>("ShouldDoOpeningTaunts", Array.Empty<object>());
        }

        public bool ShouldHandleCoin()
        {
            return base.method_11<bool>("ShouldHandleCoin", Array.Empty<object>());
        }

        public void ShowDontHurtYourselfPopup(Vector3 origin)
        {
            object[] objArray1 = new object[] { origin };
            base.method_8("ShowDontHurtYourselfPopup", objArray1);
        }

        public TutorialNotification ShowTutorialDialog(string headlineGameString, string bodyTextGameString, string buttonGameString, Vector2 materialOffset, bool swapMaterial)
        {
            object[] objArray1 = new object[] { headlineGameString, bodyTextGameString, buttonGameString, materialOffset, swapMaterial };
            return base.method_14<TutorialNotification>("ShowTutorialDialog", objArray1);
        }

        public void UserPressedStartButton(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("UserPressedStartButton", objArray1);
        }

        public static Vector3 HELP_POPUP_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "TutorialEntity", "HELP_POPUP_SCALE");
            }
        }

        public KeywordHelpPanel historyTooltip
        {
            get
            {
                return base.method_3<KeywordHelpPanel>("historyTooltip");
            }
        }

        public Triton.Game.Mapping.Notification manaReminder
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("manaReminder");
            }
        }

        public Triton.Game.Mapping.Notification thatsABadPlayPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("thatsABadPlayPopup");
            }
        }

        public static Vector3 TUTORIAL_DIALOG_SCALE_PHONE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "TutorialEntity", "TUTORIAL_DIALOG_SCALE_PHONE");
            }
        }
    }
}

