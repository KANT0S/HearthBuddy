namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Tournament")]
    public class Tournament : MonoClass
    {
        public Tournament(IntPtr address) : this(address, "Tournament")
        {
        }

        public Tournament(IntPtr address, string className) : base(address, className)
        {
        }

        public static Tournament Get()
        {
            return MonoClass.smethod_15<Tournament>(TritonHs.MainAssemblyPath, "", "Tournament", "Get", Array.Empty<object>());
        }

        public static void Init()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Tournament", "Init");
        }

        public void NotifyOfBoxTransitionStart()
        {
            base.method_8("NotifyOfBoxTransitionStart", Array.Empty<object>());
        }

        public void OnBoxTransitionFinished(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnBoxTransitionFinished", objArray1);
        }
    }
}

