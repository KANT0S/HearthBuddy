namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("iTweenCollection")]
    public class iTweenCollection : MonoClass
    {
        public iTweenCollection(IntPtr address) : this(address, "iTweenCollection")
        {
        }

        public iTweenCollection(IntPtr address, string className) : base(address, className)
        {
        }

        public void Add(iTween tween)
        {
            object[] objArray1 = new object[] { tween };
            base.method_8("Add", objArray1);
        }

        public void CleanUp()
        {
            base.method_8("CleanUp", Array.Empty<object>());
        }

        public iTweenIterator GetIterator()
        {
            return base.method_11<iTweenIterator>("GetIterator", Array.Empty<object>());
        }

        public void Remove(iTween tween)
        {
            object[] objArray1 = new object[] { tween };
            base.method_8("Remove", objArray1);
        }

        public int Count
        {
            get
            {
                return base.method_2<int>("Count");
            }
        }

        public int DeletedCount
        {
            get
            {
                return base.method_2<int>("DeletedCount");
            }
        }

        public int LastIndex
        {
            get
            {
                return base.method_2<int>("LastIndex");
            }
        }

        public List<iTween> Tweens
        {
            get
            {
                Class247<iTween> class2 = base.method_3<Class247<iTween>>("Tweens");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

