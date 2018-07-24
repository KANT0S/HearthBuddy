namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Reset")]
    public class Reset : Scene
    {
        public Reset(IntPtr address) : this(address, "Reset")
        {
        }

        public Reset(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }
    }
}

