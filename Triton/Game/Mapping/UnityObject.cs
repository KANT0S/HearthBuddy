namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Object")]
    public class UnityObject : MonoClass
    {
        public UnityObject(IntPtr address) : base(address, "Object")
        {
        }

        public UnityObject(IntPtr address, string className) : base(address, className)
        {
        }

        public static UnityObject FindObjectOfType<T>()
        {
            IntPtr ptr = MonoClass.ReflectionTypeGetType(typeof(T).Name);
            if (ptr != IntPtr.Zero)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { ptr };
                return MonoClass.smethod_16<UnityObject>(TritonHs.UnityEngineAssemblyPath, "UnityEngine", "Object", "FindObjectOfType", enumArray1, objArray1);
            }
            return null;
        }

        public static List<UnityObject> FindObjectsOfType<T>()
        {
            IntPtr ptr = MonoClass.ReflectionTypeGetType(typeof(T).Name);
            if (ptr != IntPtr.Zero)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { ptr };
                return MonoClass.smethod_16<Class247<UnityObject>>(TritonHs.UnityEngineAssemblyPath, "UnityEngine", "Object", "FindObjectsOfType", enumArray1, objArray1).method_25();
            }
            return null;
        }

        public static UnityObject FindObjectsOfType(string typeName)
        {
            IntPtr ptr = MonoClass.ReflectionTypeGetType(typeName);
            if (ptr != IntPtr.Zero)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { ptr };
                return MonoClass.smethod_16<UnityObject>(TritonHs.UnityEngineAssemblyPath, "UnityEngine", "Object", "FindObjectsOfType", enumArray1, objArray1);
            }
            return null;
        }

        public override int GetHashCode()
        {
            return base.method_11<int>("GetHashCode", Array.Empty<object>());
        }

        public int GetInstanceID()
        {
            return base.method_11<int>("GetInstanceID", Array.Empty<object>());
        }

        public static IntPtr GetType(string name, string assembly)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.String };
            object[] objArray1 = new object[] { name, assembly };
            TypeWrapper wrapper = MonoClass.smethod_16<TypeWrapper>(TritonHs.UnityEngineAssemblyPath, "UnityEngine", "Types", "GetType", enumArray1, objArray1);
            if (wrapper == null)
            {
                return IntPtr.Zero;
            }
            return wrapper.Address;
        }

        public string name
        {
            get
            {
                return base.method_13("get_name", Array.Empty<object>());
            }
        }
    }
}

