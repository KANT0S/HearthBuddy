namespace Triton.Common
{
    using System;

    public abstract class NonFinalizedDisposable : IDisposable
    {
        private bool bool_0;

        protected NonFinalizedDisposable()
        {
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.bool_0)
            {
                if (disposing)
                {
                    this.ManagedDisposed();
                }
                this.UnmanagedDisposed();
                this.bool_0 = true;
            }
        }

        public abstract void ManagedDisposed();
        public abstract void UnmanagedDisposed();
    }
}

