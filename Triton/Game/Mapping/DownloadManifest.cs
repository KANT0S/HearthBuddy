namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DownloadManifest")]
    public class DownloadManifest : MonoClass
    {
        public DownloadManifest(IntPtr address) : this(address, "DownloadManifest")
        {
        }

        public DownloadManifest(IntPtr address, string className) : base(address, className)
        {
        }

        public static void AddFileToWrite(string filePath)
        {
            object[] objArray1 = new object[] { filePath };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "DownloadManifest", "AddFileToWrite", objArray1);
        }

        public static void AddHashNameForBundle(string name, string hash)
        {
            object[] objArray1 = new object[] { name, hash };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "DownloadManifest", "AddHashNameForBundle", objArray1);
        }

        public static void ClearDataToWrite()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "DownloadManifest", "ClearDataToWrite");
        }

        public bool ContainsFile(string filePath)
        {
            object[] objArray1 = new object[] { filePath };
            return base.method_11<bool>("ContainsFile", objArray1);
        }

        public string DownloadableBundleFileName(string bundleName)
        {
            object[] objArray1 = new object[] { bundleName };
            return base.method_13("DownloadableBundleFileName", objArray1);
        }

        public static DownloadManifest Get()
        {
            return MonoClass.smethod_15<DownloadManifest>(TritonHs.MainAssemblyPath, "", "DownloadManifest", "Get", Array.Empty<object>());
        }

        public string HashForBundle(string bundleName)
        {
            object[] objArray1 = new object[] { bundleName };
            return base.method_13("HashForBundle", objArray1);
        }

        public void Load()
        {
            base.method_8("Load", Array.Empty<object>());
        }

        public bool ParseAndAddHashName(string line)
        {
            object[] objArray1 = new object[] { line };
            return base.method_11<bool>("ParseAndAddHashName", objArray1);
        }

        public static void WriteToFile(string path)
        {
            object[] objArray1 = new object[] { path };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "DownloadManifest", "WriteToFile", objArray1);
        }

        public static string MANIFEST_DIVIDER
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "DownloadManifest", "MANIFEST_DIVIDER");
            }
        }

        public static DownloadManifest s_downloadManifest
        {
            get
            {
                return MonoClass.smethod_7<DownloadManifest>(TritonHs.MainAssemblyPath, "", "DownloadManifest", "s_downloadManifest");
            }
        }

        public static string s_downloadManifestFilePath
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "DownloadManifest", "s_downloadManifestFilePath");
            }
        }

        public static List<string> s_filesToWrite
        {
            get
            {
                Class268 class2 = MonoClass.smethod_7<Class268>(TritonHs.MainAssemblyPath, "", "DownloadManifest", "s_filesToWrite");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

