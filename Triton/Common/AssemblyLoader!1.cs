namespace Triton.Common
{
    using log4net;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Triton.Common.LogUtilities;

    public class AssemblyLoader<T>
    {
        private readonly bool bool_0;
        private readonly FileSystemWatcher fileSystemWatcher_0;
        private readonly ILog ilog_0;
        [CompilerGenerated]
        private List<T> list_0;
        private readonly string string_0;

        [field: CompilerGenerated]
        public event EventHandler Reloaded;

        public AssemblyLoader(string directory, bool detectFileChanges)
        {
            this.ilog_0 = Logger.GetLoggerInstanceForType();
            this.fileSystemWatcher_0 = new FileSystemWatcher();
            this.Instances = new List<T>();
            this.string_0 = directory;
            this.bool_0 = detectFileChanges;
            if (this.bool_0)
            {
                this.fileSystemWatcher_0.Path = directory;
                this.fileSystemWatcher_0.Filter = "*.cs";
                this.fileSystemWatcher_0.IncludeSubdirectories = true;
                this.fileSystemWatcher_0.EnableRaisingEvents = true;
                this.fileSystemWatcher_0.Changed += new FileSystemEventHandler(this.method_0);
                this.fileSystemWatcher_0.Created += new FileSystemEventHandler(this.method_1);
                this.fileSystemWatcher_0.Deleted += new FileSystemEventHandler(this.method_2);
            }
            this.Reload("Initializing");
        }

        [CompilerGenerated]
        private void method_0(object sender, FileSystemEventArgs e)
        {
            this.Reload(e.ChangeType.ToString());
        }

        [CompilerGenerated]
        private void method_1(object sender, FileSystemEventArgs e)
        {
            this.Reload(e.ChangeType.ToString());
        }

        [CompilerGenerated]
        private void method_2(object sender, FileSystemEventArgs e)
        {
            this.Reload(e.ChangeType.ToString());
        }

        public void Reload(string reason)
        {
            this.ilog_0.Debug(string.Format("Reloading AssemblyLoader<{0}> - {1}", typeof(T), reason));
            this.Instances = new List<T>();
            if (!Directory.Exists(this.string_0))
            {
                this.ilog_0.Error(string.Format("Could not Reload assemblies because the path \"{0}\" does not exist.", this.string_0));
            }
            else
            {
                string[] directories = Directory.GetDirectories(this.string_0);
                int index = 0;
                while (true)
                {
                    if (index >= directories.Length)
                    {
                        break;
                    }
                    string path = directories[index];
                    try
                    {
                        Triton.Common.CodeCompiler compiler = new Triton.Common.CodeCompiler(path);
                        CompilerResults results = compiler.Compile();
                        if (results != null)
                        {
                            if (results.Errors.HasErrors)
                            {
                                foreach (object obj2 in results.Errors)
                                {
                                    this.ilog_0.Error("Compiler Error: " + obj2.ToString());
                                }
                            }
                            else
                            {
                                this.Instances.AddRange(new TypeLoader<T>(compiler.CompiledAssembly, null));
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        if (exception is ReflectionTypeLoadException)
                        {
                            foreach (Exception exception2 in (exception as ReflectionTypeLoadException).LoaderExceptions)
                            {
                                this.ilog_0.Error("[Reload] An exception occured.", exception2);
                            }
                        }
                        else
                        {
                            this.ilog_0.Error("[Reload] An exception occured.", exception);
                        }
                    }
                    index++;
                }
                using (List<T>.Enumerator enumerator2 = new TypeLoader<T>(null, null).GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        Class226<T> class2 = new Class226<T> {
                            gparam_0 = enumerator2.Current
                        };
                        if (!this.Instances.Any<T>(new Func<T, bool>(class2.method_0)))
                        {
                            this.Instances.Add(class2.gparam_0);
                        }
                    }
                }
                if (this.eventHandler_0 != null)
                {
                    this.eventHandler_0(this, null);
                }
            }
        }

        public List<T> Instances
        {
            [CompilerGenerated]
            get
            {
                return this.list_0;
            }
            [CompilerGenerated]
            private set
            {
                this.list_0 = value;
            }
        }

        [CompilerGenerated]
        private sealed class Class226
        {
            public T gparam_0;

            internal bool method_0(T gparam_1)
            {
                return (gparam_1.GetType().FullName == this.gparam_0.GetType().FullName);
            }
        }
    }
}

