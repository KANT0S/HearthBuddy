namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RotateOverTimePingPong")]
    public class RotateOverTimePingPong : MonoBehaviour
    {
        public RotateOverTimePingPong(IntPtr address) : this(address, "RotateOverTimePingPong")
        {
        }

        public RotateOverTimePingPong(IntPtr address, string className) : base(address, className)
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

        public float RotateRangeXmax
        {
            get
            {
                return base.method_2<float>("RotateRangeXmax");
            }
        }

        public float RotateRangeXmin
        {
            get
            {
                return base.method_2<float>("RotateRangeXmin");
            }
        }

        public float RotateRangeYmax
        {
            get
            {
                return base.method_2<float>("RotateRangeYmax");
            }
        }

        public float RotateRangeYmin
        {
            get
            {
                return base.method_2<float>("RotateRangeYmin");
            }
        }

        public float RotateRangeZmax
        {
            get
            {
                return base.method_2<float>("RotateRangeZmax");
            }
        }

        public float RotateRangeZmin
        {
            get
            {
                return base.method_2<float>("RotateRangeZmin");
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

