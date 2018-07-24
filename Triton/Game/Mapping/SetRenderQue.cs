namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("SetRenderQue")]
    public class SetRenderQue : MonoBehaviour
    {
        public SetRenderQue(IntPtr address) : this(address, "SetRenderQue")
        {
        }

        public SetRenderQue(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public bool includeChildren
        {
            get
            {
                return base.method_2<bool>("includeChildren");
            }
        }

        public int queue
        {
            get
            {
                return base.method_2<int>("queue");
            }
        }

        public List<int> queues
        {
            get
            {
                Class246<int> class2 = base.method_3<Class246<int>>("queues");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

