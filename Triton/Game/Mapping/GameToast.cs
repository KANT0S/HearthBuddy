namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("GameToast")]
    public class GameToast : MonoBehaviour
    {
        public GameToast(IntPtr address) : this(address, "GameToast")
        {
        }

        public GameToast(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateIntensity(float intensity)
        {
            object[] objArray1 = new object[] { intensity };
            base.method_8("UpdateIntensity", objArray1);
        }

        public List<Material> m_intensityMaterials
        {
            get
            {
                Class267<Material> class2 = base.method_3<Class267<Material>>("m_intensityMaterials");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

