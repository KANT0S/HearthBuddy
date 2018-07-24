namespace Triton.Bot.Profiles
{
    using Buddy.Coroutines;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("While"), ProfileElementName("While")]
    public class WhileTag : ConditionalProfileGroupElement
    {
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;

        [AsyncStateMachine(typeof(Struct40))]
        private Task method_0()
        {
            Struct40 struct2;
            struct2.whileTag_0 = this;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct40>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        [AsyncStateMachine(typeof(#{\&NI=J"M\*~puk\\?kr\*;CI!|$))]
        public override Task ProfileTagLogic()
        {
            Struct39 struct2;
            struct2.whileTag_0 = this;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct39>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        public override void Reset()
        {
            base.Reset();
            this.bool_0 = false;
        }

        [XmlIgnore]
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

        [XmlAttribute("ExitImmediately")]
        public bool ExitImmediately
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

        [XmlIgnore]
        public override bool IsFinished
        {
            get
            {
                return this.bool_0;
            }
        }

        [XmlIgnore]
        public override string Name
        {
            get
            {
                return "While";
            }
        }

        [XmlIgnore]
        public override string Version
        {
            get
            {
                return "1.0.0.0";
            }
        }

        [CompilerGenerated]
        private sealed class Class217
        {
            public ProfileElement profileElement_0;

            internal Task method_0()
            {
                return this.profileElement_0.ProfileTagLogic();
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class218
        {
            public static readonly WhileTag.Class218 <>9 = new WhileTag.Class218();
            public static Func<ProfileElement, Coroutine> <>9__17_0;

            internal Coroutine method_0(ProfileElement profileElement_0)
            {
                WhileTag.Class217 class1 = new WhileTag.Class217 {
                    profileElement_0 = profileElement_0
                };
                return new Coroutine(new Func<Task>(class1.method_0));
            }
        }

        [CompilerGenerated]
        private struct Struct39 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            private List<ProfileElement>.Enumerator enumerator_0;
            public int int_0;
            private ProfileElement profileElement_0;
            private TaskAwaiter taskAwaiter_0;
            public WhileTag whileTag_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    TaskAwaiter awaiter;
                    switch (num)
                    {
                        case 0:
                            break;

                        case 1:
                        case 2:
                            goto Label_00F1;

                        case 3:
                            goto Label_00A6;

                        default:
                            if (!this.whileTag_0.ExitImmediately)
                            {
                                goto Label_0244;
                            }
                            awaiter = this.whileTag_0.method_0().GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto Label_0086;
                            }
                            num = 0;
                            this.int_0 = 0;
                            this.taskAwaiter_0 = awaiter;
                            this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, WhileTag.Struct39>(ref awaiter, ref this);
                            return;
                    }
                    awaiter = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                Label_0086:
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                    this.whileTag_0.bool_0 = true;
                    goto Label_02BA;
                Label_00A6:
                    awaiter = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                Label_00C2:
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                Label_0244:
                    while (this.whileTag_0.Condition)
                    {
                        this.enumerator_0 = this.whileTag_0.Children.GetEnumerator();
                    Label_00F1:
                        try
                        {
                            if (num != 1)
                            {
                                if (num != 2)
                                {
                                    goto Label_014F;
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
                                goto Label_01A2;
                            }
                        Label_0137:
                            awaiter.GetResult();
                            awaiter = new TaskAwaiter();
                            while (this.profileElement_0.IsFinished)
                            {
                                this.profileElement_0 = null;
                            Label_014F:
                                if (!this.enumerator_0.MoveNext())
                                {
                                    goto Label_0226;
                                }
                                this.profileElement_0 = this.enumerator_0.Current;
                                this.profileElement_0.Reset();
                            }
                            awaiter = this.profileElement_0.ProfileTagLogic().GetAwaiter();
                            if (!awaiter.IsCompleted)
                            {
                                goto Label_01ED;
                            }
                        Label_01A2:
                            awaiter.GetResult();
                            awaiter = new TaskAwaiter();
                            awaiter = Coroutine.Yield().GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto Label_0137;
                            }
                            num = 2;
                            this.int_0 = 2;
                            this.taskAwaiter_0 = awaiter;
                            this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, WhileTag.Struct39>(ref awaiter, ref this);
                            return;
                        Label_01ED:
                            num = 1;
                            this.int_0 = 1;
                            this.taskAwaiter_0 = awaiter;
                            this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, WhileTag.Struct39>(ref awaiter, ref this);
                            return;
                        }
                        finally
                        {
                            if (num < 0)
                            {
                                this.enumerator_0.Dispose();
                            }
                        }
                    Label_0226:
                        this.enumerator_0 = new List<ProfileElement>.Enumerator();
                        if (this.whileTag_0.Children.Count == 0)
                        {
                            goto Label_0256;
                        }
                    }
                    goto Label_0275;
                Label_0256:
                    awaiter = Coroutine.Yield().GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto Label_00C2;
                    }
                    goto Label_0283;
                Label_0275:
                    this.whileTag_0.bool_0 = true;
                    goto Label_02BA;
                Label_0283:
                    num = 3;
                    this.int_0 = 3;
                    this.taskAwaiter_0 = awaiter;
                    this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, WhileTag.Struct39>(ref awaiter, ref this);
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                }
                return;
            Label_02BA:
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
        private struct Struct40 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            public int int_0;
            public WhileTag whileTag_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    Coroutine[] coroutineArray2;
                    int num2;
                    Coroutine[] coroutineArray = this.whileTag_0.Children.Select<ProfileElement, Coroutine>((WhileTag.Class218.<>9__17_0 ?? (WhileTag.Class218.<>9__17_0 = new Func<ProfileElement, Coroutine>(WhileTag.Class218.<>9.method_0)))).ToArray<Coroutine>();
                    try
                    {
                        while (this.whileTag_0.Condition)
                        {
                            List<ProfileElement>.Enumerator enumerator = this.whileTag_0.Children.GetEnumerator();
                            try
                            {
                                while (enumerator.MoveNext())
                                {
                                    enumerator.Current.Reset();
                                }
                            }
                            finally
                            {
                                if (num < 0)
                                {
                                    enumerator.Dispose();
                                }
                            }
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
                                goto Label_00FF;
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
            Label_00FF:
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

