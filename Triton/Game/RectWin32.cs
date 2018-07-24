namespace Triton.Game
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct RectWin32
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
        public bool Within(int x, int y)
        {
            return ((((x > this.Left) && (x < this.Right)) && (y > this.Top)) && (y < this.Bottom));
        }

        public override string ToString()
        {
            object[] args = new object[] { this.Left, this.Top, this.Right, this.Bottom };
            return string.Format("Left: {0}, Top: {1}, Right: {2}, Bottom: {3}", args);
        }
    }
}

