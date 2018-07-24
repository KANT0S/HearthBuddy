namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SpecialEventManager")]
    public class SpecialEventManager : MonoClass
    {
        public SpecialEventManager(IntPtr address) : this(address, "SpecialEventManager")
        {
        }

        public SpecialEventManager(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ForceEventActive(SpecialEventType eventType)
        {
            object[] objArray1 = new object[] { eventType };
            return base.method_11<bool>("ForceEventActive", objArray1);
        }

        public static SpecialEventManager Get()
        {
            return MonoClass.smethod_15<SpecialEventManager>(TritonHs.MainAssemblyPath, "", "SpecialEventManager", "Get", Array.Empty<object>());
        }

        public bool HasEventEnded(SpecialEventType eventType)
        {
            object[] objArray1 = new object[] { eventType };
            return base.method_11<bool>("HasEventEnded", objArray1);
        }

        public bool HasEventStarted(SpecialEventType eventType)
        {
            object[] objArray1 = new object[] { eventType };
            return base.method_11<bool>("HasEventStarted", objArray1);
        }

        public bool IsEventActive(string eventName, bool activeIfDoesNotExist)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { eventName, activeIfDoesNotExist };
            return base.method_10<bool>("IsEventActive", enumArray1, objArray1);
        }

        public bool IsEventActive(SpecialEventType eventType, bool activeIfDoesNotExist)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { eventType, activeIfDoesNotExist };
            return base.method_10<bool>("IsEventActive", enumArray1, objArray1);
        }

        public void OnReset()
        {
            base.method_8("OnReset", Array.Empty<object>());
        }

        [Attribute38("SpecialEventManager.EventTiming")]
        public class EventTiming : MonoClass
        {
            public EventTiming(IntPtr address) : this(address, "EventTiming")
            {
            }

            public EventTiming(IntPtr address, string className) : base(address, className)
            {
            }

            public bool HasEnded()
            {
                return base.method_11<bool>("HasEnded", Array.Empty<object>());
            }

            public bool HasStarted()
            {
                return base.method_11<bool>("HasStarted", Array.Empty<object>());
            }

            public bool IsActiveNow()
            {
                return base.method_11<bool>("IsActiveNow", Array.Empty<object>());
            }
        }
    }
}

