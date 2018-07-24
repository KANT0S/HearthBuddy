namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PackOpeningScene")]
    public class PackOpeningScene : Scene
    {
        public PackOpeningScene(IntPtr address) : this(address, "PackOpeningScene")
        {
        }

        public PackOpeningScene(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
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

        public PackOpening m_packOpening
        {
            get
            {
                return base.method_3<PackOpening>("m_packOpening");
            }
        }
    }
}

