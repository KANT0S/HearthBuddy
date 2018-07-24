namespace Triton.Common
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    public class PerformanceTimer : IDisposable
    {
        private bool bool_0;
        private readonly FinishedMeasuringCallback finishedMeasuringCallback_0;
        private readonly Stopwatch stopwatch_0;
        private readonly string string_0;

        public PerformanceTimer(string debugText, FinishedMeasuringCallback callback = null)
        {
            this.finishedMeasuringCallback_0 = callback;
            this.stopwatch_0 = new Stopwatch();
            this.string_0 = debugText;
        }

        public void Dispose()
        {
        }

        public void DontPrint()
        {
            this.bool_0 = true;
        }

        [Conditional("TIMERS")]
        private void method_0()
        {
            this.Start();
        }

        [Conditional("TIMERS")]
        private void method_1()
        {
            this.StopAndPrint();
        }

        public void Start()
        {
            this.stopwatch_0.Start();
        }

        public void StopAndPrint()
        {
            this.stopwatch_0.Stop();
            if (!this.bool_0)
            {
                Trace.WriteLine(string.Format("[{0}ms] {1}", this.stopwatch_0.Elapsed.TotalMilliseconds, this.string_0));
                if (this.finishedMeasuringCallback_0 != null)
                {
                    this.finishedMeasuringCallback_0.BeginInvoke(this.ElapsedMilliseconds, null, null);
                }
            }
        }

        public long ElapsedMilliseconds
        {
            get
            {
                return this.stopwatch_0.ElapsedMilliseconds;
            }
        }
    }
}

