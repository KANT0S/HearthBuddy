namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Camera")]
    public class Camera : Behaviour
    {
        public Camera(IntPtr address) : base(address, "Camera")
        {
        }

        public Vector3 ScreenToViewportPoint(Vector3 position)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { position };
            return base.method_10<Vector3>("ScreenToViewportPoint", enumArray1, objArray1);
        }

        public Vector3 ScreenToWorldPoint(Vector3 position)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { position };
            return base.method_10<Vector3>("ScreenToWorldPoint", enumArray1, objArray1);
        }

        public Vector3 ViewportToScreenPoint(Vector3 position)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { position };
            return base.method_10<Vector3>("ViewportToScreenPoint", enumArray1, objArray1);
        }

        public Vector3 ViewportToWorldPoint(Vector3 position)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { position };
            return base.method_10<Vector3>("ViewportToWorldPoint", enumArray1, objArray1);
        }

        public Vector3 WorldToScreenPoint(Vector3 position)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { position };
            return base.method_10<Vector3>("WorldToScreenPoint", enumArray1, objArray1);
        }

        public Vector3 WorldToViewportPoint(Vector3 position)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { position };
            return base.method_10<Vector3>("WorldToViewportPoint", enumArray1, objArray1);
        }

        public static Camera Main
        {
            get
            {
                return MonoClass.smethod_15<Camera>(TritonHs.UnityEngineAssemblyPath, "UnityEngine", "Camera", "get_main", Array.Empty<object>());
            }
        }

        public float NearClipPlane
        {
            get
            {
                return base.method_11<float>("get_nearClipPlane", Array.Empty<object>());
            }
        }
    }
}

