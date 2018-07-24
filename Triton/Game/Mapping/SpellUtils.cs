namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SpellUtils")]
    public class SpellUtils : MonoClass
    {
        public SpellUtils(IntPtr address) : this(address, "SpellUtils")
        {
        }

        public SpellUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool CanAddPowerTargets(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SpellUtils", "CanAddPowerTargets", objArray1);
        }

        public static SpellClassTag ConvertClassTagToSpellEnum(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            return MonoClass.smethod_14<SpellClassTag>(TritonHs.MainAssemblyPath, "", "SpellUtils", "ConvertClassTagToSpellEnum", objArray1);
        }

        public static Player.Side ConvertSpellSideToPlayerSide(Spell spell, SpellPlayerSide spellSide)
        {
            object[] objArray1 = new object[] { spell, spellSide };
            return MonoClass.smethod_14<Player.Side>(TritonHs.MainAssemblyPath, "", "SpellUtils", "ConvertSpellSideToPlayerSide", objArray1);
        }

        public static void FaceOppositeOf(Component source, Component target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceOppositeOf", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceOppositeOf(Component source, GameObject target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceOppositeOf", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceOppositeOf(GameObject source, Component target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceOppositeOf", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceOppositeOf(GameObject source, GameObject target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceOppositeOf", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceOppositeOf(Transform source, Transform target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceOppositeOf", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceSameAs(Component source, Component target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceSameAs", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceSameAs(Component source, GameObject target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceSameAs", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceSameAs(GameObject source, Component target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceSameAs", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceSameAs(GameObject source, GameObject target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceSameAs", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceSameAs(Transform source, Transform target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceSameAs", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceTowards(Component source, Component target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceTowards", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceTowards(Component source, GameObject target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceTowards", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceTowards(GameObject source, Component target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceTowards", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceTowards(GameObject source, GameObject target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceTowards", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FaceTowards(Transform source, Transform target, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, target, options };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SpellUtils", "FaceTowards", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static GameObject FindAutoObjectForSpell(Triton.Game.Mapping.Entity entity, Card card, TAG_CARDTYPE cardType)
        {
            object[] objArray1 = new object[] { entity, card, cardType };
            return MonoClass.smethod_15<GameObject>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindAutoObjectForSpell", objArray1);
        }

        public static Card FindBestTargetCard(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<Card>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindBestTargetCard", objArray1);
        }

        public static Player FindFriendlyPlayer(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<Player>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindFriendlyPlayer", objArray1);
        }

        public static ZonePlay FindFriendlyPlayZone(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<ZonePlay>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindFriendlyPlayZone", objArray1);
        }

        public static Card FindHeroCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return MonoClass.smethod_15<Card>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindHeroCard", objArray1);
        }

        public static Card FindHeroPowerCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return MonoClass.smethod_15<Card>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindHeroPowerCard", objArray1);
        }

        public static Player FindOpponentPlayer(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<Player>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindOpponentPlayer", objArray1);
        }

        public static ZonePlay FindOpponentPlayZone(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<ZonePlay>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindOpponentPlayZone", objArray1);
        }

        public static GameObject FindSourceAutoObjectForSpell(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<GameObject>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindSourceAutoObjectForSpell", objArray1);
        }

        public static GameObject FindTargetAutoObjectForSpell(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<GameObject>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindTargetAutoObjectForSpell", objArray1);
        }

        public static Zone FindTargetZone(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<Zone>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindTargetZone", objArray1);
        }

        public static List<Zone> FindZonesFromTag(SpellZoneTag zoneTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { zoneTag };
            Class267<Zone> class2 = MonoClass.smethod_16<Class267<Zone>>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindZonesFromTag", enumArray1, objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<Zone> FindZonesFromTag(Spell spell, SpellZoneTag zoneTag, SpellPlayerSide spellSide)
        {
            object[] objArray1 = new object[] { spell, zoneTag, spellSide };
            Class267<Zone> class2 = MonoClass.smethod_16<Class267<Zone>>(TritonHs.MainAssemblyPath, "", "SpellUtils", "FindZonesFromTag", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static GameObject GetLocationObject(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<GameObject>(TritonHs.MainAssemblyPath, "", "SpellUtils", "GetLocationObject", objArray1);
        }

        public static Transform GetLocationTransform(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<Transform>(TritonHs.MainAssemblyPath, "", "SpellUtils", "GetLocationTransform", objArray1);
        }

        public static Actor GetParentActor(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<Actor>(TritonHs.MainAssemblyPath, "", "SpellUtils", "GetParentActor", objArray1);
        }

        public static GameObject GetParentRootObject(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<GameObject>(TritonHs.MainAssemblyPath, "", "SpellUtils", "GetParentRootObject", objArray1);
        }

        public static MeshRenderer GetParentRootObjectMesh(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_15<MeshRenderer>(TritonHs.MainAssemblyPath, "", "SpellUtils", "GetParentRootObjectMesh", objArray1);
        }

        public static bool IsNonMetaTaskListInMetaBlock(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SpellUtils", "IsNonMetaTaskListInMetaBlock", objArray1);
        }

        public static void SetCustomSpellParent(Spell spell, Component c)
        {
            object[] objArray1 = new object[] { spell, c };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SpellUtils", "SetCustomSpellParent", objArray1);
        }

        public static void SetOrientation(Transform source, Vector3 sourcePosition, Vector3 targetPosition, SpellFacingOptions options)
        {
            object[] objArray1 = new object[] { source, sourcePosition, targetPosition, options };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SpellUtils", "SetOrientation", objArray1);
        }

        public static bool SetOrientationFromFacing(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SpellUtils", "SetOrientationFromFacing", objArray1);
        }

        public static bool SetPositionFromLocation(Spell spell)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { spell };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "SpellUtils", "SetPositionFromLocation", enumArray1, objArray1);
        }

        public static bool SetPositionFromLocation(Spell spell, bool setParent)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { spell, setParent };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "SpellUtils", "SetPositionFromLocation", enumArray1, objArray1);
        }

        public static void SetupSoundSpell(CardSoundSpell spell, Component c)
        {
            object[] objArray1 = new object[] { spell, c };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SpellUtils", "SetupSoundSpell", objArray1);
        }

        public static void SetupSpell(Spell spell, Component c)
        {
            object[] objArray1 = new object[] { spell, c };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SpellUtils", "SetupSpell", objArray1);
        }
    }
}

