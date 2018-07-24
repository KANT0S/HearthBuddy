namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BattleNetClient")]
    public class BattleNetClient : MonoClass
    {
        public BattleNetClient(IntPtr address) : this(address, "BattleNetClient")
        {
        }

        public BattleNetClient(IntPtr address, string className) : base(address, className)
        {
        }

        public static void quitHearthstoneAndRun()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "BattleNetClient", "quitHearthstoneAndRun");
        }

        public static bool launchedHearthstone
        {
            get
            {
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BattleNetClient", "get_launchedHearthstone", Array.Empty<object>());
            }
        }

        public static bool needsToRun
        {
            get
            {
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BattleNetClient", "get_needsToRun", Array.Empty<object>());
            }
        }

        public static bool usedOnThisPlatform
        {
            get
            {
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BattleNetClient", "get_usedOnThisPlatform", Array.Empty<object>());
            }
        }
    }
}

