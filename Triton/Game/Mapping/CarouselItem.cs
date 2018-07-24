namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("CarouselItem")]
    public class CarouselItem : MonoClass
    {
        public CarouselItem(IntPtr address) : this(address, "CarouselItem")
        {
        }

        public CarouselItem(IntPtr address, string className) : base(address, className)
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

        public void Show(Carousel parent)
        {
            object[] objArray1 = new object[] { parent };
            base.method_8("Show", objArray1);
        }
    }
}

