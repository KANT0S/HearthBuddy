namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SocialToast")]
    public class SocialToast : MonoBehaviour
    {
        public SocialToast(IntPtr address) : this(address, "SocialToast")
        {
        }

        public SocialToast(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetText", objArray1);
        }

        public static float FUDGE_FACTOR
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SocialToast", "FUDGE_FACTOR");
            }
        }

        public UberText m_text
        {
            get
            {
                return base.method_3<UberText>("m_text");
            }
        }
    }
}

