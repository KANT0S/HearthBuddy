namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Debug1v1Button")]
    public class Debug1v1Button : PegUIElement
    {
        public Debug1v1Button(IntPtr address) : this(address, "Debug1v1Button")
        {
        }

        public Debug1v1Button(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnCardDefLoaded(string cardID, CardDef cardDef, object userData)
        {
            object[] objArray1 = new object[] { cardID, cardDef, userData };
            base.method_8("OnCardDefLoaded", objArray1);
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public static bool HasUsedDebugMenu
        {
            get
            {
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Debug1v1Button", "get_HasUsedDebugMenu", Array.Empty<object>());
            }
        }

        public GameObject m_heroImage
        {
            get
            {
                return base.method_3<GameObject>("m_heroImage");
            }
        }

        public GameObject m_heroPowerObject
        {
            get
            {
                return base.method_3<GameObject>("m_heroPowerObject");
            }
        }

        public int m_missionId
        {
            get
            {
                return base.method_2<int>("m_missionId");
            }
        }

        public UberText m_name
        {
            get
            {
                return base.method_3<UberText>("m_name");
            }
        }
    }
}

