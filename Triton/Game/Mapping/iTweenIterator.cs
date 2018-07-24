namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct iTweenIterator
    {
        public iTweenCollection TweenCollection;
        public int Index;
    }
}

