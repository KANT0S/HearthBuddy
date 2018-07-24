namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DefLoader")]
    public class DefLoader : MonoClass
    {
        public DefLoader(IntPtr address) : this(address, "DefLoader")
        {
        }

        public DefLoader(IntPtr address, string className) : base(address, className)
        {
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public void ClearCardDef(string cardID)
        {
            object[] objArray1 = new object[] { cardID };
            base.method_8("ClearCardDef", objArray1);
        }

        public void ClearCardDefs()
        {
            base.method_8("ClearCardDefs", Array.Empty<object>());
        }

        public void ClearEntityDefs()
        {
            base.method_8("ClearEntityDefs", Array.Empty<object>());
        }

        public static DefLoader Get()
        {
            return MonoClass.smethod_15<DefLoader>(TritonHs.MainAssemblyPath, "", "DefLoader", "Get", Array.Empty<object>());
        }

        public CardDef GetCardDef(string cardId, CardPortraitQuality quality)
        {
            object[] objArray1 = new object[] { cardId, quality };
            return base.method_14<CardDef>("GetCardDef", objArray1);
        }

        public EntityDef GetEntityDef(int dbId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { dbId };
            return base.method_15<EntityDef>("GetEntityDef", enumArray1, objArray1);
        }

        public EntityDef GetEntityDef(string cardId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { cardId };
            return base.method_15<EntityDef>("GetEntityDef", enumArray1, objArray1);
        }

        public FullDef GetFullDef(string cardId, CardPortraitQuality quality)
        {
            object[] objArray1 = new object[] { cardId, quality };
            return base.method_14<FullDef>("GetFullDef", objArray1);
        }

        public EntityDef GetPlaceholderEntityDef()
        {
            return base.method_14<EntityDef>("GetPlaceholderEntityDef", Array.Empty<object>());
        }

        public static string GetTextureName(string path, int quality)
        {
            object[] objArray1 = new object[] { path, quality };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "DefLoader", "GetTextureName", objArray1);
        }

        public bool HasCardDef(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("HasCardDef", objArray1);
        }

        public bool HasDef(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("HasDef", objArray1);
        }

        public bool HasLoadedEntityDefs()
        {
            return base.method_11<bool>("HasLoadedEntityDefs", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public void LoadAllEntityDefs()
        {
            base.method_8("LoadAllEntityDefs", Array.Empty<object>());
        }

        public void UpdateCardAssets(CardDef cardDef, CardPortraitQuality quality)
        {
            object[] objArray1 = new object[] { cardDef, quality };
            base.method_8("UpdateCardAssets", objArray1);
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public bool m_loadedEntityDefs
        {
            get
            {
                return base.method_2<bool>("m_loadedEntityDefs");
            }
        }
    }
}

