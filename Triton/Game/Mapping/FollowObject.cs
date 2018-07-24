namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FollowObject")]
    public class FollowObject : MonoBehaviour
    {
        public FollowObject(IntPtr address) : this(address, "FollowObject")
        {
        }

        public FollowObject(IntPtr address, string className) : base(address, className)
        {
        }

        public void LateUpdate()
        {
            base.method_8("LateUpdate", Array.Empty<object>());
        }

        public Transform targetObj
        {
            get
            {
                return base.method_3<Transform>("targetObj");
            }
        }
    }
}

