namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("VS")]
    public class VS : MonoBehaviour
    {
        public VS(IntPtr address) : this(address, "VS")
        {
        }

        public VS(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateAnimation(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("ActivateAnimation", objArray1);
        }

        public void ActivateShadow(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("ActivateShadow", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void SetDefaults()
        {
            base.method_8("SetDefaults", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public GameObject m_shadow
        {
            get
            {
                return base.method_3<GameObject>("m_shadow");
            }
        }
    }
}

