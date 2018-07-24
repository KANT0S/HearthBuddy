namespace Triton.Bot
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Triton.Common;
    using Triton.Game;
    using Triton.Game.Mapping;

    public class GameEventManager : IRunnable, IResetable
    {
        private static GameEventManager gameEventManager_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private int int_0 = -1;
        private int int_1;
        private PresenceStatus presenceStatus_0 = PresenceStatus.UNKNOWN;
        private readonly Stopwatch stopwatch_0 = new Stopwatch();
        private const string string_0 = "77885";

        [field: CompilerGenerated]
        public static  event EventHandler<ArenaRewardsEventArgs> ArenaRewards;

        [field: CompilerGenerated]
        public static  event EventHandler<CustomDecksCachedEventArgs> CustomDecksCached;

        [field: CompilerGenerated]
        public static  event EventHandler<FatalErrorEventArgs> FatalError;

        [field: CompilerGenerated]
        public static  event EventHandler<GameOverEventArgs> GameOver;

        [field: CompilerGenerated]
        public static  event EventHandler<MulliganConfirmEventArgs> MulliganConfirm;

        [field: CompilerGenerated]
        public static  event EventHandler<NewGameEventArgs> NewGame;

        [field: CompilerGenerated]
        public static  event EventHandler<QuestUpdateEventArgs> QuestUpdate;

        [field: CompilerGenerated]
        public static  event EventHandler<StartingNewGameEventArgs> StartingNewGame;

        internal void method_0(PresenceStatus presenceStatus_1)
        {
            this.presenceStatus_0 = presenceStatus_1;
        }

        internal void method_1()
        {
            object[] args = new object[] { this, new MulliganConfirmEventArgs() };
            TritonHs.InvokeEvent(eventHandler_4, args);
        }

        internal void method_2()
        {
            object[] args = new object[] { this, new QuestUpdateEventArgs() };
            TritonHs.InvokeEvent(eventHandler_1, args);
        }

        internal void method_3(List<RewardData> list_0)
        {
            object[] args = new object[] { this, new ArenaRewardsEventArgs(list_0) };
            TritonHs.InvokeEvent(eventHandler_2, args);
        }

        internal void method_4(GameOverFlag gameOverFlag_0, bool bool_0)
        {
            if (this.int_0 != this.int_1)
            {
                this.int_0 = this.int_1;
                object[] args = new object[] { this, new GameOverEventArgs(gameOverFlag_0, bool_0) };
                TritonHs.InvokeEvent(eventHandler_3, args);
            }
        }

        internal void method_5()
        {
            object[] args = new object[] { this, new StartingNewGameEventArgs() };
            TritonHs.InvokeEvent(eventHandler_5, args);
        }

        internal void method_6()
        {
            object[] args = new object[] { this, new CustomDecksCachedEventArgs() };
            TritonHs.InvokeEvent(eventHandler_6, args);
        }

        internal void method_7()
        {
            object[] args = new object[] { this, new FatalErrorEventArgs() };
            TritonHs.InvokeEvent(eventHandler_7, args);
        }

        public void Reset()
        {
            this.int_1 = 0;
            this.int_0 = -1;
            this.stopwatch_0.Reset();
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public void Tick()
        {
            using (new PerformanceTimer("NewGame", null))
            {
                bool flag = true;
                Network network = Network.Get();
                if (network != null)
                {
                    GameServerInfo lastGameServerInfo = network.m_lastGameServerInfo;
                    if ((Network.IsConnectedToGameServer() && (lastGameServerInfo != null)) && (this.int_1 != lastGameServerInfo.GameHandle))
                    {
                        this.int_1 = lastGameServerInfo.GameHandle;
                        this.int_0 = -1;
                        this.stopwatch_0.Restart();
                        flag = false;
                        object[] args = new object[] { this, new NewGameEventArgs(this.int_1) };
                        TritonHs.InvokeEvent(eventHandler_0, args);
                    }
                }
                if (flag)
                {
                    this.stopwatch_0.Reset();
                }
            }
        }

        public static GameEventManager Instance
        {
            get
            {
                return (gameEventManager_0 ?? (gameEventManager_0 = new GameEventManager()));
            }
        }

        public PresenceStatus LastGamePresenceStatus
        {
            get
            {
                return this.presenceStatus_0;
            }
        }
    }
}

