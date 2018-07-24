namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PegUICustomBehavior")]
    public class PegUICustomBehavior : MonoBehaviour
    {
        public PegUICustomBehavior(IntPtr address) : this(address, "PegUICustomBehavior")
        {
        }

        public PegUICustomBehavior(IntPtr address, string className) : base(address, className)
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

        public bool UpdateUI()
        {
            return base.method_11<bool>("UpdateUI", Array.Empty<object>());
        }
    }
}

