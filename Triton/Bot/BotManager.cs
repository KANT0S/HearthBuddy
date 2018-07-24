namespace Triton.Bot
{
    using GreyMagic;
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Triton.Common;
    using Triton.Game;

    public static class BotManager
    {
        private static readonly AutoResetEvent autoResetEvent_0 = new AutoResetEvent(false);
        private static bool bool_0;
        private static bool bool_1;
        private static bool bool_2;
        private static bool bool_3;
        private static IBot ibot_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private static int int_0;
        private static int int_1;
        [CompilerGenerated]
        private static List<IBot> list_0;
        private static readonly object object_0 = new object();
        [CompilerGenerated]
        private static Thread thread_0;

        [field: CompilerGenerated]
        public static  event EventHandler<BotChangedEventArgs> OnBotChanged;

        [field: CompilerGenerated]
        public static  event EventHandler<ClientFrozenEventArgs> OnClientFrozen;

        [field: CompilerGenerated]
        public static  event BotEvent PostStart;

        [field: CompilerGenerated]
        public static  event BotEvent PostStop;

        [field: CompilerGenerated]
        public static  event BotEvent PostTick;

        [field: CompilerGenerated]
        public static  event BotEvent PreStart;

        [field: CompilerGenerated]
        public static  event BotEvent PreStop;

        [field: CompilerGenerated]
        public static  event BotEvent PreTick;

        static BotManager()
        {
            MsBetweenTicks = 15;
        }

        public static void Deinitialize()
        {
            if (Bots != null)
            {
                foreach (IBot bot in Bots)
                {
                    try
                    {
                        bot.Deinitialize();
                    }
                    catch (Exception exception)
                    {
                        ilog_0.ErrorFormat("[BotManager] An exception occured in {0}'s Deinitialize function. {1}", bot.Name, exception);
                    }
                }
                Bots.Clear();
            }
        }

        public static bool Load()
        {
            try
            {
                string botsPath = BotsPath;
                object obj2 = object_0;
                lock (obj2)
                {
                    if (Bots != null)
                    {
                        ilog_0.ErrorFormat("[Load] This function can only be called once.", Array.Empty<object>());
                        return false;
                    }
                    if (!Directory.Exists(botsPath))
                    {
                        Directory.CreateDirectory(botsPath);
                    }
                    Bots = new List<IBot>();
                    foreach (IBot bot in new AssemblyLoader<IBot>(botsPath, false).Instances.AsReadOnly())
                    {
                        try
                        {
                            Utility.smethod_0(bot);
                            bot.Initialize();
                            Bots.Add(bot);
                        }
                        catch (Exception exception)
                        {
                            ilog_0.Debug("[Load] Exception thrown when initializing " + bot.Name + ". Bot  will not be loaded.", exception);
                            Utility.smethod_1(bot);
                            bot.Deinitialize();
                        }
                    }
                    return true;
                }
            }
            catch (Exception exception2)
            {
                ilog_0.ErrorFormat("[Load] An exception occurred: {0}.", exception2);
            }
            return false;
        }

        internal static void smethod_0(IBot ibot_1)
        {
            object obj2;
            try
            {
                obj2 = object_0;
                lock (obj2)
                {
                    if (bool_0)
                    {
                        return;
                    }
                    bool_0 = true;
                }
                smethod_3(ibot_1, botEvent_0);
                try
                {
                    using (TritonHs.AcquireFrame())
                    {
                        using (TritonHs.Memory.TemporaryCacheState(false))
                        {
                            TritonHs.Memory.ClearCache();
                            ibot_1.Start();
                        }
                    }
                }
                catch (Exception exception)
                {
                    ilog_0.Error("[Start] Exception during execution:", exception);
                    throw;
                }
                smethod_3(ibot_1, botEvent_1);
            }
            finally
            {
                obj2 = object_0;
                lock (obj2)
                {
                    bool_0 = false;
                }
            }
        }

        internal static void smethod_1(IBot ibot_1)
        {
            object obj2;
            try
            {
                obj2 = object_0;
                lock (obj2)
                {
                    if (bool_1)
                    {
                        return;
                    }
                    bool_1 = true;
                }
                smethod_3(ibot_1, botEvent_2);
                try
                {
                    using (TritonHs.AcquireFrame())
                    {
                        using (TritonHs.Memory.TemporaryCacheState(false))
                        {
                            TritonHs.Memory.ClearCache();
                            ibot_1.Tick();
                            TritonHs.smethod_2(false);
                        }
                    }
                }
                catch (Exception exception)
                {
                    ilog_0.Error("[Tick] Exception during execution:", exception);
                    throw;
                }
                smethod_3(ibot_1, botEvent_3);
            }
            finally
            {
                obj2 = object_0;
                lock (obj2)
                {
                    bool_1 = false;
                }
            }
        }

        internal static void smethod_2(IBot ibot_1)
        {
            object obj2;
            try
            {
                obj2 = object_0;
                lock (obj2)
                {
                    if (bool_2)
                    {
                        return;
                    }
                    bool_2 = true;
                }
                smethod_3(ibot_1, botEvent_4);
                try
                {
                    using (TritonHs.AcquireFrame())
                    {
                        using (TritonHs.Memory.TemporaryCacheState(false))
                        {
                            TritonHs.Memory.ClearCache();
                            ibot_1.Stop();
                        }
                    }
                }
                catch (Exception exception)
                {
                    ilog_0.Error("[Stop] Exception during execution:", exception);
                    throw;
                }
                smethod_3(ibot_1, botEvent_5);
            }
            finally
            {
                obj2 = object_0;
                lock (obj2)
                {
                    bool_2 = false;
                }
            }
        }

        private static void smethod_3(IBot ibot_1, BotEvent botEvent_6)
        {
            if (botEvent_6 != null)
            {
                try
                {
                    using (TritonHs.AcquireFrame())
                    {
                        using (TritonHs.Memory.TemporaryCacheState(false))
                        {
                            botEvent_6(ibot_1);
                        }
                    }
                }
                catch (Exception exception)
                {
                    ilog_0.Error("[Invoke] Error during execution:", exception);
                    throw;
                }
            }
        }

        private static void smethod_4()
        {
            object obj2 = object_0;
            lock (obj2)
            {
                Thread.Sleep(1);
            }
            TritonHs.Memory.DisableCache();
            TritonHs.Memory.ClearCache();
            TritonHs.Memory.Executor.FrameDropWaitTime = 0x3a98;
            TritonHs.Memory.Executor.ExecuteWaitTime = 0x3a98;
            try
            {
                TritonHs.smethod_2(true);
            }
            catch
            {
            }
            try
            {
                smethod_0(CurrentBot);
                goto Label_00DF;
            }
            catch
            {
                autoResetEvent_0.Set();
                goto Label_00DF;
            }
        Label_0084:;
            try
            {
                if (MsBeforeNextTick != 0)
                {
                    Thread.Sleep(MsBeforeNextTick);
                    MsBeforeNextTick = 0;
                }
                smethod_1(CurrentBot);
                if (MsBetweenTicks != 0)
                {
                    Thread.Sleep(MsBetweenTicks);
                }
                bool_3 = false;
            }
            catch (InjectionDesyncException)
            {
                ilog_0.DebugFormat("[BotThreadFunction] An InjectionDesyncException was detected.", Array.Empty<object>());
                bool_3 = true;
                goto Label_00EC;
            }
            catch
            {
            }
        Label_00DF:
            if (!autoResetEvent_0.WaitOne(0))
            {
                goto Label_0084;
            }
        Label_00EC:;
            try
            {
                smethod_2(CurrentBot);
            }
            catch
            {
            }
            BotThread = null;
            if (bool_3)
            {
                object[] args = new object[2];
                args[1] = new ClientFrozenEventArgs();
                TritonHs.InvokeEvent(eventHandler_1, args);
            }
            else
            {
                try
                {
                    TritonHs.smethod_2(true);
                }
                catch
                {
                }
            }
        }

        public static bool Start()
        {
            object obj2 = object_0;
            lock (obj2)
            {
                if (IsRunning)
                {
                    ilog_0.ErrorFormat("[Start] The BotThread is already running. Please use BotManager.Stop first.", Array.Empty<object>());
                    return false;
                }
                if (!TritonHs.Initialized)
                {
                    ilog_0.ErrorFormat("[Start] TritonHs is not initialized yet.", Array.Empty<object>());
                    return false;
                }
                if (CurrentBot == null)
                {
                    ilog_0.ErrorFormat("[Start] There is no bot to run. Please assign a bot first.", Array.Empty<object>());
                    return false;
                }
                ilog_0.InfoFormat("[Start] Now creating the BotThread.", Array.Empty<object>());
                bool_3 = false;
                BotThread = new Thread(new ThreadStart(BotManager.smethod_4));
                BotThread.Start();
                return true;
            }
        }

        public static bool Stop()
        {
            object obj2 = object_0;
            lock (obj2)
            {
                if (BotThread == null)
                {
                    ilog_0.ErrorFormat("[Stop] The BotThread is not running. Please use BotManager.Start first.", Array.Empty<object>());
                    return false;
                }
                ilog_0.InfoFormat("[Stop] Now requesting the BotThread to stop.", Array.Empty<object>());
                autoResetEvent_0.Set();
                return true;
            }
        }

        public static List<IBot> Bots
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

        public static string BotsPath
        {
            get
            {
                return Path.Combine(String_0, "Bots");
            }
        }

        public static Thread BotThread
        {
            [CompilerGenerated]
            get
            {
                return thread_0;
            }
            [CompilerGenerated]
            private set
            {
                thread_0 = value;
            }
        }

        public static bool ClientFrozen
        {
            get
            {
                return bool_3;
            }
        }

        public static IBot CurrentBot
        {
            get
            {
                return ibot_0;
            }
            set
            {
                object obj2 = object_0;
                lock (obj2)
                {
                    if (IsRunning)
                    {
                        throw new InvalidOperationException("The CurrentBot cannot change while the bot is running. Please Stop it first.");
                    }
                    if (value == null)
                    {
                        throw new InvalidOperationException("The CurrentBot cannot be set to null.");
                    }
                    if (ibot_0 != value)
                    {
                        IBot old = ibot_0;
                        ibot_0 = value;
                        object[] args = new object[2];
                        args[1] = new BotChangedEventArgs(old, ibot_0);
                        TritonHs.InvokeEvent(eventHandler_0, args);
                    }
                }
            }
        }

        public static bool IsRunning
        {
            get
            {
                return (BotThread > null);
            }
        }

        public static int MsBeforeNextTick
        {
            get
            {
                return int_1;
            }
            set
            {
                int_1 = value;
                if (int_1 < 0)
                {
                    int_1 = 0;
                }
            }
        }

        public static int MsBetweenTicks
        {
            get
            {
                return int_0;
            }
            set
            {
                int_0 = value;
                if (int_0 < 0)
                {
                    int_0 = 0;
                }
                ilog_0.InfoFormat("[BotManager] MsBetweenTicks = {0}", int_0);
            }
        }

        private static string String_0
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            }
        }

        public delegate void BotEvent(IBot bot);
    }
}

