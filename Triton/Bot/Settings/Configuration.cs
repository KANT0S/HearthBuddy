namespace Triton.Bot.Settings
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Triton.Common;

    public class Configuration
    {
        private static Configuration configuration_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private readonly List<JsonSettings> list_0 = new List<JsonSettings>();
        [CompilerGenerated]
        private string string_0;

        public void AddSettings(JsonSettings settings)
        {
            if (!this.list_0.Contains(settings))
            {
                this.list_0.Add(settings);
            }
        }

        public void RemoveSettings(JsonSettings settings)
        {
            this.list_0.Remove(settings);
        }

        public void SaveAll()
        {
            try
            {
                GlobalSettings.Instance.Save();
            }
            catch (Exception exception)
            {
                ilog_0.Error("[SaveAll] An exception occurred when saving GlobalSettings:", exception);
            }
            foreach (JsonSettings settings in this.list_0)
            {
                try
                {
                    settings.Save();
                }
                catch (Exception exception2)
                {
                    ilog_0.Error("[SaveAll] An exception occurred when saving:", exception2);
                }
            }
        }

        public static Configuration Instance
        {
            get
            {
                return (configuration_0 ?? (configuration_0 = new Configuration()));
            }
        }

        public string Name
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            set
            {
                this.string_0 = value;
            }
        }

        public List<JsonSettings> Settings
        {
            get
            {
                return this.list_0;
            }
        }
    }
}

