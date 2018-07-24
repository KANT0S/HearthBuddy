namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("SoundDucker")]
    public class SoundDucker : MonoBehaviour
    {
        public SoundDucker(IntPtr address) : this(address, "SoundDucker")
        {
        }

        public SoundDucker(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public List<SoundDuckedCategoryDef> GetDuckedCategoryDefs()
        {
            Class267<SoundDuckedCategoryDef> class2 = base.method_14<Class267<SoundDuckedCategoryDef>>("GetDuckedCategoryDefs", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void InitDuckedCategoryDefs()
        {
            base.method_8("InitDuckedCategoryDefs", Array.Empty<object>());
        }

        public bool IsDucking()
        {
            return base.method_11<bool>("IsDucking", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void StartDucking()
        {
            base.method_8("StartDucking", Array.Empty<object>());
        }

        public void StopDucking()
        {
            base.method_8("StopDucking", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public bool m_DuckAllCategories
        {
            get
            {
                return base.method_2<bool>("m_DuckAllCategories");
            }
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

        public bool m_ducking
        {
            get
            {
                return base.method_2<bool>("m_ducking");
            }
        }

        public SoundDuckedCategoryDef m_GlobalDuckDef
        {
            get
            {
                return base.method_3<SoundDuckedCategoryDef>("m_GlobalDuckDef");
            }
        }
    }
}

