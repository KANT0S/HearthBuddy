namespace Triton.Bot.Profiles
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using Triton.Bot;

    [ProfileElementName("Function"), XmlRoot("Function")]
    public class FunctionTag : ProfileGroupElement
    {
        private bool bool_0;
        private readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();

        [AsyncStateMachine(typeof(Struct36))]
        public override Task ProfileTagLogic()
        {
            Struct36 struct2;
            struct2.functionTag_0 = this;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct36>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        public override void Reset()
        {
            this.bool_0 = false;
            base.Reset();
        }

        public override string Author
        {
            get
            {
                return "Bossland GmbH";
            }
        }

        public override string Description
        {
            get
            {
                return "";
            }
        }

        public override bool IsFinished
        {
            get
            {
                return this.bool_0;
            }
        }

        public override string Name
        {
            get
            {
                return "Function";
            }
        }

        public override string Version
        {
            get
            {
                return "1.0.0.0";
            }
        }

        [CompilerGenerated]
        private struct Struct36 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            private List<ProfileElement>.Enumerator enumerator_0;
            public FunctionTag functionTag_0;
            public int int_0;
            private TaskAwaiter taskAwaiter_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    if (num != 0)
                    {
                        if ((this.functionTag_0.ReferenceName == null) && (this.functionTag_0.ReferenceTag == null))
                        {
                            this.functionTag_0.ilog_0.Info("Cannot execute a Function tag that has no reference name, or tag set. This tag is only meant for easily referencing profile behavior steps in sequence.");
                            BotManager.Stop();
                            goto Label_0128;
                        }
                        this.enumerator_0 = this.functionTag_0.Children.GetEnumerator();
                    }
                    try
                    {
                        TaskAwaiter awaiter;
                        if (num == 0)
                        {
                            awaiter = this.taskAwaiter_0;
                            this.taskAwaiter_0 = new TaskAwaiter();
                            num = -1;
                            this.int_0 = -1;
                            goto Label_00AE;
                        }
                    Label_007C:
                        if (!this.enumerator_0.MoveNext())
                        {
                            goto Label_00F7;
                        }
                        ProfileElement current = this.enumerator_0.Current;
                        current.Reset();
                        awaiter = current.ProfileTagLogic().GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            goto Label_00C1;
                        }
                    Label_00AE:
                        awaiter.GetResult();
                        awaiter = new TaskAwaiter();
                        goto Label_007C;
                    Label_00C1:
                        num = 0;
                        this.int_0 = 0;
                        this.taskAwaiter_0 = awaiter;
                        this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, FunctionTag.Struct36>(ref awaiter, ref this);
                        return;
                    }
                    finally
                    {
                        if (num < 0)
                        {
                            this.enumerator_0.Dispose();
                        }
                    }
                Label_00F7:
                    this.enumerator_0 = new List<ProfileElement>.Enumerator();
                    this.functionTag_0.bool_0 = true;
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                    return;
                }
            Label_0128:
                this.int_0 = -2;
                this.asyncTaskMethodBuilder_0.SetResult();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
            }
        }
    }
}

