namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("ZoneChangeList")]
    public class ZoneChangeList : MonoClass
    {
        public ZoneChangeList(IntPtr address) : this(address, "ZoneChangeList")
        {
        }

        public ZoneChangeList(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddChange(ZoneChange change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("AddChange", objArray1);
        }

        public void ClearChanges()
        {
            base.method_8("ClearChanges", Array.Empty<object>());
        }

        public bool DoesIgnoreCardZoneChanges()
        {
            return base.method_11<bool>("DoesIgnoreCardZoneChanges", Array.Empty<object>());
        }

        public void Finish()
        {
            base.method_8("Finish", Array.Empty<object>());
        }

        public void FireCompleteCallback()
        {
            base.method_8("FireCompleteCallback", Array.Empty<object>());
        }

        public ZoneChange GetChange(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_14<ZoneChange>("GetChange", objArray1);
        }

        public List<ZoneChange> GetChanges()
        {
            Class267<ZoneChange> class2 = base.method_14<Class267<ZoneChange>>("GetChanges", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public object GetCompleteCallbackUserData()
        {
            return base.method_14<object>("GetCompleteCallbackUserData", Array.Empty<object>());
        }

        public int GetId()
        {
            return base.method_11<int>("GetId", Array.Empty<object>());
        }

        public Card GetLocalTriggerCard()
        {
            return base.method_14<Card>("GetLocalTriggerCard", Array.Empty<object>());
        }

        public ZoneChange GetLocalTriggerChange()
        {
            return base.method_14<ZoneChange>("GetLocalTriggerChange", Array.Empty<object>());
        }

        public int GetPredictedPosition()
        {
            return base.method_11<int>("GetPredictedPosition", Array.Empty<object>());
        }

        public PowerTaskList GetTaskList()
        {
            return base.method_14<PowerTaskList>("GetTaskList", Array.Empty<object>());
        }

        public void InsertChange(int index, ZoneChange change)
        {
            object[] objArray1 = new object[] { index, change };
            base.method_8("InsertChange", objArray1);
        }

        public bool IsCanceledChangeList()
        {
            return base.method_11<bool>("IsCanceledChangeList", Array.Empty<object>());
        }

        public bool IsComplete()
        {
            return base.method_11<bool>("IsComplete", Array.Empty<object>());
        }

        public bool IsDeathBlock()
        {
            return base.method_11<bool>("IsDeathBlock", Array.Empty<object>());
        }

        public bool IsDisplayableDyingSecret(Triton.Game.Mapping.Entity entity, Card card, Zone srcZone, Zone dstZone)
        {
            object[] objArray1 = new object[] { entity, card, srcZone, dstZone };
            return base.method_11<bool>("IsDisplayableDyingSecret", objArray1);
        }

        public bool IsEntityLoading(Triton.Game.Mapping.Entity entity, Card card)
        {
            object[] objArray1 = new object[] { entity, card };
            return base.method_11<bool>("IsEntityLoading", objArray1);
        }

        public bool IsLocal()
        {
            return base.method_11<bool>("IsLocal", Array.Empty<object>());
        }

        public bool MustWaitForChoices()
        {
            return base.method_11<bool>("MustWaitForChoices", Array.Empty<object>());
        }

        public void OnUpdateLayoutComplete(Zone zone, object userData)
        {
            object[] objArray1 = new object[] { zone, userData };
            base.method_8("OnUpdateLayoutComplete", objArray1);
        }

        public void SetCanceledChangeList(bool canceledChangeList)
        {
            object[] objArray1 = new object[] { canceledChangeList };
            base.method_8("SetCanceledChangeList", objArray1);
        }

        public void SetCompleteCallbackUserData(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("SetCompleteCallbackUserData", objArray1);
        }

        public void SetId(int id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetId", objArray1);
        }

        public void SetIgnoreCardZoneChanges(bool ignore)
        {
            object[] objArray1 = new object[] { ignore };
            base.method_8("SetIgnoreCardZoneChanges", objArray1);
        }

        public void SetPredictedPosition(int pos)
        {
            object[] objArray1 = new object[] { pos };
            base.method_8("SetPredictedPosition", objArray1);
        }

        public void SetTaskList(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            base.method_8("SetTaskList", objArray1);
        }

        public void SetZoneInputBlocking(bool block)
        {
            object[] objArray1 = new object[] { block };
            base.method_8("SetZoneInputBlocking", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public bool m_canceledChangeList
        {
            get
            {
                return base.method_2<bool>("m_canceledChangeList");
            }
        }

        public List<ZoneChange> m_changes
        {
            get
            {
                Class267<ZoneChange> class2 = base.method_3<Class267<ZoneChange>>("m_changes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_complete
        {
            get
            {
                return base.method_2<bool>("m_complete");
            }
        }

        public object m_completeCallbackUserData
        {
            get
            {
                return base.method_3<object>("m_completeCallbackUserData");
            }
        }

        public int m_id
        {
            get
            {
                return base.method_2<int>("m_id");
            }
        }

        public bool m_ignoreCardZoneChanges
        {
            get
            {
                return base.method_2<bool>("m_ignoreCardZoneChanges");
            }
        }

        public int m_predictedPosition
        {
            get
            {
                return base.method_2<int>("m_predictedPosition");
            }
        }

        public PowerTaskList m_taskList
        {
            get
            {
                return base.method_3<PowerTaskList>("m_taskList");
            }
        }
    }
}

