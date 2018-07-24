namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBackDisplay")]
    public class CardBackDisplay : MonoBehaviour
    {
        public CardBackDisplay(IntPtr address) : this(address, "CardBackDisplay")
        {
        }

        public CardBackDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetCardBack(bool friendlySide)
        {
            object[] objArray1 = new object[] { friendlySide };
            base.method_8("SetCardBack", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateCardBack()
        {
            base.method_8("UpdateCardBack", Array.Empty<object>());
        }

        public Actor m_Actor
        {
            get
            {
                return base.method_3<Actor>("m_Actor");
            }
        }

        public CardBackManager m_CardBackManager
        {
            get
            {
                return base.method_3<CardBackManager>("m_CardBackManager");
            }
        }

        public bool m_FriendlySide
        {
            get
            {
                return base.method_2<bool>("m_FriendlySide");
            }
        }
    }
}

