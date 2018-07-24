namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PackOpeningCardCarouselItem")]
    public class PackOpeningCardCarouselItem : CarouselItem
    {
        public PackOpeningCardCarouselItem(IntPtr address) : this(address, "PackOpeningCardCarouselItem")
        {
        }

        public PackOpeningCardCarouselItem(IntPtr address, string className) : base(address, className)
        {
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public GameObject GetGameObject()
        {
            return base.method_14<GameObject>("GetGameObject", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsLoaded()
        {
            return base.method_11<bool>("IsLoaded", Array.Empty<object>());
        }

        public void Show(Carousel card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("Show", objArray1);
        }

        public PackOpeningCard m_card
        {
            get
            {
                return base.method_3<PackOpeningCard>("m_card");
            }
        }
    }
}

