namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DebugMissionButton")]
    public class DebugMissionButton : PegUIElement
    {
        public DebugMissionButton(IntPtr address) : this(address, "DebugMissionButton")
        {
        }

        public DebugMissionButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnCardDefLoaded(string cardID, CardDef cardDef, object userData)
        {
            object[] objArray1 = new object[] { cardID, cardDef, userData };
            base.method_8("OnCardDefLoaded", objArray1);
        }

        public void OnHeroPowerActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnHeroPowerActorLoaded", objArray1);
        }

        public void OnHeroPowerDefLoaded(string cardID, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardID, def, userData };
            base.method_8("OnHeroPowerDefLoaded", objArray1);
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

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public string m_characterPrefabName
        {
            get
            {
                return base.method_4("m_characterPrefabName");
            }
        }

        public GameObject m_heroImage
        {
            get
            {
                return base.method_3<GameObject>("m_heroImage");
            }
        }

        public Actor m_heroPowerActor
        {
            get
            {
                return base.method_3<Actor>("m_heroPowerActor");
            }
        }

        public FullDef m_heroPowerDef
        {
            get
            {
                return base.method_3<FullDef>("m_heroPowerDef");
            }
        }

        public GameObject m_heroPowerObject
        {
            get
            {
                return base.method_3<GameObject>("m_heroPowerObject");
            }
        }

        public string m_introline
        {
            get
            {
                return base.method_4("m_introline");
            }
        }

        public int m_missionId
        {
            get
            {
                return base.method_2<int>("m_missionId");
            }
        }

        public bool m_mousedOver
        {
            get
            {
                return base.method_2<bool>("m_mousedOver");
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

