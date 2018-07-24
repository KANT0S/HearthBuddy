namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Blizzard")]
    public class Blizzard : MonoClass
    {
        public Blizzard(IntPtr address) : this(address, "Blizzard")
        {
        }

        public Blizzard(IntPtr address, string className) : base(address, className)
        {
        }

        [Attribute38("Blizzard.Crypto")]
        public class Crypto : MonoClass
        {
            public Crypto(IntPtr address) : this(address, "Crypto")
            {
            }

            public Crypto(IntPtr address, string className) : base(address, className)
            {
            }

            [Attribute38("Blizzard.Crypto.SHA1")]
            public class SHA1 : MonoClass
            {
                public SHA1(IntPtr address) : this(address, "SHA1")
                {
                }

                public SHA1(IntPtr address, string className) : base(address, className)
                {
                }

                public static string Calc(string message)
                {
                    Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
                    object[] objArray1 = new object[] { message };
                    return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "SHA1", "Calc", enumArray1, objArray1);
                }

                public static int Length
                {
                    get
                    {
                        return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Blizzard/Crypto/SHA1", "Length");
                    }
                }

                public static string Null
                {
                    get
                    {
                        return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Blizzard/Crypto/SHA1", "Null");
                    }
                }
            }
        }

        [Attribute38("Blizzard.File")]
        public class File : MonoClass
        {
            public File(IntPtr address) : this(address, "File")
            {
            }

            public File(IntPtr address, string className) : base(address, className)
            {
            }

            public static bool createFolder(string folder)
            {
                object[] objArray1 = new object[] { folder };
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "File", "createFolder", objArray1);
            }

            [Attribute38("Blizzard.File.CopyTask")]
            public class CopyTask : MonoClass
            {
                public CopyTask(IntPtr address) : this(address, "CopyTask")
                {
                }

                public CopyTask(IntPtr address, string className) : base(address, className)
                {
                }

                public Result copy()
                {
                    return base.method_11<Result>("copy", Array.Empty<object>());
                }

                public static Blizzard.File.CopyTask FileToFile(string s, string t)
                {
                    object[] objArray1 = new object[] { s, t };
                    return MonoClass.smethod_15<Blizzard.File.CopyTask>(TritonHs.MainAssemblyPath, "", "CopyTask", "FileToFile", objArray1);
                }

                public static Blizzard.File.CopyTask FileToFolder(string s, string t)
                {
                    object[] objArray1 = new object[] { s, t };
                    return MonoClass.smethod_15<Blizzard.File.CopyTask>(TritonHs.MainAssemblyPath, "", "CopyTask", "FileToFolder", objArray1);
                }

                public static Blizzard.File.CopyTask FolderToFolder(string s, string t)
                {
                    object[] objArray1 = new object[] { s, t };
                    return MonoClass.smethod_15<Blizzard.File.CopyTask>(TritonHs.MainAssemblyPath, "", "CopyTask", "FolderToFolder", objArray1);
                }

                public string ToString()
                {
                    return base.method_13("ToString", Array.Empty<object>());
                }

                public static DateTime writeTime(bool isFolder, string path)
                {
                    object[] objArray1 = new object[] { isFolder, path };
                    return MonoClass.smethod_14<DateTime>(TritonHs.MainAssemblyPath, "", "CopyTask", "writeTime", objArray1);
                }

                public bool overwrite
                {
                    get
                    {
                        return base.method_2<bool>("overwrite");
                    }
                }

                public bool sourceExists
                {
                    get
                    {
                        return base.method_11<bool>("get_sourceExists", Array.Empty<object>());
                    }
                }

                public string sourceFilename
                {
                    get
                    {
                        return base.method_13("get_sourceFilename", Array.Empty<object>());
                    }
                }

                public string sourceFolder
                {
                    get
                    {
                        return base.method_13("get_sourceFolder", Array.Empty<object>());
                    }
                }

                public bool sourceIsFolder
                {
                    get
                    {
                        return base.method_2<bool>("sourceIsFolder");
                    }
                }

                public string sourcePath
                {
                    get
                    {
                        return base.method_13("get_sourcePath", Array.Empty<object>());
                    }
                }

                public DateTime sourceTime
                {
                    get
                    {
                        return base.method_11<DateTime>("get_sourceTime", Array.Empty<object>());
                    }
                }

                public bool targetExists
                {
                    get
                    {
                        return base.method_11<bool>("get_targetExists", Array.Empty<object>());
                    }
                }

                public string targetFilename
                {
                    get
                    {
                        return base.method_13("get_targetFilename", Array.Empty<object>());
                    }
                }

                public string targetFolder
                {
                    get
                    {
                        return base.method_13("get_targetFolder", Array.Empty<object>());
                    }
                }

                public bool targetIsFolder
                {
                    get
                    {
                        return base.method_2<bool>("targetIsFolder");
                    }
                }

                public string targetPath
                {
                    get
                    {
                        return base.method_13("get_targetPath", Array.Empty<object>());
                    }
                }

                public DateTime targetTime
                {
                    get
                    {
                        return base.method_11<DateTime>("get_targetTime", Array.Empty<object>());
                    }
                }

                public enum Result
                {
                    Unknown,
                    Success,
                    MissingSource,
                    CantOverwriteTarget,
                    UnauthorizedAccess,
                    ArgumentNull,
                    Argument,
                    PathTooLong,
                    DirectoryNotFound,
                    FileNotFound,
                    IO,
                    NotSupported
                }
            }
        }

        [Attribute38("Blizzard.Log")]
        public class Log : MonoClass
        {
            public Log(IntPtr address) : this(address, "Log")
            {
            }

            public Log(IntPtr address, string className) : base(address, className)
            {
            }

            public static void Error(string message)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
                object[] objArray1 = new object[] { message };
                MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "Log", "Error", enumArray1, objArray1);
            }

            public static void Warning(string message)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
                object[] objArray1 = new object[] { message };
                MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "Log", "Warning", enumArray1, objArray1);
            }

            public static void Write(string message)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
                object[] objArray1 = new object[] { message };
                MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "Log", "Write", enumArray1, objArray1);
            }
        }

        [Attribute38("Blizzard.Path")]
        public class Path : MonoClass
        {
            public Path(IntPtr address) : this(address, "Path")
            {
            }

            public Path(IntPtr address, string className) : base(address, className)
            {
            }
        }

        [Attribute38("Blizzard.Time")]
        public class Time : MonoClass
        {
            public Time(IntPtr address) : this(address, "Time")
            {
            }

            public Time(IntPtr address, string className) : base(address, className)
            {
            }

            public static string FormatElapsedTime(TimeSpan elapsedTime)
            {
                object[] objArray1 = new object[] { elapsedTime };
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Time", "FormatElapsedTime", objArray1);
            }

            public static string Stamp()
            {
                return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "Time", "Stamp", new Class272.Enum20[0], Array.Empty<object>());
            }

            public static string Stamp(DateTime then)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
                object[] objArray1 = new object[] { then };
                return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "Time", "Stamp", enumArray1, objArray1);
            }

            [Attribute38("Blizzard.Time.ScopedTimer")]
            public class ScopedTimer : MonoClass
            {
                public ScopedTimer(IntPtr address) : this(address, "ScopedTimer")
                {
                }

                public ScopedTimer(IntPtr address, string className) : base(address, className)
                {
                }

                public static Blizzard.Time.ScopedTimer Create(string postMessage)
                {
                    Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
                    object[] objArray1 = new object[] { postMessage };
                    return MonoClass.smethod_16<Blizzard.Time.ScopedTimer>(TritonHs.MainAssemblyPath, "", "ScopedTimer", "Create", enumArray1, objArray1);
                }

                public static Blizzard.Time.ScopedTimer Create(string preMessage, string postMessage)
                {
                    Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.String };
                    object[] objArray1 = new object[] { preMessage, postMessage };
                    return MonoClass.smethod_16<Blizzard.Time.ScopedTimer>(TritonHs.MainAssemblyPath, "", "ScopedTimer", "Create", enumArray1, objArray1);
                }

                public void Dispose()
                {
                    base.method_8("Dispose", Array.Empty<object>());
                }

                public string message_
                {
                    get
                    {
                        return base.method_4("message_");
                    }
                }

                public DateTime start_
                {
                    get
                    {
                        return base.method_2<DateTime>("start_");
                    }
                }
            }
        }
    }
}

