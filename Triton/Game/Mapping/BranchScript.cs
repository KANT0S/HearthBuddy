namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BranchScript")]
    public class BranchScript : MonoBehaviour
    {
        public BranchScript(IntPtr address) : this(address, "BranchScript")
        {
        }

        public BranchScript(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float timeSpawned
        {
            get
            {
                return base.method_2<float>("timeSpawned");
            }
        }
    }
}

