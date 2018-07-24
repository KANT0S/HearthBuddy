namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardRewardCount")]
    public class CardRewardCount : MonoBehaviour
    {
        public CardRewardCount(IntPtr address) : this(address, "CardRewardCount")
        {
        }

        public CardRewardCount(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void SetCount(int count)
        {
            object[] objArray1 = new object[] { count };
            base.method_8("SetCount", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public UberText m_countText
        {
            get
            {
                return base.method_3<UberText>("m_countText");
            }
        }

        public UberText m_multiplierText
        {
            get
            {
                return base.method_3<UberText>("m_multiplierText");
            }
        }
    }
}

