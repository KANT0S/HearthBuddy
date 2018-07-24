namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("InnKeepersSpecial")]
    public class InnKeepersSpecial : MonoBehaviour
    {
        public InnKeepersSpecial(IntPtr address) : this(address, "InnKeepersSpecial")
        {
        }

        public InnKeepersSpecial(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Click(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("Click", objArray1);
        }

        public static ulong DateTimeToUnixTimeStamp(DateTime time)
        {
            object[] objArray1 = new object[] { time };
            return MonoClass.smethod_14<ulong>(TritonHs.MainAssemblyPath, "", "InnKeepersSpecial", "DateTimeToUnixTimeStamp", objArray1);
        }

        public static InnKeepersSpecial Get()
        {
            return MonoClass.smethod_15<InnKeepersSpecial>(TritonHs.MainAssemblyPath, "", "InnKeepersSpecial", "Get", Array.Empty<object>());
        }

        public bool HasAlreadySeenResponse()
        {
            return base.method_11<bool>("HasAlreadySeenResponse", Array.Empty<object>());
        }

        public static void Init()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "InnKeepersSpecial", "Init");
        }

        public bool LoadedSuccessfully()
        {
            return base.method_11<bool>("LoadedSuccessfully", Array.Empty<object>());
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void Show(bool visible)
        {
            object[] objArray1 = new object[] { visible };
            base.method_8("Show", objArray1);
        }

        public void ShowStore(GeneralStoreMode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("ShowStore", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public GameObject adBackground
        {
            get
            {
                return base.method_3<GameObject>("adBackground");
            }
        }

        public PegUIElement adButton
        {
            get
            {
                return base.method_3<PegUIElement>("adButton");
            }
        }

        public UberText adButtonText
        {
            get
            {
                return base.method_3<UberText>("adButtonText");
            }
        }

        public GameObject adImage
        {
            get
            {
                return base.method_3<GameObject>("adImage");
            }
        }

        public UberText adSubtitle
        {
            get
            {
                return base.method_3<UberText>("adSubtitle");
            }
        }

        public UberText adTitle
        {
            get
            {
                return base.method_3<UberText>("adTitle");
            }
        }

        public string adUrlOverride
        {
            get
            {
                return base.method_4("adUrlOverride");
            }
        }

        public GameObject content
        {
            get
            {
                return base.method_3<GameObject>("content");
            }
        }

        public string m_gameAction
        {
            get
            {
                return base.method_4("m_gameAction");
            }
        }

        public bool m_hasSeenResponse
        {
            get
            {
                return base.method_2<bool>("m_hasSeenResponse");
            }
        }

        public Dictionary<string, string> m_headers
        {
            get
            {
                Class254 class2 = base.method_3<Class254>("m_headers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_lastUrl
        {
            get
            {
                return base.method_4("m_lastUrl");
            }
        }

        public string m_link
        {
            get
            {
                return base.method_4("m_link");
            }
        }

        public bool m_loadedSuccessfully
        {
            get
            {
                return base.method_2<bool>("m_loadedSuccessfully");
            }
        }

        public GeneralStoreMode m_storeMode
        {
            get
            {
                return base.method_2<GeneralStoreMode>("m_storeMode");
            }
        }

        public string m_url
        {
            get
            {
                return base.method_4("m_url");
            }
        }
    }
}

