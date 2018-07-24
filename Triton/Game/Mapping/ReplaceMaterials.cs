namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("ReplaceMaterials")]
    public class ReplaceMaterials : MonoBehaviour
    {
        public ReplaceMaterials(IntPtr address) : this(address, "ReplaceMaterials")
        {
        }

        public ReplaceMaterials(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject FindGameObject(string gameObjName)
        {
            object[] objArray1 = new object[] { gameObjName };
            return base.method_14<GameObject>("FindGameObject", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public List<MaterialData> m_Materials
        {
            get
            {
                Class267<MaterialData> class2 = base.method_3<Class267<MaterialData>>("m_Materials");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        [Attribute38("ReplaceMaterials.MaterialData")]
        public class MaterialData : MonoClass
        {
            public MaterialData(IntPtr address) : this(address, "MaterialData")
            {
            }

            public MaterialData(IntPtr address, string className) : base(address, className)
            {
            }

            public GameObject DisplayGameObject
            {
                get
                {
                    return base.method_3<GameObject>("DisplayGameObject");
                }
            }

            public string GameObjectName
            {
                get
                {
                    return base.method_4("GameObjectName");
                }
            }

            public int MaterialIndex
            {
                get
                {
                    return base.method_2<int>("MaterialIndex");
                }
            }

            public Material NewMaterial
            {
                get
                {
                    return base.method_3<Material>("NewMaterial");
                }
            }

            public bool ReplaceChildMaterials
            {
                get
                {
                    return base.method_2<bool>("ReplaceChildMaterials");
                }
            }
        }
    }
}

