namespace Triton.Bot
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Triton.Common;

    public static class PluginManager
    {
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        [CompilerGenerated]
        private static List<IPlugin> list_0;

        [field: CompilerGenerated]
        public static  event PluginEvent PluginDisabled;

        [field: CompilerGenerated]
        public static  event PluginEvent PluginEnabled;

        [field: CompilerGenerated]
        public static  event PluginEvent PostStart;

        [field: CompilerGenerated]
        public static  event PluginEvent PostStop;

        [field: CompilerGenerated]
        public static  event PluginEvent PostTick;

        [field: CompilerGenerated]
        public static  event PluginEvent PreStart;

        [field: CompilerGenerated]
        public static  event PluginEvent PreStop;

        [field: CompilerGenerated]
        public static  event PluginEvent PreTick;

        public static void Deinitialize()
        {
            if (Plugins != null)
            {
                foreach (IPlugin plugin in Plugins)
                {
                    try
                    {
                        plugin.Deinitialize();
                    }
                    catch (Exception exception)
                    {
                        ilog_0.ErrorFormat("[PluginManager] An exception occured in {0}'s Deinitialize function. {1}", plugin.Name, exception);
                    }
                }
                Plugins.Clear();
            }
        }

        public static void Disable(IPlugin plugin)
        {
            try
            {
                if (BotManager.IsRunning)
                {
                    throw new InvalidOperationException("Cannot Disable plugins while the bot is running.");
                }
                if (plugin.IsEnabled)
                {
                    plugin.Disable();
                    smethod_3(plugin, pluginEvent_7);
                }
            }
            catch (Exception exception)
            {
                ilog_0.Error("Exception during plugin Disable.", exception);
            }
        }

        public static void Enable(IPlugin plugin)
        {
            if (BotManager.IsRunning)
            {
                throw new InvalidOperationException("Cannot Enable plugins while the bot is running.");
            }
            try
            {
                if (!plugin.IsEnabled)
                {
                    plugin.Enable();
                    smethod_3(plugin, pluginEvent_6);
                }
            }
            catch (Exception exception)
            {
                ilog_0.Error("Exception during plugin Enable.", exception);
            }
        }

        public static bool Load()
        {
            try
            {
                string pluginsPath = PluginsPath;
                if (BotManager.IsRunning)
                {
                    throw new InvalidOperationException("Cannot Load plugins while the bot is running.");
                }
                if (Plugins != null)
                {
                    ilog_0.ErrorFormat("[Load] This function can only be called once.", Array.Empty<object>());
                    return false;
                }
                if (!Directory.Exists(pluginsPath))
                {
                    Directory.CreateDirectory(pluginsPath);
                }
                Plugins = new List<IPlugin>();
                foreach (IPlugin plugin in new AssemblyLoader<IPlugin>(pluginsPath, false).Instances.AsReadOnly())
                {
                    try
                    {
                        Utility.smethod_0(plugin);
                        plugin.Initialize();
                        Plugins.Add(plugin);
                    }
                    catch (Exception exception)
                    {
                        ilog_0.Debug("[Load] Exception thrown when initializing " + plugin.Name + ". Plugin will not be loaded.", exception);
                        Utility.smethod_1(plugin);
                        plugin.Deinitialize();
                    }
                }
                return true;
            }
            catch (Exception exception2)
            {
                ilog_0.ErrorFormat("[Load] An exception occurred: {0}.", exception2);
            }
            return false;
        }

        private static void smethod_0(IPlugin iplugin_0)
        {
            smethod_3(iplugin_0, pluginEvent_0);
            try
            {
                iplugin_0.Start();
            }
            catch (Exception exception)
            {
                ilog_0.Error("Exception during plugin Start.", exception);
            }
            smethod_3(iplugin_0, pluginEvent_1);
        }

        private static void smethod_1(IPlugin iplugin_0)
        {
            smethod_3(iplugin_0, pluginEvent_2);
            try
            {
                iplugin_0.Tick();
            }
            catch (Exception exception)
            {
                ilog_0.Error("Exception during plugin Tick.", exception);
            }
            smethod_3(iplugin_0, pluginEvent_3);
        }

        private static void smethod_2(IPlugin iplugin_0)
        {
            smethod_3(iplugin_0, pluginEvent_4);
            try
            {
                iplugin_0.Stop();
            }
            catch (Exception exception)
            {
                ilog_0.Error("Exception during plugin Stop.", exception);
            }
            smethod_3(iplugin_0, pluginEvent_5);
        }

        private static void smethod_3(IPlugin iplugin_0, PluginEvent pluginEvent_8)
        {
            if (pluginEvent_8 != null)
            {
                try
                {
                    pluginEvent_8(iplugin_0);
                }
                catch (Exception exception)
                {
                    ilog_0.Error("[Invoke] Error during execution:", exception);
                }
            }
        }

        public static void Start()
        {
            foreach (IPlugin plugin in Plugins)
            {
                if (plugin.IsEnabled)
                {
                    smethod_0(plugin);
                }
            }
        }

        public static void Stop()
        {
            foreach (IPlugin plugin in Plugins)
            {
                if (plugin.IsEnabled)
                {
                    smethod_2(plugin);
                }
            }
        }

        public static void Tick()
        {
            foreach (IPlugin plugin in Plugins)
            {
                if (plugin.IsEnabled)
                {
                    smethod_1(plugin);
                }
            }
        }

        public static IEnumerable<IPlugin> DisabledPlugins
        {
            get
            {
                return Plugins.Where<IPlugin>((Class205.<>9__47_0 ?? (Class205.<>9__47_0 = new Func<IPlugin, bool>(Class205.<>9.method_1))));
            }
        }

        public static IEnumerable<IPlugin> EnabledPlugins
        {
            get
            {
                return Plugins.Where<IPlugin>((Class205.<>9__45_0 ?? (Class205.<>9__45_0 = new Func<IPlugin, bool>(Class205.<>9.method_0))));
            }
        }

        public static List<IPlugin> Plugins
        {
            [CompilerGenerated]
            get
            {
                return list_0;
            }
            [CompilerGenerated]
            private set
            {
                list_0 = value;
            }
        }

        public static string PluginsPath
        {
            get
            {
                return Path.Combine(String_0, "Plugins");
            }
        }

        private static string String_0
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class205
        {
            public static readonly PluginManager.Class205 <>9 = new PluginManager.Class205();
            public static Func<IPlugin, bool> <>9__45_0;
            public static Func<IPlugin, bool> <>9__47_0;

            internal bool method_0(IPlugin iplugin_0)
            {
                return iplugin_0.IsEnabled;
            }

            internal bool method_1(IPlugin iplugin_0)
            {
                return !iplugin_0.IsEnabled;
            }
        }

        public delegate void PluginEvent(IPlugin plugin);
    }
}

