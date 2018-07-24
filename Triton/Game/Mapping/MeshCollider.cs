namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MeshCollider")]
    public class MeshCollider : Collider
    {
        public MeshCollider(IntPtr address) : base(address, "MeshCollider")
        {
        }
    }
}

