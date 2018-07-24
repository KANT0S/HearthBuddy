namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ActivateToggle")]
    public class ActivateToggle : MonoBehaviour
    {
        public ActivateToggle(IntPtr address) : this(address, "ActivateToggle")
        {
        }

        public ActivateToggle(IntPtr address, string className) : base(address, className)
        {
        }

        public void ToggleActive()
        {
            base.method_8("ToggleActive", Array.Empty<object>());
        }

        public GameObject obj
        {
            get
            {
                return base.method_3<GameObject>("obj");
            }
        }

        public bool onoff
        {
            get
            {
                return base.method_2<bool>("onoff");
            }
        }
    }
}

