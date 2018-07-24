namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Shadowform")]
    public class Shadowform : SuperSpell
    {
        public Shadowform(IntPtr address) : this(address, "Shadowform")
        {
        }

        public Shadowform(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public void OnDeath(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnDeath", objArray1);
        }

        public float m_Contrast
        {
            get
            {
                return base.method_2<float>("m_Contrast");
            }
        }

        public float m_Desaturate
        {
            get
            {
                return base.method_2<float>("m_Desaturate");
            }
        }

        public float m_FadeInTime
        {
            get
            {
                return base.method_2<float>("m_FadeInTime");
            }
        }

        public float m_FxIntensity
        {
            get
            {
                return base.method_2<float>("m_FxIntensity");
            }
        }

        public float m_Intensity
        {
            get
            {
                return base.method_2<float>("m_Intensity");
            }
        }

        public int m_MaterialIndex
        {
            get
            {
                return base.method_2<int>("m_MaterialIndex");
            }
        }

        public Material m_MaterialInstance
        {
            get
            {
                return base.method_3<Material>("m_MaterialInstance");
            }
        }

        public Material m_ShadowformMaterial
        {
            get
            {
                return base.method_3<Material>("m_ShadowformMaterial");
            }
        }

        public Color m_Tint
        {
            get
            {
                return base.method_2<Color>("m_Tint");
            }
        }
    }
}

