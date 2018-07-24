namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Disable_LowQuality")]
    public class Disable_LowQuality : MonoBehaviour
    {
        public Disable_LowQuality(IntPtr address) : this(address, "Disable_LowQuality")
        {
        }

        public Disable_LowQuality(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }
    }
}

