namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ArcEnd")]
    public class ArcEnd : MonoBehaviour
    {
        public ArcEnd(IntPtr address) : this(address, "ArcEnd")
        {
        }

        public ArcEnd(IntPtr address, string className) : base(address, className)
        {
        }

        public void FixedUpdate()
        {
            base.method_8("FixedUpdate", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public Vector3 s
        {
            get
            {
                return base.method_2<Vector3>("s");
            }
        }
    }
}

