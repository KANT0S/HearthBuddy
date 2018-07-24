namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("TagSet")]
    public class TagSet : MonoClass
    {
        public TagSet(IntPtr address) : this(address, "TagSet")
        {
        }

        public TagSet(IntPtr address, string className) : base(address, className)
        {
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public TagDeltaSet CreateDeltas(TagSet comp)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { comp };
            return base.method_15<TagDeltaSet>("CreateDeltas", enumArray1, objArray1);
        }

        public int GetTag(int tag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag };
            return base.method_10<int>("GetTag", enumArray1, objArray1);
        }

        public int GetTag(GAME_TAG enumTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { enumTag };
            return base.method_10<int>("GetTag", enumArray1, objArray1);
        }

        public bool HasTag(int tag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag };
            return base.method_10<bool>("HasTag", enumArray1, objArray1);
        }

        public void Replace(TagSet sourceSet)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { sourceSet };
            base.method_9("Replace", enumArray1, objArray1);
        }

        public void SetTag(int tag, int tagValue)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag, tagValue };
            base.method_9("SetTag", enumArray1, objArray1);
        }

        public void SetTag(GAME_TAG tag, int tagValue)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag, tagValue };
            base.method_9("SetTag", enumArray1, objArray1);
        }
    }
}

