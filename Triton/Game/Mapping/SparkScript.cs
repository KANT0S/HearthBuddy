namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SparkScript")]
    public class SparkScript : MonoBehaviour
    {
        public SparkScript(IntPtr address) : this(address, "SparkScript")
        {
        }

        public SparkScript(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }
    }
}

