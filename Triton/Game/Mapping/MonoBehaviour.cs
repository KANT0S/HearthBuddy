namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MonoBehaviour")]
    public class MonoBehaviour : Behaviour
    {
        public MonoBehaviour(IntPtr address) : base(address, "MonoBehaviour")
        {
        }

        public MonoBehaviour(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

