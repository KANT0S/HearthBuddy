namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("UpdateManager")]
    public class UpdateManager : MonoBehaviour
    {
        public UpdateManager(IntPtr address) : this(address, "UpdateManager")
        {
        }

        public UpdateManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public string CachedFileFolder()
        {
            return base.method_13("CachedFileFolder", Array.Empty<object>());
        }

        public string CachedFilePath(string fileName)
        {
            object[] objArray1 = new object[] { fileName };
            return base.method_13("CachedFilePath", objArray1);
        }

        public void CallCallback()
        {
            base.method_8("CallCallback", Array.Empty<object>());
        }

        public bool ContainsFile(string fileName)
        {
            object[] objArray1 = new object[] { fileName };
            return base.method_11<bool>("ContainsFile", objArray1);
        }

        public bool CurrentRegionIsCN()
        {
            return base.method_11<bool>("CurrentRegionIsCN", Array.Empty<object>());
        }

        public string DownloadURI(string fileName)
        {
            object[] objArray1 = new object[] { fileName };
            return base.method_13("DownloadURI", objArray1);
        }

        public static UpdateManager Get()
        {
            return MonoClass.smethod_15<UpdateManager>(TritonHs.MainAssemblyPath, "", "UpdateManager", "Get", Array.Empty<object>());
        }

        public string GetError()
        {
            return base.method_13("GetError", Array.Empty<object>());
        }

        public UpdateProgress GetProgressForCurrentFile()
        {
            return base.method_14<UpdateProgress>("GetProgressForCurrentFile", Array.Empty<object>());
        }

        public int GetTryCount()
        {
            return base.method_11<int>("GetTryCount", Array.Empty<object>());
        }

        public void InitValues()
        {
            base.method_8("InitValues", Array.Empty<object>());
        }

        public void MoveToNextCDN()
        {
            base.method_8("MoveToNextCDN", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void SetDownloadURI()
        {
            base.method_8("SetDownloadURI", Array.Empty<object>());
        }

        public void SetLastFailedDOPVersion(bool success)
        {
            object[] objArray1 = new object[] { success };
            base.method_8("SetLastFailedDOPVersion", objArray1);
        }

        public bool StopWaitingForUpdate()
        {
            return base.method_11<bool>("StopWaitingForUpdate", Array.Empty<object>());
        }

        public bool UpdateIsRequired()
        {
            return base.method_11<bool>("UpdateIsRequired", Array.Empty<object>());
        }

        public int m_assetsVersion
        {
            get
            {
                return base.method_2<int>("m_assetsVersion");
            }
        }

        public string m_error
        {
            get
            {
                return base.method_4("m_error");
            }
        }

        public List<string> m_remoteUri
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("m_remoteUri");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_remoteUriIndex
        {
            get
            {
                return base.method_2<int>("m_remoteUriIndex");
            }
        }

        public bool m_skipLoadingAssetBundle
        {
            get
            {
                return base.method_2<bool>("m_skipLoadingAssetBundle");
            }
        }

        public bool m_updateIsRequired
        {
            get
            {
                return base.method_2<bool>("m_updateIsRequired");
            }
        }

        public UpdateProgress m_updateProgress
        {
            get
            {
                return base.method_3<UpdateProgress>("m_updateProgress");
            }
        }

        [Attribute38("UpdateManager.UpdateItem")]
        public class UpdateItem : MonoClass
        {
            public UpdateItem(IntPtr address) : this(address, "UpdateItem")
            {
            }

            public UpdateItem(IntPtr address, string className) : base(address, className)
            {
            }

            public List<byte> bytes
            {
                get
                {
                    Class246<byte> class2 = base.method_3<Class246<byte>>("bytes");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public string fileName
            {
                get
                {
                    return base.method_4("fileName");
                }
            }

            public string md5
            {
                get
                {
                    return base.method_4("md5");
                }
            }

            public int size
            {
                get
                {
                    return base.method_2<int>("size");
                }
            }
        }

        [Attribute38("UpdateManager.UpdateProgress")]
        public class UpdateProgress : MonoClass
        {
            public UpdateProgress(IntPtr address) : this(address, "UpdateProgress")
            {
            }

            public UpdateProgress(IntPtr address, string className) : base(address, className)
            {
            }

            public float downloadPercentage
            {
                get
                {
                    return base.method_2<float>("downloadPercentage");
                }
            }

            public float maxPatchingBarDisplayTime
            {
                get
                {
                    return base.method_2<float>("maxPatchingBarDisplayTime");
                }
            }

            public int numFilesDownloaded
            {
                get
                {
                    return base.method_2<int>("numFilesDownloaded");
                }
            }

            public int numFilesToDownload
            {
                get
                {
                    return base.method_2<int>("numFilesToDownload");
                }
            }

            public bool showProgressBar
            {
                get
                {
                    return base.method_2<bool>("showProgressBar");
                }
            }
        }
    }
}

