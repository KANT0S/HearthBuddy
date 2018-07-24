namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ManaCostBar")]
    public class ManaCostBar : MonoBehaviour
    {
        public ManaCostBar(IntPtr address) : this(address, "ManaCostBar")
        {
        }

        public ManaCostBar(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateBar(float newValue)
        {
            object[] objArray1 = new object[] { newValue };
            base.method_8("AnimateBar", objArray1);
        }

        public void BarPercent_OnUpdate(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("BarPercent_OnUpdate", objArray1);
        }

        public void CoolDown()
        {
            base.method_8("CoolDown", Array.Empty<object>());
        }

        public void CoolDown_OnComplete()
        {
            base.method_8("CoolDown_OnComplete", Array.Empty<object>());
        }

        public void Decrease_OnComplete()
        {
            base.method_8("Decrease_OnComplete", Array.Empty<object>());
        }

        public void DecreaseBar(float newVal, float prevVal)
        {
            object[] objArray1 = new object[] { newVal, prevVal };
            base.method_8("DecreaseBar", objArray1);
        }

        public void Increase_OnComplete()
        {
            base.method_8("Increase_OnComplete", Array.Empty<object>());
        }

        public void IncreaseBar(float newVal, float prevVal)
        {
            object[] objArray1 = new object[] { newVal, prevVal };
            base.method_8("IncreaseBar", objArray1);
        }

        public void Intensity_OnUpdate(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("Intensity_OnUpdate", objArray1);
        }

        public void ParticlePosition_OnUpdate(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("ParticlePosition_OnUpdate", objArray1);
        }

        public void PlayParticles(bool state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("PlayParticles", objArray1);
        }

        public void SetBar(float newValue)
        {
            object[] objArray1 = new object[] { newValue };
            base.method_8("SetBar", objArray1);
        }

        public void SetBarValue(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetBarValue", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void TestDecrease()
        {
            base.method_8("TestDecrease", Array.Empty<object>());
        }

        public void TestIncrease()
        {
            base.method_8("TestIncrease", Array.Empty<object>());
        }

        public void TestReset()
        {
            base.method_8("TestReset", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float m_BarIntensity
        {
            get
            {
                return base.method_2<float>("m_BarIntensity");
            }
        }

        public Material m_barMaterial
        {
            get
            {
                return base.method_3<Material>("m_barMaterial");
            }
        }

        public float m_coolDownAnimTime
        {
            get
            {
                return base.method_2<float>("m_coolDownAnimTime");
            }
        }

        public float m_currentVal
        {
            get
            {
                return base.method_2<float>("m_currentVal");
            }
        }

        public float m_factor
        {
            get
            {
                return base.method_2<float>("m_factor");
            }
        }

        public float m_increaseAnimTime
        {
            get
            {
                return base.method_2<float>("m_increaseAnimTime");
            }
        }

        public GameObject m_manaCostBarObject
        {
            get
            {
                return base.method_3<GameObject>("m_manaCostBarObject");
            }
        }

        public float m_maxIntensity
        {
            get
            {
                return base.method_2<float>("m_maxIntensity");
            }
        }

        public float m_maxValue
        {
            get
            {
                return base.method_2<float>("m_maxValue");
            }
        }

        public GameObject m_ParticleEnd
        {
            get
            {
                return base.method_3<GameObject>("m_ParticleEnd");
            }
        }

        public Vector3 m_particleEndPoint
        {
            get
            {
                return base.method_2<Vector3>("m_particleEndPoint");
            }
        }

        public GameObject m_ParticleImpact
        {
            get
            {
                return base.method_3<GameObject>("m_ParticleImpact");
            }
        }

        public GameObject m_ParticleObject
        {
            get
            {
                return base.method_3<GameObject>("m_ParticleObject");
            }
        }

        public GameObject m_ParticleStart
        {
            get
            {
                return base.method_3<GameObject>("m_ParticleStart");
            }
        }

        public Vector3 m_particleStartPoint
        {
            get
            {
                return base.method_2<Vector3>("m_particleStartPoint");
            }
        }

        public float m_previousVal
        {
            get
            {
                return base.method_2<float>("m_previousVal");
            }
        }
    }
}

