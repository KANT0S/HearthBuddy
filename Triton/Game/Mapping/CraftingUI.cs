namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("CraftingUI")]
    public class CraftingUI : MonoBehaviour
    {
        public CraftingUI(IntPtr address) : this(address, "CraftingUI")
        {
        }

        public CraftingUI(IntPtr address, string className) : base(address, className)
        {
        }

        public void CleanUpEffects()
        {
            base.method_8("CleanUpEffects", Array.Empty<object>());
        }

        public void CreateCraftNotification()
        {
            base.method_8("CreateCraftNotification", Array.Empty<object>());
        }

        public void CreateDisenchantNotification()
        {
            base.method_8("CreateDisenchantNotification", Array.Empty<object>());
        }

        public void Disable(Vector3 hidePosition)
        {
            object[] objArray1 = new object[] { hidePosition };
            base.method_8("Disable", objArray1);
        }

        public void DoCreate()
        {
            base.method_8("DoCreate", Array.Empty<object>());
        }

        public void DoDisenchant()
        {
            base.method_8("DoDisenchant", Array.Empty<object>());
        }

        public void Enable(Vector3 showPosition, Vector3 hidePosition)
        {
            object[] objArray1 = new object[] { showPosition, hidePosition };
            base.method_8("Enable", objArray1);
        }

        public int GetCardBuyValue(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_11<int>("GetCardBuyValue", objArray1);
        }

        public int GetCardSellValue(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_11<int>("GetCardSellValue", objArray1);
        }

        public void HideTips()
        {
            base.method_8("HideTips", Array.Empty<object>());
        }

        public bool IsCraftingEventForCardActive(string cardID)
        {
            object[] objArray1 = new object[] { cardID };
            return base.method_11<bool>("IsCraftingEventForCardActive", objArray1);
        }

        public bool IsEnabled()
        {
            return base.method_11<bool>("IsEnabled", Array.Empty<object>());
        }

        public void NotifyOfMouseOut()
        {
            base.method_8("NotifyOfMouseOut", Array.Empty<object>());
        }

        public void NotifyOfMouseOver()
        {
            base.method_8("NotifyOfMouseOver", Array.Empty<object>());
        }

        public void SetStartingActive()
        {
            base.method_8("SetStartingActive", Array.Empty<object>());
        }

        public void ShowFirstTimeTips()
        {
            base.method_8("ShowFirstTimeTips", Array.Empty<object>());
        }

        public void StopCurrentAnim()
        {
            base.method_8("StopCurrentAnim", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateBankText()
        {
            base.method_8("UpdateBankText", Array.Empty<object>());
        }

        public void UpdateText()
        {
            base.method_8("UpdateText", Array.Empty<object>());
        }

        public void UpdateTips()
        {
            base.method_8("UpdateTips", Array.Empty<object>());
        }

        public GameObject m_activeObject
        {
            get
            {
                return base.method_3<GameObject>("m_activeObject");
            }
        }

        public UberText m_bankAmountText
        {
            get
            {
                return base.method_3<UberText>("m_bankAmountText");
            }
        }

        public CreateButton m_buttonCreate
        {
            get
            {
                return base.method_3<CreateButton>("m_buttonCreate");
            }
        }

        public DisenchantButton m_buttonDisenchant
        {
            get
            {
                return base.method_3<DisenchantButton>("m_buttonDisenchant");
            }
        }

        public Actor m_constructingActor
        {
            get
            {
                return base.method_3<Actor>("m_constructingActor");
            }
        }

        public float m_craftDelayBeforeConstructSpell
        {
            get
            {
                return base.method_2<float>("m_craftDelayBeforeConstructSpell");
            }
        }

        public float m_craftDelayBeforeGhostDeath
        {
            get
            {
                return base.method_2<float>("m_craftDelayBeforeGhostDeath");
            }
        }

        public SoundDef m_craftingSound
        {
            get
            {
                return base.method_3<SoundDef>("m_craftingSound");
            }
        }

        public Triton.Game.Mapping.Notification m_craftNotification
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_craftNotification");
            }
        }

        public UberText m_craftValue
        {
            get
            {
                return base.method_3<UberText>("m_craftValue");
            }
        }

        public float m_disenchantDelayBeforeBallsComeOut
        {
            get
            {
                return base.method_2<float>("m_disenchantDelayBeforeBallsComeOut");
            }
        }

        public float m_disenchantDelayBeforeCardExplodes
        {
            get
            {
                return base.method_2<float>("m_disenchantDelayBeforeCardExplodes");
            }
        }

        public float m_disenchantDelayBeforeCardFlips
        {
            get
            {
                return base.method_2<float>("m_disenchantDelayBeforeCardFlips");
            }
        }

        public SoundDef m_disenchantSound
        {
            get
            {
                return base.method_3<SoundDef>("m_disenchantSound");
            }
        }

        public UberText m_disenchantValue
        {
            get
            {
                return base.method_3<UberText>("m_disenchantValue");
            }
        }

        public bool m_enabled
        {
            get
            {
                return base.method_2<bool>("m_enabled");
            }
        }

        public Actor m_explodingActor
        {
            get
            {
                return base.method_3<Actor>("m_explodingActor");
            }
        }

        public GameObject m_glowballs
        {
            get
            {
                return base.method_3<GameObject>("m_glowballs");
            }
        }

        public bool m_initializedPositions
        {
            get
            {
                return base.method_2<bool>("m_initializedPositions");
            }
        }

        public bool m_isAnimating
        {
            get
            {
                return base.method_2<bool>("m_isAnimating");
            }
        }

        public bool m_mousedOver
        {
            get
            {
                return base.method_2<bool>("m_mousedOver");
            }
        }

        public Collider m_mouseOverCollider
        {
            get
            {
                return base.method_3<Collider>("m_mouseOverCollider");
            }
        }

        public UberText m_soulboundDesc
        {
            get
            {
                return base.method_3<UberText>("m_soulboundDesc");
            }
        }

        public GameObject m_soulboundNotification
        {
            get
            {
                return base.method_3<GameObject>("m_soulboundNotification");
            }
        }

        public UberText m_soulboundTitle
        {
            get
            {
                return base.method_3<UberText>("m_soulboundTitle");
            }
        }

        public List<GameObject> m_thingsToDestroy
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_thingsToDestroy");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

