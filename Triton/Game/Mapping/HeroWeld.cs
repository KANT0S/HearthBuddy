namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HeroWeld")]
    public class HeroWeld : MonoBehaviour
    {
        public HeroWeld(IntPtr address) : this(address, "HeroWeld")
        {
        }

        public HeroWeld(IntPtr address, string className) : base(address, className)
        {
        }

        public void DoAnim()
        {
            base.method_8("DoAnim", Array.Empty<object>());
        }
    }
}

