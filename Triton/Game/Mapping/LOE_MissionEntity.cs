namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE_MissionEntity")]
    public class LOE_MissionEntity : MissionEntity
    {
        public LOE_MissionEntity(IntPtr address) : this(address, "LOE_MissionEntity")
        {
        }

        public LOE_MissionEntity(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

