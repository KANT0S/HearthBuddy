namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Banner")]
    public class Banner : MonoBehaviour
    {
        public Banner(IntPtr address) : this(address, "Banner")
        {
        }

        public Banner(IntPtr address, string className) : base(address, className)
        {
        }

        public void MoveGlowForBottomPlacement()
        {
            base.method_8("MoveGlowForBottomPlacement", Array.Empty<object>());
        }

        public void SetText(string headline)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { headline };
            base.method_9("SetText", enumArray1, objArray1);
        }

        public void SetText(string headline, string caption)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.String };
            object[] objArray1 = new object[] { headline, caption };
            base.method_9("SetText", enumArray1, objArray1);
        }

        public UberText m_caption
        {
            get
            {
                return base.method_3<UberText>("m_caption");
            }
        }

        public GameObject m_glowObject
        {
            get
            {
                return base.method_3<GameObject>("m_glowObject");
            }
        }

        public UberText m_headline
        {
            get
            {
                return base.method_3<UberText>("m_headline");
            }
        }
    }
}

