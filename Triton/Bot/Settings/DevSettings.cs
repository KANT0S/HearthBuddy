namespace Triton.Bot.Settings
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Reflection;
    using Triton.Common;

    public class DevSettings : JsonSettings
    {
        private static DevSettings devSettings_0;
        private string string_1;
        private string string_2;
        private string string_3;
        private string string_4;

        public DevSettings() : base(JsonSettings.GetSettingsFilePath(textArray1))
        {
            string[] textArray1 = new string[] { Configuration.Instance.Name, string.Format("{0}.json", "Dev") };
        }

        [DefaultValue("System.dll\r\nSystem.Core.dll\r\nHearthbuddy.exe\r\nlog4net.dll\r\ngreymagic.dll")]
        public string Assemblies
        {
            get
            {
                return this.string_2;
            }
            set
            {
                if (!value.Equals(this.string_2))
                {
                    this.string_2 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(DevSettings)), (MethodInfo) methodof(DevSettings.get_Assemblies)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue("RuntimeCode")]
        public string ClassName
        {
            get
            {
                return this.string_3;
            }
            set
            {
                if (!value.Equals(this.string_3))
                {
                    this.string_3 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(DevSettings)), (MethodInfo) methodof(DevSettings.get_ClassName)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue("using Triton.Common;\r\nusing Triton.Game;\r\nusing Triton.Bot;\r\nusing log4net;\r\nusing Logger = Triton.Common.LogUtilities.Logger;\r\n\r\npublic class RuntimeCode\r\n{\r\n\tprivate static readonly ILog Log = Logger.GetLoggerInstanceForType();\r\n\r\n\tpublic void Execute()\r\n\t{\r\n\t\tusing(TritonHs.AcquireFrame())\r\n\t\t{\r\n\t\t\tLog.DebugFormat(\"Hello World!\");\r\n\t\t}\r\n\t}\r\n}")]
        public string Code
        {
            get
            {
                return this.string_4;
            }
            set
            {
                if (!value.Equals(this.string_4))
                {
                    this.string_4 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(DevSettings)), (MethodInfo) methodof(DevSettings.get_Code)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue("")]
        public string FileName
        {
            get
            {
                return this.string_1;
            }
            set
            {
                if (!value.Equals(this.string_1))
                {
                    this.string_1 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(DevSettings)), (MethodInfo) methodof(DevSettings.get_FileName)), new ParameterExpression[0]));
                }
            }
        }

        public static DevSettings Instance
        {
            get
            {
                return (devSettings_0 ?? (devSettings_0 = new DevSettings()));
            }
        }
    }
}

