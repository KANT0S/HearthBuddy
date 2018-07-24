namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PegUIContainer")]
    public class PegUIContainer : MonoBehaviour
    {
        public PegUIContainer(IntPtr address) : this(address, "PegUIContainer")
        {
        }

        public PegUIContainer(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetActive(bool a)
        {
            object[] objArray1 = new object[] { a };
            base.method_8("SetActive", objArray1);
        }

        public bool isActive
        {
            get
            {
                return base.method_2<bool>("isActive");
            }
        }
    }
}

