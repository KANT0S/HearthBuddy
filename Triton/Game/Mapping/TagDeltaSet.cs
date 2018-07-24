namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("TagDeltaSet")]
    public class TagDeltaSet : MonoClass
    {
        public TagDeltaSet(IntPtr address) : this(address, "TagDeltaSet")
        {
        }

        public TagDeltaSet(IntPtr address, string className) : base(address, className)
        {
        }

        public void Add(int tag, int prev, int curr)
        {
            object[] objArray1 = new object[] { tag, prev, curr };
            base.method_9("Add", new Class272.Enum20[] { Class272.Enum20.I4 }, objArray1);
        }

        public List<TagDelta> GetList()
        {
            Class267<TagDelta> class2 = base.method_14<Class267<TagDelta>>("GetList", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int NewValue(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_11<int>("NewValue", objArray1);
        }

        public int OldValue(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_11<int>("OldValue", objArray1);
        }

        public int Size()
        {
            return base.method_11<int>("Size", Array.Empty<object>());
        }

        public int Tag(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_11<int>("Tag", objArray1);
        }

        public List<TagDelta> m_deltas
        {
            get
            {
                Class267<TagDelta> class2 = base.method_3<Class267<TagDelta>>("m_deltas");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

