namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ChoiceCardMgr")]
    public class ChoiceCardMgr : MonoBehaviour
    {
        public ChoiceCardMgr(IntPtr address) : this(address, "ChoiceCardMgr")
        {
        }

        public ChoiceCardMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CancelChoices()
        {
            base.method_8("CancelChoices", Array.Empty<object>());
        }

        public void CancelSubOptions()
        {
            base.method_8("CancelSubOptions", Array.Empty<object>());
        }

        public void ChoiceButton_OnPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ChoiceButton_OnPress", objArray1);
        }

        public void ChoiceButton_OnRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ChoiceButton_OnRelease", objArray1);
        }

        public void ClearSubOptions()
        {
            base.method_8("ClearSubOptions", Array.Empty<object>());
        }

        public void DoCommonHideChoicesWork(int playerId)
        {
            object[] objArray1 = new object[] { playerId };
            base.method_8("DoCommonHideChoicesWork", objArray1);
        }

        public static ChoiceCardMgr Get()
        {
            return MonoClass.smethod_15<ChoiceCardMgr>(TritonHs.MainAssemblyPath, "", "ChoiceCardMgr", "Get", Array.Empty<object>());
        }

        public NormalButton GetChoiceButton()
        {
            return base.method_14<NormalButton>("GetChoiceButton", Array.Empty<object>());
        }

        public Spell GetChoiceEffectForCard(Triton.Game.Mapping.Entity sourceEntity, Card card)
        {
            object[] objArray1 = new object[] { sourceEntity, card };
            return base.method_14<Spell>("GetChoiceEffectForCard", objArray1);
        }

        public List<Card> GetFriendlyCards()
        {
            Class267<Card> class2 = base.method_14<Class267<Card>>("GetFriendlyCards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public PowerTaskList GetFriendlyPreChoiceTaskList()
        {
            return base.method_14<PowerTaskList>("GetFriendlyPreChoiceTaskList", Array.Empty<object>());
        }

        public PowerTaskList GetPreChoiceTaskList(int playerId)
        {
            object[] objArray1 = new object[] { playerId };
            return base.method_14<PowerTaskList>("GetPreChoiceTaskList", objArray1);
        }

        public Card GetSubOptionParentCard()
        {
            return base.method_14<Card>("GetSubOptionParentCard", Array.Empty<object>());
        }

        public bool HasChoices()
        {
            return base.method_10<bool>("HasChoices", new Class272.Enum20[0], Array.Empty<object>());
        }

        public bool HasChoices(int playerId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { playerId };
            return base.method_10<bool>("HasChoices", enumArray1, objArray1);
        }

        public bool HasFriendlyChoices()
        {
            return base.method_11<bool>("HasFriendlyChoices", Array.Empty<object>());
        }

        public bool HasSubOption()
        {
            return base.method_11<bool>("HasSubOption", Array.Empty<object>());
        }

        public void HideChoiceBanner()
        {
            base.method_8("HideChoiceBanner", Array.Empty<object>());
        }

        public void HideChoiceButton()
        {
            base.method_8("HideChoiceButton", Array.Empty<object>());
        }

        public void HideChoiceCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("HideChoiceCard", objArray1);
        }

        public void HideChoiceCards(ChoiceState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("HideChoiceCards", objArray1);
        }

        public void HideChoicesFromPacket(int playerId, ChoiceState state, Network.EntitiesChosen chosen)
        {
            object[] objArray1 = new object[] { playerId, state, chosen };
            base.method_8("HideChoicesFromPacket", objArray1);
        }

        public void HideChoiceUi()
        {
            base.method_8("HideChoiceUi", Array.Empty<object>());
        }

        public void HideSubOptions(Triton.Game.Mapping.Entity chosenEntity)
        {
            object[] objArray1 = new object[] { chosenEntity };
            base.method_8("HideSubOptions", objArray1);
        }

        public bool IsCardActorReady(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsCardActorReady", objArray1);
        }

        public bool IsCardReady(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsCardReady", objArray1);
        }

        public bool IsChoiceCardReady(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsChoiceCardReady", objArray1);
        }

        public bool IsEntityReady(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsEntityReady", objArray1);
        }

        public bool IsFriendlyShown()
        {
            return base.method_11<bool>("IsFriendlyShown", Array.Empty<object>());
        }

        public bool IsFriendlyWaitingToShowChoices()
        {
            return base.method_11<bool>("IsFriendlyWaitingToShowChoices", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public bool IsWaitingToShowChoices(int playerId)
        {
            object[] objArray1 = new object[] { playerId };
            return base.method_11<bool>("IsWaitingToShowChoices", objArray1);
        }

        public bool IsWaitingToShowSubOptions()
        {
            return base.method_11<bool>("IsWaitingToShowSubOptions", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool OnEntitiesChosenReceived(Network.EntitiesChosen chosen, Network.EntityChoices choices, object userData)
        {
            object[] objArray1 = new object[] { chosen, choices, userData };
            return base.method_11<bool>("OnEntitiesChosenReceived", objArray1);
        }

        public void OnEntityChoicesReceived(Network.EntityChoices choices, PowerTaskList preChoiceTaskList, object userData)
        {
            object[] objArray1 = new object[] { choices, preChoiceTaskList, userData };
            base.method_8("OnEntityChoicesReceived", objArray1);
        }

        public void OnGameOver(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnGameOver", objArray1);
        }

        public void OnSubOptionClicked(Triton.Game.Mapping.Entity chosenEntity)
        {
            object[] objArray1 = new object[] { chosenEntity };
            base.method_8("OnSubOptionClicked", objArray1);
        }

        public void PlayChoiceEffects(ChoiceState state, bool friendly)
        {
            object[] objArray1 = new object[] { state, friendly };
            base.method_8("PlayChoiceEffects", objArray1);
        }

        public void ShowChoiceButton()
        {
            base.method_8("ShowChoiceButton", Array.Empty<object>());
        }

        public void ShowChoiceCards(ChoiceState state, bool friendly, bool playEffects)
        {
            object[] objArray1 = new object[] { state, friendly, playEffects };
            base.method_8("ShowChoiceCards", objArray1);
        }

        public void ShowChoices(ChoiceState state, bool friendly)
        {
            object[] objArray1 = new object[] { state, friendly };
            base.method_8("ShowChoices", objArray1);
        }

        public void ShowSubOptions()
        {
            base.method_9("ShowSubOptions", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void ShowSubOptions(Card parentCard)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { parentCard };
            base.method_9("ShowSubOptions", enumArray1, objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public static Vector3 INVISIBLE_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "ChoiceCardMgr", "INVISIBLE_SCALE");
            }
        }

        public Banner m_choiceBanner
        {
            get
            {
                return base.method_3<Banner>("m_choiceBanner");
            }
        }

        public NormalButton m_choiceButton
        {
            get
            {
                return base.method_3<NormalButton>("m_choiceButton");
            }
        }

        public ChoiceData m_ChoiceData
        {
            get
            {
                return base.method_3<ChoiceData>("m_ChoiceData");
            }
        }

        public ChoiceEffectData m_ChoiceEffectData
        {
            get
            {
                return base.method_3<ChoiceEffectData>("m_ChoiceEffectData");
            }
        }

        public CommonData m_CommonData
        {
            get
            {
                return base.method_3<CommonData>("m_CommonData");
            }
        }

        public bool m_friendlyChoicesShown
        {
            get
            {
                return base.method_2<bool>("m_friendlyChoicesShown");
            }
        }

        public SubOptionData m_SubOptionData
        {
            get
            {
                return base.method_3<SubOptionData>("m_SubOptionData");
            }
        }

        public SubOptionState m_subOptionState
        {
            get
            {
                return base.method_3<SubOptionState>("m_subOptionState");
            }
        }

        [Attribute38("ChoiceCardMgr.ChoiceData")]
        public class ChoiceData : MonoClass
        {
            public ChoiceData(IntPtr address) : this(address, "ChoiceData")
            {
            }

            public ChoiceData(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_BannerBoneName
            {
                get
                {
                    return base.method_4("m_BannerBoneName");
                }
            }

            public Banner m_BannerPrefab
            {
                get
                {
                    return base.method_3<Banner>("m_BannerPrefab");
                }
            }

            public string m_ButtonBoneName
            {
                get
                {
                    return base.method_4("m_ButtonBoneName");
                }
            }

            public string m_ButtonPrefab
            {
                get
                {
                    return base.method_4("m_ButtonPrefab");
                }
            }

            public float m_CardHideTime
            {
                get
                {
                    return base.method_2<float>("m_CardHideTime");
                }
            }

            public float m_CardShowTime
            {
                get
                {
                    return base.method_2<float>("m_CardShowTime");
                }
            }

            public string m_FriendlyBoneName
            {
                get
                {
                    return base.method_4("m_FriendlyBoneName");
                }
            }

            public float m_HorizontalPadding
            {
                get
                {
                    return base.method_2<float>("m_HorizontalPadding");
                }
            }

            public float m_MinShowTime
            {
                get
                {
                    return base.method_2<float>("m_MinShowTime");
                }
            }

            public string m_OpponentBoneName
            {
                get
                {
                    return base.method_4("m_OpponentBoneName");
                }
            }

            public float m_PhoneMaxHorizontalPadding
            {
                get
                {
                    return base.method_2<float>("m_PhoneMaxHorizontalPadding");
                }
            }

            public float m_UiShowTime
            {
                get
                {
                    return base.method_2<float>("m_UiShowTime");
                }
            }
        }

        [Attribute38("ChoiceCardMgr.ChoiceEffectData")]
        public class ChoiceEffectData : MonoClass
        {
            public ChoiceEffectData(IntPtr address) : this(address, "ChoiceEffectData")
            {
            }

            public ChoiceEffectData(IntPtr address, string className) : base(address, className)
            {
            }

            public bool m_AlwaysPlayChoiceEffects
            {
                get
                {
                    return base.method_2<bool>("m_AlwaysPlayChoiceEffects");
                }
            }

            public Spell m_DiscoverCardEffect
            {
                get
                {
                    return base.method_3<Spell>("m_DiscoverCardEffect");
                }
            }
        }

        [Attribute38("ChoiceCardMgr.ChoiceState")]
        public class ChoiceState : MonoClass
        {
            public ChoiceState(IntPtr address) : this(address, "ChoiceState")
            {
            }

            public ChoiceState(IntPtr address, string className) : base(address, className)
            {
            }

            public List<Card> m_cards
            {
                get
                {
                    Class267<Card> class2 = base.method_3<Class267<Card>>("m_cards");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public PowerTaskList m_preTaskList
            {
                get
                {
                    return base.method_3<PowerTaskList>("m_preTaskList");
                }
            }

            public bool m_waitingToShow
            {
                get
                {
                    return base.method_2<bool>("m_waitingToShow");
                }
            }
        }

        [Attribute38("ChoiceCardMgr.CommonData")]
        public class CommonData : MonoClass
        {
            public CommonData(IntPtr address) : this(address, "CommonData")
            {
            }

            public CommonData(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_FriendlyCardWidth
            {
                get
                {
                    return base.method_2<float>("m_FriendlyCardWidth");
                }
            }

            public float m_OpponentCardWidth
            {
                get
                {
                    return base.method_2<float>("m_OpponentCardWidth");
                }
            }

            public int m_PhoneMaxCardsBeforeAdjusting
            {
                get
                {
                    return base.method_2<int>("m_PhoneMaxCardsBeforeAdjusting");
                }
            }

            public float m_PhoneMaxCardScale
            {
                get
                {
                    return base.method_2<float>("m_PhoneMaxCardScale");
                }
            }
        }

        [Attribute38("ChoiceCardMgr.SubOptionData")]
        public class SubOptionData : MonoClass
        {
            public SubOptionData(IntPtr address) : this(address, "SubOptionData")
            {
            }

            public SubOptionData(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_AdjacentCardXOffset
            {
                get
                {
                    return base.method_2<float>("m_AdjacentCardXOffset");
                }
            }

            public string m_BoneName
            {
                get
                {
                    return base.method_4("m_BoneName");
                }
            }

            public float m_CardShowTime
            {
                get
                {
                    return base.method_2<float>("m_CardShowTime");
                }
            }

            public float m_MinionParentXOffset
            {
                get
                {
                    return base.method_2<float>("m_MinionParentXOffset");
                }
            }

            public float m_PhoneMaxAdjacentCardXOffset
            {
                get
                {
                    return base.method_2<float>("m_PhoneMaxAdjacentCardXOffset");
                }
            }
        }

        [Attribute38("ChoiceCardMgr.SubOptionState")]
        public class SubOptionState : MonoClass
        {
            public SubOptionState(IntPtr address) : this(address, "SubOptionState")
            {
            }

            public SubOptionState(IntPtr address, string className) : base(address, className)
            {
            }

            public List<Card> m_cards
            {
                get
                {
                    Class267<Card> class2 = base.method_3<Class267<Card>>("m_cards");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public Card m_parentCard
            {
                get
                {
                    return base.method_3<Card>("m_parentCard");
                }
            }
        }
    }
}

