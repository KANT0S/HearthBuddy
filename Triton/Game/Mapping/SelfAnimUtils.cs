namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SelfAnimUtils")]
    public class SelfAnimUtils : MonoBehaviour
    {
        public SelfAnimUtils(IntPtr address) : this(address, "SelfAnimUtils")
        {
        }

        public SelfAnimUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateHierarchy()
        {
            base.method_8("ActivateHierarchy", Array.Empty<object>());
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

        public void KillParticles()
        {
            base.method_8("KillParticles", Array.Empty<object>());
        }

        public void PlayAnimation()
        {
            base.method_8("PlayAnimation", Array.Empty<object>());
        }

        public void PlayDefaultSound()
        {
            base.method_8("PlayDefaultSound", Array.Empty<object>());
        }

        public void PlayParticles()
        {
            base.method_8("PlayParticles", Array.Empty<object>());
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

        public void RandomRotationX()
        {
            base.method_8("RandomRotationX", Array.Empty<object>());
        }

        public void RandomRotationY()
        {
            base.method_8("RandomRotationY", Array.Empty<object>());
        }

        public void RandomRotationZ()
        {
            base.method_8("RandomRotationZ", Array.Empty<object>());
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

        public void StopParticles()
        {
            base.method_8("StopParticles", Array.Empty<object>());
        }
    }
}

