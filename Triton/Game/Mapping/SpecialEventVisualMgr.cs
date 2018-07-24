namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SpecialEventVisualMgr")]
    public class SpecialEventVisualMgr : MonoBehaviour
    {
        public SpecialEventVisualMgr(IntPtr address) : this(address, "SpecialEventVisualMgr")
        {
        }

        public SpecialEventVisualMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static SpecialEventVisualMgr Get()
        {
            return MonoClass.smethod_15<SpecialEventVisualMgr>(TritonHs.MainAssemblyPath, "", "SpecialEventVisualMgr", "Get", Array.Empty<object>());
        }

        public static SpecialEventType GetActiveEventType()
        {
            return MonoClass.smethod_14<SpecialEventType>(TritonHs.MainAssemblyPath, "", "SpecialEventVisualMgr", "GetActiveEventType", Array.Empty<object>());
        }

        public bool LoadEvent(SpecialEventType eventType)
        {
            object[] objArray1 = new object[] { eventType };
            return base.method_11<bool>("LoadEvent", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnEventFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnEventFinished", objArray1);
        }

        public bool UnloadEvent(SpecialEventType eventType)
        {
            object[] objArray1 = new object[] { eventType };
            return base.method_11<bool>("UnloadEvent", objArray1);
        }

        public List<SpecialEventVisualDef> m_EventDefs
        {
            get
            {
                Class267<SpecialEventVisualDef> class2 = base.method_3<Class267<SpecialEventVisualDef>>("m_EventDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

