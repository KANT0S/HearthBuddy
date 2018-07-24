namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("AssetPathInfo")]
    public class AssetPathInfo : MonoClass
    {
        public AssetPathInfo(IntPtr address) : this(address, "AssetPathInfo")
        {
        }

        public AssetPathInfo(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

