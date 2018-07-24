namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("TargetListAnimUtils")]
    public class TargetListAnimUtils : MonoBehaviour
    {
        public TargetListAnimUtils(IntPtr address) : this(address, "TargetListAnimUtils")
        {
        }

        public TargetListAnimUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateHierarchyList()
        {
            base.method_8("ActivateHierarchyList", Array.Empty<object>());
        }

        public void DeactivateHierarchyList()
        {
            base.method_8("DeactivateHierarchyList", Array.Empty<object>());
        }

        public void DestroyHierarchyList()
        {
            base.method_8("DestroyHierarchyList", Array.Empty<object>());
        }

        public void FadeInList(float FadeSec)
        {
            object[] objArray1 = new object[] { FadeSec };
            base.method_8("FadeInList", objArray1);
        }

        public void FadeOutList(float FadeSec)
        {
            object[] objArray1 = new object[] { FadeSec };
            base.method_8("FadeOutList", objArray1);
        }

        public void KillParticlesList()
        {
            base.method_8("KillParticlesList", Array.Empty<object>());
        }

        public void KillParticlesListInChildren()
        {
            base.method_8("KillParticlesListInChildren", Array.Empty<object>());
        }

        public void PlayAnimationList()
        {
            base.method_8("PlayAnimationList", Array.Empty<object>());
        }

        public void PlayAnimationListInChildren()
        {
            base.method_8("PlayAnimationListInChildren", Array.Empty<object>());
        }

        public void PlayNewParticlesListInChildren()
        {
            base.method_8("PlayNewParticlesListInChildren", Array.Empty<object>());
        }

        public void PlayParticlesList()
        {
            base.method_8("PlayParticlesList", Array.Empty<object>());
        }

        public void PlayParticlesListInChildren()
        {
            base.method_8("PlayParticlesListInChildren", Array.Empty<object>());
        }

        public void SetAlphaHierarchyList(float alpha)
        {
            object[] objArray1 = new object[] { alpha };
            base.method_8("SetAlphaHierarchyList", objArray1);
        }

        public void StopAnimationList()
        {
            base.method_8("StopAnimationList", Array.Empty<object>());
        }

        public void StopAnimationListInChildren()
        {
            base.method_8("StopAnimationListInChildren", Array.Empty<object>());
        }

        public void StopNewParticlesListInChildren()
        {
            base.method_8("StopNewParticlesListInChildren", Array.Empty<object>());
        }

        public void StopParticlesList()
        {
            base.method_8("StopParticlesList", Array.Empty<object>());
        }

        public void StopParticlesListInChildren()
        {
            base.method_8("StopParticlesListInChildren", Array.Empty<object>());
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

