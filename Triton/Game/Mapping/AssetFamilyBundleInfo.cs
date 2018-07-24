namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("AssetFamilyBundleInfo")]
    public class AssetFamilyBundleInfo : MonoClass
    {
        public AssetFamilyBundleInfo(IntPtr address) : this(address, "AssetFamilyBundleInfo")
        {
        }

        public AssetFamilyBundleInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public string BundleName
        {
            get
            {
                return base.method_4("BundleName");
            }
        }

        public int NumberOfBundles
        {
            get
            {
                return base.method_2<int>("NumberOfBundles");
            }
        }

        public int NumberOfDownloadableLocaleBundles
        {
            get
            {
                return base.method_2<int>("NumberOfDownloadableLocaleBundles");
            }
        }

        public int NumberOfLocaleBundles
        {
            get
            {
                return base.method_2<int>("NumberOfLocaleBundles");
            }
        }

        public System.Type TypeOf
        {
            get
            {
                return base.method_3<System.Type>("TypeOf");
            }
        }

        public bool Updatable
        {
            get
            {
                return base.method_2<bool>("Updatable");
            }
        }
    }
}

