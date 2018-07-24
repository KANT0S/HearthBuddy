namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("Enum")]
    public class MonoEnum : MonoClass
    {
        public MonoEnum(IntPtr address) : base(address, "Enum")
        {
        }

        public T AsEnum<T>()
        {
            return (T) Enum.Parse(typeof(T), this.ToString());
        }

        public override string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }
    }
}

