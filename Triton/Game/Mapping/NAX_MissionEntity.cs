namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX_MissionEntity")]
    public class NAX_MissionEntity : MissionEntity
    {
        public NAX_MissionEntity(IntPtr address) : this(address, "NAX_MissionEntity")
        {
        }

        public NAX_MissionEntity(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

