namespace Triton.Bot
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Triton.Common;
    using Triton.Game;

    public static class RoutineManager
    {
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private static IRoutine iroutine_0;
        [CompilerGenerated]
        private static List<IRoutine> list_0;

        [field: CompilerGenerated]
        public static  event EventHandler<RoutineChangedEventArgs> OnRoutineChanged;

        [field: CompilerGenerated]
        public static  event RoutineEvent PostStart;

        [field: CompilerGenerated]
        public static  event RoutineEvent PostStop;

        [field: CompilerGenerated]
        public static  event RoutineEvent PostTick;

        [field: CompilerGenerated]
        public static  event RoutineEvent PreStart;

        [field: CompilerGenerated]
        public static  event RoutineEvent PreStop;

        [field: CompilerGenerated]
        public static  event RoutineEvent PreTick;

        public static void Deinitialize()
        {
            if (Routines != null)
            {
                foreach (IRoutine routine in Routines)
                {
                    try
                    {
                        routine.Deinitialize();
                    }
                    catch (Exception exception)
                    {
                        ilog_0.ErrorFormat("[RoutineManager] An exception occured in {0}'s Deinitialize function. {1}", routine.Name, exception);
                    }
                }
                Routines.Clear();
            }
        }

        public static bool Load()
        {
            try
            {
                string routinesPath = RoutinesPath;
                if (Routines != null)
                {
                    ilog_0.ErrorFormat("[Load] This function can only be called once.", Array.Empty<object>());
                    return false;
                }
                if (!Directory.Exists(routinesPath))
                {
                    Directory.CreateDirectory(routinesPath);
                }
                Routines = new List<IRoutine>();
                foreach (IRoutine routine in new AssemblyLoader<IRoutine>(routinesPath, false).Instances.AsReadOnly())
                {
                    try
                    {
                        Utility.smethod_0(routine);
                        routine.Initialize();
                        Routines.Add(routine);
                    }
                    catch (Exception exception)
                    {
                        ilog_0.Debug("[Load] Exception thrown when initializing " + routine.Name + ". Routine will not be loaded.", exception);
                        Utility.smethod_1(routine);
                        routine.Deinitialize();
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

        private static void smethod_0(IRoutine iroutine_1, RoutineEvent routineEvent_6)
        {
            if (routineEvent_6 != null)
            {
                try
                {
                    routineEvent_6(iroutine_1);
                }
                catch (Exception exception)
                {
                    ilog_0.Error("[Invoke] Error during execution:", exception);
                }
            }
        }

        public static void Start()
        {
            Start(CurrentRoutine);
        }

        public static void Start(IRoutine routine)
        {
            smethod_0(routine, routineEvent_0);
            try
            {
                routine.Start();
            }
            catch (Exception exception)
            {
                ilog_0.Error("Exception during routine Start.", exception);
            }
            smethod_0(routine, routineEvent_1);
        }

        public static void Stop()
        {
            Stop(CurrentRoutine);
        }

        public static void Stop(IRoutine routine)
        {
            smethod_0(routine, routineEvent_4);
            try
            {
                routine.Stop();
            }
            catch (Exception exception)
            {
                ilog_0.Error("Exception during routine Stop.", exception);
            }
            smethod_0(routine, routineEvent_5);
        }

        public static void Tick()
        {
            Tick(CurrentRoutine);
        }

        public static void Tick(IRoutine routine)
        {
            smethod_0(routine, routineEvent_2);
            try
            {
                routine.Tick();
            }
            catch (Exception exception)
            {
                ilog_0.Error("Exception during routine Tick.", exception);
            }
            smethod_0(routine, routineEvent_3);
        }

        public static IRoutine CurrentRoutine
        {
            get
            {
                return iroutine_0;
            }
            set
            {
                if (BotManager.IsRunning)
                {
                    throw new InvalidOperationException("The CurrentRoutine cannot change while the bot is running. Please Stop it first.");
                }
                if (value == null)
                {
                    throw new InvalidOperationException("The CurrentRoutine cannot be set to null.");
                }
                if (iroutine_0 != value)
                {
                    IRoutine old = iroutine_0;
                    iroutine_0 = value;
                    object[] args = new object[2];
                    args[1] = new RoutineChangedEventArgs(old, iroutine_0);
                    TritonHs.InvokeEvent(eventHandler_0, args);
                }
            }
        }

        public static List<IRoutine> Routines
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

        public static string RoutinesPath
        {
            get
            {
                return Path.Combine(String_0, "Routines");
            }
        }

        private static string String_0
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            }
        }

        public delegate void RoutineEvent(IRoutine routine);
    }
}

