namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BannerManager")]
    public class BannerManager : MonoClass
    {
        public BannerManager(IntPtr address) : this(address, "BannerManager")
        {
        }

        public BannerManager(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AcknowledgeBanner(int banner)
        {
            object[] objArray1 = new object[] { banner };
            return base.method_11<bool>("AcknowledgeBanner", objArray1);
        }

        public static BannerManager Get()
        {
            return MonoClass.smethod_15<BannerManager>(TritonHs.MainAssemblyPath, "", "BannerManager", "Get", Array.Empty<object>());
        }

        public int GetDisplayBannerId()
        {
            return base.method_11<int>("GetDisplayBannerId", Array.Empty<object>());
        }

        public bool m_bannerWasAcknowledged
        {
            get
            {
                return base.method_2<bool>("m_bannerWasAcknowledged");
            }
        }

        public List<int> m_seenBanners
        {
            get
            {
                Class266<int> class2 = base.method_3<Class266<int>>("m_seenBanners");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

