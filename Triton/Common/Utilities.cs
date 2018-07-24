namespace Triton.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;

    public static class Utilities
    {
        private static string string_0 = smethod_0();

        public static DateTime ConvertFromUnixTimestamp(ulong timestamp)
        {
            DateTime time = new DateTime(0x7b2, 1, 1, 0, 0, 0, 0);
            return time.AddSeconds((double) timestamp);
        }

        public static int ConvertToUnixTimestamp(DateTime date)
        {
            DateTime time = new DateTime(0x7b2, 1, 1, 0, 0, 0, 0);
            TimeSpan span = (TimeSpan) (date - time);
            return (int) span.TotalSeconds;
        }

        public static IEnumerable<T> FindInterfaceImplementations<T>()
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany<Assembly, Type, Class222<Assembly, Type>>((Class235<T>.<>9__0_0 ?? (Class235<T>.<>9__0_0 = new Func<Assembly, IEnumerable<Type>>(Class235<T>.<>9.method_0))), (Class235<T>.<>9__0_1 ?? (Class235<T>.<>9__0_1 = new Func<Assembly, Type, Class222<Assembly, Type>>(Class235<T>.<>9.method_1)))).Where<Class222<Assembly, Type>>((Class235<T>.<>9__0_2 ?? (Class235<T>.<>9__0_2 = new Func<Class222<Assembly, Type>, bool>(Class235<T>.<>9.method_2)))).Select<Class222<Assembly, Type>, T>((Class235<T>.<>9__0_4 ?? (Class235<T>.<>9__0_4 = new Func<Class222<Assembly, Type>, T>(Class235<T>.<>9.method_4))));
        }

        public static int FNV1a(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            return (bytes[3] ^ (0x1000193 * (bytes[2] ^ (0x1000193 * (bytes[1] ^ (0x1000193 * (bytes[0] ^ (0x1000193 * (value ^ -2128831035)))))))));
        }

        public static uint FNV1a(string value)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(value + "\0");
            uint num = 0x811c9dc5;
            int startIndex = 0;
            int num3 = value.Length * 2;
            do
            {
                startIndex += (num3 / 10) + 1;
                num = BitConverter.ToUInt16(bytes, startIndex) ^ (0x1000193 * num);
            }
            while (startIndex < num3);
            return num;
        }

        public static string FormatString([Localizable(true)] string format, params object[] args)
        {
            try
            {
                return string.Format(Thread.CurrentThread.CurrentUICulture, format, args);
            }
            catch (Exception exception)
            {
                return string.Format("FS_EMPTY {0} {1}", exception.GetType().Name, format.ToString());
            }
        }

        public static string GetObjectString(object obj, string nullRet)
        {
            if (obj == null)
            {
                return nullRet;
            }
            return obj.ToString();
        }

        public static DateTime PerformanceCounterToDateTime(ulong performanceCounter)
        {
            return DateTime.Now.Subtract(TimeSpan.FromMilliseconds((double) Environment.TickCount)).AddMilliseconds((double) performanceCounter);
        }

        [Conditional("DEBUG")]
        public static void PrintStackTrace(string reason = "Debug")
        {
            StackFrame[] frames = new StackTrace(true).GetFrames();
            for (int i = 1; i < Math.Min(frames.Length, 10); i++)
            {
            }
        }

        private static string smethod_0()
        {
            try
            {
                Assembly executingAssembly = Assembly.GetExecutingAssembly();
                if (string.IsNullOrEmpty(executingAssembly.Location))
                {
                    return Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), @"Hearthstone_Data\Managed");
                }
                return Path.GetDirectoryName(executingAssembly.Location);
            }
            catch
            {
                return "";
            }
        }

        internal static string smethod_1(CompilerResults compilerResults_0)
        {
            StringBuilder builder = new StringBuilder();
            foreach (CompilerError error in compilerResults_0.Errors)
            {
                if (!error.IsWarning)
                {
                    object[] args = new object[] { Path.GetFileName(error.FileName), error.Line, error.ErrorText, error.IsWarning ? "Warning" : "Error" };
                    builder.AppendLine(string.Format("File: {0} Line: {1} {3}: {2}", args));
                }
            }
            return builder.ToString();
        }

        public static string AssemblyDirectory
        {
            get
            {
                return string_0;
            }
            set
            {
                string_0 = value;
            }
        }

        public static bool IsWindowsXp
        {
            get
            {
                return (Environment.OSVersion.Version.Major == 5);
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class235<T>
        {
            public static readonly Utilities.Class235<T> <>9;
            public static Func<Assembly, IEnumerable<Type>> <>9__0_0;
            public static Func<Assembly, Type, Class222<Assembly, Type>> <>9__0_1;
            public static Func<Class222<Assembly, Type>, bool> <>9__0_2;
            public static Func<Type, bool> <>9__0_3;
            public static Func<Class222<Assembly, Type>, T> <>9__0_4;

            static Class235()
            {
                Utilities.Class235<T>.<>9 = new Utilities.Class235<T>();
            }

            internal IEnumerable<Type> method_0(Assembly assembly_0)
            {
                return assembly_0.GetTypes();
            }

            internal Class222<Assembly, Type> method_1(Assembly assembly_0, Type type_0)
            {
                return new Class222<Assembly, Type>(assembly_0, type_0);
            }

            internal bool method_2(Class222<Assembly, Type> class222_0)
            {
                return class222_0.type.GetInterfaces().Any<Type>((Utilities.Class235<T>.<>9__0_3 ?? (Utilities.Class235<T>.<>9__0_3 = new Func<Type, bool>(Utilities.Class235<T>.<>9.method_3))));
            }

            internal bool method_3(Type type_0)
            {
                return (type_0 == typeof(T));
            }

            internal T method_4(Class222<Assembly, Type> class222_0)
            {
                return (T) Activator.CreateInstance(class222_0.type);
            }
        }
    }
}

