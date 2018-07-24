namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("AdventureDef")]
    public class AdventureDef : MonoBehaviour
    {
        public AdventureDef(IntPtr address) : this(address, "AdventureDef")
        {
        }

        public AdventureDef(IntPtr address, string className) : base(address, className)
        {
        }

        public AdventureDbId GetAdventureId()
        {
            return base.method_11<AdventureDbId>("GetAdventureId", Array.Empty<object>());
        }

        public string GetAdventureName()
        {
            return base.method_13("GetAdventureName", Array.Empty<object>());
        }

        public List<AdventureSubDef> GetSortedSubDefs()
        {
            Class267<AdventureSubDef> class2 = base.method_14<Class267<AdventureSubDef>>("GetSortedSubDefs", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetSortOrder()
        {
            return base.method_11<int>("GetSortOrder", Array.Empty<object>());
        }

        public AdventureSubDef GetSubDef(AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { modeId };
            return base.method_14<AdventureSubDef>("GetSubDef", objArray1);
        }

        public bool IsActiveAndPlayable()
        {
            return base.method_11<bool>("IsActiveAndPlayable", Array.Empty<object>());
        }

        public AdventureDbId m_AdventureId
        {
            get
            {
                return base.method_2<AdventureDbId>("m_AdventureId");
            }
        }

        public string m_AdventureName
        {
            get
            {
                return base.method_4("m_AdventureName");
            }
        }

        public string m_BannerRewardPrefab
        {
            get
            {
                return base.method_4("m_BannerRewardPrefab");
            }
        }

        public BannerRewardType m_BannerRewardType
        {
            get
            {
                return base.method_2<BannerRewardType>("m_BannerRewardType");
            }
        }

        public string m_ChooserButtonPrefab
        {
            get
            {
                return base.method_4("m_ChooserButtonPrefab");
            }
        }

        public string m_ChooserSubButtonPrefab
        {
            get
            {
                return base.method_4("m_ChooserSubButtonPrefab");
            }
        }

        public string m_DefaultQuotePrefab
        {
            get
            {
                return base.method_4("m_DefaultQuotePrefab");
            }
        }

        public int m_SortOrder
        {
            get
            {
                return base.method_2<int>("m_SortOrder");
            }
        }

        public string m_Texture
        {
            get
            {
                return base.method_4("m_Texture");
            }
        }

        public Vector2 m_TextureOffset
        {
            get
            {
                return base.method_2<Vector2>("m_TextureOffset");
            }
        }

        public Vector2 m_TextureTiling
        {
            get
            {
                return base.method_2<Vector2>("m_TextureTiling");
            }
        }

        public string m_WingBottomBorderPrefab
        {
            get
            {
                return base.method_4("m_WingBottomBorderPrefab");
            }
        }

        public enum BannerRewardType
        {
            AdventureCompleteReward,
            BannerManagerPopup
        }
    }
}

