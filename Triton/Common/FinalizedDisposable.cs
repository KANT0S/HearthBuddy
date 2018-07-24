namespace Triton.Common
{
    using System;

    public abstract class FinalizedDisposable : IDisposable
    {
        private bool bool_0;

        protected FinalizedDisposable()
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

        ~FinalizedDisposable()
        {
            this.Dispose(false);
        }

        public abstract void ManagedDisposed();
        public abstract void UnmanagedDisposed();
    }
}

