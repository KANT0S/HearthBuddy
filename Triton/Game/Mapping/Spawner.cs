namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Spawner")]
    public class Spawner : MonoBehaviour
    {
        public Spawner(IntPtr address) : this(address, "Spawner")
        {
        }

        public Spawner(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public GameObject Spawn()
        {
            return base.method_15<GameObject>("Spawn", new Class272.Enum20[0], Array.Empty<object>());
        }

        public bool destroyOnSpawn
        {
            get
            {
                return base.method_2<bool>("destroyOnSpawn");
            }
        }

        public GameObject prefab
        {
            get
            {
                return base.method_3<GameObject>("prefab");
            }
        }

        public bool spawnOnAwake
        {
            get
            {
                return base.method_2<bool>("spawnOnAwake");
            }
        }
    }
}

