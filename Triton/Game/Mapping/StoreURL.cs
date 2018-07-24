namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("StoreURL")]
    public class StoreURL : MonoClass
    {
        public StoreURL(IntPtr address) : this(address, "StoreURL")
        {
        }

        public StoreURL(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetParamString(Param paramType)
        {
            object[] objArray1 = new object[] { paramType };
            return base.method_13("GetParamString", objArray1);
        }

        public string GetURL()
        {
            return base.method_13("GetURL", Array.Empty<object>());
        }

        public string m_format
        {
            get
            {
                return base.method_4("m_format");
            }
        }

        public Param m_param1
        {
            get
            {
                return base.method_2<Param>("m_param1");
            }
        }

        public Param m_param2
        {
            get
            {
                return base.method_2<Param>("m_param2");
            }
        }

        public enum Param
        {
            NONE,
            LOCALE,
            REGION
        }
    }
}

