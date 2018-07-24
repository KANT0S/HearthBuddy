namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ParticleSystemScaler")]
    public class ParticleSystemScaler : MonoBehaviour
    {
        public ParticleSystemScaler(IntPtr address) : this(address, "ParticleSystemScaler")
        {
        }

        public ParticleSystemScaler(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ScaleParticleSystems(float scaleFactor)
        {
            object[] objArray1 = new object[] { scaleFactor };
            base.method_8("ScaleParticleSystems", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float m_unitMagnitude
        {
            get
            {
                return base.method_2<float>("m_unitMagnitude");
            }
        }

        public GameObject ObjectToInherit
        {
            get
            {
                return base.method_3<GameObject>("ObjectToInherit");
            }
        }

        public float ParticleSystemScale
        {
            get
            {
                return base.method_2<float>("ParticleSystemScale");
            }
        }
    }
}

