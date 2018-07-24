namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionSearch")]
    public class CollectionSearch : MonoBehaviour
    {
        public CollectionSearch(IntPtr address) : this(address, "CollectionSearch")
        {
        }

        public CollectionSearch(IntPtr address, string className) : base(address, className)
        {
        }

        public void Activate(bool ignoreTouchMode)
        {
            object[] objArray1 = new object[] { ignoreTouchMode };
            base.method_8("Activate", objArray1);
        }

        public void Cancel()
        {
            base.method_8("Cancel", Array.Empty<object>());
        }

        public void ClearFilter(bool updateVisuals)
        {
            object[] objArray1 = new object[] { updateVisuals };
            base.method_8("ClearFilter", objArray1);
        }

        public void ClearInput()
        {
            base.method_8("ClearInput", Array.Empty<object>());
        }

        public void Deactivate()
        {
            base.method_8("Deactivate", Array.Empty<object>());
        }

        public string GetText()
        {
            return base.method_13("GetText", Array.Empty<object>());
        }

        public void HideInput()
        {
            base.method_8("HideInput", Array.Empty<object>());
        }

        public bool IsActive()
        {
            return base.method_11<bool>("IsActive", Array.Empty<object>());
        }

        public void MoveToActiveLayer(bool saveOriginalLayer)
        {
            object[] objArray1 = new object[] { saveOriginalLayer };
            base.method_8("MoveToActiveLayer", objArray1);
        }

        public void MoveToOriginalLayer()
        {
            base.method_8("MoveToOriginalLayer", Array.Empty<object>());
        }

        public void OnActivateAnimComplete()
        {
            base.method_8("OnActivateAnimComplete", Array.Empty<object>());
        }

        public void OnBackgroundReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBackgroundReleased", objArray1);
        }

        public void OnClearReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnClearReleased", objArray1);
        }

        public void OnDeactivateAnimComplete()
        {
            base.method_8("OnDeactivateAnimComplete", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnInputCanceled(bool userRequested, GameObject requester)
        {
            object[] objArray1 = new object[] { userRequested, requester };
            base.method_8("OnInputCanceled", objArray1);
        }

        public void OnInputComplete(string input)
        {
            object[] objArray1 = new object[] { input };
            base.method_8("OnInputComplete", objArray1);
        }

        public void OnInputUpdated(string input)
        {
            object[] objArray1 = new object[] { input };
            base.method_8("OnInputUpdated", objArray1);
        }

        public void OnKeyboardHidden()
        {
            base.method_8("OnKeyboardHidden", Array.Empty<object>());
        }

        public void OnKeyboardShown()
        {
            base.method_8("OnKeyboardShown", Array.Empty<object>());
        }

        public void ResetSearchDisplay()
        {
            base.method_8("ResetSearchDisplay", Array.Empty<object>());
        }

        public void SetActiveLayer(GameLayer activeLayer)
        {
            object[] objArray1 = new object[] { activeLayer };
            base.method_8("SetActiveLayer", objArray1);
        }

        public void SetEnabled(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("SetEnabled", objArray1);
        }

        public void ShowInput(bool fromActivate)
        {
            object[] objArray1 = new object[] { fromActivate };
            base.method_8("ShowInput", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void TouchKeyboardSearchDisplay(bool fromActivate)
        {
            object[] objArray1 = new object[] { fromActivate };
            base.method_8("TouchKeyboardSearchDisplay", objArray1);
        }

        public void UpdateSearchText()
        {
            base.method_8("UpdateSearchText", Array.Empty<object>());
        }

        public static float ANIM_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionSearch", "ANIM_TIME");
            }
        }

        public GameLayer m_activeLayer
        {
            get
            {
                return base.method_2<GameLayer>("m_activeLayer");
            }
        }

        public Color m_altSearchColor
        {
            get
            {
                return base.method_2<Color>("m_altSearchColor");
            }
        }

        public Material m_altSearchMaterial
        {
            get
            {
                return base.method_3<Material>("m_altSearchMaterial");
            }
        }

        public PegUIElement m_background
        {
            get
            {
                return base.method_3<PegUIElement>("m_background");
            }
        }

        public PegUIElement m_clearButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_clearButton");
            }
        }

        public bool m_isActive
        {
            get
            {
                return base.method_2<bool>("m_isActive");
            }
        }

        public bool m_isTouchKeyboardDisplayMode
        {
            get
            {
                return base.method_2<bool>("m_isTouchKeyboardDisplayMode");
            }
        }

        public GameLayer m_originalLayer
        {
            get
            {
                return base.method_2<GameLayer>("m_originalLayer");
            }
        }

        public Material m_origSearchMaterial
        {
            get
            {
                return base.method_3<Material>("m_origSearchMaterial");
            }
        }

        public Vector3 m_origSearchPos
        {
            get
            {
                return base.method_2<Vector3>("m_origSearchPos");
            }
        }

        public string m_prevText
        {
            get
            {
                return base.method_4("m_prevText");
            }
        }

        public UberText m_searchText
        {
            get
            {
                return base.method_3<UberText>("m_searchText");
            }
        }

        public string m_text
        {
            get
            {
                return base.method_4("m_text");
            }
        }

        public GameObject m_xMesh
        {
            get
            {
                return base.method_3<GameObject>("m_xMesh");
            }
        }

        public static int MAX_SEARCH_LENGTH
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionSearch", "MAX_SEARCH_LENGTH");
            }
        }
    }
}

