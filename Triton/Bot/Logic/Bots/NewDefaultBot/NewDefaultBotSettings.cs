namespace Triton.Bot.Logic.Bots.NewDefaultBot
{
    using log4net;
    using System;
    using Triton.Bot.Settings;
    using Triton.Common;

    public class NewDefaultBotSettings : JsonSettings
    {
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private static NewDefaultBotSettings newDefaultBotSettings_0;

        internal NewDefaultBotSettings() : base(JsonSettings.GetSettingsFilePath(textArray1))
        {
            string[] textArray1 = new string[] { Configuration.Instance.Name, string.Format("{0}.json", "NewDefaultBot") };
        }

        public static NewDefaultBotSettings Instance
        {
            get
            {
                return (newDefaultBotSettings_0 ?? (newDefaultBotSettings_0 = new NewDefaultBotSettings()));
            }
        }
    }
}

