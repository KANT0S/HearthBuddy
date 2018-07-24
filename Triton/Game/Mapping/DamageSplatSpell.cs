namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DamageSplatSpell")]
    public class DamageSplatSpell : Spell
    {
        public DamageSplatSpell(IntPtr address) : this(address, "DamageSplatSpell")
        {
        }

        public DamageSplatSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DoSplatAnims()
        {
            base.method_8("DoSplatAnims", Array.Empty<object>());
        }

        public void EnableAllRenderers(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("EnableAllRenderers", objArray1);
        }

        public float GetDamage()
        {
            return base.method_11<float>("GetDamage", Array.Empty<object>());
        }

        public void HideImpl()
        {
            base.method_8("HideImpl", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void OnIdle(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnIdle", objArray1);
        }

        public void OnNone(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnNone", objArray1);
        }

        public void SetDamage(int damage)
        {
            object[] objArray1 = new object[] { damage };
            base.method_8("SetDamage", objArray1);
        }

        public void ShowImpl()
        {
            base.method_8("ShowImpl", Array.Empty<object>());
        }

        public void UpdateElements()
        {
            base.method_8("UpdateElements", Array.Empty<object>());
        }

        public GameObject m_activeSplat
        {
            get
            {
                return base.method_3<GameObject>("m_activeSplat");
            }
        }

        public GameObject m_BloodSplat
        {
            get
            {
                return base.method_3<GameObject>("m_BloodSplat");
            }
        }

        public int m_damage
        {
            get
            {
                return base.method_2<int>("m_damage");
            }
        }

        public UberText m_DamageTextMesh
        {
            get
            {
                return base.method_3<UberText>("m_DamageTextMesh");
            }
        }

        public GameObject m_HealSplat
        {
            get
            {
                return base.method_3<GameObject>("m_HealSplat");
            }
        }

        public static float SCALE_IN_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DamageSplatSpell", "SCALE_IN_TIME");
            }
        }
    }
}

