namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CameraUtils")]
    public class CameraUtils : MonoClass
    {
        public CameraUtils(IntPtr address) : this(address, "CameraUtils")
        {
        }

        public CameraUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static Plane CreateBottomPlane(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            return MonoClass.smethod_14<Plane>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateBottomPlane", objArray1);
        }

        public static Rect CreateGUIScreenRect(Camera camera, Component topLeft, Component bottomRight)
        {
            object[] objArray1 = new object[] { camera, topLeft, bottomRight };
            return MonoClass.smethod_11<Rect>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateGUIScreenRect", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Rect CreateGUIScreenRect(Camera camera, Component topLeft, GameObject bottomRight)
        {
            object[] objArray1 = new object[] { camera, topLeft, bottomRight };
            return MonoClass.smethod_11<Rect>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateGUIScreenRect", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Rect CreateGUIScreenRect(Camera camera, GameObject topLeft, Component bottomRight)
        {
            object[] objArray1 = new object[] { camera, topLeft, bottomRight };
            return MonoClass.smethod_11<Rect>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateGUIScreenRect", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Rect CreateGUIScreenRect(Camera camera, GameObject topLeft, GameObject bottomRight)
        {
            object[] objArray1 = new object[] { camera, topLeft, bottomRight };
            return MonoClass.smethod_11<Rect>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateGUIScreenRect", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Rect CreateGUIScreenRect(Camera camera, Vector3 worldTopLeft, Vector3 worldBottomRight)
        {
            object[] objArray1 = new object[] { camera, worldTopLeft, worldBottomRight };
            return MonoClass.smethod_11<Rect>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateGUIScreenRect", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Rect CreateGUIViewportRect(Camera camera, Component topLeft, Component bottomRight)
        {
            object[] objArray1 = new object[] { camera, topLeft, bottomRight };
            return MonoClass.smethod_11<Rect>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateGUIViewportRect", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Rect CreateGUIViewportRect(Camera camera, Component topLeft, GameObject bottomRight)
        {
            object[] objArray1 = new object[] { camera, topLeft, bottomRight };
            return MonoClass.smethod_11<Rect>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateGUIViewportRect", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Rect CreateGUIViewportRect(Camera camera, GameObject topLeft, Component bottomRight)
        {
            object[] objArray1 = new object[] { camera, topLeft, bottomRight };
            return MonoClass.smethod_11<Rect>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateGUIViewportRect", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Rect CreateGUIViewportRect(Camera camera, GameObject topLeft, GameObject bottomRight)
        {
            object[] objArray1 = new object[] { camera, topLeft, bottomRight };
            return MonoClass.smethod_11<Rect>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateGUIViewportRect", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Rect CreateGUIViewportRect(Camera camera, Vector3 worldTopLeft, Vector3 worldBottomRight)
        {
            object[] objArray1 = new object[] { camera, worldTopLeft, worldBottomRight };
            return MonoClass.smethod_11<Rect>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateGUIViewportRect", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static GameObject CreateInputBlocker(Camera camera)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { camera };
            return MonoClass.smethod_16<GameObject>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateInputBlocker", enumArray1, objArray1);
        }

        public static GameObject CreateInputBlocker(Camera camera, string name)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.String };
            object[] objArray1 = new object[] { camera, name };
            return MonoClass.smethod_16<GameObject>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateInputBlocker", enumArray1, objArray1);
        }

        public static GameObject CreateInputBlocker(Camera camera, string name, Component parent)
        {
            object[] objArray1 = new object[] { camera, name, parent };
            return MonoClass.smethod_16<GameObject>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateInputBlocker", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static GameObject CreateInputBlocker(Camera camera, string name, Component parent, float worldOffset)
        {
            object[] objArray1 = new object[] { camera, name, parent, worldOffset };
            return MonoClass.smethod_16<GameObject>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateInputBlocker", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static GameObject CreateInputBlocker(Camera camera, string name, Component parent, Component relative)
        {
            object[] objArray1 = new object[] { camera, name, parent, relative };
            return MonoClass.smethod_16<GameObject>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateInputBlocker", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static GameObject CreateInputBlocker(Camera camera, string name, Component parent, Component relative, float worldOffset)
        {
            object[] objArray1 = new object[] { camera, name, parent, relative, worldOffset };
            return MonoClass.smethod_16<GameObject>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateInputBlocker", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Plane CreateTopPlane(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            return MonoClass.smethod_14<Plane>(TritonHs.MainAssemblyPath, "", "CameraUtils", "CreateTopPlane", objArray1);
        }

        public static Camera FindFirstByLayer(int layer)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { layer };
            return MonoClass.smethod_16<Camera>(TritonHs.MainAssemblyPath, "", "CameraUtils", "FindFirstByLayer", enumArray1, objArray1);
        }

        public static Camera FindFirstByLayer(GameLayer layer)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { layer };
            return MonoClass.smethod_16<Camera>(TritonHs.MainAssemblyPath, "", "CameraUtils", "FindFirstByLayer", enumArray1, objArray1);
        }

        public static Camera FindFirstByLayerMask(LayerMask mask)
        {
            object[] objArray1 = new object[] { mask };
            return MonoClass.smethod_15<Camera>(TritonHs.MainAssemblyPath, "", "CameraUtils", "FindFirstByLayerMask", objArray1);
        }

        public static Camera FindFullScreenEffectsCamera(bool activeOnly)
        {
            object[] objArray1 = new object[] { activeOnly };
            return MonoClass.smethod_15<Camera>(TritonHs.MainAssemblyPath, "", "CameraUtils", "FindFullScreenEffectsCamera", objArray1);
        }

        public static Bounds GetFarClipBounds(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            return MonoClass.smethod_14<Bounds>(TritonHs.MainAssemblyPath, "", "CameraUtils", "GetFarClipBounds", objArray1);
        }

        public static Bounds GetNearClipBounds(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            return MonoClass.smethod_14<Bounds>(TritonHs.MainAssemblyPath, "", "CameraUtils", "GetNearClipBounds", objArray1);
        }

        public static Vector3 GetNearestPosInFrontOfCamera(Camera camera, float worldOffset)
        {
            object[] objArray1 = new object[] { camera, worldOffset };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "CameraUtils", "GetNearestPosInFrontOfCamera", objArray1);
        }

        public static Vector3 GetPosInFrontOfCamera(Camera camera, float worldDistance)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { camera, worldDistance };
            return MonoClass.smethod_11<Vector3>(TritonHs.MainAssemblyPath, "", "CameraUtils", "GetPosInFrontOfCamera", enumArray1, objArray1);
        }

        public static Vector3 GetPosInFrontOfCamera(Camera camera, Vector3 worldPoint)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { camera, worldPoint };
            return MonoClass.smethod_11<Vector3>(TritonHs.MainAssemblyPath, "", "CameraUtils", "GetPosInFrontOfCamera", enumArray1, objArray1);
        }

        public static Vector3 GetPosInFrontOfCamera(Camera camera, Vector3 worldPoint, float worldOffset)
        {
            object[] objArray1 = new object[] { camera, worldPoint, worldOffset };
            return MonoClass.smethod_11<Vector3>(TritonHs.MainAssemblyPath, "", "CameraUtils", "GetPosInFrontOfCamera", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static float ScreenToWorldDist(Camera camera, float screenDist)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { camera, screenDist };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "CameraUtils", "ScreenToWorldDist", enumArray1, objArray1);
        }

        public static float ScreenToWorldDist(Camera camera, float screenDist, float worldDist)
        {
            object[] objArray1 = new object[] { camera, screenDist, worldDist };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "CameraUtils", "ScreenToWorldDist", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static float ScreenToWorldDist(Camera camera, float screenDist, Vector3 worldPoint)
        {
            object[] objArray1 = new object[] { camera, screenDist, worldPoint };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "CameraUtils", "ScreenToWorldDist", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }
    }
}

