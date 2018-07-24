namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("iTweenPath")]
    public class iTweenPath : MonoBehaviour
    {
        public iTweenPath(IntPtr address) : this(address, "iTweenPath")
        {
        }

        public iTweenPath(IntPtr address, string className) : base(address, className)
        {
        }

        public static string FixupPathName(string name)
        {
            object[] objArray1 = new object[] { name };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "iTweenPath", "FixupPathName", objArray1);
        }

        public static List<Vector3> GetPath(string requestedName)
        {
            object[] objArray1 = new object[] { requestedName };
            Class246<Vector3> class2 = MonoClass.smethod_15<Class246<Vector3>>(TritonHs.MainAssemblyPath, "", "iTweenPath", "GetPath", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<Vector3> GetPathReversed(string requestedName)
        {
            object[] objArray1 = new object[] { requestedName };
            Class246<Vector3> class2 = MonoClass.smethod_15<Class246<Vector3>>(TritonHs.MainAssemblyPath, "", "iTweenPath", "GetPathReversed", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnDrawGizmosSelected()
        {
            base.method_8("OnDrawGizmosSelected", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public bool initialized
        {
            get
            {
                return base.method_2<bool>("initialized");
            }
        }

        public string initialName
        {
            get
            {
                return base.method_4("initialName");
            }
        }

        public List<Vector3> nodes
        {
            get
            {
                Class266<Vector3> class2 = base.method_3<Class266<Vector3>>("nodes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Color pathColor
        {
            get
            {
                return base.method_2<Color>("pathColor");
            }
        }

        public string pathName
        {
            get
            {
                return base.method_4("pathName");
            }
        }

        public bool pathVisible
        {
            get
            {
                return base.method_2<bool>("pathVisible");
            }
        }
    }
}

