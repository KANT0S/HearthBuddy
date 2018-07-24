namespace Triton.Common.LogUtilities
{
    using log4net;
    using log4net.Appender;
    using log4net.Core;
    using log4net.Filter;
    using log4net.Layout;
    using log4net.Repository.Hierarchy;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Controls;

    public class CustomLogger
    {
        private Level level_0 = Level.All;
        private Level level_1 = Level.Emergency;
        private readonly string string_0;
        [CompilerGenerated]
        private string string_1;
        private WpfRtfAppender wpfRtfAppender_0;

        public CustomLogger(string path, string prefix, Level minLevel, Level maxLevel)
        {
            this.string_0 = prefix;
            this.level_0 = minLevel ?? Level.All;
            this.level_1 = maxLevel ?? Level.Emergency;
            Directory.CreateDirectory(path);
            PatternLayout layout = new PatternLayout("%-4utcdate [%thread] %-5level %logger{1} %ndc - %message%newline");
            DateTime now = DateTime.Now;
            object[] args = new object[] { now.Year, now.Month, now.Day, now.Hour, now.Minute, Process.GetCurrentProcess().Id, path, this.string_0 };
            this.FileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), string.Format(@"{6}\{7} {5} {0:0000}-{1:00}-{2:00} {3:00}.{4:00}.txt", args));
            FileAppender newAppender = new FileAppender {
                File = this.FileName,
                Layout = layout,
                LockingModel = new FileAppender.MinimalLock()
            };
            LevelRangeFilter filter = new LevelRangeFilter {
                LevelMin = this.level_0,
                LevelMax = this.level_1,
                AcceptOnMatch = true
            };
            newAppender.AddFilter(filter);
            layout.ActivateOptions();
            newAppender.ActivateOptions();
            AsyncAppender appender2 = new AsyncAppender();
            appender2.AddAppender(newAppender);
            appender2.ActivateOptions();
            log4net.Repository.Hierarchy.Hierarchy hierarchy1 = (log4net.Repository.Hierarchy.Hierarchy) LogManager.CreateRepository(this.string_0);
            hierarchy1.Root.AddAppender(appender2);
            hierarchy1.Configured = true;
        }

        public void AddWpfListener(ScrollViewer scrollViewer, RichTextBox rtbLog)
        {
            PatternLayout layout = new PatternLayout("%message");
            WpfRtfAppender appender1 = new WpfRtfAppender(scrollViewer, rtbLog) {
                Layout = layout
            };
            this.wpfRtfAppender_0 = appender1;
            LevelRangeFilter filter = new LevelRangeFilter {
                LevelMin = this.level_0,
                LevelMax = this.level_1
            };
            this.wpfRtfAppender_0.AddFilter(filter);
            layout.ActivateOptions();
            this.wpfRtfAppender_0.ActivateOptions();
            AsyncAppender newAppender = new AsyncAppender();
            newAppender.AddAppender(this.wpfRtfAppender_0);
            newAppender.ActivateOptions();
            ((log4net.Repository.Hierarchy.Hierarchy) LogManager.GetRepository(this.string_0)).Root.AddAppender(newAppender);
        }

        public void ChangeLogFilterLevel(Level minLevel = null, Level maxLevel = null)
        {
            if (minLevel != null)
            {
                this.level_0 = minLevel;
            }
            if (maxLevel != null)
            {
                this.level_1 = maxLevel;
            }
            if (this.wpfRtfAppender_0 != null)
            {
                this.wpfRtfAppender_0.ClearFilters();
                LevelRangeFilter filter = new LevelRangeFilter {
                    LevelMin = this.level_0,
                    LevelMax = this.level_1,
                    AcceptOnMatch = true
                };
                this.wpfRtfAppender_0.AddFilter(filter);
                this.wpfRtfAppender_0.AddFilter(new DenyAllFilter());
            }
        }

        public void Clear()
        {
            if (this.wpfRtfAppender_0 != null)
            {
                this.wpfRtfAppender_0.Clear();
            }
        }

        public ILog GetLoggerInstanceForType()
        {
            return LogManager.GetLogger(this.string_0, new StackTrace().GetFrames()[1].GetMethod().DeclaringType);
        }

        public string FileName
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            private set
            {
                this.string_1 = value;
            }
        }
    }
}

