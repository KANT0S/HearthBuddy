namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GoldenHeroEvent")]
    public class GoldenHeroEvent : MonoBehaviour
    {
        public GoldenHeroEvent(IntPtr address) : this(address, "GoldenHeroEvent")
        {
        }

        public GoldenHeroEvent(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimationDone()
        {
            base.method_8("AnimationDone", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FireAnimationDoneEvent()
        {
            base.method_8("FireAnimationDoneEvent", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideTwoScoop()
        {
            base.method_8("HideTwoScoop", Array.Empty<object>());
        }

        public void LoadVanillaHeroCardDef()
        {
            base.method_8("LoadVanillaHeroCardDef", Array.Empty<object>());
        }

        public void OnVanillaHeroCardDefLoaded(string cardId, CardDef def, object userData)
        {
            object[] objArray1 = new object[] { cardId, def, userData };
            base.method_8("OnVanillaHeroCardDefLoaded", objArray1);
        }

        public void SetHeroBurnAwayTexture(Texture heroTexture)
        {
            object[] objArray1 = new object[] { heroTexture };
            base.method_8("SetHeroBurnAwayTexture", objArray1);
        }

        public void SetVictoryTwoScoop(VictoryTwoScoop twoScoop)
        {
            object[] objArray1 = new object[] { twoScoop };
            base.method_8("SetVictoryTwoScoop", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void SwapHeroToVanilla()
        {
            base.method_8("SwapHeroToVanilla", Array.Empty<object>());
        }

        public void SwapMaterialToPremium()
        {
            base.method_8("SwapMaterialToPremium", Array.Empty<object>());
        }

        public GameObject m_burningHero
        {
            get
            {
                return base.method_3<GameObject>("m_burningHero");
            }
        }

        public Transform m_heroBone
        {
            get
            {
                return base.method_3<Transform>("m_heroBone");
            }
        }

        public CardDef m_VanillaHeroCardDef
        {
            get
            {
                return base.method_3<CardDef>("m_VanillaHeroCardDef");
            }
        }

        public VictoryTwoScoop m_victoryTwoScoop
        {
            get
            {
                return base.method_3<VictoryTwoScoop>("m_victoryTwoScoop");
            }
        }
    }
}

