namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TargetAnimUtils2")]
    public class TargetAnimUtils2 : MonoBehaviour
    {
        public TargetAnimUtils2(IntPtr address) : this(address, "TargetAnimUtils2")
        {
        }

        public TargetAnimUtils2(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateHierarchy2()
        {
            base.method_8("ActivateHierarchy2", Array.Empty<object>());
        }

        public void DeactivateHierarchy2()
        {
            base.method_8("DeactivateHierarchy2", Array.Empty<object>());
        }

        public void DestroyHierarchy2()
        {
            base.method_8("DestroyHierarchy2", Array.Empty<object>());
        }

        public void FadeIn2(float FadeSec)
        {
            object[] objArray1 = new object[] { FadeSec };
            base.method_8("FadeIn2", objArray1);
        }

        public void FadeOut2(float FadeSec)
        {
            object[] objArray1 = new object[] { FadeSec };
            base.method_8("FadeOut2", objArray1);
        }

        public void KillParticlesInChildren2()
        {
            base.method_8("KillParticlesInChildren2", Array.Empty<object>());
        }

        public void PlayAnimation2()
        {
            base.method_8("PlayAnimation2", Array.Empty<object>());
        }

        public void PlayAnimationsInChildren2()
        {
            base.method_8("PlayAnimationsInChildren2", Array.Empty<object>());
        }

        public void PlayDefaultSound2()
        {
            base.method_8("PlayDefaultSound2", Array.Empty<object>());
        }

        public void PlayNewParticles2()
        {
            base.method_8("PlayNewParticles2", Array.Empty<object>());
        }

        public void PlayParticles2()
        {
            base.method_8("PlayParticles2", Array.Empty<object>());
        }

        public void PlayParticlesInChildren2()
        {
            base.method_8("PlayParticlesInChildren2", Array.Empty<object>());
        }

        public void PrintLog2(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("PrintLog2", objArray1);
        }

        public void PrintLogError2(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("PrintLogError2", objArray1);
        }

        public void PrintLogWarning2(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("PrintLogWarning2", objArray1);
        }

        public void SetAlphaHierarchy2(float alpha)
        {
            object[] objArray1 = new object[] { alpha };
            base.method_8("SetAlphaHierarchy2", objArray1);
        }

        public void StopAnimation2()
        {
            base.method_8("StopAnimation2", Array.Empty<object>());
        }

        public void StopAnimationsInChildren2()
        {
            base.method_8("StopAnimationsInChildren2", Array.Empty<object>());
        }

        public void StopNewParticles2()
        {
            base.method_8("StopNewParticles2", Array.Empty<object>());
        }

        public void StopParticles2()
        {
            base.method_8("StopParticles2", Array.Empty<object>());
        }

        public void StopParticlesInChildren2()
        {
            base.method_8("StopParticlesInChildren2", Array.Empty<object>());
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

