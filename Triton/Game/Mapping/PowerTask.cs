namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("PowerTask")]
    public class PowerTask : MonoClass
    {
        public PowerTask(IntPtr address) : this(address, "PowerTask")
        {
        }

        public PowerTask(IntPtr address, string className) : base(address, className)
        {
        }

        public void DoEarlyConcedeTask()
        {
            base.method_8("DoEarlyConcedeTask", Array.Empty<object>());
        }

        public void DoTask()
        {
            base.method_8("DoTask", Array.Empty<object>());
        }

        public Network.PowerHistory GetPower()
        {
            return base.method_14<Network.PowerHistory>("GetPower", Array.Empty<object>());
        }

        public string GetPrintableEntity(int entityId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { entityId };
            return base.method_12("GetPrintableEntity", enumArray1, objArray1);
        }

        public string GetPrintableEntity(Network.Entity netEntity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { netEntity };
            return base.method_12("GetPrintableEntity", enumArray1, objArray1);
        }

        public bool IsCompleted()
        {
            return base.method_11<bool>("IsCompleted", Array.Empty<object>());
        }

        public void SetCompleted(bool complete)
        {
            object[] objArray1 = new object[] { complete };
            base.method_8("SetCompleted", objArray1);
        }

        public void SetPower(Network.PowerHistory power)
        {
            object[] objArray1 = new object[] { power };
            base.method_8("SetPower", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public bool m_completed
        {
            get
            {
                return base.method_2<bool>("m_completed");
            }
        }

        public Network.PowerHistory m_power
        {
            get
            {
                return base.method_3<Network.PowerHistory>("m_power");
            }
        }
    }
}

