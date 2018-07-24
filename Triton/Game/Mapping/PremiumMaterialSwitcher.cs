namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("PremiumMaterialSwitcher")]
    public class PremiumMaterialSwitcher : MonoBehaviour
    {
        public PremiumMaterialSwitcher(IntPtr address) : this(address, "PremiumMaterialSwitcher")
        {
        }

        public PremiumMaterialSwitcher(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetToPremium(int premium)
        {
            object[] objArray1 = new object[] { premium };
            base.method_8("SetToPremium", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public List<Material> m_PremiumMaterials
        {
            get
            {
                Class247<Material> class2 = base.method_3<Class247<Material>>("m_PremiumMaterials");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Material> OrgMaterials
        {
            get
            {
                Class247<Material> class2 = base.method_3<Class247<Material>>("OrgMaterials");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

