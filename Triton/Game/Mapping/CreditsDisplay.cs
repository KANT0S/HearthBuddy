namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CreditsDisplay")]
    public class CreditsDisplay : MonoBehaviour
    {
        public CreditsDisplay(IntPtr address) : this(address, "CreditsDisplay")
        {
        }

        public CreditsDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActorLoadedCallback(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("ActorLoadedCallback", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DropText()
        {
            base.method_8("DropText", Array.Empty<object>());
        }

        public bool EndCredits()
        {
            return base.method_11<bool>("EndCredits", Array.Empty<object>());
        }

        public void FlopCredits()
        {
            base.method_8("FlopCredits", Array.Empty<object>());
        }

        public static CreditsDisplay Get()
        {
            return MonoClass.smethod_15<CreditsDisplay>(TritonHs.MainAssemblyPath, "", "CreditsDisplay", "Get", Array.Empty<object>());
        }

        public string GetFilePath()
        {
            return base.method_13("GetFilePath", Array.Empty<object>());
        }

        public string GetNextCreditsChunk()
        {
            return base.method_13("GetNextCreditsChunk", Array.Empty<object>());
        }

        public float GetTopOfCurrentCredits()
        {
            return base.method_11<float>("GetTopOfCurrentCredits", Array.Empty<object>());
        }

        public void LoadAllCreditsCards()
        {
            base.method_8("LoadAllCreditsCards", Array.Empty<object>());
        }

        public void LoadCreditsText()
        {
            base.method_8("LoadCreditsText", Array.Empty<object>());
        }

        public void NewCard()
        {
            base.method_8("NewCard", Array.Empty<object>());
        }

        public void OnBoxOpened(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnBoxOpened", objArray1);
        }

        public void OnDestoy()
        {
            base.method_8("OnDestoy", Array.Empty<object>());
        }

        public void OnDonePressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDonePressed", objArray1);
        }

        public void OnFullDefLoaded(string cardID, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardID, def, userData };
            base.method_8("OnFullDefLoaded", objArray1);
        }

        public void OnYearPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnYearPressed", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartEndCreditsTimer()
        {
            base.method_8("StartEndCreditsTimer", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static float CREDITS_SCROLL_SPEED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CreditsDisplay", "CREDITS_SCROLL_SPEED");
            }
        }

        public Vector3 creditsRootStartLocalPosition
        {
            get
            {
                return base.method_2<Vector3>("creditsRootStartLocalPosition");
            }
        }

        public Vector3 creditsText1StartLocalPosition
        {
            get
            {
                return base.method_2<Vector3>("creditsText1StartLocalPosition");
            }
        }

        public Vector3 creditsText2StartLocalPosition
        {
            get
            {
                return base.method_2<Vector3>("creditsText2StartLocalPosition");
            }
        }

        public Transform m_cardBone
        {
            get
            {
                return base.method_3<Transform>("m_cardBone");
            }
        }

        public List<string> m_creditLines
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("m_creditLines");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<FullDef> m_creditsDefs
        {
            get
            {
                Class267<FullDef> class2 = base.method_3<Class267<FullDef>>("m_creditsDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_creditsDone
        {
            get
            {
                return base.method_2<bool>("m_creditsDone");
            }
        }

        public GameObject m_creditsRoot
        {
            get
            {
                return base.method_3<GameObject>("m_creditsRoot");
            }
        }

        public UberText m_creditsText1
        {
            get
            {
                return base.method_3<UberText>("m_creditsText1");
            }
        }

        public UberText m_creditsText2
        {
            get
            {
                return base.method_3<UberText>("m_creditsText2");
            }
        }

        public bool m_creditsTextLoaded
        {
            get
            {
                return base.method_2<bool>("m_creditsTextLoaded");
            }
        }

        public bool m_creditsTextLoadSucceeded
        {
            get
            {
                return base.method_2<bool>("m_creditsTextLoadSucceeded");
            }
        }

        public int m_currentLine
        {
            get
            {
                return base.method_2<int>("m_currentLine");
            }
        }

        public UberText m_currentText
        {
            get
            {
                return base.method_3<UberText>("m_currentText");
            }
        }

        public bool m_displayingLatestYear
        {
            get
            {
                return base.method_2<bool>("m_displayingLatestYear");
            }
        }

        public GameObject m_doneArrowInButton
        {
            get
            {
                return base.method_3<GameObject>("m_doneArrowInButton");
            }
        }

        public UIBButton m_doneButton
        {
            get
            {
                return base.method_3<UIBButton>("m_doneButton");
            }
        }

        public List<Actor> m_fakeCards
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_fakeCards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Transform m_flopPoint
        {
            get
            {
                return base.method_3<Transform>("m_flopPoint");
            }
        }

        public int m_lastCard
        {
            get
            {
                return base.method_2<int>("m_lastCard");
            }
        }

        public Transform m_offscreenCardBone
        {
            get
            {
                return base.method_3<Transform>("m_offscreenCardBone");
            }
        }

        public Actor m_shownCreditsCard
        {
            get
            {
                return base.method_3<Actor>("m_shownCreditsCard");
            }
        }

        public UIBButton m_yearButton
        {
            get
            {
                return base.method_3<UIBButton>("m_yearButton");
            }
        }

        public static int MAX_LINES_PER_CHUNK
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CreditsDisplay", "MAX_LINES_PER_CHUNK");
            }
        }

        public static string SHOW_NEW_CARD_COROUTINE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CreditsDisplay", "SHOW_NEW_CARD_COROUTINE");
            }
        }

        public static string START_CREDITS_COROUTINE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CreditsDisplay", "START_CREDITS_COROUTINE");
            }
        }

        public bool started
        {
            get
            {
                return base.method_2<bool>("started");
            }
        }
    }
}

