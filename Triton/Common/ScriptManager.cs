namespace Triton.Common
{
    using IronPython;
    using IronPython.Hosting;
    using log4net;
    using Microsoft.Scripting.Hosting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text;
    using Triton.Common.LogUtilities;

    public class ScriptManager
    {
        private readonly AppDomain appDomain_0;
        private ILog ilog_0;
        [CompilerGenerated]
        private InputOutputProxy inputOutputProxy_0;
        private static readonly List<string> list_0;
        private ScriptEngine scriptEngine_0;
        private ScriptScope scriptScope_0;
        private const string string_0 = "import clr\r\nclr.ImportExtensions(System.Linq)\r\n";

        static ScriptManager()
        {
            List<string> list1 = new List<string> { "System", "System.Threading", "System.Diagnostics", "System.Linq", "System.Linq.Expressions", "System.Windows.Media", "System.Text", "System.Collections", "System.Collections.Concurrent", "System.Collections.Generic", "System.Collections.ObjectModel" };
            list_0 = list1;
        }

        public ScriptManager()
        {
            this.appDomain_0 = AppDomain.CurrentDomain;
        }

        public ScriptManager(AppDomain domain)
        {
            this.appDomain_0 = domain;
        }

        private void appDomain_0_AssemblyLoad(object sender, AssemblyLoadEventArgs e)
        {
            this.scriptEngine_0.Runtime.LoadAssembly(e.LoadedAssembly);
        }

        public void Deinitialize()
        {
            this.appDomain_0.AssemblyLoad -= new AssemblyLoadEventHandler(this.appDomain_0_AssemblyLoad);
            this.scriptEngine_0 = null;
            this.scriptScope_0 = null;
        }

        public string FormatSyntaxErrorException(Exception ex)
        {
            return this.scriptEngine_0.GetService<ExceptionOperations>(Array.Empty<object>()).FormatException(ex);
        }

        public Action GetStatement(string statement)
        {
            this.scriptScope_0.SetVariable("ioproxy", this.IoProxy);
            this.scriptEngine_0.CreateScriptSourceFromString(statement.Trim()).Execute(this.scriptScope_0);
            return this.scriptScope_0.GetVariable<Action>("Execute");
        }

        public void Initialize(IEnumerable<Type> shortcutsDefinitions, IEnumerable<string> customNamespaces)
        {
            this.Initialize(Logger.GetLoggerInstanceForType(), shortcutsDefinitions, customNamespaces);
        }

        public void Initialize(ILog log, IEnumerable<Type> shortcutsDefinitions, IEnumerable<string> customNamespaces)
        {
            this.ilog_0 = log;
            if (this.IoProxy == null)
            {
                this.IoProxy = new InputOutputProxy(this.ilog_0);
            }
            try
            {
                Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
                dictionary1.Add("DivisionOptions", PythonDivisionOptions.New);
                Dictionary<string, object> options = dictionary1;
                this.scriptEngine_0 = Python.CreateEngine(options);
                foreach (Assembly assembly in this.appDomain_0.GetAssemblies())
                {
                    this.scriptEngine_0.Runtime.LoadAssembly(assembly);
                }
                this.scriptScope_0 = this.scriptEngine_0.CreateScope();
                this.method_0(customNamespaces);
                if (shortcutsDefinitions != null)
                {
                    using (IEnumerator<Type> enumerator = shortcutsDefinitions.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            foreach (MethodInfo info in enumerator.Current.GetMethods(BindingFlags.Public | BindingFlags.Static))
                            {
                                if (!info.Name.ToLowerInvariant().Contains("init"))
                                {
                                    Delegate delegate2 = smethod_0(info);
                                    this.scriptScope_0.SetVariable(info.Name, delegate2);
                                }
                            }
                        }
                    }
                }
                this.appDomain_0.AssemblyLoad += new AssemblyLoadEventHandler(this.appDomain_0_AssemblyLoad);
            }
            catch (Exception exception)
            {
                this.ilog_0.Error("Exception while loading Python runtime. Exception follows", exception);
            }
        }

        private void method_0(IEnumerable<string> ienumerable_0)
        {
            List<string> list = new List<string>(list_0);
            list.AddRange(ienumerable_0.Where<string>(Class230.<>9__17_0 ?? (Class230.<>9__17_0 = new Func<string, bool>(Class230.<>9.method_1))));
            StringBuilder builder = new StringBuilder();
            foreach (string str in list)
            {
                builder.AppendLine("import " + str);
            }
            foreach (string str2 in list)
            {
                builder.AppendLine("from " + str2 + " import *");
            }
            builder.AppendLine("import clr\r\nclr.ImportExtensions(System.Linq)\r\n");
            this.scriptEngine_0.Execute(builder.ToString(), this.scriptScope_0);
        }

        private static Delegate smethod_0(MethodInfo methodInfo_0)
        {
            Type[] second = new Type[] { methodInfo_0.ReturnType };
            return Delegate.CreateDelegate(Expression.GetDelegateType(methodInfo_0.GetParameters().Select<ParameterInfo, Type>((Class230.<>9__11_0 ?? (Class230.<>9__11_0 = new Func<ParameterInfo, Type>(Class230.<>9.method_0)))).Concat<Type>(second).ToArray<Type>()), null, methodInfo_0);
        }

        public ScriptEngine Engine
        {
            get
            {
                return this.scriptEngine_0;
            }
        }

        public InputOutputProxy IoProxy
        {
            [CompilerGenerated]
            get
            {
                return this.inputOutputProxy_0;
            }
            [CompilerGenerated]
            set
            {
                this.inputOutputProxy_0 = value;
            }
        }

        public ScriptScope Scope
        {
            get
            {
                return this.scriptScope_0;
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class230
        {
            public static readonly ScriptManager.Class230 <>9 = new ScriptManager.Class230();
            public static Func<ParameterInfo, Type> <>9__11_0;
            public static Func<string, bool> <>9__17_0;

            internal Type method_0(ParameterInfo parameterInfo_0)
            {
                return parameterInfo_0.ParameterType;
            }

            internal bool method_1(string string_0)
            {
                return !string.IsNullOrEmpty(string_0);
            }
        }

        public class InputOutputProxy
        {
            private readonly ILog ilog_0;

            public InputOutputProxy()
            {
                this.ilog_0 = Logger.GetLoggerInstanceForType();
            }

            public InputOutputProxy(ILog log)
            {
                this.ilog_0 = log;
            }

            public void write(string s)
            {
                this.ilog_0.DebugFormat("{0}", s);
            }
        }
    }
}

