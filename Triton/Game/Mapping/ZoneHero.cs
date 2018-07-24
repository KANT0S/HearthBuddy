namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ZoneHero")]
    public class ZoneHero : Zone
    {
        public ZoneHero(IntPtr address) : this(address, "ZoneHero")
        {
        }

        public ZoneHero(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanAcceptTags(int controllerId, TAG_ZONE zoneTag, TAG_CARDTYPE cardType)
        {
            object[] objArray1 = new object[] { controllerId, zoneTag, cardType };
            return base.method_11<bool>("CanAcceptTags", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }
    }
}

