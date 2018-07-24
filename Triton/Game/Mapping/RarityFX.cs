namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct RarityFX
    {
        public GameObject burstFX;
        public GameObject explodeFX;
        public Material glowBallMat;
        public Material glowTrailMat;
    }
}

