namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("iTweenManager")]
    public class iTweenManager : MonoBehaviour
    {
        public iTweenManager(IntPtr address) : this(address, "iTweenManager")
        {
        }

        public iTweenManager(IntPtr address, string className) : base(address, className)
        {
        }

        public static void Add(iTween tween)
        {
            object[] objArray1 = new object[] { tween };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "iTweenManager", "Add", objArray1);
        }

        public void AddImpl(iTween tween)
        {
            object[] objArray1 = new object[] { tween };
            base.method_8("AddImpl", objArray1);
        }

        public void FixedUpdate()
        {
            base.method_8("FixedUpdate", Array.Empty<object>());
        }

        public static iTweenManager Get()
        {
            return MonoClass.smethod_15<iTweenManager>(TritonHs.MainAssemblyPath, "", "iTweenManager", "Get", Array.Empty<object>());
        }

        public static iTweenIterator GetIterator()
        {
            return MonoClass.smethod_14<iTweenIterator>(TritonHs.MainAssemblyPath, "", "iTweenManager", "GetIterator", Array.Empty<object>());
        }

        public iTweenIterator GetIteratorImpl()
        {
            return base.method_11<iTweenIterator>("GetIteratorImpl", Array.Empty<object>());
        }

        public static int GetTweenCount()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "iTweenManager", "GetTweenCount", Array.Empty<object>());
        }

        public int GetTweenCountImpl()
        {
            return base.method_11<int>("GetTweenCountImpl", Array.Empty<object>());
        }

        public iTween GetTweenForObject(GameObject obj)
        {
            object[] objArray1 = new object[] { obj };
            return base.method_14<iTween>("GetTweenForObject", objArray1);
        }

        public static List<iTween> GetTweensForObject(GameObject obj)
        {
            object[] objArray1 = new object[] { obj };
            Class247<iTween> class2 = MonoClass.smethod_15<Class247<iTween>>(TritonHs.MainAssemblyPath, "", "iTweenManager", "GetTweensForObject", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<iTween> GetTweensForObjectImpl(GameObject obj)
        {
            object[] objArray1 = new object[] { obj };
            Class247<iTween> class2 = base.method_14<Class247<iTween>>("GetTweensForObjectImpl", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void LateUpdate()
        {
            base.method_8("LateUpdate", Array.Empty<object>());
        }

        public void OnApplicationQuit()
        {
            base.method_8("OnApplicationQuit", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public static void Remove(iTween tween)
        {
            object[] objArray1 = new object[] { tween };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "iTweenManager", "Remove", objArray1);
        }

        public void RemoveImpl(iTween tween)
        {
            object[] objArray1 = new object[] { tween };
            base.method_8("RemoveImpl", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public iTweenCollection m_tweenCollection
        {
            get
            {
                return base.method_3<iTweenCollection>("m_tweenCollection");
            }
        }

        public static bool s_quitting
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "iTweenManager", "s_quitting");
            }
        }

        [Attribute38("iTweenManager.iTweenEntry")]
        public class iTweenEntry : MonoClass
        {
            public iTweenEntry(IntPtr address) : this(address, "iTweenEntry")
            {
            }

            public iTweenEntry(IntPtr address, string className) : base(address, className)
            {
            }

            public GameObject gameObject
            {
                get
                {
                    return base.method_3<GameObject>("gameObject");
                }
            }

            public Triton.Game.Mapping.iTween iTween
            {
                get
                {
                    return base.method_3<Triton.Game.Mapping.iTween>("iTween");
                }
            }
        }
    }
}

