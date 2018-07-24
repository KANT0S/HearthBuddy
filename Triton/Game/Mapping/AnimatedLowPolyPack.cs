namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AnimatedLowPolyPack")]
    public class AnimatedLowPolyPack : MonoBehaviour
    {
        public AnimatedLowPolyPack(IntPtr address) : this(address, "AnimatedLowPolyPack")
        {
        }

        public AnimatedLowPolyPack(IntPtr address, string className) : base(address, className)
        {
        }

        public bool FlyIn(float animTime, float delay)
        {
            object[] objArray1 = new object[] { animTime, delay };
            return base.method_11<bool>("FlyIn", objArray1);
        }

        public void FlyInImmediate()
        {
            base.method_8("FlyInImmediate", Array.Empty<object>());
        }

        public bool FlyOut(float animTime, float delay)
        {
            object[] objArray1 = new object[] { animTime, delay };
            return base.method_11<bool>("FlyOut", objArray1);
        }

        public void FlyOutImmediate()
        {
            base.method_8("FlyOutImmediate", Array.Empty<object>());
        }

        public State GetState()
        {
            return base.method_11<State>("GetState", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Init(int column, Vector3 targetLocalPos, Vector3 offScreenOffset, bool ignoreFullscreenEffects, bool changeActivation)
        {
            object[] objArray1 = new object[] { column, targetLocalPos, offScreenOffset, ignoreFullscreenEffects, changeActivation };
            base.method_8("Init", objArray1);
        }

        public void OnFlownIn()
        {
            base.method_8("OnFlownIn", Array.Empty<object>());
        }

        public void OnHidden()
        {
            base.method_8("OnHidden", Array.Empty<object>());
        }

        public void PositionOffScreen()
        {
            base.method_8("PositionOffScreen", Array.Empty<object>());
        }

        public void SetFlyingLocalRotations(Vector3 flyInLocalAngles, Vector3 flyOutLocalAngles)
        {
            object[] objArray1 = new object[] { flyInLocalAngles, flyOutLocalAngles };
            base.method_8("SetFlyingLocalRotations", objArray1);
        }

        public int Column
        {
            get
            {
                return base.method_11<int>("get_Column", Array.Empty<object>());
            }
        }

        public bool m_changeActivation
        {
            get
            {
                return base.method_2<bool>("m_changeActivation");
            }
        }

        public Vector3 m_flyInLocalAngles
        {
            get
            {
                return base.method_2<Vector3>("m_flyInLocalAngles");
            }
        }

        public string m_FlyInSound
        {
            get
            {
                return base.method_4("m_FlyInSound");
            }
        }

        public Vector3 m_flyOutLocalAngles
        {
            get
            {
                return base.method_2<Vector3>("m_flyOutLocalAngles");
            }
        }

        public string m_FlyOutSound
        {
            get
            {
                return base.method_4("m_FlyOutSound");
            }
        }

        public State m_state
        {
            get
            {
                return base.method_2<State>("m_state");
            }
        }

        public Vector3 m_targetLocalPos
        {
            get
            {
                return base.method_2<Vector3>("m_targetLocalPos");
            }
        }

        public Vector3 m_targetOffScreenLocalPos
        {
            get
            {
                return base.method_2<Vector3>("m_targetOffScreenLocalPos");
            }
        }

        public Vector3 PUNCH_POSITION_AMOUNT
        {
            get
            {
                return base.method_2<Vector3>("PUNCH_POSITION_AMOUNT");
            }
        }

        public float PUNCH_POSITION_TIME
        {
            get
            {
                return base.method_2<float>("PUNCH_POSITION_TIME");
            }
        }

        public enum State
        {
            UNKNOWN,
            FLOWN_IN,
            FLYING_IN,
            FLYING_OUT,
            HIDDEN
        }
    }
}

