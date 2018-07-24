namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckRule_IsClassCardOrNeutral")]
    public class DeckRule_IsClassCardOrNeutral : DeckRule
    {
        public DeckRule_IsClassCardOrNeutral(IntPtr address) : this(address, "DeckRule_IsClassCardOrNeutral")
        {
        }

        public DeckRule_IsClassCardOrNeutral(IntPtr address, string className) : base(address, className)
        {
        }

        public bool Filter(EntityDef def)
        {
            object[] objArray1 = new object[] { def };
            return base.method_11<bool>("Filter", objArray1);
        }
    }
}

