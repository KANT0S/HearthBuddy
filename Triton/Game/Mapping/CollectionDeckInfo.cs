namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("CollectionDeckInfo")]
    public class CollectionDeckInfo : MonoBehaviour
    {
        public CollectionDeckInfo(IntPtr address) : this(address, "CollectionDeckInfo")
        {
        }

        public CollectionDeckInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public string GetTextForManaCost(int manaCostID)
        {
            object[] objArray1 = new object[] { manaCostID };
            return base.method_13("GetTextForManaCost", objArray1);
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void OnClosePressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnClosePressed", objArray1);
        }

        public void OnDeleteButtonConfirmationResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnDeleteButtonConfirmationResponse", objArray1);
        }

        public void OnDeleteButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeleteButtonPressed", objArray1);
        }

        public void OnGoldenHeroPowerActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnGoldenHeroPowerActorLoaded", objArray1);
        }

        public void OnHeroCardDefLoaded(string cardId, CardDef def, object userData)
        {
            object[] objArray1 = new object[] { cardId, def, userData };
            base.method_8("OnHeroCardDefLoaded", objArray1);
        }

        public void OnHeroPowerActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnHeroPowerActorLoaded", objArray1);
        }

        public void OnHeroPowerFullDefLoaded(string cardID, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardID, def, userData };
            base.method_8("OnHeroPowerFullDefLoaded", objArray1);
        }

        public void OnRenameButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRenameButtonPressed", objArray1);
        }

        public void SetDeck(CollectionDeck deck)
        {
            object[] objArray1 = new object[] { deck };
            base.method_8("SetDeck", objArray1);
        }

        public void SetHeroPowerInfo(string heroPowerCardID, FullDef def, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { heroPowerCardID, def, premium };
            base.method_8("SetHeroPowerInfo", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateManaCurve()
        {
            base.method_9("UpdateManaCurve", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void UpdateManaCurve(CollectionDeck deck)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { deck };
            base.method_9("UpdateManaCurve", enumArray1, objArray1);
        }

        public UIBButton m_deleteButton
        {
            get
            {
                return base.method_3<UIBButton>("m_deleteButton");
            }
        }

        public Actor m_goldenHeroPowerActor
        {
            get
            {
                return base.method_3<Actor>("m_goldenHeroPowerActor");
            }
        }

        public Actor m_heroPowerActor
        {
            get
            {
                return base.method_3<Actor>("m_heroPowerActor");
            }
        }

        public UberText m_heroPowerDescription
        {
            get
            {
                return base.method_3<UberText>("m_heroPowerDescription");
            }
        }

        public string m_heroPowerID
        {
            get
            {
                return base.method_4("m_heroPowerID");
            }
        }

        public UberText m_heroPowerName
        {
            get
            {
                return base.method_3<UberText>("m_heroPowerName");
            }
        }

        public GameObject m_heroPowerParent
        {
            get
            {
                return base.method_3<GameObject>("m_heroPowerParent");
            }
        }

        public List<DeckInfoManaBar> m_manaBars
        {
            get
            {
                Class267<DeckInfoManaBar> class2 = base.method_3<Class267<DeckInfoManaBar>>("m_manaBars");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_manaCurveTooltipText
        {
            get
            {
                return base.method_3<UberText>("m_manaCurveTooltipText");
            }
        }

        public PegUIElement m_offClicker
        {
            get
            {
                return base.method_3<PegUIElement>("m_offClicker");
            }
        }

        public UIBButton m_renameButton
        {
            get
            {
                return base.method_3<UIBButton>("m_renameButton");
            }
        }

        public GameObject m_renameButtonCover
        {
            get
            {
                return base.method_3<GameObject>("m_renameButtonCover");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public bool m_wasTouchModeEnabled
        {
            get
            {
                return base.method_2<bool>("m_wasTouchModeEnabled");
            }
        }

        public float MANA_COST_TEXT_MAX_LOCAL_Z
        {
            get
            {
                return base.method_2<float>("MANA_COST_TEXT_MAX_LOCAL_Z");
            }
        }

        public float MANA_COST_TEXT_MIN_LOCAL_Z
        {
            get
            {
                return base.method_2<float>("MANA_COST_TEXT_MIN_LOCAL_Z");
            }
        }

        public int MAX_MANA_COST_ID
        {
            get
            {
                return base.method_2<int>("MAX_MANA_COST_ID");
            }
        }

        public int MIN_MANA_COST_ID
        {
            get
            {
                return base.method_2<int>("MIN_MANA_COST_ID");
            }
        }
    }
}

