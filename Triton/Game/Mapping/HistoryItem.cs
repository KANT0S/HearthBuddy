namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HistoryItem")]
    public class HistoryItem : MonoBehaviour
    {
        public HistoryItem(IntPtr address) : this(address, "HistoryItem")
        {
        }

        public HistoryItem(IntPtr address, string className) : base(address, className)
        {
        }

        public void DisplaySkullOnActor(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("DisplaySkullOnActor", objArray1);
        }

        public void DisplaySpells()
        {
            base.method_8("DisplaySpells", Array.Empty<object>());
        }

        public void DisplaySplatOnActor(Actor actor, int damage)
        {
            object[] objArray1 = new object[] { actor, damage };
            base.method_8("DisplaySplatOnActor", objArray1);
        }

        public Texture GetBigCardPortraitTexture()
        {
            return base.method_14<Texture>("GetBigCardPortraitTexture", Array.Empty<object>());
        }

        public Material GetBigCardPotraitGoldenMaterial()
        {
            return base.method_14<Material>("GetBigCardPotraitGoldenMaterial", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetEntity()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetEntity", Array.Empty<object>());
        }

        public void InitializeActor()
        {
            base.method_8("InitializeActor", Array.Empty<object>());
        }

        public bool IsInitialized()
        {
            return base.method_11<bool>("IsInitialized", Array.Empty<object>());
        }

        public bool actorHasBeenInitialized
        {
            get
            {
                return base.method_2<bool>("actorHasBeenInitialized");
            }
        }

        public bool dead
        {
            get
            {
                return base.method_2<bool>("dead");
            }
        }

        public bool isFatigue
        {
            get
            {
                return base.method_2<bool>("isFatigue");
            }
        }

        public Texture m_bigCardPortraitTexture
        {
            get
            {
                return base.method_3<Texture>("m_bigCardPortraitTexture");
            }
        }

        public Material m_bigCardPotraitGoldenMaterial
        {
            get
            {
                return base.method_3<Material>("m_bigCardPotraitGoldenMaterial");
            }
        }

        public Triton.Game.Mapping.Entity m_entity
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_entity");
            }
        }

        public Actor m_mainCardActor
        {
            get
            {
                return base.method_3<Actor>("m_mainCardActor");
            }
        }

        public int m_splatAmount
        {
            get
            {
                return base.method_2<int>("m_splatAmount");
            }
        }
    }
}

