namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CollectionManagerScene")]
    public class CollectionManagerScene : Scene
    {
        public CollectionManagerScene(IntPtr address) : this(address, "CollectionManagerScene")
        {
        }

        public CollectionManagerScene(IntPtr address, string className) : base(address, className)
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

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
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

