namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TutorialKeywordManager")]
    public class TutorialKeywordManager : MonoBehaviour
    {
        public TutorialKeywordManager(IntPtr address) : this(address, "TutorialKeywordManager")
        {
        }

        public TutorialKeywordManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static TutorialKeywordManager Get()
        {
            return MonoClass.smethod_15<TutorialKeywordManager>(TritonHs.MainAssemblyPath, "", "TutorialKeywordManager", "Get", Array.Empty<object>());
        }

        public Card GetCard()
        {
            return base.method_14<Card>("GetCard", Array.Empty<object>());
        }

        public Vector3 GetPositionOfTopPanel()
        {
            return base.method_11<Vector3>("GetPositionOfTopPanel", Array.Empty<object>());
        }

        public void HideKeywordHelp()
        {
            base.method_8("HideKeywordHelp", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void PrepareToUpdateKeywordHelp(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("PrepareToUpdateKeywordHelp", objArray1);
        }

        public void SetupKeywordPanel(GAME_TAG tag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { tag };
            base.method_9("SetupKeywordPanel", enumArray1, objArray1);
        }

        public void SetupKeywordPanel(string headline, string description)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.String };
            object[] objArray1 = new object[] { headline, description };
            base.method_9("SetupKeywordPanel", enumArray1, objArray1);
        }

        public bool SetupKeywordPanelIfNecessary(EntityBase entityInfo, GAME_TAG tag)
        {
            object[] objArray1 = new object[] { entityInfo, tag };
            return base.method_11<bool>("SetupKeywordPanelIfNecessary", objArray1);
        }

        public void SetupKeywordRefPanel(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            base.method_8("SetupKeywordRefPanel", objArray1);
        }

        public void SetUpPanels(EntityBase entityInfo)
        {
            object[] objArray1 = new object[] { entityInfo };
            base.method_8("SetUpPanels", objArray1);
        }

        public void UpdateKeywordHelp(Card c, Actor a)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { c, a };
            base.method_9("UpdateKeywordHelp", enumArray1, objArray1);
        }

        public Actor m_actor
        {
            get
            {
                return base.method_3<Actor>("m_actor");
            }
        }

        public Card m_card
        {
            get
            {
                return base.method_3<Card>("m_card");
            }
        }

        public TutorialKeywordTooltip m_keywordPanelPrefab
        {
            get
            {
                return base.method_3<TutorialKeywordTooltip>("m_keywordPanelPrefab");
            }
        }

        public List<TutorialKeywordTooltip> m_keywordPanels
        {
            get
            {
                Class267<TutorialKeywordTooltip> class2 = base.method_3<Class267<TutorialKeywordTooltip>>("m_keywordPanels");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

