namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BackBehavior")]
    public class BackBehavior : MonoBehaviour
    {
        public BackBehavior(IntPtr address) : this(address, "BackBehavior")
        {
        }

        public BackBehavior(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }
    }
}

