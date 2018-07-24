namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("CardReward")]
    public class CardReward : Reward
    {
        public CardReward(IntPtr address) : this(address, "CardReward")
        {
        }

        public CardReward(IntPtr address, string className) : base(address, className)
        {
        }

        public void FinishSettingUpActor(Actor actor, CardDef cardDef)
        {
            object[] objArray1 = new object[] { actor, cardDef };
            base.method_8("FinishSettingUpActor", objArray1);
        }

        public void HideReward()
        {
            base.method_8("HideReward", Array.Empty<object>());
        }

        public void InitData()
        {
            base.method_8("InitData", Array.Empty<object>());
        }

        public void InitRewardText()
        {
            base.method_8("InitRewardText", Array.Empty<object>());
        }

        public void MakeActorsUnlit()
        {
            base.method_8("MakeActorsUnlit", Array.Empty<object>());
        }

        public void OnActorLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnActorLoaded", objArray1);
        }

        public void OnCardDefLoaded(string cardID, CardDef cardDef, object callbackData)
        {
            object[] objArray1 = new object[] { cardID, cardDef, callbackData };
            base.method_8("OnCardDefLoaded", objArray1);
        }

        public void OnDataSet(bool updateVisuals)
        {
            object[] objArray1 = new object[] { updateVisuals };
            base.method_8("OnDataSet", objArray1);
        }

        public void OnHeroActorLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnHeroActorLoaded", objArray1);
        }

        public void OnStartEmoteLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnStartEmoteLoaded", objArray1);
        }

        public void PlayHeroEmote()
        {
            base.method_8("PlayHeroEmote", Array.Empty<object>());
        }

        public void SetUpGoldenHeroAchieves()
        {
            base.method_8("SetUpGoldenHeroAchieves", Array.Empty<object>());
        }

        public void SetupHeroAchieves()
        {
            base.method_8("SetupHeroAchieves", Array.Empty<object>());
        }

        public void ShowReward(bool updateCacheValues)
        {
            object[] objArray1 = new object[] { updateCacheValues };
            base.method_8("ShowReward", objArray1);
        }

        public void StartSettingUpNonHeroActor(Actor actor, EntityDef entityDef, Transform parentTransform)
        {
            object[] objArray1 = new object[] { actor, entityDef, parentTransform };
            base.method_8("StartSettingUpNonHeroActor", objArray1);
        }

        public List<Actor> m_actors
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_actors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public CardRewardCount m_cardCount
        {
            get
            {
                return base.method_3<CardRewardCount>("m_cardCount");
            }
        }

        public GameObject m_cardParent
        {
            get
            {
                return base.method_3<GameObject>("m_cardParent");
            }
        }

        public GameObject m_duplicateCardParent
        {
            get
            {
                return base.method_3<GameObject>("m_duplicateCardParent");
            }
        }

        public CardSoundSpell m_emote
        {
            get
            {
                return base.method_3<CardSoundSpell>("m_emote");
            }
        }

        public GameObject m_goToRotate
        {
            get
            {
                return base.method_3<GameObject>("m_goToRotate");
            }
        }

        public GameObject m_heroCardRoot
        {
            get
            {
                return base.method_3<GameObject>("m_heroCardRoot");
            }
        }

        public GameObject m_nonHeroCardsRoot
        {
            get
            {
                return base.method_3<GameObject>("m_nonHeroCardsRoot");
            }
        }
    }
}

