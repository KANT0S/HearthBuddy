namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DefeatScreen")]
    public class DefeatScreen : EndGameScreen
    {
        public DefeatScreen(IntPtr address) : this(address, "DefeatScreen")
        {
        }

        public DefeatScreen(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ShowStandardFlow()
        {
            base.method_8("ShowStandardFlow", Array.Empty<object>());
        }
    }
}

