namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TransformUtil")]
    public class TransformUtil : MonoClass
    {
        public TransformUtil(IntPtr address) : this(address, "TransformUtil")
        {
        }

        public TransformUtil(IntPtr address, string className) : base(address, className)
        {
        }

        public static void AttachAndPreserveLocalTransform(Transform child, Transform parent)
        {
            object[] objArray1 = new object[] { child, parent };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "TransformUtil", "AttachAndPreserveLocalTransform", objArray1);
        }

        public static bool CanComputeOrientedWorldBounds(GameObject go, bool includeAllChildren)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { go, includeAllChildren };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "TransformUtil", "CanComputeOrientedWorldBounds", enumArray1, objArray1);
        }

        public static bool CanComputeOrientedWorldBounds(GameObject go, bool includeUberText, bool includeAllChildren)
        {
            object[] objArray1 = new object[] { go, includeUberText, includeAllChildren };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "TransformUtil", "CanComputeOrientedWorldBounds", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, bool includeAllChildren)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { go, includeAllChildren };
            return MonoClass.smethod_16<OrientedBounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeOrientedWorldBounds", enumArray1, objArray1);
        }

        public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, bool includeUberText, bool includeAllChildren)
        {
            object[] objArray1 = new object[] { go, includeUberText, includeAllChildren };
            return MonoClass.smethod_16<OrientedBounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeOrientedWorldBounds", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, Vector3 minLocalPadding, Vector3 maxLocalPadding, bool includeAllChildren)
        {
            object[] objArray1 = new object[] { go, minLocalPadding, maxLocalPadding, includeAllChildren };
            return MonoClass.smethod_16<OrientedBounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeOrientedWorldBounds", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, bool includeUberText, Vector3 minLocalPadding, Vector3 maxLocalPadding, bool includeAllChildren)
        {
            object[] objArray1 = new object[] { go, includeUberText, minLocalPadding, maxLocalPadding, includeAllChildren };
            return MonoClass.smethod_16<OrientedBounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeOrientedWorldBounds", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Bounds ComputeSetPointBounds(Component c)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { c };
            return MonoClass.smethod_11<Bounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeSetPointBounds", enumArray1, objArray1);
        }

        public static Bounds ComputeSetPointBounds(GameObject go)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_11<Bounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeSetPointBounds", enumArray1, objArray1);
        }

        public static Bounds ComputeSetPointBounds(Component c, bool includeInactive)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { c, includeInactive };
            return MonoClass.smethod_11<Bounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeSetPointBounds", enumArray1, objArray1);
        }

        public static Bounds ComputeSetPointBounds(GameObject go, bool includeInactive)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { go, includeInactive };
            return MonoClass.smethod_11<Bounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeSetPointBounds", enumArray1, objArray1);
        }

        public static Vector2 ComputeUnitAnchor(Bounds bounds, Vector2 worldPoint)
        {
            object[] objArray1 = new object[] { bounds, worldPoint };
            return MonoClass.smethod_14<Vector2>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeUnitAnchor", objArray1);
        }

        public static Vector3 ComputeWorldPoint(Bounds bounds, Vector3 selfUnitAnchor)
        {
            object[] objArray1 = new object[] { bounds, selfUnitAnchor };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeWorldPoint", objArray1);
        }

        public static Vector3 ComputeWorldScale(Component c)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { c };
            return MonoClass.smethod_11<Vector3>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeWorldScale", enumArray1, objArray1);
        }

        public static Vector3 ComputeWorldScale(GameObject go)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_11<Vector3>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ComputeWorldScale", enumArray1, objArray1);
        }

        public static void CopyLocal(Component destination, Component source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyLocal", enumArray1, objArray1);
        }

        public static void CopyLocal(Component destination, GameObject source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyLocal", enumArray1, objArray1);
        }

        public static void CopyLocal(Component destination, TransformProps source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyLocal", enumArray1, objArray1);
        }

        public static void CopyLocal(GameObject destination, Component source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyLocal", enumArray1, objArray1);
        }

        public static void CopyLocal(GameObject destination, GameObject source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyLocal", enumArray1, objArray1);
        }

        public static void CopyLocal(GameObject destination, TransformProps source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyLocal", enumArray1, objArray1);
        }

        public static void CopyLocal(TransformProps destination, Component source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyLocal", enumArray1, objArray1);
        }

        public static void CopyLocal(TransformProps destination, GameObject source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyLocal", enumArray1, objArray1);
        }

        public static void CopyWorld(Component destination, Component source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorld", enumArray1, objArray1);
        }

        public static void CopyWorld(Component destination, GameObject source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorld", enumArray1, objArray1);
        }

        public static void CopyWorld(Component destination, TransformProps source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorld", enumArray1, objArray1);
        }

        public static void CopyWorld(GameObject destination, Component source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorld", enumArray1, objArray1);
        }

        public static void CopyWorld(GameObject destination, GameObject source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorld", enumArray1, objArray1);
        }

        public static void CopyWorld(GameObject destination, TransformProps source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorld", enumArray1, objArray1);
        }

        public static void CopyWorld(TransformProps destination, Component source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorld", enumArray1, objArray1);
        }

        public static void CopyWorld(TransformProps destination, GameObject source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorld", enumArray1, objArray1);
        }

        public static void CopyWorldScale(Component destination, Component source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorldScale", enumArray1, objArray1);
        }

        public static void CopyWorldScale(Component destination, GameObject source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorldScale", enumArray1, objArray1);
        }

        public static void CopyWorldScale(GameObject destination, Component source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorldScale", enumArray1, objArray1);
        }

        public static void CopyWorldScale(GameObject destination, GameObject source)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { destination, source };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "CopyWorldScale", enumArray1, objArray1);
        }

        public static Vector3 Divide(Vector3 v1, Vector3 v2)
        {
            object[] objArray1 = new object[] { v1, v2 };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "TransformUtil", "Divide", objArray1);
        }

        public static Vector3 GetAspectRatioDependentPosition(Vector3 aspect3to2, Vector3 aspect16to9)
        {
            object[] objArray1 = new object[] { aspect3to2, aspect16to9 };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "TransformUtil", "GetAspectRatioDependentPosition", objArray1);
        }

        public static float GetAspectRatioDependentValue(float aspect3to2, float aspect16to9)
        {
            object[] objArray1 = new object[] { aspect3to2, aspect16to9 };
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "TransformUtil", "GetAspectRatioDependentValue", objArray1);
        }

        public static List<Vector3> GetBoundCorners(Vector3 origin, Vector3 xExtent, Vector3 yExtent, Vector3 zExtent)
        {
            object[] objArray1 = new object[] { origin, xExtent, yExtent, zExtent };
            Class246<Vector3> class2 = MonoClass.smethod_15<Class246<Vector3>>(TritonHs.MainAssemblyPath, "", "TransformUtil", "GetBoundCorners", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static Bounds GetBoundsOfChildren(Component c)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { c };
            return MonoClass.smethod_11<Bounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "GetBoundsOfChildren", enumArray1, objArray1);
        }

        public static Bounds GetBoundsOfChildren(GameObject go)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_11<Bounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "GetBoundsOfChildren", enumArray1, objArray1);
        }

        public static Bounds GetBoundsOfChildren(Component c, bool includeInactive)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { c, includeInactive };
            return MonoClass.smethod_11<Bounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "GetBoundsOfChildren", enumArray1, objArray1);
        }

        public static Bounds GetBoundsOfChildren(GameObject go, bool includeInactive)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { go, includeInactive };
            return MonoClass.smethod_11<Bounds>(TritonHs.MainAssemblyPath, "", "TransformUtil", "GetBoundsOfChildren", enumArray1, objArray1);
        }

        public static Vector3 GetUnitAnchor(Anchor anchor)
        {
            object[] objArray1 = new object[] { anchor };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "TransformUtil", "GetUnitAnchor", objArray1);
        }

        public static void Identity(Component c)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { c };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "Identity", enumArray1, objArray1);
        }

        public static void Identity(GameObject go)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { go };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "Identity", enumArray1, objArray1);
        }

        public static Vector3 Multiply(Vector3 v1, Vector3 v2)
        {
            object[] objArray1 = new object[] { v1, v2 };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "TransformUtil", "Multiply", objArray1);
        }

        public static void OrientTo(Component source, Component target)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { source, target };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "OrientTo", enumArray1, objArray1);
        }

        public static void OrientTo(Component source, GameObject target)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { source, target };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "OrientTo", enumArray1, objArray1);
        }

        public static void OrientTo(GameObject source, Component target)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { source, target };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "OrientTo", enumArray1, objArray1);
        }

        public static void OrientTo(GameObject source, GameObject target)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { source, target };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "OrientTo", enumArray1, objArray1);
        }

        public static void OrientTo(Transform source, Transform target)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { source, target };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "OrientTo", enumArray1, objArray1);
        }

        public static void OrientTo(Transform source, Vector3 sourcePosition, Vector3 targetPosition)
        {
            object[] objArray1 = new object[] { source, sourcePosition, targetPosition };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "OrientTo", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static float PhoneAspectRatioScale()
        {
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "TransformUtil", "PhoneAspectRatioScale", Array.Empty<object>());
        }

        public static Vector3 RandomVector3(Vector3 min, Vector3 max)
        {
            object[] objArray1 = new object[] { min, max };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "TransformUtil", "RandomVector3", objArray1);
        }

        public static void SetEulerAngleX(Component c, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetEulerAngleX", enumArray1, objArray1);
        }

        public static void SetEulerAngleX(GameObject go, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetEulerAngleX", enumArray1, objArray1);
        }

        public static void SetEulerAngleY(Component c, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetEulerAngleY", enumArray1, objArray1);
        }

        public static void SetEulerAngleY(GameObject go, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetEulerAngleY", enumArray1, objArray1);
        }

        public static void SetEulerAngleZ(Component c, float z)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetEulerAngleZ", enumArray1, objArray1);
        }

        public static void SetEulerAngleZ(GameObject go, float z)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetEulerAngleZ", enumArray1, objArray1);
        }

        public static void SetLocalEulerAngleX(Component c, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalEulerAngleX", enumArray1, objArray1);
        }

        public static void SetLocalEulerAngleX(GameObject go, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalEulerAngleX", enumArray1, objArray1);
        }

        public static void SetLocalEulerAngleY(Component c, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalEulerAngleY", enumArray1, objArray1);
        }

        public static void SetLocalEulerAngleY(GameObject go, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalEulerAngleY", enumArray1, objArray1);
        }

        public static void SetLocalEulerAngleZ(Component c, float z)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalEulerAngleZ", enumArray1, objArray1);
        }

        public static void SetLocalEulerAngleZ(GameObject go, float z)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalEulerAngleZ", enumArray1, objArray1);
        }

        public static void SetLocalPosX(Component component, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { component, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalPosX", enumArray1, objArray1);
        }

        public static void SetLocalPosX(GameObject go, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalPosX", enumArray1, objArray1);
        }

        public static void SetLocalPosY(Component component, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { component, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalPosY", enumArray1, objArray1);
        }

        public static void SetLocalPosY(GameObject go, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalPosY", enumArray1, objArray1);
        }

        public static void SetLocalPosZ(Component component, float z)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { component, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalPosZ", enumArray1, objArray1);
        }

        public static void SetLocalPosZ(GameObject go, float z)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalPosZ", enumArray1, objArray1);
        }

        public static void SetLocalScaleX(Component component, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { component, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleX", enumArray1, objArray1);
        }

        public static void SetLocalScaleX(GameObject go, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleX", enumArray1, objArray1);
        }

        public static void SetLocalScaleXY(Component component, Vector2 v)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { component, v };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleXY", enumArray1, objArray1);
        }

        public static void SetLocalScaleXY(GameObject go, Vector2 v)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { go, v };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleXY", enumArray1, objArray1);
        }

        public static void SetLocalScaleXY(Component component, float x, float y)
        {
            object[] objArray1 = new object[] { component, x, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleXY", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetLocalScaleXY(GameObject go, float x, float y)
        {
            object[] objArray1 = new object[] { go, x, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleXY", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetLocalScaleXZ(Component component, Vector2 v)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { component, v };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleXZ", enumArray1, objArray1);
        }

        public static void SetLocalScaleXZ(GameObject go, Vector2 v)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { go, v };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleXZ", enumArray1, objArray1);
        }

        public static void SetLocalScaleXZ(Component component, float x, float z)
        {
            object[] objArray1 = new object[] { component, x, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleXZ", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetLocalScaleXZ(GameObject go, float x, float z)
        {
            object[] objArray1 = new object[] { go, x, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleXZ", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetLocalScaleY(Component component, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { component, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleY", enumArray1, objArray1);
        }

        public static void SetLocalScaleY(GameObject go, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleY", enumArray1, objArray1);
        }

        public static void SetLocalScaleYZ(Component component, Vector2 v)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { component, v };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleYZ", enumArray1, objArray1);
        }

        public static void SetLocalScaleYZ(GameObject go, Vector2 v)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { go, v };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleYZ", enumArray1, objArray1);
        }

        public static void SetLocalScaleYZ(Component component, float y, float z)
        {
            object[] objArray1 = new object[] { component, y, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleYZ", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetLocalScaleYZ(GameObject go, float y, float z)
        {
            object[] objArray1 = new object[] { go, y, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleYZ", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetLocalScaleZ(Component component, float z)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { component, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleZ", enumArray1, objArray1);
        }

        public static void SetLocalScaleZ(GameObject go, float z)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetLocalScaleZ", enumArray1, objArray1);
        }

        public static void SetPoint(Component src, Anchor srcAnchor, Component dst, Anchor dstAnchor)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject src, Anchor srcAnchor, Component dst, Anchor dstAnchor)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component src, Anchor srcAnchor, Component dst, Anchor dstAnchor, bool includeInactive)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component src, Anchor srcAnchor, Component dst, Anchor dstAnchor, Vector3 offset)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, offset };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, bool includeInactive)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, Vector3 offset)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, offset };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor, Vector3 offset)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor, offset };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor, Vector3 offset)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor, offset };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject src, Anchor srcAnchor, Component dst, Anchor dstAnchor, bool includeInactive)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject src, Anchor srcAnchor, Component dst, Anchor dstAnchor, Vector3 offset)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, offset };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, bool includeInactive)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, Vector3 offset)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, offset };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor, Vector3 offset)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor, offset };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor, Vector3 offset)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor, offset };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component src, Anchor srcAnchor, Component dst, Anchor dstAnchor, Vector3 offset, bool includeInactive)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, offset, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, Vector3 offset, bool includeInactive)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, offset, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor, Vector3 offset, bool includeInactive)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor, offset, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(Component self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor, Vector3 offset, bool includeInactive)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor, offset, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject src, Anchor srcAnchor, Component dst, Anchor dstAnchor, Vector3 offset, bool includeInactive)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, offset, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, Vector3 offset, bool includeInactive)
        {
            object[] objArray1 = new object[] { src, srcAnchor, dst, dstAnchor, offset, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor, Vector3 offset, bool includeInactive)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor, offset, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor, Vector3 offset, bool includeInactive)
        {
            object[] objArray1 = new object[] { self, selfUnitAnchor, relative, relativeUnitAnchor, offset, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPoint", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetPosX(Component component, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { component, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPosX", enumArray1, objArray1);
        }

        public static void SetPosX(GameObject go, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPosX", enumArray1, objArray1);
        }

        public static void SetPosY(Component component, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { component, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPosY", enumArray1, objArray1);
        }

        public static void SetPosY(GameObject go, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPosY", enumArray1, objArray1);
        }

        public static void SetPosZ(Component component, float z)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { component, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPosZ", enumArray1, objArray1);
        }

        public static void SetPosZ(GameObject go, float z)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, z };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetPosZ", enumArray1, objArray1);
        }

        public static void SetWorldScale(Component destination, Vector3 scale)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { destination, scale };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetWorldScale", enumArray1, objArray1);
        }

        public static void SetWorldScale(GameObject destination, Vector3 scale)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { destination, scale };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "TransformUtil", "SetWorldScale", enumArray1, objArray1);
        }

        public static Vector3 Vector3Reciprocal(Vector3 source)
        {
            object[] objArray1 = new object[] { source };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "TransformUtil", "Vector3Reciprocal", objArray1);
        }

        public static float ASPECT_RANGE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TransformUtil", "ASPECT_RANGE");
            }
        }

        public static float MAX_PHONE_ASPECT_RATIO
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TransformUtil", "MAX_PHONE_ASPECT_RATIO");
            }
        }

        public static float MIN_PHONE_ASPECT_RATIO
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TransformUtil", "MIN_PHONE_ASPECT_RATIO");
            }
        }
    }
}

