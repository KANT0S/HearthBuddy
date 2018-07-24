namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RotateByMovement")]
    public class RotateByMovement : MonoBehaviour
    {
        public RotateByMovement(IntPtr address) : this(address, "RotateByMovement")
        {
        }

        public RotateByMovement(IntPtr address, string className) : base(address, className)
        {
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public Vector3 m_previousPos
        {
            get
            {
                return base.method_2<Vector3>("m_previousPos");
            }
        }

        public GameObject mParent
        {
            get
            {
                return base.method_3<GameObject>("mParent");
            }
        }
    }
}

