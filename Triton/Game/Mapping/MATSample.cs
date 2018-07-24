namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MATSample")]
    public class MATSample : MonoBehaviour
    {
        public MATSample(IntPtr address) : this(address, "MATSample")
        {
        }

        public MATSample(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static string getSampleiTunesIAPReceipt()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "MATSample", "getSampleiTunesIAPReceipt", Array.Empty<object>());
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }
    }
}

