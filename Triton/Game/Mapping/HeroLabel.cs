namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HeroLabel")]
    public class HeroLabel : MonoBehaviour
    {
        public HeroLabel(IntPtr address) : this(address, "HeroLabel")
        {
        }

        public HeroLabel(IntPtr address, string className) : base(address, className)
        {
        }

        public void FadeOut()
        {
            base.method_8("FadeOut", Array.Empty<object>());
        }

        public void UpdateText(string nameText, string classText)
        {
            object[] objArray1 = new object[] { nameText, classText };
            base.method_8("UpdateText", objArray1);
        }

        public UberText m_classText
        {
            get
            {
                return base.method_3<UberText>("m_classText");
            }
        }

        public UberText m_nameText
        {
            get
            {
                return base.method_3<UberText>("m_nameText");
            }
        }
    }
}

