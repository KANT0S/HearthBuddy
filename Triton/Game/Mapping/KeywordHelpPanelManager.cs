namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("KeywordHelpPanelManager")]
    public class KeywordHelpPanelManager : MonoBehaviour
    {
        public KeywordHelpPanelManager(IntPtr address) : this(address, "KeywordHelpPanelManager")
        {
        }

        public KeywordHelpPanelManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CleanTweensOnPanel(KeywordHelpPanel helpPanel)
        {
            object[] objArray1 = new object[] { helpPanel };
            base.method_8("CleanTweensOnPanel", objArray1);
        }

        public KeywordHelpPanel CreateKeywordPanel(int i)
        {
            object[] objArray1 = new object[] { i };
            return base.method_14<KeywordHelpPanel>("CreateKeywordPanel", objArray1);
        }

        public void DestroyKeywordPanel(KeywordHelpPanel panel)
        {
            object[] objArray1 = new object[] { panel };
            base.method_8("DestroyKeywordPanel", objArray1);
        }

        public void FadeInPanel(KeywordHelpPanel helpPanel)
        {
            object[] objArray1 = new object[] { helpPanel };
            base.method_8("FadeInPanel", objArray1);
        }

        public static KeywordHelpPanelManager Get()
        {
            return MonoClass.smethod_15<KeywordHelpPanelManager>(TritonHs.MainAssemblyPath, "", "KeywordHelpPanelManager", "Get", Array.Empty<object>());
        }

        public Card GetCard()
        {
            return base.method_14<Card>("GetCard", Array.Empty<object>());
        }

        public Vector3 GetPanelPosition(KeywordHelpPanel panel)
        {
            object[] objArray1 = new object[] { panel };
            return base.method_11<Vector3>("GetPanelPosition", objArray1);
        }

        public Vector3 GetPositionOfTopPanel()
        {
            return base.method_11<Vector3>("GetPositionOfTopPanel", Array.Empty<object>());
        }

        public string GetTextForTag(GAME_TAG tag, string key)
        {
            object[] objArray1 = new object[] { tag, key };
            return base.method_13("GetTextForTag", objArray1);
        }

        public void HideKeywordHelp()
        {
            base.method_8("HideKeywordHelp", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnSceneUnloaded(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("OnSceneUnloaded", objArray1);
        }

        public void OnUberTextFadeUpdate(float newValue)
        {
            object[] objArray1 = new object[] { newValue };
            base.method_8("OnUberTextFadeUpdate", objArray1);
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

        public void ShowKeywordHelp()
        {
            base.method_8("ShowKeywordHelp", Array.Empty<object>());
        }

        public void UpdateKeywordHelpForCollectionManager(EntityDef entityDef, Actor actor, bool reverse)
        {
            object[] objArray1 = new object[] { entityDef, actor, reverse };
            base.method_8("UpdateKeywordHelpForCollectionManager", objArray1);
        }

        public void UpdateKeywordHelpForDeckHelper(EntityDef entityDef, Actor actor)
        {
            object[] objArray1 = new object[] { entityDef, actor };
            base.method_8("UpdateKeywordHelpForDeckHelper", objArray1);
        }

        public void UpdateKeywordHelpForForge(EntityDef entityDef, Actor actor, int cardChoice)
        {
            object[] objArray1 = new object[] { entityDef, actor, cardChoice };
            base.method_8("UpdateKeywordHelpForForge", objArray1);
        }

        public void UpdateKeywordHelpForHistoryCard(Triton.Game.Mapping.Entity entity, Actor actor, UberText createdByText)
        {
            object[] objArray1 = new object[] { entity, actor, createdByText };
            base.method_8("UpdateKeywordHelpForHistoryCard", objArray1);
        }

        public void UpdateKeywordHelpForMulliganCard(Triton.Game.Mapping.Entity entity, Actor actor)
        {
            object[] objArray1 = new object[] { entity, actor };
            base.method_8("UpdateKeywordHelpForMulliganCard", objArray1);
        }

        public void UpdateKeywordHelpForPackOpening(EntityDef entityDef, Actor actor)
        {
            object[] objArray1 = new object[] { entityDef, actor };
            base.method_8("UpdateKeywordHelpForPackOpening", objArray1);
        }

        public static float DELAY_BEFORE_FADE_IN
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "KeywordHelpPanelManager", "DELAY_BEFORE_FADE_IN");
            }
        }

        public static float FADE_IN_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "KeywordHelpPanelManager", "FADE_IN_TIME");
            }
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

        public KeywordHelpPanel m_keywordPanelPrefab
        {
            get
            {
                return base.method_3<KeywordHelpPanel>("m_keywordPanelPrefab");
            }
        }

        public List<KeywordHelpPanel> m_keywordPanels
        {
            get
            {
                Class267<KeywordHelpPanel> class2 = base.method_3<Class267<KeywordHelpPanel>>("m_keywordPanels");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float scaleToUse
        {
            get
            {
                return base.method_2<float>("scaleToUse");
            }
        }
    }
}

