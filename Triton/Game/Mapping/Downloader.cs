namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Downloader")]
    public class Downloader : MonoBehaviour
    {
        public Downloader(IntPtr address) : this(address, "Downloader")
        {
        }

        public Downloader(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AllLocalizedAudioBundlesDownloaded()
        {
            return base.method_11<bool>("AllLocalizedAudioBundlesDownloaded", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public List<string> BundlesMissing()
        {
            Class268 class2 = base.method_14<Class268>("BundlesMissing", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<string> BundlesToDownloadForLocale()
        {
            Class268 class2 = base.method_14<Class268>("BundlesToDownloadForLocale", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static string BundleURL(string fileName)
        {
            object[] objArray1 = new object[] { fileName };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Downloader", "BundleURL", objArray1);
        }

        public void DeleteLocalizedBundles()
        {
            base.method_8("DeleteLocalizedBundles", Array.Empty<object>());
        }

        public void DownloadLocalizedBundles()
        {
            base.method_9("DownloadLocalizedBundles", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void DownloadNextFile()
        {
            base.method_8("DownloadNextFile", Array.Empty<object>());
        }

        public static Downloader Get()
        {
            return MonoClass.smethod_15<Downloader>(TritonHs.MainAssemblyPath, "", "Downloader", "Get", Array.Empty<object>());
        }

        public static int GetTryCount()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "Downloader", "GetTryCount", Array.Empty<object>());
        }

        public static string NextBundleURL(string fileName)
        {
            object[] objArray1 = new object[] { fileName };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Downloader", "NextBundleURL", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public List<string> m_bundlesToDownload
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_bundlesToDownload");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_downloadStartTime
        {
            get
            {
                return base.method_2<float>("m_downloadStartTime");
            }
        }

        public bool m_hasShownInternalFailureAlert
        {
            get
            {
                return base.method_2<bool>("m_hasShownInternalFailureAlert");
            }
        }

        public bool m_isDownloading
        {
            get
            {
                return base.method_2<bool>("m_isDownloading");
            }
        }

        public static string m_remoteUri
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Downloader", "m_remoteUri");
            }
        }

        public static string m_remoteUriCN
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Downloader", "m_remoteUriCN");
            }
        }

        public static int m_remoteUriCNIndex
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Downloader", "m_remoteUriCNIndex");
            }
        }
    }
}

