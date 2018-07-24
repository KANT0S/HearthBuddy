namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    [Attribute38("NestedPrefab")]
    public class NestedPrefab : MonoBehaviour
    {
        public NestedPrefab(IntPtr address) : this(address, "NestedPrefab")
        {
        }

        public NestedPrefab(IntPtr address, string className) : base(address, className)
        {
        }

        public void LoadPrefab()
        {
            base.method_8("LoadPrefab", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public GameObject PrefabGameObject()
        {
            return base.method_14<GameObject>("PrefabGameObject", Array.Empty<object>());
        }

        public void UpdateMesh()
        {
            base.method_8("UpdateMesh", Array.Empty<object>());
        }

        public List<EditorMesh> m_EditorMeshes
        {
            get
            {
                Class266<EditorMesh> class2 = base.method_3<Class266<EditorMesh>>("m_EditorMeshes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_lastPrefab
        {
            get
            {
                return base.method_4("m_lastPrefab");
            }
        }

        public string m_Prefab
        {
            get
            {
                return base.method_4("m_Prefab");
            }
        }

        public GameObject m_PrefabGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_PrefabGameObject");
            }
        }

        public Color SELECTED_WIRE_COLOR
        {
            get
            {
                return base.method_2<Color>("SELECTED_WIRE_COLOR");
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EditorMesh
        {
            public Mesh mesh;
            public List<Material> materials;
        }
    }
}

