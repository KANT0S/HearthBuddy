namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MaterialReplacementExclude")]
    public class MaterialReplacementExclude : MonoBehaviour
    {
        public MaterialReplacementExclude(IntPtr address) : this(address, "MaterialReplacementExclude")
        {
        }

        public MaterialReplacementExclude(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }
    }
}

