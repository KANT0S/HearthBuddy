namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Logger")]
    public class Logger : MonoClass
    {
        public Logger(IntPtr address) : this(address, "Logger")
        {
        }

        public Logger(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanPrint()
        {
            return base.method_10<bool>("CanPrint", new Class272.Enum20[0], Array.Empty<object>());
        }

        public bool CanPrint(LogTarget target, Triton.Game.Mapping.LogLevel level, bool verbose)
        {
            object[] objArray1 = new object[] { target, level, verbose };
            return base.method_10<bool>("CanPrint", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public void ConsolePrint(Triton.Game.Mapping.LogLevel level, bool verbose, string message)
        {
            object[] objArray1 = new object[] { level, verbose, message };
            base.method_9("ConsolePrint", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public void FilePrint(Triton.Game.Mapping.LogLevel level, bool verbose, string message)
        {
            object[] objArray1 = new object[] { level, verbose, message };
            base.method_9("FilePrint", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public Triton.Game.Mapping.LogLevel GetDefaultLevel()
        {
            return base.method_11<Triton.Game.Mapping.LogLevel>("GetDefaultLevel", Array.Empty<object>());
        }

        public void InitFileWriter()
        {
            base.method_8("InitFileWriter", Array.Empty<object>());
        }

        public bool IsVerbose()
        {
            return base.method_11<bool>("IsVerbose", Array.Empty<object>());
        }

        public void Print(Triton.Game.Mapping.LogLevel level, bool verbose, string message)
        {
            object[] objArray1 = new object[] { level, verbose, message };
            base.method_9("Print", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public void ScreenPrint(Triton.Game.Mapping.LogLevel level, bool verbose, string message)
        {
            object[] objArray1 = new object[] { level, verbose, message };
            base.method_9("ScreenPrint", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public bool m_fileWriterInitialized
        {
            get
            {
                return base.method_2<bool>("m_fileWriterInitialized");
            }
        }

        public string m_name
        {
            get
            {
                return base.method_4("m_name");
            }
        }

        public static string OUTPUT_DIRECTORY_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Logger", "OUTPUT_DIRECTORY_NAME");
            }
        }

        public static string OUTPUT_FILE_EXTENSION
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Logger", "OUTPUT_FILE_EXTENSION");
            }
        }
    }
}

