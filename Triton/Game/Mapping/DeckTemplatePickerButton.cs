namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckTemplatePickerButton")]
    public class DeckTemplatePickerButton : PegUIElement
    {
        public DeckTemplatePickerButton(IntPtr address) : this(address, "DeckTemplatePickerButton")
        {
        }

        public DeckTemplatePickerButton(IntPtr address, string className) : base(address, className)
        {
        }

        public int GetOwnedCardCount()
        {
            return base.method_11<int>("GetOwnedCardCount", Array.Empty<object>());
        }

        public bool IsStarterDeck()
        {
            return base.method_11<bool>("IsStarterDeck", Array.Empty<object>());
        }

        public void SetCardCountText(int count)
        {
            object[] objArray1 = new object[] { count };
            base.method_8("SetCardCountText", objArray1);
        }

        public void SetDeckTexture(string texturePath)
        {
            object[] objArray1 = new object[] { texturePath };
            base.method_8("SetDeckTexture", objArray1);
        }

        public void SetIsStarterDeck(bool starter)
        {
            object[] objArray1 = new object[] { starter };
            base.method_8("SetIsStarterDeck", objArray1);
        }

        public void SetSelected(bool selected)
        {
            object[] objArray1 = new object[] { selected };
            base.method_8("SetSelected", objArray1);
        }

        public void SetTitleText(string titleText)
        {
            object[] objArray1 = new object[] { titleText };
            base.method_8("SetTitleText", objArray1);
        }

        public List<UberText> m_cardCountTexts
        {
            get
            {
                Class267<UberText> class2 = base.method_3<Class267<UberText>>("m_cardCountTexts");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_completeTextRibbon
        {
            get
            {
                return base.method_3<GameObject>("m_completeTextRibbon");
            }
        }

        public MeshRenderer m_deckTexture
        {
            get
            {
                return base.method_3<MeshRenderer>("m_deckTexture");
            }
        }

        public GameObject m_incompleteTextRibbon
        {
            get
            {
                return base.method_3<GameObject>("m_incompleteTextRibbon");
            }
        }

        public bool m_isStarterDeck
        {
            get
            {
                return base.method_2<bool>("m_isStarterDeck");
            }
        }

        public int m_ownedCardCount
        {
            get
            {
                return base.method_2<int>("m_ownedCardCount");
            }
        }

        public MeshRenderer m_packRibbon
        {
            get
            {
                return base.method_3<MeshRenderer>("m_packRibbon");
            }
        }

        public GameObject m_selectGlow
        {
            get
            {
                return base.method_3<GameObject>("m_selectGlow");
            }
        }

        public UberText m_title
        {
            get
            {
                return base.method_3<UberText>("m_title");
            }
        }

        public static int s_MinimumRecommendedSize
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "DeckTemplatePickerButton", "s_MinimumRecommendedSize");
            }
        }
    }
}

