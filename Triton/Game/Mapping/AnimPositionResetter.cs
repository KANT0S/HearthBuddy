namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AnimPositionResetter")]
    public class AnimPositionResetter : MonoBehaviour
    {
        public AnimPositionResetter(IntPtr address) : this(address, "AnimPositionResetter")
        {
        }

        public AnimPositionResetter(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public float GetDelay()
        {
            return base.method_11<float>("GetDelay", Array.Empty<object>());
        }

        public float GetEndTimestamp()
        {
            return base.method_11<float>("GetEndTimestamp", Array.Empty<object>());
        }

        public Vector3 GetInitialPosition()
        {
            return base.method_11<Vector3>("GetInitialPosition", Array.Empty<object>());
        }

        public void OnAnimStarted(float animTime)
        {
            object[] objArray1 = new object[] { animTime };
            base.method_8("OnAnimStarted", objArray1);
        }

        public static AnimPositionResetter OnAnimStarted(GameObject go, float animTime)
        {
            object[] objArray1 = new object[] { go, animTime };
            return MonoClass.smethod_15<AnimPositionResetter>(TritonHs.MainAssemblyPath, "", "AnimPositionResetter", "OnAnimStarted", objArray1);
        }

        public static AnimPositionResetter RegisterResetter(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_15<AnimPositionResetter>(TritonHs.MainAssemblyPath, "", "AnimPositionResetter", "RegisterResetter", objArray1);
        }

        public float m_delay
        {
            get
            {
                return base.method_2<float>("m_delay");
            }
        }

        public float m_endTimestamp
        {
            get
            {
                return base.method_2<float>("m_endTimestamp");
            }
        }

        public Vector3 m_initialPosition
        {
            get
            {
                return base.method_2<Vector3>("m_initialPosition");
            }
        }
    }
}

