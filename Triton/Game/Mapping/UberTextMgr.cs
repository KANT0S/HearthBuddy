namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("UberTextMgr")]
    public class UberTextMgr : MonoBehaviour
    {
        public UberTextMgr(IntPtr address) : this(address, "UberTextMgr")
        {
        }

        public UberTextMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public string BuildCharacterSet()
        {
            return base.method_13("BuildCharacterSet", Array.Empty<object>());
        }

        public void ForceEnglishCharactersInAtlas()
        {
            base.method_8("ForceEnglishCharactersInAtlas", Array.Empty<object>());
        }

        public static UberTextMgr Get()
        {
            return MonoClass.smethod_15<UberTextMgr>(TritonHs.MainAssemblyPath, "", "UberTextMgr", "Get", Array.Empty<object>());
        }

        public void LogBelweAtlasUpdate()
        {
            base.method_8("LogBelweAtlasUpdate", Array.Empty<object>());
        }

        public void LogBelweOutlineAtlasUpdate()
        {
            base.method_8("LogBelweOutlineAtlasUpdate", Array.Empty<object>());
        }

        public void LogBlizzardGlobalAtlasUpdate()
        {
            base.method_8("LogBlizzardGlobalAtlasUpdate", Array.Empty<object>());
        }

        public void LogFranklinGothicAtlasUpdate()
        {
            base.method_8("LogFranklinGothicAtlasUpdate", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartAtlasUpdate()
        {
            base.method_8("StartAtlasUpdate", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool m_Active
        {
            get
            {
                return base.method_2<bool>("m_Active");
            }
        }

        public string m_AtlasCharacters
        {
            get
            {
                return base.method_4("m_AtlasCharacters");
            }
        }

        public string m_AtlasNumbers
        {
            get
            {
                return base.method_4("m_AtlasNumbers");
            }
        }

        public Locale m_Locale
        {
            get
            {
                return base.method_2<Locale>("m_Locale");
            }
        }

        public static UberTextMgr s_Instance
        {
            get
            {
                return MonoClass.smethod_7<UberTextMgr>(TritonHs.MainAssemblyPath, "", "UberTextMgr", "s_Instance");
            }
        }
    }
}

