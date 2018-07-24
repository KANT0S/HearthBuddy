namespace Triton.Bot.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [ProfileElementName("Switch"), XmlRoot("Switch")]
    public class SwitchTag : ProfileGroupElement
    {
        private bool bool_0;
        private Func<string> func_0;
        [CompilerGenerated]
        private List<SwitchArgument> list_1;
        private string string_0;
        private SwitchArgument switchArgument_0;

        private void method_0()
        {
            string condition = this.Condition;
            using (List<SwitchArgument>.Enumerator enumerator = this.Arguments.GetEnumerator())
            {
                SwitchArgument current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (current.Value == condition)
                    {
                        goto Label_0037;
                    }
                }
                goto Label_004E;
            Label_0037:
                this.switchArgument_0 = current;
            }
        Label_004E:
            if (this.switchArgument_0 == null)
            {
                throw new Exception("Switch argument does not contain a matching value! Current condition: " + this.ConditionString + " => " + condition);
            }
        }

        [AsyncStateMachine(typeof(ref G>\.Y7^@i4W=XoH(\[)dV-d_Xx\))]
        public override Task ProfileTagLogic()
        {
            Struct41 struct2;
            struct2.switchTag_0 = this;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct41>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        public override void Reset()
        {
            base.Reset();
            this.bool_0 = false;
        }

        [XmlElement("Arg")]
        public List<SwitchArgument> Arguments
        {
            [CompilerGenerated]
            get
            {
                return this.list_1;
            }
            [CompilerGenerated]
            set
            {
                this.list_1 = value;
            }
        }

        public override string Author
        {
            get
            {
                return "Bossland GmbH";
            }
        }

        [XmlIgnore]
        public string Condition
        {
            get
            {
                return this.func_0();
            }
        }

        [XmlAttribute("Condition")]
        public string ConditionString
        {
            get
            {
                return this.string_0;
            }
            set
            {
                if (value != this.string_0)
                {
                    this.string_0 = value;
                    this.func_0 = ProfileScripting.GetCondition<string>("str(" + value + ")");
                }
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
                return "Switch";
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
        private struct Struct41 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            private List<ProfileElement>.Enumerator enumerator_0;
            public int int_0;
            public SwitchTag switchTag_0;
            private TaskAwaiter taskAwaiter_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    if (num != 0)
                    {
                        this.switchTag_0.method_0();
                        this.enumerator_0 = this.switchTag_0.switchArgument_0.Children.GetEnumerator();
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
                            goto Label_0084;
                        }
                    Label_0052:
                        if (!this.enumerator_0.MoveNext())
                        {
                            goto Label_00CD;
                        }
                        ProfileElement current = this.enumerator_0.Current;
                        current.Reset();
                        awaiter = current.ProfileTagLogic().GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            goto Label_0097;
                        }
                    Label_0084:
                        awaiter.GetResult();
                        awaiter = new TaskAwaiter();
                        goto Label_0052;
                    Label_0097:
                        num = 0;
                        this.int_0 = 0;
                        this.taskAwaiter_0 = awaiter;
                        this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, SwitchTag.Struct41>(ref awaiter, ref this);
                        return;
                    }
                    finally
                    {
                        if (num < 0)
                        {
                            this.enumerator_0.Dispose();
                        }
                    }
                Label_00CD:
                    this.enumerator_0 = new List<ProfileElement>.Enumerator();
                    this.switchTag_0.bool_0 = true;
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

        public class SwitchArgument
        {
            [CompilerGenerated]
            private List<ProfileElement> list_0;
            [CompilerGenerated]
            private string string_0;

            public List<ProfileElement> Children
            {
                [CompilerGenerated]
                get
                {
                    return this.list_0;
                }
                [CompilerGenerated]
                set
                {
                    this.list_0 = value;
                }
            }

            [XmlAttribute("Value")]
            public string Value
            {
                [CompilerGenerated]
                get
                {
                    return this.string_0;
                }
                [CompilerGenerated]
                set
                {
                    this.string_0 = value;
                }
            }
        }
    }
}

