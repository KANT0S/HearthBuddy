namespace Triton.Game.Mapping
{
    using GreyMagic;
    using System;
    using System.Runtime.InteropServices;
    using Triton.Game.Mono;

    public static class OutExtensions
    {
        public static bool GetInputHitInfo(UniversalInputManager uim, out RaycastHit hitInfo)
        {
            object outLock = MonoClass.OutLock;
            lock (outLock)
            {
                RaycastHit hit = new RaycastHit();
                MonoClass.ResetOutParams();
                MonoClass.SetOutParam(0, MarshalCache<RaycastHit>.Size);
                object[] objArray1 = new object[] { hit };
                hitInfo = MonoClass.ReadOutParam<RaycastHit>(0);
                MonoClass.ResetOutParams();
                return uim.method_11<bool>("GetInputHitInfo", objArray1);
            }
        }
    }
}

