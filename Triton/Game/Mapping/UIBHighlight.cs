namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UIBHighlight")]
    public class UIBHighlight : MonoBehaviour
    {
        public UIBHighlight(IntPtr address) : this(address, "UIBHighlight")
        {
        }

        public UIBHighlight(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void HighlightOnce()
        {
            base.method_8("HighlightOnce", Array.Empty<object>());
        }

        public void OnPress()
        {
            base.method_9("OnPress", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void OnPress(bool playSound)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { playSound };
            base.method_9("OnPress", enumArray1, objArray1);
        }

        public void OnRelease()
        {
            base.method_9("OnRelease", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void OnRelease(bool playSound)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { playSound };
            base.method_9("OnRelease", enumArray1, objArray1);
        }

        public void OnRollOut(bool force)
        {
            object[] objArray1 = new object[] { force };
            base.method_8("OnRollOut", objArray1);
        }

        public void OnRollOver(bool force)
        {
            object[] objArray1 = new object[] { force };
            base.method_8("OnRollOver", objArray1);
        }

        public void PlaySound(string soundFilePath)
        {
            object[] objArray1 = new object[] { soundFilePath };
            base.method_8("PlaySound", objArray1);
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void ResetState()
        {
            base.method_8("ResetState", Array.Empty<object>());
        }

        public void Select()
        {
            base.method_8("Select", Array.Empty<object>());
        }

        public void SelectNoSound()
        {
            base.method_8("SelectNoSound", Array.Empty<object>());
        }

        public void ShowHighlightObject(GameObject obj, bool show)
        {
            object[] objArray1 = new object[] { obj, show };
            base.method_8("ShowHighlightObject", objArray1);
        }

        public bool AlwaysOver
        {
            get
            {
                return base.method_11<bool>("get_AlwaysOver", Array.Empty<object>());
            }
        }

        public bool EnableResponse
        {
            get
            {
                return base.method_11<bool>("get_EnableResponse", Array.Empty<object>());
            }
        }

        public bool m_AllowSelection
        {
            get
            {
                return base.method_2<bool>("m_AllowSelection");
            }
        }

        public bool m_AlwaysOver
        {
            get
            {
                return base.method_2<bool>("m_AlwaysOver");
            }
        }

        public bool m_EnableResponse
        {
            get
            {
                return base.method_2<bool>("m_EnableResponse");
            }
        }

        public bool m_HideMouseOverOnPress
        {
            get
            {
                return base.method_2<bool>("m_HideMouseOverOnPress");
            }
        }

        public GameObject m_MouseDownHighlight
        {
            get
            {
                return base.method_3<GameObject>("m_MouseDownHighlight");
            }
        }

        public string m_MouseDownSound
        {
            get
            {
                return base.method_4("m_MouseDownSound");
            }
        }

        public string m_MouseOutSound
        {
            get
            {
                return base.method_4("m_MouseOutSound");
            }
        }

        public GameObject m_MouseOverHighlight
        {
            get
            {
                return base.method_3<GameObject>("m_MouseOverHighlight");
            }
        }

        public GameObject m_MouseOverSelectedHighlight
        {
            get
            {
                return base.method_3<GameObject>("m_MouseOverSelectedHighlight");
            }
        }

        public string m_MouseOverSound
        {
            get
            {
                return base.method_4("m_MouseOverSound");
            }
        }

        public GameObject m_MouseUpHighlight
        {
            get
            {
                return base.method_3<GameObject>("m_MouseUpHighlight");
            }
        }

        public string m_MouseUpSound
        {
            get
            {
                return base.method_4("m_MouseUpSound");
            }
        }

        public PegUIElement m_PegUIElement
        {
            get
            {
                return base.method_3<PegUIElement>("m_PegUIElement");
            }
        }

        public GameObject m_SelectedHighlight
        {
            get
            {
                return base.method_3<GameObject>("m_SelectedHighlight");
            }
        }

        public bool m_SelectOnRelease
        {
            get
            {
                return base.method_2<bool>("m_SelectOnRelease");
            }
        }
    }
}

