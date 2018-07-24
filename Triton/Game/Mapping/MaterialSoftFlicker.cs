namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MaterialSoftFlicker")]
    public class MaterialSoftFlicker : MonoBehaviour
    {
        public MaterialSoftFlicker(IntPtr address) : this(address, "MaterialSoftFlicker")
        {
        }

        public MaterialSoftFlicker(IntPtr address, string className) : base(address, className)
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

        public Color m_color
        {
            get
            {
                return base.method_2<Color>("m_color");
            }
        }

        public float m_timeScale
        {
            get
            {
                return base.method_2<float>("m_timeScale");
            }
        }

        public float maxIntensity
        {
            get
            {
                return base.method_2<float>("maxIntensity");
            }
        }

        public float minIntensity
        {
            get
            {
                return base.method_2<float>("minIntensity");
            }
        }

        public float random
        {
            get
            {
                return base.method_2<float>("random");
            }
        }
    }
}

