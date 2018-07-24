namespace Triton.Common.LogUtilities
{
    using log4net;
    using log4net.Core;
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Windows.Controls;

    public static class Logger
    {
        private static readonly CustomLogger customLogger_0 = new CustomLogger("Logs", "Hearthbuddy", Level.All, Level.Emergency);
        private static Stopwatch stopwatch_0 = new Stopwatch();
        private const string string_0 = "Hearthbuddy";

        public static void AddWpfListener(ScrollViewer scrollViewer, RichTextBox rtbLog)
        {
            customLogger_0.AddWpfListener(scrollViewer, rtbLog);
        }

        public static void ChangeLogFilterLevel(Level minLevel = null, Level maxLevel = null)
        {
            customLogger_0.ChangeLogFilterLevel(minLevel, maxLevel);
        }

        public static void Clear()
        {
            customLogger_0.Clear();
        }

        public static ILog GetLoggerInstanceForType()
        {
            return customLogger_0.GetLoggerInstanceForType();
        }

        public static void OpenLogFile()
        {
            if (!stopwatch_0.IsRunning)
            {
                stopwatch_0.Start();
            }
            else
            {
                if (stopwatch_0.ElapsedMilliseconds < 0x7530L)
                {
                    return;
                }
                stopwatch_0.Restart();
            }
            try
            {
                Process.Start(FileName);
            }
            catch
            {
            }
        }

        public static string FileName
        {
            get
            {
                return customLogger_0.FileName;
            }
        }
    }
}

