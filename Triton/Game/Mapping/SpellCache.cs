namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SpellCache")]
    public class SpellCache : MonoBehaviour
    {
        public SpellCache(IntPtr address) : this(address, "SpellCache")
        {
        }

        public SpellCache(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public static SpellCache Get()
        {
            return MonoClass.smethod_15<SpellCache>(TritonHs.MainAssemblyPath, "", "SpellCache", "Get", Array.Empty<object>());
        }

        public SpellTable GetSpellTable(string tablePath)
        {
            object[] objArray1 = new object[] { tablePath };
            return base.method_14<SpellTable>("GetSpellTable", objArray1);
        }

        public SpellTable LoadSpellTable(string tableName)
        {
            object[] objArray1 = new object[] { tableName };
            return base.method_14<SpellTable>("LoadSpellTable", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnScenePreLoad(SceneMgr.Mode prevMode, SceneMgr.Mode mode, object userData)
        {
            object[] objArray1 = new object[] { prevMode, mode, userData };
            base.method_8("OnScenePreLoad", objArray1);
        }

        public void PreloadSpell(string tableName, SpellType type)
        {
            object[] objArray1 = new object[] { tableName, type };
            base.method_8("PreloadSpell", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }
    }
}

