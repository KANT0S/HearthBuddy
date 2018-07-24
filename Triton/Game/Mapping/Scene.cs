namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Scene")]
    public class Scene : MonoBehaviour
    {
        public Scene(IntPtr address) : this(address, "Scene")
        {
        }

        public Scene(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public bool IsUnloading()
        {
            return base.method_11<bool>("IsUnloading", Array.Empty<object>());
        }

        public void PreUnload()
        {
            base.method_8("PreUnload", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }
    }
}

