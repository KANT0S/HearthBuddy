namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SceneUtils")]
    public class SceneUtils : MonoClass
    {
        public SceneUtils(IntPtr address) : this(address, "SceneUtils")
        {
        }

        public SceneUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static Transform CreateBone(Component template)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { template };
            return MonoClass.smethod_16<Transform>(TritonHs.MainAssemblyPath, "", "SceneUtils", "CreateBone", enumArray1, objArray1);
        }

        public static Transform CreateBone(GameObject template)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { template };
            return MonoClass.smethod_16<Transform>(TritonHs.MainAssemblyPath, "", "SceneUtils", "CreateBone", enumArray1, objArray1);
        }

        public static void EnableColliders(Component c, bool enable)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { c, enable };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "EnableColliders", enumArray1, objArray1);
        }

        public static void EnableColliders(GameObject go, bool enable)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { go, enable };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "EnableColliders", enumArray1, objArray1);
        }

        public static void EnableRenderers(Component c, bool enable)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { c, enable };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "EnableRenderers", enumArray1, objArray1);
        }

        public static void EnableRenderers(GameObject go, bool enable)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { go, enable };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "EnableRenderers", enumArray1, objArray1);
        }

        public static void EnableRenderers(Component c, bool enable, bool includeInactive)
        {
            object[] objArray1 = new object[] { c, enable, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "EnableRenderers", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void EnableRenderers(GameObject go, bool enable, bool includeInactive)
        {
            object[] objArray1 = new object[] { go, enable, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "EnableRenderers", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void EnableRenderersAndColliders(Component c, bool enable)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { c, enable };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "EnableRenderersAndColliders", enumArray1, objArray1);
        }

        public static void EnableRenderersAndColliders(GameObject go, bool enable)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { go, enable };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "EnableRenderersAndColliders", enumArray1, objArray1);
        }

        public static GameObject FindChild(GameObject parentObject, string name)
        {
            object[] objArray1 = new object[] { parentObject, name };
            return MonoClass.smethod_15<GameObject>(TritonHs.MainAssemblyPath, "", "SceneUtils", "FindChild", objArray1);
        }

        public static GameObject FindChildBySubstring(GameObject parentObject, string substr)
        {
            object[] objArray1 = new object[] { parentObject, substr };
            return MonoClass.smethod_15<GameObject>(TritonHs.MainAssemblyPath, "", "SceneUtils", "FindChildBySubstring", objArray1);
        }

        public static GameObject FindChildByTag(GameObject go, string tag)
        {
            object[] objArray1 = new object[] { go, tag };
            return MonoClass.smethod_15<GameObject>(TritonHs.MainAssemblyPath, "", "SceneUtils", "FindChildByTag", objArray1);
        }

        public static Transform FindFirstChild(Transform parent)
        {
            object[] objArray1 = new object[] { parent };
            return MonoClass.smethod_15<Transform>(TritonHs.MainAssemblyPath, "", "SceneUtils", "FindFirstChild", objArray1);
        }

        public static GameObject FindTopParent(Component c)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { c };
            return MonoClass.smethod_16<GameObject>(TritonHs.MainAssemblyPath, "", "SceneUtils", "FindTopParent", enumArray1, objArray1);
        }

        public static GameObject FindTopParent(GameObject go)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_16<GameObject>(TritonHs.MainAssemblyPath, "", "SceneUtils", "FindTopParent", enumArray1, objArray1);
        }

        public static bool IsAncestorOf(Component ancestor, Component descendant)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { ancestor, descendant };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "SceneUtils", "IsAncestorOf", enumArray1, objArray1);
        }

        public static bool IsAncestorOf(GameObject ancestor, GameObject descendant)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { ancestor, descendant };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "SceneUtils", "IsAncestorOf", enumArray1, objArray1);
        }

        public static bool IsDescendantOf(Component descendant, Component ancestor)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { descendant, ancestor };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "SceneUtils", "IsDescendantOf", enumArray1, objArray1);
        }

        public static bool IsDescendantOf(Component descendant, GameObject ancestor)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { descendant, ancestor };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "SceneUtils", "IsDescendantOf", enumArray1, objArray1);
        }

        public static bool IsDescendantOf(GameObject descendant, Component ancestor)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { descendant, ancestor };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "SceneUtils", "IsDescendantOf", enumArray1, objArray1);
        }

        public static bool IsDescendantOf(GameObject descendant, GameObject ancestor)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { descendant, ancestor };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "SceneUtils", "IsDescendantOf", enumArray1, objArray1);
        }

        public static string LayerMaskToString(LayerMask mask)
        {
            object[] objArray1 = new object[] { mask };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "SceneUtils", "LayerMaskToString", objArray1);
        }

        public static void ReplaceLayer(GameObject parentObject, GameLayer newLayer, GameLayer oldLayer)
        {
            object[] objArray1 = new object[] { parentObject, newLayer, oldLayer };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SceneUtils", "ReplaceLayer", objArray1);
        }

        public static void ResizeBoxCollider(Component c, Bounds bounds)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { c, bounds };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", enumArray1, objArray1);
        }

        public static void ResizeBoxCollider(GameObject go, Bounds bounds)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { go, bounds };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", enumArray1, objArray1);
        }

        public static void ResizeBoxCollider(Component c, Component worldCorner1, Component worldCorner2)
        {
            object[] objArray1 = new object[] { c, worldCorner1, worldCorner2 };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ResizeBoxCollider(Component c, Component worldCorner1, GameObject worldCorner2)
        {
            object[] objArray1 = new object[] { c, worldCorner1, worldCorner2 };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ResizeBoxCollider(Component c, GameObject worldCorner1, Component worldCorner2)
        {
            object[] objArray1 = new object[] { c, worldCorner1, worldCorner2 };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ResizeBoxCollider(Component c, GameObject worldCorner1, GameObject worldCorner2)
        {
            object[] objArray1 = new object[] { c, worldCorner1, worldCorner2 };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ResizeBoxCollider(Component c, Vector3 worldCorner1, Vector3 worldCorner2)
        {
            object[] objArray1 = new object[] { c, worldCorner1, worldCorner2 };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ResizeBoxCollider(GameObject go, Component worldCorner1, Component worldCorner2)
        {
            object[] objArray1 = new object[] { go, worldCorner1, worldCorner2 };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ResizeBoxCollider(GameObject go, Component worldCorner1, GameObject worldCorner2)
        {
            object[] objArray1 = new object[] { go, worldCorner1, worldCorner2 };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ResizeBoxCollider(GameObject go, GameObject worldCorner1, Component worldCorner2)
        {
            object[] objArray1 = new object[] { go, worldCorner1, worldCorner2 };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ResizeBoxCollider(GameObject go, GameObject worldCorner1, GameObject worldCorner2)
        {
            object[] objArray1 = new object[] { go, worldCorner1, worldCorner2 };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ResizeBoxCollider(GameObject go, Vector3 worldCorner1, Vector3 worldCorner2)
        {
            object[] objArray1 = new object[] { go, worldCorner1, worldCorner2 };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "ResizeBoxCollider", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetHideFlags(object obj, HideFlags flags)
        {
            object[] objArray1 = new object[] { obj, flags };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SceneUtils", "SetHideFlags", objArray1);
        }

        public static void SetLayer(Component c, int layer)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { c, layer };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "SetLayer", enumArray1, objArray1);
        }

        public static void SetLayer(Component c, GameLayer layer)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { c, layer };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "SetLayer", enumArray1, objArray1);
        }

        public static void SetLayer(GameObject go, int layer)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { go, layer };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "SetLayer", enumArray1, objArray1);
        }

        public static void SetLayer(GameObject go, GameLayer layer)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { go, layer };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SceneUtils", "SetLayer", enumArray1, objArray1);
        }

        public static void SetRenderQueue(GameObject go, int renderQueue)
        {
            object[] objArray1 = new object[] { go, renderQueue };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SceneUtils", "SetRenderQueue", objArray1);
        }
    }
}

