namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DraftInputManager")]
    public class DraftInputManager : MonoBehaviour
    {
        public DraftInputManager(IntPtr address) : this(address, "DraftInputManager")
        {
        }

        public DraftInputManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static DraftInputManager Get()
        {
            return MonoClass.smethod_15<DraftInputManager>(TritonHs.MainAssemblyPath, "", "DraftInputManager", "Get", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }
    }
}

