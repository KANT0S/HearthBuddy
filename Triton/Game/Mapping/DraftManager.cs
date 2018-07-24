namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DraftManager")]
    public class DraftManager : MonoClass
    {
        public DraftManager(IntPtr address) : this(address, "DraftManager")
        {
        }

        public DraftManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void ClearDeckInfo()
        {
            base.method_8("ClearDeckInfo", Array.Empty<object>());
        }

        public bool DeckWasActiveDuringSession()
        {
            return base.method_11<bool>("DeckWasActiveDuringSession", Array.Empty<object>());
        }

        public void FindGame()
        {
            base.method_8("FindGame", Array.Empty<object>());
        }

        public void FireDraftDeckSetEvent()
        {
            base.method_8("FireDraftDeckSetEvent", Array.Empty<object>());
        }

        public static DraftManager Get()
        {
            return MonoClass.smethod_15<DraftManager>(TritonHs.MainAssemblyPath, "", "DraftManager", "Get", Array.Empty<object>());
        }

        public CollectionDeck GetDraftDeck()
        {
            return base.method_14<CollectionDeck>("GetDraftDeck", Array.Empty<object>());
        }

        public bool GetIsNewKey()
        {
            return base.method_11<bool>("GetIsNewKey", Array.Empty<object>());
        }

        public int GetLosses()
        {
            return base.method_11<int>("GetLosses", Array.Empty<object>());
        }

        public int GetMaxWins()
        {
            return base.method_11<int>("GetMaxWins", Array.Empty<object>());
        }

        public List<RewardData> GetRewards()
        {
            Class267<RewardData> class2 = base.method_14<Class267<RewardData>>("GetRewards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetSlot()
        {
            return base.method_11<int>("GetSlot", Array.Empty<object>());
        }

        public int GetWins()
        {
            return base.method_11<int>("GetWins", Array.Empty<object>());
        }

        public void MakeChoice(int choiceNum)
        {
            object[] objArray1 = new object[] { choiceNum };
            base.method_8("MakeChoice", objArray1);
        }

        public void NotifyOfFinalGame(bool wonFinalGame)
        {
            object[] objArray1 = new object[] { wonFinalGame };
            base.method_8("NotifyOfFinalGame", objArray1);
        }

        public void OnAckRewards()
        {
            base.method_8("OnAckRewards", Array.Empty<object>());
        }

        public void OnBegin()
        {
            base.method_8("OnBegin", Array.Empty<object>());
        }

        public void OnChoicesAndContents()
        {
            base.method_8("OnChoicesAndContents", Array.Empty<object>());
        }

        public void OnChosen()
        {
            base.method_8("OnChosen", Array.Empty<object>());
        }

        public void OnDraftPurchaseAck(Network.Bundle bundle, PaymentMethod paymentMethod, object userData)
        {
            object[] objArray1 = new object[] { bundle, paymentMethod, userData };
            base.method_8("OnDraftPurchaseAck", objArray1);
        }

        public void OnError()
        {
            base.method_8("OnError", Array.Empty<object>());
        }

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
        }

        public void OnRetire()
        {
            base.method_8("OnRetire", Array.Empty<object>());
        }

        public void RegisterMatchmakerHandlers()
        {
            base.method_8("RegisterMatchmakerHandlers", Array.Empty<object>());
        }

        public void RegisterNetHandlers()
        {
            base.method_8("RegisterNetHandlers", Array.Empty<object>());
        }

        public void RegisterStoreHandlers()
        {
            base.method_8("RegisterStoreHandlers", Array.Empty<object>());
        }

        public void RemoveMatchmakerHandlers()
        {
            base.method_8("RemoveMatchmakerHandlers", Array.Empty<object>());
        }

        public void RemoveNetHandlers()
        {
            base.method_8("RemoveNetHandlers", Array.Empty<object>());
        }

        public void RemoveStoreHandlers()
        {
            base.method_8("RemoveStoreHandlers", Array.Empty<object>());
        }

        public void RequestDraftStart()
        {
            base.method_8("RequestDraftStart", Array.Empty<object>());
        }

        public int m_currentSlot
        {
            get
            {
                return base.method_2<int>("m_currentSlot");
            }
        }

        public bool m_deckActiveDuringSession
        {
            get
            {
                return base.method_2<bool>("m_deckActiveDuringSession");
            }
        }

        public CollectionDeck m_draftDeck
        {
            get
            {
                return base.method_3<CollectionDeck>("m_draftDeck");
            }
        }

        public bool m_isNewKey
        {
            get
            {
                return base.method_2<bool>("m_isNewKey");
            }
        }

        public int m_losses
        {
            get
            {
                return base.method_2<int>("m_losses");
            }
        }

        public int m_maxWins
        {
            get
            {
                return base.method_2<int>("m_maxWins");
            }
        }

        public int m_validSlot
        {
            get
            {
                return base.method_2<int>("m_validSlot");
            }
        }

        public int m_wins
        {
            get
            {
                return base.method_2<int>("m_wins");
            }
        }
    }
}

