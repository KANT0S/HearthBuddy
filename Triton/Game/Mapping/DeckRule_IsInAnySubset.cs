namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckRule_IsInAnySubset")]
    public class DeckRule_IsInAnySubset : DeckRule
    {
        public DeckRule_IsInAnySubset(IntPtr address) : this(address, "DeckRule_IsInAnySubset")
        {
        }

        public DeckRule_IsInAnySubset(IntPtr address, string className) : base(address, className)
        {
        }

        public bool Filter(EntityDef def)
        {
            object[] objArray1 = new object[] { def };
            return base.method_11<bool>("Filter", objArray1);
        }
    }
}

