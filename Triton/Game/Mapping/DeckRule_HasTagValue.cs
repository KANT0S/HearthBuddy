namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckRule_HasTagValue")]
    public class DeckRule_HasTagValue : DeckRule
    {
        public DeckRule_HasTagValue(IntPtr address) : this(address, "DeckRule_HasTagValue")
        {
        }

        public DeckRule_HasTagValue(IntPtr address, string className) : base(address, className)
        {
        }

        public bool Filter(EntityDef def)
        {
            object[] objArray1 = new object[] { def };
            return base.method_11<bool>("Filter", objArray1);
        }
    }
}

