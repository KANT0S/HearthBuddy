namespace Triton.Bot.Profiles
{
    using Microsoft.Scripting.Hosting;
    using System;
    using System.Collections.Generic;
    using Triton.Common;

    public static class ProfileScripting
    {
        internal static ScriptManager scriptManager_0;

        public static void Deinitialize()
        {
            if (scriptManager_0 != null)
            {
                scriptManager_0.Deinitialize();
                scriptManager_0 = null;
            }
        }

        public static Func<bool> GetCondition(string expression)
        {
            string str = string.Format("\r\nimport sys\r\nsys.stdout=ioproxy\r\n\r\ndef Execute():\r\n    return bool({0})", expression);
            ScriptScope scope = scriptManager_0.Scope;
            scope.SetVariable("ioproxy", scriptManager_0.IoProxy);
            scriptManager_0.Engine.CreateScriptSourceFromString(str).Execute(scope);
            return scope.GetVariable<Func<bool>>("Execute");
        }

        public static Func<T> GetCondition<T>(string expression)
        {
            string str = string.Format("\r\nimport sys\r\nsys.stdout=ioproxy\r\n\r\ndef Execute():\r\n    return bool({0})", expression);
            ScriptScope scope = scriptManager_0.Scope;
            scope.SetVariable("ioproxy", scriptManager_0.IoProxy);
            scriptManager_0.Engine.CreateScriptSourceFromString(str).Execute(scope);
            return scope.GetVariable<Func<T>>("Execute");
        }

        public static Action GetPythonStatement(string statement)
        {
            return scriptManager_0.GetStatement(statement);
        }

        public static void Initialize(IEnumerable<Type> shortcutsDefinitions, IEnumerable<string> customNamespaces)
        {
            Deinitialize();
            scriptManager_0 = new ScriptManager();
            scriptManager_0.Initialize(shortcutsDefinitions, customNamespaces);
        }
    }
}

