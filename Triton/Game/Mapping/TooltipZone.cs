namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TooltipZone")]
    public class TooltipZone : MonoBehaviour
    {
        public TooltipZone(IntPtr address) : this(address, "TooltipZone")
        {
        }

        public TooltipZone(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnchorTooltipTo(GameObject target, Anchor targetAnchorPoint, Anchor tooltipAnchorPoint)
        {
            object[] objArray1 = new object[] { target, targetAnchorPoint, tooltipAnchorPoint };
            base.method_8("AnchorTooltipTo", objArray1);
        }

        public GameObject GetTooltipObject()
        {
            return base.method_14<GameObject>("GetTooltipObject", Array.Empty<object>());
        }

        public void HideTooltip()
        {
            base.method_8("HideTooltip", Array.Empty<object>());
        }

        public bool IsShowingTooltip()
        {
            return base.method_11<bool>("IsShowingTooltip", Array.Empty<object>());
        }

        public void ShowBoxTooltip(string headline, string bodytext)
        {
            object[] objArray1 = new object[] { headline, bodytext };
            base.method_8("ShowBoxTooltip", objArray1);
        }

        public void ShowGameplayTooltip(string headline, string bodytext)
        {
            object[] objArray1 = new object[] { headline, bodytext };
            base.method_8("ShowGameplayTooltip", objArray1);
        }

        public void ShowGameplayTooltipLarge(string headline, string bodytext)
        {
            object[] objArray1 = new object[] { headline, bodytext };
            base.method_8("ShowGameplayTooltipLarge", objArray1);
        }

        public KeywordHelpPanel ShowLayerTooltip(string headline, string bodytext)
        {
            object[] objArray1 = new object[] { headline, bodytext };
            return base.method_14<KeywordHelpPanel>("ShowLayerTooltip", objArray1);
        }

        public void ShowSocialTooltip(Component target, string headline, string bodytext, float scale, GameLayer layer)
        {
            object[] objArray1 = new object[] { target, headline, bodytext, scale, layer };
            base.method_9("ShowSocialTooltip", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void ShowSocialTooltip(GameObject targetObject, string headline, string bodytext, float scale, GameLayer layer)
        {
            object[] objArray1 = new object[] { targetObject, headline, bodytext, scale, layer };
            base.method_9("ShowSocialTooltip", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public KeywordHelpPanel ShowTooltip(string headline, string bodytext)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.String };
            object[] objArray1 = new object[] { headline, bodytext };
            return base.method_15<KeywordHelpPanel>("ShowTooltip", enumArray1, objArray1);
        }

        public KeywordHelpPanel ShowTooltip(string headline, string bodytext, float scale, bool enablePhoneScale)
        {
            object[] objArray1 = new object[] { headline, bodytext, scale, enablePhoneScale };
            return base.method_15<KeywordHelpPanel>("ShowTooltip", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public GameObject m_tooltip
        {
            get
            {
                return base.method_3<GameObject>("m_tooltip");
            }
        }

        public GameObject targetObject
        {
            get
            {
                return base.method_3<GameObject>("targetObject");
            }
        }

        public Transform tooltipDisplayLocation
        {
            get
            {
                return base.method_3<Transform>("tooltipDisplayLocation");
            }
        }

        public GameObject tooltipPrefab
        {
            get
            {
                return base.method_3<GameObject>("tooltipPrefab");
            }
        }

        public Transform touchTooltipLocation
        {
            get
            {
                return base.method_3<Transform>("touchTooltipLocation");
            }
        }
    }
}

