namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ArcEndSphere")]
    public class ArcEndSphere : MonoBehaviour
    {
        public ArcEndSphere(IntPtr address) : this(address, "ArcEndSphere")
        {
        }

        public ArcEndSphere(IntPtr address, string className) : base(address, className)
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

