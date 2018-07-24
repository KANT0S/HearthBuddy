namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ParticleEffects")]
    public class ParticleEffects : MonoBehaviour
    {
        public ParticleEffects(IntPtr address) : this(address, "ParticleEffects")
        {
        }

        public ParticleEffects(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnDrawGizmos()
        {
            base.method_8("OnDrawGizmos", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static float VectorAngle(Vector3 forwardVector, Vector3 targetVector, Vector3 upVector)
        {
            object[] objArray1 = new object[] { forwardVector, targetVector, upVector };
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "ParticleEffects", "VectorAngle", objArray1);
        }

        public List<ParticleEffectsAttractor> m_ParticleAttractors
        {
            get
            {
                Class267<ParticleEffectsAttractor> class2 = base.method_3<Class267<ParticleEffectsAttractor>>("m_ParticleAttractors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public ParticleEffectsOrientation m_ParticleOrientation
        {
            get
            {
                return base.method_3<ParticleEffectsOrientation>("m_ParticleOrientation");
            }
        }

        public List<ParticleEffectsRepulser> m_ParticleRepulsers
        {
            get
            {
                Class267<ParticleEffectsRepulser> class2 = base.method_3<Class267<ParticleEffectsRepulser>>("m_ParticleRepulsers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_WorldSpace
        {
            get
            {
                return base.method_2<bool>("m_WorldSpace");
            }
        }
    }
}

