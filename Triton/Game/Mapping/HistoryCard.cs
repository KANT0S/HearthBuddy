namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("HistoryCard")]
    public class HistoryCard : HistoryItem
    {
        public HistoryCard(IntPtr address) : this(address, "HistoryCard")
        {
        }

        public HistoryCard(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddHistoryChild(HistoryChildCard childCard)
        {
            object[] objArray1 = new object[] { childCard };
            base.method_8("AddHistoryChild", objArray1);
        }

        public void AssignMaterials(CardDef cardDef)
        {
            object[] objArray1 = new object[] { cardDef };
            base.method_8("AssignMaterials", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool ChildrenLoaded()
        {
            return base.method_11<bool>("ChildrenLoaded", Array.Empty<object>());
        }

        public bool GetHalfSize()
        {
            return base.method_11<bool>("GetHalfSize", Array.Empty<object>());
        }

        public Vector3 GetHistoryTokenScale()
        {
            return base.method_11<Vector3>("GetHistoryTokenScale", Array.Empty<object>());
        }

        public Collider GetTileCollider()
        {
            return base.method_14<Collider>("GetTileCollider", Array.Empty<object>());
        }

        public float GetZOffsetForThisTilesMouseOverCard()
        {
            return base.method_11<float>("GetZOffsetForThisTilesMouseOverCard", Array.Empty<object>());
        }

        public bool HasBeenShown()
        {
            return base.method_11<bool>("HasBeenShown", Array.Empty<object>());
        }

        public void InitDisplayedCreator()
        {
            base.method_8("InitDisplayedCreator", Array.Empty<object>());
        }

        public void LoadArrow()
        {
            base.method_8("LoadArrow", Array.Empty<object>());
        }

        public void LoadAttackTileActor()
        {
            base.method_8("LoadAttackTileActor", Array.Empty<object>());
        }

        public void LoadBigCardActor(bool andShowBigCard)
        {
            object[] objArray1 = new object[] { andShowBigCard };
            base.method_8("LoadBigCardActor", objArray1);
        }

        public void LoadBigCardActorCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadBigCardActorCallback", objArray1);
        }

        public void LoadCorrectTileActor(HistoryInfo sourceCard)
        {
            object[] objArray1 = new object[] { sourceCard };
            base.method_8("LoadCorrectTileActor", objArray1);
        }

        public void LoadCrossedSwords()
        {
            base.method_8("LoadCrossedSwords", Array.Empty<object>());
        }

        public void LoadSeparatorCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadSeparatorCallback", objArray1);
        }

        public void LoadTileActor()
        {
            base.method_8("LoadTileActor", Array.Empty<object>());
        }

        public void LoadTileActorCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadTileActorCallback", objArray1);
        }

        public void LoadTriggerTileActor()
        {
            base.method_8("LoadTriggerTileActor", Array.Empty<object>());
        }

        public void LoadWeaponBreakActor()
        {
            base.method_8("LoadWeaponBreakActor", Array.Empty<object>());
        }

        public void MarkAsShown()
        {
            base.method_8("MarkAsShown", Array.Empty<object>());
        }

        public void NotifyMousedOut()
        {
            base.method_8("NotifyMousedOut", Array.Empty<object>());
        }

        public void NotifyMousedOver()
        {
            base.method_8("NotifyMousedOver", Array.Empty<object>());
        }

        public void NotifyOfSecretFinished()
        {
            base.method_8("NotifyOfSecretFinished", Array.Empty<object>());
        }

        public void OnPathComplete()
        {
            base.method_8("OnPathComplete", Array.Empty<object>());
        }

        public void PositionMouseOverCard()
        {
            base.method_8("PositionMouseOverCard", Array.Empty<object>());
        }

        public void RunCallbackNow()
        {
            base.method_8("RunCallbackNow", Array.Empty<object>());
        }

        public void SetFatigue(Texture bigTexture)
        {
            object[] objArray1 = new object[] { bigTexture };
            base.method_8("SetFatigue", objArray1);
        }

        public void SetHeroPowerFrontTexture(Texture frontTex)
        {
            object[] objArray1 = new object[] { frontTex };
            base.method_8("SetHeroPowerFrontTexture", objArray1);
        }

        public void ShowDisplayedCreator()
        {
            base.method_8("ShowDisplayedCreator", Array.Empty<object>());
        }

        public bool WasCountered()
        {
            return base.method_11<bool>("WasCountered", Array.Empty<object>());
        }

        public static float ABILITY_CARD_ANIMATE_TO_BIG_CARD_AREA_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryCard", "ABILITY_CARD_ANIMATE_TO_BIG_CARD_AREA_TIME");
            }
        }

        public static float BIG_CARD_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryCard", "BIG_CARD_SCALE");
            }
        }

        public static string CREATED_BY_BONE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "HistoryCard", "CREATED_BY_BONE_NAME");
            }
        }

        public bool finishedCallbackHasRun
        {
            get
            {
                return base.method_2<bool>("finishedCallbackHasRun");
            }
        }

        public Color FRIENDLY_COLOR
        {
            get
            {
                return base.method_2<Color>("FRIENDLY_COLOR");
            }
        }

        public bool halfSize
        {
            get
            {
                return base.method_2<bool>("halfSize");
            }
        }

        public bool hasBeenShown
        {
            get
            {
                return base.method_2<bool>("hasBeenShown");
            }
        }

        public List<HistoryChildCard> historyChildren
        {
            get
            {
                Class267<HistoryChildCard> class2 = base.method_3<Class267<HistoryChildCard>>("historyChildren");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_createdByText
        {
            get
            {
                return base.method_3<UberText>("m_createdByText");
            }
        }

        public Material m_fullHistory
        {
            get
            {
                return base.method_3<Material>("m_fullHistory");
            }
        }

        public bool m_gameEntityMousedOver
        {
            get
            {
                return base.method_2<bool>("m_gameEntityMousedOver");
            }
        }

        public Material m_halfHistory
        {
            get
            {
                return base.method_3<Material>("m_halfHistory");
            }
        }

        public bool m_haveDisplayedCreator
        {
            get
            {
                return base.method_2<bool>("m_haveDisplayedCreator");
            }
        }

        public Texture m_HeroPowerFrontTex
        {
            get
            {
                return base.method_3<Texture>("m_HeroPowerFrontTex");
            }
        }

        public List<HistoryManager.HistoryCallbackData> m_loadChildrenInfo
        {
            get
            {
                Class267<HistoryManager.HistoryCallbackData> class2 = base.method_3<Class267<HistoryManager.HistoryCallbackData>>("m_loadChildrenInfo");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_numChildrenToLoad
        {
            get
            {
                return base.method_2<int>("m_numChildrenToLoad");
            }
        }

        public Actor m_tileActor
        {
            get
            {
                return base.method_3<Actor>("m_tileActor");
            }
        }

        public static float MAX_WIDTH_OF_CHILDREN
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryCard", "MAX_WIDTH_OF_CHILDREN");
            }
        }

        public static float MOUSE_OVER_HEIGHT_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryCard", "MOUSE_OVER_HEIGHT_OFFSET");
            }
        }

        public static float MOUSE_OVER_Z_OFFSET_BOTTOM
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryCard", "MOUSE_OVER_Z_OFFSET_BOTTOM");
            }
        }

        public static float MOUSE_OVER_Z_OFFSET_PHONE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryCard", "MOUSE_OVER_Z_OFFSET_PHONE");
            }
        }

        public static float MOUSE_OVER_Z_OFFSET_SECRET_PHONE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryCard", "MOUSE_OVER_Z_OFFSET_SECRET_PHONE");
            }
        }

        public static float MOUSE_OVER_Z_OFFSET_TOP
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryCard", "MOUSE_OVER_Z_OFFSET_TOP");
            }
        }

        public bool mousedOver
        {
            get
            {
                return base.method_2<bool>("mousedOver");
            }
        }

        public Color OPPONENT_COLOR
        {
            get
            {
                return base.method_2<Color>("OPPONENT_COLOR");
            }
        }

        public bool secretFinished
        {
            get
            {
                return base.method_2<bool>("secretFinished");
            }
        }

        public Actor seperator
        {
            get
            {
                return base.method_3<Actor>("seperator");
            }
        }

        public bool seperatorStartedLoading
        {
            get
            {
                return base.method_2<bool>("seperatorStartedLoading");
            }
        }

        public static float TIME_TO_WAIT_BEFORE_RUNNING_SPELL_EFFECTS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryCard", "TIME_TO_WAIT_BEFORE_RUNNING_SPELL_EFFECTS");
            }
        }

        public bool waitingForSecretToFinish
        {
            get
            {
                return base.method_2<bool>("waitingForSecretToFinish");
            }
        }

        public bool wasCountered
        {
            get
            {
                return base.method_2<bool>("wasCountered");
            }
        }
    }
}

