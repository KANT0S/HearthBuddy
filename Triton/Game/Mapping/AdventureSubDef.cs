namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureSubDef")]
    public class AdventureSubDef : MonoBehaviour
    {
        public AdventureSubDef(IntPtr address) : this(address, "AdventureSubDef")
        {
        }

        public AdventureSubDef(IntPtr address, string className) : base(address, className)
        {
        }

        public AdventureModeDbId GetAdventureModeId()
        {
            return base.method_11<AdventureModeDbId>("GetAdventureModeId", Array.Empty<object>());
        }

        public string GetCompleteBannerText()
        {
            return base.method_13("GetCompleteBannerText", Array.Empty<object>());
        }

        public string GetDescription()
        {
            return base.method_13("GetDescription", Array.Empty<object>());
        }

        public string GetRequirementsDescription()
        {
            return base.method_13("GetRequirementsDescription", Array.Empty<object>());
        }

        public string GetShortName()
        {
            return base.method_13("GetShortName", Array.Empty<object>());
        }

        public int GetSortOrder()
        {
            return base.method_11<int>("GetSortOrder", Array.Empty<object>());
        }

        public void Init(AdventureDataDbfRecord advDataRecord)
        {
            object[] objArray1 = new object[] { advDataRecord };
            base.method_8("Init", objArray1);
        }

        public AdventureModeDbId m_AdventureModeId
        {
            get
            {
                return base.method_2<AdventureModeDbId>("m_AdventureModeId");
            }
        }

        public string m_CompleteBannerText
        {
            get
            {
                return base.method_4("m_CompleteBannerText");
            }
        }

        public string m_Description
        {
            get
            {
                return base.method_4("m_Description");
            }
        }

        public string m_RequirementsDescription
        {
            get
            {
                return base.method_4("m_RequirementsDescription");
            }
        }

        public string m_ShortName
        {
            get
            {
                return base.method_4("m_ShortName");
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

        public string m_WatermarkTexture
        {
            get
            {
                return base.method_4("m_WatermarkTexture");
            }
        }
    }
}

