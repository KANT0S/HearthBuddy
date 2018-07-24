namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("ClassFilterButtonContainer")]
    public class ClassFilterButtonContainer : MonoBehaviour
    {
        public ClassFilterButtonContainer(IntPtr address) : this(address, "ClassFilterButtonContainer")
        {
        }

        public ClassFilterButtonContainer(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public int GetIndex(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            return base.method_11<int>("GetIndex", objArray1);
        }

        public int GetNumVisibleClasses()
        {
            return base.method_11<int>("GetNumVisibleClasses", Array.Empty<object>());
        }

        public void SetCardBacksEnabled(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("SetCardBacksEnabled", objArray1);
        }

        public void SetClass(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            base.method_8("SetClass", objArray1);
        }

        public void SetDefaults()
        {
            base.method_8("SetDefaults", Array.Empty<object>());
        }

        public void SetHeroSkinsEnabled(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("SetHeroSkinsEnabled", objArray1);
        }

        public PegUIElement m_cardBacksButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_cardBacksButton");
            }
        }

        public GameObject m_cardBacksDisabled
        {
            get
            {
                return base.method_3<GameObject>("m_cardBacksDisabled");
            }
        }

        public List<ClassFilterButton> m_classButtons
        {
            get
            {
                Class247<ClassFilterButton> class2 = base.method_3<Class247<ClassFilterButton>>("m_classButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Material> m_classMaterials
        {
            get
            {
                Class247<Material> class2 = base.method_3<Class247<Material>>("m_classMaterials");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<TAG_CLASS> m_classTags
        {
            get
            {
                Class246<TAG_CLASS> class2 = base.method_3<Class246<TAG_CLASS>>("m_classTags");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public PegUIElement m_heroSkinsButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_heroSkinsButton");
            }
        }

        public GameObject m_heroSkinsDisabled
        {
            get
            {
                return base.method_3<GameObject>("m_heroSkinsDisabled");
            }
        }

        public Material m_inactiveMaterial
        {
            get
            {
                return base.method_3<Material>("m_inactiveMaterial");
            }
        }

        public int m_neutralIndex
        {
            get
            {
                return base.method_2<int>("m_neutralIndex");
            }
        }

        public int m_rowSize
        {
            get
            {
                return base.method_2<int>("m_rowSize");
            }
        }

        public Material m_templateMaterial
        {
            get
            {
                return base.method_3<Material>("m_templateMaterial");
            }
        }
    }
}

