namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckPickerHero")]
    public class DeckPickerHero : MonoBehaviour
    {
        public DeckPickerHero(IntPtr address) : this(address, "DeckPickerHero")
        {
        }

        public DeckPickerHero(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
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

