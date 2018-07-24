namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HiddenCard")]
    public class HiddenCard : CardDef
    {
        public HiddenCard(IntPtr address) : this(address, "HiddenCard")
        {
        }

        public HiddenCard(IntPtr address, string className) : base(address, className)
        {
        }

        public string DetermineActorNameForZone(Triton.Game.Mapping.Entity entity, TAG_ZONE zoneTag)
        {
            object[] objArray1 = new object[] { entity, zoneTag };
            return base.method_13("DetermineActorNameForZone", objArray1);
        }
    }
}

