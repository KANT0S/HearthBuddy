namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CreditsScene")]
    public class CreditsScene : Scene
    {
        public CreditsScene(IntPtr address) : this(address, "CreditsScene")
        {
        }

        public CreditsScene(IntPtr address, string className) : base(address, className)
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

