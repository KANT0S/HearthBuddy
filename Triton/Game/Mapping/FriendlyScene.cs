namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FriendlyScene")]
    public class FriendlyScene : PlayGameScene
    {
        public FriendlyScene(IntPtr address) : this(address, "FriendlyScene")
        {
        }

        public FriendlyScene(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static FriendlyScene Get()
        {
            return MonoClass.smethod_15<FriendlyScene>(TritonHs.MainAssemblyPath, "", "FriendlyScene", "Get", Array.Empty<object>());
        }

        public string GetScreenName()
        {
            return base.method_13("GetScreenName", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }
    }
}

