namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetEventMgr")]
    public class BnetEventMgr : MonoClass
    {
        public BnetEventMgr(IntPtr address) : this(address, "BnetEventMgr")
        {
        }

        public BnetEventMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public static BnetEventMgr Get()
        {
            return MonoClass.smethod_15<BnetEventMgr>(TritonHs.MainAssemblyPath, "", "BnetEventMgr", "Get", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public void Shutdown()
        {
            base.method_8("Shutdown", Array.Empty<object>());
        }
    }
}

