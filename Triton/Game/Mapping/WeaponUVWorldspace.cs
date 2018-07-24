namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("WeaponUVWorldspace")]
    public class WeaponUVWorldspace : MonoBehaviour
    {
        public WeaponUVWorldspace(IntPtr address) : this(address, "WeaponUVWorldspace")
        {
        }

        public WeaponUVWorldspace(IntPtr address, string className) : base(address, className)
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

        public float xOffset
        {
            get
            {
                return base.method_2<float>("xOffset");
            }
        }

        public float yOffset
        {
            get
            {
                return base.method_2<float>("yOffset");
            }
        }
    }
}

