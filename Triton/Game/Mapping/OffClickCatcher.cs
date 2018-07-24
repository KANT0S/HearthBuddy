namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("OffClickCatcher")]
    public class OffClickCatcher : PegUIElement
    {
        public OffClickCatcher(IntPtr address) : this(address, "OffClickCatcher")
        {
        }

        public OffClickCatcher(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void OnRightClick()
        {
            base.method_8("OnRightClick", Array.Empty<object>());
        }
    }
}

