namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DragRotator")]
    public class DragRotator : MonoBehaviour
    {
        public DragRotator(IntPtr address) : this(address, "DragRotator")
        {
        }

        public DragRotator(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public DragRotatorInfo GetInfo()
        {
            return base.method_14<DragRotatorInfo>("GetInfo", Array.Empty<object>());
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void SetInfo(DragRotatorInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SetInfo", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static float EPSILON
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DragRotator", "EPSILON");
            }
        }

        public DragRotatorInfo m_info
        {
            get
            {
                return base.method_3<DragRotatorInfo>("m_info");
            }
        }

        public Vector3 m_originalAngles
        {
            get
            {
                return base.method_2<Vector3>("m_originalAngles");
            }
        }

        public float m_pitchDeg
        {
            get
            {
                return base.method_2<float>("m_pitchDeg");
            }
        }

        public float m_pitchVel
        {
            get
            {
                return base.method_2<float>("m_pitchVel");
            }
        }

        public Vector3 m_prevPos
        {
            get
            {
                return base.method_2<Vector3>("m_prevPos");
            }
        }

        public float m_rollDeg
        {
            get
            {
                return base.method_2<float>("m_rollDeg");
            }
        }

        public float m_rollVel
        {
            get
            {
                return base.method_2<float>("m_rollVel");
            }
        }

        public static float SMOOTH_DAMP_SEC_FUDGE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DragRotator", "SMOOTH_DAMP_SEC_FUDGE");
            }
        }
    }
}

