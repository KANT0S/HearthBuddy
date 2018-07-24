namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("LogArchive")]
    public class LogArchive : MonoClass
    {
        public LogArchive(IntPtr address) : this(address, "LogArchive")
        {
        }

        public LogArchive(IntPtr address, string className) : base(address, className)
        {
        }

        public void CleanOldLogs(string logFolderPath)
        {
            object[] objArray1 = new object[] { logFolderPath };
            base.method_8("CleanOldLogs", objArray1);
        }

        public static LogArchive Get()
        {
            return MonoClass.smethod_15<LogArchive>(TritonHs.MainAssemblyPath, "", "LogArchive", "Get", Array.Empty<object>());
        }

        public static void Init()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "LogArchive", "Init");
        }

        public void MakeLogPath(string logFolderPath)
        {
            object[] objArray1 = new object[] { logFolderPath };
            base.method_8("MakeLogPath", objArray1);
        }

        public string m_logPath
        {
            get
            {
                return base.method_4("m_logPath");
            }
        }

        public int m_maxFileSizeKB
        {
            get
            {
                return base.method_2<int>("m_maxFileSizeKB");
            }
        }

        public ulong m_numLinesWritten
        {
            get
            {
                return base.method_2<ulong>("m_numLinesWritten");
            }
        }

        public bool m_stopLogging
        {
            get
            {
                return base.method_2<bool>("m_stopLogging");
            }
        }
    }
}

