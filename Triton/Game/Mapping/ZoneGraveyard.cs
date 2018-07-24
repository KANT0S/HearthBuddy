namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ZoneGraveyard")]
    public class ZoneGraveyard : Zone
    {
        public ZoneGraveyard(IntPtr address) : this(address, "ZoneGraveyard")
        {
        }

        public ZoneGraveyard(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanAcceptTags(int controllerId, TAG_ZONE zoneTag, TAG_CARDTYPE cardType)
        {
            object[] objArray1 = new object[] { controllerId, zoneTag, cardType };
            return base.method_11<bool>("CanAcceptTags", objArray1);
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }
    }
}

