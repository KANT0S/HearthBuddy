namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("SoundDuckingDef")]
    public class SoundDuckingDef : MonoClass
    {
        public SoundDuckingDef(IntPtr address) : this(address, "SoundDuckingDef")
        {
        }

        public SoundDuckingDef(IntPtr address, string className) : base(address, className)
        {
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public List<SoundDuckedCategoryDef> m_DuckedCategoryDefs
        {
            get
            {
                Class267<SoundDuckedCategoryDef> class2 = base.method_3<Class267<SoundDuckedCategoryDef>>("m_DuckedCategoryDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public SoundCategory m_TriggerCategory
        {
            get
            {
                return base.method_2<SoundCategory>("m_TriggerCategory");
            }
        }
    }
}

