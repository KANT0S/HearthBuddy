namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PackOpeningCard")]
    public class PackOpeningCard : MonoBehaviour
    {
        public PackOpeningCard(IntPtr address) : this(address, "PackOpeningCard")
        {
        }

        public PackOpeningCard(IntPtr address, string className) : base(address, className)
        {
        }

        public void AttachBoosterCard(NetCache.BoosterCard boosterCard)
        {
            object[] objArray1 = new object[] { boosterCard };
            base.method_8("AttachBoosterCard", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BecomeReady()
        {
            base.method_8("BecomeReady", Array.Empty<object>());
        }

        public void Destroy()
        {
            base.method_8("Destroy", Array.Empty<object>());
        }

        public bool DetermineRarityInfo()
        {
            return base.method_11<bool>("DetermineRarityInfo", Array.Empty<object>());
        }

        public void EnableInput(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableInput", objArray1);
        }

        public void EnableRarityInfo(PackOpeningCardRarityInfo info, bool enable)
        {
            object[] objArray1 = new object[] { info, enable };
            base.method_8("EnableRarityInfo", objArray1);
        }

        public void EnableReveal(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableReveal", objArray1);
        }

        public void FireRevealedEvent()
        {
            base.method_8("FireRevealedEvent", Array.Empty<object>());
        }

        public void ForceReveal()
        {
            base.method_8("ForceReveal", Array.Empty<object>());
        }

        public Actor GetActor()
        {
            return base.method_14<Actor>("GetActor", Array.Empty<object>());
        }

        public NetCache.BoosterCard GetCard()
        {
            return base.method_14<NetCache.BoosterCard>("GetCard", Array.Empty<object>());
        }

        public CardDef GetCardDef()
        {
            return base.method_14<CardDef>("GetCardDef", Array.Empty<object>());
        }

        public string GetCardId()
        {
            return base.method_13("GetCardId", Array.Empty<object>());
        }

        public string GetClassName()
        {
            return base.method_13("GetClassName", Array.Empty<object>());
        }

        public EntityDef GetEntityDef()
        {
            return base.method_14<EntityDef>("GetEntityDef", Array.Empty<object>());
        }

        public void HideRarityGlow()
        {
            base.method_8("HideRarityGlow", Array.Empty<object>());
        }

        public bool IsInputEnabled()
        {
            return base.method_11<bool>("IsInputEnabled", Array.Empty<object>());
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public bool IsRevealed()
        {
            return base.method_11<bool>("IsRevealed", Array.Empty<object>());
        }

        public bool IsRevealEnabled()
        {
            return base.method_11<bool>("IsRevealEnabled", Array.Empty<object>());
        }

        public void OnActorLoaded(string name, GameObject actorObject, object userData)
        {
            object[] objArray1 = new object[] { name, actorObject, userData };
            base.method_8("OnActorLoaded", objArray1);
        }

        public void OnFullDefLoaded(string cardId, FullDef fullDef, object userData)
        {
            object[] objArray1 = new object[] { cardId, fullDef, userData };
            base.method_8("OnFullDefLoaded", objArray1);
        }

        public void OnOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnOut", objArray1);
        }

        public void OnOutWhileFlipped(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnOutWhileFlipped", objArray1);
        }

        public void OnOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnOver", objArray1);
        }

        public void OnOverWhileFlipped(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnOverWhileFlipped", objArray1);
        }

        public void OnPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnPress", objArray1);
        }

        public void OnSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished", objArray1);
        }

        public void PlayCorrectSound()
        {
            base.method_8("PlayCorrectSound", Array.Empty<object>());
        }

        public void RemoveOnOverWhileFlippedListeners()
        {
            base.method_8("RemoveOnOverWhileFlippedListeners", Array.Empty<object>());
        }

        public void SetupActor()
        {
            base.method_8("SetupActor", Array.Empty<object>());
        }

        public void SetupRarity()
        {
            base.method_8("SetupRarity", Array.Empty<object>());
        }

        public void ShowClassName()
        {
            base.method_8("ShowClassName", Array.Empty<object>());
        }

        public void ShowIsNew()
        {
            base.method_8("ShowIsNew", Array.Empty<object>());
        }

        public void ShowRarityGlow()
        {
            base.method_8("ShowRarityGlow", Array.Empty<object>());
        }

        public void UpdateActor()
        {
            base.method_8("UpdateActor", Array.Empty<object>());
        }

        public void UpdateInput()
        {
            base.method_8("UpdateInput", Array.Empty<object>());
        }

        public static TAG_RARITY FALLBACK_RARITY
        {
            get
            {
                return MonoClass.smethod_6<TAG_RARITY>(TritonHs.MainAssemblyPath, "", "PackOpeningCard", "FALLBACK_RARITY");
            }
        }

        public Actor m_actor
        {
            get
            {
                return base.method_3<Actor>("m_actor");
            }
        }

        public NetCache.BoosterCard m_boosterCard
        {
            get
            {
                return base.method_3<NetCache.BoosterCard>("m_boosterCard");
            }
        }

        public CardDef m_cardDef
        {
            get
            {
                return base.method_3<CardDef>("m_cardDef");
            }
        }

        public GameObject m_CardParent
        {
            get
            {
                return base.method_3<GameObject>("m_CardParent");
            }
        }

        public Spell m_ClassNameSpell
        {
            get
            {
                return base.method_3<Spell>("m_ClassNameSpell");
            }
        }

        public EntityDef m_entityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_entityDef");
            }
        }

        public bool m_inputEnabled
        {
            get
            {
                return base.method_2<bool>("m_inputEnabled");
            }
        }

        public bool m_isNew
        {
            get
            {
                return base.method_2<bool>("m_isNew");
            }
        }

        public Spell m_IsNewSpell
        {
            get
            {
                return base.method_3<Spell>("m_IsNewSpell");
            }
        }

        public TAG_PREMIUM m_premium
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("m_premium");
            }
        }

        public PackOpeningCardRarityInfo m_rarityInfo
        {
            get
            {
                return base.method_3<PackOpeningCardRarityInfo>("m_rarityInfo");
            }
        }

        public List<PackOpeningCardRarityInfo> m_RarityInfos
        {
            get
            {
                Class247<PackOpeningCardRarityInfo> class2 = base.method_3<Class247<PackOpeningCardRarityInfo>>("m_RarityInfos");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_ready
        {
            get
            {
                return base.method_2<bool>("m_ready");
            }
        }

        public PegUIElement m_revealButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_revealButton");
            }
        }

        public bool m_revealed
        {
            get
            {
                return base.method_2<bool>("m_revealed");
            }
        }

        public bool m_revealEnabled
        {
            get
            {
                return base.method_2<bool>("m_revealEnabled");
            }
        }

        public GameObject m_SharedHiddenCardObject
        {
            get
            {
                return base.method_3<GameObject>("m_SharedHiddenCardObject");
            }
        }

        public Spell m_spell
        {
            get
            {
                return base.method_3<Spell>("m_spell");
            }
        }
    }
}

