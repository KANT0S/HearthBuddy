namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GraphicsResolution")]
    public class GraphicsResolution : MonoClass
    {
        public GraphicsResolution(IntPtr address) : this(address, "GraphicsResolution")
        {
        }

        public GraphicsResolution(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool add(int width, int height)
        {
            object[] objArray1 = new object[] { width, height };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GraphicsResolution", "add", objArray1);
        }

        public int CompareTo(object obj)
        {
            object[] objArray1 = new object[] { obj };
            return base.method_11<int>("CompareTo", objArray1);
        }

        public static GraphicsResolution create(int width, int height)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { width, height };
            return MonoClass.smethod_16<GraphicsResolution>(TritonHs.MainAssemblyPath, "", "GraphicsResolution", "create", enumArray1, objArray1);
        }

        public bool Equals(object obj)
        {
            object[] objArray1 = new object[] { obj };
            return base.method_11<bool>("Equals", objArray1);
        }

        public int GetHashCode()
        {
            return base.method_11<int>("GetHashCode", Array.Empty<object>());
        }

        public float aspectRatio
        {
            get
            {
                return base.method_11<float>("get_aspectRatio", Array.Empty<object>());
            }
        }

        public static GraphicsResolution current
        {
            get
            {
                return MonoClass.smethod_15<GraphicsResolution>(TritonHs.MainAssemblyPath, "", "GraphicsResolution", "get_current", Array.Empty<object>());
            }
        }

        public static List<GraphicsResolution> list
        {
            get
            {
                Class267<GraphicsResolution> class2 = MonoClass.smethod_15<Class267<GraphicsResolution>>(TritonHs.MainAssemblyPath, "", "GraphicsResolution", "get_list", Array.Empty<object>());
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static List<GraphicsResolution> resolutions_
        {
            get
            {
                Class267<GraphicsResolution> class2 = MonoClass.smethod_7<Class267<GraphicsResolution>>(TritonHs.MainAssemblyPath, "", "GraphicsResolution", "resolutions_");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int x
        {
            get
            {
                return base.method_11<int>("get_x", Array.Empty<object>());
            }
        }

        public int y
        {
            get
            {
                return base.method_11<int>("get_y", Array.Empty<object>());
            }
        }
    }
}

