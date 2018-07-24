namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ShakeObject")]
    public class ShakeObject : MonoBehaviour
    {
        public ShakeObject(IntPtr address) : this(address, "ShakeObject")
        {
        }

        public ShakeObject(IntPtr address, string className) : base(address, className)
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

        public float amount
        {
            get
            {
                return base.method_2<float>("amount");
            }
        }

        public Vector3 orgPos
        {
            get
            {
                return base.method_2<Vector3>("orgPos");
            }
        }
    }
}

