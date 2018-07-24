namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RotateOverTime")]
    public class RotateOverTime : MonoBehaviour
    {
        public RotateOverTime(IntPtr address) : this(address, "RotateOverTime")
        {
        }

        public RotateOverTime(IntPtr address, string className) : base(address, className)
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

        public bool RandomStartX
        {
            get
            {
                return base.method_2<bool>("RandomStartX");
            }
        }

        public bool RandomStartY
        {
            get
            {
                return base.method_2<bool>("RandomStartY");
            }
        }

        public bool RandomStartZ
        {
            get
            {
                return base.method_2<bool>("RandomStartZ");
            }
        }

        public float RotateSpeedX
        {
            get
            {
                return base.method_2<float>("RotateSpeedX");
            }
        }

        public float RotateSpeedY
        {
            get
            {
                return base.method_2<float>("RotateSpeedY");
            }
        }

        public float RotateSpeedZ
        {
            get
            {
                return base.method_2<float>("RotateSpeedZ");
            }
        }
    }
}

