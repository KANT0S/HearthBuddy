namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CardBackManager")]
    public class CardBackManager : MonoBehaviour
    {
        public CardBackManager(IntPtr address) : this(address, "CardBackManager")
        {
        }

        public CardBackManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddNewCardBack(int cardBackID)
        {
            object[] objArray1 = new object[] { cardBackID };
            base.method_8("AddNewCardBack", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FailedLoad(bool friendlySide)
        {
            object[] objArray1 = new object[] { friendlySide };
            base.method_8("FailedLoad", objArray1);
        }

        public static CardBackManager Get()
        {
            return MonoClass.smethod_15<CardBackManager>(TritonHs.MainAssemblyPath, "", "CardBackManager", "Get", Array.Empty<object>());
        }

        public CardBack GetCardBack(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            return base.method_14<CardBack>("GetCardBack", objArray1);
        }

        public string GetCardBackName(int cardBackId)
        {
            object[] objArray1 = new object[] { cardBackId };
            return base.method_13("GetCardBackName", objArray1);
        }

        public int GetDeckCardBackID(long deck)
        {
            object[] objArray1 = new object[] { deck };
            return base.method_11<int>("GetDeckCardBackID", objArray1);
        }

        public int GetDefaultCardBackID()
        {
            return base.method_11<int>("GetDefaultCardBackID", Array.Empty<object>());
        }

        public List<CardBackData> GetEnabledCardBacks()
        {
            Class267<CardBackData> class2 = base.method_14<Class267<CardBackData>>("GetEnabledCardBacks", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public CardBack GetFriendlyCardBack()
        {
            return base.method_14<CardBack>("GetFriendlyCardBack", Array.Empty<object>());
        }

        public int GetNumCardBacksOwned()
        {
            return base.method_11<int>("GetNumCardBacksOwned", Array.Empty<object>());
        }

        public int GetNumEnabledCardBacks()
        {
            return base.method_11<int>("GetNumEnabledCardBacks", Array.Empty<object>());
        }

        public CardBack GetOpponentCardBack()
        {
            return base.method_14<CardBack>("GetOpponentCardBack", Array.Empty<object>());
        }

        public List<OwnedCardBack> GetOrderedEnabledCardBacks(bool checkOwned)
        {
            object[] objArray1 = new object[] { checkOwned };
            Class267<OwnedCardBack> class2 = base.method_14<Class267<OwnedCardBack>>("GetOrderedEnabledCardBacks", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetValidCardBackID(int cardBackID)
        {
            object[] objArray1 = new object[] { cardBackID };
            return base.method_11<int>("GetValidCardBackID", objArray1);
        }

        public void InitCardBackData()
        {
            base.method_8("InitCardBackData", Array.Empty<object>());
        }

        public void InitCardBacks()
        {
            base.method_8("InitCardBacks", Array.Empty<object>());
        }

        public bool IsActorFriendly(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            return base.method_11<bool>("IsActorFriendly", objArray1);
        }

        public bool IsCardBackEnabled(int cardBackID)
        {
            object[] objArray1 = new object[] { cardBackID };
            return base.method_11<bool>("IsCardBackEnabled", objArray1);
        }

        public bool IsCardBackOwned(int cardBackID)
        {
            object[] objArray1 = new object[] { cardBackID };
            return base.method_11<bool>("IsCardBackOwned", objArray1);
        }

        public void LoadCardBack(string cardBackPath, bool friendlySide)
        {
            object[] objArray1 = new object[] { cardBackPath, friendlySide };
            base.method_8("LoadCardBack", objArray1);
        }

        public LoadCardBackData LoadCardBackByIndex(int cardBackIdx, bool unlit, string actorName)
        {
            object[] objArray1 = new object[] { cardBackIdx, unlit, actorName };
            return base.method_15<LoadCardBackData>("LoadCardBackByIndex", new Class272.Enum20[] { Class272.Enum20.I4 }, objArray1);
        }

        public void LoadDefaultCardBack()
        {
            base.method_8("LoadDefaultCardBack", Array.Empty<object>());
        }

        public void OnCardBackLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnCardBackLoaded", objArray1);
        }

        public void OnCheatOptionChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnCheatOptionChanged", objArray1);
        }

        public void OnDefaultCardBackChanged(int defaultCardBackID, object userData)
        {
            object[] objArray1 = new object[] { defaultCardBackID, userData };
            base.method_8("OnDefaultCardBackChanged", objArray1);
        }

        public void OnDefaultCardBackLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnDefaultCardBackLoaded", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnHiddenActorCardBackLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnHiddenActorCardBackLoaded", objArray1);
        }

        public void OnHiddenActorLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnHiddenActorLoaded", objArray1);
        }

        public void OnSceneChangeResetDefaultCardBack(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneChangeResetDefaultCardBack", objArray1);
        }

        public void SetCardBack(GameObject go, bool friendlySide)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { go, friendlySide };
            base.method_9("SetCardBack", enumArray1, objArray1);
        }

        public void SetCardBack(GameObject go, CardBack cardBack)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { go, cardBack };
            base.method_9("SetCardBack", enumArray1, objArray1);
        }

        public void SetCardBack(GameObject go, CardBack cardBack, bool unlit)
        {
            object[] objArray1 = new object[] { go, cardBack, unlit };
            base.method_9("SetCardBack", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void SetCardBackTexture(Renderer renderer, int matIdx, bool friendlySide)
        {
            object[] objArray1 = new object[] { renderer, matIdx, friendlySide };
            base.method_8("SetCardBackTexture", objArray1);
        }

        public void SetDeckCardBack(GameObject go, bool friendlySide)
        {
            object[] objArray1 = new object[] { go, friendlySide };
            base.method_8("SetDeckCardBack", objArray1);
        }

        public void SetDragEffects(GameObject go, bool friendlySide)
        {
            object[] objArray1 = new object[] { go, friendlySide };
            base.method_8("SetDragEffects", objArray1);
        }

        public void SetGameCardBackIDs(int friendlyCardBackID, int opponentCardBackID)
        {
            object[] objArray1 = new object[] { friendlyCardBackID, opponentCardBackID };
            base.method_8("SetGameCardBackIDs", objArray1);
        }

        public void SetTexture(Renderer renderer, int matIdx, bool friendlySide)
        {
            object[] objArray1 = new object[] { renderer, matIdx, friendlySide };
            base.method_8("SetTexture", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateAllCardBacks()
        {
            base.method_8("UpdateAllCardBacks", Array.Empty<object>());
        }

        public void UpdateCardBack(Actor actor, CardBack cardBack)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { actor, cardBack };
            base.method_9("UpdateCardBack", enumArray1, objArray1);
        }

        public void UpdateCardBack(GameObject go, bool friendlySide)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { go, friendlySide };
            base.method_9("UpdateCardBack", enumArray1, objArray1);
        }

        public void UpdateCardBackWithInternalCardBack(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("UpdateCardBackWithInternalCardBack", objArray1);
        }

        public void UpdateDeck(GameObject go, bool friendlySide)
        {
            object[] objArray1 = new object[] { go, friendlySide };
            base.method_8("UpdateDeck", objArray1);
        }

        public void UpdateDragEffect(GameObject go, bool friendlySide)
        {
            object[] objArray1 = new object[] { go, friendlySide };
            base.method_8("UpdateDragEffect", objArray1);
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public CardBack m_DefaultCardBack
        {
            get
            {
                return base.method_3<CardBack>("m_DefaultCardBack");
            }
        }

        public bool m_DefaultCardBackChangeListenerRegistered
        {
            get
            {
                return base.method_2<bool>("m_DefaultCardBackChangeListenerRegistered");
            }
        }

        public CardBack m_FriendlyCardBack
        {
            get
            {
                return base.method_3<CardBack>("m_FriendlyCardBack");
            }
        }

        public string m_FriendlyCardBackName
        {
            get
            {
                return base.method_4("m_FriendlyCardBackName");
            }
        }

        public bool m_isFriendlyLoading
        {
            get
            {
                return base.method_2<bool>("m_isFriendlyLoading");
            }
        }

        public bool m_isOpponentLoading
        {
            get
            {
                return base.method_2<bool>("m_isOpponentLoading");
            }
        }

        public CardBack m_OpponentCardBack
        {
            get
            {
                return base.method_3<CardBack>("m_OpponentCardBack");
            }
        }

        public string m_OpponentCardBackName
        {
            get
            {
                return base.method_4("m_OpponentCardBackName");
            }
        }

        public bool m_ResetDefaultRegistered
        {
            get
            {
                return base.method_2<bool>("m_ResetDefaultRegistered");
            }
        }

        [Attribute38("CardBackManager.LoadCardBackData")]
        public class LoadCardBackData : MonoClass
        {
            public LoadCardBackData(IntPtr address) : this(address, "LoadCardBackData")
            {
            }

            public LoadCardBackData(IntPtr address, string className) : base(address, className)
            {
            }

            public CardBack m_CardBack
            {
                get
                {
                    return base.method_3<CardBack>("m_CardBack");
                }
            }

            public int m_CardBackIndex
            {
                get
                {
                    return base.method_2<int>("m_CardBackIndex");
                }
            }

            public bool m_FriendlySide
            {
                get
                {
                    return base.method_2<bool>("m_FriendlySide");
                }
            }

            public GameObject m_GameObject
            {
                get
                {
                    return base.method_3<GameObject>("m_GameObject");
                }
            }

            public string m_Name
            {
                get
                {
                    return base.method_4("m_Name");
                }
            }

            public string m_Path
            {
                get
                {
                    return base.method_4("m_Path");
                }
            }

            public bool m_Unlit
            {
                get
                {
                    return base.method_2<bool>("m_Unlit");
                }
            }
        }

        [Attribute38("CardBackManager.OwnedCardBack")]
        public class OwnedCardBack : MonoClass
        {
            public OwnedCardBack(IntPtr address) : this(address, "OwnedCardBack")
            {
            }

            public OwnedCardBack(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_cardBackId
            {
                get
                {
                    return base.method_2<int>("m_cardBackId");
                }
            }

            public bool m_owned
            {
                get
                {
                    return base.method_2<bool>("m_owned");
                }
            }

            public long m_seasonId
            {
                get
                {
                    return base.method_2<long>("m_seasonId");
                }
            }

            public int m_sortCategory
            {
                get
                {
                    return base.method_2<int>("m_sortCategory");
                }
            }

            public int m_sortOrder
            {
                get
                {
                    return base.method_2<int>("m_sortOrder");
                }
            }
        }
    }
}

