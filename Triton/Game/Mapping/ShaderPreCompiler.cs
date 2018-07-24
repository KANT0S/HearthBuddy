namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("ShaderPreCompiler")]
    public class ShaderPreCompiler : MonoBehaviour
    {
        public ShaderPreCompiler(IntPtr address) : this(address, "ShaderPreCompiler")
        {
        }

        public ShaderPreCompiler(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject CreateMesh(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<GameObject>("CreateMesh", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void WarmupSceneChangeShader(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("WarmupSceneChangeShader", objArray1);
        }

        public List<string> GOLDEN_UBER_KEYWORDS1
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("GOLDEN_UBER_KEYWORDS1");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<string> GOLDEN_UBER_KEYWORDS2
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("GOLDEN_UBER_KEYWORDS2");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Vector3> MESH_NORMALS
        {
            get
            {
                Class246<Vector3> class2 = base.method_3<Class246<Vector3>>("MESH_NORMALS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Vector4> MESH_TANGENTS
        {
            get
            {
                Class246<Vector4> class2 = base.method_3<Class246<Vector4>>("MESH_TANGENTS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<int> MESH_TRIANGLES
        {
            get
            {
                Class246<int> class2 = base.method_3<Class246<int>>("MESH_TRIANGLES");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Vector2> MESH_UVS
        {
            get
            {
                Class246<Vector2> class2 = base.method_3<Class246<Vector2>>("MESH_UVS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Vector3> MESH_VERTS
        {
            get
            {
                Class246<Vector3> class2 = base.method_3<Class246<Vector3>>("MESH_VERTS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool PremiumShadersCompiled
        {
            get
            {
                return base.method_2<bool>("PremiumShadersCompiled");
            }
        }

        public bool SceneChangeShadersCompiled
        {
            get
            {
                return base.method_2<bool>("SceneChangeShadersCompiled");
            }
        }
    }
}

