namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("AccountCreationFlipbook")]
    public class AccountCreationFlipbook : MonoClass
    {
        public AccountCreationFlipbook(IntPtr address) : this(address, "AccountCreationFlipbook")
        {
        }

        public AccountCreationFlipbook(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject m_acFlipbook
        {
            get
            {
                return base.method_3<GameObject>("m_acFlipbook");
            }
        }

        public List<Texture> m_acFlipbookTextures
        {
            get
            {
                Class247<Texture> class2 = base.method_3<Class247<Texture>>("m_acFlipbookTextures");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_acFlipbookTimeAlt
        {
            get
            {
                return base.method_2<float>("m_acFlipbookTimeAlt");
            }
        }

        public float m_acFlipbookTimeMax
        {
            get
            {
                return base.method_2<float>("m_acFlipbookTimeMax");
            }
        }

        public float m_acFlipbookTimeMin
        {
            get
            {
                return base.method_2<float>("m_acFlipbookTimeMin");
            }
        }
    }
}

