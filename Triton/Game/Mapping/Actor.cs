namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Actor")]
    public class Actor : MonoBehaviour
    {
        public Actor(IntPtr address) : this(address, "Actor")
        {
        }

        public Actor(IntPtr address, string className) : base(address, className)
        {
        }

        public Spell ActivateSpell(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            return base.method_14<Spell>("ActivateSpell", objArray1);
        }

        public Spell ActivateTaunt()
        {
            return base.method_14<Spell>("ActivateTaunt", Array.Empty<object>());
        }

        public void AssignBones()
        {
            base.method_8("AssignBones", Array.Empty<object>());
        }

        public void AssignMaterials(MeshRenderer meshRenderer)
        {
            object[] objArray1 = new object[] { meshRenderer };
            base.method_8("AssignMaterials", objArray1);
        }

        public void AssignMeshRenderers()
        {
            base.method_8("AssignMeshRenderers", Array.Empty<object>());
        }

        public void AssignRootObject()
        {
            base.method_8("AssignRootObject", Array.Empty<object>());
        }

        public void AssignSpells()
        {
            base.method_8("AssignSpells", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Actor Clone()
        {
            return base.method_14<Actor>("Clone", Array.Empty<object>());
        }

        public void ContactShadow(bool visible)
        {
            object[] objArray1 = new object[] { visible };
            base.method_8("ContactShadow", objArray1);
        }

        public Material CreateReplacementMaterial(Material oldMaterial, Material newMaterialPrefab)
        {
            object[] objArray1 = new object[] { oldMaterial, newMaterialPrefab };
            return base.method_14<Material>("CreateReplacementMaterial", objArray1);
        }

        public void DeactivateAllPreDeathSpells()
        {
            base.method_8("DeactivateAllPreDeathSpells", Array.Empty<object>());
        }

        public void DeactivateAllSpells()
        {
            base.method_8("DeactivateAllSpells", Array.Empty<object>());
        }

        public void DeactivateSpell(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            base.method_8("DeactivateSpell", objArray1);
        }

        public void DeactivateTaunt()
        {
            base.method_8("DeactivateTaunt", Array.Empty<object>());
        }

        public void Destroy()
        {
            base.method_8("Destroy", Array.Empty<object>());
        }

        public void DestroySpell(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            base.method_8("DestroySpell", objArray1);
        }

        public void DisableMissingCardEffect()
        {
            base.method_8("DisableMissingCardEffect", Array.Empty<object>());
        }

        public void DisableTextMesh(UberText mesh)
        {
            object[] objArray1 = new object[] { mesh };
            base.method_8("DisableTextMesh", objArray1);
        }

        public GameObject FindBone(string boneName)
        {
            object[] objArray1 = new object[] { boneName };
            return base.method_14<GameObject>("FindBone", objArray1);
        }

        public ActorStateMgr GetActorStateMgr()
        {
            return base.method_14<ActorStateMgr>("GetActorStateMgr", Array.Empty<object>());
        }

        public ActorStateType GetActorStateType()
        {
            return base.method_11<ActorStateType>("GetActorStateType", Array.Empty<object>());
        }

        public GemObject GetAttackObject()
        {
            return base.method_14<GemObject>("GetAttackObject", Array.Empty<object>());
        }

        public UberText GetAttackText()
        {
            return base.method_14<UberText>("GetAttackText", Array.Empty<object>());
        }

        public GameObject GetAttackTextObject()
        {
            return base.method_14<GameObject>("GetAttackTextObject", Array.Empty<object>());
        }

        public GameObject GetBones()
        {
            return base.method_14<GameObject>("GetBones", Array.Empty<object>());
        }

        public Card GetCard()
        {
            return base.method_14<Card>("GetCard", Array.Empty<object>());
        }

        public Player.Side GetCardBackSide()
        {
            return base.method_11<Player.Side>("GetCardBackSide", Array.Empty<object>());
        }

        public bool GetCardbackUpdateIgnore()
        {
            return base.method_11<bool>("GetCardbackUpdateIgnore", Array.Empty<object>());
        }

        public CardDef GetCardDef()
        {
            return base.method_14<CardDef>("GetCardDef", Array.Empty<object>());
        }

        public TAG_CARD_SET GetCardSet()
        {
            return base.method_11<TAG_CARD_SET>("GetCardSet", Array.Empty<object>());
        }

        public GameObject GetCardTypeBannerAnchor()
        {
            return base.method_14<GameObject>("GetCardTypeBannerAnchor", Array.Empty<object>());
        }

        public Collider GetCollider()
        {
            return base.method_14<Collider>("GetCollider", Array.Empty<object>());
        }

        public UberText GetCostText()
        {
            return base.method_14<UberText>("GetCostText", Array.Empty<object>());
        }

        public GameObject GetCostTextObject()
        {
            return base.method_14<GameObject>("GetCostTextObject", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetEntity()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetEntity", Array.Empty<object>());
        }

        public EntityDef GetEntityDef()
        {
            return base.method_14<EntityDef>("GetEntityDef", Array.Empty<object>());
        }

        public GemObject GetHealthObject()
        {
            return base.method_14<GemObject>("GetHealthObject", Array.Empty<object>());
        }

        public UberText GetHealthText()
        {
            return base.method_14<UberText>("GetHealthText", Array.Empty<object>());
        }

        public GameObject GetHealthTextObject()
        {
            return base.method_14<GameObject>("GetHealthTextObject", Array.Empty<object>());
        }

        public GameObject GetHiddenStandIn()
        {
            return base.method_14<GameObject>("GetHiddenStandIn", Array.Empty<object>());
        }

        public HistoryCard GetHistoryCard()
        {
            return base.method_14<HistoryCard>("GetHistoryCard", Array.Empty<object>());
        }

        public HistoryChildCard GetHistoryChildCard()
        {
            return base.method_14<HistoryChildCard>("GetHistoryChildCard", Array.Empty<object>());
        }

        public Spell GetLoadedSpell(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            return base.method_14<Spell>("GetLoadedSpell", objArray1);
        }

        public MeshRenderer GetMeshRenderer()
        {
            return base.method_14<MeshRenderer>("GetMeshRenderer", Array.Empty<object>());
        }

        public UberText GetNameText()
        {
            return base.method_14<UberText>("GetNameText", Array.Empty<object>());
        }

        public Material GetPortraitMaterial()
        {
            return base.method_14<Material>("GetPortraitMaterial", Array.Empty<object>());
        }

        public GameObject GetPortraitMesh()
        {
            return base.method_14<GameObject>("GetPortraitMesh", Array.Empty<object>());
        }

        public Texture GetPortraitTexture()
        {
            return base.method_14<Texture>("GetPortraitTexture", Array.Empty<object>());
        }

        public UberText GetPowersText()
        {
            return base.method_14<UberText>("GetPowersText", Array.Empty<object>());
        }

        public TAG_PREMIUM GetPremium()
        {
            return base.method_11<TAG_PREMIUM>("GetPremium", Array.Empty<object>());
        }

        public UberText GetRaceText()
        {
            return base.method_14<UberText>("GetRaceText", Array.Empty<object>());
        }

        public TAG_RARITY GetRarity()
        {
            return base.method_11<TAG_RARITY>("GetRarity", Array.Empty<object>());
        }

        public GameObject GetRootObject()
        {
            return base.method_14<GameObject>("GetRootObject", Array.Empty<object>());
        }

        public UberText GetSecretText()
        {
            return base.method_14<UberText>("GetSecretText", Array.Empty<object>());
        }

        public Spell GetSpell(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            return base.method_14<Spell>("GetSpell", objArray1);
        }

        public Spell GetSpellIfLoaded(SpellType spellType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { spellType };
            return base.method_15<Spell>("GetSpellIfLoaded", enumArray1, objArray1);
        }

        public SpellTable GetSpellTable()
        {
            return base.method_14<SpellTable>("GetSpellTable", Array.Empty<object>());
        }

        public void GhostCardEffect(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("GhostCardEffect", objArray1);
        }

        public void Hide()
        {
            base.method_9("Hide", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Hide(bool ignoreSpells)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { ignoreSpells };
            base.method_9("Hide", enumArray1, objArray1);
        }

        public void HideActorState()
        {
            base.method_8("HideActorState", Array.Empty<object>());
        }

        public void HideAllText()
        {
            base.method_8("HideAllText", Array.Empty<object>());
        }

        public void HideArmorSpell()
        {
            base.method_8("HideArmorSpell", Array.Empty<object>());
        }

        public void HideImpl(bool ignoreSpells)
        {
            object[] objArray1 = new object[] { ignoreSpells };
            base.method_8("HideImpl", objArray1);
        }

        public void HideSpellTable()
        {
            base.method_8("HideSpellTable", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public bool IsElite()
        {
            return base.method_11<bool>("IsElite", Array.Empty<object>());
        }

        public bool isGhostCard()
        {
            return base.method_11<bool>("isGhostCard", Array.Empty<object>());
        }

        public bool isMissingCard()
        {
            return base.method_11<bool>("isMissingCard", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public bool IsSpellActive(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            return base.method_11<bool>("IsSpellActive", objArray1);
        }

        public bool IsSpellDyingOrNone(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            return base.method_11<bool>("IsSpellDyingOrNone", objArray1);
        }

        public void LoadArmorSpell()
        {
            base.method_8("LoadArmorSpell", Array.Empty<object>());
        }

        public Spell LoadSpell(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            return base.method_14<Spell>("LoadSpell", objArray1);
        }

        public void MaterialShaderAnimation(bool animationEnabled)
        {
            object[] objArray1 = new object[] { animationEnabled };
            base.method_8("MaterialShaderAnimation", objArray1);
        }

        public bool MissingCardEffect()
        {
            return base.method_11<bool>("MissingCardEffect", Array.Empty<object>());
        }

        public void OnArmorSpellLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnArmorSpellLoaded", objArray1);
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void OnSpellStateStarted(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnSpellStateStarted", objArray1);
        }

        public void OverrideAllMeshMaterials(Material material)
        {
            object[] objArray1 = new object[] { material };
            base.method_8("OverrideAllMeshMaterials", objArray1);
        }

        public void OverrideNameText(UberText newText)
        {
            object[] objArray1 = new object[] { newText };
            base.method_8("OverrideNameText", objArray1);
        }

        public void RecursivelyReplaceMaterialsList(Transform transformToRecurse, Material newMaterialPrefab)
        {
            object[] objArray1 = new object[] { transformToRecurse, newMaterialPrefab };
            base.method_8("RecursivelyReplaceMaterialsList", objArray1);
        }

        public void ReleasePortrait()
        {
            base.method_8("ReleasePortrait", Array.Empty<object>());
        }

        public void ReplaceMaterialsList(Renderer renderer, Material newMaterialPrefab)
        {
            object[] objArray1 = new object[] { renderer, newMaterialPrefab };
            base.method_8("ReplaceMaterialsList", objArray1);
        }

        public void SeedMaterialEffects()
        {
            base.method_8("SeedMaterialEffects", Array.Empty<object>());
        }

        public void SetActorState(ActorStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("SetActorState", objArray1);
        }

        public void SetCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("SetCard", objArray1);
        }

        public void SetCardbackUpdateIgnore(bool ignoreUpdate)
        {
            object[] objArray1 = new object[] { ignoreUpdate };
            base.method_8("SetCardbackUpdateIgnore", objArray1);
        }

        public void SetCardDef(CardDef cardDef)
        {
            object[] objArray1 = new object[] { cardDef };
            base.method_8("SetCardDef", objArray1);
        }

        public void SetDisablePremiumPortrait(bool disable)
        {
            object[] objArray1 = new object[] { disable };
            base.method_8("SetDisablePremiumPortrait", objArray1);
        }

        public void SetEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("SetEntity", objArray1);
        }

        public void SetEntityDef(EntityDef entityDef)
        {
            object[] objArray1 = new object[] { entityDef };
            base.method_8("SetEntityDef", objArray1);
        }

        public void SetHiddenStandIn(GameObject standIn)
        {
            object[] objArray1 = new object[] { standIn };
            base.method_8("SetHiddenStandIn", objArray1);
        }

        public void SetHistoryCard(HistoryCard card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("SetHistoryCard", objArray1);
        }

        public void SetHistoryChildCard(HistoryChildCard card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("SetHistoryChildCard", objArray1);
        }

        public void SetLightBlend(float blendValue)
        {
            object[] objArray1 = new object[] { blendValue };
            base.method_8("SetLightBlend", objArray1);
        }

        public void SetLightingBlend(float value)
        {
            object[] objArray1 = new object[] { value };
            base.method_8("SetLightingBlend", objArray1);
        }

        public void SetLit()
        {
            base.method_8("SetLit", Array.Empty<object>());
        }

        public void SetMissingCardMaterial(Material missingCardMat)
        {
            object[] objArray1 = new object[] { missingCardMat };
            base.method_8("SetMissingCardMaterial", objArray1);
        }

        public void SetPortraitMaterial(Material material)
        {
            object[] objArray1 = new object[] { material };
            base.method_8("SetPortraitMaterial", objArray1);
        }

        public void SetPortraitTexture(Texture texture)
        {
            object[] objArray1 = new object[] { texture };
            base.method_8("SetPortraitTexture", objArray1);
        }

        public void SetPortraitTextureOverride(Texture portrait)
        {
            object[] objArray1 = new object[] { portrait };
            base.method_8("SetPortraitTextureOverride", objArray1);
        }

        public void SetPremium(TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { premium };
            base.method_8("SetPremium", objArray1);
        }

        public void SetShadowform(bool shadowform)
        {
            object[] objArray1 = new object[] { shadowform };
            base.method_8("SetShadowform", objArray1);
        }

        public void SetUnlit()
        {
            base.method_8("SetUnlit", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_9("Show", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Show(bool ignoreSpells)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { ignoreSpells };
            base.method_9("Show", enumArray1, objArray1);
        }

        public void ShowActorState()
        {
            base.method_8("ShowActorState", Array.Empty<object>());
        }

        public void ShowAllText()
        {
            base.method_8("ShowAllText", Array.Empty<object>());
        }

        public void ShowImpl(bool ignoreSpells)
        {
            object[] objArray1 = new object[] { ignoreSpells };
            base.method_8("ShowImpl", objArray1);
        }

        public void ShowSpellTable()
        {
            base.method_8("ShowSpellTable", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void ToggleCollider(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("ToggleCollider", objArray1);
        }

        public void ToggleForceIdle(bool bOn)
        {
            object[] objArray1 = new object[] { bOn };
            base.method_8("ToggleForceIdle", objArray1);
        }

        public void ToggleTextVisibility(bool bOn)
        {
            object[] objArray1 = new object[] { bOn };
            base.method_8("ToggleTextVisibility", objArray1);
        }

        public void TurnOffCollider()
        {
            base.method_8("TurnOffCollider", Array.Empty<object>());
        }

        public void TurnOnCollider()
        {
            base.method_8("TurnOnCollider", Array.Empty<object>());
        }

        public void UpdateAllComponents()
        {
            base.method_8("UpdateAllComponents", Array.Empty<object>());
        }

        public void UpdateArmorSpell()
        {
            base.method_8("UpdateArmorSpell", Array.Empty<object>());
        }

        public void UpdateCardBack()
        {
            base.method_8("UpdateCardBack", Array.Empty<object>());
        }

        public void UpdateCardBackDisplay(bool friendlySide)
        {
            object[] objArray1 = new object[] { friendlySide };
            base.method_8("UpdateCardBackDisplay", objArray1);
        }

        public void UpdateCardBackDragEffect()
        {
            base.method_8("UpdateCardBackDragEffect", Array.Empty<object>());
        }

        public void UpdateCardColor()
        {
            base.method_8("UpdateCardColor", Array.Empty<object>());
        }

        public void UpdateEliteComponent()
        {
            base.method_8("UpdateEliteComponent", Array.Empty<object>());
        }

        public void UpdateGhostCardEffect()
        {
            base.method_8("UpdateGhostCardEffect", Array.Empty<object>());
        }

        public void UpdateMaterials()
        {
            base.method_8("UpdateMaterials", Array.Empty<object>());
        }

        public void UpdateMeshComponents()
        {
            base.method_8("UpdateMeshComponents", Array.Empty<object>());
        }

        public void UpdateMissingCardArt()
        {
            base.method_8("UpdateMissingCardArt", Array.Empty<object>());
        }

        public void UpdateNameText()
        {
            base.method_8("UpdateNameText", Array.Empty<object>());
        }

        public void UpdateNumberText(UberText textMesh, string newText)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.String };
            object[] objArray1 = new object[] { textMesh, newText };
            base.method_9("UpdateNumberText", enumArray1, objArray1);
        }

        public void UpdateNumberText(UberText textMesh, string newText, bool shouldHide)
        {
            object[] objArray1 = new object[] { textMesh, newText, shouldHide };
            base.method_9("UpdateNumberText", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void UpdatePortraitTexture()
        {
            base.method_8("UpdatePortraitTexture", Array.Empty<object>());
        }

        public void UpdatePowersText()
        {
            base.method_8("UpdatePowersText", Array.Empty<object>());
        }

        public void UpdatePremiumComponents()
        {
            base.method_8("UpdatePremiumComponents", Array.Empty<object>());
        }

        public void UpdateRace(string raceText)
        {
            object[] objArray1 = new object[] { raceText };
            base.method_8("UpdateRace", objArray1);
        }

        public void UpdateRarityComponent()
        {
            base.method_8("UpdateRarityComponent", Array.Empty<object>());
        }

        public void UpdateRootObjectSpellComponents()
        {
            base.method_8("UpdateRootObjectSpellComponents", Array.Empty<object>());
        }

        public void UpdateSecretText()
        {
            base.method_8("UpdateSecretText", Array.Empty<object>());
        }

        public void UpdateText(UberText uberTextMesh, string text)
        {
            object[] objArray1 = new object[] { uberTextMesh, text };
            base.method_8("UpdateText", objArray1);
        }

        public void UpdateTextColor(UberText originalMesh, int baseNumber, int currentNumber)
        {
            object[] objArray1 = new object[] { originalMesh, baseNumber, currentNumber };
            base.method_9("UpdateTextColor", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void UpdateTextColor(UberText uberTextMesh, int baseNumber, int currentNumber, bool higherIsBetter)
        {
            object[] objArray1 = new object[] { uberTextMesh, baseNumber, currentNumber, higherIsBetter };
            base.method_9("UpdateTextColor", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void UpdateTextColorToGreenOrWhite(UberText uberTextMesh, int baseNumber, int currentNumber)
        {
            object[] objArray1 = new object[] { uberTextMesh, baseNumber, currentNumber };
            base.method_8("UpdateTextColorToGreenOrWhite", objArray1);
        }

        public void UpdateTextComponents()
        {
            base.method_9("UpdateTextComponents", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void UpdateTextComponents(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            base.method_9("UpdateTextComponents", enumArray1, objArray1);
        }

        public void UpdateTextComponentsDef(EntityDef entityDef)
        {
            object[] objArray1 = new object[] { entityDef };
            base.method_8("UpdateTextComponentsDef", objArray1);
        }

        public void UpdateTextures()
        {
            base.method_8("UpdateTextures", Array.Empty<object>());
        }

        public void UpdateWatermark()
        {
            base.method_8("UpdateWatermark", Array.Empty<object>());
        }

        public Color CLASS_COLOR_DRUID
        {
            get
            {
                return base.method_2<Color>("CLASS_COLOR_DRUID");
            }
        }

        public Color CLASS_COLOR_GENERIC
        {
            get
            {
                return base.method_2<Color>("CLASS_COLOR_GENERIC");
            }
        }

        public Color CLASS_COLOR_HUNTER
        {
            get
            {
                return base.method_2<Color>("CLASS_COLOR_HUNTER");
            }
        }

        public Color CLASS_COLOR_MAGE
        {
            get
            {
                return base.method_2<Color>("CLASS_COLOR_MAGE");
            }
        }

        public Color CLASS_COLOR_PALADIN
        {
            get
            {
                return base.method_2<Color>("CLASS_COLOR_PALADIN");
            }
        }

        public Color CLASS_COLOR_PRIEST
        {
            get
            {
                return base.method_2<Color>("CLASS_COLOR_PRIEST");
            }
        }

        public Color CLASS_COLOR_ROGUE
        {
            get
            {
                return base.method_2<Color>("CLASS_COLOR_ROGUE");
            }
        }

        public Color CLASS_COLOR_SHAMAN
        {
            get
            {
                return base.method_2<Color>("CLASS_COLOR_SHAMAN");
            }
        }

        public Color CLASS_COLOR_WARLOCK
        {
            get
            {
                return base.method_2<Color>("CLASS_COLOR_WARLOCK");
            }
        }

        public Color CLASS_COLOR_WARRIOR
        {
            get
            {
                return base.method_2<Color>("CLASS_COLOR_WARRIOR");
            }
        }

        public bool forceIdleState
        {
            get
            {
                return base.method_2<bool>("forceIdleState");
            }
        }

        public Color GEM_COLOR_COMMON
        {
            get
            {
                return base.method_2<Color>("GEM_COLOR_COMMON");
            }
        }

        public Color GEM_COLOR_EPIC
        {
            get
            {
                return base.method_2<Color>("GEM_COLOR_EPIC");
            }
        }

        public Color GEM_COLOR_LEGENDARY
        {
            get
            {
                return base.method_2<Color>("GEM_COLOR_LEGENDARY");
            }
        }

        public Color GEM_COLOR_RARE
        {
            get
            {
                return base.method_2<Color>("GEM_COLOR_RARE");
            }
        }

        public Vector2 GEM_TEXTURE_OFFSET_COMMON
        {
            get
            {
                return base.method_2<Vector2>("GEM_TEXTURE_OFFSET_COMMON");
            }
        }

        public Vector2 GEM_TEXTURE_OFFSET_EPIC
        {
            get
            {
                return base.method_2<Vector2>("GEM_TEXTURE_OFFSET_EPIC");
            }
        }

        public Vector2 GEM_TEXTURE_OFFSET_LEGENDARY
        {
            get
            {
                return base.method_2<Vector2>("GEM_TEXTURE_OFFSET_LEGENDARY");
            }
        }

        public Vector2 GEM_TEXTURE_OFFSET_RARE
        {
            get
            {
                return base.method_2<Vector2>("GEM_TEXTURE_OFFSET_RARE");
            }
        }

        public bool isPortraitMaterialDirty
        {
            get
            {
                return base.method_2<bool>("isPortraitMaterialDirty");
            }
        }

        public ActorStateType m_actorState
        {
            get
            {
                return base.method_2<ActorStateType>("m_actorState");
            }
        }

        public ActorStateMgr m_actorStateMgr
        {
            get
            {
                return base.method_3<ActorStateMgr>("m_actorStateMgr");
            }
        }

        public ActorStateType m_actualState
        {
            get
            {
                return base.method_2<ActorStateType>("m_actualState");
            }
        }

        public ArmorSpell m_armorSpell
        {
            get
            {
                return base.method_3<ArmorSpell>("m_armorSpell");
            }
        }

        public GameObject m_armorSpellBone
        {
            get
            {
                return base.method_3<GameObject>("m_armorSpellBone");
            }
        }

        public bool m_armorSpellLoading
        {
            get
            {
                return base.method_2<bool>("m_armorSpellLoading");
            }
        }

        public GameObject m_attackObject
        {
            get
            {
                return base.method_3<GameObject>("m_attackObject");
            }
        }

        public UberText m_attackTextMesh
        {
            get
            {
                return base.method_3<UberText>("m_attackTextMesh");
            }
        }

        public GameObject m_bones
        {
            get
            {
                return base.method_3<GameObject>("m_bones");
            }
        }

        public Card m_card
        {
            get
            {
                return base.method_3<Card>("m_card");
            }
        }

        public int m_cardBackMatIdx
        {
            get
            {
                return base.method_2<int>("m_cardBackMatIdx");
            }
        }

        public CardDef m_cardDef
        {
            get
            {
                return base.method_3<CardDef>("m_cardDef");
            }
        }

        public int m_cardFrontMatIdx
        {
            get
            {
                return base.method_2<int>("m_cardFrontMatIdx");
            }
        }

        public GameObject m_cardMesh
        {
            get
            {
                return base.method_3<GameObject>("m_cardMesh");
            }
        }

        public GameObject m_cardTypeAnchorObject
        {
            get
            {
                return base.method_3<GameObject>("m_cardTypeAnchorObject");
            }
        }

        public GameObject m_classIconObject
        {
            get
            {
                return base.method_3<GameObject>("m_classIconObject");
            }
        }

        public UberText m_costTextMesh
        {
            get
            {
                return base.method_3<UberText>("m_costTextMesh");
            }
        }

        public GameObject m_descriptionMesh
        {
            get
            {
                return base.method_3<GameObject>("m_descriptionMesh");
            }
        }

        public GameObject m_descriptionTrimMesh
        {
            get
            {
                return base.method_3<GameObject>("m_descriptionTrimMesh");
            }
        }

        public bool m_DisablePremiumPortrait
        {
            get
            {
                return base.method_2<bool>("m_DisablePremiumPortrait");
            }
        }

        public GameObject m_eliteObject
        {
            get
            {
                return base.method_3<GameObject>("m_eliteObject");
            }
        }

        public Triton.Game.Mapping.Entity m_entity
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_entity");
            }
        }

        public EntityDef m_entityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_entityDef");
            }
        }

        public bool m_ghostCard
        {
            get
            {
                return base.method_2<bool>("m_ghostCard");
            }
        }

        public GameObject m_ghostCardGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_ghostCardGameObject");
            }
        }

        public GameObject m_glints
        {
            get
            {
                return base.method_3<GameObject>("m_glints");
            }
        }

        public GameObject m_healthObject
        {
            get
            {
                return base.method_3<GameObject>("m_healthObject");
            }
        }

        public UberText m_healthTextMesh
        {
            get
            {
                return base.method_3<UberText>("m_healthTextMesh");
            }
        }

        public GameObject m_heroSpotLight
        {
            get
            {
                return base.method_3<GameObject>("m_heroSpotLight");
            }
        }

        public GameObject m_hiddenCardStandIn
        {
            get
            {
                return base.method_3<GameObject>("m_hiddenCardStandIn");
            }
        }

        public bool m_hideActorState
        {
            get
            {
                return base.method_2<bool>("m_hideActorState");
            }
        }

        public bool m_ignoreUpdateCardback
        {
            get
            {
                return base.method_2<bool>("m_ignoreUpdateCardback");
            }
        }

        public Material m_initialPortraitMaterial
        {
            get
            {
                return base.method_3<Material>("m_initialPortraitMaterial");
            }
        }

        public int m_legacyCardColorMaterialIndex
        {
            get
            {
                return base.method_2<int>("m_legacyCardColorMaterialIndex");
            }
        }

        public int m_legacyPortraitMaterialIndex
        {
            get
            {
                return base.method_2<int>("m_legacyPortraitMaterialIndex");
            }
        }

        public List<Material> m_lightBlendMaterials
        {
            get
            {
                Class267<Material> class2 = base.method_3<Class267<Material>>("m_lightBlendMaterials");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<UberText> m_lightBlendUberText
        {
            get
            {
                Class267<UberText> class2 = base.method_3<Class267<UberText>>("m_lightBlendUberText");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_manaObject
        {
            get
            {
                return base.method_3<GameObject>("m_manaObject");
            }
        }

        public bool m_materialEffectsSeeded
        {
            get
            {
                return base.method_2<bool>("m_materialEffectsSeeded");
            }
        }

        public MeshRenderer m_meshRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_meshRenderer");
            }
        }

        public bool m_missingcard
        {
            get
            {
                return base.method_2<bool>("m_missingcard");
            }
        }

        public GameObject m_missingCardEffect
        {
            get
            {
                return base.method_3<GameObject>("m_missingCardEffect");
            }
        }

        public GameObject m_nameBannerMesh
        {
            get
            {
                return base.method_3<GameObject>("m_nameBannerMesh");
            }
        }

        public UberText m_nameTextMesh
        {
            get
            {
                return base.method_3<UberText>("m_nameTextMesh");
            }
        }

        public int m_portraitFrameMatIdx
        {
            get
            {
                return base.method_2<int>("m_portraitFrameMatIdx");
            }
        }

        public int m_portraitMatIdx
        {
            get
            {
                return base.method_2<int>("m_portraitMatIdx");
            }
        }

        public GameObject m_portraitMesh
        {
            get
            {
                return base.method_3<GameObject>("m_portraitMesh");
            }
        }

        public Texture m_portraitTextureOverride
        {
            get
            {
                return base.method_3<Texture>("m_portraitTextureOverride");
            }
        }

        public UberText m_powersTextMesh
        {
            get
            {
                return base.method_3<UberText>("m_powersTextMesh");
            }
        }

        public int m_premiumRibbon
        {
            get
            {
                return base.method_2<int>("m_premiumRibbon");
            }
        }

        public TAG_PREMIUM m_premiumType
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("m_premiumType");
            }
        }

        public ProjectedShadow m_projectedShadow
        {
            get
            {
                return base.method_3<ProjectedShadow>("m_projectedShadow");
            }
        }

        public GameObject m_racePlateMesh
        {
            get
            {
                return base.method_3<GameObject>("m_racePlateMesh");
            }
        }

        public GameObject m_racePlateObject
        {
            get
            {
                return base.method_3<GameObject>("m_racePlateObject");
            }
        }

        public UberText m_raceTextMesh
        {
            get
            {
                return base.method_3<UberText>("m_raceTextMesh");
            }
        }

        public GameObject m_rarityFrameMesh
        {
            get
            {
                return base.method_3<GameObject>("m_rarityFrameMesh");
            }
        }

        public GameObject m_rarityGemMesh
        {
            get
            {
                return base.method_3<GameObject>("m_rarityGemMesh");
            }
        }

        public GameObject m_rootObject
        {
            get
            {
                return base.method_3<GameObject>("m_rootObject");
            }
        }

        public UberText m_secretText
        {
            get
            {
                return base.method_3<UberText>("m_secretText");
            }
        }

        public bool m_shadowform
        {
            get
            {
                return base.method_2<bool>("m_shadowform");
            }
        }

        public SpellTable m_sharedSpellTable
        {
            get
            {
                return base.method_3<SpellTable>("m_sharedSpellTable");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public SpellTable m_spellTable
        {
            get
            {
                return base.method_3<SpellTable>("m_spellTable");
            }
        }

        public string m_spellTablePrefab
        {
            get
            {
                return base.method_4("m_spellTablePrefab");
            }
        }

        public bool m_useSharedSpellTable
        {
            get
            {
                return base.method_2<bool>("m_useSharedSpellTable");
            }
        }

        public static string WATERMARK_BRM
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Actor", "WATERMARK_BRM");
            }
        }

        public static string WATERMARK_EXPERT1
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Actor", "WATERMARK_EXPERT1");
            }
        }

        public static string WATERMARK_FP1
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Actor", "WATERMARK_FP1");
            }
        }

        public static string WATERMARK_GVG
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Actor", "WATERMARK_GVG");
            }
        }

        public static string WATERMARK_LOE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Actor", "WATERMARK_LOE");
            }
        }

        public static string WATERMARK_TGT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Actor", "WATERMARK_TGT");
            }
        }
    }
}

