namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ChangedCardMgr")]
    public class ChangedCardMgr : MonoClass
    {
        public ChangedCardMgr(IntPtr address) : this(address, "ChangedCardMgr")
        {
        }

        public ChangedCardMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCard(TrackedCard card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("AddCard", objArray1);
        }

        public bool AllowCard(int index, int dbId)
        {
            object[] objArray1 = new object[] { index, dbId };
            return base.method_11<bool>("AllowCard", objArray1);
        }

        public TrackedCard FindCard(int index, int dbId)
        {
            object[] objArray1 = new object[] { index, dbId };
            return base.method_14<TrackedCard>("FindCard", objArray1);
        }

        public static ChangedCardMgr Get()
        {
            return MonoClass.smethod_15<ChangedCardMgr>(TritonHs.MainAssemblyPath, "", "ChangedCardMgr", "Get", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public void Load()
        {
            base.method_8("Load", Array.Empty<object>());
        }

        public void Save()
        {
            base.method_8("Save", Array.Empty<object>());
        }

        public int m_currentCardNerfIndex
        {
            get
            {
                return base.method_2<int>("m_currentCardNerfIndex");
            }
        }

        public bool m_isInitialized
        {
            get
            {
                return base.method_2<bool>("m_isInitialized");
            }
        }

        public static int MaxViewCount
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ChangedCardMgr", "MaxViewCount");
            }
        }

        [Attribute38("ChangedCardMgr.TrackedCard")]
        public class TrackedCard : MonoClass
        {
            public TrackedCard(IntPtr address) : this(address, "TrackedCard")
            {
            }

            public TrackedCard(IntPtr address, string className) : base(address, className)
            {
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public int Count
            {
                get
                {
                    return base.method_11<int>("get_Count", Array.Empty<object>());
                }
            }

            public int DbId
            {
                get
                {
                    return base.method_11<int>("get_DbId", Array.Empty<object>());
                }
            }

            public int Index
            {
                get
                {
                    return base.method_11<int>("get_Index", Array.Empty<object>());
                }
            }
        }
    }
}

