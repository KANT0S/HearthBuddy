namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("IncrementRenderQueue")]
    public class IncrementRenderQueue : MonoBehaviour
    {
        public IncrementRenderQueue(IntPtr address) : this(address, "IncrementRenderQueue")
        {
        }

        public IncrementRenderQueue(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }
    }
}

