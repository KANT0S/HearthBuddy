namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PracticeAIButton")]
    public class PracticeAIButton : PegUIElement
    {
        public PracticeAIButton(IntPtr address) : this(address, "PracticeAIButton")
        {
        }

        public PracticeAIButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void CoverUp(bool flip)
        {
            object[] objArray1 = new object[] { flip };
            base.method_8("CoverUp", objArray1);
        }

        public void Depress()
        {
            base.method_8("Depress", Array.Empty<object>());
        }

        public void Deselect()
        {
            base.method_8("Deselect", Array.Empty<object>());
        }

        public void Flip()
        {
            base.method_8("Flip", Array.Empty<object>());
        }

        public TAG_CLASS GetClass()
        {
            return base.method_11<TAG_CLASS>("GetClass", Array.Empty<object>());
        }

        public long GetDeckID()
        {
            return base.method_11<long>("GetDeckID", Array.Empty<object>());
        }

        public GameObject GetHiddenCover()
        {
            return base.method_14<GameObject>("GetHiddenCover", Array.Empty<object>());
        }

        public Material GetHiddenMaterial()
        {
            return base.method_14<Material>("GetHiddenMaterial", Array.Empty<object>());
        }

        public UberText GetHiddenNameMesh()
        {
            return base.method_14<UberText>("GetHiddenNameMesh", Array.Empty<object>());
        }

        public int GetMissionID()
        {
            return base.method_11<int>("GetMissionID", Array.Empty<object>());
        }

        public GameObject GetShowingCover()
        {
            return base.method_14<GameObject>("GetShowingCover", Array.Empty<object>());
        }

        public Material GetShowingMaterial()
        {
            return base.method_14<Material>("GetShowingMaterial", Array.Empty<object>());
        }

        public UberText GetShowingNameMesh()
        {
            return base.method_14<UberText>("GetShowingNameMesh", Array.Empty<object>());
        }

        public void Lock(bool locked)
        {
            object[] objArray1 = new object[] { locked };
            base.method_8("Lock", objArray1);
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void PlayUnlockGlow()
        {
            base.method_8("PlayUnlockGlow", Array.Empty<object>());
        }

        public void Raise()
        {
            base.method_9("Raise", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Raise(float time)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4 };
            object[] objArray1 = new object[] { time };
            base.method_9("Raise", enumArray1, objArray1);
        }

        public void Select()
        {
            base.method_8("Select", Array.Empty<object>());
        }

        public void SetButtonClass(TAG_CLASS buttonClass)
        {
            object[] objArray1 = new object[] { buttonClass };
            base.method_8("SetButtonClass", objArray1);
        }

        public void SetDeckID(long deckID)
        {
            object[] objArray1 = new object[] { deckID };
            base.method_8("SetDeckID", objArray1);
        }

        public void SetHiddenMaterial(Material mat)
        {
            object[] objArray1 = new object[] { mat };
            base.method_8("SetHiddenMaterial", objArray1);
        }

        public void SetInfo(string name, TAG_CLASS buttonClass, CardDef cardDef, int missionID, bool flip)
        {
            object[] objArray1 = new object[] { name, buttonClass, cardDef, missionID, flip };
            base.method_9("SetInfo", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void SetInfo(string name, TAG_CLASS buttonClass, CardDef cardDef, long deckID, bool flip)
        {
            object[] objArray1 = new object[] { name, buttonClass, cardDef, deckID, flip };
            base.method_9("SetInfo", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void SetInfo(string name, TAG_CLASS buttonClass, CardDef cardDef, int missionID, long deckID, bool flip)
        {
            object[] objArray1 = new object[] { name, buttonClass, cardDef, missionID, deckID, flip };
            base.method_9("SetInfo", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void SetMissionID(int missionID)
        {
            object[] objArray1 = new object[] { missionID };
            base.method_8("SetMissionID", objArray1);
        }

        public void SetShowingMaterial(Material mat)
        {
            object[] objArray1 = new object[] { mat };
            base.method_8("SetShowingMaterial", objArray1);
        }

        public void ShowQuestBang(bool shown)
        {
            object[] objArray1 = new object[] { shown };
            base.method_8("ShowQuestBang", objArray1);
        }

        public string FLIP_COROUTINE
        {
            get
            {
                return base.method_4("FLIP_COROUTINE");
            }
        }

        public static float FLIPPED_X_ROTATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "PracticeAIButton", "FLIPPED_X_ROTATION");
            }
        }

        public Vector3 GLOW_QUAD_FLIPPED_LOCAL_POS
        {
            get
            {
                return base.method_2<Vector3>("GLOW_QUAD_FLIPPED_LOCAL_POS");
            }
        }

        public Vector3 GLOW_QUAD_NORMAL_LOCAL_POS
        {
            get
            {
                return base.method_2<Vector3>("GLOW_QUAD_NORMAL_LOCAL_POS");
            }
        }

        public GameObject m_backsideCover
        {
            get
            {
                return base.method_3<GameObject>("m_backsideCover");
            }
        }

        public UberText m_backsideName
        {
            get
            {
                return base.method_3<UberText>("m_backsideName");
            }
        }

        public TAG_CLASS m_class
        {
            get
            {
                return base.method_2<TAG_CLASS>("m_class");
            }
        }

        public bool m_covered
        {
            get
            {
                return base.method_2<bool>("m_covered");
            }
        }

        public Transform m_coveredBone
        {
            get
            {
                return base.method_3<Transform>("m_coveredBone");
            }
        }

        public long m_deckID
        {
            get
            {
                return base.method_2<long>("m_deckID");
            }
        }

        public Transform m_downBone
        {
            get
            {
                return base.method_3<Transform>("m_downBone");
            }
        }

        public GameObject m_frontCover
        {
            get
            {
                return base.method_3<GameObject>("m_frontCover");
            }
        }

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }

        public bool m_infoSet
        {
            get
            {
                return base.method_2<bool>("m_infoSet");
            }
        }

        public bool m_locked
        {
            get
            {
                return base.method_2<bool>("m_locked");
            }
        }

        public int m_missionID
        {
            get
            {
                return base.method_2<int>("m_missionID");
            }
        }

        public UberText m_name
        {
            get
            {
                return base.method_3<UberText>("m_name");
            }
        }

        public int m_PortraitMaterialIdx
        {
            get
            {
                return base.method_2<int>("m_PortraitMaterialIdx");
            }
        }

        public GameObject m_questBang
        {
            get
            {
                return base.method_3<GameObject>("m_questBang");
            }
        }

        public GameObject m_rootObject
        {
            get
            {
                return base.method_3<GameObject>("m_rootObject");
            }
        }

        public GameObject m_unlockEffect
        {
            get
            {
                return base.method_3<GameObject>("m_unlockEffect");
            }
        }

        public Transform m_upBone
        {
            get
            {
                return base.method_3<Transform>("m_upBone");
            }
        }

        public bool m_usingBackside
        {
            get
            {
                return base.method_2<bool>("m_usingBackside");
            }
        }

        public static float NORMAL_X_ROTATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "PracticeAIButton", "NORMAL_X_ROTATION");
            }
        }
    }
}

