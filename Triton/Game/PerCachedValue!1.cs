namespace Triton.Game
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public abstract class PerCachedValue<T>
    {
        private bool bool_0;
        private readonly Func<T> func_0;
        private T gparam_0;

        [field: CompilerGenerated]
        public event EventHandler<CacheUpdateEvent> OnCacheUpdate;

        protected PerCachedValue(Func<T> producer)
        {
            if (producer == null)
            {
                throw new ArgumentNullException("producer");
            }
            this.func_0 = producer;
        }

        public static implicit operator T(PerCachedValue<T> pfcv)
        {
            return pfcv.Value;
        }

        public void RequestCacheFlush()
        {
            this.bool_0 = true;
        }

        protected abstract bool ShouldUpdateCache(bool force);

        public T Value
        {
            get
            {
                if (!TritonHs.Memory.Executor.IsInsideHook)
                {
                    throw new InvalidOperationException("!IsInsideHook");
                }
                if (this.ShouldUpdateCache(this.bool_0))
                {
                    this.bool_0 = false;
                    this.gparam_0 = this.func_0();
                    if (this.eventHandler_0 != null)
                    {
                        Delegate[] invocationList = this.eventHandler_0.GetInvocationList();
                        for (int i = 0; i < invocationList.Length; i++)
                        {
                            object[] args = new object[2];
                            args[1] = new CacheUpdateEvent();
                            invocationList[i].DynamicInvoke(args);
                        }
                    }
                }
                return this.gparam_0;
            }
        }
    }
}

