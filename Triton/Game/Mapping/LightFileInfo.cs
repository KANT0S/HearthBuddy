namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("LightFileInfo")]
    public class LightFileInfo : MonoClass
    {
        public LightFileInfo(IntPtr address) : this(address, "LightFileInfo")
        {
        }

        public LightFileInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public string DirectoryName
        {
            get
            {
                return base.method_4("DirectoryName");
            }
        }

        public string FullName
        {
            get
            {
                return base.method_4("FullName");
            }
        }

        public string Name
        {
            get
            {
                return base.method_4("Name");
            }
        }

        public string Path
        {
            get
            {
                return base.method_13("get_Path", Array.Empty<object>());
            }
        }
    }
}

