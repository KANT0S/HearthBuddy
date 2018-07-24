namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FileUtils")]
    public class FileUtils : MonoClass
    {
        public FileUtils(IntPtr address) : this(address, "FileUtils")
        {
        }

        public FileUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static string GameAssetPathToName(string path)
        {
            object[] objArray1 = new object[] { path };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "GameAssetPathToName", objArray1);
        }

        public static string GameToSourceAssetName(string folder, string name, string dotExtension)
        {
            object[] objArray1 = new object[] { folder, name, dotExtension };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "GameToSourceAssetName", objArray1);
        }

        public static string GameToSourceAssetPath(string path, string dotExtension)
        {
            object[] objArray1 = new object[] { path, dotExtension };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "GameToSourceAssetPath", objArray1);
        }

        public static string GetAssetPath(string fileName)
        {
            object[] objArray1 = new object[] { fileName };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "GetAssetPath", objArray1);
        }

        public static string GetMD5(string fileName)
        {
            object[] objArray1 = new object[] { fileName };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "GetMD5", objArray1);
        }

        public static string GetMD5FromString(string buf)
        {
            object[] objArray1 = new object[] { buf };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "GetMD5FromString", objArray1);
        }

        public static string GetOnDiskCapitalizationForDir(string dirPath)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { dirPath };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "FileUtils", "GetOnDiskCapitalizationForDir", enumArray1, objArray1);
        }

        public static string GetOnDiskCapitalizationForFile(string filePath)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { filePath };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "FileUtils", "GetOnDiskCapitalizationForFile", enumArray1, objArray1);
        }

        public static bool IsForeignLocaleSourcePath(string path)
        {
            object[] objArray1 = new object[] { path };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "FileUtils", "IsForeignLocaleSourcePath", objArray1);
        }

        public static IntPtr LoadPlugin(string fileName, bool handleError)
        {
            object[] objArray1 = new object[] { fileName, handleError };
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "FileUtils", "LoadPlugin", objArray1);
        }

        public static string MakeLocalizedPathFromSourcePath(Locale locale, string enUsPath)
        {
            object[] objArray1 = new object[] { locale, enUsPath };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "MakeLocalizedPathFromSourcePath", objArray1);
        }

        public static string MakeMetaPathFromSourcePath(string path)
        {
            object[] objArray1 = new object[] { path };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "MakeMetaPathFromSourcePath", objArray1);
        }

        public static string MakeSourceAssetMetaPath(string path)
        {
            object[] objArray1 = new object[] { path };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "MakeSourceAssetMetaPath", objArray1);
        }

        public static string MakeSourceAssetPath(string path)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { path };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "FileUtils", "MakeSourceAssetPath", enumArray1, objArray1);
        }

        public static bool SetFileWritableFlag(string path, bool setWritable)
        {
            object[] objArray1 = new object[] { path, setWritable };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "FileUtils", "SetFileWritableFlag", objArray1);
        }

        public static bool SetFolderWritableFlag(string dirPath, bool writable)
        {
            object[] objArray1 = new object[] { dirPath, writable };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "FileUtils", "SetFolderWritableFlag", objArray1);
        }

        public static string SourceToGameAssetName(string path)
        {
            object[] objArray1 = new object[] { path };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "SourceToGameAssetName", objArray1);
        }

        public static string SourceToGameAssetPath(string path)
        {
            object[] objArray1 = new object[] { path };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "SourceToGameAssetPath", objArray1);
        }

        public static string StripLocaleFromPath(string path)
        {
            object[] objArray1 = new object[] { path };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "StripLocaleFromPath", objArray1);
        }

        public static string BasePersistentDataPath
        {
            get
            {
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "get_BasePersistentDataPath", Array.Empty<object>());
            }
        }

        public static string CachePath
        {
            get
            {
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "get_CachePath", Array.Empty<object>());
            }
        }

        public static List<char> FOLDER_SEPARATOR_CHARS
        {
            get
            {
                Class246<char> class2 = MonoClass.smethod_7<Class246<char>>(TritonHs.MainAssemblyPath, "", "FileUtils", "FOLDER_SEPARATOR_CHARS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static string InternalPersistentDataPath
        {
            get
            {
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "get_InternalPersistentDataPath", Array.Empty<object>());
            }
        }

        public static string PersistentDataPath
        {
            get
            {
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "get_PersistentDataPath", Array.Empty<object>());
            }
        }

        public static string PublicPersistentDataPath
        {
            get
            {
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FileUtils", "get_PublicPersistentDataPath", Array.Empty<object>());
            }
        }
    }
}

