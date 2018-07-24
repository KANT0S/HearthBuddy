namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("BnetPlayerChangelist")]
    public class BnetPlayerChangelist : MonoClass
    {
        public BnetPlayerChangelist(IntPtr address) : this(address, "BnetPlayerChangelist")
        {
        }

        public BnetPlayerChangelist(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddChange(BnetPlayerChange change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("AddChange", objArray1);
        }

        public BnetPlayerChange FindChange(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_15<BnetPlayerChange>("FindChange", enumArray1, objArray1);
        }

        public List<BnetPlayerChange> GetChanges()
        {
            Class267<BnetPlayerChange> class2 = base.method_14<Class267<BnetPlayerChange>>("GetChanges", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public bool HasChange(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_10<bool>("HasChange", enumArray1, objArray1);
        }

        public List<BnetPlayerChange> m_changes
        {
            get
            {
                Class267<BnetPlayerChange> class2 = base.method_3<Class267<BnetPlayerChange>>("m_changes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

