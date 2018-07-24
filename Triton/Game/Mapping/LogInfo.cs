namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("LogInfo")]
    public class LogInfo : MonoClass
    {
        public LogInfo(IntPtr address) : this(address, "LogInfo")
        {
        }

        public LogInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public bool m_consolePrinting
        {
            get
            {
                return base.method_2<bool>("m_consolePrinting");
            }
        }

        public Triton.Game.Mapping.LogLevel m_defaultLevel
        {
            get
            {
                return base.method_2<Triton.Game.Mapping.LogLevel>("m_defaultLevel");
            }
        }

        public bool m_filePrinting
        {
            get
            {
                return base.method_2<bool>("m_filePrinting");
            }
        }

        public Triton.Game.Mapping.LogLevel m_minLevel
        {
            get
            {
                return base.method_2<Triton.Game.Mapping.LogLevel>("m_minLevel");
            }
        }

        public string m_name
        {
            get
            {
                return base.method_4("m_name");
            }
        }

        public bool m_screenPrinting
        {
            get
            {
                return base.method_2<bool>("m_screenPrinting");
            }
        }

        public bool m_verbose
        {
            get
            {
                return base.method_2<bool>("m_verbose");
            }
        }
    }
}

