namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TraySection")]
    public class TraySection : MonoBehaviour
    {
        public TraySection(IntPtr address) : this(address, "TraySection")
        {
        }

        public TraySection(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearDeckInfo()
        {
            base.method_8("ClearDeckInfo", Array.Empty<object>());
        }

        public void CloseDoor()
        {
            base.method_9("CloseDoor", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void CloseDoorImmediately()
        {
            base.method_9("CloseDoorImmediately", new Class272.Enum20[0], Array.Empty<object>());
        }

        public Bounds GetDoorBounds()
        {
            return base.method_11<Bounds>("GetDoorBounds", Array.Empty<object>());
        }

        public bool HideIfNotInBounds(Bounds bounds)
        {
            object[] objArray1 = new object[] { bounds };
            return base.method_11<bool>("HideIfNotInBounds", objArray1);
        }

        public bool IsDeckBoxShown()
        {
            return base.method_11<bool>("IsDeckBoxShown", Array.Empty<object>());
        }

        public bool IsOpen()
        {
            return base.method_11<bool>("IsOpen", Array.Empty<object>());
        }

        public void OpenDoor()
        {
            base.method_9("OpenDoor", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void OpenDoorImmediately()
        {
            base.method_9("OpenDoorImmediately", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void ShowDoor(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowDoor", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static Vector3 DECKBOX_LOCAL_EULER_ANGLES
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "TraySection", "DECKBOX_LOCAL_EULER_ANGLES");
            }
        }

        public static float DOOR_ANIM_SPEED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TraySection", "DOOR_ANIM_SPEED");
            }
        }

        public string DOOR_CLOSE_ANIM_NAME
        {
            get
            {
                return base.method_4("DOOR_CLOSE_ANIM_NAME");
            }
        }

        public string DOOR_OPEN_ANIM_NAME
        {
            get
            {
                return base.method_4("DOOR_OPEN_ANIM_NAME");
            }
        }

        public CollectionDeckBoxVisual m_deckBox
        {
            get
            {
                return base.method_3<CollectionDeckBoxVisual>("m_deckBox");
            }
        }

        public bool m_deckBoxShown
        {
            get
            {
                return base.method_2<bool>("m_deckBoxShown");
            }
        }

        public GameObject m_door
        {
            get
            {
                return base.method_3<GameObject>("m_door");
            }
        }

        public bool m_inEditPosition
        {
            get
            {
                return base.method_2<bool>("m_inEditPosition");
            }
        }

        public bool m_isOpen
        {
            get
            {
                return base.method_2<bool>("m_isOpen");
            }
        }

        public bool m_wasTouchModeEnabled
        {
            get
            {
                return base.method_2<bool>("m_wasTouchModeEnabled");
            }
        }

        [Attribute38("TraySection.OnDoorStateChangedCallbackData")]
        public class OnDoorStateChangedCallbackData : MonoClass
        {
            public OnDoorStateChangedCallbackData(IntPtr address) : this(address, "OnDoorStateChangedCallbackData")
            {
            }

            public OnDoorStateChangedCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_animationName
            {
                get
                {
                    return base.method_4("m_animationName");
                }
            }

            public object m_callbackData
            {
                get
                {
                    return base.method_3<object>("m_callbackData");
                }
            }
        }
    }
}

