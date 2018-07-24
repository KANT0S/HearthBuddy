namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CreateButton")]
    public class CreateButton : CraftingButton
    {
        public CreateButton(IntPtr address) : this(address, "CreateButton")
        {
        }

        public CreateButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void EnableButton()
        {
            base.method_8("EnableButton", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }
    }
}

