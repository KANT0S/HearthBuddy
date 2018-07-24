namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TavernBrawlScene")]
    public class TavernBrawlScene : Scene
    {
        public TavernBrawlScene(IntPtr address) : this(address, "TavernBrawlScene")
        {
        }

        public TavernBrawlScene(IntPtr address, string className) : base(address, className)
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

        public void OnCollectionManagerLoaded(string name, GameObject screen, object callbackData)
        {
            object[] objArray1 = new object[] { name, screen, callbackData };
            base.method_8("OnCollectionManagerLoaded", objArray1);
        }

        public void OnServerDataReady()
        {
            base.method_8("OnServerDataReady", Array.Empty<object>());
        }

        public void OnTavernBrawlLoaded(string name, GameObject screen, object callbackData)
        {
            object[] objArray1 = new object[] { name, screen, callbackData };
            base.method_8("OnTavernBrawlLoaded", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool m_collectionManagerNeeded
        {
            get
            {
                return base.method_2<bool>("m_collectionManagerNeeded");
            }
        }

        public bool m_collectionManagerPrefabLoaded
        {
            get
            {
                return base.method_2<bool>("m_collectionManagerPrefabLoaded");
            }
        }

        public bool m_tavernBrawlPrefabLoaded
        {
            get
            {
                return base.method_2<bool>("m_tavernBrawlPrefabLoaded");
            }
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

