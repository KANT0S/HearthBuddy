namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Options")]
    public class Options : MonoClass
    {
        public Options(IntPtr address) : this(address, "Options")
        {
        }

        public Options(IntPtr address, string className) : base(address, className)
        {
        }

        public void DeleteClientOption(Triton.Game.Mapping.Option option, string optionName)
        {
            object[] objArray1 = new object[] { option, optionName };
            base.method_8("DeleteClientOption", objArray1);
        }

        public void DeleteOption(Triton.Game.Mapping.Option option)
        {
            object[] objArray1 = new object[] { option };
            base.method_8("DeleteOption", objArray1);
        }

        public void DeleteServerOption(Triton.Game.Mapping.Option option, ServerOption serverOption)
        {
            object[] objArray1 = new object[] { option, serverOption };
            base.method_8("DeleteServerOption", objArray1);
        }

        public void DeleteServerOptionFlag(Triton.Game.Mapping.Option option, ServerOptionFlag serverOptionFlag)
        {
            object[] objArray1 = new object[] { option, serverOptionFlag };
            base.method_8("DeleteServerOptionFlag", objArray1);
        }

        public void FireChangedEvent(Triton.Game.Mapping.Option option, object prevVal, bool existed)
        {
            object[] objArray1 = new object[] { option, prevVal, existed };
            base.method_8("FireChangedEvent", objArray1);
        }

        public static Triton.Game.Mapping.Options Get()
        {
            return MonoClass.smethod_15<Triton.Game.Mapping.Options>(TritonHs.MainAssemblyPath, "", "Options", "Get", Array.Empty<object>());
        }

        public bool GetBool(Triton.Game.Mapping.Option option)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { option };
            return base.method_10<bool>("GetBool", enumArray1, objArray1);
        }

        public bool GetBool(Triton.Game.Mapping.Option option, bool defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { option, defaultVal };
            return base.method_10<bool>("GetBool", enumArray1, objArray1);
        }

        public object GetClientOption(Triton.Game.Mapping.Option option, string optionName)
        {
            object[] objArray1 = new object[] { option, optionName };
            return base.method_14<object>("GetClientOption", objArray1);
        }

        public float GetFloat(Triton.Game.Mapping.Option option)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { option };
            return base.method_10<float>("GetFloat", enumArray1, objArray1);
        }

        public float GetFloat(Triton.Game.Mapping.Option option, float defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { option, defaultVal };
            return base.method_10<float>("GetFloat", enumArray1, objArray1);
        }

        public int GetInt(Triton.Game.Mapping.Option option)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { option };
            return base.method_10<int>("GetInt", enumArray1, objArray1);
        }

        public int GetInt(Triton.Game.Mapping.Option option, int defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { option, defaultVal };
            return base.method_10<int>("GetInt", enumArray1, objArray1);
        }

        public long GetLong(Triton.Game.Mapping.Option option)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { option };
            return base.method_10<long>("GetLong", enumArray1, objArray1);
        }

        public long GetLong(Triton.Game.Mapping.Option option, long defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.I8 };
            object[] objArray1 = new object[] { option, defaultVal };
            return base.method_10<long>("GetLong", enumArray1, objArray1);
        }

        public object GetOption(Triton.Game.Mapping.Option option)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { option };
            return base.method_15<object>("GetOption", enumArray1, objArray1);
        }

        public object GetOption(Triton.Game.Mapping.Option option, object defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.Class };
            object[] objArray1 = new object[] { option, defaultVal };
            return base.method_15<object>("GetOption", enumArray1, objArray1);
        }

        public System.Type GetOptionType(Triton.Game.Mapping.Option option)
        {
            object[] objArray1 = new object[] { option };
            return base.method_14<System.Type>("GetOptionType", objArray1);
        }

        public object GetServerOption(Triton.Game.Mapping.Option option, ServerOption serverOption)
        {
            object[] objArray1 = new object[] { option, serverOption };
            return base.method_14<object>("GetServerOption", objArray1);
        }

        public string GetString(Triton.Game.Mapping.Option option)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { option };
            return base.method_12("GetString", enumArray1, objArray1);
        }

        public string GetString(Triton.Game.Mapping.Option option, string defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.String };
            object[] objArray1 = new object[] { option, defaultVal };
            return base.method_12("GetString", enumArray1, objArray1);
        }

        public ulong GetULong(Triton.Game.Mapping.Option option)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { option };
            return base.method_10<ulong>("GetULong", enumArray1, objArray1);
        }

        public ulong GetULong(Triton.Game.Mapping.Option option, ulong defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.U8 };
            object[] objArray1 = new object[] { option, defaultVal };
            return base.method_10<ulong>("GetULong", enumArray1, objArray1);
        }

        public bool HasOption(Triton.Game.Mapping.Option option)
        {
            object[] objArray1 = new object[] { option };
            return base.method_11<bool>("HasOption", objArray1);
        }

        public bool HasServerOptionFlag(ServerOptionFlag serverOptionFlag)
        {
            object[] objArray1 = new object[] { serverOptionFlag };
            return base.method_11<bool>("HasServerOptionFlag", objArray1);
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool IsClientOption(Triton.Game.Mapping.Option option)
        {
            object[] objArray1 = new object[] { option };
            return base.method_11<bool>("IsClientOption", objArray1);
        }

        public bool IsServerOption(Triton.Game.Mapping.Option option)
        {
            object[] objArray1 = new object[] { option };
            return base.method_11<bool>("IsServerOption", objArray1);
        }

        public void RemoveListeners(Triton.Game.Mapping.Option option, object prevVal)
        {
            object[] objArray1 = new object[] { option, prevVal };
            base.method_8("RemoveListeners", objArray1);
        }

        public void SetBool(Triton.Game.Mapping.Option option, bool val)
        {
            object[] objArray1 = new object[] { option, val };
            base.method_8("SetBool", objArray1);
        }

        public void SetFloat(Triton.Game.Mapping.Option option, float val)
        {
            object[] objArray1 = new object[] { option, val };
            base.method_8("SetFloat", objArray1);
        }

        public void SetInt(Triton.Game.Mapping.Option option, int val)
        {
            object[] objArray1 = new object[] { option, val };
            base.method_8("SetInt", objArray1);
        }

        public void SetLong(Triton.Game.Mapping.Option option, long val)
        {
            object[] objArray1 = new object[] { option, val };
            base.method_8("SetLong", objArray1);
        }

        public void SetOption(Triton.Game.Mapping.Option option, object val)
        {
            object[] objArray1 = new object[] { option, val };
            base.method_8("SetOption", objArray1);
        }

        public void SetString(Triton.Game.Mapping.Option option, string val)
        {
            object[] objArray1 = new object[] { option, val };
            base.method_8("SetString", objArray1);
        }

        public void SetULong(Triton.Game.Mapping.Option option, ulong val)
        {
            object[] objArray1 = new object[] { option, val };
            base.method_8("SetULong", objArray1);
        }

        public static string DEPRECATED_NAME_PREFIX
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Options", "DEPRECATED_NAME_PREFIX");
            }
        }

        public static int FLAG_BIT_COUNT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Options", "FLAG_BIT_COUNT");
            }
        }

        public static string FLAG_NAME_PREFIX
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Options", "FLAG_NAME_PREFIX");
            }
        }

        public static float RCP_FLAG_BIT_COUNT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Options", "RCP_FLAG_BIT_COUNT");
            }
        }

        public static List<ServerOption> s_serverFlagContainers
        {
            get
            {
                Class246<ServerOption> class2 = MonoClass.smethod_7<Class246<ServerOption>>(TritonHs.MainAssemblyPath, "", "Options", "s_serverFlagContainers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

