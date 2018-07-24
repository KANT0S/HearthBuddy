namespace Triton.Bot
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using Triton.Bot.Settings;

    public class TaskManager
    {
        private bool bool_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private readonly List<ITask> list_0 = new List<ITask>();

        public bool Add(ITask task)
        {
            Class208 class2 = new Class208 {
                itask_0 = task
            };
            if (class2.itask_0 == null)
            {
                throw new ArgumentNullException("task");
            }
            if (this.IsFrozen)
            {
                ilog_0.ErrorFormat("[Add] This TaskManager is frozen.", Array.Empty<object>());
                return false;
            }
            if (this.list_0.Any<ITask>(new Func<ITask, bool>(class2.method_0)))
            {
                ilog_0.ErrorFormat("[Add] A task with the name of {0} has already been added. This one will be skipped.", class2.itask_0.Name);
                return false;
            }
            ilog_0.DebugFormat("[Add] Now adding [{0}] {1}.", class2.itask_0.Name, class2.itask_0.Description);
            this.list_0.Add(class2.itask_0);
            return true;
        }

        public bool AddAfter(ITask task, string name)
        {
            Class207 class2 = new Class207 {
                itask_0 = task
            };
            if (class2.itask_0 == null)
            {
                throw new ArgumentNullException("task");
            }
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (this.IsFrozen)
            {
                ilog_0.ErrorFormat("[AddAfter] This TaskManager is frozen.", Array.Empty<object>());
                return false;
            }
            if (this.list_0.Any<ITask>(new Func<ITask, bool>(class2.method_0)))
            {
                ilog_0.ErrorFormat("[AddAfter] A task with the name of {0} has already been added. This one will be skipped.", class2.itask_0.Name);
                return false;
            }
            for (int i = 0; i < this.list_0.Count; i++)
            {
                if (this.list_0[i].Name == name)
                {
                    this.list_0.Insert(i + 1, class2.itask_0);
                    return true;
                }
            }
            return false;
        }

        public bool AddAtFront(ITask task)
        {
            Class209 class2 = new Class209 {
                itask_0 = task
            };
            if (class2.itask_0 == null)
            {
                throw new ArgumentNullException("task");
            }
            if (this.IsFrozen)
            {
                ilog_0.ErrorFormat("[AddAtFront] This TaskManager is frozen.", Array.Empty<object>());
                return false;
            }
            if (this.list_0.Any<ITask>(new Func<ITask, bool>(class2.method_0)))
            {
                ilog_0.ErrorFormat("[AddAtFront] A task with the name of {0} has already been added. This one will be skipped.", class2.itask_0.Name);
                return false;
            }
            ilog_0.DebugFormat("[AddAtFront] Now adding [{0}] {1}.", class2.itask_0.Name, class2.itask_0.Description);
            this.list_0.Insert(0, class2.itask_0);
            return true;
        }

        public bool AddBefore(ITask task, string name)
        {
            Class206 class2 = new Class206 {
                itask_0 = task
            };
            if (class2.itask_0 == null)
            {
                throw new ArgumentNullException("task");
            }
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (this.IsFrozen)
            {
                ilog_0.ErrorFormat("[AddBefore] This TaskManager is frozen.", Array.Empty<object>());
                return false;
            }
            if (this.list_0.Any<ITask>(new Func<ITask, bool>(class2.method_0)))
            {
                ilog_0.ErrorFormat("[AddBefore] A task with the name of {0} has already been added. This one will be skipped.", class2.itask_0.Name);
                return false;
            }
            for (int i = 0; i < this.list_0.Count; i++)
            {
                if (this.list_0[i].Name == name)
                {
                    this.list_0.Insert(i, class2.itask_0);
                    return true;
                }
            }
            return false;
        }

        [AsyncStateMachine(typeof(Struct35))]
        public Task<bool> Execute(string type, [Dynamic(new bool[] { false, true })] params object[] param)
        {
            Struct35 struct2;
            struct2.taskManager_0 = this;
            struct2.string_0 = type;
            struct2.object_0 = param;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct35>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        public void Freeze()
        {
            this.bool_0 = true;
        }

        public ITask GetTaskByName(string name)
        {
            Class211 class2 = new Class211 {
                string_0 = name
            };
            return this.list_0.FirstOrDefault<ITask>(new Func<ITask, bool>(class2.method_0));
        }

        public bool Remove(string name)
        {
            Class210 class2 = new Class210 {
                string_0 = name
            };
            if (class2.string_0 == null)
            {
                throw new ArgumentNullException("name");
            }
            if (this.IsFrozen)
            {
                ilog_0.ErrorFormat("[Remove] This TaskManager is frozen.", Array.Empty<object>());
                return false;
            }
            ITask item = this.list_0.FirstOrDefault<ITask>(new Func<ITask, bool>(class2.method_0));
            if (item == null)
            {
                ilog_0.ErrorFormat("[Remove] A task with the name of {0} does not exist.", class2.string_0);
                return false;
            }
            ilog_0.DebugFormat("[Remove] Now removing [{0}].", item.Name);
            this.list_0.Remove(item);
            return true;
        }

        public bool Replace(string name, ITask task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("task");
            }
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (this.IsFrozen)
            {
                ilog_0.ErrorFormat("[Replace] This TaskManager is frozen.", Array.Empty<object>());
                return false;
            }
            for (int i = 0; i < this.list_0.Count; i++)
            {
                if (this.list_0[i].Name == name)
                {
                    for (int j = 0; j < this.list_0.Count; j++)
                    {
                        if ((j != i) && (this.list_0[j].Name == task.Name))
                        {
                            ilog_0.ErrorFormat("[Replace] A task with the name of {0} has already been registered.", task.Name);
                            return false;
                        }
                    }
                    ilog_0.DebugFormat("[Replace] Now replacing task [{0}] with [{1}].", name, task.Name);
                    this.list_0[i] = task;
                    return true;
                }
            }
            ilog_0.ErrorFormat("[Replace] A task with the name of {0} was not found.", name);
            return false;
        }

        public void Reset()
        {
            this.list_0.Clear();
            this.bool_0 = false;
        }

        public void Start()
        {
            using (List<ITask>.Enumerator enumerator = this.list_0.ToList<ITask>().GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    enumerator.Current.Start();
                }
            }
        }

        public void Stop()
        {
            using (List<ITask>.Enumerator enumerator = this.list_0.ToList<ITask>().GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    enumerator.Current.Stop();
                }
            }
        }

        public bool SwapTasks(string name1, string name2)
        {
            if (name1 == null)
            {
                throw new ArgumentNullException("name1");
            }
            if (name2 == null)
            {
                throw new ArgumentNullException("name2");
            }
            if (this.IsFrozen)
            {
                ilog_0.ErrorFormat("[SwapTasks] This TaskManager is frozen.", Array.Empty<object>());
                return false;
            }
            int num = -1;
            int num2 = -1;
            for (int i = 0; i < this.list_0.Count; i++)
            {
                if ((num != -1) || (num2 != -1))
                {
                    break;
                }
                if (this.list_0[i].Name == name1)
                {
                    num = i;
                }
                else if (this.list_0[i].Name == name2)
                {
                    num2 = i;
                }
            }
            if (((num != -1) && (num2 != -1)) && (num != num2))
            {
                ITask task = this.list_0[num];
                this.list_0[num] = this.list_0[num2];
                this.list_0[num2] = task;
                return true;
            }
            ilog_0.ErrorFormat("[SwapTasks] A task could not be found, or both tasks are the same.", Array.Empty<object>());
            return false;
        }

        public void Tick()
        {
            using (List<ITask>.Enumerator enumerator = this.list_0.ToList<ITask>().GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    enumerator.Current.Tick();
                }
            }
        }

        public bool IsFrozen
        {
            get
            {
                return this.bool_0;
            }
        }

        public List<ITask> TaskList
        {
            get
            {
                return this.list_0.ToList<ITask>();
            }
        }

        [CompilerGenerated]
        private sealed class Class206
        {
            public ITask itask_0;

            internal bool method_0(ITask itask_1)
            {
                return (itask_1.Name == this.itask_0.Name);
            }
        }

        [CompilerGenerated]
        private sealed class Class207
        {
            public ITask itask_0;

            internal bool method_0(ITask itask_1)
            {
                return (itask_1.Name == this.itask_0.Name);
            }
        }

        [CompilerGenerated]
        private sealed class Class208
        {
            public ITask itask_0;

            internal bool method_0(ITask itask_1)
            {
                return (itask_1.Name == this.itask_0.Name);
            }
        }

        [CompilerGenerated]
        private sealed class Class209
        {
            public ITask itask_0;

            internal bool method_0(ITask itask_1)
            {
                return (itask_1.Name == this.itask_0.Name);
            }
        }

        [CompilerGenerated]
        private sealed class Class210
        {
            public string string_0;

            internal bool method_0(ITask itask_0)
            {
                return (itask_0.Name == this.string_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class211
        {
            public string string_0;

            internal bool method_0(ITask itask_0)
            {
                return (itask_0.Name == this.string_0);
            }
        }

        [CompilerGenerated]
        private struct Struct35 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;
            private bool bool_0;
            private bool bool_1;
            private List<ITask>.Enumerator enumerator_0;
            public int int_0;
            private ITask itask_0;
            private List<ITask> list_0;
            public object[] object_0;
            public string string_0;
            private TaskAwaiter<bool> taskAwaiter_0;
            public TaskManager taskManager_0;

            private void MoveNext()
            {
                bool flag;
                int num = this.int_0;
                try
                {
                    if (num != 0)
                    {
                        this.bool_0 = this.string_0.EndsWith("_event");
                        this.bool_1 = false;
                        this.list_0 = this.taskManager_0.list_0.ToList<ITask>();
                        this.enumerator_0 = this.list_0.GetEnumerator();
                    }
                    try
                    {
                        if (num != 0)
                        {
                            goto Label_0077;
                        }
                        TaskAwaiter<bool> awaiter = this.taskAwaiter_0;
                        this.taskAwaiter_0 = new TaskAwaiter<bool>();
                        num = -1;
                        this.int_0 = -1;
                        goto Label_00D4;
                    Label_0070:
                        this.itask_0 = null;
                    Label_0077:
                        if (!this.enumerator_0.MoveNext())
                        {
                            goto Label_01A8;
                        }
                        this.itask_0 = this.enumerator_0.Current;
                        awaiter = this.itask_0.Logic(this.string_0, this.object_0).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto Label_00D4;
                        }
                        goto Label_0172;
                    Label_00C3:
                        if (!this.bool_0)
                        {
                            goto Label_00E7;
                        }
                        this.bool_1 = true;
                        goto Label_0070;
                    Label_00D4:
                        bool introduced7 = awaiter.GetResult();
                        awaiter = new TaskAwaiter<bool>();
                        if (!introduced7)
                        {
                            goto Label_0070;
                        }
                        goto Label_00C3;
                    Label_00E7:
                        if (!GlobalSettings.Instance.DebugLastTask)
                        {
                            goto Label_016C;
                        }
                        StringBuilder builder = new StringBuilder();
                        List<ITask>.Enumerator enumerator = this.list_0.GetEnumerator();
                        try
                        {
                            while (enumerator.MoveNext())
                            {
                                ITask current = enumerator.Current;
                                if (current == this.itask_0)
                                {
                                    goto Label_014C;
                                }
                                builder.AppendFormat("[{0}] -> ", current.Name);
                            }
                        }
                        finally
                        {
                            if (num < 0)
                            {
                                enumerator.Dispose();
                            }
                        }
                    Label_014C:
                        TaskManager.ilog_0.InfoFormat("[Execute] {1} {0}.", this.itask_0.Name, builder.ToString());
                    Label_016C:
                        flag = true;
                        goto Label_01D6;
                    Label_0172:
                        num = 0;
                        this.int_0 = 0;
                        this.taskAwaiter_0 = awaiter;
                        this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, TaskManager.Struct35>(ref awaiter, ref this);
                        return;
                    }
                    finally
                    {
                        if (num < 0)
                        {
                            this.enumerator_0.Dispose();
                        }
                    }
                Label_01A8:
                    this.enumerator_0 = new List<ITask>.Enumerator();
                    flag = this.bool_1;
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                    return;
                }
            Label_01D6:
                this.int_0 = -2;
                this.asyncTaskMethodBuilder_0.SetResult(flag);
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
            }
        }
    }
}

