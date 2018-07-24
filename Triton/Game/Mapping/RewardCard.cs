namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RewardCard")]
    public class RewardCard : MonoBehaviour
    {
        public RewardCard(IntPtr address) : this(address, "RewardCard")
        {
        }

        public RewardCard(IntPtr address, string className) : base(address, className)
        {
        }

        public void Death()
        {
            base.method_8("Death", Array.Empty<object>());
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public void LoadCard(CardRewardData cardData, GameLayer layer)
        {
            object[] objArray1 = new object[] { cardData, layer };
            base.method_8("LoadCard", objArray1);
        }

        public void OnActorLoaded(string name, GameObject actorObject, object userData)
        {
            object[] objArray1 = new object[] { name, actorObject, userData };
            base.method_8("OnActorLoaded", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFullDefLoaded(string cardId, FullDef fullDef, object userData)
        {
            object[] objArray1 = new object[] { cardId, fullDef, userData };
            base.method_8("OnFullDefLoaded", objArray1);
        }

        public Actor m_actor
        {
            get
            {
                return base.method_3<Actor>("m_actor");
            }
        }

        public CardDef m_cardDef
        {
            get
            {
                return base.method_3<CardDef>("m_cardDef");
            }
        }

        public string m_CardID
        {
            get
            {
                return base.method_4("m_CardID");
            }
        }

        public EntityDef m_entityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_entityDef");
            }
        }

        public GameLayer m_layer
        {
            get
            {
                return base.method_2<GameLayer>("m_layer");
            }
        }

        public TAG_PREMIUM m_premium
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("m_premium");
            }
        }

        public bool m_Ready
        {
            get
            {
                return base.method_2<bool>("m_Ready");
            }
        }
    }
}

