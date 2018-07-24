namespace Triton.Game
{
    using System;

    public class PerFrameCachedValue<T> : PerCachedValue<T>
    {
        private uint uint_0;

        public PerFrameCachedValue(Func<T> producer) : base(producer)
        {
            this.uint_0 = uint.MaxValue;
        }

        protected override bool ShouldUpdateCache(bool force)
        {
            uint frameCount = TritonHs.Memory.Executor.FrameCount;
            if ((this.uint_0 != frameCount) | force)
            {
                this.uint_0 = frameCount;
                return true;
            }
            return false;
        }
    }
}

