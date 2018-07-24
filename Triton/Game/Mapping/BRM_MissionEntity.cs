namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM_MissionEntity")]
    public class BRM_MissionEntity : MissionEntity
    {
        public BRM_MissionEntity(IntPtr address) : this(address, "BRM_MissionEntity")
        {
        }

        public BRM_MissionEntity(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

