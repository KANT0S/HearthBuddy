namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TargetAnimUtils")]
    public class TargetAnimUtils : MonoBehaviour
    {
        public TargetAnimUtils(IntPtr address) : this(address, "TargetAnimUtils")
        {
        }

        public TargetAnimUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateHierarchy()
        {
            base.method_8("ActivateHierarchy", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DeactivateHierarchy()
        {
            base.method_8("DeactivateHierarchy", Array.Empty<object>());
        }

        public void DestroyHierarchy()
        {
            base.method_8("DestroyHierarchy", Array.Empty<object>());
        }

        public void FadeIn(float FadeSec)
        {
            object[] objArray1 = new object[] { FadeSec };
            base.method_8("FadeIn", objArray1);
        }

        public void FadeOut(float FadeSec)
        {
            object[] objArray1 = new object[] { FadeSec };
            base.method_8("FadeOut", objArray1);
        }

        public void KillParticlesInChildren()
        {
            base.method_8("KillParticlesInChildren", Array.Empty<object>());
        }

        public void PlayAnimation()
        {
            base.method_8("PlayAnimation", Array.Empty<object>());
        }

        public void PlayAnimationsInChildren()
        {
            base.method_8("PlayAnimationsInChildren", Array.Empty<object>());
        }

        public void PlayDefaultSound()
        {
            base.method_8("PlayDefaultSound", Array.Empty<object>());
        }

        public void PlayNewParticles()
        {
            base.method_8("PlayNewParticles", Array.Empty<object>());
        }

        public void PlayParticles()
        {
            base.method_8("PlayParticles", Array.Empty<object>());
        }

        public void PlayParticlesInChildren()
        {
            base.method_8("PlayParticlesInChildren", Array.Empty<object>());
        }

        public void PrintLog(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("PrintLog", objArray1);
        }

        public void PrintLogError(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("PrintLogError", objArray1);
        }

        public void PrintLogWarning(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("PrintLogWarning", objArray1);
        }

        public void SetAlphaHierarchy(float alpha)
        {
            object[] objArray1 = new object[] { alpha };
            base.method_8("SetAlphaHierarchy", objArray1);
        }

        public void StopAnimation()
        {
            base.method_8("StopAnimation", Array.Empty<object>());
        }

        public void StopAnimationsInChildren()
        {
            base.method_8("StopAnimationsInChildren", Array.Empty<object>());
        }

        public void StopNewParticles()
        {
            base.method_8("StopNewParticles", Array.Empty<object>());
        }

        public void StopParticles()
        {
            base.method_8("StopParticles", Array.Empty<object>());
        }

        public void StopParticlesInChildren()
        {
            base.method_8("StopParticlesInChildren", Array.Empty<object>());
        }

        public GameObject m_Target
        {
            get
            {
                return base.method_3<GameObject>("m_Target");
            }
        }
    }
}

