namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ZoneHeroPower")]
    public class ZoneHeroPower : Zone
    {
        public ZoneHeroPower(IntPtr address) : this(address, "ZoneHeroPower")
        {
        }

        public ZoneHeroPower(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
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

