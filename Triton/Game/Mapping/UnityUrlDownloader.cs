namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("UnityUrlDownloader")]
    public class UnityUrlDownloader : MonoClass
    {
        public UnityUrlDownloader(IntPtr address) : this(address, "UnityUrlDownloader")
        {
        }

        public UnityUrlDownloader(IntPtr address, string className) : base(address, className)
        {
        }

        public void Process()
        {
            base.method_8("Process", Array.Empty<object>());
        }

        [Attribute38("UnityUrlDownloader.DownloadState")]
        public class DownloadState : MonoClass
        {
            public DownloadState(IntPtr address) : this(address, "DownloadState")
            {
            }

            public DownloadState(IntPtr address, string className) : base(address, className)
            {
            }

            public int numRetriesLeft
            {
                get
                {
                    return base.method_2<int>("numRetriesLeft");
                }
            }

            public float startTime
            {
                get
                {
                    return base.method_2<float>("startTime");
                }
            }

            public bool success
            {
                get
                {
                    return base.method_2<bool>("success");
                }
            }

            public int timeoutMs
            {
                get
                {
                    return base.method_2<int>("timeoutMs");
                }
            }

            public string url
            {
                get
                {
                    return base.method_4("url");
                }
            }
        }
    }
}

