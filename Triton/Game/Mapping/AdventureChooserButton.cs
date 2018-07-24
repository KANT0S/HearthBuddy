namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureChooserButton")]
    public class AdventureChooserButton : AdventureGenericButton
    {
        public AdventureChooserButton(IntPtr address) : this(address, "AdventureChooserButton")
        {
        }

        public AdventureChooserButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool ContainsSubButton(AdventureChooserSubButton btn)
        {
            object[] objArray1 = new object[] { btn };
            return base.method_11<bool>("ContainsSubButton", objArray1);
        }

        public AdventureChooserSubButton CreateSubButton(AdventureModeDbId id, AdventureSubDef subDef, string subButtonPrefab, bool useAsLastSelected)
        {
            object[] objArray1 = new object[] { id, subDef, subButtonPrefab, useAsLastSelected };
            return base.method_14<AdventureChooserSubButton>("CreateSubButton", objArray1);
        }

        public void DisableSubButtonHighlights()
        {
            base.method_8("DisableSubButtonHighlights", Array.Empty<object>());
        }

        public void FireExpandedEvent(bool expand)
        {
            object[] objArray1 = new object[] { expand };
            base.method_8("FireExpandedEvent", objArray1);
        }

        public void FireModeSelectedEvent(AdventureChooserSubButton btn)
        {
            object[] objArray1 = new object[] { btn };
            base.method_8("FireModeSelectedEvent", objArray1);
        }

        public void FireToggleEvent()
        {
            base.method_8("FireToggleEvent", Array.Empty<object>());
        }

        public void FireVisualUpdatedEvent()
        {
            base.method_8("FireVisualUpdatedEvent", Array.Empty<object>());
        }

        public AdventureDbId GetAdventure()
        {
            return base.method_11<AdventureDbId>("GetAdventure", Array.Empty<object>());
        }

        public float GetFullButtonHeight()
        {
            return base.method_11<float>("GetFullButtonHeight", Array.Empty<object>());
        }

        public Vector3 GetHiddenPosition()
        {
            return base.method_11<Vector3>("GetHiddenPosition", Array.Empty<object>());
        }

        public Vector3 GetShowPosition()
        {
            return base.method_11<Vector3>("GetShowPosition", Array.Empty<object>());
        }

        public AdventureChooserSubButton GetSubButtonFromMode(AdventureModeDbId mode)
        {
            object[] objArray1 = new object[] { mode };
            return base.method_14<AdventureChooserSubButton>("GetSubButtonFromMode", objArray1);
        }

        public List<AdventureChooserSubButton> GetSubButtons()
        {
            Class247<AdventureChooserSubButton> class2 = base.method_14<Class247<AdventureChooserSubButton>>("GetSubButtons", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void OnButtonAnimating(Vector3 curr, float zposshowlimit)
        {
            object[] objArray1 = new object[] { curr, zposshowlimit };
            base.method_8("OnButtonAnimating", objArray1);
        }

        public void OnExpandAnimationComplete()
        {
            base.method_8("OnExpandAnimationComplete", Array.Empty<object>());
        }

        public void OnSubButtonClicked(AdventureChooserSubButton btn)
        {
            object[] objArray1 = new object[] { btn };
            base.method_8("OnSubButtonClicked", objArray1);
        }

        public void SetAdventure(AdventureDbId id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetAdventure", objArray1);
        }

        public void SetSelectSubButtonOnToggle(bool flag)
        {
            object[] objArray1 = new object[] { flag };
            base.method_8("SetSelectSubButtonOnToggle", objArray1);
        }

        public void ToggleButton(bool toggle)
        {
            object[] objArray1 = new object[] { toggle };
            base.method_8("ToggleButton", objArray1);
        }

        public void UpdateButtonPositions()
        {
            base.method_8("UpdateButtonPositions", Array.Empty<object>());
        }

        public void UpdateSubButtonsVisibility(Vector3 curr, float zposshowlimit)
        {
            object[] objArray1 = new object[] { curr, zposshowlimit };
            base.method_8("UpdateSubButtonsVisibility", objArray1);
        }

        public float ButtonBottomPadding
        {
            get
            {
                return base.method_11<float>("get_ButtonBottomPadding", Array.Empty<object>());
            }
        }

        public iTween.EaseType m_ActivateEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_ActivateEaseType");
            }
        }

        public AdventureDbId m_AdventureId
        {
            get
            {
                return base.method_2<AdventureDbId>("m_AdventureId");
            }
        }

        public float m_ButtonBottomPadding
        {
            get
            {
                return base.method_2<float>("m_ButtonBottomPadding");
            }
        }

        public StateEventTable m_ButtonStateTable
        {
            get
            {
                return base.method_3<StateEventTable>("m_ButtonStateTable");
            }
        }

        public iTween.EaseType m_DeactivateEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_DeactivateEaseType");
            }
        }

        public AdventureChooserSubButton m_LastSelectedSubButton
        {
            get
            {
                return base.method_3<AdventureChooserSubButton>("m_LastSelectedSubButton");
            }
        }

        public Vector3 m_MainButtonExtents
        {
            get
            {
                return base.method_2<Vector3>("m_MainButtonExtents");
            }
        }

        public bool m_SelectSubButtonOnToggle
        {
            get
            {
                return base.method_2<bool>("m_SelectSubButtonOnToggle");
            }
        }

        public float m_SubButtonAnimationTime
        {
            get
            {
                return base.method_2<float>("m_SubButtonAnimationTime");
            }
        }

        public GameObject m_SubButtonContainer
        {
            get
            {
                return base.method_3<GameObject>("m_SubButtonContainer");
            }
        }

        public float m_SubButtonContainerBtmPadding
        {
            get
            {
                return base.method_2<float>("m_SubButtonContainerBtmPadding");
            }
        }

        public float m_SubButtonHeight
        {
            get
            {
                return base.method_2<float>("m_SubButtonHeight");
            }
        }

        public List<AdventureChooserSubButton> m_SubButtons
        {
            get
            {
                Class267<AdventureChooserSubButton> class2 = base.method_3<Class267<AdventureChooserSubButton>>("m_SubButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_SubButtonShowPosZ
        {
            get
            {
                return base.method_2<float>("m_SubButtonShowPosZ");
            }
        }

        public float m_SubButtonVisibilityPadding
        {
            get
            {
                return base.method_2<float>("m_SubButtonVisibilityPadding");
            }
        }

        public bool m_Toggled
        {
            get
            {
                return base.method_2<bool>("m_Toggled");
            }
        }

        public static string s_EventButtonContract
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureChooserButton", "s_EventButtonContract");
            }
        }

        public static string s_EventButtonExpand
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureChooserButton", "s_EventButtonExpand");
            }
        }

        public float SubButtonContainerBtmPadding
        {
            get
            {
                return base.method_11<float>("get_SubButtonContainerBtmPadding", Array.Empty<object>());
            }
        }

        public float SubButtonHeight
        {
            get
            {
                return base.method_11<float>("get_SubButtonHeight", Array.Empty<object>());
            }
        }

        public bool Toggle
        {
            get
            {
                return base.method_11<bool>("get_Toggle", Array.Empty<object>());
            }
        }
    }
}

