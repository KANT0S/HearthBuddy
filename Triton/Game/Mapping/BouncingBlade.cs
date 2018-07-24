namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BouncingBlade")]
    public class BouncingBlade : SuperSpell
    {
        public BouncingBlade(IntPtr address) : this(address, "BouncingBlade")
        {
        }

        public BouncingBlade(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateSparks()
        {
            base.method_8("AnimateSparks", Array.Empty<object>());
        }

        public void AnimateToNextTarget(Target target)
        {
            object[] objArray1 = new object[] { target };
            base.method_8("AnimateToNextTarget", objArray1);
        }

        public void AnimationComplete(Target target)
        {
            object[] objArray1 = new object[] { target };
            base.method_8("AnimationComplete", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void RampBladeVolume()
        {
            base.method_8("RampBladeVolume", Array.Empty<object>());
        }

        public void SetupBounceLocations()
        {
            base.method_8("SetupBounceLocations", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public static float BLADE_ANIMATION_SPEED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BouncingBlade", "BLADE_ANIMATION_SPEED");
            }
        }

        public static float BLADE_BIRTH_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BouncingBlade", "BLADE_BIRTH_TIME");
            }
        }

        public static float DAMAGE_SPLAT_DELAY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BouncingBlade", "DAMAGE_SPLAT_DELAY");
            }
        }

        public bool m_Animating
        {
            get
            {
                return base.method_2<bool>("m_Animating");
            }
        }

        public GameObject m_Blade
        {
            get
            {
                return base.method_3<GameObject>("m_Blade");
            }
        }

        public GameObject m_BladeRoot
        {
            get
            {
                return base.method_3<GameObject>("m_BladeRoot");
            }
        }

        public float m_BladeSpinningMaxVol
        {
            get
            {
                return base.method_2<float>("m_BladeSpinningMaxVol");
            }
        }

        public float m_BladeSpinningMinVol
        {
            get
            {
                return base.method_2<float>("m_BladeSpinningMinVol");
            }
        }

        public float m_BladeSpinningRampTime
        {
            get
            {
                return base.method_2<float>("m_BladeSpinningRampTime");
            }
        }

        public List<HitBonesType> m_HitBones
        {
            get
            {
                Class267<HitBonesType> class2 = base.method_3<Class267<HitBonesType>>("m_HitBones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_HitBonesRoot
        {
            get
            {
                return base.method_3<GameObject>("m_HitBonesRoot");
            }
        }

        public bool m_isDone
        {
            get
            {
                return base.method_2<bool>("m_isDone");
            }
        }

        public Vector3 m_OrgBladeScale
        {
            get
            {
                return base.method_2<Vector3>("m_OrgBladeScale");
            }
        }

        public HitBonesType m_PreviousHitBone
        {
            get
            {
                return base.method_3<HitBonesType>("m_PreviousHitBone");
            }
        }

        public bool m_Running
        {
            get
            {
                return base.method_2<bool>("m_Running");
            }
        }

        public List<Target> m_TargetQueue
        {
            get
            {
                Class267<Target> class2 = base.method_3<Class267<Target>>("m_TargetQueue");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_Trail
        {
            get
            {
                return base.method_3<GameObject>("m_Trail");
            }
        }

        public static int OFFSCREEN_HIT_PERCENT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "BouncingBlade", "OFFSCREEN_HIT_PERCENT");
            }
        }

        public enum HIT_DIRECTIONS
        {
            NW,
            NE,
            E,
            SW,
            SE,
            N_OFFSCREEN,
            E_OFFSCREEN,
            W_OFFSCREEN,
            S_OFFSCREEN
        }

        [Attribute38("BouncingBlade.HitBonesType")]
        public class HitBonesType : MonoClass
        {
            public HitBonesType(IntPtr address) : this(address, "HitBonesType")
            {
            }

            public HitBonesType(IntPtr address, string className) : base(address, className)
            {
            }

            public Vector3 GetPosition()
            {
                return base.method_11<Vector3>("GetPosition", Array.Empty<object>());
            }

            public void SetPosition(Vector3 pos)
            {
                object[] objArray1 = new object[] { pos };
                base.method_8("SetPosition", objArray1);
            }

            public GameObject Bone
            {
                get
                {
                    return base.method_3<GameObject>("Bone");
                }
            }

            public BouncingBlade.HIT_DIRECTIONS Direction
            {
                get
                {
                    return base.method_2<BouncingBlade.HIT_DIRECTIONS>("Direction");
                }
            }

            public Vector3 m_Position
            {
                get
                {
                    return base.method_2<Vector3>("m_Position");
                }
            }
        }

        [Attribute38("BouncingBlade.Target")]
        public class Target : MonoClass
        {
            public Target(IntPtr address) : this(address, "Target")
            {
            }

            public Target(IntPtr address, string className) : base(address, className)
            {
            }

            public bool isMinion
            {
                get
                {
                    return base.method_2<bool>("isMinion");
                }
            }

            public bool LastBlock
            {
                get
                {
                    return base.method_2<bool>("LastBlock");
                }
            }

            public bool LastTarget
            {
                get
                {
                    return base.method_2<bool>("LastTarget");
                }
            }

            public int MetaDataIdx
            {
                get
                {
                    return base.method_2<int>("MetaDataIdx");
                }
            }

            public bool Offscreen
            {
                get
                {
                    return base.method_2<bool>("Offscreen");
                }
            }

            public Vector3 TargetPosition
            {
                get
                {
                    return base.method_2<Vector3>("TargetPosition");
                }
            }

            public GameObject VisualTarget
            {
                get
                {
                    return base.method_3<GameObject>("VisualTarget");
                }
            }
        }
    }
}

