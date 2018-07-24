namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CustomDeck")]
    public class CustomDeck : MonoBehaviour
    {
        public CustomDeck(IntPtr address) : this(address, "CustomDeck")
        {
        }

        public CustomDeck(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public int m_PortraitMaterialIdx
        {
            get
            {
                return base.method_2<int>("m_PortraitMaterialIdx");
            }
        }

        public GameObject m_PortraitMesh
        {
            get
            {
                return base.method_3<GameObject>("m_PortraitMesh");
            }
        }
    }
}

