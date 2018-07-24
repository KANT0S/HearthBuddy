namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CraftCardCountTab")]
    public class CraftCardCountTab : MonoBehaviour
    {
        public CraftCardCountTab(IntPtr address) : this(address, "CraftCardCountTab")
        {
        }

        public CraftCardCountTab(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void UpdateText(int numCopies)
        {
            object[] objArray1 = new object[] { numCopies };
            base.method_8("UpdateText", objArray1);
        }

        public UberText m_count
        {
            get
            {
                return base.method_3<UberText>("m_count");
            }
        }

        public UberText m_plus
        {
            get
            {
                return base.method_3<UberText>("m_plus");
            }
        }

        public GameObject m_shadow
        {
            get
            {
                return base.method_3<GameObject>("m_shadow");
            }
        }

        public Vector3 origPos
        {
            get
            {
                return base.method_2<Vector3>("origPos");
            }
        }
    }
}

