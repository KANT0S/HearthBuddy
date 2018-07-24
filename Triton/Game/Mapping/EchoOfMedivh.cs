namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("EchoOfMedivh")]
    public class EchoOfMedivh : SpawnToHandSpell
    {
        public EchoOfMedivh(IntPtr address) : this(address, "EchoOfMedivh")
        {
        }

        public EchoOfMedivh(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetCardIdForTarget(int targetIndex)
        {
            object[] objArray1 = new object[] { targetIndex };
            return base.method_13("GetCardIdForTarget", objArray1);
        }

        public Vector3 GetOriginForTarget(int targetIndex)
        {
            object[] objArray1 = new object[] { targetIndex };
            return base.method_11<Vector3>("GetOriginForTarget", objArray1);
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }
    }
}

