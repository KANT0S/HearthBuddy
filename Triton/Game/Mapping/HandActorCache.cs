namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("HandActorCache")]
    public class HandActorCache : MonoClass
    {
        public HandActorCache(IntPtr address) : this(address, "HandActorCache")
        {
        }

        public HandActorCache(IntPtr address, string className) : base(address, className)
        {
        }

        public void FireActorLoadedListeners(string name, Actor actor)
        {
            object[] objArray1 = new object[] { name, actor };
            base.method_8("FireActorLoadedListeners", objArray1);
        }

        public Actor GetActor(EntityDef entityDef, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { entityDef, premium };
            return base.method_14<Actor>("GetActor", objArray1);
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool IsInitializing()
        {
            return base.method_11<bool>("IsInitializing", Array.Empty<object>());
        }

        public ActorKey MakeActorKey(EntityDef entityDef, TAG_PREMIUM premium)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { entityDef, premium };
            return base.method_15<ActorKey>("MakeActorKey", enumArray1, objArray1);
        }

        public ActorKey MakeActorKey(TAG_CARDTYPE cardType, TAG_PREMIUM premiumType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cardType, premiumType };
            return base.method_15<ActorKey>("MakeActorKey", enumArray1, objArray1);
        }

        public void OnActorLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnActorLoaded", objArray1);
        }

        public List<TAG_CARDTYPE> ACTOR_CARD_TYPES
        {
            get
            {
                Class246<TAG_CARDTYPE> class2 = base.method_3<Class246<TAG_CARDTYPE>>("ACTOR_CARD_TYPES");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        [Attribute38("HandActorCache.ActorKey")]
        public class ActorKey : MonoClass
        {
            public ActorKey(IntPtr address) : this(address, "ActorKey")
            {
            }

            public ActorKey(IntPtr address, string className) : base(address, className)
            {
            }

            public bool Equals(object obj)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { obj };
                return base.method_10<bool>("Equals", enumArray1, objArray1);
            }

            public bool Equals(HandActorCache.ActorKey other)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { other };
                return base.method_10<bool>("Equals", enumArray1, objArray1);
            }

            public int GetHashCode()
            {
                return base.method_11<int>("GetHashCode", Array.Empty<object>());
            }

            public static bool op_Equality(HandActorCache.ActorKey a, HandActorCache.ActorKey b)
            {
                object[] objArray1 = new object[] { a, b };
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "ActorKey", "op_Equality", objArray1);
            }

            public static bool op_Inequality(HandActorCache.ActorKey a, HandActorCache.ActorKey b)
            {
                object[] objArray1 = new object[] { a, b };
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "ActorKey", "op_Inequality", objArray1);
            }

            public TAG_CARDTYPE m_cardType
            {
                get
                {
                    return base.method_2<TAG_CARDTYPE>("m_cardType");
                }
            }

            public TAG_PREMIUM m_premiumType
            {
                get
                {
                    return base.method_2<TAG_PREMIUM>("m_premiumType");
                }
            }
        }
    }
}

