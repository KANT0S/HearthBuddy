namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardCrafting_WepPartSetParent")]
    public class CardCrafting_WepPartSetParent : MonoBehaviour
    {
        public CardCrafting_WepPartSetParent(IntPtr address) : this(address, "CardCrafting_WepPartSetParent")
        {
        }

        public CardCrafting_WepPartSetParent(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetParentWepParts()
        {
            base.method_8("SetParentWepParts", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public GameObject m_Parent
        {
            get
            {
                return base.method_3<GameObject>("m_Parent");
            }
        }

        public GameObject m_WepParts
        {
            get
            {
                return base.method_3<GameObject>("m_WepParts");
            }
        }
    }
}

