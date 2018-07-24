namespace Triton.Bot.Profiles
{
    using Buddy.Coroutines;
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [ProfileElementName("If"), XmlRoot("If")]
    public class IfTag : ConditionalProfileGroupElement
    {
        private bool bool_0;
        private readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();

        [AsyncStateMachine(typeof(x!Z"egif-#66_XcQ@=D_KGcU!))]
        private Task method_0()
        {
            Struct38 struct2;
            struct2.ifTag_0 = this;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct38>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        [AsyncStateMachine(typeof(Struct37))]
        public override Task ProfileTagLogic()
        {
            Struct37 struct2;
            struct2.ifTag_0 = this;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct37>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        public override void Reset()
        {
            base.Reset();
            this.bool_0 = false;
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
                return "If";
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
        private sealed class Class215
        {
            public ProfileElement profileElement_0;

            internal Task method_0()
            {
                return this.profileElement_0.ProfileTagLogic();
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class216
        {
            public static readonly IfTag.Class216 <>9 = new IfTag.Class216();
            public static Func<ProfileElement, Coroutine> <>9__14_0;

            internal Coroutine method_0(ProfileElement profileElement_0)
            {
                IfTag.Class215 class1 = new IfTag.Class215 {
                    profileElement_0 = profileElement_0
                };
                return new Coroutine(new Func<Task>(class1.method_0));
            }
        }

        [CompilerGenerated]
        private struct Struct37 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            private List<ProfileElement>.Enumerator enumerator_0;
            public IfTag ifTag_0;
            public int int_0;
            private ProfileElement profileElement_0;
            private TaskAwaiter taskAwaiter_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    if ((num != 0) && (num != 1))
                    {
                        if (!this.ifTag_0.Condition)
                        {
                            goto Label_016F;
                        }
                        this.enumerator_0 = this.ifTag_0.Children.GetEnumerator();
                    }
                    try
                    {
                        TaskAwaiter awaiter;
                        if (num != 0)
                        {
                            if (num != 1)
                            {
                                goto Label_0092;
                            }
                            awaiter = this.taskAwaiter_0;
                            this.taskAwaiter_0 = new TaskAwaiter();
                            num = -1;
                            this.int_0 = -1;
                        }
                        else
                        {
                            awaiter = this.taskAwaiter_0;
                            this.taskAwaiter_0 = new TaskAwaiter();
                            num = -1;
                            this.int_0 = -1;
                            goto Label_00E5;
                        }
                    Label_007A:
                        awaiter.GetResult();
                        awaiter = new TaskAwaiter();
                        while (this.profileElement_0.IsFinished)
                        {
                            this.profileElement_0 = null;
                        Label_0092:
                            if (!this.enumerator_0.MoveNext())
                            {
                                goto Label_0163;
                            }
                            this.profileElement_0 = this.enumerator_0.Current;
                            this.profileElement_0.Reset();
                        }
                        awaiter = this.profileElement_0.ProfileTagLogic().GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            goto Label_012D;
                        }
                    Label_00E5:
                        awaiter.GetResult();
                        awaiter = new TaskAwaiter();
                        awaiter = Coroutine.Yield().GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto Label_007A;
                        }
                        num = 1;
                        this.int_0 = 1;
                        this.taskAwaiter_0 = awaiter;
                        this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, IfTag.Struct37>(ref awaiter, ref this);
                        return;
                    Label_012D:
                        num = 0;
                        this.int_0 = 0;
                        this.taskAwaiter_0 = awaiter;
                        this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, IfTag.Struct37>(ref awaiter, ref this);
                        return;
                    }
                    finally
                    {
                        if (num < 0)
                        {
                            this.enumerator_0.Dispose();
                        }
                    }
                Label_0163:
                    this.enumerator_0 = new List<ProfileElement>.Enumerator();
                Label_016F:
                    this.ifTag_0.bool_0 = true;
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                    return;
                }
                this.int_0 = -2;
                this.asyncTaskMethodBuilder_0.SetResult();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
            }
        }

        [CompilerGenerated]
        private struct Struct38 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            public IfTag ifTag_0;
            public int int_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    Coroutine[] coroutineArray2;
                    int num2;
                    Coroutine[] coroutineArray = this.ifTag_0.Children.Select<ProfileElement, Coroutine>((IfTag.Class216.<>9__14_0 ?? (IfTag.Class216.<>9__14_0 = new Func<ProfileElement, Coroutine>(IfTag.Class216.<>9.method_0)))).ToArray<Coroutine>();
                    try
                    {
                        while (this.ifTag_0.Condition)
                        {
                            bool flag = false;
                            coroutineArray2 = coroutineArray;
                            for (num2 = 0; num2 < coroutineArray2.Length; num2++)
                            {
                                Coroutine coroutine = coroutineArray2[num2];
                                if (!coroutine.IsFinished)
                                {
                                    coroutine.Resume();
                                    flag = true;
                                }
                            }
                            if (!flag)
                            {
                                goto Label_00BC;
                            }
                        }
                    }
                    finally
                    {
                        if (num < 0)
                        {
                            coroutineArray2 = coroutineArray;
                            for (num2 = 0; num2 < coroutineArray2.Length; num2++)
                            {
                                coroutineArray2[num2].Dispose();
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                    return;
                }
            Label_00BC:
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

