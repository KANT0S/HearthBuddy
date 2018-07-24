namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Transform")]
    public class Transform : Component
    {
        public Transform(IntPtr address) : base(address, "Transform")
        {
        }

        public Vector3 TransformPoint(Vector3 point)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { point };
            return base.method_10<Vector3>("TransformPoint", enumArray1, objArray1);
        }

        public Vector3 LocalPosition
        {
            get
            {
                return base.method_11<Vector3>("get_localPosition", Array.Empty<object>());
            }
        }

        public Vector3 LocalScale
        {
            get
            {
                return base.method_11<Vector3>("get_localScale", Array.Empty<object>());
            }
        }

        public Transform Parent
        {
            get
            {
                return base.method_14<Transform>("get_parent", Array.Empty<object>());
            }
        }

        public Vector3 Position
        {
            get
            {
                return base.method_11<Vector3>("get_position", Array.Empty<object>());
            }
        }
    }
}

