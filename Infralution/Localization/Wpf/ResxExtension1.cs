namespace Infralution.Localization.Wpf
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    using System.Resources;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Interop;
    using System.Windows.Markup;
    using System.Windows.Media.Imaging;

    [ContentProperty("Children"), MarkupExtensionReturnType(typeof(object))]
    public class ResxExtension1 : ManagedMarkupExtension1
    {
        private System.Windows.Data.Binding binding_0;
        private Collection<ResxExtension1> collection_0;
        public static readonly DependencyProperty DefaultResxNameProperty = DependencyProperty.RegisterAttached("DefaultResxName", typeof(string), typeof(ResxExtension1), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits | FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(ResxExtension1.smethod_0)));
        private static Dictionary<string, WeakReference> dictionary_0 = new Dictionary<string, WeakReference>();
        private static MarkupExtensionManager1 markupExtensionManager1_0 = new MarkupExtensionManager1(40);
        private ResourceManager resourceManager_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private string string_3;

        [field: CompilerGenerated]
        public static  event GetResourceHandler1 GetResource;

        public ResxExtension1() : base(markupExtensionManager1_0)
        {
            this.collection_0 = new Collection<ResxExtension1>();
        }

        public ResxExtension1(string key) : base(markupExtensionManager1_0)
        {
            this.collection_0 = new Collection<ResxExtension1>();
            this.string_2 = key;
        }

        [DllImport("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr intptr_0);
        [AttachedPropertyBrowsableForChildren(IncludeDescendants=true)]
        public static string GetDefaultResxName(DependencyObject target)
        {
            return (string) target.GetValue(DefaultResxNameProperty);
        }

        protected override object GetValue()
        {
            if (string.IsNullOrEmpty(this.Key))
            {
                return null;
            }
            object obj2 = null;
            if (!string.IsNullOrEmpty(this.ResxName))
            {
                try
                {
                    if (getResourceHandler1_0 != null)
                    {
                        obj2 = getResourceHandler1_0(this.ResxName, this.Key, CultureManager1.UICulture);
                    }
                    if (obj2 == null)
                    {
                        if (this.resourceManager_0 == null)
                        {
                            this.resourceManager_0 = this.method_4(this.ResxName);
                        }
                        if (this.resourceManager_0 != null)
                        {
                            obj2 = this.resourceManager_0.GetObject(this.Key, CultureManager1.UICulture);
                        }
                    }
                    if (!this.Boolean_2)
                    {
                        obj2 = this.method_5(obj2);
                    }
                }
                catch
                {
                }
            }
            if (obj2 == null)
            {
                obj2 = this.method_6(this.Key);
            }
            return obj2;
        }

        private System.Windows.Data.Binding method_0()
        {
            System.Windows.Data.Binding binding = new System.Windows.Data.Binding();
            if (this.Boolean_0)
            {
                if (this.binding_0.ElementName != null)
                {
                    binding.ElementName = this.binding_0.ElementName;
                }
                if (this.binding_0.RelativeSource != null)
                {
                    binding.RelativeSource = this.binding_0.RelativeSource;
                }
                if (this.binding_0.Source != null)
                {
                    binding.Source = this.binding_0.Source;
                }
                binding.AsyncState = this.binding_0.AsyncState;
                binding.BindingGroupName = this.binding_0.BindingGroupName;
                binding.BindsDirectlyToSource = this.binding_0.BindsDirectlyToSource;
                binding.Converter = this.binding_0.Converter;
                binding.ConverterCulture = this.binding_0.ConverterCulture;
                binding.ConverterParameter = this.binding_0.ConverterParameter;
                binding.FallbackValue = this.binding_0.FallbackValue;
                binding.IsAsync = this.binding_0.IsAsync;
                binding.Mode = this.binding_0.Mode;
                binding.NotifyOnSourceUpdated = this.binding_0.NotifyOnSourceUpdated;
                binding.NotifyOnTargetUpdated = this.binding_0.NotifyOnTargetUpdated;
                binding.NotifyOnValidationError = this.binding_0.NotifyOnValidationError;
                binding.Path = this.binding_0.Path;
                binding.TargetNullValue = this.binding_0.TargetNullValue;
                binding.UpdateSourceTrigger = this.binding_0.UpdateSourceTrigger;
                binding.ValidatesOnDataErrors = this.binding_0.ValidatesOnDataErrors;
                binding.ValidatesOnExceptions = this.binding_0.ValidatesOnExceptions;
                foreach (ValidationRule rule in this.binding_0.ValidationRules)
                {
                    binding.ValidationRules.Add(rule);
                }
                binding.XPath = this.binding_0.XPath;
                binding.StringFormat = this.GetValue() as string;
                return binding;
            }
            binding.Source = this.GetValue();
            return binding;
        }

        private MultiBinding method_1()
        {
            MultiBinding binding = new MultiBinding();
            foreach (ResxExtension1 extension in this.collection_0)
            {
                if (extension.ResxName == null)
                {
                    extension.ResxName = this.ResxName;
                }
                binding.Bindings.Add(extension.method_0());
            }
            binding.StringFormat = this.GetValue() as string;
            return binding;
        }

        private bool method_2(Assembly assembly_0, string string_4)
        {
            if (assembly_0.GetType().Name != "AssemblyBuilder")
            {
                try
                {
                    string str = string_4.ToLower() + ".resources";
                    string[] manifestResourceNames = assembly_0.GetManifestResourceNames();
                    for (int i = 0; i < manifestResourceNames.Length; i++)
                    {
                        if (manifestResourceNames[i].ToLower() == str)
                        {
                            return true;
                        }
                    }
                }
                catch
                {
                }
            }
            return false;
        }

        private Assembly method_3()
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            if ((entryAssembly != null) && this.method_2(entryAssembly, this.ResxName))
            {
                return entryAssembly;
            }
            foreach (Assembly assembly2 in AppDomain.CurrentDomain.GetAssemblies())
            {
                string fullName = assembly2.FullName;
                if (((!fullName.StartsWith("Microsoft.") && !fullName.StartsWith("System.")) && (!fullName.StartsWith("System,") && !fullName.StartsWith("mscorlib,"))) && ((!fullName.StartsWith("PresentationFramework,") && !fullName.StartsWith("WindowsBase,")) && this.method_2(assembly2, this.ResxName)))
                {
                    return assembly2;
                }
            }
            return null;
        }

        private ResourceManager method_4(string string_4)
        {
            WeakReference reference = null;
            ResourceManager target = null;
            if (string_4 == null)
            {
                return null;
            }
            if (dictionary_0.TryGetValue(string_4, out reference))
            {
                target = reference.Target as ResourceManager;
                if (target == null)
                {
                    dictionary_0.Remove(string_4);
                }
            }
            if (target == null)
            {
                Assembly assembly = this.method_3();
                if (assembly != null)
                {
                    target = new ResourceManager(string_4, assembly);
                }
                dictionary_0.Add(string_4, new WeakReference(target));
            }
            return target;
        }

        private object method_5(object object_1)
        {
            object obj2 = null;
            BitmapSource source = null;
            if (object_1 is Icon)
            {
                Icon icon = object_1 as Icon;
                using (MemoryStream stream = new MemoryStream())
                {
                    icon.Save(stream);
                    stream.Seek(0L, SeekOrigin.Begin);
                    source = BitmapFrame.Create(stream);
                    goto Label_0079;
                }
            }
            if (object_1 is Bitmap)
            {
                IntPtr hbitmap = (object_1 as Bitmap).GetHbitmap();
                source = Imaging.CreateBitmapSourceFromHBitmap(hbitmap, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
                source.Freeze();
                DeleteObject(hbitmap);
            }
        Label_0079:
            if (source != null)
            {
                if (base.TargetPropertyType == typeof(object))
                {
                    return new System.Windows.Controls.Image { Source = source, Width = source.Width, Height = source.Height };
                }
                return source;
            }
            obj2 = object_1;
            Type targetPropertyType = base.TargetPropertyType;
            if (((targetPropertyType != null) && (object_1 is string)) && ((targetPropertyType != typeof(string)) && (targetPropertyType != typeof(object))))
            {
                obj2 = TypeDescriptor.GetConverter(targetPropertyType).ConvertFromInvariantString(object_1 as string);
            }
            return obj2;
        }

        private object method_6(string string_4)
        {
            object obj2 = this.string_3;
            Type targetPropertyType = base.TargetPropertyType;
            if (this.string_3 == null)
            {
                if ((!(targetPropertyType == typeof(string)) && !(targetPropertyType == typeof(object))) && !this.Boolean_2)
                {
                    return obj2;
                }
                return ("#" + string_4);
            }
            if (((targetPropertyType != null) && (targetPropertyType != typeof(string))) && (targetPropertyType != typeof(object)))
            {
                try
                {
                    obj2 = TypeDescriptor.GetConverter(targetPropertyType).ConvertFromInvariantString(this.string_3);
                }
                catch
                {
                }
            }
            return obj2;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            this.RegisterTarget(serviceProvider);
            if (base.IsInDesignMode)
            {
                CultureManager1.smethod_1();
            }
            if (string.IsNullOrEmpty(this.Key) && !this.Boolean_0)
            {
                throw new ArgumentException("You must set the resource Key or Binding properties");
            }
            if ((base.TargetProperty != null) && !this.Boolean_2)
            {
                if (this.Boolean_1)
                {
                    return this.method_1().ProvideValue(serviceProvider);
                }
                if (this.Boolean_0)
                {
                    return this.method_0().ProvideValue(serviceProvider);
                }
                return this.GetValue();
            }
            return this;
        }

        public static void SetDefaultResxName(DependencyObject target, string value)
        {
            target.SetValue(DefaultResxNameProperty, value);
        }

        private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            if (DesignerProperties.GetIsInDesignMode(dependencyObject_0))
            {
                foreach (ResxExtension1 extension in MarkupManager.ActiveExtensions)
                {
                    if (extension.IsTarget(dependencyObject_0))
                    {
                        extension.resourceManager_0 = null;
                        extension.string_1 = dependencyPropertyChangedEventArgs_0.NewValue as string;
                        extension.UpdateTarget(dependencyObject_0);
                    }
                }
            }
        }

        public static void UpdateAllTargets()
        {
            markupExtensionManager1_0.UpdateAllTargets();
        }

        protected override void UpdateTarget(object target)
        {
            if (!this.Boolean_2)
            {
                if (this.Boolean_1)
                {
                    FrameworkElement element = target as FrameworkElement;
                    if (element != null)
                    {
                        MultiBinding binding = this.method_1();
                        element.SetBinding(base.TargetProperty as DependencyProperty, binding);
                    }
                }
                else if (this.Boolean_0)
                {
                    FrameworkElement element2 = target as FrameworkElement;
                    if (element2 != null)
                    {
                        System.Windows.Data.Binding binding2 = this.method_0();
                        element2.SetBinding(base.TargetProperty as DependencyProperty, binding2);
                    }
                }
                else
                {
                    base.UpdateTarget(target);
                }
            }
        }

        public static void UpdateTarget(string key)
        {
            foreach (ResxExtension1 extension in markupExtensionManager1_0.ActiveExtensions)
            {
                if (extension.Key == key)
                {
                    extension.UpdateTargets();
                }
            }
        }

        public System.Windows.Data.Binding Binding
        {
            get
            {
                if (this.binding_0 == null)
                {
                    this.binding_0 = new System.Windows.Data.Binding();
                }
                return this.binding_0;
            }
        }

        [DefaultValue((string) null)]
        public object BindingAsyncState
        {
            get
            {
                return this.Binding.AsyncState;
            }
            set
            {
                this.Binding.AsyncState = value;
            }
        }

        [DefaultValue((string) null)]
        public IValueConverter BindingConverter
        {
            get
            {
                return this.Binding.Converter;
            }
            set
            {
                this.Binding.Converter = value;
            }
        }

        [DefaultValue((string) null)]
        public CultureInfo BindingConverterCulture
        {
            get
            {
                return this.Binding.ConverterCulture;
            }
            set
            {
                this.Binding.ConverterCulture = value;
            }
        }

        [DefaultValue((string) null)]
        public object BindingConverterParameter
        {
            get
            {
                return this.Binding.ConverterParameter;
            }
            set
            {
                this.Binding.ConverterParameter = value;
            }
        }

        [DefaultValue((string) null)]
        public string BindingElementName
        {
            get
            {
                return this.Binding.ElementName;
            }
            set
            {
                this.Binding.ElementName = value;
            }
        }

        [DefaultValue((string) null)]
        public object BindingFallbackValue
        {
            get
            {
                return this.Binding.FallbackValue;
            }
            set
            {
                this.Binding.FallbackValue = value;
            }
        }

        [DefaultValue((string) null)]
        public string BindingGroupName
        {
            get
            {
                return this.Binding.BindingGroupName;
            }
            set
            {
                this.Binding.BindingGroupName = value;
            }
        }

        [DefaultValue(false)]
        public bool BindingIsAsync
        {
            get
            {
                return this.Binding.IsAsync;
            }
            set
            {
                this.Binding.IsAsync = value;
            }
        }

        [DefaultValue(4)]
        public System.Windows.Data.BindingMode BindingMode
        {
            get
            {
                return this.Binding.Mode;
            }
            set
            {
                this.Binding.Mode = value;
            }
        }

        [DefaultValue(false)]
        public bool BindingNotifyOnSourceUpdated
        {
            get
            {
                return this.Binding.NotifyOnSourceUpdated;
            }
            set
            {
                this.Binding.NotifyOnSourceUpdated = value;
            }
        }

        [DefaultValue(false)]
        public bool BindingNotifyOnTargetUpdated
        {
            get
            {
                return this.Binding.NotifyOnTargetUpdated;
            }
            set
            {
                this.Binding.NotifyOnTargetUpdated = value;
            }
        }

        [DefaultValue(false)]
        public bool BindingNotifyOnValidationError
        {
            get
            {
                return this.Binding.NotifyOnValidationError;
            }
            set
            {
                this.Binding.NotifyOnValidationError = value;
            }
        }

        [DefaultValue((string) null)]
        public PropertyPath BindingPath
        {
            get
            {
                return this.Binding.Path;
            }
            set
            {
                this.Binding.Path = value;
            }
        }

        [DefaultValue((string) null)]
        public RelativeSource BindingRelativeSource
        {
            get
            {
                return this.Binding.RelativeSource;
            }
            set
            {
                this.Binding.RelativeSource = value;
            }
        }

        [DefaultValue((string) null)]
        public object BindingSource
        {
            get
            {
                return this.Binding.Source;
            }
            set
            {
                this.Binding.Source = value;
            }
        }

        [DefaultValue((string) null)]
        public object BindingTargetNullValue
        {
            get
            {
                return this.Binding.TargetNullValue;
            }
            set
            {
                this.Binding.TargetNullValue = value;
            }
        }

        [DefaultValue(0)]
        public UpdateSourceTrigger BindingUpdateSourceTrigger
        {
            get
            {
                return this.Binding.UpdateSourceTrigger;
            }
            set
            {
                this.Binding.UpdateSourceTrigger = value;
            }
        }

        [DefaultValue(false)]
        public bool BindingValidatesOnDataErrors
        {
            get
            {
                return this.Binding.ValidatesOnDataErrors;
            }
            set
            {
                this.Binding.ValidatesOnDataErrors = value;
            }
        }

        [DefaultValue(false)]
        public bool BindingValidatesOnExceptions
        {
            get
            {
                return this.Binding.ValidatesOnExceptions;
            }
            set
            {
                this.Binding.ValidatesOnExceptions = value;
            }
        }

        [DefaultValue(false)]
        public Collection<ValidationRule> BindingValidationRules
        {
            get
            {
                return this.Binding.ValidationRules;
            }
        }

        [DefaultValue((string) null)]
        public string BindingXPath
        {
            get
            {
                return this.Binding.XPath;
            }
            set
            {
                this.Binding.XPath = value;
            }
        }

        [DefaultValue(false)]
        public bool BindsDirectlyToSource
        {
            get
            {
                return this.Binding.BindsDirectlyToSource;
            }
            set
            {
                this.Binding.BindsDirectlyToSource = value;
            }
        }

        private bool Boolean_0
        {
            get
            {
                if (this.binding_0 == null)
                {
                    return false;
                }
                if (((this.binding_0.Source == null) && (this.binding_0.RelativeSource == null)) && ((this.binding_0.ElementName == null) && (this.binding_0.XPath == null)))
                {
                    return (this.binding_0.Path > null);
                }
                return true;
            }
        }

        private bool Boolean_1
        {
            get
            {
                return (this.collection_0.Count > 0);
            }
        }

        private bool Boolean_2
        {
            get
            {
                return (base.TargetPropertyType == typeof(Collection<ResxExtension1>));
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Collection<ResxExtension1> Children
        {
            get
            {
                return this.collection_0;
            }
        }

        public string DefaultValue
        {
            get
            {
                return this.string_3;
            }
            set
            {
                this.string_3 = value;
            }
        }

        public string Key
        {
            get
            {
                return this.string_2;
            }
            set
            {
                this.string_2 = value;
            }
        }

        public static MarkupExtensionManager1 MarkupManager
        {
            get
            {
                return markupExtensionManager1_0;
            }
        }

        public string ResxName
        {
            get
            {
                string str = this.string_0;
                if (!string.IsNullOrEmpty(str))
                {
                    return str;
                }
                if (this.string_1 == null)
                {
                    WeakReference reference = base.TargetObjects.Find(Class225.<>9__15_0 ?? (Class225.<>9__15_0 = new Predicate<WeakReference>(Class225.<>9.method_0)));
                    if ((reference != null) && (reference.Target is DependencyObject))
                    {
                        this.string_1 = (reference.Target as DependencyObject).GetValue(DefaultResxNameProperty) as string;
                    }
                }
                return this.string_1;
            }
            set
            {
                this.string_0 = value;
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class225
        {
            public static readonly ResxExtension1.Class225 <>9 = new ResxExtension1.Class225();
            public static Predicate<WeakReference> <>9__15_0;

            internal bool method_0(WeakReference weakReference_0)
            {
                return weakReference_0.IsAlive;
            }
        }
    }
}

