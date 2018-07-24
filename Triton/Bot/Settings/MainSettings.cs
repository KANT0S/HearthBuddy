namespace Triton.Bot.Settings
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Controls;
    using Triton.Bot;
    using Triton.Common;
    using Triton.Game;

    public class MainSettings : JsonSettings
    {
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private int int_5;
        private int int_6;
        private List<string> list_0;
        private static MainSettings mainSettings_0;
        private ObservableCollection<CustomDeckCache> observableCollection_0;
        private string string_1;
        private string string_2;
        private string string_3;
        private string string_4;
        private string string_5;

        public MainSettings() : base(JsonSettings.GetSettingsFilePath(textArray1))
        {
            string[] textArray1 = new string[] { Configuration.Instance.Name, string.Format("{0}.json", "Main") };
            if (this.list_0 == null)
            {
                List<string> list1 = new List<string> { "Stats" };
                this.list_0 = list1;
            }
            if (this.observableCollection_0 == null)
            {
                this.observableCollection_0 = new ObservableCollection<CustomDeckCache>();
            }
        }

        public void LoadRowDefinitions(RowDefinition topRowDefinition, RowDefinition splitterRowDefinition, RowDefinition bottomRowDefinition)
        {
            GridLengthConverter converter = new GridLengthConverter();
            topRowDefinition.Height = (GridLength) converter.ConvertFromString(this.TopRowDefinitionHeight);
            splitterRowDefinition.Height = (GridLength) converter.ConvertFromString(this.SplitterRowDefinitionHeight);
            bottomRowDefinition.Height = (GridLength) converter.ConvertFromString(this.BottomRowDefinitionHeight);
        }

        public void SaveRowDefinitions(RowDefinition topRowDefinition, RowDefinition splitterRowDefinition, RowDefinition bottomRowDefinition)
        {
            GridLengthConverter converter = new GridLengthConverter();
            this.TopRowDefinitionHeight = converter.ConvertToString(topRowDefinition.Height);
            this.SplitterRowDefinitionHeight = converter.ConvertToString(splitterRowDefinition.Height);
            this.BottomRowDefinitionHeight = converter.ConvertToString(bottomRowDefinition.Height);
        }

        [DefaultValue(0), JsonIgnore]
        public int AccessToken
        {
            get
            {
                return this.int_0;
            }
            set
            {
                if (!value.Equals(this.int_0))
                {
                    this.int_0 = value;
                    base.NotifyPropertyChanged<int>(System.Linq.Expressions.Expression.Lambda<Func<int>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_AccessToken)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(false)]
        public bool AllowExternalAccess
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                if (!value.Equals(this.bool_0))
                {
                    this.bool_0 = value;
                    base.NotifyPropertyChanged<bool>(System.Linq.Expressions.Expression.Lambda<Func<bool>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_AllowExternalAccess)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue("175*")]
        public string BottomRowDefinitionHeight
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
                    base.NotifyPropertyChanged<string>(System.Linq.Expressions.Expression.Lambda<Func<string>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_BottomRowDefinitionHeight)), new ParameterExpression[0]));
                }
            }
        }

        [JsonIgnore]
        public ObservableCollection<CustomDeckCache> CustomDecks
        {
            get
            {
                return this.observableCollection_0;
            }
            set
            {
                if (!value.Equals(this.observableCollection_0))
                {
                    this.observableCollection_0 = value;
                    base.NotifyPropertyChanged<ObservableCollection<CustomDeckCache>>(System.Linq.Expressions.Expression.Lambda<Func<ObservableCollection<CustomDeckCache>>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_CustomDecks)), new ParameterExpression[0]));
                }
            }
        }

        public List<string> EnabledPlugins
        {
            get
            {
                return this.list_0;
            }
            set
            {
                if (!value.Equals(this.list_0))
                {
                    this.list_0 = value;
                    base.NotifyPropertyChanged<List<string>>(System.Linq.Expressions.Expression.Lambda<Func<List<string>>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_EnabledPlugins)), new ParameterExpression[0]));
                }
            }
        }

        public int InputEventMsDelay
        {
            get
            {
                return Input.InputEventMsDelay;
            }
            set
            {
                Input.InputEventMsDelay = value;
                base.NotifyPropertyChanged<int>(System.Linq.Expressions.Expression.Lambda<Func<int>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_InputEventMsDelay)), new ParameterExpression[0]));
            }
        }

        public static MainSettings Instance
        {
            get
            {
                return (mainSettings_0 ?? (mainSettings_0 = new MainSettings()));
            }
        }

        [DefaultValue("DefaultBot")]
        public string LastBot
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
                    base.NotifyPropertyChanged<string>(System.Linq.Expressions.Expression.Lambda<Func<string>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_LastBot)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(0)]
        public int LastDeckCachePid
        {
            get
            {
                return this.int_6;
            }
            set
            {
                if (!value.Equals(this.int_6))
                {
                    this.int_6 = value;
                    base.NotifyPropertyChanged<int>(System.Linq.Expressions.Expression.Lambda<Func<int>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_LastDeckCachePid)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue("DefaultRoutine")]
        public string LastRoutine
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
                    base.NotifyPropertyChanged<string>(System.Linq.Expressions.Expression.Lambda<Func<string>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_LastRoutine)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(0x3e8)]
        public int MsBetweenGuiTicks
        {
            get
            {
                return this.int_5;
            }
            set
            {
                if (!value.Equals(this.int_5))
                {
                    this.int_5 = value;
                    base.NotifyPropertyChanged<int>(System.Linq.Expressions.Expression.Lambda<Func<int>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_MsBetweenGuiTicks)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(15)]
        public int MsBetweenTicks
        {
            get
            {
                return BotManager.MsBetweenTicks;
            }
            set
            {
                BotManager.MsBetweenTicks = value;
                base.NotifyPropertyChanged<int>(System.Linq.Expressions.Expression.Lambda<Func<int>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_MsBetweenTicks)), new ParameterExpression[0]));
            }
        }

        [DefaultValue(false)]
        public bool ShowConfigurationTab
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                if (!value.Equals(this.bool_3))
                {
                    this.bool_3 = value;
                    base.NotifyPropertyChanged<bool>(System.Linq.Expressions.Expression.Lambda<Func<bool>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_ShowConfigurationTab)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(false)]
        public bool ShowDevTab
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                if (!value.Equals(this.bool_1))
                {
                    this.bool_1 = value;
                    base.NotifyPropertyChanged<bool>(System.Linq.Expressions.Expression.Lambda<Func<bool>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_ShowDevTab)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(false)]
        public bool ShowGlobalTab
        {
            get
            {
                return this.bool_4;
            }
            set
            {
                if (!value.Equals(this.bool_4))
                {
                    this.bool_4 = value;
                    base.NotifyPropertyChanged<bool>(System.Linq.Expressions.Expression.Lambda<Func<bool>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_ShowGlobalTab)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(false)]
        public bool ShowToolsTab
        {
            get
            {
                return this.bool_2;
            }
            set
            {
                if (!value.Equals(this.bool_2))
                {
                    this.bool_2 = value;
                    base.NotifyPropertyChanged<bool>(System.Linq.Expressions.Expression.Lambda<Func<bool>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_ShowToolsTab)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue("Auto")]
        public string SplitterRowDefinitionHeight
        {
            get
            {
                return this.string_5;
            }
            set
            {
                if (!value.Equals(this.string_5))
                {
                    this.string_5 = value;
                    base.NotifyPropertyChanged<string>(System.Linq.Expressions.Expression.Lambda<Func<string>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_SplitterRowDefinitionHeight)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue("295*")]
        public string TopRowDefinitionHeight
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
                    base.NotifyPropertyChanged<string>(System.Linq.Expressions.Expression.Lambda<Func<string>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_TopRowDefinitionHeight)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(600)]
        public int WindowHeight
        {
            get
            {
                return this.int_2;
            }
            set
            {
                if (!value.Equals(this.int_2))
                {
                    this.int_2 = value;
                    base.NotifyPropertyChanged<int>(System.Linq.Expressions.Expression.Lambda<Func<int>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_WindowHeight)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(0x273)]
        public int WindowWidth
        {
            get
            {
                return this.int_1;
            }
            set
            {
                if (!value.Equals(this.int_1))
                {
                    this.int_1 = value;
                    base.NotifyPropertyChanged<int>(System.Linq.Expressions.Expression.Lambda<Func<int>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_WindowWidth)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(0)]
        public int WindowX
        {
            get
            {
                return this.int_3;
            }
            set
            {
                if (!value.Equals(this.int_3))
                {
                    this.int_3 = value;
                    base.NotifyPropertyChanged<int>(System.Linq.Expressions.Expression.Lambda<Func<int>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_WindowX)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(0)]
        public int WindowY
        {
            get
            {
                return this.int_4;
            }
            set
            {
                if (!value.Equals(this.int_4))
                {
                    this.int_4 = value;
                    base.NotifyPropertyChanged<int>(System.Linq.Expressions.Expression.Lambda<Func<int>>(System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression.Constant(this, typeof(MainSettings)), (MethodInfo) methodof(MainSettings.get_WindowY)), new ParameterExpression[0]));
                }
            }
        }
    }
}

