namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CardBackDragEffect")]
    public class CardBackDragEffect : MonoBehaviour
    {
        public CardBackDragEffect(IntPtr address) : this(address, "CardBackDragEffect")
        {
        }

        public CardBackDragEffect(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FixedUpdate()
        {
            base.method_8("FixedUpdate", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void SetEffect()
        {
            base.method_8("SetEffect", Array.Empty<object>());
        }

        public void ShowParticles(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowParticles", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateDragEffect()
        {
            base.method_8("UpdateDragEffect", Array.Empty<object>());
        }

        public bool m_Active
        {
            get
            {
                return base.method_2<bool>("m_Active");
            }
        }

        public Actor m_Actor
        {
            get
            {
                return base.method_3<Actor>("m_Actor");
            }
        }

        public CardBackManager m_CardBackManager
        {
            get
            {
                return base.method_3<CardBackManager>("m_CardBackManager");
            }
        }

        public GameObject m_EffectsRoot
        {
            get
            {
                return base.method_3<GameObject>("m_EffectsRoot");
            }
        }

        public Vector3 m_LastPosition
        {
            get
            {
                return base.method_2<Vector3>("m_LastPosition");
            }
        }

        public float m_Max
        {
            get
            {
                return base.method_2<float>("m_Max");
            }
        }

        public float m_Min
        {
            get
            {
                return base.method_2<float>("m_Min");
            }
        }

        public float m_Speed
        {
            get
            {
                return base.method_2<float>("m_Speed");
            }
        }

        public static float MAX_VELOCITY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CardBackDragEffect", "MAX_VELOCITY");
            }
        }

        public static float MIN_VELOCITY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CardBackDragEffect", "MIN_VELOCITY");
            }
        }
    }
}

