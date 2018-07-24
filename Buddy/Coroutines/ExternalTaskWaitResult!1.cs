namespace Buddy.Coroutines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ExternalTaskWaitResult<T>
    {
        internal static readonly ExternalTaskWaitResult<T> externalTaskWaitResult_0;
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private T gparam_0;
        public bool Completed
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_0 = value;
            }
        }
        public T Result
        {
            [CompilerGenerated]
            get
            {
                return this.gparam_0;
            }
            [CompilerGenerated]
            private set
            {
                this.gparam_0 = value;
            }
        }
        internal static ExternalTaskWaitResult<T> smethod_0(T gparam_1)
        {
            return new ExternalTaskWaitResult<T> { Result = gparam_1, Completed = true };
        }

        static ExternalTaskWaitResult()
        {
            ExternalTaskWaitResult<T>.externalTaskWaitResult_0 = new ExternalTaskWaitResult<T>();
        }
    }
}

