namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BugReporter")]
    public class BugReporter : MonoClass
    {
        public BugReporter(IntPtr address) : this(address, "BugReporter")
        {
        }

        public BugReporter(IntPtr address, string className) : base(address, className)
        {
        }

        public static BugReporter Get()
        {
            return MonoClass.smethod_15<BugReporter>(TritonHs.MainAssemblyPath, "", "BugReporter", "Get", Array.Empty<object>());
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }
    }
}

