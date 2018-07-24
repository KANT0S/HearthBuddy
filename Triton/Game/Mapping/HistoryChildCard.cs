namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HistoryChildCard")]
    public class HistoryChildCard : HistoryItem
    {
        public HistoryChildCard(IntPtr address) : this(address, "HistoryChildCard")
        {
        }

        public HistoryChildCard(IntPtr address, string className) : base(address, className)
        {
        }

        public void LoadActor()
        {
            base.method_8("LoadActor", Array.Empty<object>());
        }

        public void LoadActorCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadActorCallback", objArray1);
        }

        public void SetCardInfo(Triton.Game.Mapping.Entity entity, Texture bigTexture, int splatAmount, bool isDead, Material goldenMaterial)
        {
            object[] objArray1 = new object[] { entity, bigTexture, splatAmount, isDead, goldenMaterial };
            base.method_8("SetCardInfo", objArray1);
        }
    }
}

