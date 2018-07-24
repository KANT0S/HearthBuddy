namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PackOpeningButton")]
    public class PackOpeningButton : BoxMenuButton
    {
        public PackOpeningButton(IntPtr address) : this(address, "PackOpeningButton")
        {
        }

        public PackOpeningButton(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetGetPackCount()
        {
            return base.method_13("GetGetPackCount", Array.Empty<object>());
        }

        public void SetPackCount(int packs)
        {
            object[] objArray1 = new object[] { packs };
            base.method_8("SetPackCount", objArray1);
        }

        public UberText m_count
        {
            get
            {
                return base.method_3<UberText>("m_count");
            }
        }

        public GameObject m_countFrame
        {
            get
            {
                return base.method_3<GameObject>("m_countFrame");
            }
        }
    }
}

