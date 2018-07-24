namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("VarKey")]
    public class VarKey : MonoClass
    {
        public VarKey(IntPtr address) : this(address, "VarKey")
        {
        }

        public VarKey(IntPtr address, string className) : base(address, className)
        {
        }

        public bool GetBool(bool def)
        {
            object[] objArray1 = new object[] { def };
            return base.method_11<bool>("GetBool", objArray1);
        }

        public float GetFloat(float def)
        {
            object[] objArray1 = new object[] { def };
            return base.method_11<float>("GetFloat", objArray1);
        }

        public int GetInt(int def)
        {
            object[] objArray1 = new object[] { def };
            return base.method_11<int>("GetInt", objArray1);
        }

        public string GetStr(string def)
        {
            object[] objArray1 = new object[] { def };
            return base.method_13("GetStr", objArray1);
        }

        public VarKey Key(string subKey)
        {
            object[] objArray1 = new object[] { subKey };
            return base.method_14<VarKey>("Key", objArray1);
        }

        public string m_key
        {
            get
            {
                return base.method_4("m_key");
            }
        }
    }
}

