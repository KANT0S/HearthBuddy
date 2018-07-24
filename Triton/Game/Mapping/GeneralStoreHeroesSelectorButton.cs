namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GeneralStoreHeroesSelectorButton")]
    public class GeneralStoreHeroesSelectorButton : PegUIElement
    {
        public GeneralStoreHeroesSelectorButton(IntPtr address) : this(address, "GeneralStoreHeroesSelectorButton")
        {
        }

        public GeneralStoreHeroesSelectorButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public int GetHeroDbId()
        {
            return base.method_11<int>("GetHeroDbId", Array.Empty<object>());
        }

        public string GetHeroId()
        {
            return base.method_13("GetHeroId", Array.Empty<object>());
        }

        public bool GetPurchased()
        {
            return base.method_11<bool>("GetPurchased", Array.Empty<object>());
        }

        public bool IsAvailable()
        {
            return base.method_11<bool>("IsAvailable", Array.Empty<object>());
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void Select()
        {
            base.method_8("Select", Array.Empty<object>());
        }

        public void SetHeroIds(int heroDbId, string heroId)
        {
            object[] objArray1 = new object[] { heroDbId, heroId };
            base.method_8("SetHeroIds", objArray1);
        }

        public void SetPurchased(bool purchased)
        {
            object[] objArray1 = new object[] { purchased };
            base.method_8("SetPurchased", objArray1);
        }

        public void Unselect()
        {
            base.method_8("Unselect", Array.Empty<object>());
        }

        public void UpdateName(string name)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { name };
            base.method_9("UpdateName", enumArray1, objArray1);
        }

        public void UpdateName(GeneralStoreHeroesSelectorButton rhs)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { rhs };
            base.method_9("UpdateName", enumArray1, objArray1);
        }

        public void UpdatePortrait(GeneralStoreHeroesSelectorButton rhs)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { rhs };
            base.method_9("UpdatePortrait", enumArray1, objArray1);
        }

        public void UpdatePortrait(EntityDef entityDef, CardDef cardDef)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { entityDef, cardDef };
            base.method_9("UpdatePortrait", enumArray1, objArray1);
        }

        public CardDef m_currentCardDef
        {
            get
            {
                return base.method_3<CardDef>("m_currentCardDef");
            }
        }

        public EntityDef m_currentEntityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_currentEntityDef");
            }
        }

        public Actor m_heroActor
        {
            get
            {
                return base.method_3<Actor>("m_heroActor");
            }
        }

        public int m_heroDbId
        {
            get
            {
                return base.method_2<int>("m_heroDbId");
            }
        }

        public string m_heroId
        {
            get
            {
                return base.method_4("m_heroId");
            }
        }

        public UberText m_heroName
        {
            get
            {
                return base.method_3<UberText>("m_heroName");
            }
        }

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }

        public string m_mouseOverSound
        {
            get
            {
                return base.method_4("m_mouseOverSound");
            }
        }

        public bool m_purchased
        {
            get
            {
                return base.method_2<bool>("m_purchased");
            }
        }

        public bool m_selected
        {
            get
            {
                return base.method_2<bool>("m_selected");
            }
        }

        public string m_selectSound
        {
            get
            {
                return base.method_4("m_selectSound");
            }
        }

        public string m_unselectSound
        {
            get
            {
                return base.method_4("m_unselectSound");
            }
        }
    }
}

