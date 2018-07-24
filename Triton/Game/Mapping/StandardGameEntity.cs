namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("StandardGameEntity")]
    public class StandardGameEntity : GameEntity
    {
        public StandardGameEntity(IntPtr address) : this(address, "StandardGameEntity")
        {
        }

        public StandardGameEntity(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnTagChanged(TagDelta change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnTagChanged", objArray1);
        }
    }
}

