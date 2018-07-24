namespace Triton.Common.Localization
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    [CompilerGenerated, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode]
    public class Globalization
    {
        private static CultureInfo cultureInfo_0;
        private static System.Resources.ResourceManager resourceManager_0;

        internal Globalization()
        {
        }

        public static string ArenaCheckboxText
        {
            get
            {
                return ResourceManager.GetString("ArenaCheckboxText", cultureInfo_0);
            }
        }

        public static string BotStartingMessage
        {
            get
            {
                return ResourceManager.GetString("BotStartingMessage", cultureInfo_0);
            }
        }

        public static string BotStoppedMessage
        {
            get
            {
                return ResourceManager.GetString("BotStoppedMessage", cultureInfo_0);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture
        {
            get
            {
                return cultureInfo_0;
            }
            set
            {
                cultureInfo_0 = value;
            }
        }

        public static string CustomDeck
        {
            get
            {
                return ResourceManager.GetString("CustomDeck", cultureInfo_0);
            }
        }

        public static string ExpertAICheckboxText
        {
            get
            {
                return ResourceManager.GetString("ExpertAICheckboxText", cultureInfo_0);
            }
        }

        public static string Hearthbuddy_is_up_to_date_
        {
            get
            {
                return ResourceManager.GetString("Hearthbuddy_is_up_to_date_", cultureInfo_0);
            }
        }

        public static string LoadingWithElipsis
        {
            get
            {
                return ResourceManager.GetString("LoadingWithElipsis", cultureInfo_0);
            }
        }

        public static string PracticeCheckboxText
        {
            get
            {
                return ResourceManager.GetString("PracticeCheckboxText", cultureInfo_0);
            }
        }

        public static string RandomDeckCheckBoxText
        {
            get
            {
                return ResourceManager.GetString("RandomDeckCheckBoxText", cultureInfo_0);
            }
        }

        public static string RankedPvpCheckboxText
        {
            get
            {
                return ResourceManager.GetString("RankedPvpCheckboxText", cultureInfo_0);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (resourceManager_0 == null)
                {
                    resourceManager_0 = new System.Resources.ResourceManager("Triton.Common.Localization.Globalization", typeof(Globalization).Assembly);
                }
                return resourceManager_0;
            }
        }

        public static string RunsForStatusLabelText
        {
            get
            {
                return ResourceManager.GetString("RunsForStatusLabelText", cultureInfo_0);
            }
        }

        public static string RushCheckboxText
        {
            get
            {
                return ResourceManager.GetString("RushCheckboxText", cultureInfo_0);
            }
        }

        public static string SettingsGroupboxText
        {
            get
            {
                return ResourceManager.GetString("SettingsGroupboxText", cultureInfo_0);
            }
        }

        public static string Start
        {
            get
            {
                return ResourceManager.GetString("Start", cultureInfo_0);
            }
        }

        public static string StartButtonText
        {
            get
            {
                return ResourceManager.GetString("StartButtonText", cultureInfo_0);
            }
        }

        public static string Stop
        {
            get
            {
                return ResourceManager.GetString("Stop", cultureInfo_0);
            }
        }

        public static string StopButtonText
        {
            get
            {
                return ResourceManager.GetString("StopButtonText", cultureInfo_0);
            }
        }

        public static string UpdateDownloadUpdaterFailed
        {
            get
            {
                return ResourceManager.GetString("UpdateDownloadUpdaterFailed", cultureInfo_0);
            }
        }

        public static string UpdateVersionPulledBack
        {
            get
            {
                return ResourceManager.GetString("UpdateVersionPulledBack", cultureInfo_0);
            }
        }

        public static string UpdateVersionPulledBackMessageCaption
        {
            get
            {
                return ResourceManager.GetString("UpdateVersionPulledBackMessageCaption", cultureInfo_0);
            }
        }

        public static string WinsLossesTotalStatusLabelText
        {
            get
            {
                return ResourceManager.GetString("WinsLossesTotalStatusLabelText", cultureInfo_0);
            }
        }
    }
}

