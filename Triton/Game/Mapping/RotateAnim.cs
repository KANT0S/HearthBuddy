namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RotateAnim")]
    public class RotateAnim : MonoBehaviour
    {
        public RotateAnim(IntPtr address) : this(address, "RotateAnim")
        {
        }

        public RotateAnim(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetTargetRotation(Vector3 target, float timeValueInput)
        {
            object[] objArray1 = new object[] { target, timeValueInput };
            base.method_8("SetTargetRotation", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool gogogo
        {
            get
            {
                return base.method_2<bool>("gogogo");
            }
        }

        public float startingAngle
        {
            get
            {
                return base.method_2<float>("startingAngle");
            }
        }

        public Quaternion targetRotation
        {
            get
            {
                return base.method_2<Quaternion>("targetRotation");
            }
        }

        public float timePassed
        {
            get
            {
                return base.method_2<float>("timePassed");
            }
        }

        public float timeValue
        {
            get
            {
                return base.method_2<float>("timeValue");
            }
        }
    }
}

