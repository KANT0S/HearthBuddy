namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ScrollBarThumb")]
    public class ScrollBarThumb : PegUIElement
    {
        public ScrollBarThumb(IntPtr address) : this(address, "ScrollBarThumb")
        {
        }

        public ScrollBarThumb(IntPtr address, string className) : base(address, className)
        {
        }

        public bool IsDragging()
        {
            return base.method_11<bool>("IsDragging", Array.Empty<object>());
        }

        public void OnHold()
        {
            base.method_8("OnHold", Array.Empty<object>());
        }

        public void StartDragging()
        {
            base.method_8("StartDragging", Array.Empty<object>());
        }

        public void StopDragging()
        {
            base.method_8("StopDragging", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool m_isDragging
        {
            get
            {
                return base.method_2<bool>("m_isDragging");
            }
        }
    }
}

