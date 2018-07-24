namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ThreeSliceTextElement")]
    public class ThreeSliceTextElement : MonoBehaviour
    {
        public ThreeSliceTextElement(IntPtr address) : this(address, "ThreeSliceTextElement")
        {
        }

        public ThreeSliceTextElement(IntPtr address, string className) : base(address, className)
        {
        }

        public float GetTextWidth()
        {
            return base.method_11<float>("GetTextWidth", Array.Empty<object>());
        }

        public void Resize()
        {
            base.method_8("Resize", Array.Empty<object>());
        }

        public void SetText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetText", objArray1);
        }

        public UberText m_text
        {
            get
            {
                return base.method_3<UberText>("m_text");
            }
        }

        public ThreeSliceElement m_threeSlice
        {
            get
            {
                return base.method_3<ThreeSliceElement>("m_threeSlice");
            }
        }
    }
}

