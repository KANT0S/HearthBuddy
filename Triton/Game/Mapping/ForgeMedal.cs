namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("ForgeMedal")]
    public class ForgeMedal : PegUIElement
    {
        public ForgeMedal(IntPtr address) : this(address, "ForgeMedal")
        {
        }

        public ForgeMedal(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void MedalOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("MedalOut", objArray1);
        }

        public void MedalOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("MedalOver", objArray1);
        }

        public void SetMedal(int wins)
        {
            object[] objArray1 = new object[] { wins };
            base.method_8("SetMedal", objArray1);
        }

        public List<ForgeMedalInfo> m_forgeMedalInfos
        {
            get
            {
                Class267<ForgeMedalInfo> class2 = base.method_3<Class267<ForgeMedalInfo>>("m_forgeMedalInfos");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Medal m_medal
        {
            get
            {
                return base.method_3<Medal>("m_medal");
            }
        }

        public Medal m_nextMedal
        {
            get
            {
                return base.method_3<Medal>("m_nextMedal");
            }
        }

        [Attribute38("ForgeMedal.ForgeMedalInfo")]
        public class ForgeMedalInfo : MonoClass
        {
            public ForgeMedalInfo(IntPtr address) : this(address, "ForgeMedalInfo")
            {
            }

            public ForgeMedalInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public Medal ForgeMedal
            {
                get
                {
                    return base.method_14<Medal>("get_ForgeMedal", Array.Empty<object>());
                }
            }

            public Vector2 TextureCoords
            {
                get
                {
                    return base.method_11<Vector2>("get_TextureCoords", Array.Empty<object>());
                }
            }
        }
    }
}

