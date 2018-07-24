namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("TargetListAnimUtils2")]
    public class TargetListAnimUtils2 : MonoBehaviour
    {
        public TargetListAnimUtils2(IntPtr address) : this(address, "TargetListAnimUtils2")
        {
        }

        public TargetListAnimUtils2(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateHierarchyList2()
        {
            base.method_8("ActivateHierarchyList2", Array.Empty<object>());
        }

        public void DeactivateHierarchyList2()
        {
            base.method_8("DeactivateHierarchyList2", Array.Empty<object>());
        }

        public void DestroyHierarchyList2()
        {
            base.method_8("DestroyHierarchyList2", Array.Empty<object>());
        }

        public void FadeInList2(float FadeSec)
        {
            object[] objArray1 = new object[] { FadeSec };
            base.method_8("FadeInList2", objArray1);
        }

        public void FadeOutList2(float FadeSec)
        {
            object[] objArray1 = new object[] { FadeSec };
            base.method_8("FadeOutList2", objArray1);
        }

        public void KillParticlesList2()
        {
            base.method_8("KillParticlesList2", Array.Empty<object>());
        }

        public void KillParticlesListInChildren2()
        {
            base.method_8("KillParticlesListInChildren2", Array.Empty<object>());
        }

        public void PlayAnimationList2()
        {
            base.method_8("PlayAnimationList2", Array.Empty<object>());
        }

        public void PlayAnimationListInChildren2()
        {
            base.method_8("PlayAnimationListInChildren2", Array.Empty<object>());
        }

        public void PlayParticlesList2()
        {
            base.method_8("PlayParticlesList2", Array.Empty<object>());
        }

        public void PlayParticlesListInChildren2()
        {
            base.method_8("PlayParticlesListInChildren2", Array.Empty<object>());
        }

        public void SetAlphaHierarchyList2(float alpha)
        {
            object[] objArray1 = new object[] { alpha };
            base.method_8("SetAlphaHierarchyList2", objArray1);
        }

        public void StopAnimationList2()
        {
            base.method_8("StopAnimationList2", Array.Empty<object>());
        }

        public void StopAnimationListInChildren2()
        {
            base.method_8("StopAnimationListInChildren2", Array.Empty<object>());
        }

        public void StopParticlesList2()
        {
            base.method_8("StopParticlesList2", Array.Empty<object>());
        }

        public void StopParticlesListInChildren2()
        {
            base.method_8("StopParticlesListInChildren2", Array.Empty<object>());
        }

        public List<GameObject> m_TargetList
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_TargetList");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

