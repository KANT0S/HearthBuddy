namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DraftScene")]
    public class DraftScene : Scene
    {
        public DraftScene(IntPtr address) : this(address, "DraftScene")
        {
        }

        public DraftScene(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool IsUnloading()
        {
            return base.method_11<bool>("IsUnloading", Array.Empty<object>());
        }

        public void OnPhoneUIScreenLoaded(string name, GameObject screen, object callbackData)
        {
            object[] objArray1 = new object[] { name, screen, callbackData };
            base.method_8("OnPhoneUIScreenLoaded", objArray1);
        }

        public void OnUIScreenLoaded(string name, GameObject screen, object callbackData)
        {
            object[] objArray1 = new object[] { name, screen, callbackData };
            base.method_8("OnUIScreenLoaded", objArray1);
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public bool m_unloading
        {
            get
            {
                return base.method_2<bool>("m_unloading");
            }
        }
    }
}

