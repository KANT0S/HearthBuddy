namespace Triton.Game.Mapping
{
    using System;
    using Triton.Game.Mono;

    public class TypeWrapper : MonoClass
    {
        public TypeWrapper(IntPtr address) : base(address, "TypeWrapper")
        {
        }
    }
}

