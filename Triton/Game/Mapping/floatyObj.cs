namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("floatyObj")]
    public class floatyObj : MonoBehaviour
    {
        public floatyObj(IntPtr address) : this(address, "floatyObj")
        {
        }

        public floatyObj(IntPtr address, string className) : base(address, className)
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

        public float frequencyMax
        {
            get
            {
                return base.method_2<float>("frequencyMax");
            }
        }

        public float frequencyMin
        {
            get
            {
                return base.method_2<float>("frequencyMin");
            }
        }

        public float m_interval
        {
            get
            {
                return base.method_2<float>("m_interval");
            }
        }

        public float magnitude
        {
            get
            {
                return base.method_2<float>("magnitude");
            }
        }
    }
}

