namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TournamentScene")]
    public class TournamentScene : PlayGameScene
    {
        public TournamentScene(IntPtr address) : this(address, "TournamentScene")
        {
        }

        public TournamentScene(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static TournamentScene Get()
        {
            return MonoClass.smethod_15<TournamentScene>(TritonHs.MainAssemblyPath, "", "TournamentScene", "Get", Array.Empty<object>());
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

