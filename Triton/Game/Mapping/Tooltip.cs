namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Tooltip")]
    public class Tooltip : MonoBehaviour
    {
        public Tooltip(IntPtr address) : this(address, "Tooltip")
        {
        }

        public Tooltip(IntPtr address, string className) : base(address, className)
        {
        }

        public void UpdateText(string headline, string description)
        {
            object[] objArray1 = new object[] { headline, description };
            base.method_8("UpdateText", objArray1);
        }

        public TextMesh descriptionText
        {
            get
            {
                return base.method_3<TextMesh>("descriptionText");
            }
        }

        public TextMesh headlineText
        {
            get
            {
                return base.method_3<TextMesh>("headlineText");
            }
        }
    }
}

