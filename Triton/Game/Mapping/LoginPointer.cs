namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LoginPointer")]
    public class LoginPointer : PegUIElement
    {
        public LoginPointer(IntPtr address) : this(address, "LoginPointer")
        {
        }

        public LoginPointer(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }
    }
}

