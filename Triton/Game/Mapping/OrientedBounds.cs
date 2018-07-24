namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("OrientedBounds")]
    public class OrientedBounds : MonoClass
    {
        public OrientedBounds(IntPtr address) : this(address, "OrientedBounds")
        {
        }

        public OrientedBounds(IntPtr address, string className) : base(address, className)
        {
        }

        public Vector3 GetTrueCenterPosition()
        {
            return base.method_11<Vector3>("GetTrueCenterPosition", Array.Empty<object>());
        }

        public Vector3 CenterOffset
        {
            get
            {
                return base.method_2<Vector3>("CenterOffset");
            }
        }

        public List<Vector3> Extents
        {
            get
            {
                Class246<Vector3> class2 = base.method_3<Class246<Vector3>>("Extents");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 Origin
        {
            get
            {
                return base.method_2<Vector3>("Origin");
            }
        }
    }
}

