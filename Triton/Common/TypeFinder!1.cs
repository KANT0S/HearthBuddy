namespace Triton.Common
{
    using log4net;
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class TypeFinder<T> : ObservableCollection<T>
    {
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        private static readonly ILog ilog_0;
        [CompilerGenerated]
        private ObservableCollection<System.Type> observableCollection_0;
        [CompilerGenerated]
        private System.Type type_0;

        static TypeFinder()
        {
            TypeFinder<T>.ilog_0 = LogManager.GetLogger(typeof(TypeFinder<T>));
        }

        public TypeFinder(bool includeGacAssemblies, bool createInstances = true)
        {
            this.Type = typeof(T);
            this.IncludeGacAssemblies = includeGacAssemblies;
            this.CreateInstances = createInstances;
            this.InstanceTypes = new ObservableCollection<System.Type>();
            this.Refresh();
            AppDomain.CurrentDomain.AssemblyLoad += new AssemblyLoadEventHandler(this.method_1);
        }

        private void method_0(Assembly assembly_0)
        {
            if (this.IncludeGacAssemblies || !assembly_0.GlobalAssemblyCache)
            {
                System.Type[] types = assembly_0.GetTypes();
                for (int i = 0; i < types.Length; i++)
                {
                    Class232<T> class2 = new Class232<T> {
                        type_0 = types[i]
                    };
                    if ((class2.type_0.IsClass && !this.Any<T>(new Func<T, bool>(class2.method_0))) && !class2.type_0.GetCustomAttributes(typeof(TypeFinderIgnoredAttribute)).Any<Attribute>())
                    {
                        if (this.Type.IsInterface)
                        {
                            if (class2.type_0.GetInterfaces().Any<System.Type>(new Func<System.Type, bool>(this.method_2)))
                            {
                                TypeFinder<T>.ilog_0.Debug("Type " + class2.type_0.Name + " implements interface " + this.Type.Name);
                                try
                                {
                                    this.InstanceTypes.Add(class2.type_0);
                                    if (this.CreateInstances)
                                    {
                                        base.Add((T) Activator.CreateInstance(class2.type_0));
                                    }
                                }
                                catch (MissingMethodException exception)
                                {
                                    TypeFinder<T>.ilog_0.Error("Could not instantiate class " + class2.type_0 + ". It does not have a public, parameterless constructor.");
                                    TypeFinder<T>.ilog_0.Error(exception);
                                }
                                catch (Exception exception2)
                                {
                                    TypeFinder<T>.ilog_0.Error("Exception instantiating type " + class2.type_0);
                                    TypeFinder<T>.ilog_0.Error(exception2);
                                }
                            }
                        }
                        else if (class2.type_0.IsSubclassOf(this.Type))
                        {
                            TypeFinder<T>.ilog_0.Debug("Type " + class2.type_0.Name + " inherits class " + this.Type.Name);
                            try
                            {
                                this.InstanceTypes.Add(class2.type_0);
                                if (this.CreateInstances)
                                {
                                    base.Add((T) Activator.CreateInstance(class2.type_0));
                                }
                            }
                            catch (MissingMethodException exception3)
                            {
                                TypeFinder<T>.ilog_0.Error("Could not instantiate class " + class2.type_0 + ". It does not have a public, parameterless constructor.");
                                TypeFinder<T>.ilog_0.Error(exception3);
                            }
                            catch (Exception exception4)
                            {
                                TypeFinder<T>.ilog_0.Error("Exception instantiating type " + class2.type_0);
                                TypeFinder<T>.ilog_0.Error(exception4);
                            }
                        }
                    }
                }
            }
        }

        [CompilerGenerated]
        private void method_1(object sender, AssemblyLoadEventArgs e)
        {
            this.method_0(e.LoadedAssembly);
        }

        [CompilerGenerated]
        private bool method_2(System.Type type_1)
        {
            return (type_1 == this.Type);
        }

        public void Refresh()
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    this.method_0(assembly);
                }
                catch (ReflectionTypeLoadException)
                {
                }
                catch (TypeLoadException)
                {
                }
            }
        }

        public bool CreateInstances
        {
            [CompilerGenerated]
            get
            {
                return this.bool_1;
            }
            [CompilerGenerated]
            set
            {
                this.bool_1 = value;
            }
        }

        public bool IncludeGacAssemblies
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            set
            {
                this.bool_0 = value;
            }
        }

        public ObservableCollection<System.Type> InstanceTypes
        {
            [CompilerGenerated]
            get
            {
                return this.observableCollection_0;
            }
            [CompilerGenerated]
            set
            {
                this.observableCollection_0 = value;
            }
        }

        public System.Type Type
        {
            [CompilerGenerated]
            get
            {
                return this.type_0;
            }
            [CompilerGenerated]
            private set
            {
                this.type_0 = value;
            }
        }

        [CompilerGenerated]
        private sealed class Class232
        {
            public Type type_0;

            internal bool method_0(T gparam_0)
            {
                return (gparam_0.GetType() == this.type_0);
            }
        }
    }
}

