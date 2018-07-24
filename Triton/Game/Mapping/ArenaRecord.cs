namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ArenaRecord
    {
        public int wins;
        public int losses;
        public bool isFinished;
        public static ArenaRecord Invalid;
    }
}

