namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FatalErrorScene")]
    public class FatalErrorScene : Scene
    {
        public FatalErrorScene(IntPtr address) : this(address, "FatalErrorScene")
        {
        }

        public FatalErrorScene(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnFatalErrorScreenLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnFatalErrorScreenLoaded", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }
    }
}

