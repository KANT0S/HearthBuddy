namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RarityGem")]
    public class RarityGem : MonoBehaviour
    {
        public RarityGem(IntPtr address) : this(address, "RarityGem")
        {
        }

        public RarityGem(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetRarityGem(TAG_RARITY rarity, TAG_CARD_SET cardSet)
        {
            object[] objArray1 = new object[] { rarity, cardSet };
            base.method_8("SetRarityGem", objArray1);
        }
    }
}

