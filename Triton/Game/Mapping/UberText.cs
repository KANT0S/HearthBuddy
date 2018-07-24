namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("UberText")]
    public class UberText : MonoBehaviour
    {
        public UberText(IntPtr address) : this(address, "UberText")
        {
        }

        public UberText(IntPtr address, string className) : base(address, className)
        {
        }

        public LocalizationSettings.LocaleAdjustment AddLocaleAdjustment(Locale locale)
        {
            object[] objArray1 = new object[] { locale };
            return base.method_14<LocalizationSettings.LocaleAdjustment>("AddLocaleAdjustment", objArray1);
        }

        public void AntiAliasRender()
        {
            base.method_8("AntiAliasRender", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Bold()
        {
            base.method_8("Bold", Array.Empty<object>());
        }

        public List<string> BreakStringIntoWords(string text)
        {
            object[] objArray1 = new object[] { text };
            Class245 class2 = base.method_14<Class245>("BreakStringIntoWords", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Vector2 CalcTextureSize()
        {
            return base.method_11<Vector2>("CalcTextureSize", Array.Empty<object>());
        }

        public bool CanWrapBetween(int lastChar, int wideChar, int nextChar)
        {
            object[] objArray1 = new object[] { lastChar, wideChar, nextChar };
            return base.method_11<bool>("CanWrapBetween", objArray1);
        }

        public void CleanUp()
        {
            base.method_8("CleanUp", Array.Empty<object>());
        }

        public static void CreateCacheFolder()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "UberText", "CreateCacheFolder");
        }

        public void CreateCamera()
        {
            base.method_8("CreateCamera", Array.Empty<object>());
        }

        public void CreateEditorRoot()
        {
            base.method_8("CreateEditorRoot", Array.Empty<object>());
        }

        public void CreateRenderPlane()
        {
            base.method_8("CreateRenderPlane", Array.Empty<object>());
        }

        public void CreateTextMesh()
        {
            base.method_8("CreateTextMesh", Array.Empty<object>());
        }

        public void CreateTexture()
        {
            base.method_8("CreateTexture", Array.Empty<object>());
        }

        public static void DeleteOldCacheFiles()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "UberText", "DeleteOldCacheFiles");
        }

        public void DestroyCamera()
        {
            base.method_8("DestroyCamera", Array.Empty<object>());
        }

        public void DestroyChildren()
        {
            base.method_8("DestroyChildren", Array.Empty<object>());
        }

        public void DestroyRenderPlane()
        {
            base.method_8("DestroyRenderPlane", Array.Empty<object>());
        }

        public void DestroyShadow()
        {
            base.method_8("DestroyShadow", Array.Empty<object>());
        }

        public void DestroyTextMesh()
        {
            base.method_8("DestroyTextMesh", Array.Empty<object>());
        }

        public void DestroyTexture()
        {
            base.method_8("DestroyTexture", Array.Empty<object>());
        }

        public void EditorAwake()
        {
            base.method_8("EditorAwake", Array.Empty<object>());
        }

        public static List<UberText> EnableAllTextInObject(GameObject obj, bool enable)
        {
            object[] objArray1 = new object[] { obj, enable };
            Class247<UberText> class2 = MonoClass.smethod_15<Class247<UberText>>(TritonHs.MainAssemblyPath, "", "UberText", "EnableAllTextInObject", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void FindSupportedTextureFormat()
        {
            base.method_8("FindSupportedTextureFormat", Array.Empty<object>());
        }

        public string FixThai(string text)
        {
            object[] objArray1 = new object[] { text };
            return base.method_13("FixThai", objArray1);
        }

        public float GetActualCharacterSize()
        {
            return base.method_11<float>("GetActualCharacterSize", Array.Empty<object>());
        }

        public LocalizationSettings GetAllLocalizationSettings()
        {
            return base.method_14<LocalizationSettings>("GetAllLocalizationSettings", Array.Empty<object>());
        }

        public Bounds GetBounds()
        {
            return base.method_11<Bounds>("GetBounds", Array.Empty<object>());
        }

        public static string GetCacheFilePath()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "UberText", "GetCacheFilePath", Array.Empty<object>());
        }

        public static string GetCacheFolderPath()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "UberText", "GetCacheFolderPath", Array.Empty<object>());
        }

        public Texture GetFontTexture()
        {
            return base.method_14<Texture>("GetFontTexture", Array.Empty<object>());
        }

        public int GetLineCount()
        {
            return base.method_11<int>("GetLineCount", Array.Empty<object>());
        }

        public LocalizationSettings.LocaleAdjustment GetLocaleAdjustment(Locale locale)
        {
            object[] objArray1 = new object[] { locale };
            return base.method_14<LocalizationSettings.LocaleAdjustment>("GetLocaleAdjustment", objArray1);
        }

        public Vector3 GetLocalizationPositionOffset()
        {
            return base.method_11<Vector3>("GetLocalizationPositionOffset", Array.Empty<object>());
        }

        public Vector3 GetLossyWorldScale(Transform xform)
        {
            object[] objArray1 = new object[] { xform };
            return base.method_11<Vector3>("GetLossyWorldScale", objArray1);
        }

        public Bounds GetTextBounds()
        {
            return base.method_11<Bounds>("GetTextBounds", Array.Empty<object>());
        }

        public Bounds GetTextWorldSpaceBounds()
        {
            return base.method_11<Bounds>("GetTextWorldSpaceBounds", Array.Empty<object>());
        }

        public static Vector3 GetWorldScale(Transform xform)
        {
            object[] objArray1 = new object[] { xform };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "UberText", "GetWorldScale", objArray1);
        }

        public Vector2 GetWorldWidthAndHight()
        {
            return base.method_11<Vector2>("GetWorldWidthAndHight", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public string InlineImage(string tag)
        {
            object[] objArray1 = new object[] { tag };
            return base.method_13("InlineImage", objArray1);
        }

        public bool IsDone()
        {
            return base.method_11<bool>("IsDone", Array.Empty<object>());
        }

        public bool IsEllipsized()
        {
            return base.method_11<bool>("IsEllipsized", Array.Empty<object>());
        }

        public bool isHidden()
        {
            return base.method_11<bool>("isHidden", Array.Empty<object>());
        }

        public bool IsMultiLine()
        {
            return base.method_11<bool>("IsMultiLine", Array.Empty<object>());
        }

        public static int LineCount(string s)
        {
            object[] objArray1 = new object[] { s };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "UberText", "LineCount", objArray1);
        }

        public static void LoadCachedData()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "UberText", "LoadCachedData");
        }

        public string LocalizationFixes(string text)
        {
            object[] objArray1 = new object[] { text };
            return base.method_13("LocalizationFixes", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnDrawGizmos()
        {
            base.method_8("OnDrawGizmos", Array.Empty<object>());
        }

        public void OnDrawGizmosSelected()
        {
            base.method_8("OnDrawGizmosSelected", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void OutlineRender()
        {
            base.method_8("OutlineRender", Array.Empty<object>());
        }

        public string ProcessText(string text)
        {
            object[] objArray1 = new object[] { text };
            return base.method_13("ProcessText", objArray1);
        }

        public void ReduceText(string text, int step, int newSize)
        {
            object[] objArray1 = new object[] { text, step, newSize };
            base.method_8("ReduceText", objArray1);
        }

        public void ReduceText_CharSize(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("ReduceText_CharSize", objArray1);
        }

        public string RemoveLineBreakTags(string text)
        {
            object[] objArray1 = new object[] { text };
            return base.method_13("RemoveLineBreakTags", objArray1);
        }

        public void RemoveLocaleAdjustment(Locale locale)
        {
            object[] objArray1 = new object[] { locale };
            base.method_8("RemoveLocaleAdjustment", objArray1);
        }

        public string RemoveTagsFromWord(string word)
        {
            object[] objArray1 = new object[] { word };
            return base.method_13("RemoveTagsFromWord", objArray1);
        }

        public void RenderText()
        {
            base.method_8("RenderText", Array.Empty<object>());
        }

        public void ResizeTextToFit(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("ResizeTextToFit", objArray1);
        }

        public void SetActualCharacterSize(float characterSize)
        {
            object[] objArray1 = new object[] { characterSize };
            base.method_8("SetActualCharacterSize", objArray1);
        }

        public void SetFontSize(int fontSize)
        {
            object[] objArray1 = new object[] { fontSize };
            base.method_8("SetFontSize", objArray1);
        }

        public void SetFontWithoutLocalization(FontDef fontDef)
        {
            object[] objArray1 = new object[] { fontDef };
            base.method_8("SetFontWithoutLocalization", objArray1);
        }

        public void SetGameStringText(string gameStringTag)
        {
            object[] objArray1 = new object[] { gameStringTag };
            base.method_8("SetGameStringText", objArray1);
        }

        public void SetLineSpacing(float lineSpacing)
        {
            object[] objArray1 = new object[] { lineSpacing };
            base.method_8("SetLineSpacing", objArray1);
        }

        public void SetManaTexture(string name, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { name, obj, callbackData };
            base.method_8("SetManaTexture", objArray1);
        }

        public void SetRichText(bool richText)
        {
            object[] objArray1 = new object[] { richText };
            base.method_8("SetRichText", objArray1);
        }

        public void SetText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetText", objArray1);
        }

        public void SetupForRender()
        {
            base.method_8("SetupForRender", Array.Empty<object>());
        }

        public void SetupRenderOnObject()
        {
            base.method_8("SetupRenderOnObject", Array.Empty<object>());
        }

        public void ShadowRender()
        {
            base.method_8("ShadowRender", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public static void StoreCachedData()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "UberText", "StoreCachedData");
        }

        public Vector2 TexelSize(Texture texture)
        {
            object[] objArray1 = new object[] { texture };
            return base.method_11<Vector2>("TexelSize", objArray1);
        }

        public int TextEffectsMaterial(TextRenderMaterial materialKey, Material material)
        {
            object[] objArray1 = new object[] { materialKey, material };
            return base.method_11<int>("TextEffectsMaterial", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateColor()
        {
            base.method_8("UpdateColor", Array.Empty<object>());
        }

        public void UpdateEditorText()
        {
            base.method_8("UpdateEditorText", Array.Empty<object>());
        }

        public void UpdateFontTextures()
        {
            base.method_8("UpdateFontTextures", Array.Empty<object>());
        }

        public void UpdateLayers()
        {
            base.method_8("UpdateLayers", Array.Empty<object>());
        }

        public void UpdateNow()
        {
            base.method_8("UpdateNow", Array.Empty<object>());
        }

        public void UpdateRenderQueue()
        {
            base.method_8("UpdateRenderQueue", Array.Empty<object>());
        }

        public void UpdateTexelSize()
        {
            base.method_8("UpdateTexelSize", Array.Empty<object>());
        }

        public void UpdateText()
        {
            base.method_8("UpdateText", Array.Empty<object>());
        }

        public void UpdateTextMesh()
        {
            base.method_8("UpdateTextMesh", Array.Empty<object>());
        }

        public string WordWrapString(string text, float width)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { text, width };
            return base.method_12("WordWrapString", enumArray1, objArray1);
        }

        public string WordWrapString(string text, float width, bool ellipsis)
        {
            object[] objArray1 = new object[] { text, width, ellipsis };
            return base.method_12("WordWrapString", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public AlignmentOptions Alignment
        {
            get
            {
                return base.method_11<AlignmentOptions>("get_Alignment", Array.Empty<object>());
            }
        }

        public float AmbientLightBlend
        {
            get
            {
                return base.method_11<float>("get_AmbientLightBlend", Array.Empty<object>());
            }
        }

        public AnchorOptions Anchor
        {
            get
            {
                return base.method_11<AnchorOptions>("get_Anchor", Array.Empty<object>());
            }
        }

        public bool AntiAlias
        {
            get
            {
                return base.method_11<bool>("get_AntiAlias", Array.Empty<object>());
            }
        }

        public float AntiAliasAmount
        {
            get
            {
                return base.method_11<float>("get_AntiAliasAmount", Array.Empty<object>());
            }
        }

        public float AntiAliasEdge
        {
            get
            {
                return base.method_11<float>("get_AntiAliasEdge", Array.Empty<object>());
            }
        }

        public static float BOLD_MAX_SIZE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "UberText", "BOLD_MAX_SIZE");
            }
        }

        public string BOLD_OUTLINE_TEXT_SHADER_NAME
        {
            get
            {
                return base.method_4("BOLD_OUTLINE_TEXT_SHADER_NAME");
            }
        }

        public string BOLD_SHADER_NAME
        {
            get
            {
                return base.method_4("BOLD_SHADER_NAME");
            }
        }

        public Material BoldMaterial
        {
            get
            {
                return base.method_14<Material>("get_BoldMaterial", Array.Empty<object>());
            }
        }

        public float BoldSize
        {
            get
            {
                return base.method_11<float>("get_BoldSize", Array.Empty<object>());
            }
        }

        public bool Cache
        {
            get
            {
                return base.method_11<bool>("get_Cache", Array.Empty<object>());
            }
        }

        public static int CACHE_FILE_MAX_SIZE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "UberText", "CACHE_FILE_MAX_SIZE");
            }
        }

        public static int CACHE_FILE_VERSION_TEMP
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "UberText", "CACHE_FILE_VERSION_TEMP");
            }
        }

        public static float CHARACTER_SIZE_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "UberText", "CHARACTER_SIZE_SCALE");
            }
        }

        public float CharacterSize
        {
            get
            {
                return base.method_11<float>("get_CharacterSize", Array.Empty<object>());
            }
        }

        public static string FONT_NAME_BELWE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "UberText", "FONT_NAME_BELWE");
            }
        }

        public static string FONT_NAME_BELWE_OUTLINE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "UberText", "FONT_NAME_BELWE_OUTLINE");
            }
        }

        public static string FONT_NAME_BLIZZARD_GLOBAL
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "UberText", "FONT_NAME_BLIZZARD_GLOBAL");
            }
        }

        public static string FONT_NAME_FRANKLIN_GOTHIC
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "UberText", "FONT_NAME_FRANKLIN_GOTHIC");
            }
        }

        public int FontSize
        {
            get
            {
                return base.method_11<int>("get_FontSize", Array.Empty<object>());
            }
        }

        public bool ForceWrapLargeWords
        {
            get
            {
                return base.method_11<bool>("get_ForceWrapLargeWords", Array.Empty<object>());
            }
        }

        public bool GameStringLookup
        {
            get
            {
                return base.method_11<bool>("get_GameStringLookup", Array.Empty<object>());
            }
        }

        public float GradientLowerAlpha
        {
            get
            {
                return base.method_11<float>("get_GradientLowerAlpha", Array.Empty<object>());
            }
        }

        public Color GradientLowerColor
        {
            get
            {
                return base.method_11<Color>("get_GradientLowerColor", Array.Empty<object>());
            }
        }

        public float GradientUpperAlpha
        {
            get
            {
                return base.method_11<float>("get_GradientUpperAlpha", Array.Empty<object>());
            }
        }

        public Color GradientUpperColor
        {
            get
            {
                return base.method_11<Color>("get_GradientUpperColor", Array.Empty<object>());
            }
        }

        public float Height
        {
            get
            {
                return base.method_11<float>("get_Height", Array.Empty<object>());
            }
        }

        public string INLINE_IMAGE_SHADER_NAME
        {
            get
            {
                return base.method_4("INLINE_IMAGE_SHADER_NAME");
            }
        }

        public Material InlineImageMaterial
        {
            get
            {
                return base.method_14<Material>("get_InlineImageMaterial", Array.Empty<object>());
            }
        }

        public float LineSpacing
        {
            get
            {
                return base.method_11<float>("get_LineSpacing", Array.Empty<object>());
            }
        }

        public LocalizationSettings LocalizeSettings
        {
            get
            {
                return base.method_14<LocalizationSettings>("get_LocalizeSettings", Array.Empty<object>());
            }
        }

        public AlignmentOptions m_Alignment
        {
            get
            {
                return base.method_2<AlignmentOptions>("m_Alignment");
            }
        }

        public float m_AmbientLightBlend
        {
            get
            {
                return base.method_2<float>("m_AmbientLightBlend");
            }
        }

        public AnchorOptions m_Anchor
        {
            get
            {
                return base.method_2<AnchorOptions>("m_Anchor");
            }
        }

        public bool m_AntiAlias
        {
            get
            {
                return base.method_2<bool>("m_AntiAlias");
            }
        }

        public float m_AntiAliasAmount
        {
            get
            {
                return base.method_2<float>("m_AntiAliasAmount");
            }
        }

        public float m_AntiAliasEdge
        {
            get
            {
                return base.method_2<float>("m_AntiAliasEdge");
            }
        }

        public Material m_BoldMaterial
        {
            get
            {
                return base.method_3<Material>("m_BoldMaterial");
            }
        }

        public float m_BoldSize
        {
            get
            {
                return base.method_2<float>("m_BoldSize");
            }
        }

        public bool m_Cache
        {
            get
            {
                return base.method_2<bool>("m_Cache");
            }
        }

        public int m_CacheHash
        {
            get
            {
                return base.method_2<int>("m_CacheHash");
            }
        }

        public Camera m_Camera
        {
            get
            {
                return base.method_3<Camera>("m_Camera");
            }
        }

        public GameObject m_CameraGO
        {
            get
            {
                return base.method_3<GameObject>("m_CameraGO");
            }
        }

        public float m_CharacterSize
        {
            get
            {
                return base.method_2<float>("m_CharacterSize");
            }
        }

        public float m_CharacterSizeModifier
        {
            get
            {
                return base.method_2<float>("m_CharacterSizeModifier");
            }
        }

        public bool m_Ellipsized
        {
            get
            {
                return base.method_2<bool>("m_Ellipsized");
            }
        }

        public int m_FontSize
        {
            get
            {
                return base.method_2<int>("m_FontSize");
            }
        }

        public float m_FontSizeModifier
        {
            get
            {
                return base.method_2<float>("m_FontSizeModifier");
            }
        }

        public Texture m_FontTexture
        {
            get
            {
                return base.method_3<Texture>("m_FontTexture");
            }
        }

        public bool m_ForceWrapLargeWords
        {
            get
            {
                return base.method_2<bool>("m_ForceWrapLargeWords");
            }
        }

        public bool m_GameStringLookup
        {
            get
            {
                return base.method_2<bool>("m_GameStringLookup");
            }
        }

        public Color m_GradientLowerColor
        {
            get
            {
                return base.method_2<Color>("m_GradientLowerColor");
            }
        }

        public Color m_GradientUpperColor
        {
            get
            {
                return base.method_2<Color>("m_GradientUpperColor");
            }
        }

        public float m_Height
        {
            get
            {
                return base.method_2<float>("m_Height");
            }
        }

        public bool m_Hidden
        {
            get
            {
                return base.method_2<bool>("m_Hidden");
            }
        }

        public Material m_InlineImageMaterial
        {
            get
            {
                return base.method_3<Material>("m_InlineImageMaterial");
            }
        }

        public bool m_isFontDefLoaded
        {
            get
            {
                return base.method_2<bool>("m_isFontDefLoaded");
            }
        }

        public int m_LineCount
        {
            get
            {
                return base.method_2<int>("m_LineCount");
            }
        }

        public float m_LineSpaceModifier
        {
            get
            {
                return base.method_2<float>("m_LineSpaceModifier");
            }
        }

        public float m_LineSpacing
        {
            get
            {
                return base.method_2<float>("m_LineSpacing");
            }
        }

        public LocalizationSettings m_LocalizedSettings
        {
            get
            {
                return base.method_3<LocalizationSettings>("m_LocalizedSettings");
            }
        }

        public float m_MinCharacterSize
        {
            get
            {
                return base.method_2<float>("m_MinCharacterSize");
            }
        }

        public int m_MinFontSize
        {
            get
            {
                return base.method_2<int>("m_MinFontSize");
            }
        }

        public float m_Offset
        {
            get
            {
                return base.method_2<float>("m_Offset");
            }
        }

        public int m_OrgRenderQueue
        {
            get
            {
                return base.method_2<int>("m_OrgRenderQueue");
            }
        }

        public bool m_Outline
        {
            get
            {
                return base.method_2<bool>("m_Outline");
            }
        }

        public Color m_OutlineColor
        {
            get
            {
                return base.method_2<Color>("m_OutlineColor");
            }
        }

        public float m_OutlineModifier
        {
            get
            {
                return base.method_2<float>("m_OutlineModifier");
            }
        }

        public float m_OutlineSize
        {
            get
            {
                return base.method_2<float>("m_OutlineSize");
            }
        }

        public Material m_OutlineTextMaterial
        {
            get
            {
                return base.method_3<Material>("m_OutlineTextMaterial");
            }
        }

        public GameObject m_PlaneGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_PlaneGameObject");
            }
        }

        public Material m_PlaneMaterial
        {
            get
            {
                return base.method_3<Material>("m_PlaneMaterial");
            }
        }

        public Mesh m_PlaneMesh
        {
            get
            {
                return base.method_3<Mesh>("m_PlaneMesh");
            }
        }

        public float m_PreviousPlaneHeight
        {
            get
            {
                return base.method_2<float>("m_PreviousPlaneHeight");
            }
        }

        public float m_PreviousPlaneWidth
        {
            get
            {
                return base.method_2<float>("m_PreviousPlaneWidth");
            }
        }

        public int m_PreviousResolution
        {
            get
            {
                return base.method_2<int>("m_PreviousResolution");
            }
        }

        public Vector2 m_PreviousTexelSize
        {
            get
            {
                return base.method_2<Vector2>("m_PreviousTexelSize");
            }
        }

        public string m_PreviousText
        {
            get
            {
                return base.method_4("m_PreviousText");
            }
        }

        public GameObject m_RenderOnObject
        {
            get
            {
                return base.method_3<GameObject>("m_RenderOnObject");
            }
        }

        public int m_RenderQueue
        {
            get
            {
                return base.method_2<int>("m_RenderQueue");
            }
        }

        public bool m_RenderToTexture
        {
            get
            {
                return base.method_2<bool>("m_RenderToTexture");
            }
        }

        public bool m_ResizeToFit
        {
            get
            {
                return base.method_2<bool>("m_ResizeToFit");
            }
        }

        public int m_Resolution
        {
            get
            {
                return base.method_2<int>("m_Resolution");
            }
        }

        public bool m_RichText
        {
            get
            {
                return base.method_2<bool>("m_RichText");
            }
        }

        public bool m_Shadow
        {
            get
            {
                return base.method_2<bool>("m_Shadow");
            }
        }

        public float m_ShadowBlur
        {
            get
            {
                return base.method_2<float>("m_ShadowBlur");
            }
        }

        public Color m_ShadowColor
        {
            get
            {
                return base.method_2<Color>("m_ShadowColor");
            }
        }

        public Material m_ShadowMaterial
        {
            get
            {
                return base.method_3<Material>("m_ShadowMaterial");
            }
        }

        public float m_ShadowOffset
        {
            get
            {
                return base.method_2<float>("m_ShadowOffset");
            }
        }

        public GameObject m_ShadowPlaneGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_ShadowPlaneGameObject");
            }
        }

        public float m_SingleLineAdjustment
        {
            get
            {
                return base.method_2<float>("m_SingleLineAdjustment");
            }
        }

        public string m_Text
        {
            get
            {
                return base.method_4("m_Text");
            }
        }

        public Material m_TextAntialiasingMaterial
        {
            get
            {
                return base.method_3<Material>("m_TextAntialiasingMaterial");
            }
        }

        public Color m_TextColor
        {
            get
            {
                return base.method_2<Color>("m_TextColor");
            }
        }

        public Material m_TextMaterial
        {
            get
            {
                return base.method_3<Material>("m_TextMaterial");
            }
        }

        public TextMesh m_TextMesh
        {
            get
            {
                return base.method_3<TextMesh>("m_TextMesh");
            }
        }

        public GameObject m_TextMeshGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_TextMeshGameObject");
            }
        }

        public bool m_TextSet
        {
            get
            {
                return base.method_2<bool>("m_TextSet");
            }
        }

        public bool m_Underwear
        {
            get
            {
                return base.method_2<bool>("m_Underwear");
            }
        }

        public bool m_UnderwearFlip
        {
            get
            {
                return base.method_2<bool>("m_UnderwearFlip");
            }
        }

        public float m_UnderwearHeight
        {
            get
            {
                return base.method_2<float>("m_UnderwearHeight");
            }
        }

        public float m_UnderwearWidth
        {
            get
            {
                return base.method_2<float>("m_UnderwearWidth");
            }
        }

        public bool m_updated
        {
            get
            {
                return base.method_2<bool>("m_updated");
            }
        }

        public bool m_UseEditorText
        {
            get
            {
                return base.method_2<bool>("m_UseEditorText");
            }
        }

        public float m_Width
        {
            get
            {
                return base.method_2<float>("m_Width");
            }
        }

        public List<string> m_Words
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("m_Words");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_WordWrap
        {
            get
            {
                return base.method_2<bool>("m_WordWrap");
            }
        }

        public float m_WorldHeight
        {
            get
            {
                return base.method_2<float>("m_WorldHeight");
            }
        }

        public float m_WorldWidth
        {
            get
            {
                return base.method_2<float>("m_WorldWidth");
            }
        }

        public static int MAX_REDUCE_TEXT_COUNT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "UberText", "MAX_REDUCE_TEXT_COUNT");
            }
        }

        public float MinCharacterSize
        {
            get
            {
                return base.method_11<float>("get_MinCharacterSize", Array.Empty<object>());
            }
        }

        public int MinFontSize
        {
            get
            {
                return base.method_11<int>("get_MinFontSize", Array.Empty<object>());
            }
        }

        public float Offset
        {
            get
            {
                return base.method_11<float>("get_Offset", Array.Empty<object>());
            }
        }

        public bool Outline
        {
            get
            {
                return base.method_11<bool>("get_Outline", Array.Empty<object>());
            }
        }

        public string OUTLINE_NO_VERT_COLOR_TEXT_2PASS_SHADER_NAME
        {
            get
            {
                return base.method_4("OUTLINE_NO_VERT_COLOR_TEXT_2PASS_SHADER_NAME");
            }
        }

        public string OUTLINE_NO_VERT_COLOR_TEXT_SHADER_NAME
        {
            get
            {
                return base.method_4("OUTLINE_NO_VERT_COLOR_TEXT_SHADER_NAME");
            }
        }

        public string OUTLINE_TEXT_2PASS_SHADER_NAME
        {
            get
            {
                return base.method_4("OUTLINE_TEXT_2PASS_SHADER_NAME");
            }
        }

        public string OUTLINE_TEXT_SHADER_NAME
        {
            get
            {
                return base.method_4("OUTLINE_TEXT_SHADER_NAME");
            }
        }

        public float OutlineAlpha
        {
            get
            {
                return base.method_11<float>("get_OutlineAlpha", Array.Empty<object>());
            }
        }

        public Color OutlineColor
        {
            get
            {
                return base.method_11<Color>("get_OutlineColor", Array.Empty<object>());
            }
        }

        public float OutlineSize
        {
            get
            {
                return base.method_11<float>("get_OutlineSize", Array.Empty<object>());
            }
        }

        public Material OutlineTextMaterial
        {
            get
            {
                return base.method_14<Material>("get_OutlineTextMaterial", Array.Empty<object>());
            }
        }

        public List<Vector3> PLANE_NORMALS
        {
            get
            {
                Class246<Vector3> class2 = base.method_3<Class246<Vector3>>("PLANE_NORMALS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string PLANE_SHADER_NAME
        {
            get
            {
                return base.method_4("PLANE_SHADER_NAME");
            }
        }

        public List<int> PLANE_TRIANGLES
        {
            get
            {
                Class246<int> class2 = base.method_3<Class246<int>>("PLANE_TRIANGLES");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Vector2> PLANE_UVS
        {
            get
            {
                Class246<Vector2> class2 = base.method_3<Class246<Vector2>>("PLANE_UVS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Material PlaneMaterial
        {
            get
            {
                return base.method_14<Material>("get_PlaneMaterial", Array.Empty<object>());
            }
        }

        public static int RENDER_LAYER
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "UberText", "RENDER_LAYER");
            }
        }

        public static int RENDER_LAYER_BIT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "UberText", "RENDER_LAYER_BIT");
            }
        }

        public GameObject RenderOnObject
        {
            get
            {
                return base.method_14<GameObject>("get_RenderOnObject", Array.Empty<object>());
            }
        }

        public int RenderQueue
        {
            get
            {
                return base.method_11<int>("get_RenderQueue", Array.Empty<object>());
            }
        }

        public bool RenderToTexture
        {
            get
            {
                return base.method_11<bool>("get_RenderToTexture", Array.Empty<object>());
            }
        }

        public bool ResizeToFit
        {
            get
            {
                return base.method_11<bool>("get_ResizeToFit", Array.Empty<object>());
            }
        }

        public bool RichText
        {
            get
            {
                return base.method_11<bool>("get_RichText", Array.Empty<object>());
            }
        }

        public static bool s_InlineImageTextureLoaded
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "UberText", "s_InlineImageTextureLoaded");
            }
        }

        public static float s_offset
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "UberText", "s_offset");
            }
        }

        public bool Shadow
        {
            get
            {
                return base.method_11<bool>("get_Shadow", Array.Empty<object>());
            }
        }

        public string SHADOW_SHADER_NAME
        {
            get
            {
                return base.method_4("SHADOW_SHADER_NAME");
            }
        }

        public float ShadowAlpha
        {
            get
            {
                return base.method_11<float>("get_ShadowAlpha", Array.Empty<object>());
            }
        }

        public float ShadowBlur
        {
            get
            {
                return base.method_11<float>("get_ShadowBlur", Array.Empty<object>());
            }
        }

        public Color ShadowColor
        {
            get
            {
                return base.method_11<Color>("get_ShadowColor", Array.Empty<object>());
            }
        }

        public Material ShadowMaterial
        {
            get
            {
                return base.method_14<Material>("get_ShadowMaterial", Array.Empty<object>());
            }
        }

        public float ShadowOffset
        {
            get
            {
                return base.method_11<float>("get_ShadowOffset", Array.Empty<object>());
            }
        }

        public string Text
        {
            get
            {
                return base.method_13("get_Text", Array.Empty<object>());
            }
        }

        public string TEXT_ANTIALAISING_SHADER_NAME
        {
            get
            {
                return base.method_4("TEXT_ANTIALAISING_SHADER_NAME");
            }
        }

        public string TEXT_SHADER_NAME
        {
            get
            {
                return base.method_4("TEXT_SHADER_NAME");
            }
        }

        public float TextAlpha
        {
            get
            {
                return base.method_11<float>("get_TextAlpha", Array.Empty<object>());
            }
        }

        public Material TextAntialiasingMaterial
        {
            get
            {
                return base.method_14<Material>("get_TextAntialiasingMaterial", Array.Empty<object>());
            }
        }

        public Color TextColor
        {
            get
            {
                return base.method_11<Color>("get_TextColor", Array.Empty<object>());
            }
        }

        public Material TextMaterial
        {
            get
            {
                return base.method_14<Material>("get_TextMaterial", Array.Empty<object>());
            }
        }

        public Material TextMeshBaseMaterial
        {
            get
            {
                return base.method_3<Material>("TextMeshBaseMaterial");
            }
        }

        public int TextureResolution
        {
            get
            {
                return base.method_11<int>("get_TextureResolution", Array.Empty<object>());
            }
        }

        public bool Underwear
        {
            get
            {
                return base.method_11<bool>("get_Underwear", Array.Empty<object>());
            }
        }

        public bool UnderwearFlip
        {
            get
            {
                return base.method_11<bool>("get_UnderwearFlip", Array.Empty<object>());
            }
        }

        public float UnderwearHeight
        {
            get
            {
                return base.method_11<float>("get_UnderwearHeight", Array.Empty<object>());
            }
        }

        public float UnderwearWidth
        {
            get
            {
                return base.method_11<float>("get_UnderwearWidth", Array.Empty<object>());
            }
        }

        public bool UseEditorText
        {
            get
            {
                return base.method_11<bool>("get_UseEditorText", Array.Empty<object>());
            }
        }

        public float Width
        {
            get
            {
                return base.method_11<float>("get_Width", Array.Empty<object>());
            }
        }

        public bool WordWrap
        {
            get
            {
                return base.method_11<bool>("get_WordWrap", Array.Empty<object>());
            }
        }

        public enum AlignmentOptions
        {
            Left,
            Center,
            Right
        }

        public enum AnchorOptions
        {
            Upper,
            Middle,
            Lower
        }

        [Attribute38("UberText.CachedTextKeyData")]
        public class CachedTextKeyData : MonoClass
        {
            public CachedTextKeyData(IntPtr address) : this(address, "CachedTextKeyData")
            {
            }

            public CachedTextKeyData(IntPtr address, string className) : base(address, className)
            {
            }

            public int GetHashCode()
            {
                return base.method_11<int>("GetHashCode", Array.Empty<object>());
            }

            public float m_CharSize
            {
                get
                {
                    return base.method_2<float>("m_CharSize");
                }
            }

            public int m_FontSize
            {
                get
                {
                    return base.method_2<int>("m_FontSize");
                }
            }

            public float m_Height
            {
                get
                {
                    return base.method_2<float>("m_Height");
                }
            }

            public float m_LineSpacing
            {
                get
                {
                    return base.method_2<float>("m_LineSpacing");
                }
            }

            public string m_Text
            {
                get
                {
                    return base.method_4("m_Text");
                }
            }

            public float m_Width
            {
                get
                {
                    return base.method_2<float>("m_Width");
                }
            }
        }

        [Attribute38("UberText.CachedTextValues")]
        public class CachedTextValues : MonoClass
        {
            public CachedTextValues(IntPtr address) : this(address, "CachedTextValues")
            {
            }

            public CachedTextValues(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_CharSize
            {
                get
                {
                    return base.method_2<float>("m_CharSize");
                }
            }

            public int m_OriginalTextHash
            {
                get
                {
                    return base.method_2<int>("m_OriginalTextHash");
                }
            }

            public string m_Text
            {
                get
                {
                    return base.method_4("m_Text");
                }
            }
        }

        public enum Fonts
        {
            BlizzardGlobal,
            Belwe,
            BelweOutline,
            FranklinGothic
        }

        [Attribute38("UberText.LocalizationSettings")]
        public class LocalizationSettings : MonoClass
        {
            public LocalizationSettings(IntPtr address) : this(address, "LocalizationSettings")
            {
            }

            public LocalizationSettings(IntPtr address, string className) : base(address, className)
            {
            }

            public LocaleAdjustment AddLocale(Locale locale)
            {
                object[] objArray1 = new object[] { locale };
                return base.method_14<LocaleAdjustment>("AddLocale", objArray1);
            }

            public LocaleAdjustment GetLocale(Locale locale)
            {
                object[] objArray1 = new object[] { locale };
                return base.method_14<LocaleAdjustment>("GetLocale", objArray1);
            }

            public bool HasLocale(Locale locale)
            {
                object[] objArray1 = new object[] { locale };
                return base.method_11<bool>("HasLocale", objArray1);
            }

            public void RemoveLocale(Locale locale)
            {
                object[] objArray1 = new object[] { locale };
                base.method_8("RemoveLocale", objArray1);
            }

            public List<LocaleAdjustment> m_LocaleAdjustments
            {
                get
                {
                    Class267<LocaleAdjustment> class2 = base.method_3<Class267<LocaleAdjustment>>("m_LocaleAdjustments");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            [Attribute38("UberText.LocalizationSettings.LocaleAdjustment")]
            public class LocaleAdjustment : MonoClass
            {
                public LocaleAdjustment(IntPtr address) : this(address, "LocaleAdjustment")
                {
                }

                public LocaleAdjustment(IntPtr address, string className) : base(address, className)
                {
                }

                public float m_FontSizeModifier
                {
                    get
                    {
                        return base.method_2<float>("m_FontSizeModifier");
                    }
                }

                public float m_LineSpaceModifier
                {
                    get
                    {
                        return base.method_2<float>("m_LineSpaceModifier");
                    }
                }

                public Locale m_Locale
                {
                    get
                    {
                        return base.method_2<Locale>("m_Locale");
                    }
                }

                public float m_OutlineModifier
                {
                    get
                    {
                        return base.method_2<float>("m_OutlineModifier");
                    }
                }

                public Vector3 m_PositionOffset
                {
                    get
                    {
                        return base.method_2<Vector3>("m_PositionOffset");
                    }
                }

                public float m_SingleLineAdjustment
                {
                    get
                    {
                        return base.method_2<float>("m_SingleLineAdjustment");
                    }
                }

                public float m_UnderwearHeight
                {
                    get
                    {
                        return base.method_2<float>("m_UnderwearHeight");
                    }
                }

                public float m_UnderwearWidth
                {
                    get
                    {
                        return base.method_2<float>("m_UnderwearWidth");
                    }
                }
            }
        }

        public enum TextRenderMaterial
        {
            Text,
            Bold,
            Outline,
            InlineImages
        }

        public enum ThaiGlyphType
        {
            BASE,
            BASE_ASCENDER,
            BASE_DESCENDER,
            TONE_MARK,
            UPPER,
            LOWER
        }
    }
}

