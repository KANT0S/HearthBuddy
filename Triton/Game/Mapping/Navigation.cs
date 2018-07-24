namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Navigation")]
    public class Navigation : MonoClass
    {
        public Navigation(IntPtr address) : this(address, "Navigation")
        {
        }

        public Navigation(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool BlockBackingOut()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Navigation", "BlockBackingOut", Array.Empty<object>());
        }

        public static bool CanNavigate()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Navigation", "CanNavigate", Array.Empty<object>());
        }

        public static void Clear()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Navigation", "Clear");
        }

        public static void DumpStack()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Navigation", "DumpStack");
        }

        public static bool GoBack()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Navigation", "GoBack", Array.Empty<object>());
        }

        public static void Pop()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Navigation", "Pop");
        }

        public static bool NAVIGATION_DEBUG
        {
            get
            {
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Navigation", "get_NAVIGATION_DEBUG", Array.Empty<object>());
            }
        }
    }
}

