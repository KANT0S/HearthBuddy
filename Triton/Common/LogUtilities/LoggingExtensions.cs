namespace Triton.Common.LogUtilities
{
    using log4net;
    using log4net.Core;
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public static class LoggingExtensions
    {
        public static void Alert(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Alert, message, exception);
        }

        [Conditional("DEBUG")]
        public static void AlertDebugOnly(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Alert, message, exception);
        }

        public static void AlertFormat(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Alert, string.Format(message, args), null);
        }

        [Conditional("DEBUG")]
        public static void AlertFormatDebugOnly(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Alert, string.Format(message, args), null);
        }

        public static void Critical(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Critical, message, exception);
        }

        [Conditional("DEBUG")]
        public static void CriticalDebugOnly(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Critical, message, exception);
        }

        public static void CriticalFormat(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Critical, string.Format(message, args), null);
        }

        [Conditional("DEBUG")]
        public static void CriticalFormatDebugOnly(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Critical, string.Format(message, args), null);
        }

        public static void Emergency(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Emergency, message, exception);
        }

        [Conditional("DEBUG")]
        public static void EmergencyDebugOnly(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Emergency, message, exception);
        }

        public static void EmergencyFormat(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Emergency, string.Format(message, args), null);
        }

        [Conditional("DEBUG")]
        public static void EmergencyFormatDebugOnly(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Emergency, string.Format(message, args), null);
        }

        public static void Notice(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Notice, message, exception);
        }

        [Conditional("DEBUG")]
        public static void NoticeDebugOnly(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Notice, message, exception);
        }

        public static void NoticeFormat(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Notice, string.Format(message, args), null);
        }

        [Conditional("DEBUG")]
        public static void NoticeFormatDebugOnly(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Notice, string.Format(message, args), null);
        }

        public static void Severe(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Severe, message, exception);
        }

        [Conditional("DEBUG")]
        public static void SevereDebugOnly(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Severe, message, exception);
        }

        public static void SevereFormat(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Severe, string.Format(message, args), null);
        }

        [Conditional("DEBUG")]
        public static void SevereFormatDebugOnly(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Severe, string.Format(message, args), null);
        }

        public static void Trace(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Trace, message, exception);
        }

        [Conditional("DEBUG")]
        public static void TraceDebugOnly(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Trace, message, exception);
        }

        public static void TraceFormat(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Trace, string.Format(message, args), null);
        }

        [Conditional("DEBUG")]
        public static void TraceFormatDebugOnly(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Trace, string.Format(message, args), null);
        }

        public static void Verbose(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Verbose, message, exception);
        }

        [Conditional("DEBUG")]
        public static void VerboseDebugOnly(this ILog log, string message, Exception exception = null)
        {
            log.Logger.Log(null, Level.Verbose, message, exception);
        }

        public static void VerboseFormat(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Verbose, string.Format(message, args), null);
        }

        [Conditional("DEBUG")]
        public static void VerboseFormatDebugOnly(this ILog log, string message, params object[] args)
        {
            log.Logger.Log(null, Level.Verbose, string.Format(message, args), null);
        }
    }
}

