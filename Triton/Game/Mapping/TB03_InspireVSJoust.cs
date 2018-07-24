namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TB03_InspireVSJoust")]
    public class TB03_InspireVSJoust : MissionEntity
    {
        public TB03_InspireVSJoust(IntPtr address) : this(address, "TB03_InspireVSJoust")
        {
        }

        public TB03_InspireVSJoust(IntPtr address, string className) : base(address, className)
        {
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }
    }
}

