namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("RenderUtils")]
    public class RenderUtils : MonoClass
    {
        public RenderUtils(IntPtr address) : this(address, "RenderUtils")
        {
        }

        public RenderUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static float GetMainTextureOffsetX(Component c)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { c };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureOffsetX", enumArray1, objArray1);
        }

        public static float GetMainTextureOffsetX(GameObject go)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureOffsetX", enumArray1, objArray1);
        }

        public static float GetMainTextureOffsetX(Renderer r)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { r };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureOffsetX", enumArray1, objArray1);
        }

        public static float GetMainTextureOffsetY(Component c)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { c };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureOffsetY", enumArray1, objArray1);
        }

        public static float GetMainTextureOffsetY(GameObject go)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureOffsetY", enumArray1, objArray1);
        }

        public static float GetMainTextureOffsetY(Renderer r)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { r };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureOffsetY", enumArray1, objArray1);
        }

        public static float GetMainTextureScaleX(Component c)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { c };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureScaleX", enumArray1, objArray1);
        }

        public static float GetMainTextureScaleX(GameObject go)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureScaleX", enumArray1, objArray1);
        }

        public static float GetMainTextureScaleX(Renderer r)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { r };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureScaleX", enumArray1, objArray1);
        }

        public static float GetMainTextureScaleY(Component c)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { c };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureScaleY", enumArray1, objArray1);
        }

        public static float GetMainTextureScaleY(GameObject go)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureScaleY", enumArray1, objArray1);
        }

        public static float GetMainTextureScaleY(Renderer r)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { r };
            return MonoClass.smethod_11<float>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMainTextureScaleY", enumArray1, objArray1);
        }

        public static Material GetMaterial(Component c, int materialIndex)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { c, materialIndex };
            return MonoClass.smethod_16<Material>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMaterial", enumArray1, objArray1);
        }

        public static Material GetMaterial(GameObject go, int materialIndex)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { go, materialIndex };
            return MonoClass.smethod_16<Material>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMaterial", enumArray1, objArray1);
        }

        public static Material GetMaterial(Renderer renderer, int materialIndex)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { renderer, materialIndex };
            return MonoClass.smethod_16<Material>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetMaterial", enumArray1, objArray1);
        }

        public static Material GetSharedMaterial(Component c, int materialIndex)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { c, materialIndex };
            return MonoClass.smethod_16<Material>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetSharedMaterial", enumArray1, objArray1);
        }

        public static Material GetSharedMaterial(GameObject go, int materialIndex)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { go, materialIndex };
            return MonoClass.smethod_16<Material>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetSharedMaterial", enumArray1, objArray1);
        }

        public static Material GetSharedMaterial(Renderer renderer, int materialIndex)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { renderer, materialIndex };
            return MonoClass.smethod_16<Material>(TritonHs.MainAssemblyPath, "", "RenderUtils", "GetSharedMaterial", enumArray1, objArray1);
        }

        public static void SetAlpha(Component c, float alpha)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, alpha };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetAlpha", enumArray1, objArray1);
        }

        public static void SetAlpha(GameObject go, float alpha)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, alpha };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetAlpha", enumArray1, objArray1);
        }

        public static void SetAlpha(Component c, float alpha, bool includeInactive)
        {
            object[] objArray1 = new object[] { c, alpha, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetAlpha", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetAlpha(GameObject go, float alpha, bool includeInactive)
        {
            object[] objArray1 = new object[] { go, alpha, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetAlpha", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetMainTextureOffsetX(Component c, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureOffsetX", enumArray1, objArray1);
        }

        public static void SetMainTextureOffsetX(GameObject go, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureOffsetX", enumArray1, objArray1);
        }

        public static void SetMainTextureOffsetX(Renderer r, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { r, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureOffsetX", enumArray1, objArray1);
        }

        public static void SetMainTextureOffsetY(Component c, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureOffsetY", enumArray1, objArray1);
        }

        public static void SetMainTextureOffsetY(GameObject go, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureOffsetY", enumArray1, objArray1);
        }

        public static void SetMainTextureOffsetY(Renderer r, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { r, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureOffsetY", enumArray1, objArray1);
        }

        public static void SetMainTextureScaleX(Component c, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureScaleX", enumArray1, objArray1);
        }

        public static void SetMainTextureScaleX(GameObject go, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureScaleX", enumArray1, objArray1);
        }

        public static void SetMainTextureScaleX(Renderer r, float x)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { r, x };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureScaleX", enumArray1, objArray1);
        }

        public static void SetMainTextureScaleY(Component c, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { c, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureScaleY", enumArray1, objArray1);
        }

        public static void SetMainTextureScaleY(GameObject go, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { go, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureScaleY", enumArray1, objArray1);
        }

        public static void SetMainTextureScaleY(Renderer r, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { r, y };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMainTextureScaleY", enumArray1, objArray1);
        }

        public static void SetMaterial(Component c, int materialIndex, Material material)
        {
            object[] objArray1 = new object[] { c, materialIndex, material };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMaterial", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetMaterial(GameObject go, int materialIndex, Material material)
        {
            object[] objArray1 = new object[] { go, materialIndex, material };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMaterial", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetMaterial(Renderer renderer, int materialIndex, Material material)
        {
            object[] objArray1 = new object[] { renderer, materialIndex, material };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetMaterial", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetSharedMaterial(Component c, int materialIndex, Material material)
        {
            object[] objArray1 = new object[] { c, materialIndex, material };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetSharedMaterial", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetSharedMaterial(GameObject go, int materialIndex, Material material)
        {
            object[] objArray1 = new object[] { go, materialIndex, material };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetSharedMaterial", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetSharedMaterial(Renderer renderer, int materialIndex, Material material)
        {
            object[] objArray1 = new object[] { renderer, materialIndex, material };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "RenderUtils", "SetSharedMaterial", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }
    }
}

