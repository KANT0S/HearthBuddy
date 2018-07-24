namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ZoneChange")]
    public class ZoneChange : MonoClass
    {
        public ZoneChange(IntPtr address) : this(address, "ZoneChange")
        {
        }

        public ZoneChange(IntPtr address, string className) : base(address, className)
        {
        }

        public int GetDestinationControllerId()
        {
            return base.method_11<int>("GetDestinationControllerId", Array.Empty<object>());
        }

        public int GetDestinationPosition()
        {
            return base.method_11<int>("GetDestinationPosition", Array.Empty<object>());
        }

        public Zone GetDestinationZone()
        {
            return base.method_14<Zone>("GetDestinationZone", Array.Empty<object>());
        }

        public TAG_ZONE GetDestinationZoneTag()
        {
            return base.method_11<TAG_ZONE>("GetDestinationZoneTag", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetEntity()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetEntity", Array.Empty<object>());
        }

        public ZoneChangeList GetParentList()
        {
            return base.method_14<ZoneChangeList>("GetParentList", Array.Empty<object>());
        }

        public PowerTask GetPowerTask()
        {
            return base.method_14<PowerTask>("GetPowerTask", Array.Empty<object>());
        }

        public int GetSourcePosition()
        {
            return base.method_11<int>("GetSourcePosition", Array.Empty<object>());
        }

        public Zone GetSourceZone()
        {
            return base.method_14<Zone>("GetSourceZone", Array.Empty<object>());
        }

        public TAG_ZONE GetSourceZoneTag()
        {
            return base.method_11<TAG_ZONE>("GetSourceZoneTag", Array.Empty<object>());
        }

        public bool HasDestinationControllerId()
        {
            return base.method_11<bool>("HasDestinationControllerId", Array.Empty<object>());
        }

        public bool HasDestinationData()
        {
            return base.method_11<bool>("HasDestinationData", Array.Empty<object>());
        }

        public bool HasDestinationPosition()
        {
            return base.method_11<bool>("HasDestinationPosition", Array.Empty<object>());
        }

        public bool HasDestinationZone()
        {
            return base.method_11<bool>("HasDestinationZone", Array.Empty<object>());
        }

        public bool HasDestinationZoneChange()
        {
            return base.method_11<bool>("HasDestinationZoneChange", Array.Empty<object>());
        }

        public bool HasDestinationZoneTag()
        {
            return base.method_11<bool>("HasDestinationZoneTag", Array.Empty<object>());
        }

        public bool HasSourceData()
        {
            return base.method_11<bool>("HasSourceData", Array.Empty<object>());
        }

        public bool HasSourcePosition()
        {
            return base.method_11<bool>("HasSourcePosition", Array.Empty<object>());
        }

        public bool HasSourceZone()
        {
            return base.method_11<bool>("HasSourceZone", Array.Empty<object>());
        }

        public bool HasSourceZoneTag()
        {
            return base.method_11<bool>("HasSourceZoneTag", Array.Empty<object>());
        }

        public void SetDestinationControllerId(int controllerId)
        {
            object[] objArray1 = new object[] { controllerId };
            base.method_8("SetDestinationControllerId", objArray1);
        }

        public void SetDestinationPosition(int pos)
        {
            object[] objArray1 = new object[] { pos };
            base.method_8("SetDestinationPosition", objArray1);
        }

        public void SetDestinationZone(Zone zone)
        {
            object[] objArray1 = new object[] { zone };
            base.method_8("SetDestinationZone", objArray1);
        }

        public void SetDestinationZoneTag(TAG_ZONE tag)
        {
            object[] objArray1 = new object[] { tag };
            base.method_8("SetDestinationZoneTag", objArray1);
        }

        public void SetEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("SetEntity", objArray1);
        }

        public void SetParentList(ZoneChangeList parentList)
        {
            object[] objArray1 = new object[] { parentList };
            base.method_8("SetParentList", objArray1);
        }

        public void SetPowerTask(PowerTask powerTask)
        {
            object[] objArray1 = new object[] { powerTask };
            base.method_8("SetPowerTask", objArray1);
        }

        public void SetSourcePosition(int pos)
        {
            object[] objArray1 = new object[] { pos };
            base.method_8("SetSourcePosition", objArray1);
        }

        public void SetSourceZone(Zone zone)
        {
            object[] objArray1 = new object[] { zone };
            base.method_8("SetSourceZone", objArray1);
        }

        public void SetSourceZoneTag(TAG_ZONE tag)
        {
            object[] objArray1 = new object[] { tag };
            base.method_8("SetSourceZoneTag", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public Zone m_destinationZone
        {
            get
            {
                return base.method_3<Zone>("m_destinationZone");
            }
        }

        public TAG_ZONE m_destinationZoneTag
        {
            get
            {
                return base.method_2<TAG_ZONE>("m_destinationZoneTag");
            }
        }

        public Triton.Game.Mapping.Entity m_entity
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_entity");
            }
        }

        public ZoneChangeList m_parentList
        {
            get
            {
                return base.method_3<ZoneChangeList>("m_parentList");
            }
        }

        public PowerTask m_powerTask
        {
            get
            {
                return base.method_3<PowerTask>("m_powerTask");
            }
        }

        public Zone m_sourceZone
        {
            get
            {
                return base.method_3<Zone>("m_sourceZone");
            }
        }

        public TAG_ZONE m_sourceZoneTag
        {
            get
            {
                return base.method_2<TAG_ZONE>("m_sourceZoneTag");
            }
        }
    }
}

