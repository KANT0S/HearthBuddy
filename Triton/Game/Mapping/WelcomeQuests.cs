namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("WelcomeQuests")]
    public class WelcomeQuests : MonoBehaviour
    {
        public WelcomeQuests(IntPtr address) : this(address, "WelcomeQuests")
        {
        }

        public WelcomeQuests(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Close()
        {
            base.method_8("Close", Array.Empty<object>());
        }

        public void CloseWelcomeQuests(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("CloseWelcomeQuests", objArray1);
        }

        public void DestroyWelcomeQuests()
        {
            base.method_8("DestroyWelcomeQuests", Array.Empty<object>());
        }

        public void DoInnkeeperLine(Achievement quest)
        {
            object[] objArray1 = new object[] { quest };
            base.method_8("DoInnkeeperLine", objArray1);
        }

        public void FadeEffectsIn()
        {
            base.method_8("FadeEffectsIn", Array.Empty<object>());
        }

        public void FadeEffectsOut()
        {
            base.method_8("FadeEffectsOut", Array.Empty<object>());
        }

        public void FlipQuest(QuestTile quest)
        {
            object[] objArray1 = new object[] { quest };
            base.method_8("FlipQuest", objArray1);
        }

        public static WelcomeQuests Get()
        {
            return MonoClass.smethod_15<WelcomeQuests>(TritonHs.MainAssemblyPath, "", "WelcomeQuests", "Get", Array.Empty<object>());
        }

        public QuestTile GetFirstQuestTile()
        {
            return base.method_14<QuestTile>("GetFirstQuestTile", Array.Empty<object>());
        }

        public static void Hide()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WelcomeQuests", "Hide");
        }

        public void InitAndShow(ShowRequestData showRequestData)
        {
            object[] objArray1 = new object[] { showRequestData };
            base.method_8("InitAndShow", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public static bool OnNavigateBack()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "WelcomeQuests", "OnNavigateBack", Array.Empty<object>());
        }

        public static void OnWelcomeQuestsLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "WelcomeQuests", "OnWelcomeQuestsLoaded", objArray1);
        }

        public void ShowActiveQuests()
        {
            base.method_8("ShowActiveQuests", Array.Empty<object>());
        }

        public UberText m_allCompletedCaption
        {
            get
            {
                return base.method_3<UberText>("m_allCompletedCaption");
            }
        }

        public PegUIElement m_clickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_clickCatcher");
            }
        }

        public List<QuestTile> m_currentQuests
        {
            get
            {
                Class267<QuestTile> class2 = base.method_3<Class267<QuestTile>>("m_currentQuests");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Banner m_headlineBanner
        {
            get
            {
                return base.method_3<Banner>("m_headlineBanner");
            }
        }

        public Vector3 m_originalScale
        {
            get
            {
                return base.method_2<Vector3>("m_originalScale");
            }
        }

        public Collider m_placementCollider
        {
            get
            {
                return base.method_3<Collider>("m_placementCollider");
            }
        }

        public UberText m_questCaption
        {
            get
            {
                return base.method_3<UberText>("m_questCaption");
            }
        }

        public QuestTile m_questTilePrefab
        {
            get
            {
                return base.method_3<QuestTile>("m_questTilePrefab");
            }
        }

        public GameObject m_Root
        {
            get
            {
                return base.method_3<GameObject>("m_Root");
            }
        }

        public ShowRequestData m_showRequestData
        {
            get
            {
                return base.method_3<ShowRequestData>("m_showRequestData");
            }
        }

        [Attribute38("WelcomeQuests.ShowRequestData")]
        public class ShowRequestData : MonoClass
        {
            public ShowRequestData(IntPtr address) : this(address, "ShowRequestData")
            {
            }

            public ShowRequestData(IntPtr address, string className) : base(address, className)
            {
            }

            public bool m_fromLogin
            {
                get
                {
                    return base.method_2<bool>("m_fromLogin");
                }
            }

            public bool m_keepRichPresence
            {
                get
                {
                    return base.method_2<bool>("m_keepRichPresence");
                }
            }
        }
    }
}

