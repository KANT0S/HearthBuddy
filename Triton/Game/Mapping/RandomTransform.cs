namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RandomTransform")]
    public class RandomTransform : MonoBehaviour
    {
        public RandomTransform(IntPtr address) : this(address, "RandomTransform")
        {
        }

        public RandomTransform(IntPtr address, string className) : base(address, className)
        {
        }

        public void Apply()
        {
            base.method_8("Apply", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public bool m_applyOnStart
        {
            get
            {
                return base.method_2<bool>("m_applyOnStart");
            }
        }

        public Vector3 positionMax
        {
            get
            {
                return base.method_2<Vector3>("positionMax");
            }
        }

        public Vector3 positionMin
        {
            get
            {
                return base.method_2<Vector3>("positionMin");
            }
        }

        public Vector3 rotationMax
        {
            get
            {
                return base.method_2<Vector3>("rotationMax");
            }
        }

        public Vector3 rotationMin
        {
            get
            {
                return base.method_2<Vector3>("rotationMin");
            }
        }

        public Vector3 scaleMax
        {
            get
            {
                return base.method_2<Vector3>("scaleMax");
            }
        }

        public Vector3 scaleMin
        {
            get
            {
                return base.method_2<Vector3>("scaleMin");
            }
        }
    }
}

