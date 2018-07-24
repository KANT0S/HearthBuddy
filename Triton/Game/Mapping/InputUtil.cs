namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("InputUtil")]
    public class InputUtil : MonoClass
    {
        public InputUtil(IntPtr address) : this(address, "InputUtil")
        {
        }

        public InputUtil(IntPtr address, string className) : base(address, className)
        {
        }

        public static InputScheme GetInputScheme()
        {
            return MonoClass.smethod_14<InputScheme>(TritonHs.MainAssemblyPath, "", "InputUtil", "GetInputScheme", Array.Empty<object>());
        }

        public static bool IsMouseOnScreen()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "InputUtil", "IsMouseOnScreen", Array.Empty<object>());
        }

        public static bool IsPlayMakerMouseInputAllowed(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "InputUtil", "IsPlayMakerMouseInputAllowed", objArray1);
        }

        public static bool ShouldCheckGameplayForPlayMakerMouseInput(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "InputUtil", "ShouldCheckGameplayForPlayMakerMouseInput", objArray1);
        }
    }
}

