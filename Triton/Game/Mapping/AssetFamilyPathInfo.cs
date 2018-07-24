namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("AssetFamilyPathInfo")]
    public class AssetFamilyPathInfo : MonoClass
    {
        public AssetFamilyPathInfo(IntPtr address) : this(address, "AssetFamilyPathInfo")
        {
        }

        public AssetFamilyPathInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public List<string> exts
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("exts");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string format
        {
            get
            {
                return base.method_4("format");
            }
        }

        public string sourceDir
        {
            get
            {
                return base.method_4("sourceDir");
            }
        }
    }
}

