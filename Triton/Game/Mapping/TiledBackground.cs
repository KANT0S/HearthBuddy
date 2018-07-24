namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TiledBackground")]
    public class TiledBackground : MonoBehaviour
    {
        public TiledBackground(IntPtr address) : this(address, "TiledBackground")
        {
        }

        public TiledBackground(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void SetBounds(Bounds bounds)
        {
            object[] objArray1 = new object[] { bounds };
            base.method_8("SetBounds", objArray1);
        }

        public float Depth
        {
            get
            {
                return base.method_2<float>("Depth");
            }
        }

        public Vector2 Offset
        {
            get
            {
                return base.method_11<Vector2>("get_Offset", Array.Empty<object>());
            }
        }
    }
}

