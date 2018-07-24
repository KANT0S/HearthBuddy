namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SpellImpl")]
    public class SpellImpl : Spell
    {
        public SpellImpl(IntPtr address) : this(address, "SpellImpl")
        {
        }

        public SpellImpl(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject GetActorObject(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<GameObject>("GetActorObject", objArray1);
        }

        public Material GetMaterial(GameObject go, Material material, bool getSharedMaterial, int materialIndex)
        {
            object[] objArray1 = new object[] { go, material, getSharedMaterial, materialIndex };
            return base.method_14<Material>("GetMaterial", objArray1);
        }

        public void InitActorVariables()
        {
            base.method_8("InitActorVariables", Array.Empty<object>());
        }

        public void PlayAnimation(GameObject go, string animName, PlayMode playMode, float crossFade)
        {
            object[] objArray1 = new object[] { go, animName, playMode, crossFade };
            base.method_8("PlayAnimation", objArray1);
        }

        public void PlayParticles(GameObject go, bool includeChildren)
        {
            object[] objArray1 = new object[] { go, includeChildren };
            base.method_8("PlayParticles", objArray1);
        }

        public void SetActorVisibility(bool visible, bool ignoreSpells)
        {
            object[] objArray1 = new object[] { visible, ignoreSpells };
            base.method_8("SetActorVisibility", objArray1);
        }

        public void SetAnimationSpeed(GameObject go, string animName, float speed)
        {
            object[] objArray1 = new object[] { go, animName, speed };
            base.method_8("SetAnimationSpeed", objArray1);
        }

        public void SetAnimationTime(GameObject go, string animName, float time)
        {
            object[] objArray1 = new object[] { go, animName, time };
            base.method_8("SetAnimationTime", objArray1);
        }

        public void SetMaterialColor(GameObject go, Material material, string colorName, Color color, int materialIndex)
        {
            object[] objArray1 = new object[] { go, material, colorName, color, materialIndex };
            base.method_8("SetMaterialColor", objArray1);
        }

        public void SetVisibility(GameObject go, bool visible)
        {
            object[] objArray1 = new object[] { go, visible };
            base.method_8("SetVisibility", objArray1);
        }

        public void SetVisibilityRecursive(GameObject go, bool visible)
        {
            object[] objArray1 = new object[] { go, visible };
            base.method_8("SetVisibilityRecursive", objArray1);
        }

        public Actor m_actor
        {
            get
            {
                return base.method_3<Actor>("m_actor");
            }
        }

        public GameObject m_rootObject
        {
            get
            {
                return base.method_3<GameObject>("m_rootObject");
            }
        }

        public MeshRenderer m_rootObjectRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_rootObjectRenderer");
            }
        }
    }
}

